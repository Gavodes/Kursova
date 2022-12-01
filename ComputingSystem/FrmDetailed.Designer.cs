namespace ComputingSystem
{
    partial class FrmDetailed 
    {

        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblintensity = new System.Windows.Forms.Label();
            this.lblMinBurstTime = new System.Windows.Forms.Label();
            this.lblMaxBurstTime = new System.Windows.Forms.Label();
            this.lblRamSize = new System.Windows.Forms.Label();
            this.lblMinAddrSpace = new System.Windows.Forms.Label();
            this.lblMaxAddrSpace = new System.Windows.Forms.Label();
            this.lblRam = new System.Windows.Forms.Label();
            this.lblFreeRamSize = new System.Windows.Forms.Label();
            this.lblOccupiedSize = new System.Windows.Forms.Label();
            this.nudIntensity = new System.Windows.Forms.NumericUpDown();
            this.nudBurstMax = new System.Windows.Forms.NumericUpDown();
            this.cbRamSize = new System.Windows.Forms.ComboBox();
            this.nudAddrSpaceMin = new System.Windows.Forms.NumericUpDown();
            this.nudAddrSpaceMax = new System.Windows.Forms.NumericUpDown();
            this.pnlSettings = new System.Windows.Forms.Panel();
            this.rbAuto = new System.Windows.Forms.RadioButton();
            this.rbManual = new System.Windows.Forms.RadioButton();
            this.btnSessionEnd = new System.Windows.Forms.Button();
            this.lblMode = new System.Windows.Forms.Label();
            this.btnWork = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.tbProductivity = new System.Windows.Forms.TextBox();
            this.lblPerformance = new System.Windows.Forms.Label();
            this.tbCpuUtil = new System.Windows.Forms.TextBox();
            this.hardCPU = new System.Windows.Forms.Label();
            this.tlPanelSettings = new System.Windows.Forms.TableLayoutPanel();
            this.nudBurstMin = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblFreeMemValue = new System.Windows.Forms.Label();
            this.lblOccupiedMemValue = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbDevice2 = new System.Windows.Forms.TextBox();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.lbDeviceQueue2 = new System.Windows.Forms.ListBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.lbDeviceQueue1 = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.lbCPUQueue = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbCPU = new System.Windows.Forms.TextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbDevice1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudIntensity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBurstMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddrSpaceMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddrSpaceMax)).BeginInit();
            this.pnlSettings.SuspendLayout();
            this.tlPanelSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBurstMin)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            this.lblintensity.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblintensity.Location = new System.Drawing.Point(3, 0);
            this.lblintensity.Name = "lblintensity";
            this.lblintensity.Size = new System.Drawing.Size(145, 46);
            this.lblintensity.TabIndex = 20;
            this.lblintensity.Text = "Интенсивность поступления процессов";
            this.lblMinBurstTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMinBurstTime.Location = new System.Drawing.Point(154, 0);
            this.lblMinBurstTime.Name = "lblMinBurstTime";
            this.lblMinBurstTime.Size = new System.Drawing.Size(145, 63);
            this.lblMinBurstTime.TabIndex = 21;
            this.lblMinBurstTime.Text = "Минимальное значение промежутка работы на ЦП";
            this.lblMaxBurstTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMaxBurstTime.Location = new System.Drawing.Point(305, 0);
            this.lblMaxBurstTime.Name = "lblMaxBurstTime";
            this.lblMaxBurstTime.Size = new System.Drawing.Size(145, 63);
            this.lblMaxBurstTime.TabIndex = 22;
            this.lblMaxBurstTime.Text = "Максимальное значение промежутка работы на ЦП";
            this.lblRamSize.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRamSize.Location = new System.Drawing.Point(456, 0);
            this.lblRamSize.Name = "lblRamSize";
            this.lblRamSize.Size = new System.Drawing.Size(145, 46);
            this.lblRamSize.TabIndex = 23;
            this.lblRamSize.Text = "Размер оперативной памяти"; 
            this.lblMinAddrSpace.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMinAddrSpace.Location = new System.Drawing.Point(607, 0);
            this.lblMinAddrSpace.Name = "lblMinAddrSpace";
            this.lblMinAddrSpace.Size = new System.Drawing.Size(137, 62);
            this.lblMinAddrSpace.TabIndex = 24;
            this.lblMinAddrSpace.Text = "Минимальный размер адресного пространства процесса ";
            this.lblMaxAddrSpace.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMaxAddrSpace.Location = new System.Drawing.Point(750, 0);
            this.lblMaxAddrSpace.Name = "lblMaxAddrSpace";
            this.lblMaxAddrSpace.Size = new System.Drawing.Size(141, 62);
            this.lblMaxAddrSpace.TabIndex = 25;
            this.lblMaxAddrSpace.Text = "Максимальный размер адресного пространства процесса ";
            this.lblRam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRam.Location = new System.Drawing.Point(3, 0);
            this.lblRam.Name = "lblRam";
            this.lblRam.Size = new System.Drawing.Size(217, 20);
            this.lblRam.TabIndex = 30;
            this.lblRam.Text = "Оперативная память";
            this.lblFreeRamSize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFreeRamSize.Location = new System.Drawing.Point(61, 23);
            this.lblFreeRamSize.Name = "lblFreeRamSize";
            this.lblFreeRamSize.Size = new System.Drawing.Size(159, 22);
            this.lblFreeRamSize.TabIndex = 31;
            this.lblFreeRamSize.Text = "Размер свободной памяти:";
            this.lblOccupiedSize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblOccupiedSize.Location = new System.Drawing.Point(449, 23);
            this.lblOccupiedSize.Name = "lblOccupiedSize";
            this.lblOccupiedSize.Size = new System.Drawing.Size(217, 22);
            this.lblOccupiedSize.TabIndex = 32;
            this.lblOccupiedSize.Text = "Размер памяти, занятой процессами:";
            this.nudIntensity.DecimalPlaces = 1;
            this.nudIntensity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudIntensity.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudIntensity.Location = new System.Drawing.Point(3, 71);
            this.nudIntensity.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudIntensity.Name = "nudIntensity";
            this.nudIntensity.Size = new System.Drawing.Size(145, 23);
            this.nudIntensity.TabIndex = 21;
            this.nudIntensity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0}); 
            this.nudBurstMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudBurstMax.Location = new System.Drawing.Point(305, 71);
            this.nudBurstMax.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudBurstMax.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudBurstMax.Name = "nudBurstMax";
            this.nudBurstMax.Size = new System.Drawing.Size(145, 23);
            this.nudBurstMax.TabIndex = 23;
            this.nudBurstMax.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.cbRamSize.AutoCompleteCustomSource.AddRange(new string[] {
            "32000",
            "64000"});
            this.cbRamSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbRamSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRamSize.FormattingEnabled = true;
            this.cbRamSize.Items.AddRange(new object[] {
            "2000",
            "4000",
            "8000",
            "16000",
            "32000"});
            this.cbRamSize.Location = new System.Drawing.Point(456, 71);
            this.cbRamSize.Name = "cbRamSize";
            this.cbRamSize.Size = new System.Drawing.Size(145, 23);
            this.cbRamSize.TabIndex = 24;
            this.nudAddrSpaceMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudAddrSpaceMin.Location = new System.Drawing.Point(607, 71);
            this.nudAddrSpaceMin.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudAddrSpaceMin.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudAddrSpaceMin.Name = "nudAddrSpaceMin";
            this.nudAddrSpaceMin.Size = new System.Drawing.Size(137, 23);
            this.nudAddrSpaceMin.TabIndex = 24;
            this.nudAddrSpaceMin.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudAddrSpaceMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudAddrSpaceMax.Location = new System.Drawing.Point(750, 71);
            this.nudAddrSpaceMax.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudAddrSpaceMax.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudAddrSpaceMax.Name = "nudAddrSpaceMax";
            this.nudAddrSpaceMax.Size = new System.Drawing.Size(141, 23);
            this.nudAddrSpaceMax.TabIndex = 25;
            this.nudAddrSpaceMax.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.pnlSettings.AutoSize = true;
            this.pnlSettings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSettings.Controls.Add(this.rbAuto);
            this.pnlSettings.Controls.Add(this.rbManual);
            this.pnlSettings.Controls.Add(this.btnSessionEnd);
            this.pnlSettings.Controls.Add(this.lblMode);
            this.pnlSettings.Controls.Add(this.btnWork);
            this.pnlSettings.Controls.Add(this.lblTime);
            this.pnlSettings.Controls.Add(this.btnStart);
            this.pnlSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSettings.Location = new System.Drawing.Point(0, 515);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(894, 52);
            this.pnlSettings.TabIndex = 33;
            this.rbAuto.AutoSize = true;
            this.rbAuto.Location = new System.Drawing.Point(166, 26);
            this.rbAuto.Name = "rbAuto";
            this.rbAuto.Size = new System.Drawing.Size(117, 19);
            this.rbAuto.TabIndex = 16;
            this.rbAuto.Text = "Автоматический";
            this.rbAuto.UseVisualStyleBackColor = true;
            this.rbAuto.CheckedChanged += new System.EventHandler(this.rbAuto_CheckedChanged);
            this.rbManual.AutoSize = true;
            this.rbManual.Checked = true;
            this.rbManual.Location = new System.Drawing.Point(94, 26);
            this.rbManual.Name = "rbManual";
            this.rbManual.Size = new System.Drawing.Size(66, 19);
            this.rbManual.TabIndex = 15;
            this.rbManual.TabStop = true;
            this.rbManual.Text = "Ручной";
            this.rbManual.UseVisualStyleBackColor = true;
            this.rbManual.CheckedChanged += new System.EventHandler(this.rbManual_CheckedChanged);
            this.btnSessionEnd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSessionEnd.Location = new System.Drawing.Point(757, 3);
            this.btnSessionEnd.Name = "btnSessionEnd";
            this.btnSessionEnd.Size = new System.Drawing.Size(129, 42);
            this.btnSessionEnd.TabIndex = 13;
            this.btnSessionEnd.Text = "Завершение сеанса";
            this.btnSessionEnd.UseVisualStyleBackColor = true;
            this.btnSessionEnd.Click += new System.EventHandler(this.btnSessionEnd_Click);
            this.lblMode.Location = new System.Drawing.Point(94, 4);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(91, 19);
            this.lblMode.TabIndex = 33;
            this.lblMode.Text = "Режим работы"; 
            this.btnWork.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnWork.Location = new System.Drawing.Point(621, 3);
            this.btnWork.Name = "btnWork";
            this.btnWork.Size = new System.Drawing.Size(130, 42);
            this.btnWork.TabIndex = 12;
            this.btnWork.Text = "Рабочий такт";
            this.btnWork.UseVisualStyleBackColor = true;
            this.btnWork.Click += new System.EventHandler(this.btnWork_Click);
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(24, 16);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(13, 15);
            this.lblTime.TabIndex = 34;
            this.lblTime.Text = "0";
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnStart.AutoSize = true;
            this.btnStart.Location = new System.Drawing.Point(470, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(145, 41);
            this.btnStart.TabIndex = 11;
            this.btnStart.Text = "Сохранение настроек";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            this.tbProductivity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbProductivity.Location = new System.Drawing.Point(746, 55);
            this.tbProductivity.Name = "tbProductivity";
            this.tbProductivity.ReadOnly = true;
            this.tbProductivity.Size = new System.Drawing.Size(70, 23);
            this.tbProductivity.TabIndex = 38;
            this.lblPerformance.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPerformance.AutoSize = true;
            this.lblPerformance.Location = new System.Drawing.Point(543, 59);
            this.lblPerformance.Name = "lblPerformance";
            this.lblPerformance.Size = new System.Drawing.Size(123, 15);
            this.lblPerformance.TabIndex = 37;
            this.lblPerformance.Text = "Производительность";
            this.tbCpuUtil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbCpuUtil.Location = new System.Drawing.Point(299, 55);
            this.tbCpuUtil.Name = "tbCpuUtil";
            this.tbCpuUtil.ReadOnly = true;
            this.tbCpuUtil.Size = new System.Drawing.Size(70, 23);
            this.tbCpuUtil.TabIndex = 36;
            this.hardCPU.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.hardCPU.AutoSize = true;
            this.hardCPU.Location = new System.Drawing.Point(60, 59);
            this.hardCPU.Name = "hardCPU";
            this.hardCPU.Size = new System.Drawing.Size(160, 15);
            this.hardCPU.TabIndex = 35;
            this.hardCPU.Text = "Загруженность процессора";
            this.tlPanelSettings.ColumnCount = 6;
            this.tlPanelSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tlPanelSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tlPanelSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tlPanelSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tlPanelSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tlPanelSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tlPanelSettings.Controls.Add(this.nudAddrSpaceMax, 5, 1);
            this.tlPanelSettings.Controls.Add(this.nudAddrSpaceMin, 4, 1);
            this.tlPanelSettings.Controls.Add(this.lblMaxAddrSpace, 5, 0);
            this.tlPanelSettings.Controls.Add(this.lblMinAddrSpace, 4, 0);
            this.tlPanelSettings.Controls.Add(this.cbRamSize, 3, 1);
            this.tlPanelSettings.Controls.Add(this.nudBurstMax, 2, 1);
            this.tlPanelSettings.Controls.Add(this.lblRamSize, 3, 0);
            this.tlPanelSettings.Controls.Add(this.lblMaxBurstTime, 2, 0);
            this.tlPanelSettings.Controls.Add(this.nudIntensity, 0, 1);
            this.tlPanelSettings.Controls.Add(this.lblMinBurstTime, 1, 0);
            this.tlPanelSettings.Controls.Add(this.lblintensity, 0, 0);
            this.tlPanelSettings.Controls.Add(this.nudBurstMin, 1, 1);
            this.tlPanelSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlPanelSettings.Location = new System.Drawing.Point(0, 0);
            this.tlPanelSettings.Name = "tlPanelSettings";
            this.tlPanelSettings.RowCount = 2;
            this.tlPanelSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.76471F));
            this.tlPanelSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.23529F));
            this.tlPanelSettings.Size = new System.Drawing.Size(894, 95);
            this.tlPanelSettings.TabIndex = 46;
            this.nudBurstMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudBurstMin.Location = new System.Drawing.Point(154, 71);
            this.nudBurstMin.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudBurstMin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBurstMin.Name = "nudBurstMin";
            this.nudBurstMin.Size = new System.Drawing.Size(145, 23);
            this.nudBurstMin.TabIndex = 24;
            this.nudBurstMin.Value = new decimal(new int[] {
            2,
            0,
            0,
            0}); 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.tbProductivity, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblFreeRamSize, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblPerformance, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblRam, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.hardCPU, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblFreeMemValue, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblOccupiedMemValue, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblOccupiedSize, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.tbCpuUtil, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 431);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.81633F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.18367F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(894, 84);
            this.tableLayoutPanel2.TabIndex = 47; 
            this.lblFreeMemValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFreeMemValue.AutoSize = true;
            this.lblFreeMemValue.Location = new System.Drawing.Point(328, 27);
            this.lblFreeMemValue.Name = "lblFreeMemValue";
            this.lblFreeMemValue.Size = new System.Drawing.Size(13, 15);
            this.lblFreeMemValue.TabIndex = 33;
            this.lblFreeMemValue.Text = "0";
            this.lblOccupiedMemValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOccupiedMemValue.AutoSize = true;
            this.lblOccupiedMemValue.Location = new System.Drawing.Point(775, 27);
            this.lblOccupiedMemValue.Name = "lblOccupiedMemValue";
            this.lblOccupiedMemValue.Size = new System.Drawing.Size(13, 15);
            this.lblOccupiedMemValue.TabIndex = 34;
            this.lblOccupiedMemValue.Text = "0";
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.btnWork_Click); 
            this.groupBox13.Controls.Add(this.label15);
            this.groupBox13.Controls.Add(this.tbDevice2);
            this.groupBox13.Location = new System.Drawing.Point(456, 329);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(432, 91);
            this.groupBox13.TabIndex = 49;
            this.groupBox13.TabStop = false;
            this.label15.Location = new System.Drawing.Point(7, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(141, 15);
            this.label15.TabIndex = 27;
            this.label15.Text = "Внешнее устройство 2";
            this.tbDevice2.Location = new System.Drawing.Point(7, 18);
            this.tbDevice2.Multiline = true;
            this.tbDevice2.Name = "tbDevice2";
            this.tbDevice2.ReadOnly = true;
            this.tbDevice2.Size = new System.Drawing.Size(419, 64);
            this.tbDevice2.TabIndex = 0;
            this.groupBox15.Controls.Add(this.lbDeviceQueue2);
            this.groupBox15.Controls.Add(this.label17);
            this.groupBox15.Location = new System.Drawing.Point(3, 327);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(447, 91);
            this.groupBox15.TabIndex = 52;
            this.groupBox15.TabStop = false;
            this.lbDeviceQueue2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDeviceQueue2.FormattingEnabled = true;
            this.lbDeviceQueue2.ItemHeight = 15;
            this.lbDeviceQueue2.Location = new System.Drawing.Point(5, 20);
            this.lbDeviceQueue2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbDeviceQueue2.Name = "lbDeviceQueue2";
            this.lbDeviceQueue2.Size = new System.Drawing.Size(436, 64);
            this.lbDeviceQueue2.TabIndex = 29; 
            this.label17.Location = new System.Drawing.Point(8, 2);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(221, 16);
            this.label17.TabIndex = 29;
            this.label17.Text = "Очередь к внешнему устройству 2\r\n";
            this.groupBox12.Controls.Add(this.lbDeviceQueue1);
            this.groupBox12.Controls.Add(this.label10);
            this.groupBox12.Location = new System.Drawing.Point(5, 239);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(445, 87);
            this.groupBox12.TabIndex = 53;
            this.groupBox12.TabStop = false;
            this.lbDeviceQueue1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDeviceQueue1.FormattingEnabled = true;
            this.lbDeviceQueue1.ItemHeight = 15;
            this.lbDeviceQueue1.Location = new System.Drawing.Point(5, 20);
            this.lbDeviceQueue1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbDeviceQueue1.Name = "lbDeviceQueue1";
            this.lbDeviceQueue1.Size = new System.Drawing.Size(434, 64);
            this.lbDeviceQueue1.TabIndex = 29; 
            this.label10.Location = new System.Drawing.Point(8, 2);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(221, 16);
            this.label10.TabIndex = 29;
            this.label10.Text = "Очередь к внешнему устройству 1"; 
            this.groupBox11.Controls.Add(this.lbCPUQueue);
            this.groupBox11.Controls.Add(this.label9);
            this.groupBox11.Location = new System.Drawing.Point(0, 101);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(450, 132);
            this.groupBox11.TabIndex = 51;
            this.groupBox11.TabStop = false;
            this.lbCPUQueue.FormattingEnabled = true;
            this.lbCPUQueue.ItemHeight = 15;
            this.lbCPUQueue.Location = new System.Drawing.Point(5, 20);
            this.lbCPUQueue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbCPUQueue.Name = "lbCPUQueue";
            this.lbCPUQueue.Size = new System.Drawing.Size(439, 109);
            this.lbCPUQueue.TabIndex = 29;
            this.label9.Location = new System.Drawing.Point(5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(242, 16);
            this.label9.TabIndex = 28;
            this.label9.Text = "Очередь к центральному процессору\r\n";
            this.groupBox10.Controls.Add(this.label7);
            this.groupBox10.Controls.Add(this.tbCPU);
            this.groupBox10.Location = new System.Drawing.Point(456, 101);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(432, 135);
            this.groupBox10.TabIndex = 50;
            this.groupBox10.TabStop = false;
            this.label7.Location = new System.Drawing.Point(5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 15);
            this.label7.TabIndex = 26;
            this.label7.Text = "Центральный процесор";
            this.tbCPU.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbCPU.Location = new System.Drawing.Point(6, 18);
            this.tbCPU.Multiline = true;
            this.tbCPU.Name = "tbCPU";
            this.tbCPU.ReadOnly = true;
            this.tbCPU.Size = new System.Drawing.Size(420, 111);
            this.tbCPU.TabIndex = 2;
            this.groupBox9.Controls.Add(this.label8);
            this.groupBox9.Controls.Add(this.tbDevice1);
            this.groupBox9.Location = new System.Drawing.Point(456, 239);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(432, 87);
            this.groupBox9.TabIndex = 48;
            this.groupBox9.TabStop = false;
            this.label8.Location = new System.Drawing.Point(7, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 15);
            this.label8.TabIndex = 27;
            this.label8.Text = "Внешнее устройство 1\r\n";
            this.tbDevice1.Location = new System.Drawing.Point(7, 18);
            this.tbDevice1.Multiline = true;
            this.tbDevice1.Name = "tbDevice1";
            this.tbDevice1.ReadOnly = true;
            this.tbDevice1.Size = new System.Drawing.Size(419, 63);
            this.tbDevice1.TabIndex = 0;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(894, 567);
            this.Controls.Add(this.groupBox13);
            this.Controls.Add(this.groupBox15);
            this.Controls.Add(this.groupBox12);
            this.Controls.Add(this.groupBox11);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tlPanelSettings);
            this.Controls.Add(this.pnlSettings);
            this.MinimumSize = new System.Drawing.Size(910, 606);
            this.Name = "FrmDetailed";
            this.Text = "Kursova";
            ((System.ComponentModel.ISupportInitialize)(this.nudIntensity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBurstMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddrSpaceMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddrSpaceMax)).EndInit();
            this.pnlSettings.ResumeLayout(false);
            this.pnlSettings.PerformLayout();
            this.tlPanelSettings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudBurstMin)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox15.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblintensity;
        private System.Windows.Forms.Label lblMinBurstTime;
        private System.Windows.Forms.Label lblMaxBurstTime;
        private System.Windows.Forms.Label lblRamSize;
        private System.Windows.Forms.Label lblMinAddrSpace;
        private System.Windows.Forms.Label lblMaxAddrSpace;
        private System.Windows.Forms.Label lblRam;
        private System.Windows.Forms.Label lblFreeRamSize;
        private System.Windows.Forms.Label lblOccupiedSize;
        private System.Windows.Forms.ComboBox cbRamSize;
        private System.Windows.Forms.NumericUpDown nudIntensity;
        
        private System.Windows.Forms.NumericUpDown nudAddrSpaceMax;
        private System.Windows.Forms.NumericUpDown nudAddrSpaceMin;
        private System.Windows.Forms.NumericUpDown nudBurstMax;
        private System.Windows.Forms.Panel pnlSettings;
        private System.Windows.Forms.RadioButton rbAuto;
        private System.Windows.Forms.RadioButton rbManual;
        private System.Windows.Forms.Button btnSessionEnd;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.Button btnWork;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TableLayoutPanel tlPanelSettings;
        private System.Windows.Forms.NumericUpDown nudBurstMin;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblFreeMemValue;
        private System.Windows.Forms.Label lblOccupiedMemValue;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox tbCpuUtil;
        private System.Windows.Forms.Label hardCPU;
        private System.Windows.Forms.TextBox tbProductivity;
        private System.Windows.Forms.Label lblPerformance;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbDevice2;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.ListBox lbDeviceQueue2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.ListBox lbDeviceQueue1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.ListBox lbCPUQueue;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbCPU;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbDevice1;
    }
}

