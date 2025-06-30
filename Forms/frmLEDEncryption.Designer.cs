namespace KTANE_Assistant.Forms
{
	partial class frmLEDEncryption
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
            tableLayoutPanel1 = new TableLayoutPanel();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            rbRed = new RadioButton();
            rbOrange = new RadioButton();
            rbPurple = new RadioButton();
            rbYellow = new RadioButton();
            rbBlue = new RadioButton();
            rbGreen = new RadioButton();
            btnReset = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(textBox4, 1, 1);
            tableLayoutPanel1.Controls.Add(textBox3, 0, 1);
            tableLayoutPanel1.Controls.Add(textBox2, 1, 0);
            tableLayoutPanel1.Controls.Add(textBox1, 0, 0);
            tableLayoutPanel1.Location = new Point(23, 29);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(312, 195);
            tableLayoutPanel1.TabIndex = 82;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(158, 99);
            textBox4.Margin = new Padding(2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(152, 93);
            textBox4.TabIndex = 3;
            textBox4.TextAlign = HorizontalAlignment.Center;
            textBox4.TextChanged += TextBox_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(2, 99);
            textBox3.Margin = new Padding(2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(152, 93);
            textBox3.TabIndex = 2;
            textBox3.TextAlign = HorizontalAlignment.Center;
            textBox3.TextChanged += TextBox_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(158, 2);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(152, 93);
            textBox2.TabIndex = 1;
            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox2.TextChanged += TextBox_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(2, 2);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(152, 93);
            textBox1.TabIndex = 0;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += TextBox_TextChanged;
            // 
            // rbRed
            // 
            rbRed.AutoSize = true;
            rbRed.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbRed.Location = new Point(404, 41);
            rbRed.Margin = new Padding(2);
            rbRed.Name = "rbRed";
            rbRed.Size = new Size(68, 34);
            rbRed.TabIndex = 83;
            rbRed.TabStop = true;
            rbRed.Text = "Red";
            rbRed.UseVisualStyleBackColor = true;
            // 
            // rbOrange
            // 
            rbOrange.AutoSize = true;
            rbOrange.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbOrange.Location = new Point(404, 206);
            rbOrange.Margin = new Padding(2);
            rbOrange.Name = "rbOrange";
            rbOrange.Size = new Size(102, 30);
            rbOrange.TabIndex = 84;
            rbOrange.TabStop = true;
            rbOrange.Text = "Orange";
            rbOrange.UseVisualStyleBackColor = true;
            // 
            // rbPurple
            // 
            rbPurple.AutoSize = true;
            rbPurple.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbPurple.Location = new Point(404, 173);
            rbPurple.Margin = new Padding(2);
            rbPurple.Name = "rbPurple";
            rbPurple.Size = new Size(93, 34);
            rbPurple.TabIndex = 85;
            rbPurple.TabStop = true;
            rbPurple.Text = "Purple";
            rbPurple.UseVisualStyleBackColor = true;
            // 
            // rbYellow
            // 
            rbYellow.AutoSize = true;
            rbYellow.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbYellow.Location = new Point(404, 140);
            rbYellow.Margin = new Padding(2);
            rbYellow.Name = "rbYellow";
            rbYellow.Size = new Size(92, 34);
            rbYellow.TabIndex = 86;
            rbYellow.TabStop = true;
            rbYellow.Text = "Yellow";
            rbYellow.UseVisualStyleBackColor = true;
            // 
            // rbBlue
            // 
            rbBlue.AutoSize = true;
            rbBlue.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbBlue.Location = new Point(404, 107);
            rbBlue.Margin = new Padding(2);
            rbBlue.Name = "rbBlue";
            rbBlue.Size = new Size(73, 34);
            rbBlue.TabIndex = 87;
            rbBlue.TabStop = true;
            rbBlue.Text = "Blue";
            rbBlue.UseVisualStyleBackColor = true;
            // 
            // rbGreen
            // 
            rbGreen.AutoSize = true;
            rbGreen.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbGreen.Location = new Point(404, 74);
            rbGreen.Margin = new Padding(2);
            rbGreen.Name = "rbGreen";
            rbGreen.Size = new Size(90, 34);
            rbGreen.TabIndex = 88;
            rbGreen.TabStop = true;
            rbGreen.Text = "Green";
            rbGreen.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReset.Location = new Point(580, 256);
            btnReset.Margin = new Padding(2);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(158, 64);
            btnReset.TabIndex = 89;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // frmLEDEncryption
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(756, 322);
            Controls.Add(btnReset);
            Controls.Add(rbGreen);
            Controls.Add(rbBlue);
            Controls.Add(rbYellow);
            Controls.Add(rbPurple);
            Controls.Add(rbOrange);
            Controls.Add(rbRed);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(1);
            Name = "frmLEDEncryption";
            Text = "LED Encryption";
            Controls.SetChildIndex(tableLayoutPanel1, 0);
            Controls.SetChildIndex(rbRed, 0);
            Controls.SetChildIndex(rbOrange, 0);
            Controls.SetChildIndex(rbPurple, 0);
            Controls.SetChildIndex(rbYellow, 0);
            Controls.SetChildIndex(rbBlue, 0);
            Controls.SetChildIndex(rbGreen, 0);
            Controls.SetChildIndex(btnReset, 0);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
		private TextBox textBox1;
		private RadioButton rbRed;
		private RadioButton rbOrange;
		private RadioButton rbPurple;
		private RadioButton rbYellow;
		private RadioButton rbBlue;
		private RadioButton rbGreen;
		private TextBox textBox4;
		private TextBox textBox3;
		private TextBox textBox2;
		private Button btnReset;
	}
}