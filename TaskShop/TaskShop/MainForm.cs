using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections;
using System.Runtime.InteropServices;
using System.ServiceProcess;
using System.Windows.Forms.DataVisualization.Charting;
using Microsoft.VisualBasic.Devices;

namespace TaskShop
{
    public partial class MainForm : Form
    {
        private ArrayList _processcontainer;
        private ArrayList _closedprocess ;
        private ArrayList _applicationcontiner;
        private ArrayList _closeApplication;
        public MainForm()
        {
            InitializeComponent();
            _processcontainer = new ArrayList();
            _closedprocess = new ArrayList();
            _applicationcontiner = new ArrayList();

            _closeApplication = new ArrayList();
        }

        //----------------------//
        #region Application
        //display application in local
        private void Applications()
        {
            foreach (Process item in Process.GetProcesses())
            {
                if (item.MainWindowTitle.Length > 0)
                {
                    _applicationcontiner.Add(item.Id);
                    this.applicationlistBox.Items.Add(item.MainWindowTitle);
                }

            }
        }
        private void CheckApplication()
        {  
            //check for load app.

            _closeApplication.Clear();
            foreach (Process item in Process.GetProcesses())
            {
                if (item.MainWindowTitle.Length > 0)
                {
                    if (!_applicationcontiner.Contains(item.Id))
                    {
                        this.applicationlistBox.Items.Add(item.MainWindowTitle);
                        _applicationcontiner.Add(item.Id);

                    }
                    _closeApplication.Add(item.Id);
                }
            }
            //check for close app.
            foreach (Object item in _applicationcontiner.ToArray())
            {
                if (!_closeApplication.Contains(item))
                {
                    this.applicationlistBox.Items.RemoveAt(_applicationcontiner.IndexOf(item));
                    _applicationcontiner.Remove(item);
                    _closeApplication.Remove(item);
                  
                }
            }
        }

        private void endtaskbutton_Click(object sender, EventArgs e)
        {

            foreach (Process item in Process.GetProcesses())
            {
                if (this.applicationlistBox.SelectedItem == null) return;
                if (item.MainWindowTitle.Length > 0)
                {
                    if (this.applicationlistBox.SelectedItem.ToString() != item.MainWindowTitle) continue;
                        item.Kill();     
                        this.applicationlistBox.Items.Remove(item.MainWindowTitle);
                        _applicationcontiner.Remove(item.Id);
               
                    
                }
            }

        }

        private void newtaskbutton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Programs|*.exe";
            if (dialog.ShowDialog(this) != DialogResult.OK) return;
            Process.Start(dialog.FileName);
        }

        #endregion

        //----------------------//
        #region Processes

        //display processes in local.
        int numprocess = 0;
            
        public void Processes()
        {
            foreach (Process item in Process.GetProcesses())
            {
                this.processlistBox.Items.Add(item.ProcessName + ".exe");
                _processcontainer.Add(item.Id);
                numprocess++;
            }


        }

        private void endproceessbutton_Click(object sender, EventArgs e)
        {
            //kill selected process.
            foreach (Process item in Process.GetProcesses())
            {
                if (this.processlistBox.SelectedItem == null) return;
                if (item.ProcessName + ".exe" == this.processlistBox.SelectedItem.ToString())
                {
                    item.Kill();
                    _processcontainer.Remove(item.Id);
                    this.processlistBox.Items.Remove(item.ProcessName + ".exe");
                    numprocess--;
                }
            }

        }

        private void CheckProcess()
        {
            //check for load process.
           _closedprocess.Clear();
            foreach (Process item in Process.GetProcesses())
            {
                if (!_processcontainer.Contains(item.Id))
                {
                    this.processlistBox.Items.Add(item.ProcessName + ".exe");
                    _processcontainer.Add(item.Id);
                    numprocess++;
                }
                _closedprocess.Add(item.Id);
               
            }
            //check for close process.
            foreach (Object item in _processcontainer.ToArray())
                if (!_closedprocess.Contains(item))
                {
                    this.processlistBox.Items.RemoveAt(_processcontainer.IndexOf(item));
                    _processcontainer.Remove(item);
                   _closedprocess.Remove(item);
                    numprocess--;
                }
            this.processtoolStripStatusLabel.Text = numprocess.ToString();
        }
        #endregion
        //----------------------//
        #region Services

        //display services in local.
        private void Services()
        {

            foreach (ServiceController item in ServiceController.GetServices())
            {
                this.servicelistBox.Items.Add(item.ServiceName);

            }

        }
       

        #endregion
        //----------------------//
        #region Performance
        //Performance in local.

        PerformanceCounter _cpu = new PerformanceCounter("Processor", "% processor time", "_total");
           private void Performance()
        {  //------------Cpu---------------
            
            string cpuvalue = Convert.ToInt32(_cpu.NextValue()).ToString();
            this.cputoolStripStatusLabel.Text = cpuvalue + "%";
    
           //------------Memory------------
            PerformanceCounter _memory = new PerformanceCounter();
            _memory.CategoryName = "Memory";
            _memory.CounterName = "Available MBytes";
            string valuememory = Convert.ToInt32(_memory.NextValue()).ToString();
            this.memorytoolStripStatusLabel.Text =this.avilablevalue.Text=valuememory;
            this.totalvalue.Text=((new ComputerInfo().TotalVirtualMemory)/(1024*1024)).ToString();
       
            this.writecopiesvaluevalue.Text =this.performanceCounter1.NextValue().ToString();
      
            //-------------System-----------
            PerformanceCounter _system = new PerformanceCounter();
     
            _system.CategoryName = "System";
            _system.CounterName = "Threads";
            this.threadsvaluelabel.Text = _system.NextValue().ToString();
            
            _system.CounterName = "Processes";
            this.processesvaluelabel .Text=_system.NextValue().ToString();
            
            this.systemcallvaluelabel.Text = this.performanceCounter.NextValue().ToString();
            
        
            ComputerInfo computerinfo = new ComputerInfo();
            this.osnamelabel.Text = computerinfo.OSFullName;
            this.platformvaluelabel.Text = computerinfo.OSPlatform;
            this.languagevaluelabel.Text = computerinfo.InstalledUICulture.NativeName;
            this.osversionvaluelabel.Text = computerinfo.OSVersion;
            this.datevaluelabel.Text = DateTime.Now.ToShortDateString();
            this.timevaluelabel.Text = DateTime.Now.ToShortTimeString();

           
            //-----------Chart-----------
            this.cpuchart.Series[0].ChartType = SeriesChartType.FastLine;
            this.cpuchart.Series[0].Points.Add(0);
            this.cpuchart.Series[0].YAxisType = AxisType.Primary;
            this.cpuchart.Series[0].YValueType = ChartValueType.Int32;
            this.cpuchart.Series[0].IsXValueIndexed = false;
            
            this.cpuchart.ResetAutoValues(); 
            this.cpuchart.ChartAreas[0].AxisY.Maximum = 100;
            this.cpuchart.ChartAreas[0].AxisY.Minimum = 0;
            
            //Add points to chart
            this.cpuchart.Series[0].Points.AddY(int.Parse(cpuvalue));
            this.cpuchart.ChartAreas[0].AxisX.Enabled = AxisEnabled.False;
            this.cpuchart.ChartAreas[0].AxisY.IntervalAutoMode = IntervalAutoMode.VariableCount;
           //------------
            
            if (this.cpuchart.Series[0].Points.Count  >40 )
               this.cpuchart.Series[0].Points.RemoveAt(0);
            
        }
        #endregion
        //----------------------//
        #region User
        //display users in local.
        private void User()
        {
            this.userlistBox.Items.Add(Environment.MachineName);

        }
        private void logoffbutton_Click(object sender, EventArgs e)
        {
            ExitWindowsEx(0, 0);

        }

        //Add a static extern method to MainForm.cs
        [DllImport("user32.dll")]
        public static extern int ExitWindowsEx(int operationflag, int operationReason);

        #endregion


        private void timer1_Tick(object sender, EventArgs e)
        {
             this.CheckProcess();
            this.CheckApplication();
            this.Performance();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Applications();
            this.Processes();
            this.Performance();
            this.Services();
            this.User();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Process.Start(@"C:\Users\Dell\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Accessories\Run.lnk");
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            //process.StartInfo.WorkingDirectory = "c:\temp";
            process.StartInfo.Arguments = "dir";
            process.Start();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutBox().ShowDialog(this);
        }

        


      

        
   
       
    }
}