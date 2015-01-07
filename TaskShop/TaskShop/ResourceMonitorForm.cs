using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
namespace TaskShop
{
    public partial class ResourceMonitorForm : Form
    {
        private  string _cpuvalue;
        public ResourceMonitorForm()
        {
            InitializeComponent();

            this.cpuchart.Series[0].ChartType = SeriesChartType.FastLine;
            // Add Initial Point as Zero.
            this.cpuchart.Series[0].Points.Add(0);
            //Populating X Y Axis  Information
            this.cpuchart.Series[0].YAxisType = AxisType.Primary;
            this.cpuchart.Series[0].YValueType = ChartValueType.Int32;
            this.cpuchart.Series[0].IsXValueIndexed = false;

            this.cpuchart.ResetAutoValues();
            this.cpuchart.ChartAreas[0].AxisY.Maximum = 100;
            this.cpuchart.ChartAreas[0].AxisY.Minimum = 0;

            //Add points to chart
            this.cpuchart.ChartAreas[0].AxisX.Enabled = AxisEnabled.False;
            this.cpuchart.ChartAreas[0].AxisY.IntervalAutoMode = IntervalAutoMode.VariableCount;
            //------------
            cpuchart.Series[0].Points.AddY(this.performanceCounter.NextValue());
           
            
        }

        private void ResourceMonitorForm_Load(object sender, EventArgs e)
        {
        }

        public  void Values(string cpuvalue)
        {
        
        }

        
    }
}
