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
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            txtLetter4 = new System.Windows.Forms.TextBox();
            txtLetter3 = new System.Windows.Forms.TextBox();
            txtLetter2 = new System.Windows.Forms.TextBox();
            txtLetter1 = new System.Windows.Forms.TextBox();
            btnReset = new System.Windows.Forms.Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Controls.Add(txtLetter4, 1, 1);
            tableLayoutPanel1.Controls.Add(txtLetter3, 0, 1);
            tableLayoutPanel1.Controls.Add(txtLetter2, 1, 0);
            tableLayoutPanel1.Controls.Add(txtLetter1, 0, 0);
            resources.ApplyResources(tableLayoutPanel1, "tableLayoutPanel1");
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // txtLetter4
            // 
            resources.ApplyResources(txtLetter4, "txtLetter4");
            txtLetter4.Name = "txtLetter4";
            txtLetter4.TextChanged += TextBox_TextChanged;
            // 
            // txtLetter3
            // 
            resources.ApplyResources(txtLetter3, "txtLetter3");
            txtLetter3.Name = "txtLetter3";
            txtLetter3.TextChanged += TextBox_TextChanged;
            // 
            // txtLetter2
            // 
            resources.ApplyResources(txtLetter2, "txtLetter2");
            txtLetter2.Name = "txtLetter2";
            txtLetter2.TextChanged += TextBox_TextChanged;
            // 
            // txtLetter1
            // 
            resources.ApplyResources(txtLetter1, "txtLetter1");
            txtLetter1.Name = "txtLetter1";
            txtLetter1.TextChanged += TextBox_TextChanged;
            // 
            // btnReset
            // 
            resources.ApplyResources(btnReset, "btnReset");
            btnReset.Name = "btnReset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // frmAlphabet
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(btnReset);
            Controls.Add(tableLayoutPanel1);
            Load += frmAlphabet_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TextBox txtLetter1;
		private System.Windows.Forms.TextBox txtLetter4;
		private System.Windows.Forms.TextBox txtLetter3;
		private System.Windows.Forms.TextBox txtLetter2;
		private Button btnReset;
	}
}