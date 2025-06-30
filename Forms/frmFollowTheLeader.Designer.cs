namespace KTANE_Assistant.Forms
{
	partial class frmFollowTheLeader
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
			txtColours = new TextBox();
			txtNumbers = new TextBox();
			label1 = new Label();
			label2 = new Label();
			lblGuide = new Label();
			SuspendLayout();
			// 
			// txtColours
			// 
			txtColours.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txtColours.Location = new Point(233, 28);
			txtColours.Multiline = true;
			txtColours.Name = "txtColours";
			txtColours.Size = new Size(395, 126);
			txtColours.TabIndex = 0;
			// 
			// txtNumbers
			// 
			txtNumbers.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txtNumbers.Location = new Point(233, 168);
			txtNumbers.Multiline = true;
			txtNumbers.Name = "txtNumbers";
			txtNumbers.Size = new Size(395, 126);
			txtNumbers.TabIndex = 82;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label1.Location = new Point(72, 61);
			label1.Name = "label1";
			label1.Size = new Size(129, 45);
			label1.TabIndex = 83;
			label1.Text = "Colours";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label2.Location = new Point(72, 208);
			label2.Name = "label2";
			label2.Size = new Size(151, 45);
			label2.TabIndex = 84;
			label2.Text = "Numbers";
			// 
			// lblGuide
			// 
			lblGuide.AutoSize = true;
			lblGuide.Location = new Point(716, 82);
			lblGuide.Name = "lblGuide";
			lblGuide.Size = new Size(0, 25);
			lblGuide.TabIndex = 85;
			// 
			// frmFollowTheLeader
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(955, 450);
			Controls.Add(lblGuide);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(txtNumbers);
			Controls.Add(txtColours);
			Name = "frmFollowTheLeader";
			Text = "Follow The Leader";
			Load += frmFollowTheLeader_Load;
			Controls.SetChildIndex(txtColours, 0);
			Controls.SetChildIndex(txtNumbers, 0);
			Controls.SetChildIndex(label1, 0);
			Controls.SetChildIndex(label2, 0);
			Controls.SetChildIndex(lblGuide, 0);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox txtColours;
		private TextBox txtNumbers;
		private Label label1;
		private Label label2;
		private Label lblGuide;
	}
}