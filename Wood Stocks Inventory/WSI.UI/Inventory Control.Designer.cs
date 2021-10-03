
namespace Wood_Stocks_Inventory
{
    partial class InventoryControl
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
            this.ImportButton = new System.Windows.Forms.Button();
            this.ExportButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripFile = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userManualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quickStartGuideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.skillageItToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.importToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.exportToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.userManualToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.quickStartGuideToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.QuickStartPictureBox = new System.Windows.Forms.PictureBox();
            this.SkillageITPictureBox = new System.Windows.Forms.PictureBox();
            this.stockItemDataGridView = new System.Windows.Forms.DataGridView();
            this.skillageitLinkLabel = new System.Windows.Forms.LinkLabel();
            this.quickStartGuideLabel = new System.Windows.Forms.Label();
            this.exportFileTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.xmlRadioButton = new System.Windows.Forms.RadioButton();
            this.csvRadioButton = new System.Windows.Forms.RadioButton();
            this.xmlStyleComboBox = new System.Windows.Forms.ComboBox();
            this.cSVReaderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuickStartPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SkillageITPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockItemDataGridView)).BeginInit();
            this.exportFileTypeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cSVReaderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ImportButton
            // 
            this.ImportButton.Location = new System.Drawing.Point(15, 63);
            this.ImportButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(85, 46);
            this.ImportButton.TabIndex = 0;
            this.ImportButton.Text = "Import CSV";
            this.ImportButton.UseVisualStyleBackColor = true;
            this.ImportButton.Click += new System.EventHandler(this.ImportButton_Click);
            // 
            // ExportButton
            // 
            this.ExportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExportButton.Enabled = false;
            this.ExportButton.Location = new System.Drawing.Point(772, 63);
            this.ExportButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(85, 46);
            this.ExportButton.TabIndex = 1;
            this.ExportButton.Text = "Export CSV";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripFile,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(873, 30);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripFile
            // 
            this.toolStripFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.toolStripMenuItem2,
            this.quitToolStripMenuItem});
            this.toolStripFile.Name = "toolStripFile";
            this.toolStripFile.Size = new System.Drawing.Size(46, 26);
            this.toolStripFile.Text = "&File";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Image = global::Wood_Stocks_Inventory.Properties.Resources.ImportFile_16x;
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.importToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.importToolStripMenuItem.Text = "&Import CSV";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.ImportButton_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Enabled = false;
            this.exportToolStripMenuItem.Image = global::Wood_Stocks_Inventory.Properties.Resources.ExportFile_16x;
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exportToolStripMenuItem.Text = "&Export CSV";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(221, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Image = global::Wood_Stocks_Inventory.Properties.Resources.Exit_16x;
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.quitToolStripMenuItem.Text = "&Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userManualToolStripMenuItem,
            this.quickStartGuideToolStripMenuItem,
            this.toolStripMenuItem1,
            this.skillageItToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 26);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // userManualToolStripMenuItem
            // 
            this.userManualToolStripMenuItem.Image = global::Wood_Stocks_Inventory.Properties.Resources.InformationSymbol_16x;
            this.userManualToolStripMenuItem.Name = "userManualToolStripMenuItem";
            this.userManualToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.userManualToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.userManualToolStripMenuItem.Text = "&User Manual";
            this.userManualToolStripMenuItem.Click += new System.EventHandler(this.userManualToolStripButton_Click);
            // 
            // quickStartGuideToolStripMenuItem
            // 
            this.quickStartGuideToolStripMenuItem.Image = global::Wood_Stocks_Inventory.Properties.Resources.Question_16x;
            this.quickStartGuideToolStripMenuItem.Name = "quickStartGuideToolStripMenuItem";
            this.quickStartGuideToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F9;
            this.quickStartGuideToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.quickStartGuideToolStripMenuItem.Text = "&Quick Start Guide";
            this.quickStartGuideToolStripMenuItem.Click += new System.EventHandler(this.QuickStartPictureBox_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(228, 6);
            // 
            // skillageItToolStripMenuItem
            // 
            this.skillageItToolStripMenuItem.Name = "skillageItToolStripMenuItem";
            this.skillageItToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.skillageItToolStripMenuItem.Text = "&SkillageIT Website";
            this.skillageItToolStripMenuItem.Click += new System.EventHandler(this.SkillageITPictureBox_Click_1);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripButton,
            this.exportToolStripButton,
            this.toolStripSeparator1,
            this.userManualToolStripButton,
            this.quickStartGuideToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 30);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(873, 31);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // importToolStripButton
            // 
            this.importToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.importToolStripButton.Image = global::Wood_Stocks_Inventory.Properties.Resources.ImportFile_16x;
            this.importToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.importToolStripButton.Name = "importToolStripButton";
            this.importToolStripButton.Size = new System.Drawing.Size(29, 28);
            this.importToolStripButton.Text = "toolStripButton1";
            this.importToolStripButton.ToolTipText = "Import CSV";
            this.importToolStripButton.Click += new System.EventHandler(this.ImportButton_Click);
            // 
            // exportToolStripButton
            // 
            this.exportToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.exportToolStripButton.Enabled = false;
            this.exportToolStripButton.Image = global::Wood_Stocks_Inventory.Properties.Resources.ExportFile_16x;
            this.exportToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exportToolStripButton.Name = "exportToolStripButton";
            this.exportToolStripButton.Size = new System.Drawing.Size(29, 28);
            this.exportToolStripButton.Text = "exportToolStripButton";
            this.exportToolStripButton.ToolTipText = "Export CSV";
            this.exportToolStripButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // userManualToolStripButton
            // 
            this.userManualToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.userManualToolStripButton.Image = global::Wood_Stocks_Inventory.Properties.Resources.InformationSymbol_16x;
            this.userManualToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.userManualToolStripButton.Name = "userManualToolStripButton";
            this.userManualToolStripButton.Size = new System.Drawing.Size(29, 28);
            this.userManualToolStripButton.Text = "User Manual";
            this.userManualToolStripButton.Click += new System.EventHandler(this.userManualToolStripButton_Click);
            // 
            // quickStartGuideToolStripButton
            // 
            this.quickStartGuideToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.quickStartGuideToolStripButton.Image = global::Wood_Stocks_Inventory.Properties.Resources.Question_16x;
            this.quickStartGuideToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.quickStartGuideToolStripButton.Name = "quickStartGuideToolStripButton";
            this.quickStartGuideToolStripButton.Size = new System.Drawing.Size(29, 28);
            this.quickStartGuideToolStripButton.Text = "quickStartGuideToolStripButton";
            this.quickStartGuideToolStripButton.ToolTipText = "Quick Start Guide";
            this.quickStartGuideToolStripButton.Click += new System.EventHandler(this.QuickStartPictureBox_Click);
            // 
            // QuickStartPictureBox
            // 
            this.QuickStartPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.QuickStartPictureBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.QuickStartPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.QuickStartPictureBox.Image = global::Wood_Stocks_Inventory.Properties.Resources.QuickStartIcon;
            this.QuickStartPictureBox.Location = new System.Drawing.Point(15, 618);
            this.QuickStartPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.QuickStartPictureBox.Name = "QuickStartPictureBox";
            this.QuickStartPictureBox.Size = new System.Drawing.Size(44, 46);
            this.QuickStartPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.QuickStartPictureBox.TabIndex = 4;
            this.QuickStartPictureBox.TabStop = false;
            this.QuickStartPictureBox.Click += new System.EventHandler(this.QuickStartPictureBox_Click);
            // 
            // SkillageITPictureBox
            // 
            this.SkillageITPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SkillageITPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SkillageITPictureBox.Image = global::Wood_Stocks_Inventory.Properties.Resources.skillage_it_small_logo;
            this.SkillageITPictureBox.Location = new System.Drawing.Point(812, 618);
            this.SkillageITPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SkillageITPictureBox.Name = "SkillageITPictureBox";
            this.SkillageITPictureBox.Size = new System.Drawing.Size(45, 46);
            this.SkillageITPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SkillageITPictureBox.TabIndex = 3;
            this.SkillageITPictureBox.TabStop = false;
            this.SkillageITPictureBox.Click += new System.EventHandler(this.SkillageITPictureBox_Click_1);
            // 
            // stockItemDataGridView
            // 
            this.stockItemDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stockItemDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.stockItemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockItemDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.stockItemDataGridView.Location = new System.Drawing.Point(16, 128);
            this.stockItemDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.stockItemDataGridView.MultiSelect = false;
            this.stockItemDataGridView.Name = "stockItemDataGridView";
            this.stockItemDataGridView.RowHeadersWidth = 51;
            this.stockItemDataGridView.Size = new System.Drawing.Size(841, 484);
            this.stockItemDataGridView.TabIndex = 6;
            this.stockItemDataGridView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.stockItemDataGridView_CellBeginEdit);
            this.stockItemDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.stockItemDataGridView_CellEndEdit);
            this.stockItemDataGridView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.stockItemDataGridView_ColumnHeaderMouseClick);
            this.stockItemDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.stockItemDataGridView_DataBindingComplete);
            this.stockItemDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.stockItemDataGridView_DataError_1);
            // 
            // skillageitLinkLabel
            // 
            this.skillageitLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.skillageitLinkLabel.AutoSize = true;
            this.skillageitLinkLabel.Location = new System.Drawing.Point(789, 663);
            this.skillageitLinkLabel.Name = "skillageitLinkLabel";
            this.skillageitLinkLabel.Size = new System.Drawing.Size(69, 17);
            this.skillageitLinkLabel.TabIndex = 7;
            this.skillageitLinkLabel.TabStop = true;
            this.skillageitLinkLabel.Text = "SkillageIT";
            this.skillageitLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.skillageitLinkLabel_LinkClicked);
            // 
            // quickStartGuideLabel
            // 
            this.quickStartGuideLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.quickStartGuideLabel.AutoSize = true;
            this.quickStartGuideLabel.Location = new System.Drawing.Point(13, 663);
            this.quickStartGuideLabel.Name = "quickStartGuideLabel";
            this.quickStartGuideLabel.Size = new System.Drawing.Size(120, 17);
            this.quickStartGuideLabel.TabIndex = 8;
            this.quickStartGuideLabel.Text = "Quick Start Guide";
            // 
            // exportFileTypeGroupBox
            // 
            this.exportFileTypeGroupBox.Controls.Add(this.xmlRadioButton);
            this.exportFileTypeGroupBox.Controls.Add(this.csvRadioButton);
            this.exportFileTypeGroupBox.Enabled = false;
            this.exportFileTypeGroupBox.Location = new System.Drawing.Point(619, 39);
            this.exportFileTypeGroupBox.Name = "exportFileTypeGroupBox";
            this.exportFileTypeGroupBox.Size = new System.Drawing.Size(147, 52);
            this.exportFileTypeGroupBox.TabIndex = 9;
            this.exportFileTypeGroupBox.TabStop = false;
            this.exportFileTypeGroupBox.Text = "Export As:";
            // 
            // xmlRadioButton
            // 
            this.xmlRadioButton.AutoSize = true;
            this.xmlRadioButton.Location = new System.Drawing.Point(81, 22);
            this.xmlRadioButton.Name = "xmlRadioButton";
            this.xmlRadioButton.Size = new System.Drawing.Size(57, 21);
            this.xmlRadioButton.TabIndex = 1;
            this.xmlRadioButton.TabStop = true;
            this.xmlRadioButton.Text = "XML";
            this.xmlRadioButton.UseVisualStyleBackColor = true;
            this.xmlRadioButton.CheckedChanged += new System.EventHandler(this.xmlRadioButton_CheckedChanged);
            // 
            // csvRadioButton
            // 
            this.csvRadioButton.AutoSize = true;
            this.csvRadioButton.Location = new System.Drawing.Point(7, 22);
            this.csvRadioButton.Name = "csvRadioButton";
            this.csvRadioButton.Size = new System.Drawing.Size(56, 21);
            this.csvRadioButton.TabIndex = 0;
            this.csvRadioButton.TabStop = true;
            this.csvRadioButton.Text = "CSV";
            this.csvRadioButton.UseVisualStyleBackColor = true;
            this.csvRadioButton.CheckedChanged += new System.EventHandler(this.csvRadioButton_CheckedChanged);
            // 
            // xmlStyleComboBox
            // 
            this.xmlStyleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.xmlStyleComboBox.Enabled = false;
            this.xmlStyleComboBox.FormattingEnabled = true;
            this.xmlStyleComboBox.Location = new System.Drawing.Point(619, 97);
            this.xmlStyleComboBox.Name = "xmlStyleComboBox";
            this.xmlStyleComboBox.Size = new System.Drawing.Size(147, 24);
            this.xmlStyleComboBox.TabIndex = 10;
            this.xmlStyleComboBox.SelectionChangeCommitted += new System.EventHandler(this.xmlStyleComboBox_SelectionChangeCommitted);
            // 
            // cSVReaderBindingSource
            // 
            this.cSVReaderBindingSource.DataSource = typeof(Wood_Stocks_Inventory.CSVConverter);
            // 
            // InventoryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 693);
            this.Controls.Add(this.xmlStyleComboBox);
            this.Controls.Add(this.exportFileTypeGroupBox);
            this.Controls.Add(this.quickStartGuideLabel);
            this.Controls.Add(this.skillageitLinkLabel);
            this.Controls.Add(this.stockItemDataGridView);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.QuickStartPictureBox);
            this.Controls.Add(this.SkillageITPictureBox);
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.ImportButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(661, 605);
            this.Name = "InventoryControl";
            this.Text = "Wood Stocks Inventory Control";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InventoryControl_Closing);
            this.Load += new System.EventHandler(this.InventoryControl_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuickStartPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SkillageITPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockItemDataGridView)).EndInit();
            this.exportFileTypeGroupBox.ResumeLayout(false);
            this.exportFileTypeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cSVReaderBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ImportButton;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox SkillageITPictureBox;
        private System.Windows.Forms.PictureBox QuickStartPictureBox;
        private System.Windows.Forms.ToolStripMenuItem toolStripFile;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quickStartGuideToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem skillageItToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton importToolStripButton;
        private System.Windows.Forms.ToolStripButton exportToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridView stockItemDataGridView;
        private System.Windows.Forms.BindingSource cSVReaderBindingSource;
        private System.Windows.Forms.LinkLabel skillageitLinkLabel;
        private System.Windows.Forms.Label quickStartGuideLabel;
        private System.Windows.Forms.ToolStripButton userManualToolStripButton;
        private System.Windows.Forms.ToolStripButton quickStartGuideToolStripButton;
        private System.Windows.Forms.GroupBox exportFileTypeGroupBox;
        private System.Windows.Forms.RadioButton xmlRadioButton;
        private System.Windows.Forms.RadioButton csvRadioButton;
        private System.Windows.Forms.ComboBox xmlStyleComboBox;
    }
}

