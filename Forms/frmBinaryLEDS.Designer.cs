namespace KTANE_Assistant.Forms
{
    partial class frmBinaryLEDs
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
            btnLED5 = new Button();
            btnLED1 = new Button();
            btnLED2 = new Button();
            btnLED3 = new Button();
            btnLED4 = new Button();
            btnReset = new Button();
            SuspendLayout();
            // 
            // btnLED5
            // 
            btnLED5.BackColor = Color.Red;
            btnLED5.Location = new Point(39, 24);
            btnLED5.Name = "btnLED5";
            btnLED5.Size = new Size(80, 18);
            btnLED5.TabIndex = 82;
            btnLED5.Text = "\r\n";
            btnLED5.UseVisualStyleBackColor = false;
            btnLED5.Click += ToggleLED;
            // 
            // btnLED1
            // 
            btnLED1.BackColor = Color.Red;
            btnLED1.Location = new Point(414, 24);
            btnLED1.Name = "btnLED1";
            btnLED1.Size = new Size(80, 18);
            btnLED1.TabIndex = 83;
            btnLED1.Text = "\r\n";
            btnLED1.UseVisualStyleBackColor = false;
            btnLED1.Click += ToggleLED;
            // 
            // btnLED2
            // 
            btnLED2.BackColor = Color.Red;
            btnLED2.Location = new Point(328, 24);
            btnLED2.Name = "btnLED2";
            btnLED2.Size = new Size(80, 18);
            btnLED2.TabIndex = 84;
            btnLED2.Text = "\r\n";
            btnLED2.UseVisualStyleBackColor = false;
            btnLED2.Click += ToggleLED;
            // 
            // btnLED3
            // 
            btnLED3.BackColor = Color.Red;
            btnLED3.Location = new Point(231, 24);
            btnLED3.Name = "btnLED3";
            btnLED3.Size = new Size(80, 18);
            btnLED3.TabIndex = 85;
            btnLED3.Text = "\r\n";
            btnLED3.UseVisualStyleBackColor = false;
            btnLED3.Click += ToggleLED;
            // 
            // btnLED4
            // 
            btnLED4.BackColor = Color.Red;
            btnLED4.Location = new Point(136, 24);
            btnLED4.Name = "btnLED4";
            btnLED4.Size = new Size(80, 18);
            btnLED4.TabIndex = 86;
            btnLED4.Text = "\r\n";
            btnLED4.UseVisualStyleBackColor = false;
            btnLED4.Click += ToggleLED;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReset.Location = new Point(562, 226);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(156, 63);
            btnReset.TabIndex = 87;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += this.btnReset_Click;
            // 
            // frmBinaryLEDs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 299);
            Controls.Add(btnReset);
            Controls.Add(btnLED4);
            Controls.Add(btnLED3);
            Controls.Add(btnLED2);
            Controls.Add(btnLED1);
            Controls.Add(btnLED5);
            Name = "frmBinaryLEDs";
            Text = "Binary LEDS";
            Load += frmBinaryLEDs_Load;
            Controls.SetChildIndex(btnLED5, 0);
            Controls.SetChildIndex(btnLED1, 0);
            Controls.SetChildIndex(btnLED2, 0);
            Controls.SetChildIndex(btnLED3, 0);
            Controls.SetChildIndex(btnLED4, 0);
            Controls.SetChildIndex(btnReset, 0);
            ResumeLayout(false);
        }

        #endregion

        private Button btnLED5;
        private Button btnLED1;
        private Button btnLED2;
        private Button btnLED3;
        private Button btnLED4;
        private Button btnReset;
    }
}