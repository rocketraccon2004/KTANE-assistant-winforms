using KTANE_Assistant.Modules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Button = System.Windows.Forms.Button;

namespace KTANE_Assistant.Forms
{
    public partial class frmBinaryLEDs : Form
    {
        BinaryLEDs module;

        public frmBinaryLEDs()
        {
            InitializeComponent();
        }
        private void ToggleLED(object sender, EventArgs e)
        {
            Button LED = (Button)sender;
            if (LED.BackColor == Color.Red)
            {
                LED.BackColor = Color.Lime;
            }
            else
            {
                LED.BackColor = Color.Red;
            }
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            StringBuilder strBinary = new StringBuilder();
            Button[] leds = { btnLED5, btnLED4, btnLED3, btnLED2, btnLED1 };

            foreach (Button led in leds)
            {
                strBinary.Append(led.BackColor == Color.Lime ? "1" : "0");
            }

            int binary = Convert.ToInt32(strBinary.ToString(), 2);

            module.solve(binary);
        }

        private void frmBinaryLEDs_Load(object sender, EventArgs e)
        {
            module = new BinaryLEDs();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            module = new BinaryLEDs();
        }
    }
}
