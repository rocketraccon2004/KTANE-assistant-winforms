namespace KTANE_Assistant.Forms
{
	partial class frmSkewedSlots
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
			txtSlot1 = new TextBox();
			txtSlot2 = new TextBox();
			txtSlot3 = new TextBox();
			SuspendLayout();
			// 
			// txtSlot1
			// 
			txtSlot1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txtSlot1.Location = new Point(24, 68);
			txtSlot1.Name = "txtSlot1";
			txtSlot1.Size = new Size(202, 103);
			txtSlot1.TabIndex = 82;
			txtSlot1.TextAlign = HorizontalAlignment.Center;
			txtSlot1.TextChanged += txtSlot1_TextChanged;
			// 
			// txtSlot2
			// 
			txtSlot2.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txtSlot2.Location = new Point(271, 68);
			txtSlot2.Name = "txtSlot2";
			txtSlot2.Size = new Size(202, 103);
			txtSlot2.TabIndex = 83;
			txtSlot2.TextAlign = HorizontalAlignment.Center;
			txtSlot2.TextChanged += txtSlot2_TextChanged;
			// 
			// txtSlot3
			// 
			txtSlot3.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txtSlot3.Location = new Point(526, 68);
			txtSlot3.Name = "txtSlot3";
			txtSlot3.Size = new Size(202, 103);
			txtSlot3.TabIndex = 84;
			txtSlot3.TextAlign = HorizontalAlignment.Center;
			// 
			// frmSkewedSlots
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(763, 414);
			Controls.Add(txtSlot3);
			Controls.Add(txtSlot2);
			Controls.Add(txtSlot1);
			Name = "frmSkewedSlots";
			Text = "Skewed Slots";
			Controls.SetChildIndex(txtSlot1, 0);
			Controls.SetChildIndex(txtSlot2, 0);
			Controls.SetChildIndex(txtSlot3, 0);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox txtSlot1;
		private TextBox txtSlot2;
		private TextBox txtSlot3;
	}
}