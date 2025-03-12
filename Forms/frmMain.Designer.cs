namespace KTANE_Assistant.Forms;


partial class frmMain
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
		dropDownModules = new ComboBox();
		label1 = new Label();
		btnChangeEdgework = new Button();
		btnSaveEdgework = new Button();
		button1 = new Button();
		SuspendLayout();
		// 
		// btnBack
		// 
		btnBack.Location = new Point(84, 135);
		btnBack.Margin = new Padding(7, 10, 7, 10);
		btnBack.Size = new Size(248, 131);
		// 
		// btnStrike
		// 
		btnStrike.Location = new Point(16, 328);
		btnStrike.Margin = new Padding(7, 10, 7, 10);
		btnStrike.Size = new Size(276, 58);
		// 
		// btnSolve
		// 
		btnSolve.Location = new Point(84, 135);
		btnSolve.Margin = new Padding(7, 10, 7, 10);
		btnSolve.Size = new Size(248, 131);
		// 
		// dropDownModules
		// 
		dropDownModules.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		dropDownModules.FormattingEnabled = true;
		dropDownModules.Items.AddRange(new object[] { "3d Maze", "Adjacent Letters", "Adventure Game", "Alphabet", "Anagrams", "Battleships", "Blind Alley", "Button", "Colour Flash", "Complicated Wires", "Follow the Leader", "Keypads", "Knob", "LED Encryption", "Maze", "Memory", "Password", "Simon Says", "Skewed Slots", "Wire Sequences", "Wires", "Who's On First" });
		dropDownModules.Location = new Point(227, 85);
		dropDownModules.Margin = new Padding(4, 5, 4, 5);
		dropDownModules.Name = "dropDownModules";
		dropDownModules.Size = new Size(360, 37);
		dropDownModules.TabIndex = 0;
		// 
		// label1
		// 
		label1.BackColor = Color.Transparent;
		label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		label1.Location = new Point(16, 85);
		label1.Margin = new Padding(4, 0, 4, 0);
		label1.Name = "label1";
		label1.Size = new Size(204, 75);
		label1.TabIndex = 1;
		label1.Text = "Select a module:";
		// 
		// btnChangeEdgework
		// 
		btnChangeEdgework.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		btnChangeEdgework.Location = new Point(16, 252);
		btnChangeEdgework.Margin = new Padding(4, 5, 4, 5);
		btnChangeEdgework.Name = "btnChangeEdgework";
		btnChangeEdgework.Size = new Size(276, 58);
		btnChangeEdgework.TabIndex = 2;
		btnChangeEdgework.Text = "Change Edgework";
		btnChangeEdgework.UseVisualStyleBackColor = true;
		btnChangeEdgework.Click += btnChangeEdgework_Click;
		// 
		// btnSaveEdgework
		// 
		btnSaveEdgework.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		btnSaveEdgework.Location = new Point(312, 252);
		btnSaveEdgework.Margin = new Padding(4, 5, 4, 5);
		btnSaveEdgework.Name = "btnSaveEdgework";
		btnSaveEdgework.Size = new Size(276, 58);
		btnSaveEdgework.TabIndex = 4;
		btnSaveEdgework.Text = "Save Edgework";
		btnSaveEdgework.UseVisualStyleBackColor = true;
		btnSaveEdgework.Click += saveEdgeworkButton_Click;
		// 
		// button1
		// 
		button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		button1.Location = new Point(312, 328);
		button1.Margin = new Padding(4, 5, 4, 5);
		button1.Name = "button1";
		button1.Size = new Size(276, 58);
		button1.TabIndex = 6;
		button1.Text = "Select Module";
		button1.UseVisualStyleBackColor = true;
		button1.Click += btnSelect_Click;
		// 
		// frmMain
		// 
		AutoScaleDimensions = new SizeF(10F, 25F);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(617, 396);
		Controls.Add(button1);
		Controls.Add(btnSaveEdgework);
		Controls.Add(btnChangeEdgework);
		Controls.Add(label1);
		Controls.Add(dropDownModules);
		Margin = new Padding(4, 5, 4, 5);
		Name = "frmMain";
		Text = "KTANE Assistant";
		Controls.SetChildIndex(dropDownModules, 0);
		Controls.SetChildIndex(label1, 0);
		Controls.SetChildIndex(btnChangeEdgework, 0);
		Controls.SetChildIndex(btnSaveEdgework, 0);
		Controls.SetChildIndex(button1, 0);
		Controls.SetChildIndex(btnSolve, 0);
		Controls.SetChildIndex(btnStrike, 0);
		Controls.SetChildIndex(btnBack, 0);
		ResumeLayout(false);
	}

	private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button btnSaveEdgework;

    private System.Windows.Forms.Button btnChangeEdgework;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.ComboBox dropDownModules;

    #endregion
}