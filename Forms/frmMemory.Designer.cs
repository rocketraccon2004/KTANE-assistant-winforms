namespace KTANE_Assistant.Forms;

partial class frmMemory
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
        txtNum1 = new TextBox();
        txtNum2 = new TextBox();
        txtNum3 = new TextBox();
        txtNum4 = new TextBox();
        txtDisplay = new TextBox();
        btnReset = new Button();
        lblRound = new Label();
        btnBack1 = new Button();
        SuspendLayout();
        // 
        // txtNum1
        // 
        txtNum1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtNum1.Location = new Point(174, 136);
        txtNum1.Margin = new Padding(4, 3, 4, 3);
        txtNum1.Name = "txtNum1";
        txtNum1.Size = new Size(45, 29);
        txtNum1.TabIndex = 81;
        txtNum1.TextAlign = HorizontalAlignment.Center;
        txtNum1.TextChanged += TextBox_TextChanged;
        // 
        // txtNum2
        // 
        txtNum2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtNum2.Location = new Point(226, 136);
        txtNum2.Margin = new Padding(4, 3, 4, 3);
        txtNum2.Name = "txtNum2";
        txtNum2.Size = new Size(45, 29);
        txtNum2.TabIndex = 82;
        txtNum2.TextAlign = HorizontalAlignment.Center;
        txtNum2.TextChanged += TextBox_TextChanged;
        // 
        // txtNum3
        // 
        txtNum3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtNum3.Location = new Point(275, 136);
        txtNum3.Margin = new Padding(4, 3, 4, 3);
        txtNum3.Name = "txtNum3";
        txtNum3.Size = new Size(45, 29);
        txtNum3.TabIndex = 83;
        txtNum3.TextAlign = HorizontalAlignment.Center;
        txtNum3.TextChanged += TextBox_TextChanged;
        // 
        // txtNum4
        // 
        txtNum4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtNum4.Location = new Point(327, 136);
        txtNum4.Margin = new Padding(4, 3, 4, 3);
        txtNum4.Name = "txtNum4";
        txtNum4.Size = new Size(45, 29);
        txtNum4.TabIndex = 84;
        txtNum4.TextAlign = HorizontalAlignment.Center;
        txtNum4.TextChanged += TextBox_TextChanged;
        // 
        // txtDisplay
        // 
        txtDisplay.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtDisplay.Location = new Point(174, 62);
        txtDisplay.Margin = new Padding(4, 3, 4, 3);
        txtDisplay.Name = "txtDisplay";
        txtDisplay.Size = new Size(197, 50);
        txtDisplay.TabIndex = 80;
        txtDisplay.TextAlign = HorizontalAlignment.Center;
        txtDisplay.TextChanged += TextBox_TextChanged;
        // 
        // btnReset
        // 
        btnReset.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnReset.Location = new Point(267, 244);
        btnReset.Name = "btnReset";
        btnReset.Size = new Size(156, 63);
        btnReset.TabIndex = 82;
        btnReset.Text = "Reset";
        btnReset.UseVisualStyleBackColor = true;
        btnReset.Click += btnReset_Click;
        // 
        // lblRound
        // 
        lblRound.AutoSize = true;
        lblRound.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lblRound.Location = new Point(174, 28);
        lblRound.Name = "lblRound";
        lblRound.Size = new Size(51, 20);
        lblRound.TabIndex = 83;
        lblRound.Text = "label1";
        lblRound.TextAlign = ContentAlignment.TopCenter;
        // 
        // btnBack1
        // 
        btnBack1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnBack1.Location = new Point(105, 244);
        btnBack1.Name = "btnBack1";
        btnBack1.Size = new Size(156, 63);
        btnBack1.TabIndex = 85;
        btnBack1.Text = "Back";
        btnBack1.UseVisualStyleBackColor = true;
        btnBack1.Click += btnBack_Click;
        // 
        // frmMemory
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(536, 334);
        Controls.Add(btnBack1);
        Controls.Add(lblRound);
        Controls.Add(btnReset);
        Controls.Add(txtDisplay);
        Controls.Add(txtNum4);
        Controls.Add(txtNum3);
        Controls.Add(txtNum2);
        Controls.Add(txtNum1);
        Margin = new Padding(4, 3, 4, 3);
        Name = "frmMemory";
        Text = "Memory";
        Load += frmMemory_Load;
        Controls.SetChildIndex(txtNum1, 0);
        Controls.SetChildIndex(txtNum2, 0);
        Controls.SetChildIndex(txtNum3, 0);
        Controls.SetChildIndex(txtNum4, 0);
        Controls.SetChildIndex(txtDisplay, 0);
        Controls.SetChildIndex(btnReset, 0);
        Controls.SetChildIndex(lblRound, 0);
        Controls.SetChildIndex(btnBack1, 0);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private TextBox txtNum1;
    private TextBox txtNum2;
    private TextBox txtNum3;
    private TextBox txtNum4;
    private TextBox txtDisplay;
    private Button btnReset;
    private Label lblRound;
    private Button btnBack1;
}