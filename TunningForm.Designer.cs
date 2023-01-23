namespace CalcZeroIII
{
    partial class TunningForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.screenImg = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.applyBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.minTalblockTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.LockBtn = new System.Windows.Forms.Button();
            this.ParamListBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tesseractTextBox = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rightBtn = new System.Windows.Forms.Button();
            this.leftBtn = new System.Windows.Forms.Button();
            this.downBtn = new System.Windows.Forms.Button();
            this.upBtn = new System.Windows.Forms.Button();
            this.heightUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.widthUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.VbtLengthTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.screenImg)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heightUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(594, 271);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.screenImg);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 217);
            this.panel1.TabIndex = 4;
            // 
            // screenImg
            // 
            this.screenImg.Cursor = System.Windows.Forms.Cursors.Default;
            this.screenImg.Location = new System.Drawing.Point(0, 0);
            this.screenImg.Name = "screenImg";
            this.screenImg.Size = new System.Drawing.Size(259, 173);
            this.screenImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.screenImg.TabIndex = 0;
            this.screenImg.TabStop = false;
            this.screenImg.Paint += new System.Windows.Forms.PaintEventHandler(this.ScreenImg_Paint);
            this.screenImg.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ScreenImg_MouseDown);
            this.screenImg.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ScreenImg_MouseMove);
            this.screenImg.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ScreenImg_MouseUp);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.applyBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(397, 226);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(194, 42);
            this.panel2.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(106, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // applyBtn
            // 
            this.applyBtn.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.applyBtn.Location = new System.Drawing.Point(16, 9);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(75, 23);
            this.applyBtn.TabIndex = 3;
            this.applyBtn.Text = "Принять";
            this.applyBtn.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(397, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(194, 217);
            this.panel3.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.VbtLengthTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.minTalblockTextBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.LockBtn);
            this.groupBox2.Controls.Add(this.ParamListBox);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox2.Size = new System.Drawing.Size(194, 130);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " Исходные параметры ";
            // 
            // minTalblockTextBox
            // 
            this.minTalblockTextBox.Location = new System.Drawing.Point(143, 70);
            this.minTalblockTextBox.Name = "minTalblockTextBox";
            this.minTalblockTextBox.Size = new System.Drawing.Size(47, 22);
            this.minTalblockTextBox.TabIndex = 9;
            this.minTalblockTextBox.TextChanged += new System.EventHandler(this.MinTalblockTextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Нижняя точка тальблока";
            // 
            // LockBtn
            // 
            this.LockBtn.Location = new System.Drawing.Point(135, 19);
            this.LockBtn.Name = "LockBtn";
            this.LockBtn.Size = new System.Drawing.Size(56, 44);
            this.LockBtn.TabIndex = 1;
            this.LockBtn.Text = "Задать";
            this.LockBtn.UseVisualStyleBackColor = true;
            this.LockBtn.Click += new System.EventHandler(this.LockBtn_Click);
            // 
            // ParamListBox
            // 
            this.ParamListBox.FormattingEnabled = true;
            this.ParamListBox.Items.AddRange(new object[] {
            "Глубина забоя",
            "Пол.дол. по св.",
            "Тальблок"});
            this.ParamListBox.Location = new System.Drawing.Point(5, 20);
            this.ParamListBox.Name = "ParamListBox";
            this.ParamListBox.Size = new System.Drawing.Size(127, 43);
            this.ParamListBox.TabIndex = 0;
            this.ParamListBox.SelectedIndexChanged += new System.EventHandler(this.ParamListBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.tesseractTextBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 84);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Область распознавания  ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Распознаный текст";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 38);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // tesseractTextBox
            // 
            this.tesseractTextBox.Location = new System.Drawing.Point(118, 57);
            this.tesseractTextBox.Name = "tesseractTextBox";
            this.tesseractTextBox.ReadOnly = true;
            this.tesseractTextBox.Size = new System.Drawing.Size(72, 22);
            this.tesseractTextBox.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rightBtn);
            this.panel4.Controls.Add(this.leftBtn);
            this.panel4.Controls.Add(this.downBtn);
            this.panel4.Controls.Add(this.upBtn);
            this.panel4.Controls.Add(this.heightUpDown);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.widthUpDown);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 226);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(388, 42);
            this.panel4.TabIndex = 7;
            // 
            // rightBtn
            // 
            this.rightBtn.Image = global::CalcZeroIII.Properties.Resources.Forward;
            this.rightBtn.Location = new System.Drawing.Point(335, 4);
            this.rightBtn.Name = "rightBtn";
            this.rightBtn.Size = new System.Drawing.Size(34, 34);
            this.rightBtn.TabIndex = 7;
            this.rightBtn.UseVisualStyleBackColor = true;
            this.rightBtn.Click += new System.EventHandler(this.RightBtn_Click);
            // 
            // leftBtn
            // 
            this.leftBtn.Image = global::CalcZeroIII.Properties.Resources.Back;
            this.leftBtn.Location = new System.Drawing.Point(300, 4);
            this.leftBtn.Name = "leftBtn";
            this.leftBtn.Size = new System.Drawing.Size(34, 34);
            this.leftBtn.TabIndex = 6;
            this.leftBtn.UseVisualStyleBackColor = true;
            this.leftBtn.Click += new System.EventHandler(this.LeftBtn_Click);
            // 
            // downBtn
            // 
            this.downBtn.Image = global::CalcZeroIII.Properties.Resources.Down;
            this.downBtn.Location = new System.Drawing.Point(265, 4);
            this.downBtn.Name = "downBtn";
            this.downBtn.Size = new System.Drawing.Size(34, 34);
            this.downBtn.TabIndex = 5;
            this.downBtn.UseVisualStyleBackColor = true;
            this.downBtn.Click += new System.EventHandler(this.DownBtn_Click);
            // 
            // upBtn
            // 
            this.upBtn.Image = global::CalcZeroIII.Properties.Resources.Up;
            this.upBtn.Location = new System.Drawing.Point(230, 4);
            this.upBtn.Name = "upBtn";
            this.upBtn.Size = new System.Drawing.Size(34, 34);
            this.upBtn.TabIndex = 4;
            this.upBtn.UseVisualStyleBackColor = true;
            this.upBtn.Click += new System.EventHandler(this.UpBtn_Click);
            // 
            // heightUpDown
            // 
            this.heightUpDown.Location = new System.Drawing.Point(150, 7);
            this.heightUpDown.Name = "heightUpDown";
            this.heightUpDown.Size = new System.Drawing.Size(37, 22);
            this.heightUpDown.TabIndex = 3;
            this.heightUpDown.ValueChanged += new System.EventHandler(this.HeightUpDown_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Высота";
            // 
            // widthUpDown
            // 
            this.widthUpDown.Location = new System.Drawing.Point(58, 7);
            this.widthUpDown.Name = "widthUpDown";
            this.widthUpDown.Size = new System.Drawing.Size(37, 22);
            this.widthUpDown.TabIndex = 1;
            this.widthUpDown.ValueChanged += new System.EventHandler(this.WidthUpDown_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ширина";
            // 
            // VbtLengthTextBox
            // 
            this.VbtLengthTextBox.Location = new System.Drawing.Point(143, 99);
            this.VbtLengthTextBox.Name = "VbtLengthTextBox";
            this.VbtLengthTextBox.Size = new System.Drawing.Size(47, 22);
            this.VbtLengthTextBox.TabIndex = 11;
            this.VbtLengthTextBox.TextChanged += new System.EventHandler(this.VbtLengthTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Длина квадрата";
            // 
            // TunningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 271);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(610, 310);
            this.Name = "TunningForm";
            this.Text = "Настройка исходных параметров";
            this.Load += new System.EventHandler(this.TunningForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.screenImg)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heightUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox screenImg;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button applyBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button upBtn;
        private System.Windows.Forms.NumericUpDown heightUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown widthUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button rightBtn;
        private System.Windows.Forms.Button leftBtn;
        private System.Windows.Forms.Button downBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button LockBtn;
        private System.Windows.Forms.ListBox ParamListBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tesseractTextBox;
        private System.Windows.Forms.TextBox minTalblockTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox VbtLengthTextBox;
        private System.Windows.Forms.Label label3;
    }
}