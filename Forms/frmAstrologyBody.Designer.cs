using System.ComponentModel;

namespace KTANE_Assistant.Forms;

partial class frmAstrologyBody
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
        ComponentResourceManager resources = new ComponentResourceManager(typeof(frmAstrologyBody));
        btnSun = new Button();
        btnUranus = new Button();
        btnMoon = new Button();
        btnMercury = new Button();
        btnJupiter = new Button();
        btnMars = new Button();
        btnNeptune = new Button();
        btnPluto = new Button();
        btnSaturn = new Button();
        btnVenus = new Button();
        SuspendLayout();
        // 
        // btnSun
        // 
        btnSun.BackColor = SystemColors.Window;
        btnSun.Image = (Image)resources.GetObject("btnSun.Image");
        btnSun.Location = new Point(353, 262);
        btnSun.Name = "btnSun";
        btnSun.Size = new Size(143, 137);
        btnSun.TabIndex = 25;
        btnSun.UseVisualStyleBackColor = false;
        btnSun.Click += select;
        // 
        // btnUranus
        // 
        btnUranus.BackColor = SystemColors.Window;
        btnUranus.Image = (Image)resources.GetObject("btnUranus.Image");
        btnUranus.Location = new Point(518, 262);
        btnUranus.Name = "btnUranus";
        btnUranus.Size = new Size(143, 137);
        btnUranus.TabIndex = 24;
        btnUranus.UseVisualStyleBackColor = false;
        btnUranus.Click += select;
        // 
        // btnMoon
        // 
        btnMoon.BackColor = SystemColors.Window;
        btnMoon.Image = (Image)resources.GetObject("btnMoon.Image");
        btnMoon.Location = new Point(518, 73);
        btnMoon.Name = "btnMoon";
        btnMoon.Size = new Size(143, 137);
        btnMoon.TabIndex = 23;
        btnMoon.UseVisualStyleBackColor = false;
        btnMoon.Click += select;
        // 
        // btnMercury
        // 
        btnMercury.BackColor = SystemColors.Window;
        btnMercury.Image = (Image)resources.GetObject("btnMercury.Image");
        btnMercury.Location = new Point(353, 73);
        btnMercury.Name = "btnMercury";
        btnMercury.Size = new Size(143, 137);
        btnMercury.TabIndex = 22;
        btnMercury.UseVisualStyleBackColor = false;
        btnMercury.Click += select;
        // 
        // btnJupiter
        // 
        btnJupiter.BackColor = SystemColors.Window;
        btnJupiter.Image = (Image)resources.GetObject("btnJupiter.Image");
        btnJupiter.Location = new Point(25, 73);
        btnJupiter.Name = "btnJupiter";
        btnJupiter.Size = new Size(143, 137);
        btnJupiter.TabIndex = 29;
        btnJupiter.UseVisualStyleBackColor = false;
        btnJupiter.Click += select;
        // 
        // btnMars
        // 
        btnMars.BackColor = SystemColors.Window;
        btnMars.Image = (Image)resources.GetObject("btnMars.Image");
        btnMars.Location = new Point(191, 73);
        btnMars.Name = "btnMars";
        btnMars.Size = new Size(143, 137);
        btnMars.TabIndex = 28;
        btnMars.UseVisualStyleBackColor = false;
        btnMars.Click += select;
        // 
        // btnNeptune
        // 
        btnNeptune.BackColor = SystemColors.Window;
        btnNeptune.Image = (Image)resources.GetObject("btnNeptune.Image");
        btnNeptune.Location = new Point(683, 73);
        btnNeptune.Name = "btnNeptune";
        btnNeptune.Size = new Size(143, 137);
        btnNeptune.TabIndex = 27;
        btnNeptune.UseVisualStyleBackColor = false;
        btnNeptune.Click += select;
        // 
        // btnPluto
        // 
        btnPluto.BackColor = SystemColors.Window;
        btnPluto.Image = (Image)resources.GetObject("btnPluto.Image");
        btnPluto.Location = new Point(25, 262);
        btnPluto.Name = "btnPluto";
        btnPluto.Size = new Size(143, 137);
        btnPluto.TabIndex = 33;
        btnPluto.UseVisualStyleBackColor = false;
        btnPluto.Click += select;
        // 
        // btnSaturn
        // 
        btnSaturn.BackColor = SystemColors.Window;
        btnSaturn.Image = (Image)resources.GetObject("btnSaturn.Image");
        btnSaturn.Location = new Point(191, 262);
        btnSaturn.Name = "btnSaturn";
        btnSaturn.Size = new Size(143, 137);
        btnSaturn.TabIndex = 32;
        btnSaturn.UseVisualStyleBackColor = false;
        btnSaturn.Click += select;
        // 
        // btnVenus
        // 
        btnVenus.BackColor = SystemColors.Window;
        btnVenus.Image = (Image)resources.GetObject("btnVenus.Image");
        btnVenus.Location = new Point(683, 262);
        btnVenus.Name = "btnVenus";
        btnVenus.Size = new Size(143, 137);
        btnVenus.TabIndex = 31;
        btnVenus.UseVisualStyleBackColor = false;
        btnVenus.Click += select;
        // 
        // frmAstrologyBody
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(845, 466);
        Controls.Add(btnPluto);
        Controls.Add(btnSaturn);
        Controls.Add(btnVenus);
        Controls.Add(btnJupiter);
        Controls.Add(btnMars);
        Controls.Add(btnNeptune);
        Controls.Add(btnSun);
        Controls.Add(btnUranus);
        Controls.Add(btnMoon);
        Controls.Add(btnMercury);
        Name = "frmAstrologyBody";
        Text = "Astrology";
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button btnJupiter;
    private System.Windows.Forms.Button btnMars;
    private System.Windows.Forms.Button btnMercury;
    private System.Windows.Forms.Button btnMoon;
    private System.Windows.Forms.Button btnNeptune;
    private System.Windows.Forms.Button btnPluto;
    private System.Windows.Forms.Button btnSaturn;
    private System.Windows.Forms.Button btnSun;
    private System.Windows.Forms.Button btnUranus;
    private System.Windows.Forms.Button btnVenus;


    #endregion
}