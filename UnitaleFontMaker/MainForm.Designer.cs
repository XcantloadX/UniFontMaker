namespace UnitaleFontMaker
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnAutoSave;
		private System.Windows.Forms.Button btnSaveFile;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button btnPreview;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnAddChar;
		private System.Windows.Forms.TextBox txtboxY;
		private System.Windows.Forms.TextBox txtboxX;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label labCharNum;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnAutoModeHtlp;
		private System.Windows.Forms.Button btnOpenMod;
		private System.Windows.Forms.TextBox txtboxModPath;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox groupBox1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.btnAutoSave = new System.Windows.Forms.Button();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnScan = new System.Windows.Forms.Button();
            this.btnAutoModeHtlp = new System.Windows.Forms.Button();
            this.btnOpenMod = new System.Windows.Forms.Button();
            this.txtboxModPath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtboxLineSpacing = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.picboxColor = new System.Windows.Forms.PictureBox();
            this.btnChooseColor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.comboxType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labCharNum = new System.Windows.Forms.Label();
            this.txtboxX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtboxY = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddChar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxColor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAutoSave
            // 
            this.btnAutoSave.Enabled = false;
            this.btnAutoSave.Location = new System.Drawing.Point(9, 300);
            this.btnAutoSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnAutoSave.Name = "btnAutoSave";
            this.btnAutoSave.Size = new System.Drawing.Size(78, 34);
            this.btnAutoSave.TabIndex = 1;
            this.btnAutoSave.Text = "Auto Save";
            this.btnAutoSave.UseVisualStyleBackColor = true;
            this.btnAutoSave.Click += new System.EventHandler(this.BtnAutoSaveClick);
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Location = new System.Drawing.Point(92, 300);
            this.btnSaveFile.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(94, 33);
            this.btnSaveFile.TabIndex = 2;
            this.btnSaveFile.Text = "Save As File";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            this.btnSaveFile.Click += new System.EventHandler(this.BtnSaveFileClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(190, 300);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 34);
            this.button2.TabIndex = 3;
            this.button2.Text = "Set Font";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(270, 300);
            this.btnPreview.Margin = new System.Windows.Forms.Padding(2);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(70, 33);
            this.btnPreview.TabIndex = 4;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.BtnPreviewClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(4, 6);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 287);
            this.panel1.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnScan);
            this.groupBox2.Controls.Add(this.btnAutoModeHtlp);
            this.groupBox2.Controls.Add(this.btnOpenMod);
            this.groupBox2.Controls.Add(this.txtboxModPath);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(5, 174);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(365, 80);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mod Settings";
            // 
            // btnScan
            // 
            this.btnScan.Enabled = false;
            this.btnScan.Location = new System.Drawing.Point(4, 39);
            this.btnScan.Margin = new System.Windows.Forms.Padding(2);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(74, 25);
            this.btnScan.TabIndex = 9;
            this.btnScan.Text = "Auto Scan";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.BtnScanClick);
            // 
            // btnAutoModeHtlp
            // 
            this.btnAutoModeHtlp.Location = new System.Drawing.Point(82, 42);
            this.btnAutoModeHtlp.Margin = new System.Windows.Forms.Padding(2);
            this.btnAutoModeHtlp.Name = "btnAutoModeHtlp";
            this.btnAutoModeHtlp.Size = new System.Drawing.Size(14, 18);
            this.btnAutoModeHtlp.TabIndex = 8;
            this.btnAutoModeHtlp.Text = "?";
            this.btnAutoModeHtlp.UseVisualStyleBackColor = true;
            this.btnAutoModeHtlp.Click += new System.EventHandler(this.BtnAutoModeHtlpClick);
            // 
            // btnOpenMod
            // 
            this.btnOpenMod.Location = new System.Drawing.Point(330, 18);
            this.btnOpenMod.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpenMod.Name = "btnOpenMod";
            this.btnOpenMod.Size = new System.Drawing.Size(32, 19);
            this.btnOpenMod.TabIndex = 5;
            this.btnOpenMod.Text = "...";
            this.btnOpenMod.UseVisualStyleBackColor = true;
            this.btnOpenMod.Click += new System.EventHandler(this.BtnOpenModClick);
            // 
            // txtboxModPath
            // 
            this.txtboxModPath.Location = new System.Drawing.Point(64, 17);
            this.txtboxModPath.Margin = new System.Windows.Forms.Padding(2);
            this.txtboxModPath.Name = "txtboxModPath";
            this.txtboxModPath.Size = new System.Drawing.Size(263, 21);
            this.txtboxModPath.TabIndex = 4;
            this.txtboxModPath.Text = "C:\\Users\\Administrator\\Desktop\\杂项\\UNITALE Alpha 0.2.1a for Windows\\Mods\\Examples5" +
                "454";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(4, 19);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Mod Path";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtboxLineSpacing);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.picboxColor);
            this.groupBox1.Controls.Add(this.btnChooseColor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.comboxType);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.labCharNum);
            this.groupBox1.Controls.Add(this.txtboxX);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtboxY);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnAddChar);
            this.groupBox1.Location = new System.Drawing.Point(2, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(368, 162);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Font Settings";
            // 
            // txtboxLineSpacing
            // 
            this.txtboxLineSpacing.Location = new System.Drawing.Point(89, 137);
            this.txtboxLineSpacing.Margin = new System.Windows.Forms.Padding(2);
            this.txtboxLineSpacing.Name = "txtboxLineSpacing";
            this.txtboxLineSpacing.Size = new System.Drawing.Size(76, 21);
            this.txtboxLineSpacing.TabIndex = 16;
            this.txtboxLineSpacing.Text = "32";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 139);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 12);
            this.label7.TabIndex = 15;
            this.label7.Text = "Line spacing";
            // 
            // picboxColor
            // 
            this.picboxColor.Location = new System.Drawing.Point(77, 110);
            this.picboxColor.Margin = new System.Windows.Forms.Padding(2);
            this.picboxColor.Name = "picboxColor";
            this.picboxColor.Size = new System.Drawing.Size(22, 20);
            this.picboxColor.TabIndex = 14;
            this.picboxColor.TabStop = false;
            // 
            // btnChooseColor
            // 
            this.btnChooseColor.Location = new System.Drawing.Point(104, 110);
            this.btnChooseColor.Margin = new System.Windows.Forms.Padding(2);
            this.btnChooseColor.Name = "btnChooseColor";
            this.btnChooseColor.Size = new System.Drawing.Size(56, 18);
            this.btnChooseColor.TabIndex = 13;
            this.btnChooseColor.Text = "Choose";
            this.btnChooseColor.UseVisualStyleBackColor = true;
            this.btnChooseColor.Click += new System.EventHandler(this.btnChooseColor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "Font color";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(49, 62);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(48, 18);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // comboxType
            // 
            this.comboxType.FormattingEnabled = true;
            this.comboxType.Items.AddRange(new object[] {
            "uidialog",
            "monster"});
            this.comboxType.Location = new System.Drawing.Point(76, 86);
            this.comboxType.Margin = new System.Windows.Forms.Padding(2);
            this.comboxType.Name = "comboxType";
            this.comboxType.Size = new System.Drawing.Size(152, 20);
            this.comboxType.TabIndex = 9;
            this.comboxType.Text = "uidialog";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 88);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "Font name";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Image size";
            // 
            // labCharNum
            // 
            this.labCharNum.Location = new System.Drawing.Point(8, 46);
            this.labCharNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labCharNum.Name = "labCharNum";
            this.labCharNum.Size = new System.Drawing.Size(252, 14);
            this.labCharNum.TabIndex = 7;
            this.labCharNum.Text = "No characters, please add from text file.";
            // 
            // txtboxX
            // 
            this.txtboxX.Location = new System.Drawing.Point(108, 15);
            this.txtboxX.Margin = new System.Windows.Forms.Padding(2);
            this.txtboxX.Name = "txtboxX";
            this.txtboxX.Size = new System.Drawing.Size(54, 21);
            this.txtboxX.TabIndex = 1;
            this.txtboxX.Text = "400";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(170, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Y";
            // 
            // txtboxY
            // 
            this.txtboxY.Location = new System.Drawing.Point(184, 15);
            this.txtboxY.Margin = new System.Windows.Forms.Padding(2);
            this.txtboxY.Name = "txtboxY";
            this.txtboxY.Size = new System.Drawing.Size(56, 21);
            this.txtboxY.TabIndex = 2;
            this.txtboxY.Text = "400";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(94, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "X";
            // 
            // btnAddChar
            // 
            this.btnAddChar.Location = new System.Drawing.Point(7, 62);
            this.btnAddChar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddChar.Name = "btnAddChar";
            this.btnAddChar.Size = new System.Drawing.Size(38, 18);
            this.btnAddChar.TabIndex = 4;
            this.btnAddChar.Text = "Add";
            this.btnAddChar.UseVisualStyleBackColor = true;
            this.btnAddChar.Click += new System.EventHandler(this.BtnAddFileClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 343);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSaveFile);
            this.Controls.Add(this.btnAutoSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Unitale Font Maker";
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxColor)).EndInit();
            this.ResumeLayout(false);

		}

        private System.Windows.Forms.ComboBox comboxType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnChooseColor;
        private System.Windows.Forms.PictureBox picboxColor;
        private System.Windows.Forms.TextBox txtboxLineSpacing;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnScan;
    }
}
