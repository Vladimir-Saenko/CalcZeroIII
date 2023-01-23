namespace CalcZeroIII
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.fileMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tunning_fileMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.about_fileMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exit_fileMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mainLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.MinTalblockTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.OnDepthTextBox = new System.Windows.Forms.TextBox();
            this.TalblockTextBox = new System.Windows.Forms.TextBox();
            this.Talblock_0TextBox = new System.Windows.Forms.TextBox();
            this.CalcBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SPOcheckBox = new System.Windows.Forms.CheckBox();
            this.VBTcheckBox = new System.Windows.Forms.CheckBox();
            this.MainMenu.SuspendLayout();
            this.mainLayoutPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMainMenu});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(354, 24);
            this.MainMenu.TabIndex = 5;
            this.MainMenu.Text = "menuStrip1";
            // 
            // fileMainMenu
            // 
            this.fileMainMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tunning_fileMainMenu,
            this.about_fileMainMenu,
            this.toolStripMenuItem1,
            this.exit_fileMainMenu});
            this.fileMainMenu.Name = "fileMainMenu";
            this.fileMainMenu.Size = new System.Drawing.Size(50, 20);
            this.fileMainMenu.Text = "&Файл";
            // 
            // tunning_fileMainMenu
            // 
            this.tunning_fileMainMenu.Name = "tunning_fileMainMenu";
            this.tunning_fileMainMenu.Size = new System.Drawing.Size(157, 22);
            this.tunning_fileMainMenu.Text = "Настройка";
            this.tunning_fileMainMenu.Click += new System.EventHandler(this.Tunning_fileMainMenu_Click);
            // 
            // about_fileMainMenu
            // 
            this.about_fileMainMenu.Name = "about_fileMainMenu";
            this.about_fileMainMenu.Size = new System.Drawing.Size(157, 22);
            this.about_fileMainMenu.Text = "О программе";
            this.about_fileMainMenu.Click += new System.EventHandler(this.About_fileMainMenu_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(154, 6);
            // 
            // exit_fileMainMenu
            // 
            this.exit_fileMainMenu.Name = "exit_fileMainMenu";
            this.exit_fileMainMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exit_fileMainMenu.Size = new System.Drawing.Size(157, 22);
            this.exit_fileMainMenu.Text = "Выход";
            this.exit_fileMainMenu.Click += new System.EventHandler(this.Exit_fileMainMenu_Click);
            // 
            // mainLayoutPanel
            // 
            this.mainLayoutPanel.ColumnCount = 3;
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 190F));
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.mainLayoutPanel.Controls.Add(this.label4, 0, 3);
            this.mainLayoutPanel.Controls.Add(this.MinTalblockTextBox, 0, 3);
            this.mainLayoutPanel.Controls.Add(this.label1, 0, 0);
            this.mainLayoutPanel.Controls.Add(this.label2, 0, 1);
            this.mainLayoutPanel.Controls.Add(this.label3, 0, 2);
            this.mainLayoutPanel.Controls.Add(this.OnDepthTextBox, 1, 0);
            this.mainLayoutPanel.Controls.Add(this.TalblockTextBox, 1, 1);
            this.mainLayoutPanel.Controls.Add(this.Talblock_0TextBox, 1, 2);
            this.mainLayoutPanel.Controls.Add(this.CalcBtn, 2, 2);
            this.mainLayoutPanel.Controls.Add(this.panel1, 2, 0);
            this.mainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayoutPanel.Location = new System.Drawing.Point(0, 24);
            this.mainLayoutPanel.Name = "mainLayoutPanel";
            this.mainLayoutPanel.RowCount = 4;
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainLayoutPanel.Size = new System.Drawing.Size(354, 101);
            this.mainLayoutPanel.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 78);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(2);
            this.label4.Size = new System.Drawing.Size(184, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Нижняя точка тальблока";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MinTalblockTextBox
            // 
            this.MinTalblockTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MinTalblockTextBox.Location = new System.Drawing.Point(192, 77);
            this.MinTalblockTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.MinTalblockTextBox.Name = "MinTalblockTextBox";
            this.MinTalblockTextBox.ReadOnly = true;
            this.MinTalblockTextBox.Size = new System.Drawing.Size(75, 22);
            this.MinTalblockTextBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(2);
            this.label1.Size = new System.Drawing.Size(184, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Над забоем";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(2);
            this.label2.Size = new System.Drawing.Size(184, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Положение тальблока";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(2);
            this.label3.Size = new System.Drawing.Size(184, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Положение тальблока на забое";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // OnDepthTextBox
            // 
            this.OnDepthTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OnDepthTextBox.Location = new System.Drawing.Point(192, 2);
            this.OnDepthTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.OnDepthTextBox.Name = "OnDepthTextBox";
            this.OnDepthTextBox.Size = new System.Drawing.Size(75, 22);
            this.OnDepthTextBox.TabIndex = 3;
            // 
            // TalblockTextBox
            // 
            this.TalblockTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TalblockTextBox.Location = new System.Drawing.Point(192, 27);
            this.TalblockTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.TalblockTextBox.Name = "TalblockTextBox";
            this.TalblockTextBox.ReadOnly = true;
            this.TalblockTextBox.Size = new System.Drawing.Size(75, 22);
            this.TalblockTextBox.TabIndex = 4;
            // 
            // Talblock_0TextBox
            // 
            this.Talblock_0TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Talblock_0TextBox.Location = new System.Drawing.Point(192, 52);
            this.Talblock_0TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.Talblock_0TextBox.Name = "Talblock_0TextBox";
            this.Talblock_0TextBox.ReadOnly = true;
            this.Talblock_0TextBox.Size = new System.Drawing.Size(75, 22);
            this.Talblock_0TextBox.TabIndex = 5;
            this.Talblock_0TextBox.Text = "Нет данных";
            // 
            // CalcBtn
            // 
            this.CalcBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CalcBtn.Image = global::CalcZeroIII.Properties.Resources.Calculator;
            this.CalcBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CalcBtn.Location = new System.Drawing.Point(270, 51);
            this.CalcBtn.Margin = new System.Windows.Forms.Padding(1, 1, 3, 1);
            this.CalcBtn.Name = "CalcBtn";
            this.CalcBtn.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.mainLayoutPanel.SetRowSpan(this.CalcBtn, 2);
            this.CalcBtn.Size = new System.Drawing.Size(81, 49);
            this.CalcBtn.TabIndex = 6;
            this.CalcBtn.Text = "Расчет";
            this.CalcBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CalcBtn.UseVisualStyleBackColor = true;
            this.CalcBtn.Click += new System.EventHandler(this.CalcBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.SPOcheckBox);
            this.panel1.Controls.Add(this.VBTcheckBox);
            this.panel1.Location = new System.Drawing.Point(271, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.panel1.Name = "panel1";
            this.mainLayoutPanel.SetRowSpan(this.panel1, 2);
            this.panel1.Size = new System.Drawing.Size(79, 45);
            this.panel1.TabIndex = 9;
            // 
            // SPOcheckBox
            // 
            this.SPOcheckBox.AutoSize = true;
            this.SPOcheckBox.Location = new System.Drawing.Point(2, 4);
            this.SPOcheckBox.Name = "SPOcheckBox";
            this.SPOcheckBox.Size = new System.Drawing.Size(49, 17);
            this.SPOcheckBox.TabIndex = 11;
            this.SPOcheckBox.Text = "СПО";
            this.SPOcheckBox.UseVisualStyleBackColor = true;
            this.SPOcheckBox.CheckedChanged += new System.EventHandler(this.SPOcheckBox_CheckedChanged);
            // 
            // VBTcheckBox
            // 
            this.VBTcheckBox.AutoSize = true;
            this.VBTcheckBox.Location = new System.Drawing.Point(2, 23);
            this.VBTcheckBox.Name = "VBTcheckBox";
            this.VBTcheckBox.Size = new System.Drawing.Size(73, 17);
            this.VBTcheckBox.TabIndex = 12;
            this.VBTcheckBox.Text = "-Квадрат";
            this.VBTcheckBox.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 125);
            this.Controls.Add(this.mainLayoutPanel);
            this.Controls.Add(this.MainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MainMenuStrip = this.MainMenu;
            this.MaximumSize = new System.Drawing.Size(450, 180);
            this.MinimumSize = new System.Drawing.Size(370, 164);
            this.Name = "MainForm";
            this.Text = "CalcZeroIII";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.mainLayoutPanel.ResumeLayout(false);
            this.mainLayoutPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileMainMenu;
        private System.Windows.Forms.ToolStripMenuItem tunning_fileMainMenu;
        private System.Windows.Forms.ToolStripMenuItem about_fileMainMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exit_fileMainMenu;
        private System.Windows.Forms.TableLayoutPanel mainLayoutPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox OnDepthTextBox;
        private System.Windows.Forms.TextBox TalblockTextBox;
        private System.Windows.Forms.TextBox Talblock_0TextBox;
        private System.Windows.Forms.Button CalcBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MinTalblockTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox SPOcheckBox;
        private System.Windows.Forms.CheckBox VBTcheckBox;
    }
}

