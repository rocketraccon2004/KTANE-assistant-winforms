using System.ComponentModel;

namespace KTANE_Assistant.Forms;

partial class frmAstrologyZodiac
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
        ComponentResourceManager resources = new ComponentResourceManager(typeof(frmAstrologyZodiac));
        btnSagittarius = new Button();
        btnCapricorn = new Button();
        btnCancer = new Button();
        btnGemini = new Button();
        btnAries = new Button();
        btnTaurus = new Button();
        btnLeo = new Button();
        btnVirgo = new Button();
        btnLibra = new Button();
        btnScorpio = new Button();
        btnAquarius = new Button();
        btnPisces = new Button();
        SuspendLayout();
        // 
        // btnSagittarius
        // 
        btnSagittarius.BackColor = Color.White;
        btnSagittarius.Image = (Image)resources.GetObject("btnSagittarius.Image");
        btnSagittarius.Location = new Point(353, 262);
        btnSagittarius.Name = "btnSagittarius";
        btnSagittarius.Size = new Size(143, 137);
        btnSagittarius.TabIndex = 25;
        btnSagittarius.UseVisualStyleBackColor = false;
        btnSagittarius.Click += select;
        // 
        // btnCapricorn
        // 
        btnCapricorn.BackColor = Color.White;
        btnCapricorn.Image = (Image)resources.GetObject("btnCapricorn.Image");
        btnCapricorn.Location = new Point(518, 262);
        btnCapricorn.Name = "btnCapricorn";
        btnCapricorn.Size = new Size(143, 137);
        btnCapricorn.TabIndex = 24;
        btnCapricorn.UseVisualStyleBackColor = false;
        btnCapricorn.Click += select;
        // 
        // btnCancer
        // 
        btnCancer.BackColor = Color.White;
        btnCancer.Image = (Image)resources.GetObject("btnCancer.Image");
        btnCancer.Location = new Point(518, 73);
        btnCancer.Name = "btnCancer";
        btnCancer.Size = new Size(143, 137);
        btnCancer.TabIndex = 23;
        btnCancer.UseVisualStyleBackColor = false;
        btnCancer.Click += select;
        // 
        // btnGemini
        // 
        btnGemini.BackColor = Color.White;
        btnGemini.Image = (Image)resources.GetObject("btnGemini.Image");
        btnGemini.Location = new Point(353, 73);
        btnGemini.Name = "btnGemini";
        btnGemini.Size = new Size(143, 137);
        btnGemini.TabIndex = 22;
        btnGemini.UseVisualStyleBackColor = false;
        btnGemini.Click += select;
        // 
        // btnAries
        // 
        btnAries.BackColor = Color.White;
        btnAries.Image = (Image)resources.GetObject("btnAries.Image");
        btnAries.Location = new Point(25, 73);
        btnAries.Name = "btnAries";
        btnAries.Size = new Size(143, 137);
        btnAries.TabIndex = 29;
        btnAries.UseVisualStyleBackColor = false;
        btnAries.Click += select;
        // 
        // btnTaurus
        // 
        btnTaurus.BackColor = Color.White;
        btnTaurus.Image = (Image)resources.GetObject("btnTaurus.Image");
        btnTaurus.Location = new Point(191, 73);
        btnTaurus.Name = "btnTaurus";
        btnTaurus.Size = new Size(143, 137);
        btnTaurus.TabIndex = 28;
        btnTaurus.UseVisualStyleBackColor = false;
        btnTaurus.Click += select;
        // 
        // btnLeo
        // 
        btnLeo.BackColor = Color.White;
        btnLeo.Image = (Image)resources.GetObject("btnLeo.Image");
        btnLeo.Location = new Point(683, 73);
        btnLeo.Name = "btnLeo";
        btnLeo.Size = new Size(143, 137);
        btnLeo.TabIndex = 27;
        btnLeo.UseVisualStyleBackColor = false;
        btnLeo.Click += select;
        // 
        // btnVirgo
        // 
        btnVirgo.BackColor = Color.White;
        btnVirgo.Image = (Image)resources.GetObject("btnVirgo.Image");
        btnVirgo.Location = new Point(850, 73);
        btnVirgo.Name = "btnVirgo";
        btnVirgo.Size = new Size(143, 137);
        btnVirgo.TabIndex = 26;
        btnVirgo.UseVisualStyleBackColor = false;
        btnVirgo.Click += select;
        // 
        // btnLibra
        // 
        btnLibra.BackColor = Color.White;
        btnLibra.Image = (Image)resources.GetObject("btnLibra.Image");
        btnLibra.Location = new Point(25, 262);
        btnLibra.Name = "btnLibra";
        btnLibra.Size = new Size(143, 137);
        btnLibra.TabIndex = 33;
        btnLibra.UseVisualStyleBackColor = false;
        btnLibra.Click += select;
        // 
        // btnScorpio
        // 
        btnScorpio.BackColor = Color.White;
        btnScorpio.Image = (Image)resources.GetObject("btnScorpio.Image");
        btnScorpio.Location = new Point(191, 262);
        btnScorpio.Name = "btnScorpio";
        btnScorpio.Size = new Size(143, 137);
        btnScorpio.TabIndex = 32;
        btnScorpio.UseVisualStyleBackColor = false;
        btnScorpio.Click += select;
        // 
        // btnAquarius
        // 
        btnAquarius.BackColor = Color.White;
        btnAquarius.Image = (Image)resources.GetObject("btnAquarius.Image");
        btnAquarius.Location = new Point(683, 262);
        btnAquarius.Name = "btnAquarius";
        btnAquarius.Size = new Size(143, 137);
        btnAquarius.TabIndex = 31;
        btnAquarius.UseVisualStyleBackColor = false;
        btnAquarius.Click += select;
        // 
        // btnPisces
        // 
        btnPisces.BackColor = Color.White;
        btnPisces.Image = (Image)resources.GetObject("btnPisces.Image");
        btnPisces.Location = new Point(850, 262);
        btnPisces.Name = "btnPisces";
        btnPisces.Size = new Size(143, 137);
        btnPisces.TabIndex = 30;
        btnPisces.UseVisualStyleBackColor = false;
        btnPisces.Click += select;
        // 
        // frmAstrologyZodiac
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1013, 466);
        Controls.Add(btnLibra);
        Controls.Add(btnScorpio);
        Controls.Add(btnAquarius);
        Controls.Add(btnPisces);
        Controls.Add(btnAries);
        Controls.Add(btnTaurus);
        Controls.Add(btnLeo);
        Controls.Add(btnVirgo);
        Controls.Add(btnSagittarius);
        Controls.Add(btnCapricorn);
        Controls.Add(btnCancer);
        Controls.Add(btnGemini);
        Name = "frmAstrologyZodiac";
        Text = "Astrology";
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button btnAries;
    private System.Windows.Forms.Button btnTaurus;
    private System.Windows.Forms.Button btnGemini;
    private System.Windows.Forms.Button btnCancer;
    private System.Windows.Forms.Button btnLeo;
    private System.Windows.Forms.Button btnVirgo;
    private System.Windows.Forms.Button btnLibra;
    private System.Windows.Forms.Button btnScorpio;
    private System.Windows.Forms.Button btnSagittarius;
    private System.Windows.Forms.Button btnCapricorn;
    private System.Windows.Forms.Button btnAquarius;
    private System.Windows.Forms.Button btnPisces;


    #endregion
}