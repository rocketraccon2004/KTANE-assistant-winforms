namespace KTANE_Assistant.Forms
{
	partial class frmAlphabet
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlphabet));
			tableLayoutPanel1 = new TableLayoutPanel();
			txtLetter4 = new TextBox();
			txtLetter3 = new TextBox();
			txtLetter2 = new TextBox();
			txtLetter1 = new TextBox();
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
			resources.ApplyResources(tableLayoutPanel1, "tableLayoutPanel1");
			tableLayoutPanel1.Controls.Add(txtLetter4, 1, 1);
			tableLayoutPanel1.Controls.Add(txtLetter3, 0, 1);
			tableLayoutPanel1.Controls.Add(txtLetter2, 1, 0);
			tableLayoutPanel1.Controls.Add(txtLetter1, 0, 0);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			// 
			// txtLetter4
			// 
			resources.ApplyResources(txtLetter4, "txtLetter4");
			txtLetter4.Name = "txtLetter4";
			// 
			// txtLetter3
			// 
			resources.ApplyResources(txtLetter3, "txtLetter3");
			txtLetter3.Name = "txtLetter3";
			// 
			// txtLetter2
			// 
			resources.ApplyResources(txtLetter2, "txtLetter2");
			txtLetter2.Name = "txtLetter2";
			// 
			// txtLetter1
			// 
			resources.ApplyResources(txtLetter1, "txtLetter1");
			txtLetter1.Name = "txtLetter1";
			// 
			// button1
			// 
			resources.ApplyResources(button1, "button1");
			button1.Name = "button1";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// frmAlphabet
			// 
			resources.ApplyResources(this, "$this");
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(button1);
			Controls.Add(tableLayoutPanel1);
			Name = "frmAlphabet";
			Controls.SetChildIndex(btnSolve, 0);
			Controls.SetChildIndex(btnStrike, 0);
			Controls.SetChildIndex(btnBack, 0);
			Controls.SetChildIndex(tableLayoutPanel1, 0);
			Controls.SetChildIndex(button1, 0);
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel tableLayoutPanel1;
		private TextBox txtLetter1;
		private TextBox txtLetter4;
		private TextBox txtLetter3;
		private TextBox txtLetter2;
		private Button button1;
	}
}