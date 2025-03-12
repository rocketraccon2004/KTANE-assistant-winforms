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
			button1 = new Button();
			tableLayoutPanel1.SuspendLayout();
			SuspendLayout();
			// 
			// btnSolve
			// 
			btnSolve.Click += btnSolve_Click;
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
			tableLayoutPanel1.Location = new Point(33, 48);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 2;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.Size = new Size(446, 325);
			tableLayoutPanel1.TabIndex = 82;
			// 
			// textBox4
			// 
			textBox4.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
			textBox4.Location = new Point(226, 165);
			textBox4.Name = "textBox4";
			textBox4.Size = new Size(217, 135);
			textBox4.TabIndex = 3;
			textBox4.TextAlign = HorizontalAlignment.Center;
			// 
			// textBox3
			// 
			textBox3.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
			textBox3.Location = new Point(3, 165);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(217, 135);
			textBox3.TabIndex = 2;
			textBox3.TextAlign = HorizontalAlignment.Center;
			// 
			// textBox2
			// 
			textBox2.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
			textBox2.Location = new Point(226, 3);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(217, 135);
			textBox2.TabIndex = 1;
			textBox2.TextAlign = HorizontalAlignment.Center;
			// 
			// textBox1
			// 
			textBox1.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
			textBox1.Location = new Point(3, 3);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(217, 135);
			textBox1.TabIndex = 0;
			textBox1.TextAlign = HorizontalAlignment.Center;
			// 
			// rbRed
			// 
			rbRed.AutoSize = true;
			rbRed.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
			rbRed.Location = new Point(577, 68);
			rbRed.Name = "rbRed";
			rbRed.Size = new Size(99, 49);
			rbRed.TabIndex = 83;
			rbRed.TabStop = true;
			rbRed.Text = "Red";
			rbRed.UseVisualStyleBackColor = true;
			// 
			// rbOrange
			// 
			rbOrange.AutoSize = true;
			rbOrange.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
			rbOrange.Location = new Point(577, 343);
			rbOrange.Name = "rbOrange";
			rbOrange.Size = new Size(149, 41);
			rbOrange.TabIndex = 84;
			rbOrange.TabStop = true;
			rbOrange.Text = "Orange";
			rbOrange.UseVisualStyleBackColor = true;
			// 
			// rbPurple
			// 
			rbPurple.AutoSize = true;
			rbPurple.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
			rbPurple.Location = new Point(577, 288);
			rbPurple.Name = "rbPurple";
			rbPurple.Size = new Size(136, 49);
			rbPurple.TabIndex = 85;
			rbPurple.TabStop = true;
			rbPurple.Text = "Purple";
			rbPurple.UseVisualStyleBackColor = true;
			// 
			// rbYellow
			// 
			rbYellow.AutoSize = true;
			rbYellow.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
			rbYellow.Location = new Point(577, 233);
			rbYellow.Name = "rbYellow";
			rbYellow.Size = new Size(135, 49);
			rbYellow.TabIndex = 86;
			rbYellow.TabStop = true;
			rbYellow.Text = "Yellow";
			rbYellow.UseVisualStyleBackColor = true;
			// 
			// rbBlue
			// 
			rbBlue.AutoSize = true;
			rbBlue.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
			rbBlue.Location = new Point(577, 178);
			rbBlue.Name = "rbBlue";
			rbBlue.Size = new Size(106, 49);
			rbBlue.TabIndex = 87;
			rbBlue.TabStop = true;
			rbBlue.Text = "Blue";
			rbBlue.UseVisualStyleBackColor = true;
			// 
			// rbGreen
			// 
			rbGreen.AutoSize = true;
			rbGreen.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
			rbGreen.Location = new Point(577, 123);
			rbGreen.Name = "rbGreen";
			rbGreen.Size = new Size(130, 49);
			rbGreen.TabIndex = 88;
			rbGreen.TabStop = true;
			rbGreen.Text = "Green";
			rbGreen.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			button1.Location = new Point(828, 426);
			button1.Name = "button1";
			button1.Size = new Size(225, 106);
			button1.TabIndex = 89;
			button1.Text = "Reset";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// frmLEDEncryption
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1080, 537);
			Controls.Add(button1);
			Controls.Add(rbGreen);
			Controls.Add(rbBlue);
			Controls.Add(rbYellow);
			Controls.Add(rbPurple);
			Controls.Add(rbOrange);
			Controls.Add(rbRed);
			Controls.Add(tableLayoutPanel1);
			Name = "frmLEDEncryption";
			Text = "LED Encryption";
			Controls.SetChildIndex(btnSolve, 0);
			Controls.SetChildIndex(btnStrike, 0);
			Controls.SetChildIndex(btnBack, 0);
			Controls.SetChildIndex(tableLayoutPanel1, 0);
			Controls.SetChildIndex(rbRed, 0);
			Controls.SetChildIndex(rbOrange, 0);
			Controls.SetChildIndex(rbPurple, 0);
			Controls.SetChildIndex(rbYellow, 0);
			Controls.SetChildIndex(rbBlue, 0);
			Controls.SetChildIndex(rbGreen, 0);
			Controls.SetChildIndex(button1, 0);
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
		private Button button1;
	}
}