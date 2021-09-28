
namespace ChiaPlotterWinGUI
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
      this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.mstFinalDir = new MetroSet_UI.Controls.MetroSetTile();
      this.label3 = new System.Windows.Forms.Label();
      this.tbTemp2Dir = new System.Windows.Forms.TextBox();
      this.tbFinalDir = new System.Windows.Forms.TextBox();
      this.tbTempDir = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.swAlternateTemps = new MetroSet_UI.Controls.MetroSetSwitch();
      this.label11 = new System.Windows.Forms.Label();
      this.label12 = new System.Windows.Forms.Label();
      this.swWait4Copy = new MetroSet_UI.Controls.MetroSetSwitch();
      this.mstTempDir = new MetroSet_UI.Controls.MetroSetTile();
      this.mstTemp2Dir = new MetroSet_UI.Controls.MetroSetTile();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
      this.tbContractKey = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.tbFarmerKey = new System.Windows.Forms.TextBox();
      this.tbPoolKey = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
      this.numBuckets34 = new System.Windows.Forms.NumericUpDown();
      this.numBuckets = new System.Windows.Forms.NumericUpDown();
      this.numThreads = new System.Windows.Forms.NumericUpDown();
      this.label13 = new System.Windows.Forms.Label();
      this.cbPlots = new System.Windows.Forms.ComboBox();
      this.label9 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.label10 = new System.Windows.Forms.Label();
      this.btnSuggestion = new MetroSet_UI.Controls.MetroSetButton();
      this.numThreadX = new System.Windows.Forms.NumericUpDown();
      this.metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
      this.btnStart = new MetroSet_UI.Controls.MetroSetButton();
      this.btnStop = new MetroSet_UI.Controls.MetroSetButton();
      this.btnNew = new MetroSet_UI.Controls.MetroSetButton();
      this.btnSave = new MetroSet_UI.Controls.MetroSetButton();
      this.btnLoad = new MetroSet_UI.Controls.MetroSetButton();
      this.btnAbout = new MetroSet_UI.Controls.MetroSetButton();
      this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
      this.groupBox4 = new System.Windows.Forms.GroupBox();
      this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
      this.label14 = new System.Windows.Forms.Label();
      this.label16 = new System.Windows.Forms.Label();
      this.mstLogPath = new MetroSet_UI.Controls.MetroSetTile();
      this.tbLogPath = new System.Windows.Forms.TextBox();
      this.swLogActive = new MetroSet_UI.Controls.MetroSetSwitch();
      this.tbProcOutput = new System.Windows.Forms.TextBox();
      this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.groupBox1.SuspendLayout();
      this.tableLayoutPanel1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.tableLayoutPanel2.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.tableLayoutPanel3.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numBuckets34)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numBuckets)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numThreads)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numThreadX)).BeginInit();
      this.groupBox4.SuspendLayout();
      this.tableLayoutPanel4.SuspendLayout();
      this.SuspendLayout();
      // 
      // saveFileDialog1
      // 
      this.saveFileDialog1.DefaultExt = "pltcfg";
      this.saveFileDialog1.Filter = "Plotter config (*.pltcfg)|";
      // 
      // groupBox1
      // 
      this.groupBox1.BackColor = System.Drawing.Color.White;
      this.groupBox1.Controls.Add(this.tableLayoutPanel1);
      this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.groupBox1.Location = new System.Drawing.Point(15, 80);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(531, 205);
      this.groupBox1.TabIndex = 9;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Directories";
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 3;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 339F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
      this.tableLayoutPanel1.Controls.Add(this.mstFinalDir, 2, 0);
      this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.tbTemp2Dir, 1, 2);
      this.tableLayoutPanel1.Controls.Add(this.tbFinalDir, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this.tbTempDir, 1, 1);
      this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
      this.tableLayoutPanel1.Controls.Add(this.swAlternateTemps, 2, 3);
      this.tableLayoutPanel1.Controls.Add(this.label11, 1, 3);
      this.tableLayoutPanel1.Controls.Add(this.label12, 1, 4);
      this.tableLayoutPanel1.Controls.Add(this.swWait4Copy, 2, 4);
      this.tableLayoutPanel1.Controls.Add(this.mstTempDir, 2, 1);
      this.tableLayoutPanel1.Controls.Add(this.mstTemp2Dir, 2, 2);
      this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 22);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 5;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(513, 171);
      this.tableLayoutPanel1.TabIndex = 13;
      // 
      // mstFinalDir
      // 
      this.mstFinalDir.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.mstFinalDir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mstFinalDir.BackgroundImage")));
      this.mstFinalDir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
      this.mstFinalDir.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
      this.mstFinalDir.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
      this.mstFinalDir.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
      this.mstFinalDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.mstFinalDir.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
      this.mstFinalDir.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.mstFinalDir.HoverTextColor = System.Drawing.Color.White;
      this.mstFinalDir.IsDerivedStyle = true;
      this.mstFinalDir.Location = new System.Drawing.Point(448, 3);
      this.mstFinalDir.Name = "mstFinalDir";
      this.mstFinalDir.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.mstFinalDir.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.mstFinalDir.NormalTextColor = System.Drawing.Color.White;
      this.mstFinalDir.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.mstFinalDir.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.mstFinalDir.PressTextColor = System.Drawing.Color.White;
      this.mstFinalDir.Size = new System.Drawing.Size(32, 28);
      this.mstFinalDir.Style = MetroSet_UI.Enums.Style.Light;
      this.mstFinalDir.StyleManager = null;
      this.mstFinalDir.TabIndex = 15;
      this.mstFinalDir.ThemeAuthor = "Narwin";
      this.mstFinalDir.ThemeName = "MetroLite";
      this.mstFinalDir.TileAlign = MetroSet_UI.Enums.TileAlign.Topleft;
      this.mstFinalDir.Click += new System.EventHandler(this.mstfinalDir_Click);
      // 
      // label3
      // 
      this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(3, 6);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(49, 22);
      this.label3.TabIndex = 15;
      this.label3.Text = "Final";
      // 
      // tbTemp2Dir
      // 
      this.tbTemp2Dir.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.tbTemp2Dir.Location = new System.Drawing.Point(113, 71);
      this.tbTemp2Dir.Name = "tbTemp2Dir";
      this.tbTemp2Dir.Size = new System.Drawing.Size(325, 27);
      this.tbTemp2Dir.TabIndex = 16;
      // 
      // tbFinalDir
      // 
      this.tbFinalDir.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.tbFinalDir.Location = new System.Drawing.Point(113, 3);
      this.tbFinalDir.Name = "tbFinalDir";
      this.tbFinalDir.Size = new System.Drawing.Size(325, 27);
      this.tbFinalDir.TabIndex = 13;
      // 
      // tbTempDir
      // 
      this.tbTempDir.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.tbTempDir.Location = new System.Drawing.Point(113, 37);
      this.tbTempDir.Name = "tbTempDir";
      this.tbTempDir.Size = new System.Drawing.Size(325, 27);
      this.tbTempDir.TabIndex = 13;
      // 
      // label1
      // 
      this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(3, 40);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(97, 22);
      this.label1.TabIndex = 12;
      this.label1.Text = "Temporary";
      // 
      // label2
      // 
      this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(3, 74);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(96, 22);
      this.label2.TabIndex = 12;
      this.label2.Text = "Temp. 2nd";
      // 
      // swAlternateTemps
      // 
      this.swAlternateTemps.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.swAlternateTemps.BackColor = System.Drawing.Color.Transparent;
      this.swAlternateTemps.BackgroundColor = System.Drawing.Color.Empty;
      this.swAlternateTemps.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(159)))), ((int)(((byte)(147)))));
      this.swAlternateTemps.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.swAlternateTemps.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
      this.swAlternateTemps.Cursor = System.Windows.Forms.Cursors.Hand;
      this.swAlternateTemps.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
      this.swAlternateTemps.DisabledCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.swAlternateTemps.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
      this.swAlternateTemps.IsDerivedStyle = true;
      this.swAlternateTemps.Location = new System.Drawing.Point(448, 108);
      this.swAlternateTemps.Name = "swAlternateTemps";
      this.swAlternateTemps.Size = new System.Drawing.Size(58, 22);
      this.swAlternateTemps.Style = MetroSet_UI.Enums.Style.Light;
      this.swAlternateTemps.StyleManager = null;
      this.swAlternateTemps.Switched = false;
      this.swAlternateTemps.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
      this.swAlternateTemps.TabIndex = 18;
      this.swAlternateTemps.Text = "metroSetSwitch1";
      this.swAlternateTemps.ThemeAuthor = "Narwin";
      this.swAlternateTemps.ThemeName = "MetroLite";
      this.swAlternateTemps.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
      // 
      // label11
      // 
      this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label11.AutoSize = true;
      this.label11.Location = new System.Drawing.Point(109, 108);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(200, 22);
      this.label11.TabIndex = 19;
      this.label11.Text = "Alternate tmpdir/tmpdir2";
      // 
      // label12
      // 
      this.label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label12.AutoSize = true;
      this.label12.Location = new System.Drawing.Point(109, 142);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(248, 22);
      this.label12.TabIndex = 20;
      this.label12.Text = "Wait for copy to start next plot";
      // 
      // swWait4Copy
      // 
      this.swWait4Copy.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.swWait4Copy.BackColor = System.Drawing.Color.Transparent;
      this.swWait4Copy.BackgroundColor = System.Drawing.Color.Empty;
      this.swWait4Copy.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(159)))), ((int)(((byte)(147)))));
      this.swWait4Copy.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.swWait4Copy.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
      this.swWait4Copy.Cursor = System.Windows.Forms.Cursors.Hand;
      this.swWait4Copy.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
      this.swWait4Copy.DisabledCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.swWait4Copy.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
      this.swWait4Copy.IsDerivedStyle = true;
      this.swWait4Copy.Location = new System.Drawing.Point(448, 142);
      this.swWait4Copy.Name = "swWait4Copy";
      this.swWait4Copy.Size = new System.Drawing.Size(58, 22);
      this.swWait4Copy.Style = MetroSet_UI.Enums.Style.Light;
      this.swWait4Copy.StyleManager = null;
      this.swWait4Copy.Switched = false;
      this.swWait4Copy.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
      this.swWait4Copy.TabIndex = 21;
      this.swWait4Copy.Text = "metroSetSwitch2";
      this.swWait4Copy.ThemeAuthor = "Narwin";
      this.swWait4Copy.ThemeName = "MetroLite";
      this.swWait4Copy.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
      // 
      // mstTempDir
      // 
      this.mstTempDir.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.mstTempDir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mstTempDir.BackgroundImage")));
      this.mstTempDir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
      this.mstTempDir.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
      this.mstTempDir.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
      this.mstTempDir.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
      this.mstTempDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.mstTempDir.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
      this.mstTempDir.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.mstTempDir.HoverTextColor = System.Drawing.Color.White;
      this.mstTempDir.IsDerivedStyle = true;
      this.mstTempDir.Location = new System.Drawing.Point(448, 37);
      this.mstTempDir.Name = "mstTempDir";
      this.mstTempDir.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.mstTempDir.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.mstTempDir.NormalTextColor = System.Drawing.Color.White;
      this.mstTempDir.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.mstTempDir.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.mstTempDir.PressTextColor = System.Drawing.Color.White;
      this.mstTempDir.Size = new System.Drawing.Size(32, 28);
      this.mstTempDir.Style = MetroSet_UI.Enums.Style.Light;
      this.mstTempDir.StyleManager = null;
      this.mstTempDir.TabIndex = 22;
      this.mstTempDir.ThemeAuthor = "Narwin";
      this.mstTempDir.ThemeName = "MetroLite";
      this.mstTempDir.TileAlign = MetroSet_UI.Enums.TileAlign.Topleft;
      this.mstTempDir.Click += new System.EventHandler(this.mstfinalDir_Click);
      // 
      // mstTemp2Dir
      // 
      this.mstTemp2Dir.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.mstTemp2Dir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mstTemp2Dir.BackgroundImage")));
      this.mstTemp2Dir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
      this.mstTemp2Dir.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
      this.mstTemp2Dir.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
      this.mstTemp2Dir.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
      this.mstTemp2Dir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.mstTemp2Dir.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
      this.mstTemp2Dir.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.mstTemp2Dir.HoverTextColor = System.Drawing.Color.White;
      this.mstTemp2Dir.IsDerivedStyle = true;
      this.mstTemp2Dir.Location = new System.Drawing.Point(448, 71);
      this.mstTemp2Dir.Name = "mstTemp2Dir";
      this.mstTemp2Dir.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.mstTemp2Dir.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.mstTemp2Dir.NormalTextColor = System.Drawing.Color.White;
      this.mstTemp2Dir.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.mstTemp2Dir.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.mstTemp2Dir.PressTextColor = System.Drawing.Color.White;
      this.mstTemp2Dir.Size = new System.Drawing.Size(32, 28);
      this.mstTemp2Dir.Style = MetroSet_UI.Enums.Style.Light;
      this.mstTemp2Dir.StyleManager = null;
      this.mstTemp2Dir.TabIndex = 23;
      this.mstTemp2Dir.ThemeAuthor = "Narwin";
      this.mstTemp2Dir.ThemeName = "MetroLite";
      this.mstTemp2Dir.TileAlign = MetroSet_UI.Enums.TileAlign.Topleft;
      this.mstTemp2Dir.Click += new System.EventHandler(this.mstfinalDir_Click);
      // 
      // groupBox2
      // 
      this.groupBox2.BackColor = System.Drawing.Color.White;
      this.groupBox2.Controls.Add(this.tableLayoutPanel2);
      this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.groupBox2.Location = new System.Drawing.Point(552, 239);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(531, 152);
      this.groupBox2.TabIndex = 10;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Keys";
      // 
      // tableLayoutPanel2
      // 
      this.tableLayoutPanel2.ColumnCount = 2;
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 94F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 419F));
      this.tableLayoutPanel2.Controls.Add(this.tbContractKey, 1, 2);
      this.tableLayoutPanel2.Controls.Add(this.label4, 0, 0);
      this.tableLayoutPanel2.Controls.Add(this.tbFarmerKey, 1, 1);
      this.tableLayoutPanel2.Controls.Add(this.tbPoolKey, 1, 0);
      this.tableLayoutPanel2.Controls.Add(this.label6, 0, 1);
      this.tableLayoutPanel2.Controls.Add(this.label5, 0, 2);
      this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 22);
      this.tableLayoutPanel2.Name = "tableLayoutPanel2";
      this.tableLayoutPanel2.RowCount = 3;
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
      this.tableLayoutPanel2.Size = new System.Drawing.Size(513, 120);
      this.tableLayoutPanel2.TabIndex = 13;
      // 
      // tbContractKey
      // 
      this.tbContractKey.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.tbContractKey.Location = new System.Drawing.Point(101, 80);
      this.tbContractKey.Name = "tbContractKey";
      this.tbContractKey.Size = new System.Drawing.Size(405, 27);
      this.tbContractKey.TabIndex = 16;
      // 
      // label4
      // 
      this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(3, 6);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(46, 22);
      this.label4.TabIndex = 13;
      this.label4.Text = "Pool";
      // 
      // tbFarmerKey
      // 
      this.tbFarmerKey.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.tbFarmerKey.Location = new System.Drawing.Point(101, 37);
      this.tbFarmerKey.Name = "tbFarmerKey";
      this.tbFarmerKey.Size = new System.Drawing.Size(405, 27);
      this.tbFarmerKey.TabIndex = 14;
      // 
      // tbPoolKey
      // 
      this.tbPoolKey.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.tbPoolKey.Location = new System.Drawing.Point(101, 3);
      this.tbPoolKey.Name = "tbPoolKey";
      this.tbPoolKey.Size = new System.Drawing.Size(405, 27);
      this.tbPoolKey.TabIndex = 12;
      // 
      // label6
      // 
      this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(3, 40);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(67, 22);
      this.label6.TabIndex = 17;
      this.label6.Text = "Farmer";
      // 
      // label5
      // 
      this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(3, 72);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(83, 44);
      this.label5.TabIndex = 15;
      this.label5.Text = "Contract Adress";
      // 
      // groupBox3
      // 
      this.groupBox3.BackColor = System.Drawing.Color.White;
      this.groupBox3.Controls.Add(this.tableLayoutPanel3);
      this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.groupBox3.Location = new System.Drawing.Point(552, 80);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(531, 153);
      this.groupBox3.TabIndex = 11;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Settings";
      // 
      // tableLayoutPanel3
      // 
      this.tableLayoutPanel3.ColumnCount = 4;
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 148F));
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117F));
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 148F));
      this.tableLayoutPanel3.Controls.Add(this.numBuckets34, 3, 1);
      this.tableLayoutPanel3.Controls.Add(this.numBuckets, 3, 0);
      this.tableLayoutPanel3.Controls.Add(this.numThreads, 1, 1);
      this.tableLayoutPanel3.Controls.Add(this.label13, 0, 2);
      this.tableLayoutPanel3.Controls.Add(this.cbPlots, 1, 0);
      this.tableLayoutPanel3.Controls.Add(this.label9, 0, 0);
      this.tableLayoutPanel3.Controls.Add(this.label8, 0, 1);
      this.tableLayoutPanel3.Controls.Add(this.label7, 2, 0);
      this.tableLayoutPanel3.Controls.Add(this.label10, 2, 1);
      this.tableLayoutPanel3.Controls.Add(this.btnSuggestion, 3, 2);
      this.tableLayoutPanel3.Controls.Add(this.numThreadX, 1, 2);
      this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 26);
      this.tableLayoutPanel3.Name = "tableLayoutPanel3";
      this.tableLayoutPanel3.RowCount = 3;
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
      this.tableLayoutPanel3.Size = new System.Drawing.Size(513, 118);
      this.tableLayoutPanel3.TabIndex = 26;
      // 
      // numBuckets34
      // 
      this.numBuckets34.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.numBuckets34.Location = new System.Drawing.Point(368, 37);
      this.numBuckets34.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
      this.numBuckets34.Name = "numBuckets34";
      this.numBuckets34.Size = new System.Drawing.Size(140, 27);
      this.numBuckets34.TabIndex = 33;
      this.numBuckets34.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // numBuckets
      // 
      this.numBuckets.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.numBuckets.Location = new System.Drawing.Point(368, 3);
      this.numBuckets.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
      this.numBuckets.Name = "numBuckets";
      this.numBuckets.Size = new System.Drawing.Size(140, 27);
      this.numBuckets.TabIndex = 32;
      this.numBuckets.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // numThreads
      // 
      this.numThreads.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.numThreads.Location = new System.Drawing.Point(103, 37);
      this.numThreads.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
      this.numThreads.Name = "numThreads";
      this.numThreads.Size = new System.Drawing.Size(140, 27);
      this.numThreads.TabIndex = 22;
      this.numThreads.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // label13
      // 
      this.label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label13.AutoSize = true;
      this.label13.Location = new System.Drawing.Point(3, 71);
      this.label13.Name = "label13";
      this.label13.Size = new System.Drawing.Size(81, 44);
      this.label13.TabIndex = 28;
      this.label13.Text = "Thread Multiplier";
      // 
      // cbPlots
      // 
      this.cbPlots.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.cbPlots.FormattingEnabled = true;
      this.cbPlots.Items.AddRange(new object[] {
            "1",
            "Maximum"});
      this.cbPlots.Location = new System.Drawing.Point(103, 5);
      this.cbPlots.Name = "cbPlots";
      this.cbPlots.Size = new System.Drawing.Size(140, 28);
      this.cbPlots.TabIndex = 16;
      // 
      // label9
      // 
      this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(3, 6);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(50, 22);
      this.label9.TabIndex = 18;
      this.label9.Text = "Plots";
      // 
      // label8
      // 
      this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(3, 40);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(77, 22);
      this.label8.TabIndex = 19;
      this.label8.Text = "Threads";
      // 
      // label7
      // 
      this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(251, 6);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(74, 22);
      this.label7.TabIndex = 20;
      this.label7.Text = "Buckets";
      // 
      // label10
      // 
      this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label10.AutoSize = true;
      this.label10.Location = new System.Drawing.Point(251, 40);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(110, 22);
      this.label10.TabIndex = 21;
      this.label10.Text = "Buckets 3+4";
      // 
      // btnSuggestion
      // 
      this.btnSuggestion.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.btnSuggestion.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.btnSuggestion.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.btnSuggestion.DisabledForeColor = System.Drawing.Color.Gray;
      this.btnSuggestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.btnSuggestion.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
      this.btnSuggestion.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
      this.btnSuggestion.HoverTextColor = System.Drawing.Color.White;
      this.btnSuggestion.IsDerivedStyle = true;
      this.btnSuggestion.Location = new System.Drawing.Point(392, 73);
      this.btnSuggestion.Name = "btnSuggestion";
      this.btnSuggestion.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.btnSuggestion.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.btnSuggestion.NormalTextColor = System.Drawing.Color.White;
      this.btnSuggestion.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
      this.btnSuggestion.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
      this.btnSuggestion.PressTextColor = System.Drawing.Color.White;
      this.btnSuggestion.Size = new System.Drawing.Size(94, 39);
      this.btnSuggestion.Style = MetroSet_UI.Enums.Style.Light;
      this.btnSuggestion.StyleManager = null;
      this.btnSuggestion.TabIndex = 30;
      this.btnSuggestion.Text = "Get Suggestion";
      this.btnSuggestion.ThemeAuthor = "Narwin";
      this.btnSuggestion.ThemeName = "MetroLite";
      // 
      // numThreadX
      // 
      this.numThreadX.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.numThreadX.Location = new System.Drawing.Point(103, 79);
      this.numThreadX.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
      this.numThreadX.Name = "numThreadX";
      this.numThreadX.Size = new System.Drawing.Size(140, 27);
      this.numThreadX.TabIndex = 31;
      this.numThreadX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // metroSetControlBox1
      // 
      this.metroSetControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.metroSetControlBox1.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
      this.metroSetControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
      this.metroSetControlBox1.CloseNormalForeColor = System.Drawing.Color.Gray;
      this.metroSetControlBox1.DisabledForeColor = System.Drawing.Color.DimGray;
      this.metroSetControlBox1.IsDerivedStyle = true;
      this.metroSetControlBox1.Location = new System.Drawing.Point(977, 7);
      this.metroSetControlBox1.MaximizeBox = false;
      this.metroSetControlBox1.MaximizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
      this.metroSetControlBox1.MaximizeHoverForeColor = System.Drawing.Color.Gray;
      this.metroSetControlBox1.MaximizeNormalForeColor = System.Drawing.Color.Gray;
      this.metroSetControlBox1.MinimizeBox = true;
      this.metroSetControlBox1.MinimizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
      this.metroSetControlBox1.MinimizeHoverForeColor = System.Drawing.Color.Gray;
      this.metroSetControlBox1.MinimizeNormalForeColor = System.Drawing.Color.Gray;
      this.metroSetControlBox1.Name = "metroSetControlBox1";
      this.metroSetControlBox1.Size = new System.Drawing.Size(100, 25);
      this.metroSetControlBox1.Style = MetroSet_UI.Enums.Style.Light;
      this.metroSetControlBox1.StyleManager = null;
      this.metroSetControlBox1.TabIndex = 13;
      this.metroSetControlBox1.Text = "metroSetControlBox1";
      this.metroSetControlBox1.ThemeAuthor = "Narwin";
      this.metroSetControlBox1.ThemeName = "MetroLite";
      // 
      // btnStart
      // 
      this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnStart.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.btnStart.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.btnStart.DisabledForeColor = System.Drawing.Color.Gray;
      this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.btnStart.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
      this.btnStart.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
      this.btnStart.HoverTextColor = System.Drawing.Color.White;
      this.btnStart.IsDerivedStyle = true;
      this.btnStart.Location = new System.Drawing.Point(921, 905);
      this.btnStart.Name = "btnStart";
      this.btnStart.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.btnStart.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.btnStart.NormalTextColor = System.Drawing.Color.White;
      this.btnStart.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
      this.btnStart.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
      this.btnStart.PressTextColor = System.Drawing.Color.White;
      this.btnStart.Size = new System.Drawing.Size(75, 23);
      this.btnStart.Style = MetroSet_UI.Enums.Style.Light;
      this.btnStart.StyleManager = null;
      this.btnStart.TabIndex = 14;
      this.btnStart.Text = "Start";
      this.btnStart.ThemeAuthor = "Narwin";
      this.btnStart.ThemeName = "MetroLite";
      this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
      // 
      // btnStop
      // 
      this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnStop.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.btnStop.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.btnStop.DisabledForeColor = System.Drawing.Color.Gray;
      this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.btnStop.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
      this.btnStop.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
      this.btnStop.HoverTextColor = System.Drawing.Color.White;
      this.btnStop.IsDerivedStyle = true;
      this.btnStop.Location = new System.Drawing.Point(1002, 905);
      this.btnStop.Name = "btnStop";
      this.btnStop.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.btnStop.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.btnStop.NormalTextColor = System.Drawing.Color.White;
      this.btnStop.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
      this.btnStop.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
      this.btnStop.PressTextColor = System.Drawing.Color.White;
      this.btnStop.Size = new System.Drawing.Size(75, 23);
      this.btnStop.Style = MetroSet_UI.Enums.Style.Light;
      this.btnStop.StyleManager = null;
      this.btnStop.TabIndex = 15;
      this.btnStop.Text = "Stop";
      this.btnStop.ThemeAuthor = "Narwin";
      this.btnStop.ThemeName = "MetroLite";
      this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
      // 
      // btnNew
      // 
      this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.btnNew.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.btnNew.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.btnNew.DisabledForeColor = System.Drawing.Color.Gray;
      this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.btnNew.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
      this.btnNew.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
      this.btnNew.HoverTextColor = System.Drawing.Color.White;
      this.btnNew.IsDerivedStyle = true;
      this.btnNew.Location = new System.Drawing.Point(16, 905);
      this.btnNew.Name = "btnNew";
      this.btnNew.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.btnNew.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.btnNew.NormalTextColor = System.Drawing.Color.White;
      this.btnNew.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
      this.btnNew.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
      this.btnNew.PressTextColor = System.Drawing.Color.White;
      this.btnNew.Size = new System.Drawing.Size(75, 23);
      this.btnNew.Style = MetroSet_UI.Enums.Style.Light;
      this.btnNew.StyleManager = null;
      this.btnNew.TabIndex = 16;
      this.btnNew.Text = "New";
      this.btnNew.ThemeAuthor = "Narwin";
      this.btnNew.ThemeName = "MetroLite";
      this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
      // 
      // btnSave
      // 
      this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.btnSave.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.btnSave.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.btnSave.DisabledForeColor = System.Drawing.Color.Gray;
      this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.btnSave.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
      this.btnSave.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
      this.btnSave.HoverTextColor = System.Drawing.Color.White;
      this.btnSave.IsDerivedStyle = true;
      this.btnSave.Location = new System.Drawing.Point(178, 905);
      this.btnSave.Name = "btnSave";
      this.btnSave.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.btnSave.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.btnSave.NormalTextColor = System.Drawing.Color.White;
      this.btnSave.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
      this.btnSave.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
      this.btnSave.PressTextColor = System.Drawing.Color.White;
      this.btnSave.Size = new System.Drawing.Size(75, 23);
      this.btnSave.Style = MetroSet_UI.Enums.Style.Light;
      this.btnSave.StyleManager = null;
      this.btnSave.TabIndex = 17;
      this.btnSave.Text = "Save";
      this.btnSave.ThemeAuthor = "Narwin";
      this.btnSave.ThemeName = "MetroLite";
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // btnLoad
      // 
      this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.btnLoad.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.btnLoad.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.btnLoad.DisabledForeColor = System.Drawing.Color.Gray;
      this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.btnLoad.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
      this.btnLoad.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
      this.btnLoad.HoverTextColor = System.Drawing.Color.White;
      this.btnLoad.IsDerivedStyle = true;
      this.btnLoad.Location = new System.Drawing.Point(97, 905);
      this.btnLoad.Name = "btnLoad";
      this.btnLoad.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.btnLoad.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.btnLoad.NormalTextColor = System.Drawing.Color.White;
      this.btnLoad.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
      this.btnLoad.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
      this.btnLoad.PressTextColor = System.Drawing.Color.White;
      this.btnLoad.Size = new System.Drawing.Size(75, 23);
      this.btnLoad.Style = MetroSet_UI.Enums.Style.Light;
      this.btnLoad.StyleManager = null;
      this.btnLoad.TabIndex = 18;
      this.btnLoad.Text = "Load";
      this.btnLoad.ThemeAuthor = "Narwin";
      this.btnLoad.ThemeName = "MetroLite";
      this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
      // 
      // btnAbout
      // 
      this.btnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.btnAbout.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.btnAbout.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.btnAbout.DisabledForeColor = System.Drawing.Color.Gray;
      this.btnAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.btnAbout.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
      this.btnAbout.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
      this.btnAbout.HoverTextColor = System.Drawing.Color.White;
      this.btnAbout.IsDerivedStyle = true;
      this.btnAbout.Location = new System.Drawing.Point(259, 905);
      this.btnAbout.Name = "btnAbout";
      this.btnAbout.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.btnAbout.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.btnAbout.NormalTextColor = System.Drawing.Color.White;
      this.btnAbout.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
      this.btnAbout.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
      this.btnAbout.PressTextColor = System.Drawing.Color.White;
      this.btnAbout.Size = new System.Drawing.Size(75, 23);
      this.btnAbout.Style = MetroSet_UI.Enums.Style.Light;
      this.btnAbout.StyleManager = null;
      this.btnAbout.TabIndex = 19;
      this.btnAbout.Text = "About";
      this.btnAbout.ThemeAuthor = "Narwin";
      this.btnAbout.ThemeName = "MetroLite";
      this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
      // 
      // groupBox4
      // 
      this.groupBox4.BackColor = System.Drawing.Color.White;
      this.groupBox4.Controls.Add(this.tableLayoutPanel4);
      this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.groupBox4.Location = new System.Drawing.Point(15, 291);
      this.groupBox4.Name = "groupBox4";
      this.groupBox4.Size = new System.Drawing.Size(531, 100);
      this.groupBox4.TabIndex = 20;
      this.groupBox4.TabStop = false;
      this.groupBox4.Text = "Logging";
      // 
      // tableLayoutPanel4
      // 
      this.tableLayoutPanel4.ColumnCount = 3;
      this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 94F));
      this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 379F));
      this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
      this.tableLayoutPanel4.Controls.Add(this.label14, 0, 1);
      this.tableLayoutPanel4.Controls.Add(this.label16, 0, 0);
      this.tableLayoutPanel4.Controls.Add(this.mstLogPath, 2, 1);
      this.tableLayoutPanel4.Controls.Add(this.tbLogPath, 1, 1);
      this.tableLayoutPanel4.Controls.Add(this.swLogActive, 1, 0);
      this.tableLayoutPanel4.Location = new System.Drawing.Point(6, 22);
      this.tableLayoutPanel4.Name = "tableLayoutPanel4";
      this.tableLayoutPanel4.RowCount = 2;
      this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
      this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
      this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel4.Size = new System.Drawing.Size(513, 71);
      this.tableLayoutPanel4.TabIndex = 13;
      // 
      // label14
      // 
      this.label14.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label14.AutoSize = true;
      this.label14.Location = new System.Drawing.Point(3, 41);
      this.label14.Name = "label14";
      this.label14.Size = new System.Drawing.Size(47, 22);
      this.label14.TabIndex = 21;
      this.label14.Text = "Path";
      // 
      // label16
      // 
      this.label16.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label16.AutoSize = true;
      this.label16.Location = new System.Drawing.Point(3, 6);
      this.label16.Name = "label16";
      this.label16.Size = new System.Drawing.Size(59, 22);
      this.label16.TabIndex = 15;
      this.label16.Text = "Active";
      // 
      // mstLogPath
      // 
      this.mstLogPath.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.mstLogPath.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mstLogPath.BackgroundImage")));
      this.mstLogPath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
      this.mstLogPath.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
      this.mstLogPath.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
      this.mstLogPath.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
      this.mstLogPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.mstLogPath.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
      this.mstLogPath.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.mstLogPath.HoverTextColor = System.Drawing.Color.White;
      this.mstLogPath.IsDerivedStyle = true;
      this.mstLogPath.Location = new System.Drawing.Point(476, 38);
      this.mstLogPath.Name = "mstLogPath";
      this.mstLogPath.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.mstLogPath.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.mstLogPath.NormalTextColor = System.Drawing.Color.White;
      this.mstLogPath.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.mstLogPath.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.mstLogPath.PressTextColor = System.Drawing.Color.White;
      this.mstLogPath.Size = new System.Drawing.Size(32, 28);
      this.mstLogPath.Style = MetroSet_UI.Enums.Style.Light;
      this.mstLogPath.StyleManager = null;
      this.mstLogPath.TabIndex = 20;
      this.mstLogPath.ThemeAuthor = "Narwin";
      this.mstLogPath.ThemeName = "MetroLite";
      this.mstLogPath.TileAlign = MetroSet_UI.Enums.TileAlign.Topleft;
      this.mstLogPath.Click += new System.EventHandler(this.mstfinalDir_Click);
      // 
      // tbLogPath
      // 
      this.tbLogPath.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.tbLogPath.Location = new System.Drawing.Point(101, 39);
      this.tbLogPath.Name = "tbLogPath";
      this.tbLogPath.Size = new System.Drawing.Size(365, 27);
      this.tbLogPath.TabIndex = 16;
      // 
      // swLogActive
      // 
      this.swLogActive.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.swLogActive.BackColor = System.Drawing.Color.Transparent;
      this.swLogActive.BackgroundColor = System.Drawing.Color.Empty;
      this.swLogActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(159)))), ((int)(((byte)(147)))));
      this.swLogActive.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.swLogActive.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
      this.swLogActive.Cursor = System.Windows.Forms.Cursors.Hand;
      this.swLogActive.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
      this.swLogActive.DisabledCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.swLogActive.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
      this.swLogActive.IsDerivedStyle = true;
      this.swLogActive.Location = new System.Drawing.Point(101, 6);
      this.swLogActive.Margin = new System.Windows.Forms.Padding(7, 3, 3, 3);
      this.swLogActive.Name = "swLogActive";
      this.swLogActive.Size = new System.Drawing.Size(58, 22);
      this.swLogActive.Style = MetroSet_UI.Enums.Style.Light;
      this.swLogActive.StyleManager = null;
      this.swLogActive.Switched = false;
      this.swLogActive.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
      this.swLogActive.TabIndex = 19;
      this.swLogActive.Text = "metroSetSwitch3";
      this.swLogActive.ThemeAuthor = "Narwin";
      this.swLogActive.ThemeName = "MetroLite";
      this.swLogActive.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
      // 
      // tbProcOutput
      // 
      this.tbProcOutput.Location = new System.Drawing.Point(16, 397);
      this.tbProcOutput.Multiline = true;
      this.tbProcOutput.Name = "tbProcOutput";
      this.tbProcOutput.Size = new System.Drawing.Size(1067, 502);
      this.tbProcOutput.TabIndex = 21;
      // 
      // openFileDialog1
      // 
      this.openFileDialog1.DefaultExt = "pltcfg";
      this.openFileDialog1.Filter = "Plotter config (*.pltcfg)|";
      // 
      // FormMain
      // 
      this.AllowResize = false;
      this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1092, 943);
      this.Controls.Add(this.tbProcOutput);
      this.Controls.Add(this.groupBox4);
      this.Controls.Add(this.btnAbout);
      this.Controls.Add(this.btnLoad);
      this.Controls.Add(this.btnSave);
      this.Controls.Add(this.btnNew);
      this.Controls.Add(this.btnStop);
      this.Controls.Add(this.btnStart);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.metroSetControlBox1);
      this.Controls.Add(this.groupBox3);
      this.Controls.Add(this.groupBox2);
      this.DropShadowEffect = false;
      this.Name = "FormMain";
      this.Padding = new System.Windows.Forms.Padding(12, 90, 12, 12);
      this.ShowBorder = true;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Chia-Plotter GUI by OnLyTNT";
      this.groupBox1.ResumeLayout(false);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.tableLayoutPanel2.ResumeLayout(false);
      this.tableLayoutPanel2.PerformLayout();
      this.groupBox3.ResumeLayout(false);
      this.tableLayoutPanel3.ResumeLayout(false);
      this.tableLayoutPanel3.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numBuckets34)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numBuckets)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numThreads)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numThreadX)).EndInit();
      this.groupBox4.ResumeLayout(false);
      this.tableLayoutPanel4.ResumeLayout(false);
      this.tableLayoutPanel4.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTemp2Dir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbFinalDir;
        private System.Windows.Forms.TextBox tbTempDir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox tbContractKey;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbFarmerKey;
        private System.Windows.Forms.TextBox tbPoolKey;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroSet_UI.Controls.MetroSetSwitch swAlternateTemps;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ComboBox cbPlots;
        private System.Windows.Forms.Label label12;
        private MetroSet_UI.Controls.MetroSetSwitch swWait4Copy;
        private System.Windows.Forms.Label label13;
        private MetroSet_UI.Controls.MetroSetTile mstFinalDir;
        private MetroSet_UI.Controls.MetroSetTile mstTempDir;
        private MetroSet_UI.Controls.MetroSetTile mstTemp2Dir;
        private MetroSet_UI.Controls.MetroSetButton btnSuggestion;
        private MetroSet_UI.Controls.MetroSetButton btnStart;
        private MetroSet_UI.Controls.MetroSetButton btnStop;
        private MetroSet_UI.Controls.MetroSetButton btnNew;
        private MetroSet_UI.Controls.MetroSetButton btnSave;
        private MetroSet_UI.Controls.MetroSetButton btnLoad;
        private MetroSet_UI.Controls.MetroSetButton btnAbout;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    private System.Windows.Forms.GroupBox groupBox4;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
    private MetroSet_UI.Controls.MetroSetSwitch swLogActive;
    private System.Windows.Forms.Label label16;
    private MetroSet_UI.Controls.MetroSetTile mstLogPath;
    private System.Windows.Forms.TextBox tbLogPath;
    private System.Windows.Forms.Label label14;
    private System.Windows.Forms.TextBox tbProcOutput;
    private System.Windows.Forms.OpenFileDialog openFileDialog1;
    private System.Windows.Forms.NumericUpDown numBuckets34;
    private System.Windows.Forms.NumericUpDown numBuckets;
    private System.Windows.Forms.NumericUpDown numThreads;
    private System.Windows.Forms.NumericUpDown numThreadX;
  }
}

