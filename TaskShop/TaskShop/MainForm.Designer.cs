namespace TaskShop
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.performanceCounter = new System.Diagnostics.PerformanceCounter();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.applicationtabPage = new System.Windows.Forms.TabPage();
            this.newtaskbutton = new System.Windows.Forms.Button();
            this.endtaskbutton = new System.Windows.Forms.Button();
            this.applicationlistBox = new System.Windows.Forms.ListBox();
            this.processtabPage = new System.Windows.Forms.TabPage();
            this.processlistBox = new System.Windows.Forms.ListBox();
            this.endprocessbutton = new System.Windows.Forms.Button();
            this.servicetabPage = new System.Windows.Forms.TabPage();
            this.servicelistBox = new System.Windows.Forms.ListBox();
            this.performancetabPage = new System.Windows.Forms.TabPage();
            this.systemgroupBox = new System.Windows.Forms.GroupBox();
            this.systemcallvaluelabel = new System.Windows.Forms.Label();
            this.systemcalllabel = new System.Windows.Forms.Label();
            this.Processeslabel = new System.Windows.Forms.Label();
            this.processesvaluelabel = new System.Windows.Forms.Label();
            this.threadsvaluelabel = new System.Windows.Forms.Label();
            this.threadslabel = new System.Windows.Forms.Label();
            this.phmemeorygroupBox = new System.Windows.Forms.GroupBox();
            this.writecopiesvaluevalue = new System.Windows.Forms.Label();
            this.freelabel = new System.Windows.Forms.Label();
            this.avilablevalue = new System.Windows.Forms.Label();
            this.avilablelabel = new System.Windows.Forms.Label();
            this.totalvalue = new System.Windows.Forms.Label();
            this.totallabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cpuchart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.usertabPage = new System.Windows.Forms.TabPage();
            this.logoffbutton = new System.Windows.Forms.Button();
            this.userlistBox = new System.Windows.Forms.ListBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.timelabel = new System.Windows.Forms.Label();
            this.timevaluelabel = new System.Windows.Forms.Label();
            this.datelabel = new System.Windows.Forms.Label();
            this.datevaluelabel = new System.Windows.Forms.Label();
            this.languagelabel = new System.Windows.Forms.Label();
            this.languagevaluelabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.osversionlabel = new System.Windows.Forms.Label();
            this.osversionvaluelabel = new System.Windows.Forms.Label();
            this.platformlabel = new System.Windows.Forms.Label();
            this.platformvaluelabel = new System.Windows.Forms.Label();
            this.oslabel = new System.Windows.Forms.Label();
            this.osnamelabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.processtoolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.cputoolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.memorytoolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.performanceCounter1 = new System.Diagnostics.PerformanceCounter();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.applicationtabPage.SuspendLayout();
            this.processtabPage.SuspendLayout();
            this.servicetabPage.SuspendLayout();
            this.performancetabPage.SuspendLayout();
            this.systemgroupBox.SuspendLayout();
            this.phmemeorygroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpuchart)).BeginInit();
            this.usertabPage.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // performanceCounter
            // 
            this.performanceCounter.CategoryName = "System";
            this.performanceCounter.CounterName = "System Calls/sec";
            // 
            // menuStrip
            // 
            this.menuStrip.AutoSize = false;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(381, 20);
            this.menuStrip.TabIndex = 9;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(31, 16);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.newToolStripMenuItem.Text = "&New Task(Run...)";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(171, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::TaskShop.Properties.Resources.Close;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.exitToolStripMenuItem.Text = "&Exit TaskShop";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(37, 16);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::TaskShop.Properties.Resources.Actions_help_about;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.applicationtabPage);
            this.tabControl.Controls.Add(this.processtabPage);
            this.tabControl.Controls.Add(this.servicetabPage);
            this.tabControl.Controls.Add(this.performancetabPage);
            this.tabControl.Controls.Add(this.usertabPage);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(3, 23);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(375, 343);
            this.tabControl.TabIndex = 7;
            // 
            // applicationtabPage
            // 
            this.applicationtabPage.Controls.Add(this.newtaskbutton);
            this.applicationtabPage.Controls.Add(this.endtaskbutton);
            this.applicationtabPage.Controls.Add(this.applicationlistBox);
            this.applicationtabPage.Location = new System.Drawing.Point(4, 22);
            this.applicationtabPage.Name = "applicationtabPage";
            this.applicationtabPage.Padding = new System.Windows.Forms.Padding(3);
            this.applicationtabPage.Size = new System.Drawing.Size(367, 317);
            this.applicationtabPage.TabIndex = 0;
            this.applicationtabPage.Text = "Application";
            this.applicationtabPage.UseVisualStyleBackColor = true;
            // 
            // newtaskbutton
            // 
            this.newtaskbutton.Location = new System.Drawing.Point(196, 289);
            this.newtaskbutton.Name = "newtaskbutton";
            this.newtaskbutton.Size = new System.Drawing.Size(75, 23);
            this.newtaskbutton.TabIndex = 14;
            this.newtaskbutton.Text = "New Task";
            this.newtaskbutton.UseVisualStyleBackColor = true;
            this.newtaskbutton.Click += new System.EventHandler(this.newtaskbutton_Click);
            // 
            // endtaskbutton
            // 
            this.endtaskbutton.Location = new System.Drawing.Point(277, 289);
            this.endtaskbutton.Name = "endtaskbutton";
            this.endtaskbutton.Size = new System.Drawing.Size(75, 23);
            this.endtaskbutton.TabIndex = 14;
            this.endtaskbutton.Text = "End Task";
            this.endtaskbutton.UseVisualStyleBackColor = true;
            this.endtaskbutton.Click += new System.EventHandler(this.endtaskbutton_Click);
            // 
            // applicationlistBox
            // 
            this.applicationlistBox.FormattingEnabled = true;
            this.applicationlistBox.Location = new System.Drawing.Point(22, 20);
            this.applicationlistBox.Name = "applicationlistBox";
            this.applicationlistBox.Size = new System.Drawing.Size(330, 264);
            this.applicationlistBox.TabIndex = 13;
            // 
            // processtabPage
            // 
            this.processtabPage.Controls.Add(this.processlistBox);
            this.processtabPage.Controls.Add(this.endprocessbutton);
            this.processtabPage.Location = new System.Drawing.Point(4, 22);
            this.processtabPage.Name = "processtabPage";
            this.processtabPage.Padding = new System.Windows.Forms.Padding(3);
            this.processtabPage.Size = new System.Drawing.Size(367, 317);
            this.processtabPage.TabIndex = 1;
            this.processtabPage.Text = "Processes";
            this.processtabPage.UseVisualStyleBackColor = true;
            // 
            // processlistBox
            // 
            this.processlistBox.FormattingEnabled = true;
            this.processlistBox.Location = new System.Drawing.Point(22, 20);
            this.processlistBox.Name = "processlistBox";
            this.processlistBox.Size = new System.Drawing.Size(330, 264);
            this.processlistBox.TabIndex = 12;
            // 
            // endprocessbutton
            // 
            this.endprocessbutton.Location = new System.Drawing.Point(277, 289);
            this.endprocessbutton.Name = "endprocessbutton";
            this.endprocessbutton.Size = new System.Drawing.Size(75, 23);
            this.endprocessbutton.TabIndex = 3;
            this.endprocessbutton.Text = "End Process";
            this.endprocessbutton.UseVisualStyleBackColor = true;
            this.endprocessbutton.Click += new System.EventHandler(this.endproceessbutton_Click);
            // 
            // servicetabPage
            // 
            this.servicetabPage.Controls.Add(this.servicelistBox);
            this.servicetabPage.Location = new System.Drawing.Point(4, 22);
            this.servicetabPage.Name = "servicetabPage";
            this.servicetabPage.Padding = new System.Windows.Forms.Padding(3);
            this.servicetabPage.Size = new System.Drawing.Size(367, 317);
            this.servicetabPage.TabIndex = 2;
            this.servicetabPage.Text = "Services";
            this.servicetabPage.UseVisualStyleBackColor = true;
            // 
            // servicelistBox
            // 
            this.servicelistBox.FormattingEnabled = true;
            this.servicelistBox.Location = new System.Drawing.Point(22, 20);
            this.servicelistBox.Name = "servicelistBox";
            this.servicelistBox.Size = new System.Drawing.Size(330, 264);
            this.servicelistBox.TabIndex = 15;
            // 
            // performancetabPage
            // 
            this.performancetabPage.Controls.Add(this.systemgroupBox);
            this.performancetabPage.Controls.Add(this.phmemeorygroupBox);
            this.performancetabPage.Controls.Add(this.groupBox1);
            this.performancetabPage.Location = new System.Drawing.Point(4, 22);
            this.performancetabPage.Name = "performancetabPage";
            this.performancetabPage.Size = new System.Drawing.Size(367, 317);
            this.performancetabPage.TabIndex = 4;
            this.performancetabPage.Text = "performance";
            this.performancetabPage.UseVisualStyleBackColor = true;
            // 
            // systemgroupBox
            // 
            this.systemgroupBox.Controls.Add(this.systemcallvaluelabel);
            this.systemgroupBox.Controls.Add(this.systemcalllabel);
            this.systemgroupBox.Controls.Add(this.Processeslabel);
            this.systemgroupBox.Controls.Add(this.processesvaluelabel);
            this.systemgroupBox.Controls.Add(this.threadsvaluelabel);
            this.systemgroupBox.Controls.Add(this.threadslabel);
            this.systemgroupBox.Location = new System.Drawing.Point(190, 212);
            this.systemgroupBox.Name = "systemgroupBox";
            this.systemgroupBox.Size = new System.Drawing.Size(177, 83);
            this.systemgroupBox.TabIndex = 18;
            this.systemgroupBox.TabStop = false;
            this.systemgroupBox.Text = "System";
            // 
            // systemcallvaluelabel
            // 
            this.systemcallvaluelabel.AutoSize = true;
            this.systemcallvaluelabel.Location = new System.Drawing.Point(107, 67);
            this.systemcallvaluelabel.Name = "systemcallvaluelabel";
            this.systemcallvaluelabel.Size = new System.Drawing.Size(9, 13);
            this.systemcallvaluelabel.TabIndex = 1;
            this.systemcallvaluelabel.Text = "l";
            // 
            // systemcalllabel
            // 
            this.systemcalllabel.AutoSize = true;
            this.systemcalllabel.Location = new System.Drawing.Point(7, 67);
            this.systemcalllabel.Name = "systemcalllabel";
            this.systemcalllabel.Size = new System.Drawing.Size(73, 13);
            this.systemcalllabel.TabIndex = 2;
            this.systemcalllabel.Text = "SystemCalls\\s";
            // 
            // Processeslabel
            // 
            this.Processeslabel.AutoSize = true;
            this.Processeslabel.Location = new System.Drawing.Point(6, 43);
            this.Processeslabel.Name = "Processeslabel";
            this.Processeslabel.Size = new System.Drawing.Size(56, 13);
            this.Processeslabel.TabIndex = 0;
            this.Processeslabel.Text = "Processes";
            // 
            // processesvaluelabel
            // 
            this.processesvaluelabel.AutoSize = true;
            this.processesvaluelabel.Location = new System.Drawing.Point(106, 43);
            this.processesvaluelabel.Name = "processesvaluelabel";
            this.processesvaluelabel.Size = new System.Drawing.Size(9, 13);
            this.processesvaluelabel.TabIndex = 0;
            this.processesvaluelabel.Text = "l";
            // 
            // threadsvaluelabel
            // 
            this.threadsvaluelabel.AutoSize = true;
            this.threadsvaluelabel.Location = new System.Drawing.Point(107, 16);
            this.threadsvaluelabel.Name = "threadsvaluelabel";
            this.threadsvaluelabel.Size = new System.Drawing.Size(9, 13);
            this.threadsvaluelabel.TabIndex = 0;
            this.threadsvaluelabel.Text = "l";
            // 
            // threadslabel
            // 
            this.threadslabel.AutoSize = true;
            this.threadslabel.Location = new System.Drawing.Point(7, 16);
            this.threadslabel.Name = "threadslabel";
            this.threadslabel.Size = new System.Drawing.Size(46, 13);
            this.threadslabel.TabIndex = 0;
            this.threadslabel.Text = "Threads";
            // 
            // phmemeorygroupBox
            // 
            this.phmemeorygroupBox.Controls.Add(this.writecopiesvaluevalue);
            this.phmemeorygroupBox.Controls.Add(this.freelabel);
            this.phmemeorygroupBox.Controls.Add(this.avilablevalue);
            this.phmemeorygroupBox.Controls.Add(this.avilablelabel);
            this.phmemeorygroupBox.Controls.Add(this.totalvalue);
            this.phmemeorygroupBox.Controls.Add(this.totallabel);
            this.phmemeorygroupBox.Location = new System.Drawing.Point(17, 212);
            this.phmemeorygroupBox.Name = "phmemeorygroupBox";
            this.phmemeorygroupBox.Size = new System.Drawing.Size(167, 83);
            this.phmemeorygroupBox.TabIndex = 18;
            this.phmemeorygroupBox.TabStop = false;
            this.phmemeorygroupBox.Text = "Physical Memory";
            // 
            // writecopiesvaluevalue
            // 
            this.writecopiesvaluevalue.AutoSize = true;
            this.writecopiesvaluevalue.Location = new System.Drawing.Point(107, 67);
            this.writecopiesvaluevalue.Name = "writecopiesvaluevalue";
            this.writecopiesvaluevalue.Size = new System.Drawing.Size(31, 13);
            this.writecopiesvaluevalue.TabIndex = 1;
            this.writecopiesvaluevalue.Text = "Total";
            // 
            // freelabel
            // 
            this.freelabel.AutoSize = true;
            this.freelabel.Location = new System.Drawing.Point(6, 67);
            this.freelabel.Name = "freelabel";
            this.freelabel.Size = new System.Drawing.Size(89, 13);
            this.freelabel.TabIndex = 0;
            this.freelabel.Text = "Write Copies/sec";
            // 
            // avilablevalue
            // 
            this.avilablevalue.AutoSize = true;
            this.avilablevalue.Location = new System.Drawing.Point(109, 43);
            this.avilablevalue.Name = "avilablevalue";
            this.avilablevalue.Size = new System.Drawing.Size(31, 13);
            this.avilablevalue.TabIndex = 1;
            this.avilablevalue.Text = "Total";
            // 
            // avilablelabel
            // 
            this.avilablelabel.AutoSize = true;
            this.avilablelabel.Location = new System.Drawing.Point(6, 43);
            this.avilablelabel.Name = "avilablelabel";
            this.avilablelabel.Size = new System.Drawing.Size(44, 13);
            this.avilablelabel.TabIndex = 0;
            this.avilablelabel.Text = "Avilable";
            // 
            // totalvalue
            // 
            this.totalvalue.AutoSize = true;
            this.totalvalue.Location = new System.Drawing.Point(109, 16);
            this.totalvalue.Name = "totalvalue";
            this.totalvalue.Size = new System.Drawing.Size(31, 13);
            this.totalvalue.TabIndex = 1;
            this.totalvalue.Text = "Total";
            // 
            // totallabel
            // 
            this.totallabel.AutoSize = true;
            this.totallabel.Location = new System.Drawing.Point(6, 16);
            this.totallabel.Name = "totallabel";
            this.totallabel.Size = new System.Drawing.Size(31, 13);
            this.totallabel.TabIndex = 0;
            this.totallabel.Text = "Total";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cpuchart);
            this.groupBox1.Location = new System.Drawing.Point(17, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 138);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cpu Usage History";
            // 
            // cpuchart
            // 
            this.cpuchart.BackColor = System.Drawing.Color.Silver;
            chartArea3.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea3.AxisY.LineWidth = 0;
            chartArea3.Name = "ChartArea1";
            this.cpuchart.ChartAreas.Add(chartArea3);
            this.cpuchart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Enabled = false;
            legend3.Name = "Legend1";
            this.cpuchart.Legends.Add(legend3);
            this.cpuchart.Location = new System.Drawing.Point(3, 16);
            this.cpuchart.Name = "cpuchart";
            this.cpuchart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series3.Color = System.Drawing.Color.Red;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            series3.ShadowOffset = 2;
            this.cpuchart.Series.Add(series3);
            this.cpuchart.Size = new System.Drawing.Size(347, 119);
            this.cpuchart.TabIndex = 0;
            this.cpuchart.Text = "chart1";
            // 
            // usertabPage
            // 
            this.usertabPage.Controls.Add(this.logoffbutton);
            this.usertabPage.Controls.Add(this.userlistBox);
            this.usertabPage.Location = new System.Drawing.Point(4, 22);
            this.usertabPage.Name = "usertabPage";
            this.usertabPage.Padding = new System.Windows.Forms.Padding(3);
            this.usertabPage.Size = new System.Drawing.Size(367, 317);
            this.usertabPage.TabIndex = 3;
            this.usertabPage.Text = "Users";
            this.usertabPage.UseVisualStyleBackColor = true;
            // 
            // logoffbutton
            // 
            this.logoffbutton.Location = new System.Drawing.Point(277, 289);
            this.logoffbutton.Name = "logoffbutton";
            this.logoffbutton.Size = new System.Drawing.Size(75, 23);
            this.logoffbutton.TabIndex = 14;
            this.logoffbutton.Text = "Log off";
            this.logoffbutton.UseVisualStyleBackColor = true;
            this.logoffbutton.Click += new System.EventHandler(this.logoffbutton_Click);
            // 
            // userlistBox
            // 
            this.userlistBox.FormattingEnabled = true;
            this.userlistBox.Location = new System.Drawing.Point(22, 20);
            this.userlistBox.Name = "userlistBox";
            this.userlistBox.Size = new System.Drawing.Size(330, 264);
            this.userlistBox.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(367, 317);
            this.tabPage1.TabIndex = 5;
            this.tabPage1.Text = "Info";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.timelabel);
            this.groupBox3.Controls.Add(this.timevaluelabel);
            this.groupBox3.Controls.Add(this.datelabel);
            this.groupBox3.Controls.Add(this.datevaluelabel);
            this.groupBox3.Controls.Add(this.languagelabel);
            this.groupBox3.Controls.Add(this.languagevaluelabel);
            this.groupBox3.Location = new System.Drawing.Point(15, 129);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(336, 93);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Others Info";
            // 
            // timelabel
            // 
            this.timelabel.AutoSize = true;
            this.timelabel.Location = new System.Drawing.Point(6, 61);
            this.timelabel.Name = "timelabel";
            this.timelabel.Size = new System.Drawing.Size(30, 13);
            this.timelabel.TabIndex = 0;
            this.timelabel.Text = "Time";
            // 
            // timevaluelabel
            // 
            this.timevaluelabel.AutoSize = true;
            this.timevaluelabel.Location = new System.Drawing.Point(143, 61);
            this.timevaluelabel.Name = "timevaluelabel";
            this.timevaluelabel.Size = new System.Drawing.Size(31, 13);
            this.timevaluelabel.TabIndex = 1;
            this.timevaluelabel.Text = "Total";
            // 
            // datelabel
            // 
            this.datelabel.AutoSize = true;
            this.datelabel.Location = new System.Drawing.Point(6, 38);
            this.datelabel.Name = "datelabel";
            this.datelabel.Size = new System.Drawing.Size(30, 13);
            this.datelabel.TabIndex = 0;
            this.datelabel.Text = "Date";
            // 
            // datevaluelabel
            // 
            this.datevaluelabel.AutoSize = true;
            this.datevaluelabel.Location = new System.Drawing.Point(143, 38);
            this.datevaluelabel.Name = "datevaluelabel";
            this.datevaluelabel.Size = new System.Drawing.Size(31, 13);
            this.datevaluelabel.TabIndex = 1;
            this.datevaluelabel.Text = "Total";
            // 
            // languagelabel
            // 
            this.languagelabel.AutoSize = true;
            this.languagelabel.Location = new System.Drawing.Point(6, 16);
            this.languagelabel.Name = "languagelabel";
            this.languagelabel.Size = new System.Drawing.Size(61, 13);
            this.languagelabel.TabIndex = 0;
            this.languagelabel.Text = "Languague";
            // 
            // languagevaluelabel
            // 
            this.languagevaluelabel.AutoSize = true;
            this.languagevaluelabel.Location = new System.Drawing.Point(143, 16);
            this.languagevaluelabel.Name = "languagevaluelabel";
            this.languagevaluelabel.Size = new System.Drawing.Size(31, 13);
            this.languagevaluelabel.TabIndex = 1;
            this.languagevaluelabel.Text = "Total";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.osversionlabel);
            this.groupBox2.Controls.Add(this.osversionvaluelabel);
            this.groupBox2.Controls.Add(this.platformlabel);
            this.groupBox2.Controls.Add(this.platformvaluelabel);
            this.groupBox2.Controls.Add(this.oslabel);
            this.groupBox2.Controls.Add(this.osnamelabel);
            this.groupBox2.Location = new System.Drawing.Point(15, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(336, 93);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Os Info";
            // 
            // osversionlabel
            // 
            this.osversionlabel.AutoSize = true;
            this.osversionlabel.Location = new System.Drawing.Point(6, 61);
            this.osversionlabel.Name = "osversionlabel";
            this.osversionlabel.Size = new System.Drawing.Size(42, 13);
            this.osversionlabel.TabIndex = 0;
            this.osversionlabel.Text = "Version";
            // 
            // osversionvaluelabel
            // 
            this.osversionvaluelabel.AutoSize = true;
            this.osversionvaluelabel.Location = new System.Drawing.Point(143, 61);
            this.osversionvaluelabel.Name = "osversionvaluelabel";
            this.osversionvaluelabel.Size = new System.Drawing.Size(31, 13);
            this.osversionvaluelabel.TabIndex = 1;
            this.osversionvaluelabel.Text = "Total";
            // 
            // platformlabel
            // 
            this.platformlabel.AutoSize = true;
            this.platformlabel.Location = new System.Drawing.Point(6, 38);
            this.platformlabel.Name = "platformlabel";
            this.platformlabel.Size = new System.Drawing.Size(45, 13);
            this.platformlabel.TabIndex = 0;
            this.platformlabel.Text = "Platform";
            // 
            // platformvaluelabel
            // 
            this.platformvaluelabel.AutoSize = true;
            this.platformvaluelabel.Location = new System.Drawing.Point(143, 38);
            this.platformvaluelabel.Name = "platformvaluelabel";
            this.platformvaluelabel.Size = new System.Drawing.Size(31, 13);
            this.platformvaluelabel.TabIndex = 1;
            this.platformvaluelabel.Text = "Total";
            // 
            // oslabel
            // 
            this.oslabel.AutoSize = true;
            this.oslabel.Location = new System.Drawing.Point(6, 16);
            this.oslabel.Name = "oslabel";
            this.oslabel.Size = new System.Drawing.Size(35, 13);
            this.oslabel.TabIndex = 0;
            this.oslabel.Text = "Name";
            // 
            // osnamelabel
            // 
            this.osnamelabel.AutoSize = true;
            this.osnamelabel.Location = new System.Drawing.Point(143, 16);
            this.osnamelabel.Name = "osnamelabel";
            this.osnamelabel.Size = new System.Drawing.Size(31, 13);
            this.osnamelabel.TabIndex = 1;
            this.osnamelabel.Text = "Total";
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.statusStrip, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.menuStrip, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.tabControl, 0, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.670103F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.3299F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(381, 390);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.SystemColors.Control;
            this.statusStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.processtoolStripStatusLabel,
            this.toolStripStatusLabel1,
            this.cputoolStripStatusLabel,
            this.toolStripStatusLabel2,
            this.memorytoolStripStatusLabel});
            this.statusStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.statusStrip.Location = new System.Drawing.Point(0, 369);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(381, 21);
            this.statusStrip.TabIndex = 18;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(64, 16);
            this.toolStripStatusLabel.Text = "Processes :";
            // 
            // processtoolStripStatusLabel
            // 
            this.processtoolStripStatusLabel.Name = "processtoolStripStatusLabel";
            this.processtoolStripStatusLabel.Size = new System.Drawing.Size(0, 16);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(70, 16);
            this.toolStripStatusLabel1.Text = "Cpu Usage :";
            // 
            // cputoolStripStatusLabel
            // 
            this.cputoolStripStatusLabel.Name = "cputoolStripStatusLabel";
            this.cputoolStripStatusLabel.Size = new System.Drawing.Size(0, 16);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(103, 16);
            this.toolStripStatusLabel2.Text = "Avilable Memory :";
            // 
            // memorytoolStripStatusLabel
            // 
            this.memorytoolStripStatusLabel.Name = "memorytoolStripStatusLabel";
            this.memorytoolStripStatusLabel.Size = new System.Drawing.Size(0, 16);
            // 
            // performanceCounter1
            // 
            this.performanceCounter1.CategoryName = "Memory";
            this.performanceCounter1.CounterName = "Write Copies/sec";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(381, 390);
            this.Controls.Add(this.tableLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximumSize = new System.Drawing.Size(397, 429);
            this.MinimumSize = new System.Drawing.Size(397, 429);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaskShop";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.applicationtabPage.ResumeLayout(false);
            this.processtabPage.ResumeLayout(false);
            this.servicetabPage.ResumeLayout(false);
            this.performancetabPage.ResumeLayout(false);
            this.systemgroupBox.ResumeLayout(false);
            this.systemgroupBox.PerformLayout();
            this.phmemeorygroupBox.ResumeLayout(false);
            this.phmemeorygroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cpuchart)).EndInit();
            this.usertabPage.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage applicationtabPage;
        private System.Windows.Forms.Button newtaskbutton;
        private System.Windows.Forms.Button endtaskbutton;
        private System.Windows.Forms.ListBox applicationlistBox;
        private System.Windows.Forms.TabPage processtabPage;
        private System.Windows.Forms.ListBox processlistBox;
        private System.Windows.Forms.Button endprocessbutton;
        private System.Windows.Forms.TabPage servicetabPage;
        private System.Windows.Forms.ListBox servicelistBox;
        private System.Windows.Forms.TabPage performancetabPage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage usertabPage;
        private System.Windows.Forms.Button logoffbutton;
        private System.Windows.Forms.ListBox userlistBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.GroupBox phmemeorygroupBox;
        private System.Windows.Forms.Label writecopiesvaluevalue;
        private System.Windows.Forms.Label freelabel;
        private System.Windows.Forms.Label avilablevalue;
        private System.Windows.Forms.Label avilablelabel;
        private System.Windows.Forms.Label totalvalue;
        private System.Windows.Forms.Label totallabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart cpuchart;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel processtoolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel cputoolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel memorytoolStripStatusLabel;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label osversionlabel;
        private System.Windows.Forms.Label osversionvaluelabel;
        private System.Windows.Forms.Label platformlabel;
        private System.Windows.Forms.Label platformvaluelabel;
        private System.Windows.Forms.Label oslabel;
        private System.Windows.Forms.Label osnamelabel;
        private System.Diagnostics.PerformanceCounter performanceCounter;
        private System.Windows.Forms.GroupBox systemgroupBox;
        private System.Windows.Forms.Label systemcallvaluelabel;
        private System.Windows.Forms.Label systemcalllabel;
        private System.Windows.Forms.Label Processeslabel;
        private System.Windows.Forms.Label processesvaluelabel;
        private System.Windows.Forms.Label threadsvaluelabel;
        private System.Windows.Forms.Label threadslabel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label timelabel;
        private System.Windows.Forms.Label timevaluelabel;
        private System.Windows.Forms.Label datelabel;
        private System.Windows.Forms.Label datevaluelabel;
        private System.Windows.Forms.Label languagelabel;
        private System.Windows.Forms.Label languagevaluelabel;
        private System.Diagnostics.PerformanceCounter performanceCounter1;



    }
}

