using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Threading.Tasks;
using System.Threading;

//Usings for common part of the API
using Hbm.Api.Common;
using Hbm.Api.Common.Exceptions;
using Hbm.Api.Common.Entities;
using Hbm.Api.Common.Entities.Problems;
using Hbm.Api.Common.Entities.Connectors;
using Hbm.Api.Common.Entities.Channels;
using Hbm.Api.Common.Entities.Signals;
using Hbm.Api.Common.Entities.Filters;
using Hbm.Api.Common.Entities.ConnectionInfos;
using Hbm.Api.Common.Enums;


//Usings for sensor database access
using Hbm.Api.SensorDB.Entities.Sensors;
using Hbm.Api.SensorDB.Entities.Scalings;

//Usings for common API events 
using Hbm.Api.Common.Messaging;

//Usings for PMX (only necessary, if you want to use special features of PMX devices)
using Hbm.Api.Pmx;
using Hbm.Api.Pmx.Connectors;
using Hbm.Api.Pmx.Channels;
using Hbm.Api.Pmx.Signals;

//Usings for MGC (only necessary, if you want to use special features of MGC devices)
using Hbm.Api.Mgc;
using Hbm.Api.Mgc.Connectors;
using Hbm.Api.Mgc.Channels;
using Hbm.Api.Mgc.Signals;

//Usings for QuantumX (only necessary, if you want to use special features of QuantumX devices)
using Hbm.Api.QuantumX;
using Hbm.Api.QuantumX.Connectors;
using Hbm.Api.QuantumX.Channels;
using Hbm.Api.QuantumX.Signals;
using System.IO;
//using System.Windows.Forms.DataVisualization.Charting;

namespace ReadHBMclass
{
    public class ReadHBM
    {
        public DaqEnvironment Environment;                               // main object to scan, connect and parameterize devices
        public DaqMeasurement Measurement;                               // main object to execute measurements
        public Device myDevice;                                             // device to connect and to use within this demo
        public List<Signal> signalsToMeasure;                               // list of signals to use for a continuous measurement
        public List<double> Signal0=new List<double>();
        public List<double> Signal1=new List<double>();
        public List<double> Signal2=new List<double>();
        public List<double> Signal3=new List<double>();
        public bool runMeasurement;                                         // true, while data acquisition is running...
        public List<Device> deviceList;                                     // list of devices found by the scan
        public delegate void VisualizeDeviceEventHandler(DeviceEventArgs e); // delegate for our event handling
        public Signal tempSignal0;
        public Signal tempSignal1;
        public Signal tempSignal2;
        public Signal tempSignal3;
        public void Init(out string error)
        {
            error = "";
            try
            {
                Environment = DaqEnvironment.GetInstance();
                Measurement = new DaqMeasurement();
              //  AddToLog("DAQ 环境和设备初始化。。。");

            }
            catch(Exception ex)
            {
                error = ex.Message;
             //   AddToLog(ex.Message);
            }
           // System.Threading.Thread.Sleep(1000);
          //  AddToLog("延时等待1s");
          //  System.Threading.Thread.Sleep(1000);
           // AddToLog("延时等待2s");

        }
        //public void AddToLog(string logmessage)
        //{
        //    string timeMess = System.DateTime.Now.ToLongTimeString() + "  ";
        //    this.TestLog.AppendText(timeMess+logmessage + "\n");
        //}

        public bool Scan(out string error)
        {
            error = "";
            try
            {
                List<string> SupportedFamilyDevices = Environment.GetAvailableDeviceFamilyNames();
                //foreach(string family in SupportedFamilyDevices)
                //{
                //    AddToLog("SupportFamilyDevices:" + family);
                //}
                deviceList = Environment.Scan(SupportedFamilyDevices);
                deviceList = deviceList.OrderBy(n => n.Name).ToList();
              
              //  AddToLog(string.Format("发现设备数量为：{0}", deviceList.Count));
                //foreach(Device dev in deviceList)
                //{
                //   // AddToLog(string.Format("设备名称：{0}，设备序列号：{1}，设备版本号：{2}", dev.Name.PadRight(22), dev.SerialNo.PadRight(16), dev.FirmwareVersion));
                //    AddToLog(string.Format("设备名称：{0}，设备序列号：{1}，设备版本号：{2}",dev.Name,dev.SerialNo.PadRight(16),dev.FirmwareVersion));
                //}
            }
            catch(Exception ex)
            {
                error = ex.Message;
            //    AddToLog(ex.Message);
            }
            if (deviceList.Count > 0)
            {
                return true;
            }
            else
                return false;
        }

        public void Connect(out string error)
        {

            int Devindex=0;
            error = "";
            try
            {
                if (deviceList.Count>0)
                {
                    List<Problem> problemList = new List<Problem>();
                    // pick the device that should be used from the scanned device list
                    myDevice = deviceList[Devindex]; //connectionInfo of the device has been filled by the scan!
                    Environment.Connect(myDevice, out problemList);
                    
                    // when a device is connected, the complete object representation of the device is available
                    // break here and check _deviceList[0] against e.g. _deviceList[1] to see the difference
              //      AddToLog(string.Format("Device {0} is connected;  It has {1} connectors", myDevice.Name, myDevice.Connectors.Count));
                //    AddToLog(string.Format("Device connectioninfo is {0};", myDevice.ConnectionInfo));

                }
            }
            catch (Exception ex) 
            {
                error = ex.Message;
            //    AddToLog(ex.Message);
            }
        }

        public void GetMeasure(int waittime,out string error)
        {
            error = "";
          //  try
          //  {
                // get a measurement value of the first signal of the first channel of the first connector
             //   AddToLog("Get a single measurement value of first signal");

              //  Signal tempSignal0 = myDevice.Connectors[0].Channels[0].Signals[0];
                myDevice.ReadSingleMeasurementValue(new List<Signal>() { tempSignal0 });
              
                // get a measurement value from all signals of the device:
                //_myDevice.ReadSingleMeasurementValueOfAllSignals();

           //     AddToLog(string.Format("Measurement value of first signal={0}", tempSignal0.GetSingleMeasurementValue().Value));
          //      AddToLog(string.Format("Timestamp of first signal={0}", tempSignal0.GetSingleMeasurementValue().Timestamp));


          //      AddToLog("Get a single measurement value of second signal");

               // Signal tempSignal1 = myDevice.Connectors[1].Channels[0].Signals[0];
                myDevice.ReadSingleMeasurementValue(new List<Signal>() { tempSignal1 });
               
                // get a measurement value from all signals of the device:
                //_myDevice.ReadSingleMeasurementValueOfAllSignals();

             //   AddToLog(string.Format("Measurement value of second signal={0}", tempSignal1.GetSingleMeasurementValue().Value));
            //    AddToLog(string.Format("Timestamp of second signal={0}", tempSignal1.GetSingleMeasurementValue().Timestamp));

            //    AddToLog("Get a single measurement value of third signal");

              //  Signal tempSignal2 = myDevice.Connectors[2].Channels[0].Signals[0];
                myDevice.ReadSingleMeasurementValue(new List<Signal>() { tempSignal2 });
               
                // get a measurement value from all signals of the device:
                //_myDevice.ReadSingleMeasurementValueOfAllSignals();

              //  AddToLog(string.Format("Measurement value of third signal={0}", tempSignal2.GetSingleMeasurementValue().Value));
              //  AddToLog(string.Format("Timestamp of third signal={0}", tempSignal2.GetSingleMeasurementValue().Timestamp));


              //  AddToLog("Get a single measurement value of forth signal");

              //  Signal tempSignal3 = myDevice.Connectors[3].Channels[0].Signals[0];
                myDevice.ReadSingleMeasurementValue(new List<Signal>() { tempSignal3 });
                
                // get a measurement value from all signals of the device:
                //_myDevice.ReadSingleMeasurementValueOfAllSignals();
                Signal0.Add(tempSignal0.GetSingleMeasurementValue().Value);
                Signal1.Add(tempSignal1.GetSingleMeasurementValue().Value);
                Signal2.Add(tempSignal2.GetSingleMeasurementValue().Value);
                Signal3.Add(tempSignal3.GetSingleMeasurementValue().Value);
              //  AddToLog(string.Format("Measurement value of forth signal={0}", tempSignal3.GetSingleMeasurementValue().Value));
             //   AddToLog(string.Format("Timestamp of forth signal={0}", tempSignal3.GetSingleMeasurementValue().Timestamp));
                System.Threading.Thread.Sleep(waittime);
        //    }
           // catch (Exception ex)
          //  {
           //     error = ex.Message;
              //  AddToLog(ex.Message); 
          //  }
        }

        public void AutoMeasure(out string error)
        {
            error = "";
           

        }

        /// <summary>
        /// Prepares a continuous measurement
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        public void PrepareContinuousMeasurement( int sampleRate,int interval,out string error)
        {
            error = "";
            Signal0.Clear();
            Signal1.Clear();
            Signal2.Clear();
            Signal3.Clear();
            try
            {
                // prepare a continuous measurement with 2 signals
                // use the first signals of the first 2 connectors 
                // on the same device
                tempSignal0 = myDevice.Connectors[0].Channels[0].Signals[0];
                tempSignal1 = myDevice.Connectors[1].Channels[0].Signals[0];
                tempSignal2 = myDevice.Connectors[2].Channels[0].Signals[0];
                tempSignal3 = myDevice.Connectors[3].Channels[0].Signals[0];
                signalsToMeasure = new List<Signal>();
                signalsToMeasure.Add(myDevice.Connectors[0].Channels[0].Signals[0]);
                signalsToMeasure.Add(myDevice.Connectors[1].Channels[0].Signals[0]);
                signalsToMeasure.Add(myDevice.Connectors[2].Channels[0].Signals[0]);
                signalsToMeasure.Add(myDevice.Connectors[3].Channels[0].Signals[0]);
                //set sample rate for signals
                List<Problem> problems = new List<Problem>(); //this list of problems will be used to get the problems during a assign process
                foreach (Signal sig in signalsToMeasure)
                {
                    sig.SampleRate = sampleRate;//check what happens, if you assign e.g. sig.SampleRate = 1234;
                    

                    
//internal enum SampleRate {
//  _1Hz = 6300,
//  _2Hz = 6301,
//  _5Hz = 6302,
//  _10Hz = 6303,
//  _20Hz = 6326,
//  _25Hz = 6304,
//  _50Hz = 6305,
//  _75Hz = 6307,
//  _100Hz = 6308,
//  _150Hz = 6309,
//  _200Hz = 6310,
//  _300Hz = 6311,
//  _600Hz = 6313,
//  _1200Hz = 6315,
//  _2400Hz = 6317,
//  _4800Hz = 6319,
//  _9600Hz = 6320,
//  _19200Hz = 6345
//}
                    myDevice.AssignSignal(sig, out problems);
                    if (problems.Count > 0)
                    {
                        foreach (Problem prob in problems)
                        {
                         //   AddToLog("Problem with " + prob.PropertyName + " occurred: " + prob.Message);
                        }
                    }
                }

                // add the chosen signals to the measurement
                Measurement.AddSignals(myDevice, signalsToMeasure);
             //   AddToLog("4 signals added to the measurement.");
                
                // prepare data acqusisition;
                Measurement.PrepareDaq();
                // try overloaded version of PrepareDaq ( e.g. to control number of filled timestamps- default is "timeStamp for the first measurement value only")
                //_daqMeasurement.PrepareDaq(2400, 1, 2400, false, false);// use this to get a timeStamp and a status for each measurement value
             //   AddToLog("Measurement is prepared.");
            }
            catch (Exception ex)
            {
                error = ex.Message;
               // MessageBox.Show(ex.Message, ex.ToString());
            }

        }

        /// <summary>
        /// Runs continuous measurement with the signals that were added to the measurement
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        public void RunContinuousMeasurement(int length,int waittime,out string error)
        {
            error = "";
            try
            {
                // run continuous measurement with the signals that were added to the measurement
                Measurement.StartDaq(DataAcquisitionMode.HardwareSynchronized,5000);
                runMeasurement = true;
                int count = 0;
                int countsum = 0;
                while (runMeasurement && countsum < length)
                {
                    // update measurement values of the signals that were added to the measurement:
                    Measurement.FillMeasurementValues();
                    // FillMeasurements updates the ContinuousMeasurementValues from all signals that 
                    // were added to the measurement
                    // The next call of FillMeasurementValues will overwrite them again with new values....
                    
                    // check signals that were added for measurement for new measurement values...
                    //AddToLog(string.Format("Signal {0} has {1} new measurement values \tFirst timestamp={2} \tFirst measval={3}",
                    //      signalsToMeasure[0].Name,
                 //  signalsToMeasure[0].ContinuousMeasurementValues.Values.Count
                    //      signalsToMeasure[0].ContinuousMeasurementValues.Timestamps[0],
                    //      signalsToMeasure[0].ContinuousMeasurementValues.Values[0]));
                    
                    //AddToLog(string.Format("Signal {0} has {1} new measurement values \tFirst timestamp={2} \tFirst measval={3}",
                    //      signalsToMeasure[1].Name,
                    //      signalsToMeasure[1].ContinuousMeasurementValues.UpdatedValueCount,
                    //      signalsToMeasure[1].ContinuousMeasurementValues.Timestamps[0],
                    //      signalsToMeasure[1].ContinuousMeasurementValues.Values[0]));
                    
                    //AddToLog(string.Format("Signal {0} has {1} new measurement values \tFirst timestamp={2} \tFirst measval={3}",
                    //     signalsToMeasure[2].Name,
                    //     signalsToMeasure[2].ContinuousMeasurementValues.UpdatedValueCount,
                    //     signalsToMeasure[2].ContinuousMeasurementValues.Timestamps[0],
                    //     signalsToMeasure[2].ContinuousMeasurementValues.Values[0]));
                    
                    //AddToLog(string.Format("Signal {0} has {1} new measurement values \tFirst timestamp={2} \tFirst measval={3}",
                    //     signalsToMeasure[3].Name,
                    //     signalsToMeasure[3].ContinuousMeasurementValues.UpdatedValueCount,
                    //     signalsToMeasure[3].ContinuousMeasurementValues.Timestamps[0],
                    //     signalsToMeasure[3].ContinuousMeasurementValues.Values[0]));
                    if (signalsToMeasure[3].ContinuousMeasurementValues.UpdatedValueCount > 0)
                    {
                        Signal0.Add(signalsToMeasure[0].ContinuousMeasurementValues.Values[0]);
                        Signal1.Add(signalsToMeasure[1].ContinuousMeasurementValues.Values[0]);
                        Signal2.Add(signalsToMeasure[2].ContinuousMeasurementValues.Values[0]);
                        Signal3.Add(signalsToMeasure[3].ContinuousMeasurementValues.Values[0]);

                        // count = signalsToMeasure[0].ContinuousMeasurementValues.UpdatedValueCount;
                        count++;
                        countsum++;
                    }
                  //  File.AppendAllText("C:\\Users\\aliu2197\\Desktop\\11.txt", signalsToMeasure[0].ContinuousMeasurementValues.Values[0].ToString() + "\r\n",Encoding.Default);
                 //   File.AppendAllText("C:\\Users\\aliu2197\\Desktop\\12.txt", signalsToMeasure[1].ContinuousMeasurementValues.Values[0].ToString() + "\r\n", Encoding.Default);
                 //   File.AppendAllText("C:\\Users\\aliu2197\\Desktop\\13.txt", signalsToMeasure[2].ContinuousMeasurementValues.Values[0].ToString() + "\r\n", Encoding.Default);
                 //   File.AppendAllText("C:\\Users\\aliu2197\\Desktop\\14.txt", signalsToMeasure[3].ContinuousMeasurementValues.Values[0].ToString() + "\r\n", Encoding.Default);
                    System.Threading.Thread.Sleep(waittime);
                    if(signalsToMeasure[0].ContinuousMeasurementValues.Values.Count()<=count)
                   {
                       count = 0;
                    }
                }

               
            }
            catch (Exception ex) 
            {
                error = ex.Message;
               
            //    MessageBox.Show(ex.Message, ex.ToString());
            }
          //  连续采集.Click += new EventHandler(设置触发_Click);
        }

        /// <summary>
        /// Stops running measurement
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        public void StopContinuousMeasurement(out string error)
        {
            error = "";
            try
            {
                // stop running data acquisition
              //  runMeasurement = false;
                Measurement.StopDaq();
              //  Environment.Disconnect(myDevice);
              //  Environment.Dispose();
            //    AddToLog("Continuous measuring stopped!");
            }
            catch (Exception ex) 
            {
                error = ex.Message;
               // MessageBox.Show(ex.Message, ex.ToString());
            }
        }

        public void ExitMeasure(out string error)
        {
            error = "";
            try
            {
                // stop running data acquisition
                runMeasurement = false;
            //    Measurement.StopDaq();
                Environment.Disconnect(myDevice);
                Environment.Dispose();
                //    AddToLog("Continuous measuring stopped!");
            }
            catch (Exception ex)
            {
                error = ex.Message;
                // MessageBox.Show(ex.Message, ex.ToString());
            }
        }



        public void SendToZero(out string error)
        {
            error = "";
            List<Problem> problems = new List<Problem>();
            try
            {
             //   myDevice.AssignZero(myDevice.Connectors[0].Channels[0], out problems);
             //   myDevice.AssignZero(myDevice.Connectors[1].Channels[0], out problems);
            //    myDevice.AssignZero(myDevice.Connectors[2].Channels[0], out problems);
            //    myDevice.AssignZero(myDevice.Connectors[3].Channels[0], out problems);
              myDevice.SetZeroBalance(myDevice.Connectors[0].Channels, out problems,1);
              myDevice.SetZeroBalance(myDevice.Connectors[1].Channels, out problems, 1);
              myDevice.SetZeroBalance(myDevice.Connectors[2].Channels, out problems, 1);
              myDevice.SetZeroBalance(myDevice.Connectors[3].Channels, out problems, 1);
                // stop running data acquisition

                //    AddToLog("Continuous measuring stopped!");
            }
            catch (Exception ex)
            {
                error = ex.Message;
                // MessageBox.Show(ex.Message, ex.ToString());
            }
        }

        public bool ConnectFromIP(string IPAddress,out string error)
        {
            error = "";
            try
            {
                List<Problem> problemList = new List<Problem>();

                // To connect a device without using the results of the scan, you have to define at least the
                // type of the device and its IP address. E.g.:

                //_myDevice = new PmxDevice();
                //_myDevice.ConnectionInfo = new EthernetConnectionInfo("172.19.191.113",55000);
                // or:
                //_myDevice = new PmxDevice("172.19.191.113"); //this constructor uses the PMX default port (55000)

                //_myDevice = new MgcDevice();
                //_myDevice.ConnectionInfo = new EthernetConnectionInfo("172.19.169.133",7);
                // or:
                //_myDevice = new MgcDevice("172.19.169.133"); //this constructor uses the MGCplus default port (7)

                //_myDevice = new QuantumXDevice();
                //_myDevice.ConnectionInfo = new StreamingConnectionInfo("172.19.191.113",5001,7411,80);
                // or:
                //_myDevice = new QuantumXDevice("172.19.190.149"); //this constructor uses the QuantumX default port (5001), 
                //its default streaming port (7411) and its default HTTP port (80)

              //  myDevice = new MgcDevice("172.19.169.133");
              //  myDevice = new MgcDevice(IPAddress);
                myDevice = new QuantumXDevice(IPAddress);
                if (Environment.Connect(myDevice, out problemList)) //connect the defined device
                {
                    return true;
                    // when a device is connected, the complete object representation of the device is available
                    // break here and check _deviceList[0] against e.g. _deviceList[1] to see the difference
                   // AddToLog(string.Format("Device {0} is connected;  It has {1} connectors", _myDevice.Name, _myDevice.Connectors.Count));
                }
                else
                {
                    //there occurred errors during connect to the device
                   // AddToLog("Connection to device failed!");
                  foreach (Problem problem in problemList)
                    {
                        error += problem.Message;
                      //  AddToLog(problem.Message);
                    }
                  return false;
                  
                }
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message, ex.ToString());
               
                error += ex.Message;
                return false;
            }
        }

      


    }
}

    

