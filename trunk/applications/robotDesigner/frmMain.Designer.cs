namespace robotDesigner
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpBody = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBodyWidth = new System.Windows.Forms.TextBox();
            this.txtBodyLength = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBodyHeight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbPropulsion = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grpWheels = new System.Windows.Forms.GroupBox();
            this.txtWheelDiameter = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbWheelFeedback = new System.Windows.Forms.ComboBox();
            this.txtGearRatio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCountsPerRev = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbHeadType = new System.Windows.Forms.ComboBox();
            this.txtHeadSize = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtHeadHeightFromGround = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtNoOfCameras = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbHeadShape = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbCameraOrientation = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtTotalMass = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.grpStereoCamera = new System.Windows.Forms.GroupBox();
            this.txtCameraBaseline = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtCameraFOV = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.grpBody.SuspendLayout();
            this.grpWheels.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpStereoCamera.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(547, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // grpBody
            // 
            this.grpBody.Controls.Add(this.label4);
            this.grpBody.Controls.Add(this.cmbPropulsion);
            this.grpBody.Controls.Add(this.txtBodyHeight);
            this.grpBody.Controls.Add(this.label3);
            this.grpBody.Controls.Add(this.txtBodyLength);
            this.grpBody.Controls.Add(this.label2);
            this.grpBody.Controls.Add(this.txtBodyWidth);
            this.grpBody.Controls.Add(this.label1);
            this.grpBody.Location = new System.Drawing.Point(13, 116);
            this.grpBody.Name = "grpBody";
            this.grpBody.Size = new System.Drawing.Size(212, 175);
            this.grpBody.TabIndex = 1;
            this.grpBody.TabStop = false;
            this.grpBody.Text = "Body";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Width mm";
            // 
            // txtBodyWidth
            // 
            this.txtBodyWidth.Location = new System.Drawing.Point(80, 26);
            this.txtBodyWidth.Name = "txtBodyWidth";
            this.txtBodyWidth.Size = new System.Drawing.Size(59, 20);
            this.txtBodyWidth.TabIndex = 1;
            this.txtBodyWidth.Text = "500";
            this.txtBodyWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBodyLength
            // 
            this.txtBodyLength.Location = new System.Drawing.Point(80, 52);
            this.txtBodyLength.Name = "txtBodyLength";
            this.txtBodyLength.Size = new System.Drawing.Size(59, 20);
            this.txtBodyLength.TabIndex = 3;
            this.txtBodyLength.Text = "500";
            this.txtBodyLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Length mm";
            // 
            // txtBodyHeight
            // 
            this.txtBodyHeight.Location = new System.Drawing.Point(80, 78);
            this.txtBodyHeight.Name = "txtBodyHeight";
            this.txtBodyHeight.Size = new System.Drawing.Size(59, 20);
            this.txtBodyHeight.TabIndex = 5;
            this.txtBodyHeight.Text = "500";
            this.txtBodyHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Height mm";
            // 
            // cmbPropulsion
            // 
            this.cmbPropulsion.FormattingEnabled = true;
            this.cmbPropulsion.Items.AddRange(new object[] {
            "Wheels",
            "Tracks",
            "Legs"});
            this.cmbPropulsion.Location = new System.Drawing.Point(80, 104);
            this.cmbPropulsion.Name = "cmbPropulsion";
            this.cmbPropulsion.Size = new System.Drawing.Size(93, 21);
            this.cmbPropulsion.TabIndex = 6;
            this.cmbPropulsion.Text = "Wheels";
            this.cmbPropulsion.SelectedIndexChanged += new System.EventHandler(this.cmbPropulsion_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Propulsion";
            // 
            // grpWheels
            // 
            this.grpWheels.Controls.Add(this.txtCountsPerRev);
            this.grpWheels.Controls.Add(this.label9);
            this.grpWheels.Controls.Add(this.label8);
            this.grpWheels.Controls.Add(this.txtGearRatio);
            this.grpWheels.Controls.Add(this.label7);
            this.grpWheels.Controls.Add(this.label6);
            this.grpWheels.Controls.Add(this.cmbWheelFeedback);
            this.grpWheels.Controls.Add(this.txtWheelDiameter);
            this.grpWheels.Controls.Add(this.label5);
            this.grpWheels.Location = new System.Drawing.Point(249, 116);
            this.grpWheels.Name = "grpWheels";
            this.grpWheels.Size = new System.Drawing.Size(203, 175);
            this.grpWheels.TabIndex = 2;
            this.grpWheels.TabStop = false;
            this.grpWheels.Text = "Wheels";
            // 
            // txtWheelDiameter
            // 
            this.txtWheelDiameter.Location = new System.Drawing.Point(87, 22);
            this.txtWheelDiameter.Name = "txtWheelDiameter";
            this.txtWheelDiameter.Size = new System.Drawing.Size(59, 20);
            this.txtWheelDiameter.TabIndex = 3;
            this.txtWheelDiameter.Text = "500";
            this.txtWheelDiameter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Diameter mm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Feedback";
            // 
            // cmbWheelFeedback
            // 
            this.cmbWheelFeedback.FormattingEnabled = true;
            this.cmbWheelFeedback.Items.AddRange(new object[] {
            "None",
            "Encoder",
            "Resolver"});
            this.cmbWheelFeedback.Location = new System.Drawing.Point(87, 51);
            this.cmbWheelFeedback.Name = "cmbWheelFeedback";
            this.cmbWheelFeedback.Size = new System.Drawing.Size(93, 21);
            this.cmbWheelFeedback.TabIndex = 8;
            this.cmbWheelFeedback.Text = "None";
            // 
            // txtGearRatio
            // 
            this.txtGearRatio.Location = new System.Drawing.Point(87, 81);
            this.txtGearRatio.Name = "txtGearRatio";
            this.txtGearRatio.Size = new System.Drawing.Size(31, 20);
            this.txtGearRatio.TabIndex = 11;
            this.txtGearRatio.Text = "50";
            this.txtGearRatio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Gear Ratio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(124, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = ": 1";
            // 
            // txtCountsPerRev
            // 
            this.txtCountsPerRev.Location = new System.Drawing.Point(87, 107);
            this.txtCountsPerRev.Name = "txtCountsPerRev";
            this.txtCountsPerRev.Size = new System.Drawing.Size(59, 20);
            this.txtCountsPerRev.TabIndex = 14;
            this.txtCountsPerRev.Text = "4096";
            this.txtCountsPerRev.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Counts/Rev";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cmbCameraOrientation);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cmbHeadShape);
            this.groupBox1.Controls.Add(this.txtNoOfCameras);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtHeadHeightFromGround);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtHeadSize);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cmbHeadType);
            this.groupBox1.Location = new System.Drawing.Point(249, 312);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 218);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Head";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Head Type";
            // 
            // cmbHeadType
            // 
            this.cmbHeadType.FormattingEnabled = true;
            this.cmbHeadType.Items.AddRange(new object[] {
            "None or Fixed to the chassis",
            "Tilt only",
            "Pan and Tilt",
            "Pan only",
            "Elevate only",
            "Tilt and Elevate",
            "Pan, Tilt and Elevate"});
            this.cmbHeadType.Location = new System.Drawing.Point(86, 21);
            this.cmbHeadType.Name = "cmbHeadType";
            this.cmbHeadType.Size = new System.Drawing.Size(162, 21);
            this.cmbHeadType.TabIndex = 10;
            this.cmbHeadType.Text = "None or Fixed to the chassis";
            // 
            // txtHeadSize
            // 
            this.txtHeadSize.Location = new System.Drawing.Point(86, 48);
            this.txtHeadSize.Name = "txtHeadSize";
            this.txtHeadSize.Size = new System.Drawing.Size(59, 20);
            this.txtHeadSize.TabIndex = 13;
            this.txtHeadSize.Text = "50";
            this.txtHeadSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 51);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Size mm";
            // 
            // txtHeadHeightFromGround
            // 
            this.txtHeadHeightFromGround.Location = new System.Drawing.Point(170, 110);
            this.txtHeadHeightFromGround.Name = "txtHeadHeightFromGround";
            this.txtHeadHeightFromGround.Size = new System.Drawing.Size(59, 20);
            this.txtHeadHeightFromGround.TabIndex = 19;
            this.txtHeadHeightFromGround.Text = "1000";
            this.txtHeadHeightFromGround.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(20, 113);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(144, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "Height above the ground mm";
            // 
            // txtNoOfCameras
            // 
            this.txtNoOfCameras.Location = new System.Drawing.Point(137, 139);
            this.txtNoOfCameras.Name = "txtNoOfCameras";
            this.txtNoOfCameras.Size = new System.Drawing.Size(27, 20);
            this.txtNoOfCameras.TabIndex = 21;
            this.txtNoOfCameras.Text = "1";
            this.txtNoOfCameras.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(20, 142);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(111, 13);
            this.label15.TabIndex = 20;
            this.label15.Text = "No of Stereo Cameras";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Shape";
            // 
            // cmbHeadShape
            // 
            this.cmbHeadShape.FormattingEnabled = true;
            this.cmbHeadShape.Items.AddRange(new object[] {
            "Cube",
            "Sphere",
            "Other"});
            this.cmbHeadShape.Location = new System.Drawing.Point(86, 76);
            this.cmbHeadShape.Name = "cmbHeadShape";
            this.cmbHeadShape.Size = new System.Drawing.Size(93, 21);
            this.cmbHeadShape.TabIndex = 22;
            this.cmbHeadShape.Text = "Cube";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 168);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Orientation";
            // 
            // cmbCameraOrientation
            // 
            this.cmbCameraOrientation.FormattingEnabled = true;
            this.cmbCameraOrientation.Items.AddRange(new object[] {
            "Standard forward looking",
            "Diagonal"});
            this.cmbCameraOrientation.Location = new System.Drawing.Point(84, 165);
            this.cmbCameraOrientation.Name = "cmbCameraOrientation";
            this.cmbCameraOrientation.Size = new System.Drawing.Size(164, 21);
            this.cmbCameraOrientation.TabIndex = 24;
            this.cmbCameraOrientation.Text = "Standard forward looking";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTotalMass);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Location = new System.Drawing.Point(13, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(505, 71);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "General";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(94, 19);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(390, 20);
            this.txtName.TabIndex = 3;
            this.txtName.Text = "My Robot";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(17, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 13);
            this.label16.TabIndex = 2;
            this.label16.Text = "Name";
            // 
            // txtTotalMass
            // 
            this.txtTotalMass.Location = new System.Drawing.Point(94, 45);
            this.txtTotalMass.Name = "txtTotalMass";
            this.txtTotalMass.Size = new System.Drawing.Size(59, 20);
            this.txtTotalMass.TabIndex = 5;
            this.txtTotalMass.Text = "1";
            this.txtTotalMass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(17, 48);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(75, 13);
            this.label17.TabIndex = 4;
            this.label17.Text = "Total Mass Kg";
            // 
            // grpStereoCamera
            // 
            this.grpStereoCamera.Controls.Add(this.txtCameraFOV);
            this.grpStereoCamera.Controls.Add(this.label19);
            this.grpStereoCamera.Controls.Add(this.txtCameraBaseline);
            this.grpStereoCamera.Controls.Add(this.label18);
            this.grpStereoCamera.Location = new System.Drawing.Point(13, 312);
            this.grpStereoCamera.Name = "grpStereoCamera";
            this.grpStereoCamera.Size = new System.Drawing.Size(212, 129);
            this.grpStereoCamera.TabIndex = 5;
            this.grpStereoCamera.TabStop = false;
            this.grpStereoCamera.Text = "Stereo Camera";
            // 
            // txtCameraBaseline
            // 
            this.txtCameraBaseline.Location = new System.Drawing.Point(131, 19);
            this.txtCameraBaseline.Name = "txtCameraBaseline";
            this.txtCameraBaseline.Size = new System.Drawing.Size(59, 20);
            this.txtCameraBaseline.TabIndex = 3;
            this.txtCameraBaseline.Text = "100";
            this.txtCameraBaseline.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(17, 22);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(66, 13);
            this.label18.TabIndex = 2;
            this.label18.Text = "Baseline mm";
            // 
            // txtCameraFOV
            // 
            this.txtCameraFOV.Location = new System.Drawing.Point(131, 45);
            this.txtCameraFOV.Name = "txtCameraFOV";
            this.txtCameraFOV.Size = new System.Drawing.Size(59, 20);
            this.txtCameraFOV.TabIndex = 5;
            this.txtCameraFOV.Text = "40";
            this.txtCameraFOV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(17, 48);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(108, 13);
            this.label19.TabIndex = 4;
            this.label19.Text = "Field of View degrees";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 559);
            this.Controls.Add(this.grpStereoCamera);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpWheels);
            this.Controls.Add(this.grpBody);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Robot Designer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpBody.ResumeLayout(false);
            this.grpBody.PerformLayout();
            this.grpWheels.ResumeLayout(false);
            this.grpWheels.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpStereoCamera.ResumeLayout(false);
            this.grpStereoCamera.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpBody;
        private System.Windows.Forms.TextBox txtBodyLength;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBodyWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbPropulsion;
        private System.Windows.Forms.TextBox txtBodyHeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpWheels;
        private System.Windows.Forms.TextBox txtCountsPerRev;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtGearRatio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbWheelFeedback;
        private System.Windows.Forms.TextBox txtWheelDiameter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbHeadType;
        private System.Windows.Forms.TextBox txtHeadHeightFromGround;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtHeadSize;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtNoOfCameras;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbCameraOrientation;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbHeadShape;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTotalMass;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox grpStereoCamera;
        private System.Windows.Forms.TextBox txtCameraBaseline;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtCameraFOV;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

