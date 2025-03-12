namespace KTANE_Assistant.Forms
{
	partial class frmAnagrams
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
			label1 = new Label();
			txtAnagram = new TextBox();
			SuspendLayout();
			// 
			// btnBack
			// 
			btnBack.Location = new Point(15, 328);
			// 
			// btnStrike
			// 
			btnStrike.Location = new Point(284, 328);
			// 
			// btnSolve
			// 
			btnSolve.Location = new Point(562, 328);
			btnSolve.Click += btnSolve_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label1.Location = new Point(12, 134);
			label1.Name = "label1";
			label1.Size = new Size(158, 37);
			label1.TabIndex = 82;
			label1.Text = "Anagram:";
			// 
			// txtAnagram
			// 
			txtAnagram.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txtAnagram.Location = new Point(204, 124);
			txtAnagram.Name = "txtAnagram";
			txtAnagram.Size = new Size(328, 50);
			txtAnagram.TabIndex = 83;
			// 
			// frmAnagrams
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(txtAnagram);
			Controls.Add(label1);
			Name = "frmAnagrams";
			Text = "Anagrams";
			Controls.SetChildIndex(btnSolve, 0);
			Controls.SetChildIndex(btnStrike, 0);
			Controls.SetChildIndex(btnBack, 0);
			Controls.SetChildIndex(label1, 0);
			Controls.SetChildIndex(txtAnagram, 0);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox txtAnagram;
	}
}