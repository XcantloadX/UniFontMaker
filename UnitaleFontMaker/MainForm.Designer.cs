namespace UnitaleFontMaker
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPreviewImage;
		
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPreviewImage = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnChangeEnglishFont = new System.Windows.Forms.Button();
            this.lblEnglishFontPreview = new System.Windows.Forms.Label();
            this.lblNormalFontPreview = new System.Windows.Forms.Label();
            this.lblEnglishFontInfo = new System.Windows.Forms.Label();
            this.lblNormalFontInfo = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnChangeNomalFont = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnClear = new System.Windows.Forms.Button();
            this.labCharNum = new System.Windows.Forms.Label();
            this.btnAddChar = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.checkBoxDrawBorder = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxFontYOffset = new System.Windows.Forms.TextBox();
            this.txtboxLineSpacing = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.picboxColor = new System.Windows.Forms.PictureBox();
            this.btnChooseColor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboxType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxX = new System.Windows.Forms.TextBox();
            this.txtboxY = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxColor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(11, 422);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 33);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSaveFileClick);
            // 
            // btnPreviewImage
            // 
            this.btnPreviewImage.Location = new System.Drawing.Point(141, 422);
            this.btnPreviewImage.Margin = new System.Windows.Forms.Padding(2);
            this.btnPreviewImage.Name = "btnPreviewImage";
            this.btnPreviewImage.Size = new System.Drawing.Size(117, 33);
            this.btnPreviewImage.TabIndex = 4;
            this.btnPreviewImage.Text = "Image Preview";
            this.btnPreviewImage.UseVisualStyleBackColor = true;
            this.btnPreviewImage.Click += new System.EventHandler(this.BtnPreviewClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(705, 416);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnChangeEnglishFont);
            this.tabPage1.Controls.Add(this.lblEnglishFontPreview);
            this.tabPage1.Controls.Add(this.lblNormalFontPreview);
            this.tabPage1.Controls.Add(this.lblEnglishFontInfo);
            this.tabPage1.Controls.Add(this.lblNormalFontInfo);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.btnChangeNomalFont);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(697, 390);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Font Settings";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnChangeEnglishFont
            // 
            this.btnChangeEnglishFont.Location = new System.Drawing.Point(41, 269);
            this.btnChangeEnglishFont.Margin = new System.Windows.Forms.Padding(2);
            this.btnChangeEnglishFont.Name = "btnChangeEnglishFont";
            this.btnChangeEnglishFont.Size = new System.Drawing.Size(90, 33);
            this.btnChangeEnglishFont.TabIndex = 35;
            this.btnChangeEnglishFont.Text = "Change";
            this.btnChangeEnglishFont.UseVisualStyleBackColor = true;
            this.btnChangeEnglishFont.Click += new System.EventHandler(this.btnChangeEnglishFont_Click);
            // 
            // lblEnglishFontPreview
            // 
            this.lblEnglishFontPreview.AutoSize = true;
            this.lblEnglishFontPreview.Location = new System.Drawing.Point(39, 224);
            this.lblEnglishFontPreview.Name = "lblEnglishFontPreview";
            this.lblEnglishFontPreview.Size = new System.Drawing.Size(269, 12);
            this.lblEnglishFontPreview.TabIndex = 34;
            this.lblEnglishFontPreview.Text = "The quick brown fox jumps over the lazy dog.";
            // 
            // lblNormalFontPreview
            // 
            this.lblNormalFontPreview.AutoSize = true;
            this.lblNormalFontPreview.Location = new System.Drawing.Point(39, 70);
            this.lblNormalFontPreview.Name = "lblNormalFontPreview";
            this.lblNormalFontPreview.Size = new System.Drawing.Size(269, 12);
            this.lblNormalFontPreview.TabIndex = 33;
            this.lblNormalFontPreview.Text = "The quick brown fox jumps over the lazy dog.";
            // 
            // lblEnglishFontInfo
            // 
            this.lblEnglishFontInfo.AutoSize = true;
            this.lblEnglishFontInfo.Location = new System.Drawing.Point(39, 190);
            this.lblEnglishFontInfo.Name = "lblEnglishFontInfo";
            this.lblEnglishFontInfo.Size = new System.Drawing.Size(35, 12);
            this.lblEnglishFontInfo.TabIndex = 32;
            this.lblEnglishFontInfo.Text = "Empty";
            // 
            // lblNormalFontInfo
            // 
            this.lblNormalFontInfo.AutoSize = true;
            this.lblNormalFontInfo.Location = new System.Drawing.Point(39, 38);
            this.lblNormalFontInfo.Name = "lblNormalFontInfo";
            this.lblNormalFontInfo.Size = new System.Drawing.Size(35, 12);
            this.lblNormalFontInfo.TabIndex = 31;
            this.lblNormalFontInfo.Text = "Empty";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(17, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(215, 16);
            this.label9.TabIndex = 30;
            this.label9.Text = "English Font (Optional)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(16, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 16);
            this.label8.TabIndex = 29;
            this.label8.Text = "Normal Font";
            // 
            // btnChangeNomalFont
            // 
            this.btnChangeNomalFont.Location = new System.Drawing.Point(41, 112);
            this.btnChangeNomalFont.Margin = new System.Windows.Forms.Padding(2);
            this.btnChangeNomalFont.Name = "btnChangeNomalFont";
            this.btnChangeNomalFont.Size = new System.Drawing.Size(90, 33);
            this.btnChangeNomalFont.TabIndex = 28;
            this.btnChangeNomalFont.Text = "Change";
            this.btnChangeNomalFont.UseVisualStyleBackColor = true;
            this.btnChangeNomalFont.Click += new System.EventHandler(this.btnChangeNomalFont_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnClear);
            this.tabPage2.Controls.Add(this.labCharNum);
            this.tabPage2.Controls.Add(this.btnAddChar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(697, 390);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Character Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(97, 43);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(54, 35);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // labCharNum
            // 
            this.labCharNum.Location = new System.Drawing.Point(28, 16);
            this.labCharNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labCharNum.Name = "labCharNum";
            this.labCharNum.Size = new System.Drawing.Size(252, 14);
            this.labCharNum.TabIndex = 12;
            this.labCharNum.Text = "No characters, please add from text file.";
            // 
            // btnAddChar
            // 
            this.btnAddChar.Location = new System.Drawing.Point(30, 43);
            this.btnAddChar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddChar.Name = "btnAddChar";
            this.btnAddChar.Size = new System.Drawing.Size(54, 35);
            this.btnAddChar.TabIndex = 11;
            this.btnAddChar.Text = "Add";
            this.btnAddChar.UseVisualStyleBackColor = true;
            this.btnAddChar.Click += new System.EventHandler(this.btnAddChar_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.checkBoxDrawBorder);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.textBoxFontYOffset);
            this.tabPage3.Controls.Add(this.txtboxLineSpacing);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.picboxColor);
            this.tabPage3.Controls.Add(this.btnChooseColor);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.comboxType);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.txtboxX);
            this.tabPage3.Controls.Add(this.txtboxY);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(697, 390);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Export Settings";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // checkBoxDrawBorder
            // 
            this.checkBoxDrawBorder.AutoSize = true;
            this.checkBoxDrawBorder.Location = new System.Drawing.Point(18, 145);
            this.checkBoxDrawBorder.Name = "checkBoxDrawBorder";
            this.checkBoxDrawBorder.Size = new System.Drawing.Size(126, 16);
            this.checkBoxDrawBorder.TabIndex = 26;
            this.checkBoxDrawBorder.Text = "Draw Debug Border";
            this.checkBoxDrawBorder.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 12);
            this.label4.TabIndex = 25;
            this.label4.Text = "Font Y Offset";
            // 
            // textBoxFontYOffset
            // 
            this.textBoxFontYOffset.Location = new System.Drawing.Point(111, 114);
            this.textBoxFontYOffset.Name = "textBoxFontYOffset";
            this.textBoxFontYOffset.Size = new System.Drawing.Size(100, 21);
            this.textBoxFontYOffset.TabIndex = 24;
            this.textBoxFontYOffset.Text = "0";
            // 
            // txtboxLineSpacing
            // 
            this.txtboxLineSpacing.Location = new System.Drawing.Point(111, 88);
            this.txtboxLineSpacing.Margin = new System.Windows.Forms.Padding(2);
            this.txtboxLineSpacing.Name = "txtboxLineSpacing";
            this.txtboxLineSpacing.Size = new System.Drawing.Size(38, 21);
            this.txtboxLineSpacing.TabIndex = 23;
            this.txtboxLineSpacing.Text = "30";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 91);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 12);
            this.label7.TabIndex = 22;
            this.label7.Text = "Line Spacing";
            // 
            // picboxColor
            // 
            this.picboxColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picboxColor.Location = new System.Drawing.Point(111, 62);
            this.picboxColor.Margin = new System.Windows.Forms.Padding(2);
            this.picboxColor.Name = "picboxColor";
            this.picboxColor.Size = new System.Drawing.Size(22, 20);
            this.picboxColor.TabIndex = 21;
            this.picboxColor.TabStop = false;
            // 
            // btnChooseColor
            // 
            this.btnChooseColor.Location = new System.Drawing.Point(137, 63);
            this.btnChooseColor.Margin = new System.Windows.Forms.Padding(2);
            this.btnChooseColor.Name = "btnChooseColor";
            this.btnChooseColor.Size = new System.Drawing.Size(56, 18);
            this.btnChooseColor.TabIndex = 20;
            this.btnChooseColor.Text = "Choose";
            this.btnChooseColor.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 19;
            this.label2.Text = "Font Color";
            // 
            // comboxType
            // 
            this.comboxType.FormattingEnabled = true;
            this.comboxType.Items.AddRange(new object[] {
            "uidialog",
            "monster"});
            this.comboxType.Location = new System.Drawing.Point(111, 38);
            this.comboxType.Margin = new System.Windows.Forms.Padding(2);
            this.comboxType.Name = "comboxType";
            this.comboxType.Size = new System.Drawing.Size(152, 20);
            this.comboxType.TabIndex = 18;
            this.comboxType.Text = "uidialog";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 40);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 17;
            this.label6.Text = "Font Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "x";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Image Size";
            // 
            // txtboxX
            // 
            this.txtboxX.Location = new System.Drawing.Point(111, 11);
            this.txtboxX.Margin = new System.Windows.Forms.Padding(2);
            this.txtboxX.Name = "txtboxX";
            this.txtboxX.Size = new System.Drawing.Size(38, 21);
            this.txtboxX.TabIndex = 8;
            this.txtboxX.Text = "2000";
            // 
            // txtboxY
            // 
            this.txtboxY.Location = new System.Drawing.Point(166, 12);
            this.txtboxY.Margin = new System.Windows.Forms.Padding(2);
            this.txtboxY.Name = "txtboxY";
            this.txtboxY.Size = new System.Drawing.Size(37, 21);
            this.txtboxY.TabIndex = 9;
            this.txtboxY.Text = "2000";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 465);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnPreviewImage);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Unitale Font Maker";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxColor)).EndInit();
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxX;
        private System.Windows.Forms.TextBox txtboxY;
        private System.Windows.Forms.CheckBox checkBoxDrawBorder;
        private System.Windows.Forms.TextBox txtboxLineSpacing;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox picboxColor;
        private System.Windows.Forms.Button btnChooseColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboxType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnChangeNomalFont;
        private System.Windows.Forms.Label lblEnglishFontInfo;
        private System.Windows.Forms.Label lblNormalFontInfo;
        private System.Windows.Forms.Label lblEnglishFontPreview;
        private System.Windows.Forms.Label lblNormalFontPreview;
        private System.Windows.Forms.Button btnChangeEnglishFont;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxFontYOffset;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label labCharNum;
        private System.Windows.Forms.Button btnAddChar;
    }
}
