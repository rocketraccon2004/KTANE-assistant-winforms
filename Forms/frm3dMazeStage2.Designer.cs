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
        // submitButton
        // 
        submitButton.Location = new Point(326, 131);
        submitButton.Margin = new Padding(4, 4, 4, 4);
        submitButton.Name = "submitButton";
        submitButton.Size = new Size(97, 45);
        submitButton.TabIndex = 12;
        submitButton.Text = "Submit";
        submitButton.UseVisualStyleBackColor = true;
        submitButton.Click += submitButton_Click;
        // 
        // moduleSelectionButton
        // 
        moduleSelectionButton.Location = new Point(14, 133);
        moduleSelectionButton.Margin = new Padding(4, 4, 4, 4);
        moduleSelectionButton.Name = "moduleSelectionButton";
        moduleSelectionButton.Size = new Size(97, 45);
        moduleSelectionButton.TabIndex = 9;
        moduleSelectionButton.Text = "Module Selection";
        moduleSelectionButton.UseVisualStyleBackColor = true;
        moduleSelectionButton.Click += moduleSelectionButton_Click;
        // 
        // cardinalComboBox
        // 
        cardinalComboBox.FormattingEnabled = true;
        cardinalComboBox.Location = new Point(150, 83);
        cardinalComboBox.Margin = new Padding(4, 4, 4, 4);
        cardinalComboBox.Name = "cardinalComboBox";
        cardinalComboBox.Size = new Size(140, 23);
        cardinalComboBox.TabIndex = 8;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(158, 43);
        label2.Margin = new Padding(4, 0, 4, 0);
        label2.Name = "label2";
        label2.Size = new Size(111, 15);
        label2.TabIndex = 7;
        label2.Text = "What is the cardinal";
        // 
        // frm3dMazeStage2
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(445, 197);
        Controls.Add(submitButton);
        Controls.Add(moduleSelectionButton);
        Controls.Add(cardinalComboBox);
        Controls.Add(label2);
        Margin = new Padding(3, 3, 3, 3);
        Name = "frm3dMazeStage2";
        Text = "KTANE Assistant";
        Controls.SetChildIndex(label2, 0);
        Controls.SetChildIndex(cardinalComboBox, 0);
        Controls.SetChildIndex(moduleSelectionButton, 0);
        Controls.SetChildIndex(submitButton, 0);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button moduleSelectionButton;
        private ComboBox cardinalComboBox;
        private Label label2;
}