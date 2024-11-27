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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.minBrightness = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.lineLengthInput = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.elapsedLabel = new System.Windows.Forms.Label();
            this.filterBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.ownSizeRadio = new Guna.UI2.WinForms.Guna2Button();
            this.preSizeRadio = new Guna.UI2.WinForms.Guna2Button();
            this.maskSizeTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.maskSizeComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.progressBar = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.inputPictureBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minBrightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineLengthInput)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputPictureBox)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1036, 24);
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
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Изображение JPG|*.jpg|Изображение PNG|*.png";
            // 
            // minBrightness
            // 
            this.minBrightness.BackColor = System.Drawing.Color.Transparent;
            this.minBrightness.BorderColor = System.Drawing.Color.Gray;
            this.minBrightness.BorderRadius = 10;
            this.minBrightness.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.minBrightness.FocusedState.BorderColor = System.Drawing.Color.RoyalBlue;
            this.minBrightness.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minBrightness.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.minBrightness.Location = new System.Drawing.Point(162, 60);
            this.minBrightness.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.minBrightness.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.minBrightness.Name = "minBrightness";
            this.minBrightness.Size = new System.Drawing.Size(76, 30);
            this.minBrightness.TabIndex = 1;
            this.minBrightness.UpDownButtonFillColor = System.Drawing.Color.Silver;
            this.minBrightness.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.minBrightness.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // lineLengthInput
            // 
            this.lineLengthInput.BackColor = System.Drawing.Color.Transparent;
            this.lineLengthInput.BorderColor = System.Drawing.Color.Gray;
            this.lineLengthInput.BorderRadius = 10;
            this.lineLengthInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lineLengthInput.FocusedState.BorderColor = System.Drawing.Color.RoyalBlue;
            this.lineLengthInput.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lineLengthInput.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.lineLengthInput.Location = new System.Drawing.Point(162, 24);
            this.lineLengthInput.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.lineLengthInput.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.lineLengthInput.Name = "lineLengthInput";
            this.lineLengthInput.Size = new System.Drawing.Size(76, 30);
            this.lineLengthInput.TabIndex = 1;
            this.lineLengthInput.UpDownButtonFillColor = System.Drawing.Color.Silver;
            this.lineLengthInput.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lineLengthInput.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // elapsedLabel
            // 
            this.elapsedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.elapsedLabel.AutoSize = true;
            this.elapsedLabel.BackColor = System.Drawing.Color.Transparent;
            this.elapsedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.elapsedLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.elapsedLabel.Location = new System.Drawing.Point(919, 74);
            this.elapsedLabel.Name = "elapsedLabel";
            this.elapsedLabel.Size = new System.Drawing.Size(103, 13);
            this.elapsedLabel.TabIndex = 5;
            this.elapsedLabel.Text = "                        ";
            this.elapsedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // filterBtn
            // 
            this.filterBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filterBtn.BackColor = System.Drawing.Color.Transparent;
            this.filterBtn.BorderRadius = 10;
            this.filterBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.filterBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.filterBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.filterBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.filterBtn.Enabled = false;
            this.filterBtn.FillColor = System.Drawing.Color.CornflowerBlue;
            this.filterBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filterBtn.ForeColor = System.Drawing.Color.White;
            this.filterBtn.Location = new System.Drawing.Point(912, 38);
            this.filterBtn.Name = "filterBtn";
            this.filterBtn.Size = new System.Drawing.Size(112, 34);
            this.filterBtn.TabIndex = 0;
            this.filterBtn.Text = "Обработать";
            this.filterBtn.Click += new System.EventHandler(this.filterBtn_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.BorderColor = System.Drawing.Color.LightGray;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.guna2GroupBox2);
            this.guna2Panel1.Controls.Add(this.guna2GroupBox1);
            this.guna2Panel1.Controls.Add(this.elapsedLabel);
            this.guna2Panel1.Controls.Add(this.filterBtn);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Panel1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.guna2Panel1.FillColor = System.Drawing.Color.LightGray;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 24);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.BorderRadius = 10;
            this.guna2Panel1.ShadowDecoration.Depth = 10;
            this.guna2Panel1.ShadowDecoration.Enabled = true;
            this.guna2Panel1.Size = new System.Drawing.Size(1036, 116);
            this.guna2Panel1.TabIndex = 12;
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox2.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GroupBox2.BorderRadius = 10;
            this.guna2GroupBox2.BorderThickness = 2;
            this.guna2GroupBox2.Controls.Add(this.lineLengthInput);
            this.guna2GroupBox2.Controls.Add(this.minBrightness);
            this.guna2GroupBox2.Controls.Add(this.label2);
            this.guna2GroupBox2.Controls.Add(this.label1);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GroupBox2.CustomBorderThickness = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.guna2GroupBox2.FillColor = System.Drawing.SystemColors.Control;
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox2.Location = new System.Drawing.Point(10, 8);
            this.guna2GroupBox2.Margin = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Size = new System.Drawing.Size(248, 100);
            this.guna2GroupBox2.TabIndex = 18;
            this.guna2GroupBox2.Text = "Параметры линий";
            this.guna2GroupBox2.TextOffset = new System.Drawing.Point(0, -10);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(20, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Минимальная длина:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(9, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Минимальная яркость:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GroupBox1.BorderRadius = 10;
            this.guna2GroupBox1.BorderThickness = 2;
            this.guna2GroupBox1.Controls.Add(this.ownSizeRadio);
            this.guna2GroupBox1.Controls.Add(this.preSizeRadio);
            this.guna2GroupBox1.Controls.Add(this.maskSizeTextBox);
            this.guna2GroupBox1.Controls.Add(this.maskSizeComboBox);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.guna2GroupBox1.FillColor = System.Drawing.SystemColors.Control;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(268, 8);
            this.guna2GroupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.guna2GroupBox1.Size = new System.Drawing.Size(215, 100);
            this.guna2GroupBox1.TabIndex = 18;
            this.guna2GroupBox1.Text = "Размер маски";
            this.guna2GroupBox1.TextOffset = new System.Drawing.Point(0, -10);
            // 
            // ownSizeRadio
            // 
            this.ownSizeRadio.BackColor = System.Drawing.Color.Transparent;
            this.ownSizeRadio.BorderColor = System.Drawing.Color.Gray;
            this.ownSizeRadio.BorderRadius = 7;
            this.ownSizeRadio.BorderThickness = 1;
            this.ownSizeRadio.CheckedState.FillColor = System.Drawing.Color.CornflowerBlue;
            this.ownSizeRadio.CheckedState.ForeColor = System.Drawing.Color.White;
            this.ownSizeRadio.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ownSizeRadio.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ownSizeRadio.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ownSizeRadio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ownSizeRadio.FillColor = System.Drawing.SystemColors.Control;
            this.ownSizeRadio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ownSizeRadio.ForeColor = System.Drawing.Color.Black;
            this.ownSizeRadio.Location = new System.Drawing.Point(111, 27);
            this.ownSizeRadio.Name = "ownSizeRadio";
            this.ownSizeRadio.Size = new System.Drawing.Size(94, 21);
            this.ownSizeRadio.TabIndex = 19;
            this.ownSizeRadio.Text = "Настроить";
            this.ownSizeRadio.Click += new System.EventHandler(this.ownSizeRadio_Click);
            // 
            // preSizeRadio
            // 
            this.preSizeRadio.BackColor = System.Drawing.Color.Transparent;
            this.preSizeRadio.BorderColor = System.Drawing.Color.Gray;
            this.preSizeRadio.BorderRadius = 7;
            this.preSizeRadio.BorderThickness = 1;
            this.preSizeRadio.Checked = true;
            this.preSizeRadio.CheckedState.FillColor = System.Drawing.Color.CornflowerBlue;
            this.preSizeRadio.CheckedState.ForeColor = System.Drawing.Color.White;
            this.preSizeRadio.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.preSizeRadio.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.preSizeRadio.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.preSizeRadio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.preSizeRadio.FillColor = System.Drawing.SystemColors.Control;
            this.preSizeRadio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.preSizeRadio.ForeColor = System.Drawing.Color.Black;
            this.preSizeRadio.Location = new System.Drawing.Point(11, 27);
            this.preSizeRadio.Name = "preSizeRadio";
            this.preSizeRadio.Size = new System.Drawing.Size(94, 21);
            this.preSizeRadio.TabIndex = 19;
            this.preSizeRadio.Text = "Заданный";
            this.preSizeRadio.Click += new System.EventHandler(this.preSizeRadio_Click);
            // 
            // maskSizeTextBox
            // 
            this.maskSizeTextBox.BorderColor = System.Drawing.Color.Gray;
            this.maskSizeTextBox.BorderRadius = 10;
            this.maskSizeTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.maskSizeTextBox.DefaultText = "";
            this.maskSizeTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.maskSizeTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.maskSizeTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.maskSizeTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.maskSizeTextBox.Enabled = false;
            this.maskSizeTextBox.FocusedState.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.maskSizeTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskSizeTextBox.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.maskSizeTextBox.Location = new System.Drawing.Point(111, 60);
            this.maskSizeTextBox.Name = "maskSizeTextBox";
            this.maskSizeTextBox.PasswordChar = '\0';
            this.maskSizeTextBox.PlaceholderText = "";
            this.maskSizeTextBox.ReadOnly = true;
            this.maskSizeTextBox.SelectedText = "";
            this.maskSizeTextBox.Size = new System.Drawing.Size(94, 30);
            this.maskSizeTextBox.TabIndex = 17;
            this.maskSizeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // maskSizeComboBox
            // 
            this.maskSizeComboBox.BackColor = System.Drawing.Color.Transparent;
            this.maskSizeComboBox.BorderColor = System.Drawing.Color.Gray;
            this.maskSizeComboBox.BorderRadius = 10;
            this.maskSizeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.maskSizeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.maskSizeComboBox.FocusedColor = System.Drawing.Color.RoyalBlue;
            this.maskSizeComboBox.FocusedState.BorderColor = System.Drawing.Color.RoyalBlue;
            this.maskSizeComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.maskSizeComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.maskSizeComboBox.ItemHeight = 24;
            this.maskSizeComboBox.Items.AddRange(new object[] {
            "3x3",
            "5x5",
            "7x7",
            "9x9",
            "11x11",
            "13x13",
            "15x15"});
            this.maskSizeComboBox.Location = new System.Drawing.Point(11, 60);
            this.maskSizeComboBox.Name = "maskSizeComboBox";
            this.maskSizeComboBox.Size = new System.Drawing.Size(94, 30);
            this.maskSizeComboBox.TabIndex = 15;
            // 
            // progressBar
            // 
            this.progressBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progressBar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.progressBar.Backwards = true;
            this.progressBar.FillColor = System.Drawing.Color.White;
            this.progressBar.FillThickness = 13;
            this.progressBar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.progressBar.ForeColor = System.Drawing.Color.White;
            this.progressBar.Location = new System.Drawing.Point(688, 163);
            this.progressBar.Minimum = 0;
            this.progressBar.Name = "progressBar";
            this.progressBar.ProgressBrushMode = Guna.UI2.WinForms.Enums.BrushMode.SolidTransition;
            this.progressBar.ProgressColor = System.Drawing.Color.LightGray;
            this.progressBar.ProgressColor2 = System.Drawing.Color.CornflowerBlue;
            this.progressBar.ProgressThickness = 15;
            this.progressBar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.progressBar.ShowText = true;
            this.progressBar.Size = new System.Drawing.Size(144, 144);
            this.progressBar.TabIndex = 15;
            this.progressBar.Text = "guna2CircleProgressBar1";
            this.progressBar.Visible = false;
            // 
            // inputPictureBox
            // 
            this.inputPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputPictureBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.inputPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("inputPictureBox.Image")));
            this.inputPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("inputPictureBox.InitialImage")));
            this.inputPictureBox.Location = new System.Drawing.Point(11, 6);
            this.inputPictureBox.Margin = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.inputPictureBox.Name = "inputPictureBox";
            this.inputPictureBox.Size = new System.Drawing.Size(490, 458);
            this.inputPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.inputPictureBox.TabIndex = 1;
            this.inputPictureBox.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.inputPictureBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.progressBar, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 146);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1014, 470);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 628);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "Form1";
            this.Text = "AMF";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minBrightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineLengthInput)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox2.PerformLayout();
            this.guna2GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inputPictureBox)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jpgToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label elapsedLabel;
        private Guna.UI2.WinForms.Guna2Button filterBtn;
        private Guna.UI2.WinForms.Guna2NumericUpDown minBrightness;
        private Guna.UI2.WinForms.Guna2NumericUpDown lineLengthInput;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2CircleProgressBar progressBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox maskSizeComboBox;
        private Guna.UI2.WinForms.Guna2TextBox maskSizeTextBox;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2Button ownSizeRadio;
        private Guna.UI2.WinForms.Guna2Button preSizeRadio;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private System.Windows.Forms.PictureBox inputPictureBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

