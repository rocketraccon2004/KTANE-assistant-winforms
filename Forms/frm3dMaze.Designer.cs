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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        facingWallCheckBox = new System.Windows.Forms.CheckBox();
        pathTextBox = new System.Windows.Forms.TextBox();
        label2 = new System.Windows.Forms.Label();
        mazeTextBox = new System.Windows.Forms.TextBox();
        label1 = new System.Windows.Forms.Label();
        btnBack = new System.Windows.Forms.Button();
        btnStrike = new System.Windows.Forms.Button();
        btnSolve = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // facingWallCheckBox
        // 
        facingWallCheckBox.AutoSize = true;
        facingWallCheckBox.Location = new System.Drawing.Point(235, 410);
        facingWallCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        facingWallCheckBox.Name = "facingWallCheckBox";
        facingWallCheckBox.Size = new System.Drawing.Size(106, 24);
        facingWallCheckBox.TabIndex = 19;
        facingWallCheckBox.Text = "Facing Wall";
        facingWallCheckBox.UseVisualStyleBackColor = true;
        // 
        // pathTextBox
        // 
        pathTextBox.Location = new System.Drawing.Point(183, 356);
        pathTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        pathTextBox.Name = "pathTextBox";
        pathTextBox.Size = new System.Drawing.Size(192, 27);
        pathTextBox.TabIndex = 18;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new System.Drawing.Point(123, 299);
        label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(360, 20);
        label2.TabIndex = 17;
        label2.Text = "Find a straight path and tell what is there (blanks = ?)";
        // 
        // mazeTextBox
        // 
        mazeTextBox.Location = new System.Drawing.Point(183, 85);
        mazeTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        mazeTextBox.Name = "mazeTextBox";
        mazeTextBox.Size = new System.Drawing.Size(192, 27);
        mazeTextBox.TabIndex = 16;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new System.Drawing.Point(179, 39);
        label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(227, 20);
        label1.TabIndex = 15;
        label1.Text = "What are the letters in the maze?";
        // 
        // btnBack
        // 
        btnBack.Location = new System.Drawing.Point(28, 468);
        btnBack.Name = "btnBack";
        btnBack.Size = new System.Drawing.Size(151, 45);
        btnBack.TabIndex = 20;
        btnBack.Text = "Back";
        btnBack.UseVisualStyleBackColor = true;
        btnBack.Click += btnBack_Click;
        // 
        // btnStrike
        // 
        btnStrike.Location = new System.Drawing.Point(190, 468);
        btnStrike.Name = "btnStrike";
        btnStrike.Size = new System.Drawing.Size(151, 45);
        btnStrike.TabIndex = 21;
        btnStrike.Text = "Strike";
        btnStrike.UseVisualStyleBackColor = true;
        btnStrike.Click += btnStrike_Click;
        // 
        // btnSolve
        // 
        btnSolve.Location = new System.Drawing.Point(347, 468);
        btnSolve.Name = "btnSolve";
        btnSolve.Size = new System.Drawing.Size(151, 45);
        btnSolve.TabIndex = 22;
        btnSolve.Text = "Solve";
        btnSolve.UseVisualStyleBackColor = true;
        btnSolve.Click += btnSolve_Click;
        // 
        // frm3dMaze
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        AutoSize = true;
        AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        ClientSize = new System.Drawing.Size(577, 540);
        Controls.Add(btnSolve);
        Controls.Add(btnStrike);
        Controls.Add(btnBack);
        Controls.Add(facingWallCheckBox);
        Controls.Add(pathTextBox);
        Controls.Add(label2);
        Controls.Add(mazeTextBox);
        Controls.Add(label1);
        Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
        Text = "3d Maze";
        FormClosing += frm3dMaze_FormClosing;
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button btnBack;
    private System.Windows.Forms.Button btnStrike;
    private System.Windows.Forms.Button btnSolve;

    #endregion

    private CheckBox facingWallCheckBox;
        private TextBox pathTextBox;
        private Label label2;
        private TextBox mazeTextBox;
        private Label label1;
}