using System.ComponentModel;

namespace KTANE_Assistant.Forms;

partial class frmAstrology
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        btnZodiac = new Button();
        btnBody = new Button();
        btnElement = new Button();
        SuspendLayout();
        // 
        // btnZodiac
        // 
        btnZodiac.BackColor = SystemColors.Window;
        btnZodiac.Location = new Point(447, 35);
        btnZodiac.Name = "btnZodiac";
        btnZodiac.Size = new Size(185, 138);
        btnZodiac.TabIndex = 82;
        btnZodiac.UseVisualStyleBackColor = false;
        btnZodiac.Click += btnZodiac_Click;
        // 
        // btnBody
        // 
        btnBody.BackColor = SystemColors.Window;
        btnBody.Location = new Point(256, 35);
        btnBody.Name = "btnBody";
        btnBody.Size = new Size(185, 138);
        btnBody.TabIndex = 83;
        btnBody.UseVisualStyleBackColor = false;
        btnBody.Click += btnBody_Click;
        // 
        // btnElement
        // 
        btnElement.BackColor = SystemColors.Window;
        btnElement.Location = new Point(65, 35);
        btnElement.Name = "btnElement";
        btnElement.Size = new Size(185, 138);
        btnElement.TabIndex = 84;
        btnElement.UseVisualStyleBackColor = false;
        btnElement.Click += btnElement_Click;
        // 
        // frmAstrology
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(700, 422);
        Controls.Add(btnElement);
        Controls.Add(btnBody);
        Controls.Add(btnZodiac);
        Name = "frmAstrology";
        Text = "Astrology";
        Load += onLoad;
        Controls.SetChildIndex(btnZodiac, 0);
        Controls.SetChildIndex(btnBody, 0);
        Controls.SetChildIndex(btnElement, 0);
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button btnZodiac;
    private System.Windows.Forms.Button btnBody;
    private System.Windows.Forms.Button btnElement;

    #endregion
}