﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibUsbDotNet;
using LibUsbDotNet.Info;
using LibUsbDotNet.Main;
using System.Collections.ObjectModel;
using System.Threading;

namespace Mata
{
    public partial class Form1 : Form
    {
        UsbReader reader = null;
        Thread readerThread = null;

        public Form1()
        {
            InitializeComponent();
            //showInfo();
            //readPolling();
            //readAsync();
            //readIso();
        }

        public void addText(string msg)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(addText), new object[] { msg });
                return;
            }
            textBox1.Text += msg;
        }

        public void setText(string msg)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(setText), new object[] { msg });
                return;
            }
            textBox1.Text = msg;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            reader = new UsbReader(this);
            readerThread = new Thread(new ThreadStart(reader.readPolling));
            reader.isRunning = true;
            readerThread.Start();
            while (!readerThread.IsAlive) ;
        }

        private void endButton_Click(object sender, EventArgs e)
        {
            if (reader != null)
            {
                reader.isRunning = false;
            }
        }

    }

    public class UsbReader 
    {
        public UsbDevice MyUsbDevice;
        public UsbDeviceFinder MyUsbFinder = new UsbDeviceFinder(3727, 53);
        /// <summary>Use the first read endpoint</summary>
        public readonly byte TRANFER_ENDPOINT = UsbConstants.ENDPOINT_DIR_MASK;

        /// <summary>Number of transfers to sumbit before waiting begins</summary>
        public static readonly int TRANFER_MAX_OUTSTANDING_IO = 3;

        /// <summary>Number of transfers before terminating the test</summary>
        public static readonly int TRANSFER_COUNT = 30;

        /// <summary>Size of each transfer</summary>
        public static int TRANFER_SIZE = 8;

        private static DateTime mStartTime = DateTime.MinValue;
        private static double mTotalBytes = 0.0;
        private static int mTransferCount = 0;

        private Form1 form;
        private ButtonReader buttonReader = new ButtonReader();
        public volatile bool isRunning = false;

        public UsbReader(Form1 form)
        {
            this.form = form;
        }

        public void setRunning(bool value)
        {
            isRunning = value;
        }

        public void showInfo()
        {
            // Dump all devices and descriptor information to console output.
            UsbRegDeviceList allDevices = UsbDevice.AllDevices;
            foreach (UsbRegistry usbRegistry in allDevices)
            {
                if (usbRegistry.Open(out MyUsbDevice))
                {
                    form.addText(MyUsbDevice.Info.ToString());
                    for (int iConfig = 0; iConfig < MyUsbDevice.Configs.Count; iConfig++)
                    {
                        UsbConfigInfo configInfo = MyUsbDevice.Configs[iConfig];
                        form.addText(configInfo.ToString());

                        ReadOnlyCollection<UsbInterfaceInfo> interfaceList = configInfo.InterfaceInfoList;
                        for (int iInterface = 0; iInterface < interfaceList.Count; iInterface++)
                        {
                            UsbInterfaceInfo interfaceInfo = interfaceList[iInterface];
                            form.addText(interfaceInfo.ToString());

                            ReadOnlyCollection<UsbEndpointInfo> endpointList = interfaceInfo.EndpointInfoList;
                            for (int iEndpoint = 0; iEndpoint < endpointList.Count; iEndpoint++)
                            {
                                form.addText(endpointList[iEndpoint].ToString());
                            }
                        }
                    }
                }
            }

            // Free usb resources.
            // This is necessary for libusb-1.0 and Linux compatibility.
            UsbDevice.Exit();
        }

        public void readPolling()
        {
            ErrorCode ec = ErrorCode.None;

            try
            {
                // Find and open the usb device.
                MyUsbDevice = UsbDevice.OpenUsbDevice(MyUsbFinder);

                // If the device is open and ready
                if (MyUsbDevice == null) throw new Exception("Device Not Found.");

                // If this is a "whole" usb device (libusb-win32, linux libusb-1.0)
                // it exposes an IUsbDevice interface. If not (WinUSB) the 
                // 'wholeUsbDevice' variable will be null indicating this is 
                // an interface of a device; it does not require or support 
                // configuration and interface selection.
                IUsbDevice wholeUsbDevice = MyUsbDevice as IUsbDevice;
                if (!ReferenceEquals(wholeUsbDevice, null))
                {
                    // This is a "whole" USB device. Before it can be used, 
                    // the desired configuration and interface must be selected.

                    // Select config #1
                    wholeUsbDevice.SetConfiguration(1);

                    // Claim interface #0.
                    wholeUsbDevice.ClaimInterface(0);
                }

                // open read endpoint 1.
                UsbEndpointReader reader = MyUsbDevice.OpenEndpointReader(ReadEndpointID.Ep01);


                byte[] readBuffer = new byte[8];
                while (isRunning && ec== ErrorCode.None)
                {
                    int bytesRead;

                    // If the device hasn't sent data in the last 5 seconds,
                    // a timeout error (ec = IoTimedOut) will occur. 
                    ec = reader.Read(readBuffer, 5000, out bytesRead);

                    if (bytesRead == 0) throw new Exception(string.Format("{0}:No more bytes!", ec));
                    //form.addText(bytesRead.ToString() + " bytes read");

                    form.addText("Data: "); //+ Encoding.Default.GetString(readBuffer, 0, transferredIn);
                    string read = "";
                    //for (int i = 0; i < readBuffer.Length; i++)
                    //{
                    //    read += string.Format("{0:X2} ", readBuffer[i]);
                        
                    //}
                    //form.setText(read);
                    //form.addText("\r\n");
                    string pressedButtons = "";
                    List<Mata.ButtonReader.PadButton> pressed = buttonReader.readButtons(readBuffer);
                    foreach(Mata.ButtonReader.PadButton b in pressed) {
                        pressedButtons += b.ToString() +  " ";
                    }
                    form.setText(pressedButtons);
                }

                form.addText("\r\nDone!\r\n");
            }
            catch (Exception ex)
            {
                form.addText("\r\n");
                form.addText((ec != ErrorCode.None ? ec + ":" : String.Empty) + ex.Message);
            }
            finally
            {
                if (MyUsbDevice != null)
                {
                    if (MyUsbDevice.IsOpen)
                    {
                        // If this is a "whole" usb device (libusb-win32, linux libusb-1.0)
                        // it exposes an IUsbDevice interface. If not (WinUSB) the 
                        // 'wholeUsbDevice' variable will be null indicating this is 
                        // an interface of a device; it does not require or support 
                        // configuration and interface selection.
                        IUsbDevice wholeUsbDevice = MyUsbDevice as IUsbDevice;
                        if (!ReferenceEquals(wholeUsbDevice, null))
                        {
                            // Release interface #0.
                            wholeUsbDevice.ReleaseInterface(0);
                        }

                        MyUsbDevice.Close();
                    }
                    MyUsbDevice = null;

                    // Free usb resources
                    UsbDevice.Exit();

                }
            }
        }

        public void readAsync()
        {
            ErrorCode ec = ErrorCode.None;
            try
            {
                // Find and open the usb device.
                MyUsbDevice = UsbDevice.OpenUsbDevice(MyUsbFinder);

                // If the device is open and ready
                if (MyUsbDevice == null) throw new Exception("Device Not Found.");

                // If this is a "whole" usb device (libusb-win32, linux libusb)
                // it will have an IUsbDevice interface. If not (WinUSB) the 
                // variable will be null indicating this is an interface of a 
                // device.
                IUsbDevice wholeUsbDevice = MyUsbDevice as IUsbDevice;
                if (!ReferenceEquals(wholeUsbDevice, null))
                {
                    // This is a "whole" USB device. Before it can be used, 
                    // the desired configuration and interface must be selected.

                    // Select config #1
                    wholeUsbDevice.SetConfiguration(1);

                    // Claim interface #0.
                    wholeUsbDevice.ClaimInterface(0);
                }

                // open read endpoint 1.
                UsbEndpointReader reader = MyUsbDevice.OpenEndpointReader(ReadEndpointID.Ep01);

                ErrorCode ecRead;
                int transferredIn;
                UsbTransfer usbReadTransfer;
                byte[] readBuffer = new byte[8];
                int testCount = 0;
                do
                {
                    // Create and submit transfer
                    ecRead = reader.SubmitAsyncTransfer(readBuffer, 0, readBuffer.Length, 100, out usbReadTransfer);
                    if (ecRead != ErrorCode.None) throw new Exception("Submit Async Read Failed.");

                    WaitHandle.WaitAll(new WaitHandle[] { usbReadTransfer.AsyncWaitHandle }, 200, false);
                    if (!usbReadTransfer.IsCompleted) usbReadTransfer.Cancel();

                    ecRead = usbReadTransfer.Wait(out transferredIn);

                    usbReadTransfer.Dispose();

                    form.addText(string.Format("Read  :{0} ErrorCode:{1}\r\n", transferredIn, ecRead));
                    form.addText("Data: "); //+ Encoding.Default.GetString(readBuffer, 0, transferredIn);
                    for (int i = 0; i < readBuffer.Length; i++)
                    {
                        form.addText(string.Format("{0:X2} ", readBuffer[i]));
                    }
                    form.addText("\r\n");

                    testCount++;
                } while (testCount < 5);
                form.addText("\r\nDone!\r\n");
            }
            catch (Exception ex)
            {
                form.addText("\r\n");
                form.addText((ec != ErrorCode.None ? ec + ":" : String.Empty) + ex.Message);
            }
            finally
            {
                if (MyUsbDevice != null)
                {
                    if (MyUsbDevice.IsOpen)
                    {
                        // If this is a "whole" usb device (libusb-win32, linux libusb-1.0)
                        // it exposes an IUsbDevice interface. If not (WinUSB) the 
                        // 'wholeUsbDevice' variable will be null indicating this is 
                        // an interface of a device; it does not require or support 
                        // configuration and interface selection.
                        IUsbDevice wholeUsbDevice = MyUsbDevice as IUsbDevice;
                        if (!ReferenceEquals(wholeUsbDevice, null))
                        {
                            // Release interface #0.
                            wholeUsbDevice.ReleaseInterface(0);
                        }

                        MyUsbDevice.Close();
                    }
                    MyUsbDevice = null;

                    // Free usb resources
                    UsbDevice.Exit();
                }
            }
        }

        public void readIso()
        {
            ErrorCode ec = ErrorCode.None;

            try
            {
                // Find and open the usb device.
                UsbRegDeviceList regList = UsbDevice.AllDevices.FindAll(MyUsbFinder);
                if (regList.Count == 0) throw new Exception("Device Not Found.");

                UsbInterfaceInfo usbInterfaceInfo = null;
                UsbEndpointInfo usbEndpointInfo = null;

                // Look through all conected devices with this vid and pid until
                // one is found that has and and endpoint that matches TRANFER_ENDPOINT.
                // 
                foreach (UsbRegistry regDevice in regList)
                {
                    if (regDevice.Open(out MyUsbDevice))
                    {
                        if (MyUsbDevice.Configs.Count > 0)
                        {
                            // if TRANFER_ENDPOINT is 0x80 or 0x00, LookupEndpointInfo will return the 
                            // first read or write (respectively).
                            if (UsbEndpointBase.LookupEndpointInfo(MyUsbDevice.Configs[0], TRANFER_ENDPOINT,
                                out usbInterfaceInfo, out usbEndpointInfo))
                                break;

                            MyUsbDevice.Close();
                            MyUsbDevice = null;
                        }
                    }
                }

                // If the device is open and ready
                if (MyUsbDevice == null) throw new Exception("Device Not Found.");

                // If this is a "whole" usb device (libusb-win32, linux libusb-1.0)
                // it exposes an IUsbDevice interface. If not (WinUSB) the 
                // 'wholeUsbDevice' variable will be null indicating this is 
                // an interface of a device; it does not require or support 
                // configuration and interface selection.
                IUsbDevice wholeUsbDevice = MyUsbDevice as IUsbDevice;
                if (!ReferenceEquals(wholeUsbDevice, null))
                {
                    // This is a "whole" USB device. Before it can be used, 
                    // the desired configuration and interface must be selected.

                    // Select config #1
                    wholeUsbDevice.SetConfiguration(1);

                    // Claim interface #0.
                    wholeUsbDevice.ClaimInterface(usbInterfaceInfo.Descriptor.InterfaceID);
                }

                // open read endpoint.
                UsbEndpointReader reader = MyUsbDevice.OpenEndpointReader(
                    (ReadEndpointID)usbEndpointInfo.Descriptor.EndpointID,
                    0,
                    (EndpointType)(usbEndpointInfo.Descriptor.Attributes & 0x3));

                if (ReferenceEquals(reader, null))
                {
                    throw new Exception("Failed locating read endpoint.");
                }

                reader.Reset();


                TRANFER_SIZE -= (TRANFER_SIZE % usbEndpointInfo.Descriptor.MaxPacketSize);

                UsbTransferQueue transferQeue = new UsbTransferQueue(reader,
                                                                     TRANFER_MAX_OUTSTANDING_IO,
                                                                     TRANFER_SIZE,
                                                                     5000,
                                                                     usbEndpointInfo.Descriptor.MaxPacketSize);

                do
                {
                    UsbTransferQueue.Handle handle;

                    // Begin submitting transfers until TRANFER_MAX_OUTSTANDING_IO has benn reached.
                    // then wait for the oldest outstanding transfer to complete.
                    // 
                    ec = transferQeue.Transfer(out handle);
                    if (ec != ErrorCode.Success)
                        throw new Exception("Failed getting async result");

                    // Show some information on the completed transfer.
                    showTransfer(handle, mTransferCount);
                } while (mTransferCount++ < TRANSFER_COUNT);

                // Cancels any oustanding transfers and free's the transfer queue handles.
                // NOTE: A transfer queue can be reused after it's freed.
                transferQeue.Free();

                form.addText("\r\nDone!\r\n");
            }
            catch (Exception ex)
            {
                form.addText("\r\n");
                form.addText((ec != ErrorCode.None ? ec + ":" : String.Empty) + ex.Message);
            }
            finally
            {
                if (MyUsbDevice != null)
                {
                    if (MyUsbDevice.IsOpen)
                    {
                        // If this is a "whole" usb device (libusb-win32, linux libusb-1.0)
                        // it exposes an IUsbDevice interface. If not (WinUSB) the 
                        // 'wholeUsbDevice' variable will be null indicating this is 
                        // an interface of a device; it does not require or support 
                        // configuration and interface selection.
                        IUsbDevice wholeUsbDevice = MyUsbDevice as IUsbDevice;
                        if (!ReferenceEquals(wholeUsbDevice, null))
                        {
                            // Release interface #0.
                            wholeUsbDevice.ReleaseInterface(0);
                        }

                        MyUsbDevice.Close();
                    }
                    MyUsbDevice = null;
                }

                // Free usb resources
                UsbDevice.Exit();
            }
        }

        private void showTransfer(UsbTransferQueue.Handle handle, int transferIndex)
        {
            if (mStartTime == DateTime.MinValue)
            {
                mStartTime = DateTime.Now;
                form.addText("Synchronizing..\r\n");
                return;
            }

            mTotalBytes += handle.Transferred;
            double bytesSec = mTotalBytes / (DateTime.Now - mStartTime).TotalSeconds;

            form.addText(string.Format("#{0} complete. {1} bytes/sec ({2} bytes)\r\n",
                              transferIndex,
                              Math.Round(bytesSec, 2),
                              handle.Transferred,
                              handle.Data[1]));
            form.addText(string.Format("Data: "));
            for (int i = 0; i < handle.Data.Length; i++)
            {
                form.addText(string.Format("{0:X2} ", handle.Data[i]));
            }
            form.addText("\r\n");
        }
    }
}
