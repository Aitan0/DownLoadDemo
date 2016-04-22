using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Threading.Tasks;
//using System.Windows.Forms;
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
//using System.Windows.Forms.DataVisualization.Charting;

namespace ReadHBM
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
        public void Init_Click(out string errormess)
        {
            errormess = "";
            try
            {
                Environment = DaqEnvironment.GetInstance();
                Measurement = new DaqMeasurement();
              //  AddToLog("DAQ 环境和设备初始化。。。");

            }
            catch(Exception ex)
            {
                errormess = ex.Message;
             //   AddToLog(ex.Message);
            }
        }
        //public void AddToLog(string logmessage)
        //{
        //    string timeMess = System.DateTime.Now.ToLongTimeString() + "  ";
        //    this.TestLog.AppendText(timeMess+logmessage + "\n");
        //}

        public bool Scan_Click(out string errormess)
        {
            errormess = "";
            try
            {
                List<string> SupportedFamilyDevices = Environment.GetAvailableDeviceFamilyNames();
                //foreach(string family in SupportedFamilyDevices)
                //{
                //    AddToLog("SupportFamilyDevices:" + family);
                //}
                deviceList = Environment.Scan(SupportedFamilyDevices);
                deviceList = deviceList.OrderBy(n => n.Name).ToList();
                return deviceList.Count > 0;
              //  AddToLog(string.Format("发现设备数量为：{0}", deviceList.Count));
                //foreach(Device dev in deviceList)
                //{
                //   // AddToLog(string.Format("设备名称：{0}，设备序列号：{1}，设备版本号：{2}", dev.Name.PadRight(22), dev.SerialNo.PadRight(16), dev.FirmwareVersion));
                //    AddToLog(string.Format("设备名称：{0}，设备序列号：{1}，设备版本号：{2}",dev.Name,dev.SerialNo.PadRight(16),dev.FirmwareVersion));
                //}
            }
            catch(Exception ex)
            {
                errormess = ex.Message;
            //    AddToLog(ex.Message);
                return false;
            }
        }

        public void Connect_Click(out string errormess)
        {
            int Devindex=0;
            errormess = "";
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
                errormess = ex.Message;
            //    AddToLog(ex.Message);
            }
        }

        public void GetMeasure_Click(out string errormess)
        {
            errormess = "";
            try
            {
                // get a measurement value of the first signal of the first channel of the first connector
             //   AddToLog("Get a single measurement value of first signal");

                Signal tempSignal0 = myDevice.Connectors[0].Channels[0].Signals[0];
                myDevice.ReadSingleMeasurementValue(new List<Signal>() { tempSignal0 });
                
                // get a measurement value from all signals of the device:
                //_myDevice.ReadSingleMeasurementValueOfAllSignals();

           //     AddToLog(string.Format("Measurement value of first signal={0}", tempSignal0.GetSingleMeasurementValue().Value));
          //      AddToLog(string.Format("Timestamp of first signal={0}", tempSignal0.GetSingleMeasurementValue().Timestamp));


          //      AddToLog("Get a single measurement value of second signal");

                Signal tempSignal1 = myDevice.Connectors[1].Channels[0].Signals[0];
                myDevice.ReadSingleMeasurementValue(new List<Signal>() { tempSignal1 });

                // get a measurement value from all signals of the device:
                //_myDevice.ReadSingleMeasurementValueOfAllSignals();

             //   AddToLog(string.Format("Measurement value of second signal={0}", tempSignal1.GetSingleMeasurementValue().Value));
            //    AddToLog(string.Format("Timestamp of second signal={0}", tempSignal1.GetSingleMeasurementValue().Timestamp));

            //    AddToLog("Get a single measurement value of third signal");

                Signal tempSignal2 = myDevice.Connectors[2].Channels[0].Signals[0];
                myDevice.ReadSingleMeasurementValue(new List<Signal>() { tempSignal2 });

                // get a measurement value from all signals of the device:
                //_myDevice.ReadSingleMeasurementValueOfAllSignals();

              //  AddToLog(string.Format("Measurement value of third signal={0}", tempSignal2.GetSingleMeasurementValue().Value));
              //  AddToLog(string.Format("Timestamp of third signal={0}", tempSignal2.GetSingleMeasurementValue().Timestamp));


              //  AddToLog("Get a single measurement value of forth signal");

                Signal tempSignal3 = myDevice.Connectors[3].Channels[0].Signals[0];
                myDevice.ReadSingleMeasurementValue(new List<Signal>() { tempSignal3 });

                // get a measurement value from all signals of the device:
                //_myDevice.ReadSingleMeasurementValueOfAllSignals();

              //  AddToLog(string.Format("Measurement value of forth signal={0}", tempSignal3.GetSingleMeasurementValue().Value));
             //   AddToLog(string.Format("Timestamp of forth signal={0}", tempSignal3.GetSingleMeasurementValue().Timestamp));
            }
            catch (Exception ex)
            {
                errormess = ex.Message;
              //  AddToLog(ex.Message); 
            }
        }

        public void AutoMeasure_Click(out string errormess)
        {
            errormess = "";
            //AutoMeasure.Click += new EventHandler(Init_Click);
            //System.Threading.Thread.Sleep(1000);
            //AutoMeasure.Click += new EventHandler(Scan_Click);
            //AutoMeasure.Click += new EventHandler(Connect_Click);
            //AutoMeasure.Click += new EventHandler(GetMeasure_Click);
            //AutoMeasure.Click += new EventHandler(PrepareContinuousMeasurementBt_Click);
            //AutoMeasure.Click += new EventHandler(RunContinuousMeasurementBt_Click);
            //AutoMeasure.Click += new EventHandler(StopContinuousMeasurementBt_Click);
            //AutoMeasure.Click += new EventHandler(设置触发_Click);

            //try
            //{
            //    // get a measurement value of the first signal of the first channel of the first connector
            //    AddToLog("Get a single measurement value of first signal");
            //    List<Channel> mychannels;
            //    Signal tempSignal = myDevice.Connectors[0].Channels[0].Signals[0];
            //  //  myDevice.ReadSingleMeasurementValue(new List<Signal>() { tempSignal });
            //  //  myDevice.ReadSingleMeasurementValueOfAllSignals();
            // mychannels=  myDevice.GetAllChannels();
            //    AddToLog(string.Format("all channel is {0}",mychannels.Count));
               

            //    // get a measurement value from all signals of the device:
            //    //_myDevice.ReadSingleMeasurementValueOfAllSignals();

            //    AddToLog(string.Format("Measurement value of first signal={0}", tempSignal.GetSingleMeasurementValue().Value));
            //    AddToLog(string.Format("Timestamp of first signal={0}", tempSignal.GetSingleMeasurementValue().Timestamp));
            //}
            //catch (Exception ex)
            //{
            //    AddToLog(ex.Message);
            //}

        }

       
      

        /// <summary>
        /// Prepares a continuous measurement
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        public void PrepareContinuousMeasurementBt_Click(out string errormess)
        {
            errormess = "";
            try
            {
                // prepare a continuous measurement with 2 signals
                // use the first signals of the first 2 connectors 
                // on the same device
                signalsToMeasure = new List<Signal>();
                signalsToMeasure.Add(myDevice.Connectors[0].Channels[0].Signals[0]);
                signalsToMeasure.Add(myDevice.Connectors[1].Channels[0].Signals[0]);
                signalsToMeasure.Add(myDevice.Connectors[2].Channels[0].Signals[0]);
                signalsToMeasure.Add(myDevice.Connectors[3].Channels[0].Signals[0]);
                //set sample rate for signals
                List<Problem> problems = new List<Problem>(); //this list of problems will be used to get the problems during a assign process
                foreach (Signal sig in signalsToMeasure)
                {
                    sig.SampleRate = 2400; //check what happens, if you assign e.g. sig.SampleRate = 1234;
                    
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
                errormess = ex.Message;
               // MessageBox.Show(ex.Message, ex.ToString()); 
            }
        }

        /// <summary>
        /// Runs continuous measurement with the signals that were added to the measurement
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        public void RunContinuousMeasurementBt_Click(out string errormess,out double[] DoubleSignal0,out double[] DoubleSignal1,out double[] DoubleSignal2,out double[] DoubleSignal3)
        {
            errormess = "";
                   List<double> Signal10=new List<double>();
      List<double> Signal11=new List<double>();
       List<double> Signal12=new List<double>();
        List<double> Signal13=new List<double>();
        DoubleSignal0 = new double[1000];
        DoubleSignal1 = new double[1000];
        DoubleSignal2 = new double[1000];
        DoubleSignal3 = new double[1000];
            try
            {
                // run continuous measurement with the signals that were added to the measurement
                Measurement.StartDaq(DataAcquisitionMode.TimestampSynchronized);
                runMeasurement = true;
                int count = 0;
                while (runMeasurement&&count<1000)
                {
                    // update measurement values of the signals that were added to the measurement:
                    Measurement.FillMeasurementValues();
                    // FillMeasurements updates the ContinuousMeasurementValues from all signals that 
                    // were added to the measurement
                    // The next call of FillMeasurementValues will overwrite them again with new values....

                    // check signals that were added for measurement for new measurement values...
                    //AddToLog(string.Format("Signal {0} has {1} new measurement values \tFirst timestamp={2} \tFirst measval={3}",
                    //      signalsToMeasure[0].Name,
                    //      signalsToMeasure[0].ContinuousMeasurementValues.UpdatedValueCount,
                    //      signalsToMeasure[0].ContinuousMeasurementValues.Timestamps[0],
                    //      signalsToMeasure[0].ContinuousMeasurementValues.Values[0]));
                    Signal10.Insert(count,signalsToMeasure[0].ContinuousMeasurementValues.Values[0]);
                    //AddToLog(string.Format("Signal {0} has {1} new measurement values \tFirst timestamp={2} \tFirst measval={3}",
                    //      signalsToMeasure[1].Name,
                    //      signalsToMeasure[1].ContinuousMeasurementValues.UpdatedValueCount,
                    //      signalsToMeasure[1].ContinuousMeasurementValues.Timestamps[0],
                    //      signalsToMeasure[1].ContinuousMeasurementValues.Values[0]));
                    Signal11.Insert(count, signalsToMeasure[1].ContinuousMeasurementValues.Values[0]);
                    //AddToLog(string.Format("Signal {0} has {1} new measurement values \tFirst timestamp={2} \tFirst measval={3}",
                    //     signalsToMeasure[2].Name,
                    //     signalsToMeasure[2].ContinuousMeasurementValues.UpdatedValueCount,
                    //     signalsToMeasure[2].ContinuousMeasurementValues.Timestamps[0],
                    //     signalsToMeasure[2].ContinuousMeasurementValues.Values[0]));
                    Signal12.Insert(count, signalsToMeasure[2].ContinuousMeasurementValues.Values[0]);
                    //AddToLog(string.Format("Signal {0} has {1} new measurement values \tFirst timestamp={2} \tFirst measval={3}",
                    //     signalsToMeasure[3].Name,
                    //     signalsToMeasure[3].ContinuousMeasurementValues.UpdatedValueCount,
                    //     signalsToMeasure[3].ContinuousMeasurementValues.Timestamps[0],
                    //     signalsToMeasure[3].ContinuousMeasurementValues.Values[0]));
                    Signal13.Insert(count, signalsToMeasure[3].ContinuousMeasurementValues.Values[0]);

                   // count = signalsToMeasure[0].ContinuousMeasurementValues.UpdatedValueCount;
                   
                    //Application.DoEvents();// respond to GUI events
                    DoubleSignal0[count] = signalsToMeasure[0].ContinuousMeasurementValues.Values[0];
                    DoubleSignal1[count] = signalsToMeasure[1].ContinuousMeasurementValues.Values[0];
                    DoubleSignal2[count] = signalsToMeasure[2].ContinuousMeasurementValues.Values[0];
                    DoubleSignal3[count] = signalsToMeasure[3].ContinuousMeasurementValues.Values[0];
                    count++;
                }

               
            }
            catch (Exception ex) 
            {
                errormess = ex.Message;
                //MessageBox.Show(ex.Message, ex.ToString());
            }
           //DoubleSignal0= Signal10.ToArray();
           //DoubleSignal1 = Signal11.ToArray();
           //DoubleSignal2 = Signal12.ToArray();
           //DoubleSignal3 = Signal13.ToArray();
         
        }

        /// <summary>
        /// Stops running measurement
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        public void StopContinuousMeasurementBt_Click(out string errormess)
        {
            errormess = "";
            try
            {
                // stop running data acquisition
                runMeasurement = false;
                Measurement.StopDaq();
            //    AddToLog("Continuous measuring stopped!");
            }
            catch (Exception ex) 
            {
                errormess = ex.Message;
              //  MessageBox.Show(ex.Message, ex.ToString());
            }
        }
    }
}

    

