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
        submitButton = new System.Windows.Forms.Button();
        cardinalComboBox = new System.Windows.Forms.ComboBox();
        label2 = new System.Windows.Forms.Label();
        btnBack = new System.Windows.Forms.Button();
        btnStrike = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // submitButton
        // 
        submitButton.Location = new System.Drawing.Point(326, 131);
        submitButton.Margin = new System.Windows.Forms.Padding(4);
        submitButton.Name = "submitButton";
        submitButton.Size = new System.Drawing.Size(97, 45);
        submitButton.TabIndex = 12;
        submitButton.Text = "Submit";
        submitButton.UseVisualStyleBackColor = true;
        submitButton.Click += submitButton_Click;
        // 
        // cardinalComboBox
        // 
        cardinalComboBox.FormattingEnabled = true;
        cardinalComboBox.Location = new System.Drawing.Point(150, 83);
        cardinalComboBox.Margin = new System.Windows.Forms.Padding(4);
        cardinalComboBox.Name = "cardinalComboBox";
        cardinalComboBox.Size = new System.Drawing.Size(140, 28);
        cardinalComboBox.TabIndex = 8;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new System.Drawing.Point(158, 43);
        label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(140, 20);
        label2.TabIndex = 7;
        label2.Text = "What is the cardinal";
        // 
        // btnBack
        // 
        btnBack.Location = new System.Drawing.Point(24, 131);
        btnBack.Margin = new System.Windows.Forms.Padding(4);
        btnBack.Name = "btnBack";
        btnBack.Size = new System.Drawing.Size(97, 45);
        btnBack.TabIndex = 13;
        btnBack.Text = "Back";
        btnBack.UseVisualStyleBackColor = true;
        btnBack.Click += btnBack_Click;
        // 
        // btnStrike
        // 
        btnStrike.Location = new System.Drawing.Point(173, 131);
        btnStrike.Margin = new System.Windows.Forms.Padding(4);
        btnStrike.Name = "btnStrike";
        btnStrike.Size = new System.Drawing.Size(97, 45);
        btnStrike.TabIndex = 14;
        btnStrike.Text = "Strike";
        btnStrike.UseVisualStyleBackColor = true;
        btnStrike.Click += btnStrike_Click;
        // 
        // frm3dMazeStage2
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(445, 197);
        Controls.Add(btnStrike);
        Controls.Add(btnBack);
        Controls.Add(submitButton);
        Controls.Add(cardinalComboBox);
        Controls.Add(label2);
        Text = "KTANE Assistant";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button btnStrike;

    private System.Windows.Forms.Button btnBack;

    #endregion

    private System.Windows.Forms.Button submitButton;
    private ComboBox cardinalComboBox;
        private Label label2;
}