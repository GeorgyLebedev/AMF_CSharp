namespace WindowsFormsApp1
{
    partial class Form2
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
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cancelBtn = new Guna.UI2.WinForms.Guna2Button();
            this.AcceptBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maskWidthInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.maskHeightInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(7, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Ширина маски:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.cancelBtn, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.AcceptBtn, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.maskWidthInput, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.maskHeightInput, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(227, 156);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancelBtn.BackColor = System.Drawing.Color.Transparent;
            this.cancelBtn.BorderColor = System.Drawing.Color.Gray;
            this.cancelBtn.BorderRadius = 10;
            this.cancelBtn.BorderThickness = 1;
            this.cancelBtn.CheckedState.FillColor = System.Drawing.Color.CornflowerBlue;
            this.cancelBtn.CheckedState.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cancelBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cancelBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cancelBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cancelBtn.FillColor = System.Drawing.SystemColors.Control;
            this.cancelBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelBtn.ForeColor = System.Drawing.Color.Black;
            this.cancelBtn.HoverState.FillColor = System.Drawing.Color.LightSteelBlue;
            this.cancelBtn.Location = new System.Drawing.Point(123, 125);
            this.cancelBtn.MinimumSize = new System.Drawing.Size(0, 26);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(94, 26);
            this.cancelBtn.TabIndex = 20;
            this.cancelBtn.Text = "Отмена";
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // AcceptBtn
            // 
            this.AcceptBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AcceptBtn.BackColor = System.Drawing.Color.Transparent;
            this.AcceptBtn.BorderColor = System.Drawing.Color.Gray;
            this.AcceptBtn.BorderRadius = 10;
            this.AcceptBtn.BorderThickness = 1;
            this.AcceptBtn.CheckedState.FillColor = System.Drawing.Color.CornflowerBlue;
            this.AcceptBtn.CheckedState.ForeColor = System.Drawing.Color.White;
            this.AcceptBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AcceptBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AcceptBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AcceptBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AcceptBtn.FillColor = System.Drawing.Color.CornflowerBlue;
            this.AcceptBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AcceptBtn.ForeColor = System.Drawing.Color.White;
            this.AcceptBtn.HoverState.FillColor = System.Drawing.Color.RoyalBlue;
            this.AcceptBtn.Location = new System.Drawing.Point(9, 125);
            this.AcceptBtn.MinimumSize = new System.Drawing.Size(0, 26);
            this.AcceptBtn.Name = "AcceptBtn";
            this.AcceptBtn.Size = new System.Drawing.Size(94, 26);
            this.AcceptBtn.TabIndex = 20;
            this.AcceptBtn.Text = "Принять";
            this.AcceptBtn.Click += new System.EventHandler(this.AcceptBtn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(10, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Высота маски:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.SetColumnSpan(this.label3, 2);
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(9, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 34);
            this.label3.TabIndex = 15;
            this.label3.Text = "Принимаются только нечётные числа";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maskWidthInput
            // 
            this.maskWidthInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maskWidthInput.BorderColor = System.Drawing.Color.Gray;
            this.maskWidthInput.BorderRadius = 10;
            this.maskWidthInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.maskWidthInput.DefaultText = "3";
            this.maskWidthInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.maskWidthInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.maskWidthInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.maskWidthInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.maskWidthInput.FocusedState.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.maskWidthInput.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskWidthInput.ForeColor = System.Drawing.Color.DimGray;
            this.maskWidthInput.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.maskWidthInput.Location = new System.Drawing.Point(123, 56);
            this.maskWidthInput.Name = "maskWidthInput";
            this.maskWidthInput.PasswordChar = '\0';
            this.maskWidthInput.PlaceholderText = "";
            this.maskWidthInput.SelectedText = "";
            this.maskWidthInput.Size = new System.Drawing.Size(94, 28);
            this.maskWidthInput.TabIndex = 21;
            this.maskWidthInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskWidthInput.TextChanged += new System.EventHandler(this.validateInput);
            // 
            // maskHeightInput
            // 
            this.maskHeightInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maskHeightInput.BorderColor = System.Drawing.Color.Gray;
            this.maskHeightInput.BorderRadius = 10;
            this.maskHeightInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.maskHeightInput.DefaultText = "3";
            this.maskHeightInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.maskHeightInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.maskHeightInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.maskHeightInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.maskHeightInput.FocusedState.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.maskHeightInput.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskHeightInput.ForeColor = System.Drawing.Color.DimGray;
            this.maskHeightInput.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.maskHeightInput.Location = new System.Drawing.Point(123, 90);
            this.maskHeightInput.Name = "maskHeightInput";
            this.maskHeightInput.PasswordChar = '\0';
            this.maskHeightInput.PlaceholderText = "";
            this.maskHeightInput.SelectedText = "";
            this.maskHeightInput.Size = new System.Drawing.Size(94, 28);
            this.maskHeightInput.TabIndex = 21;
            this.maskHeightInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskHeightInput.TextChanged += new System.EventHandler(this.validateInput);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 156);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.ShowInTaskbar = false;
            this.Text = "Размер маски";
            this.TopMost = true;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button AcceptBtn;
        private Guna.UI2.WinForms.Guna2Button cancelBtn;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox maskWidthInput;
        private Guna.UI2.WinForms.Guna2TextBox maskHeightInput;
    }
}