namespace NI_Motion_test
{
    partial class NMC_Test
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;//提供容器的功能，容器是可以包含一个或多个组件的东西

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.xforward = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.rSpeed = new System.Windows.Forms.NumericUpDown();
            this.rDistance = new System.Windows.Forms.NumericUpDown();
            this.btn_continue = new System.Windows.Forms.Button();
            this.btn_move = new System.Windows.Forms.Button();
            this.btn_zero = new System.Windows.Forms.Button();
            this.btn_halt = new System.Windows.Forms.Button();
            this.zDistance = new System.Windows.Forms.NumericUpDown();
            this.zSpeed = new System.Windows.Forms.NumericUpDown();
            this.yDistance = new System.Windows.Forms.NumericUpDown();
            this.ySpeed = new System.Windows.Forms.NumericUpDown();
            this.xDistance = new System.Windows.Forms.NumericUpDown();
            this.xSpeed = new System.Windows.Forms.NumericUpDown();
            this.btn_stop = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.reset = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.rPos = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.zPos = new System.Windows.Forms.TextBox();
            this.yPos = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.xPos = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Cscan_btn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelScanAxis = new System.Windows.Forms.Label();
            this.cmbScanAxis = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.nudRange = new System.Windows.Forms.NumericUpDown();
            this.nudSpeed = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.force = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ySpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xSpeed)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "V(mm/s)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "D(mm)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 56);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 99);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Y";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 141);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Z";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.xforward);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.rSpeed);
            this.groupBox1.Controls.Add(this.rDistance);
            this.groupBox1.Controls.Add(this.btn_continue);
            this.groupBox1.Controls.Add(this.btn_move);
            this.groupBox1.Controls.Add(this.btn_zero);
            this.groupBox1.Controls.Add(this.btn_halt);
            this.groupBox1.Controls.Add(this.zDistance);
            this.groupBox1.Controls.Add(this.zSpeed);
            this.groupBox1.Controls.Add(this.yDistance);
            this.groupBox1.Controls.Add(this.ySpeed);
            this.groupBox1.Controls.Add(this.xDistance);
            this.groupBox1.Controls.Add(this.xSpeed);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(381, 294);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Motion";
            // 
            // xforward
            // 
            this.xforward.BackColor = System.Drawing.Color.PaleGreen;
            this.xforward.Location = new System.Drawing.Point(317, 51);
            this.xforward.Margin = new System.Windows.Forms.Padding(4);
            this.xforward.Name = "xforward";
            this.xforward.Size = new System.Drawing.Size(64, 29);
            this.xforward.TabIndex = 21;
            this.xforward.Text = "X+";
            this.xforward.UseVisualStyleBackColor = false;
            this.xforward.MouseDown += new System.Windows.Forms.MouseEventHandler(this.xforward_MouseDown);
            this.xforward.MouseUp += new System.Windows.Forms.MouseEventHandler(this.xforward_MouseUp);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 185);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(15, 15);
            this.label12.TabIndex = 20;
            this.label12.Text = "R";
            // 
            // rSpeed
            // 
            this.rSpeed.DecimalPlaces = 2;
            this.rSpeed.Location = new System.Drawing.Point(59, 182);
            this.rSpeed.Margin = new System.Windows.Forms.Padding(4);
            this.rSpeed.Name = "rSpeed";
            this.rSpeed.Size = new System.Drawing.Size(116, 25);
            this.rSpeed.TabIndex = 19;
            this.rSpeed.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // rDistance
            // 
            this.rDistance.DecimalPlaces = 2;
            this.rDistance.Location = new System.Drawing.Point(192, 182);
            this.rDistance.Margin = new System.Windows.Forms.Padding(4);
            this.rDistance.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.rDistance.Minimum = new decimal(new int[] {
            400,
            0,
            0,
            -2147483648});
            this.rDistance.Name = "rDistance";
            this.rDistance.Size = new System.Drawing.Size(116, 25);
            this.rDistance.TabIndex = 18;
            // 
            // btn_continue
            // 
            this.btn_continue.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_continue.Location = new System.Drawing.Point(284, 239);
            this.btn_continue.Margin = new System.Windows.Forms.Padding(4);
            this.btn_continue.Name = "btn_continue";
            this.btn_continue.Size = new System.Drawing.Size(89, 29);
            this.btn_continue.TabIndex = 16;
            this.btn_continue.Text = "continue";
            this.btn_continue.UseVisualStyleBackColor = false;
            this.btn_continue.Click += new System.EventHandler(this.btn_continue_Click);
            // 
            // btn_move
            // 
            this.btn_move.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_move.Location = new System.Drawing.Point(104, 239);
            this.btn_move.Margin = new System.Windows.Forms.Padding(4);
            this.btn_move.Name = "btn_move";
            this.btn_move.Size = new System.Drawing.Size(71, 29);
            this.btn_move.TabIndex = 12;
            this.btn_move.Text = "move";
            this.btn_move.UseVisualStyleBackColor = false;
            this.btn_move.Click += new System.EventHandler(this.btn_move_Click);
            // 
            // btn_zero
            // 
            this.btn_zero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_zero.ForeColor = System.Drawing.Color.Black;
            this.btn_zero.Location = new System.Drawing.Point(0, 239);
            this.btn_zero.Margin = new System.Windows.Forms.Padding(4);
            this.btn_zero.Name = "btn_zero";
            this.btn_zero.Size = new System.Drawing.Size(71, 29);
            this.btn_zero.TabIndex = 11;
            this.btn_zero.Text = "zero";
            this.btn_zero.UseVisualStyleBackColor = false;
            this.btn_zero.Click += new System.EventHandler(this.btn_zero_Click);
            // 
            // btn_halt
            // 
            this.btn_halt.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_halt.Location = new System.Drawing.Point(204, 239);
            this.btn_halt.Margin = new System.Windows.Forms.Padding(4);
            this.btn_halt.Name = "btn_halt";
            this.btn_halt.Size = new System.Drawing.Size(72, 29);
            this.btn_halt.TabIndex = 17;
            this.btn_halt.Text = "halt";
            this.btn_halt.UseVisualStyleBackColor = false;
            this.btn_halt.Click += new System.EventHandler(this.btn_halt_Click);
            // 
            // zDistance
            // 
            this.zDistance.DecimalPlaces = 2;
            this.zDistance.Location = new System.Drawing.Point(192, 139);
            this.zDistance.Margin = new System.Windows.Forms.Padding(4);
            this.zDistance.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.zDistance.Minimum = new decimal(new int[] {
            400,
            0,
            0,
            -2147483648});
            this.zDistance.Name = "zDistance";
            this.zDistance.Size = new System.Drawing.Size(116, 25);
            this.zDistance.TabIndex = 10;
            // 
            // zSpeed
            // 
            this.zSpeed.DecimalPlaces = 2;
            this.zSpeed.Location = new System.Drawing.Point(59, 139);
            this.zSpeed.Margin = new System.Windows.Forms.Padding(4);
            this.zSpeed.Name = "zSpeed";
            this.zSpeed.Size = new System.Drawing.Size(116, 25);
            this.zSpeed.TabIndex = 9;
            this.zSpeed.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // yDistance
            // 
            this.yDistance.DecimalPlaces = 2;
            this.yDistance.Location = new System.Drawing.Point(192, 96);
            this.yDistance.Margin = new System.Windows.Forms.Padding(4);
            this.yDistance.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.yDistance.Minimum = new decimal(new int[] {
            400,
            0,
            0,
            -2147483648});
            this.yDistance.Name = "yDistance";
            this.yDistance.Size = new System.Drawing.Size(116, 25);
            this.yDistance.TabIndex = 8;
            // 
            // ySpeed
            // 
            this.ySpeed.DecimalPlaces = 2;
            this.ySpeed.Location = new System.Drawing.Point(59, 96);
            this.ySpeed.Margin = new System.Windows.Forms.Padding(4);
            this.ySpeed.Name = "ySpeed";
            this.ySpeed.Size = new System.Drawing.Size(116, 25);
            this.ySpeed.TabIndex = 7;
            this.ySpeed.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // xDistance
            // 
            this.xDistance.DecimalPlaces = 2;
            this.xDistance.Location = new System.Drawing.Point(192, 54);
            this.xDistance.Margin = new System.Windows.Forms.Padding(4);
            this.xDistance.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.xDistance.Minimum = new decimal(new int[] {
            400,
            0,
            0,
            -2147483648});
            this.xDistance.Name = "xDistance";
            this.xDistance.Size = new System.Drawing.Size(116, 25);
            this.xDistance.TabIndex = 6;
            // 
            // xSpeed
            // 
            this.xSpeed.DecimalPlaces = 2;
            this.xSpeed.Location = new System.Drawing.Point(59, 54);
            this.xSpeed.Margin = new System.Windows.Forms.Padding(4);
            this.xSpeed.Name = "xSpeed";
            this.xSpeed.Size = new System.Drawing.Size(116, 25);
            this.xSpeed.TabIndex = 5;
            this.xSpeed.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // btn_stop
            // 
            this.btn_stop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_stop.Location = new System.Drawing.Point(428, 32);
            this.btn_stop.Margin = new System.Windows.Forms.Padding(4);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(71, 29);
            this.btn_stop.TabIndex = 13;
            this.btn_stop.Text = "stop";
            this.btn_stop.UseVisualStyleBackColor = false;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.reset);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.rPos);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.zPos);
            this.groupBox2.Controls.Add(this.yPos);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.xPos);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(405, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(237, 294);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Position";
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.reset.Location = new System.Drawing.Point(63, 236);
            this.reset.Margin = new System.Windows.Forms.Padding(4);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(89, 29);
            this.reset.TabIndex = 18;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(165, 182);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 15);
            this.label16.TabIndex = 17;
            this.label16.Text = "angle";
            // 
            // rPos
            // 
            this.rPos.Location = new System.Drawing.Point(63, 179);
            this.rPos.Margin = new System.Windows.Forms.Padding(4);
            this.rPos.Name = "rPos";
            this.rPos.ReadOnly = true;
            this.rPos.Size = new System.Drawing.Size(93, 25);
            this.rPos.TabIndex = 16;
            this.rPos.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(40, 182);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(15, 15);
            this.label14.TabIndex = 15;
            this.label14.Text = "R";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(165, 141);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 15);
            this.label11.TabIndex = 14;
            this.label11.Text = "mm";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(165, 99);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 15);
            this.label10.TabIndex = 13;
            this.label10.Text = "mm";
            // 
            // zPos
            // 
            this.zPos.Location = new System.Drawing.Point(63, 138);
            this.zPos.Margin = new System.Windows.Forms.Padding(4);
            this.zPos.Name = "zPos";
            this.zPos.ReadOnly = true;
            this.zPos.Size = new System.Drawing.Size(93, 25);
            this.zPos.TabIndex = 12;
            this.zPos.Text = "0";
            // 
            // yPos
            // 
            this.yPos.Location = new System.Drawing.Point(63, 95);
            this.yPos.Margin = new System.Windows.Forms.Padding(4);
            this.yPos.Name = "yPos";
            this.yPos.ReadOnly = true;
            this.yPos.Size = new System.Drawing.Size(93, 25);
            this.yPos.TabIndex = 9;
            this.yPos.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(165, 56);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 15);
            this.label9.TabIndex = 11;
            this.label9.Text = "mm";
            // 
            // xPos
            // 
            this.xPos.Location = new System.Drawing.Point(63, 52);
            this.xPos.Margin = new System.Windows.Forms.Padding(4);
            this.xPos.Name = "xPos";
            this.xPos.ReadOnly = true;
            this.xPos.Size = new System.Drawing.Size(93, 25);
            this.xPos.TabIndex = 8;
            this.xPos.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 141);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Z";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 99);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Y";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 56);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "X";
            // 
            // Cscan_btn
            // 
            this.Cscan_btn.Location = new System.Drawing.Point(252, 34);
            this.Cscan_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Cscan_btn.Name = "Cscan_btn";
            this.Cscan_btn.Size = new System.Drawing.Size(100, 29);
            this.Cscan_btn.TabIndex = 8;
            this.Cscan_btn.Text = "Scan";
            this.Cscan_btn.UseVisualStyleBackColor = true;
            this.Cscan_btn.Click += new System.EventHandler(this.Cscan_btn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_stop);
            this.groupBox3.Controls.Add(this.labelScanAxis);
            this.groupBox3.Controls.Add(this.Cscan_btn);
            this.groupBox3.Controls.Add(this.cmbScanAxis);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.nudRange);
            this.groupBox3.Controls.Add(this.nudSpeed);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Location = new System.Drawing.Point(16, 316);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(627, 168);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cscan";
            // 
            // labelScanAxis
            // 
            this.labelScanAxis.AutoSize = true;
            this.labelScanAxis.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelScanAxis.Location = new System.Drawing.Point(20, 36);
            this.labelScanAxis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelScanAxis.Name = "labelScanAxis";
            this.labelScanAxis.Size = new System.Drawing.Size(73, 20);
            this.labelScanAxis.TabIndex = 2;
            this.labelScanAxis.Text = "ScanAxis";
            // 
            // cmbScanAxis
            // 
            this.cmbScanAxis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbScanAxis.FormattingEnabled = true;
            this.cmbScanAxis.Items.AddRange(new object[] {
            "X",
            "Y",
            "Z",
            "R"});
            this.cmbScanAxis.Location = new System.Drawing.Point(105, 36);
            this.cmbScanAxis.Margin = new System.Windows.Forms.Padding(4);
            this.cmbScanAxis.Name = "cmbScanAxis";
            this.cmbScanAxis.Size = new System.Drawing.Size(116, 23);
            this.cmbScanAxis.TabIndex = 3;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label19.Location = new System.Drawing.Point(19, 81);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(55, 20);
            this.label19.TabIndex = 4;
            this.label19.Text = "Range";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(488, 81);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 20);
            this.label13.TabIndex = 14;
            this.label13.Text = "mm/s";
            // 
            // nudRange
            // 
            this.nudRange.DecimalPlaces = 2;
            this.nudRange.Location = new System.Drawing.Point(105, 82);
            this.nudRange.Margin = new System.Windows.Forms.Padding(4);
            this.nudRange.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.nudRange.Minimum = new decimal(new int[] {
            400,
            0,
            0,
            -2147483648});
            this.nudRange.Name = "nudRange";
            this.nudRange.Size = new System.Drawing.Size(117, 25);
            this.nudRange.TabIndex = 9;
            this.nudRange.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // nudSpeed
            // 
            this.nudSpeed.DecimalPlaces = 2;
            this.nudSpeed.Location = new System.Drawing.Point(360, 82);
            this.nudSpeed.Margin = new System.Windows.Forms.Padding(4);
            this.nudSpeed.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudSpeed.Name = "nudSpeed";
            this.nudSpeed.Size = new System.Drawing.Size(117, 25);
            this.nudSpeed.TabIndex = 11;
            this.nudSpeed.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(232, 81);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 20);
            this.label15.TabIndex = 12;
            this.label15.Text = "mm";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.Location = new System.Drawing.Point(292, 82);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 20);
            this.label17.TabIndex = 6;
            this.label17.Text = "Speed";
            // 
            // force
            // 
            this.force.Location = new System.Drawing.Point(740, 71);
            this.force.Margin = new System.Windows.Forms.Padding(4);
            this.force.Name = "force";
            this.force.ReadOnly = true;
            this.force.Size = new System.Drawing.Size(93, 25);
            this.force.TabIndex = 10;
            this.force.Text = "0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(670, 74);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(47, 15);
            this.label18.TabIndex = 11;
            this.label18.Text = "force";
            // 
            // NMC_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 499);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.force);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NMC_Test";
            this.Text = "NMC_Test";
            this.Load += new System.EventHandler(this.NMC_Test_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ySpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xSpeed)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_move;
        private System.Windows.Forms.Button btn_zero;
        private System.Windows.Forms.NumericUpDown zDistance;
        private System.Windows.Forms.NumericUpDown zSpeed;
        private System.Windows.Forms.NumericUpDown yDistance;
        private System.Windows.Forms.NumericUpDown ySpeed;
        private System.Windows.Forms.NumericUpDown xDistance;
        private System.Windows.Forms.NumericUpDown xSpeed;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox zPos;
        private System.Windows.Forms.TextBox yPos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox xPos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Cscan_btn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown nudSpeed;
        private System.Windows.Forms.NumericUpDown nudRange;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cmbScanAxis;
        private System.Windows.Forms.Label labelScanAxis;
        private System.Windows.Forms.Button btn_halt;
        private System.Windows.Forms.Button btn_continue;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown rSpeed;
        private System.Windows.Forms.NumericUpDown rDistance;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox rPos;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button xforward;
        private System.Windows.Forms.TextBox force;
        private System.Windows.Forms.Label label18;
    }
}

