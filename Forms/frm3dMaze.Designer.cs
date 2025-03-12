namespace KTANE_Assistant.Forms;

    partial class frm3dMaze
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
	///  Required method for Designer support - do not modify
	///  the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent()
	{
		facingWallCheckBox = new CheckBox();
		pathTextBox = new TextBox();
		label2 = new Label();
		mazeTextBox = new TextBox();
		label1 = new Label();
		SuspendLayout();
		// 
		// btnBack
		// 
		btnBack.Location = new Point(17, 780);
		btnBack.Margin = new Padding(8, 10, 8, 10);
		btnBack.Size = new Size(212, 101);
		// 
		// btnStrike
		// 
		btnStrike.Location = new Point(256, 780);
		btnStrike.Margin = new Padding(8, 10, 8, 10);
		btnStrike.Size = new Size(263, 101);
		// 
		// btnSolve
		// 
		btnSolve.Location = new Point(535, 780);
		btnSolve.Margin = new Padding(8, 10, 8, 10);
		btnSolve.Size = new Size(263, 101);
		btnSolve.Click += submitButton_Click;
		// 
		// facingWallCheckBox
		// 
		facingWallCheckBox.AutoSize = true;
		facingWallCheckBox.Location = new Point(336, 684);
		facingWallCheckBox.Margin = new Padding(4, 6, 4, 6);
		facingWallCheckBox.Name = "facingWallCheckBox";
		facingWallCheckBox.Size = new Size(126, 29);
		facingWallCheckBox.TabIndex = 19;
		facingWallCheckBox.Text = "Facing Wall";
		facingWallCheckBox.UseVisualStyleBackColor = true;
		// 
		// pathTextBox
		// 
		pathTextBox.Location = new Point(261, 594);
		pathTextBox.Margin = new Padding(6, 9, 6, 9);
		pathTextBox.Name = "pathTextBox";
		pathTextBox.Size = new Size(273, 31);
		pathTextBox.TabIndex = 18;
		// 
		// label2
		// 
		label2.AutoSize = true;
		label2.Location = new Point(176, 499);
		label2.Margin = new Padding(6, 0, 6, 0);
		label2.Name = "label2";
		label2.Size = new Size(430, 25);
		label2.TabIndex = 17;
		label2.Text = "Find a straight path and tell what is there (blanks = ?)";
		// 
		// mazeTextBox
		// 
		mazeTextBox.Location = new Point(261, 141);
		mazeTextBox.Margin = new Padding(6, 9, 6, 9);
		mazeTextBox.Name = "mazeTextBox";
		mazeTextBox.Size = new Size(273, 31);
		mazeTextBox.TabIndex = 16;
		// 
		// label1
		// 
		label1.AutoSize = true;
		label1.Location = new Point(256, 65);
		label1.Margin = new Padding(6, 0, 6, 0);
		label1.Name = "label1";
		label1.Size = new Size(270, 25);
		label1.TabIndex = 15;
		label1.Text = "What are the letters in the maze?";
		// 
		// frm3dMaze
		// 
		AutoScaleDimensions = new SizeF(10F, 25F);
		AutoScaleMode = AutoScaleMode.Font;
		AutoSize = true;
		AutoSizeMode = AutoSizeMode.GrowAndShrink;
		ClientSize = new Size(824, 900);
		Controls.Add(facingWallCheckBox);
		Controls.Add(pathTextBox);
		Controls.Add(label2);
		Controls.Add(mazeTextBox);
		Controls.Add(label1);
		Margin = new Padding(4, 5, 4, 5);
		Name = "frm3dMaze";
		Text = "KTANE Bot by Hawker";
		Controls.SetChildIndex(label1, 0);
		Controls.SetChildIndex(mazeTextBox, 0);
		Controls.SetChildIndex(label2, 0);
		Controls.SetChildIndex(pathTextBox, 0);
		Controls.SetChildIndex(facingWallCheckBox, 0);
		Controls.SetChildIndex(btnSolve, 0);
		Controls.SetChildIndex(btnStrike, 0);
		Controls.SetChildIndex(btnBack, 0);
		ResumeLayout(false);
		PerformLayout();
	}

	#endregion

	private CheckBox facingWallCheckBox;
        private TextBox pathTextBox;
        private Label label2;
        private TextBox mazeTextBox;
        private Label label1;
    }