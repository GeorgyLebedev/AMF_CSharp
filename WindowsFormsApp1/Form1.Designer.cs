namespace WindowsFormsApp1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jpgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputPictureBox = new System.Windows.Forms.PictureBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.filterBtn = new System.Windows.Forms.Button();
            this.minBrightness = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button11x11 = new System.Windows.Forms.Button();
            this.button5x5 = new System.Windows.Forms.Button();
            this.button7x7 = new System.Windows.Forms.Button();
            this.button9x9 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button13x13 = new System.Windows.Forms.Button();
            this.resetImgBtn = new System.Windows.Forms.Button();
            this.outputPictureBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lineLengthInput = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.elapsedLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minBrightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outputPictureBox)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lineLengthInput)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(924, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.openImageClick);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jpgToolStripMenuItem,
            this.pngToolStripMenuItem});
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как...";
            // 
            // jpgToolStripMenuItem
            // 
            this.jpgToolStripMenuItem.Name = "jpgToolStripMenuItem";
            this.jpgToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.jpgToolStripMenuItem.Text = ".jpg";
            // 
            // pngToolStripMenuItem
            // 
            this.pngToolStripMenuItem.Name = "pngToolStripMenuItem";
            this.pngToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.pngToolStripMenuItem.Text = ".png";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // inputPictureBox
            // 
            this.inputPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputPictureBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.inputPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("inputPictureBox.Image")));
            this.inputPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("inputPictureBox.InitialImage")));
            this.inputPictureBox.Location = new System.Drawing.Point(3, 3);
            this.inputPictureBox.Name = "inputPictureBox";
            this.inputPictureBox.Size = new System.Drawing.Size(380, 478);
            this.inputPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.inputPictureBox.TabIndex = 1;
            this.inputPictureBox.TabStop = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Изображение JPG|*.jpg|Изображение PNG|*.png";
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(12, 517);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(775, 23);
            this.progressBar.TabIndex = 2;
            this.progressBar.Visible = false;
            // 
            // filterBtn
            // 
            this.filterBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filterBtn.Enabled = false;
            this.filterBtn.Location = new System.Drawing.Point(809, 455);
            this.filterBtn.Name = "filterBtn";
            this.filterBtn.Size = new System.Drawing.Size(96, 23);
            this.filterBtn.TabIndex = 3;
            this.filterBtn.Text = "Обработать";
            this.filterBtn.UseVisualStyleBackColor = true;
            this.filterBtn.Click += new System.EventHandler(this.filterBtn_Click);
            // 
            // minBrightness
            // 
            this.minBrightness.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minBrightness.Location = new System.Drawing.Point(809, 46);
            this.minBrightness.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.minBrightness.Name = "minBrightness";
            this.minBrightness.Size = new System.Drawing.Size(96, 20);
            this.minBrightness.TabIndex = 4;
            this.minBrightness.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(806, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Номинальная яркость линии:";
            // 
            // button11x11
            // 
            this.button11x11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button11x11.BackColor = System.Drawing.SystemColors.Control;
            this.button11x11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button11x11.BackgroundImage")));
            this.button11x11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button11x11.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button11x11.FlatAppearance.BorderSize = 0;
            this.button11x11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11x11.Location = new System.Drawing.Point(63, 75);
            this.button11x11.Name = "button11x11";
            this.button11x11.Size = new System.Drawing.Size(50, 50);
            this.button11x11.TabIndex = 9;
            this.toolTip1.SetToolTip(this.button11x11, "11x11");
            this.button11x11.UseVisualStyleBackColor = false;
            this.button11x11.Click += new System.EventHandler(this.setMaskSize);
            // 
            // button5x5
            // 
            this.button5x5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5x5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5x5.BackgroundImage")));
            this.button5x5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5x5.Enabled = false;
            this.button5x5.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button5x5.FlatAppearance.BorderSize = 3;
            this.button5x5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5x5.Location = new System.Drawing.Point(6, 19);
            this.button5x5.Name = "button5x5";
            this.button5x5.Size = new System.Drawing.Size(50, 50);
            this.button5x5.TabIndex = 9;
            this.toolTip1.SetToolTip(this.button5x5, "5x5");
            this.button5x5.UseVisualStyleBackColor = true;
            this.button5x5.Click += new System.EventHandler(this.setMaskSize);
            // 
            // button7x7
            // 
            this.button7x7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button7x7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7x7.BackgroundImage")));
            this.button7x7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button7x7.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button7x7.FlatAppearance.BorderSize = 0;
            this.button7x7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7x7.Location = new System.Drawing.Point(62, 19);
            this.button7x7.Name = "button7x7";
            this.button7x7.Size = new System.Drawing.Size(50, 50);
            this.button7x7.TabIndex = 9;
            this.toolTip1.SetToolTip(this.button7x7, "7x7");
            this.button7x7.UseVisualStyleBackColor = true;
            this.button7x7.Click += new System.EventHandler(this.setMaskSize);
            // 
            // button9x9
            // 
            this.button9x9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button9x9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button9x9.BackgroundImage")));
            this.button9x9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button9x9.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button9x9.FlatAppearance.BorderSize = 0;
            this.button9x9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9x9.Location = new System.Drawing.Point(6, 75);
            this.button9x9.Name = "button9x9";
            this.button9x9.Size = new System.Drawing.Size(50, 50);
            this.button9x9.TabIndex = 9;
            this.toolTip1.SetToolTip(this.button9x9, "9x9");
            this.button9x9.UseVisualStyleBackColor = true;
            this.button9x9.Click += new System.EventHandler(this.setMaskSize);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.button9x9);
            this.groupBox1.Controls.Add(this.button5x5);
            this.groupBox1.Controls.Add(this.button7x7);
            this.groupBox1.Controls.Add(this.button13x13);
            this.groupBox1.Controls.Add(this.button11x11);
            this.groupBox1.Location = new System.Drawing.Point(793, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(119, 313);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип маски: 5 X 5";
            // 
            // button13x13
            // 
            this.button13x13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button13x13.BackColor = System.Drawing.SystemColors.Control;
            this.button13x13.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button13x13.BackgroundImage")));
            this.button13x13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button13x13.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button13x13.FlatAppearance.BorderSize = 0;
            this.button13x13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13x13.Location = new System.Drawing.Point(6, 131);
            this.button13x13.Name = "button13x13";
            this.button13x13.Size = new System.Drawing.Size(50, 50);
            this.button13x13.TabIndex = 9;
            this.toolTip1.SetToolTip(this.button13x13, "13x13");
            this.button13x13.UseVisualStyleBackColor = false;
            this.button13x13.Click += new System.EventHandler(this.setMaskSize);
            // 
            // resetImgBtn
            // 
            this.resetImgBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.resetImgBtn.Location = new System.Drawing.Point(809, 487);
            this.resetImgBtn.Name = "resetImgBtn";
            this.resetImgBtn.Size = new System.Drawing.Size(96, 23);
            this.resetImgBtn.TabIndex = 3;
            this.resetImgBtn.Text = "Сброс";
            this.resetImgBtn.UseVisualStyleBackColor = true;
            this.resetImgBtn.Visible = false;
            this.resetImgBtn.Click += new System.EventHandler(this.resetImgBtn_Click);
            // 
            // outputPictureBox
            // 
            this.outputPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputPictureBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.outputPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("outputPictureBox.Image")));
            this.outputPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("outputPictureBox.InitialImage")));
            this.outputPictureBox.Location = new System.Drawing.Point(389, 3);
            this.outputPictureBox.Name = "outputPictureBox";
            this.outputPictureBox.Size = new System.Drawing.Size(383, 478);
            this.outputPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.outputPictureBox.TabIndex = 1;
            this.outputPictureBox.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.93548F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.06452F));
            this.tableLayoutPanel1.Controls.Add(this.inputPictureBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.outputPictureBox, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(775, 484);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // lineLengthInput
            // 
            this.lineLengthInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lineLengthInput.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.lineLengthInput.Location = new System.Drawing.Point(809, 100);
            this.lineLengthInput.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.lineLengthInput.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.lineLengthInput.Name = "lineLengthInput";
            this.lineLengthInput.Size = new System.Drawing.Size(96, 20);
            this.lineLengthInput.TabIndex = 4;
            this.lineLengthInput.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(808, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Мин. длина линий:";
            this.toolTip1.SetToolTip(this.label2, "Минимальная длина последовательности пикселей, подлежащих замене");
            // 
            // elapsedLabel
            // 
            this.elapsedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.elapsedLabel.AutoSize = true;
            this.elapsedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.elapsedLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.elapsedLabel.Location = new System.Drawing.Point(843, 513);
            this.elapsedLabel.Name = "elapsedLabel";
            this.elapsedLabel.Size = new System.Drawing.Size(23, 13);
            this.elapsedLabel.TabIndex = 5;
            this.elapsedLabel.Text = "    ";
            this.elapsedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 552);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.elapsedLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lineLengthInput);
            this.Controls.Add(this.minBrightness);
            this.Controls.Add(this.resetImgBtn);
            this.Controls.Add(this.filterBtn);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minBrightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.outputPictureBox)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lineLengthInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.PictureBox inputPictureBox;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jpgToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button filterBtn;
        private System.Windows.Forms.NumericUpDown minBrightness;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button button11x11;
        private System.Windows.Forms.Button button5x5;
        private System.Windows.Forms.Button button7x7;
        private System.Windows.Forms.Button button9x9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button resetImgBtn;
        private System.Windows.Forms.PictureBox outputPictureBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.NumericUpDown lineLengthInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label elapsedLabel;
        private System.Windows.Forms.Button button13x13;
    }
}

