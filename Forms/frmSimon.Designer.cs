namespace KTANE_Assistant.Forms;

partial class frmSimon
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
        this.label1 = new System.Windows.Forms.Label();
        this.label2 = new System.Windows.Forms.Label();
        this.label3 = new System.Windows.Forms.Label();
        this.label4 = new System.Windows.Forms.Label();
        this.txtRound1 = new System.Windows.Forms.TextBox();
        this.txtRound5 = new System.Windows.Forms.TextBox();
        this.txtRound4 = new System.Windows.Forms.TextBox();
        this.txtRound3 = new System.Windows.Forms.TextBox();
        this.txtRound2 = new System.Windows.Forms.TextBox();
        this.lblRound1 = new System.Windows.Forms.Label();
        this.lblRound2 = new System.Windows.Forms.Label();
        this.lblRound3 = new System.Windows.Forms.Label();
        this.lblRound4 = new System.Windows.Forms.Label();
        this.lblRound5 = new System.Windows.Forms.Label();
        this.SuspendLayout();
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label1.Location = new System.Drawing.Point(52, 22);
        this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(77, 25);
        this.label1.TabIndex = 75;
        this.label1.Text = "R - Red";
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label2.Location = new System.Drawing.Point(52, 98);
        this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(99, 25);
        this.label2.TabIndex = 76;
        this.label2.Text = "Y - Yellow";
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label3.Location = new System.Drawing.Point(52, 72);
        this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(98, 25);
        this.label3.TabIndex = 77;
        this.label3.Text = "G - Green";
        // 
        // label4
        // 
        this.label4.AutoSize = true;
        this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label4.Location = new System.Drawing.Point(52, 46);
        this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(81, 25);
        this.label4.TabIndex = 78;
        this.label4.Text = "B - Blue";
        // 
        // txtRound1
        // 
        this.txtRound1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.txtRound1.Location = new System.Drawing.Point(317, 19);
        this.txtRound1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        this.txtRound1.Name = "txtRound1";
        this.txtRound1.Size = new System.Drawing.Size(65, 30);
        this.txtRound1.TabIndex = 79;
        this.txtRound1.TextChanged += new System.EventHandler(this.solveRound1);
        // 
        // txtRound5
        // 
        this.txtRound5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.txtRound5.Location = new System.Drawing.Point(317, 168);
        this.txtRound5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        this.txtRound5.Name = "txtRound5";
        this.txtRound5.Size = new System.Drawing.Size(65, 30);
        this.txtRound5.TabIndex = 81;
        this.txtRound5.TextChanged += new System.EventHandler(this.solveRound5);
        // 
        // txtRound4
        // 
        this.txtRound4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.txtRound4.Location = new System.Drawing.Point(317, 133);
        this.txtRound4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        this.txtRound4.Name = "txtRound4";
        this.txtRound4.Size = new System.Drawing.Size(65, 30);
        this.txtRound4.TabIndex = 82;
        this.txtRound4.TextChanged += new System.EventHandler(this.solveRound4);
        // 
        // txtRound3
        // 
        this.txtRound3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.txtRound3.Location = new System.Drawing.Point(317, 98);
        this.txtRound3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        this.txtRound3.Name = "txtRound3";
        this.txtRound3.Size = new System.Drawing.Size(65, 30);
        this.txtRound3.TabIndex = 83;
        this.txtRound3.TextChanged += new System.EventHandler(this.solveRound3);
        // 
        // txtRound2
        // 
        this.txtRound2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.txtRound2.Location = new System.Drawing.Point(317, 56);
        this.txtRound2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        this.txtRound2.Name = "txtRound2";
        this.txtRound2.Size = new System.Drawing.Size(65, 30);
        this.txtRound2.TabIndex = 84;
        this.txtRound2.TextChanged += new System.EventHandler(this.solveRound2);
        // 
        // lblRound1
        // 
        this.lblRound1.AutoSize = true;
        this.lblRound1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.lblRound1.Location = new System.Drawing.Point(399, 22);
        this.lblRound1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        this.lblRound1.Name = "lblRound1";
        this.lblRound1.Size = new System.Drawing.Size(0, 25);
        this.lblRound1.TabIndex = 85;
        // 
        // lblRound2
        // 
        this.lblRound2.AutoSize = true;
        this.lblRound2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.lblRound2.Location = new System.Drawing.Point(401, 56);
        this.lblRound2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        this.lblRound2.Name = "lblRound2";
        this.lblRound2.Size = new System.Drawing.Size(0, 25);
        this.lblRound2.TabIndex = 86;
        // 
        // lblRound3
        // 
        this.lblRound3.AutoSize = true;
        this.lblRound3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.lblRound3.Location = new System.Drawing.Point(399, 104);
        this.lblRound3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        this.lblRound3.Name = "lblRound3";
        this.lblRound3.Size = new System.Drawing.Size(0, 25);
        this.lblRound3.TabIndex = 87;
        // 
        // lblRound4
        // 
        this.lblRound4.AutoSize = true;
        this.lblRound4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.lblRound4.Location = new System.Drawing.Point(399, 142);
        this.lblRound4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        this.lblRound4.Name = "lblRound4";
        this.lblRound4.Size = new System.Drawing.Size(0, 25);
        this.lblRound4.TabIndex = 88;
        // 
        // lblRound5
        // 
        this.lblRound5.AutoSize = true;
        this.lblRound5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.lblRound5.Location = new System.Drawing.Point(389, 179);
        this.lblRound5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        this.lblRound5.Name = "lblRound5";
        this.lblRound5.Size = new System.Drawing.Size(0, 25);
        this.lblRound5.TabIndex = 89;
        // 
        // frmSimon
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.AutoSize = true;
        this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        this.ClientSize = new System.Drawing.Size(716, 354);
        this.Controls.Add(this.lblRound5);
        this.Controls.Add(this.lblRound4);
        this.Controls.Add(this.lblRound3);
        this.Controls.Add(this.lblRound2);
        this.Controls.Add(this.lblRound1);
        this.Controls.Add(this.txtRound2);
        this.Controls.Add(this.txtRound3);
        this.Controls.Add(this.txtRound4);
        this.Controls.Add(this.txtRound5);
        this.Controls.Add(this.txtRound1);
        this.Controls.Add(this.label4);
        this.Controls.Add(this.label3);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.label1);
        this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        this.Name = "frmSimon";
        this.Text = "Simon Says";
        this.Controls.SetChildIndex(this.label1, 0);
        this.Controls.SetChildIndex(this.label2, 0);
        this.Controls.SetChildIndex(this.label3, 0);
        this.Controls.SetChildIndex(this.label4, 0);
        this.Controls.SetChildIndex(this.txtRound1, 0);
        this.Controls.SetChildIndex(this.txtRound5, 0);
        this.Controls.SetChildIndex(this.txtRound4, 0);
        this.Controls.SetChildIndex(this.txtRound3, 0);
        this.Controls.SetChildIndex(this.txtRound2, 0);
        this.Controls.SetChildIndex(this.lblRound1, 0);
        this.Controls.SetChildIndex(this.lblRound2, 0);
        this.Controls.SetChildIndex(this.lblRound3, 0);
        this.Controls.SetChildIndex(this.lblRound4, 0);
        this.Controls.SetChildIndex(this.lblRound5, 0);
        this.Controls.SetChildIndex(this.btnSolve, 0);
        this.Controls.SetChildIndex(this.btnStrike, 0);
        this.Controls.SetChildIndex(this.btnBack, 0);
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion
    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private System.Windows.Forms.TextBox txtRound1;
    private System.Windows.Forms.TextBox txtRound5;
    private System.Windows.Forms.TextBox txtRound4;
    private System.Windows.Forms.TextBox txtRound3;
    private System.Windows.Forms.TextBox txtRound2;
    private Label lblRound1;
    private Label lblRound2;
    private Label lblRound3;
    private Label lblRound4;
    private Label lblRound5;
}