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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPreviewImage = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnChangeEnglishFont = new System.Windows.Forms.Button();
            this.lblEnglishFontPreview = new System.Windows.Forms.Label();
            this.lblNormalFontPreview = new System.Windows.Forms.Label();
            this.lblEnglishFontInfo = new System.Windows.Forms.Label();
            this.lblNormalFontInfo = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnChangeNomalFont = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnView = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.labCharNum = new System.Windows.Forms.Label();
            this.btnAddChar = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBoxSpaceWidthChar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
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
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSaveFileClick);
            // 
            // btnPreviewImage
            // 
            resources.ApplyResources(this.btnPreviewImage, "btnPreviewImage");
            this.btnPreviewImage.Name = "btnPreviewImage";
            this.btnPreviewImage.UseVisualStyleBackColor = true;
            this.btnPreviewImage.Click += new System.EventHandler(this.BtnPreviewClick);
            // 
            // tabControl1
            // 
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.btnChangeEnglishFont);
            this.tabPage1.Controls.Add(this.lblEnglishFontPreview);
            this.tabPage1.Controls.Add(this.lblNormalFontPreview);
            this.tabPage1.Controls.Add(this.lblEnglishFontInfo);
            this.tabPage1.Controls.Add(this.lblNormalFontInfo);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.btnChangeNomalFont);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // btnChangeEnglishFont
            // 
            resources.ApplyResources(this.btnChangeEnglishFont, "btnChangeEnglishFont");
            this.btnChangeEnglishFont.Name = "btnChangeEnglishFont";
            this.btnChangeEnglishFont.UseVisualStyleBackColor = true;
            this.btnChangeEnglishFont.Click += new System.EventHandler(this.btnChangeEnglishFont_Click);
            // 
            // lblEnglishFontPreview
            // 
            resources.ApplyResources(this.lblEnglishFontPreview, "lblEnglishFontPreview");
            this.lblEnglishFontPreview.Name = "lblEnglishFontPreview";
            // 
            // lblNormalFontPreview
            // 
            resources.ApplyResources(this.lblNormalFontPreview, "lblNormalFontPreview");
            this.lblNormalFontPreview.Name = "lblNormalFontPreview";
            // 
            // lblEnglishFontInfo
            // 
            resources.ApplyResources(this.lblEnglishFontInfo, "lblEnglishFontInfo");
            this.lblEnglishFontInfo.Name = "lblEnglishFontInfo";
            // 
            // lblNormalFontInfo
            // 
            resources.ApplyResources(this.lblNormalFontInfo, "lblNormalFontInfo");
            this.lblNormalFontInfo.Name = "lblNormalFontInfo";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // btnChangeNomalFont
            // 
            resources.ApplyResources(this.btnChangeNomalFont, "btnChangeNomalFont");
            this.btnChangeNomalFont.Name = "btnChangeNomalFont";
            this.btnChangeNomalFont.UseVisualStyleBackColor = true;
            this.btnChangeNomalFont.Click += new System.EventHandler(this.btnChangeNomalFont_Click);
            // 
            // tabPage2
            // 
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Controls.Add(this.btnView);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.btnImport);
            this.tabPage2.Controls.Add(this.btnClear);
            this.tabPage2.Controls.Add(this.labCharNum);
            this.tabPage2.Controls.Add(this.btnAddChar);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnView
            // 
            resources.ApplyResources(this.btnView, "btnView");
            this.btnView.Name = "btnView";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // btnImport
            // 
            resources.ApplyResources(this.btnImport, "btnImport");
            this.btnImport.Name = "btnImport";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnClear
            // 
            resources.ApplyResources(this.btnClear, "btnClear");
            this.btnClear.Name = "btnClear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // labCharNum
            // 
            resources.ApplyResources(this.labCharNum, "labCharNum");
            this.labCharNum.Name = "labCharNum";
            // 
            // btnAddChar
            // 
            resources.ApplyResources(this.btnAddChar, "btnAddChar");
            this.btnAddChar.Name = "btnAddChar";
            this.btnAddChar.UseVisualStyleBackColor = true;
            this.btnAddChar.Click += new System.EventHandler(this.btnAddChar_Click);
            // 
            // tabPage3
            // 
            resources.ApplyResources(this.tabPage3, "tabPage3");
            this.tabPage3.Controls.Add(this.textBoxSpaceWidthChar);
            this.tabPage3.Controls.Add(this.label5);
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
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBoxSpaceWidthChar
            // 
            resources.ApplyResources(this.textBoxSpaceWidthChar, "textBoxSpaceWidthChar");
            this.textBoxSpaceWidthChar.Name = "textBoxSpaceWidthChar";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // checkBoxDrawBorder
            // 
            resources.ApplyResources(this.checkBoxDrawBorder, "checkBoxDrawBorder");
            this.checkBoxDrawBorder.Name = "checkBoxDrawBorder";
            this.checkBoxDrawBorder.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // textBoxFontYOffset
            // 
            resources.ApplyResources(this.textBoxFontYOffset, "textBoxFontYOffset");
            this.textBoxFontYOffset.Name = "textBoxFontYOffset";
            // 
            // txtboxLineSpacing
            // 
            resources.ApplyResources(this.txtboxLineSpacing, "txtboxLineSpacing");
            this.txtboxLineSpacing.Name = "txtboxLineSpacing";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // picboxColor
            // 
            resources.ApplyResources(this.picboxColor, "picboxColor");
            this.picboxColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picboxColor.Name = "picboxColor";
            this.picboxColor.TabStop = false;
            // 
            // btnChooseColor
            // 
            resources.ApplyResources(this.btnChooseColor, "btnChooseColor");
            this.btnChooseColor.Name = "btnChooseColor";
            this.btnChooseColor.UseVisualStyleBackColor = true;
            this.btnChooseColor.Click += new System.EventHandler(this.btnChooseColor_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // comboxType
            // 
            resources.ApplyResources(this.comboxType, "comboxType");
            this.comboxType.FormattingEnabled = true;
            this.comboxType.Items.AddRange(new object[] {
            resources.GetString("comboxType.Items"),
            resources.GetString("comboxType.Items1")});
            this.comboxType.Name = "comboxType";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txtboxX
            // 
            resources.ApplyResources(this.txtboxX, "txtboxX");
            this.txtboxX.Name = "txtboxX";
            // 
            // txtboxY
            // 
            resources.ApplyResources(this.txtboxY, "txtboxY");
            this.txtboxY.Name = "txtboxY";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnPreviewImage);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
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
        private System.Windows.Forms.TextBox textBoxSpaceWidthChar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnView;
    }
}
