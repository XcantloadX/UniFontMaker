namespace UniFontGenterator
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemNew = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemNewMC = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemNewUnitale = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemNewJson = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemNewXml = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemExport = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lableTipNewProj = new System.Windows.Forms.Label();
            this.tabControlFontSettings = new System.Windows.Forms.TabControl();
            this.tabPageMC = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPageUnitale = new System.Windows.Forms.TabPage();
            this.tabPageNormal = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBoxTest = new System.Windows.Forms.PictureBox();
            this.menuStrip.SuspendLayout();
            this.tabControlFontSettings.SuspendLayout();
            this.tabPageMC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTest)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(698, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemNew,
            this.MenuItemSave,
            this.MenuItemExport,
            this.MenuItemExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.fileToolStripMenuItem.Text = "文件";
            // 
            // MenuItemNew
            // 
            this.MenuItemNew.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemNewMC,
            this.MenuItemNewUnitale,
            this.MenuItemNewJson,
            this.MenuItemNewXml});
            this.MenuItemNew.Name = "MenuItemNew";
            this.MenuItemNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.MenuItemNew.Size = new System.Drawing.Size(169, 22);
            this.MenuItemNew.Text = "新建";
            // 
            // MenuItemNewMC
            // 
            this.MenuItemNewMC.Name = "MenuItemNewMC";
            this.MenuItemNewMC.Size = new System.Drawing.Size(186, 22);
            this.MenuItemNewMC.Text = "Minecraft Java 资源包";
            this.MenuItemNewMC.Click += new System.EventHandler(this.MenuItemNewMC_Click);
            // 
            // MenuItemNewUnitale
            // 
            this.MenuItemNewUnitale.Name = "MenuItemNewUnitale";
            this.MenuItemNewUnitale.Size = new System.Drawing.Size(186, 22);
            this.MenuItemNewUnitale.Text = "Unitale 字体";
            // 
            // MenuItemNewJson
            // 
            this.MenuItemNewJson.Enabled = false;
            this.MenuItemNewJson.Name = "MenuItemNewJson";
            this.MenuItemNewJson.Size = new System.Drawing.Size(186, 22);
            this.MenuItemNewJson.Text = "Json 文件";
            // 
            // MenuItemNewXml
            // 
            this.MenuItemNewXml.Enabled = false;
            this.MenuItemNewXml.Name = "MenuItemNewXml";
            this.MenuItemNewXml.Size = new System.Drawing.Size(186, 22);
            this.MenuItemNewXml.Text = "Xml 文件";
            // 
            // MenuItemSave
            // 
            this.MenuItemSave.Enabled = false;
            this.MenuItemSave.Name = "MenuItemSave";
            this.MenuItemSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.MenuItemSave.Size = new System.Drawing.Size(169, 22);
            this.MenuItemSave.Text = "保存";
            // 
            // MenuItemExport
            // 
            this.MenuItemExport.Name = "MenuItemExport";
            this.MenuItemExport.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.S)));
            this.MenuItemExport.Size = new System.Drawing.Size(169, 22);
            this.MenuItemExport.Text = "导出";
            // 
            // MenuItemExit
            // 
            this.MenuItemExit.Name = "MenuItemExit";
            this.MenuItemExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.MenuItemExit.Size = new System.Drawing.Size(169, 22);
            this.MenuItemExit.Text = "退出";
            this.MenuItemExit.Click += new System.EventHandler(this.MenuItemExit_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于ToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.aboutToolStripMenuItem.Text = "帮助";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // lableTipNewProj
            // 
            this.lableTipNewProj.AutoSize = true;
            this.lableTipNewProj.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lableTipNewProj.Location = new System.Drawing.Point(234, 40);
            this.lableTipNewProj.Name = "lableTipNewProj";
            this.lableTipNewProj.Size = new System.Drawing.Size(232, 16);
            this.lableTipNewProj.TabIndex = 2;
            this.lableTipNewProj.Text = "使用 文件->新建 创建一个字体";
            // 
            // tabControlFontSettings
            // 
            this.tabControlFontSettings.Controls.Add(this.tabPageMC);
            this.tabControlFontSettings.Controls.Add(this.tabPageUnitale);
            this.tabControlFontSettings.Controls.Add(this.tabPageNormal);
            this.tabControlFontSettings.Location = new System.Drawing.Point(6, 20);
            this.tabControlFontSettings.Name = "tabControlFontSettings";
            this.tabControlFontSettings.SelectedIndex = 0;
            this.tabControlFontSettings.Size = new System.Drawing.Size(662, 382);
            this.tabControlFontSettings.TabIndex = 3;
            // 
            // tabPageMC
            // 
            this.tabPageMC.Controls.Add(this.comboBox1);
            this.tabPageMC.Controls.Add(this.label3);
            this.tabPageMC.Controls.Add(this.textBox1);
            this.tabPageMC.Controls.Add(this.label2);
            this.tabPageMC.Controls.Add(this.label1);
            this.tabPageMC.Controls.Add(this.pictureBox1);
            this.tabPageMC.Location = new System.Drawing.Point(4, 22);
            this.tabPageMC.Name = "tabPageMC";
            this.tabPageMC.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMC.Size = new System.Drawing.Size(654, 356);
            this.tabPageMC.TabIndex = 0;
            this.tabPageMC.Text = "MC 资源包";
            this.tabPageMC.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(297, 62);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(83, 20);
            this.comboBox1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "Minecraft 版本";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(297, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(238, 21);
            this.textBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "资源包名称";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "资源包图标";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::UniFontGenterator.Properties.Resources.unknown_pack;
            this.pictureBox1.Location = new System.Drawing.Point(19, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tabPageUnitale
            // 
            this.tabPageUnitale.Location = new System.Drawing.Point(4, 22);
            this.tabPageUnitale.Name = "tabPageUnitale";
            this.tabPageUnitale.Size = new System.Drawing.Size(654, 356);
            this.tabPageUnitale.TabIndex = 1;
            this.tabPageUnitale.Text = "Unitale";
            this.tabPageUnitale.UseVisualStyleBackColor = true;
            // 
            // tabPageNormal
            // 
            this.tabPageNormal.Location = new System.Drawing.Point(4, 22);
            this.tabPageNormal.Name = "tabPageNormal";
            this.tabPageNormal.Size = new System.Drawing.Size(654, 356);
            this.tabPageNormal.TabIndex = 2;
            this.tabPageNormal.Text = "普通";
            this.tabPageNormal.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.tabControlFontSettings);
            this.groupBox1.Location = new System.Drawing.Point(12, 209);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(674, 278);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "设置";
            // 
            // pictureBoxTest
            // 
            this.pictureBoxTest.BackColor = System.Drawing.Color.White;
            this.pictureBoxTest.Location = new System.Drawing.Point(0, 79);
            this.pictureBoxTest.Name = "pictureBoxTest";
            this.pictureBoxTest.Size = new System.Drawing.Size(698, 60);
            this.pictureBoxTest.TabIndex = 5;
            this.pictureBoxTest.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 499);
            this.Controls.Add(this.pictureBoxTest);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lableTipNewProj);
            this.Controls.Add(this.menuStrip);
            this.Name = "MainForm";
            this.Text = "UniFont Genterator";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tabControlFontSettings.ResumeLayout(false);
            this.tabPageMC.ResumeLayout(false);
            this.tabPageMC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemNew;
        private System.Windows.Forms.ToolStripMenuItem MenuItemNewMC;
        private System.Windows.Forms.ToolStripMenuItem MenuItemNewUnitale;
        private System.Windows.Forms.ToolStripMenuItem MenuItemNewJson;
        private System.Windows.Forms.ToolStripMenuItem MenuItemNewXml;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSave;
        private System.Windows.Forms.ToolStripMenuItem MenuItemExport;
        private System.Windows.Forms.ToolStripMenuItem MenuItemExit;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label lableTipNewProj;
        private System.Windows.Forms.TabControl tabControlFontSettings;
        private System.Windows.Forms.TabPage tabPageMC;
        private System.Windows.Forms.TabPage tabPageUnitale;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPageNormal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBoxTest;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
    }
}

