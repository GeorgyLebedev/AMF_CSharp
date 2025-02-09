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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.minBrightness = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.lineLengthInput = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.helpButton = new Guna.UI2.WinForms.Guna2Button();
            this.saveAsButton = new Guna.UI2.WinForms.Guna2Button();
            this.saveButton = new Guna.UI2.WinForms.Guna2Button();
            this.openFileBtn = new Guna.UI2.WinForms.Guna2Button();
            this.filterBtn = new Guna.UI2.WinForms.Guna2Button();
            this.elapsedLabel = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.maskPictureBox = new System.Windows.Forms.PictureBox();
            this.guna2GroupBox3 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.progressBar = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.ownSizeRadio = new Guna.UI2.WinForms.Guna2Button();
            this.preSizeRadio = new Guna.UI2.WinForms.Guna2Button();
            this.maskSizeTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.maskSizeComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.inputPictureBox = new System.Windows.Forms.PictureBox();
            this.outputPictureBox = new System.Windows.Forms.PictureBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.guna2GroupBox4 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.maskTypeComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.minBrightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineLengthInput)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maskPictureBox)).BeginInit();
            this.guna2GroupBox3.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputPictureBox)).BeginInit();
            this.guna2GroupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Изображение JPG|*.jpg|Изображение PNG|*.png";
            this.openFileDialog.RestoreDirectory = true;
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
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 350;
            // 
            // helpButton
            // 
            this.helpButton.BackColor = System.Drawing.Color.Transparent;
            this.helpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.helpButton.BorderColor = System.Drawing.Color.DarkGray;
            this.helpButton.BorderRadius = 10;
            this.helpButton.BorderThickness = 1;
            this.helpButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.helpButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.helpButton.DisabledState.FillColor = System.Drawing.Color.Silver;
            this.helpButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.helpButton.FillColor = System.Drawing.Color.Transparent;
            this.helpButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.helpButton.ForeColor = System.Drawing.Color.White;
            this.helpButton.Image = global::WindowsFormsApp1.Properties.Resources.help;
            this.helpButton.ImageSize = new System.Drawing.Size(40, 40);
            this.helpButton.Location = new System.Drawing.Point(190, 32);
            this.helpButton.Margin = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(50, 50);
            this.helpButton.TabIndex = 0;
            this.toolTip1.SetToolTip(this.helpButton, "Справка");
            // 
            // saveAsButton
            // 
            this.saveAsButton.BackColor = System.Drawing.Color.Transparent;
            this.saveAsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.saveAsButton.BorderColor = System.Drawing.Color.DarkGray;
            this.saveAsButton.BorderRadius = 10;
            this.saveAsButton.BorderThickness = 1;
            this.saveAsButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.saveAsButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.saveAsButton.DisabledState.FillColor = System.Drawing.Color.Silver;
            this.saveAsButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.saveAsButton.Enabled = false;
            this.saveAsButton.FillColor = System.Drawing.Color.Transparent;
            this.saveAsButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.saveAsButton.ForeColor = System.Drawing.Color.White;
            this.saveAsButton.Image = global::WindowsFormsApp1.Properties.Resources.save_as;
            this.saveAsButton.ImageSize = new System.Drawing.Size(40, 40);
            this.saveAsButton.Location = new System.Drawing.Point(130, 32);
            this.saveAsButton.Margin = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.saveAsButton.Name = "saveAsButton";
            this.saveAsButton.Size = new System.Drawing.Size(50, 50);
            this.saveAsButton.TabIndex = 0;
            this.toolTip1.SetToolTip(this.saveAsButton, "Сохранить как...");
            this.saveAsButton.Click += new System.EventHandler(this.saveAsButtonClick);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Transparent;
            this.saveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.saveButton.BorderColor = System.Drawing.Color.DarkGray;
            this.saveButton.BorderRadius = 10;
            this.saveButton.BorderThickness = 1;
            this.saveButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.saveButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.saveButton.DisabledState.FillColor = System.Drawing.Color.Silver;
            this.saveButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.saveButton.Enabled = false;
            this.saveButton.FillColor = System.Drawing.Color.Transparent;
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Image = global::WindowsFormsApp1.Properties.Resources.save;
            this.saveButton.ImageSize = new System.Drawing.Size(40, 40);
            this.saveButton.Location = new System.Drawing.Point(70, 32);
            this.saveButton.Margin = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(50, 50);
            this.saveButton.TabIndex = 0;
            this.toolTip1.SetToolTip(this.saveButton, "Сохранить");
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // openFileBtn
            // 
            this.openFileBtn.BackColor = System.Drawing.Color.Transparent;
            this.openFileBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.openFileBtn.BorderColor = System.Drawing.Color.DarkGray;
            this.openFileBtn.BorderRadius = 10;
            this.openFileBtn.BorderThickness = 1;
            this.openFileBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.openFileBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.openFileBtn.DisabledState.FillColor = System.Drawing.Color.Silver;
            this.openFileBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.openFileBtn.FillColor = System.Drawing.Color.Transparent;
            this.openFileBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.openFileBtn.ForeColor = System.Drawing.Color.White;
            this.openFileBtn.Image = global::WindowsFormsApp1.Properties.Resources.open;
            this.openFileBtn.ImageSize = new System.Drawing.Size(35, 40);
            this.openFileBtn.Location = new System.Drawing.Point(10, 32);
            this.openFileBtn.Margin = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.openFileBtn.Name = "openFileBtn";
            this.openFileBtn.Size = new System.Drawing.Size(50, 50);
            this.openFileBtn.TabIndex = 0;
            this.toolTip1.SetToolTip(this.openFileBtn, "Открыть файл");
            this.openFileBtn.Click += new System.EventHandler(this.openImageClick);
            // 
            // filterBtn
            // 
            this.filterBtn.BackColor = System.Drawing.Color.Transparent;
            this.filterBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.filterBtn.BorderColor = System.Drawing.Color.DarkGray;
            this.filterBtn.BorderRadius = 10;
            this.filterBtn.BorderThickness = 1;
            this.filterBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.filterBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.filterBtn.DisabledState.FillColor = System.Drawing.Color.Silver;
            this.filterBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.filterBtn.Enabled = false;
            this.filterBtn.FillColor = System.Drawing.Color.Transparent;
            this.filterBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.filterBtn.ForeColor = System.Drawing.Color.White;
            this.filterBtn.Image = global::WindowsFormsApp1.Properties.Resources.start;
            this.filterBtn.ImageSize = new System.Drawing.Size(40, 40);
            this.filterBtn.Location = new System.Drawing.Point(1019, 31);
            this.filterBtn.Margin = new System.Windows.Forms.Padding(5, 5, 10, 5);
            this.filterBtn.Name = "filterBtn";
            this.filterBtn.Size = new System.Drawing.Size(50, 50);
            this.filterBtn.TabIndex = 0;
            this.toolTip1.SetToolTip(this.filterBtn, "Обработать");
            this.filterBtn.Click += new System.EventHandler(this.filterBtn_Click);
            // 
            // elapsedLabel
            // 
            this.elapsedLabel.BackColor = System.Drawing.Color.Transparent;
            this.elapsedLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.elapsedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.elapsedLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.elapsedLabel.Location = new System.Drawing.Point(1019, 9);
            this.elapsedLabel.Name = "elapsedLabel";
            this.elapsedLabel.Size = new System.Drawing.Size(50, 15);
            this.elapsedLabel.TabIndex = 5;
            this.elapsedLabel.Text = "                        ";
            this.elapsedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.BorderColor = System.Drawing.Color.LightGray;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.maskPictureBox);
            this.guna2Panel1.Controls.Add(this.guna2GroupBox3);
            this.guna2Panel1.Controls.Add(this.progressBar);
            this.guna2Panel1.Controls.Add(this.guna2GroupBox2);
            this.guna2Panel1.Controls.Add(this.guna2GroupBox4);
            this.guna2Panel1.Controls.Add(this.guna2GroupBox1);
            this.guna2Panel1.Controls.Add(this.elapsedLabel);
            this.guna2Panel1.Controls.Add(this.filterBtn);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Panel1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.guna2Panel1.FillColor = System.Drawing.Color.Gainsboro;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.BorderRadius = 10;
            this.guna2Panel1.ShadowDecoration.Depth = 10;
            this.guna2Panel1.ShadowDecoration.Enabled = true;
            this.guna2Panel1.Size = new System.Drawing.Size(1155, 116);
            this.guna2Panel1.TabIndex = 12;
            // 
            // maskPictureBox
            // 
            this.maskPictureBox.Location = new System.Drawing.Point(901, 9);
            this.maskPictureBox.Name = "maskPictureBox";
            this.maskPictureBox.Size = new System.Drawing.Size(100, 100);
            this.maskPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.maskPictureBox.TabIndex = 19;
            this.maskPictureBox.TabStop = false;
            // 
            // guna2GroupBox3
            // 
            this.guna2GroupBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox3.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GroupBox3.BorderRadius = 10;
            this.guna2GroupBox3.BorderThickness = 2;
            this.guna2GroupBox3.Controls.Add(this.helpButton);
            this.guna2GroupBox3.Controls.Add(this.saveAsButton);
            this.guna2GroupBox3.Controls.Add(this.saveButton);
            this.guna2GroupBox3.Controls.Add(this.openFileBtn);
            this.guna2GroupBox3.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GroupBox3.CustomBorderThickness = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.guna2GroupBox3.FillColor = System.Drawing.SystemColors.Control;
            this.guna2GroupBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2GroupBox3.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox3.Location = new System.Drawing.Point(10, 7);
            this.guna2GroupBox3.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.guna2GroupBox3.Name = "guna2GroupBox3";
            this.guna2GroupBox3.Size = new System.Drawing.Size(249, 100);
            this.guna2GroupBox3.TabIndex = 18;
            this.guna2GroupBox3.Text = "Работа с файлами";
            this.guna2GroupBox3.TextOffset = new System.Drawing.Point(0, -10);
            // 
            // progressBar
            // 
            this.progressBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progressBar.BackColor = System.Drawing.Color.LightGray;
            this.progressBar.Backwards = true;
            this.progressBar.FillColor = System.Drawing.Color.White;
            this.progressBar.FillThickness = 13;
            this.progressBar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.progressBar.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.progressBar.Location = new System.Drawing.Point(1070, 107);
            this.progressBar.Minimum = 0;
            this.progressBar.Name = "progressBar";
            this.progressBar.ProgressBrushMode = Guna.UI2.WinForms.Enums.BrushMode.SolidTransition;
            this.progressBar.ProgressColor = System.Drawing.Color.LightGray;
            this.progressBar.ProgressColor2 = System.Drawing.Color.CornflowerBlue;
            this.progressBar.ProgressThickness = 15;
            this.progressBar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.progressBar.ShowText = true;
            this.progressBar.Size = new System.Drawing.Size(120, 120);
            this.progressBar.TabIndex = 15;
            this.progressBar.Text = "guna2CircleProgressBar1";
            this.progressBar.Visible = false;
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
            this.guna2GroupBox2.Location = new System.Drawing.Point(265, 7);
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
            this.guna2GroupBox1.Location = new System.Drawing.Point(676, 7);
            this.guna2GroupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.guna2GroupBox1.Size = new System.Drawing.Size(217, 100);
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
            this.maskSizeComboBox.SelectedValueChanged += new System.EventHandler(this.maskSizeComboBox_SelectedValueChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.LightGray;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.inputPictureBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.outputPictureBox, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 124);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1133, 492);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // inputPictureBox
            // 
            this.inputPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputPictureBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.inputPictureBox.Image = global::WindowsFormsApp1.Properties.Resources.placeholder;
            this.inputPictureBox.InitialImage = global::WindowsFormsApp1.Properties.Resources.placeholder;
            this.inputPictureBox.Location = new System.Drawing.Point(6, 6);
            this.inputPictureBox.Margin = new System.Windows.Forms.Padding(5);
            this.inputPictureBox.Name = "inputPictureBox";
            this.inputPictureBox.Size = new System.Drawing.Size(555, 480);
            this.inputPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.inputPictureBox.TabIndex = 1;
            this.inputPictureBox.TabStop = false;
            this.inputPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.inputPictureBox_MouseDown);
            // 
            // outputPictureBox
            // 
            this.outputPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputPictureBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.outputPictureBox.Image = global::WindowsFormsApp1.Properties.Resources.placeholder;
            this.outputPictureBox.InitialImage = global::WindowsFormsApp1.Properties.Resources.placeholder;
            this.outputPictureBox.Location = new System.Drawing.Point(572, 6);
            this.outputPictureBox.Margin = new System.Windows.Forms.Padding(5);
            this.outputPictureBox.Name = "outputPictureBox";
            this.outputPictureBox.Size = new System.Drawing.Size(555, 480);
            this.outputPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.outputPictureBox.TabIndex = 1;
            this.outputPictureBox.TabStop = false;
            this.outputPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.outputPictureBox_MouseDown);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Формат PNG (*.png)|*.png|Формат JPG (*.jpg)|*.jpg|Формат BMP (*.bmp)|*.bmp";
            this.saveFileDialog.RestoreDirectory = true;
            this.saveFileDialog.Title = "Сохранить как";
            // 
            // guna2GroupBox4
            // 
            this.guna2GroupBox4.BackColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox4.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GroupBox4.BorderRadius = 10;
            this.guna2GroupBox4.BorderThickness = 2;
            this.guna2GroupBox4.Controls.Add(this.maskTypeComboBox);
            this.guna2GroupBox4.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GroupBox4.CustomBorderThickness = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.guna2GroupBox4.FillColor = System.Drawing.SystemColors.Control;
            this.guna2GroupBox4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2GroupBox4.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox4.Location = new System.Drawing.Point(520, 7);
            this.guna2GroupBox4.Margin = new System.Windows.Forms.Padding(5);
            this.guna2GroupBox4.Name = "guna2GroupBox4";
            this.guna2GroupBox4.Padding = new System.Windows.Forms.Padding(5);
            this.guna2GroupBox4.Size = new System.Drawing.Size(146, 100);
            this.guna2GroupBox4.TabIndex = 18;
            this.guna2GroupBox4.Text = "Тип маски";
            this.guna2GroupBox4.TextOffset = new System.Drawing.Point(0, -10);
            // 
            // maskTypeComboBox
            // 
            this.maskTypeComboBox.BackColor = System.Drawing.Color.Transparent;
            this.maskTypeComboBox.BorderColor = System.Drawing.Color.Gray;
            this.maskTypeComboBox.BorderRadius = 10;
            this.maskTypeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.maskTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.maskTypeComboBox.FocusedColor = System.Drawing.Color.RoyalBlue;
            this.maskTypeComboBox.FocusedState.BorderColor = System.Drawing.Color.RoyalBlue;
            this.maskTypeComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.maskTypeComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.maskTypeComboBox.ItemHeight = 24;
            this.maskTypeComboBox.Items.AddRange(new object[] {
            "Тип А",
            "Тип B",
            "Тип C"});
            this.maskTypeComboBox.Location = new System.Drawing.Point(19, 44);
            this.maskTypeComboBox.Name = "maskTypeComboBox";
            this.maskTypeComboBox.Size = new System.Drawing.Size(109, 30);
            this.maskTypeComboBox.TabIndex = 15;
            this.maskTypeComboBox.SelectedValueChanged += new System.EventHandler(this.maskSizeComboBox_SelectedValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 628);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1000, 500);
            this.Name = "Form1";
            this.Text = "AMF";
            ((System.ComponentModel.ISupportInitialize)(this.minBrightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineLengthInput)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.maskPictureBox)).EndInit();
            this.guna2GroupBox3.ResumeLayout(false);
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox2.PerformLayout();
            this.guna2GroupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inputPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputPictureBox)).EndInit();
            this.guna2GroupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label elapsedLabel;
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
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox3;
        private Guna.UI2.WinForms.Guna2Button filterBtn;
        private Guna.UI2.WinForms.Guna2Button openFileBtn;
        private Guna.UI2.WinForms.Guna2Button saveButton;
        private Guna.UI2.WinForms.Guna2Button saveAsButton;
        private Guna.UI2.WinForms.Guna2Button helpButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.PictureBox outputPictureBox;
        private System.Windows.Forms.PictureBox maskPictureBox;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox4;
        private Guna.UI2.WinForms.Guna2ComboBox maskTypeComboBox;
    }
}

