namespace KTANE_Assistant.Forms;
    partial class frm3dMazeStage2
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
		submitButton = new Button();
		moduleSelectionButton = new Button();
		cardinalComboBox = new ComboBox();
		label2 = new Label();
		SuspendLayout();
		// 
		// btnBack
		// 
		btnBack.Location = new Point(172, 218);
		btnBack.Margin = new Padding(8, 10, 8, 10);
		btnBack.Size = new Size(143, 79);
		btnBack.Click += btnBack_Click;
		// 
		// btnStrike
		// 
		btnStrike.Location = new Point(322, 218);
		btnStrike.Margin = new Padding(8, 10, 8, 10);
		btnStrike.Size = new Size(130, 78);
		// 
		// btnSolve
		// 
		btnSolve.Location = new Point(721, 532);
		btnSolve.Margin = new Padding(8, 10, 8, 10);
		btnSolve.Size = new Size(279, 131);
		// 
		// submitButton
		// 
		submitButton.Location = new Point(465, 218);
		submitButton.Margin = new Padding(5, 6, 5, 6);
		submitButton.Name = "submitButton";
		submitButton.Size = new Size(139, 75);
		submitButton.TabIndex = 12;
		submitButton.Text = "Submit";
		submitButton.UseVisualStyleBackColor = true;
		submitButton.Click += submitButton_Click;
		// 
		// moduleSelectionButton
		// 
		moduleSelectionButton.Location = new Point(20, 221);
		moduleSelectionButton.Margin = new Padding(5, 6, 5, 6);
		moduleSelectionButton.Name = "moduleSelectionButton";
		moduleSelectionButton.Size = new Size(139, 75);
		moduleSelectionButton.TabIndex = 9;
		moduleSelectionButton.Text = "Module Selection";
		moduleSelectionButton.UseVisualStyleBackColor = true;
		moduleSelectionButton.Click += moduleSelectionButton_Click;
		// 
		// cardinalComboBox
		// 
		cardinalComboBox.FormattingEnabled = true;
		cardinalComboBox.Location = new Point(214, 139);
		cardinalComboBox.Margin = new Padding(5, 6, 5, 6);
		cardinalComboBox.Name = "cardinalComboBox";
		cardinalComboBox.Size = new Size(199, 33);
		cardinalComboBox.TabIndex = 8;
		// 
		// label2
		// 
		label2.AutoSize = true;
		label2.Location = new Point(225, 72);
		label2.Margin = new Padding(5, 0, 5, 0);
		label2.Name = "label2";
		label2.Size = new Size(167, 25);
		label2.TabIndex = 7;
		label2.Text = "What is the cardinal";
		// 
		// frm3dMazeStage2
		// 
		AutoScaleDimensions = new SizeF(10F, 25F);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(636, 328);
		Controls.Add(submitButton);
		Controls.Add(moduleSelectionButton);
		Controls.Add(cardinalComboBox);
		Controls.Add(label2);
		Margin = new Padding(4, 5, 4, 5);
		Name = "frm3dMazeStage2";
		Text = "KTANE Bot by Hawker";
		Controls.SetChildIndex(label2, 0);
		Controls.SetChildIndex(cardinalComboBox, 0);
		Controls.SetChildIndex(moduleSelectionButton, 0);
		Controls.SetChildIndex(submitButton, 0);
		Controls.SetChildIndex(btnSolve, 0);
		Controls.SetChildIndex(btnStrike, 0);
		Controls.SetChildIndex(btnBack, 0);
		ResumeLayout(false);
		PerformLayout();
	}

	#endregion

	private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button moduleSelectionButton;
        private ComboBox cardinalComboBox;
        private Label label2;
}