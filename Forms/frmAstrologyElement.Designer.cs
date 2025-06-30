using System.ComponentModel;

namespace KTANE_Assistant.Forms;

partial class frmAstrologyElement
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
        ComponentResourceManager resources = new ComponentResourceManager(typeof(frmAstrologyElement));
        this.btnFire = new Button();
        btnAir = new Button();
        this.btnWater = new Button();
        this.btnEarth = new Button();
        SuspendLayout();
        // 
        // btnFire
        // 
        this.btnFire.BackColor = Color.White;
        this.btnFire.Image = (Image)resources.GetObject("btnFire.Image");
        this.btnFire.Location = new Point(56, 257);
        this.btnFire.Name = "btnFire";
        this.btnFire.Size = new Size(143, 137);
        this.btnFire.TabIndex = 25;
        this.btnFire.UseVisualStyleBackColor = false;
        this.btnFire.Click += this.select;
        // 
        // btnAir
        // 
        btnAir.BackColor = Color.White;
        btnAir.Image = (Image)resources.GetObject("btnAir.Image");
        btnAir.Location = new Point(221, 257);
        btnAir.Name = "btnAir";
        btnAir.Size = new Size(143, 137);
        btnAir.TabIndex = 24;
        btnAir.UseVisualStyleBackColor = false;
        btnAir.Click += select;
        // 
        // btnWater
        // 
        this.btnWater.BackColor = Color.White;
        this.btnWater.Image = (Image)resources.GetObject("btnWater.Image");
        this.btnWater.Location = new Point(221, 68);
        this.btnWater.Name = "btnWater";
        this.btnWater.Size = new Size(143, 137);
        this.btnWater.TabIndex = 23;
        this.btnWater.UseVisualStyleBackColor = false;
        this.btnWater.Click += this.select;
        // 
        // btnEarth
        // 
        this.btnEarth.BackColor = Color.White;
        this.btnEarth.Image = (Image)resources.GetObject("btnEarth.Image");
        this.btnEarth.Location = new Point(56, 68);
        this.btnEarth.Name = "btnEarth";
        this.btnEarth.Size = new Size(143, 137);
        this.btnEarth.TabIndex = 22;
        this.btnEarth.UseVisualStyleBackColor = false;
        this.btnEarth.Click += this.select;
        // 
        // frmAstrologyElement
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(466, 466);
        Controls.Add(this.btnFire);
        Controls.Add(btnAir);
        Controls.Add(this.btnWater);
        Controls.Add(this.btnEarth);
        Name = "frmAstrologyElement";
        Text = "Astrology";
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button btnAir;
    private System.Windows.Forms.Button btnEarth;
    private System.Windows.Forms.Button btnFire;
    private System.Windows.Forms.Button btnWater;


    #endregion
}