using KTANE_Assistant.Modules;

namespace KTANE_Assistant.Forms;

public partial class frmLEDEncryption : ModuleForm
{
    public frmLEDEncryption()
    {
        InitializeComponent();
    }

    private void btnSolve_Click(object sender, EventArgs e)
    {
        var module = new LEDEncryption();
        var multiplier = 0;
        var one = textBox1.Text[0];
        var two = textBox2.Text[0];
        var three = textBox3.Text[0];
        var four = textBox4.Text[0];

        if (rbRed.Checked) multiplier = 2;
        else if (rbGreen.Checked) multiplier = 3;
        else if (rbBlue.Checked) multiplier = 4;
        else if (rbYellow.Checked) multiplier = 5;
        else if (rbPurple.Checked) multiplier = 6;
        else if (rbOrange.Checked) multiplier = 7;


        var values = module.Solve(multiplier, one, two, three, four);
        List<int> origValues =
        [
            one - 65,
            two - 65,
            three - 65,
            four - 65
        ];

        if (values[0] == origValues[3])
            textBox1.BackColor = Color.Green;
        else if (values[1] == origValues[2])
            textBox2.BackColor = Color.Green;
        else if (values[2] == origValues[1])
            textBox3.BackColor = Color.Green;
        else if (values[3] == origValues[1])
            textBox4.BackColor = Color.Green;
        else
            Utils.throwError("Something went wrong");
    }

    private void button1_Click(object sender, EventArgs e)
    {
        textBox1.Text = string.Empty;
        textBox2.Text = string.Empty;
        textBox3.Text = string.Empty;
        textBox4.Text = string.Empty;

        textBox1.BackColor = Color.White;
        textBox2.BackColor = Color.White;
        textBox3.BackColor = Color.White;
        textBox4.BackColor = Color.White;
    }
}