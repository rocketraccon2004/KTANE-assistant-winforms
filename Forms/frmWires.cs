using KTANE_Assistant.Modules;

namespace KTANE_Assistant.Forms;

public partial class frmWires : Form
{
    private string[] wires;

    public frmWires()
    {
        InitializeComponent();
    }

    private void btnSolve_Click(object sender, EventArgs e)
    {
        wires = new[]
        {
            comboBox1.Text,
            comboBox2.Text,
            comboBox3.Text,
            comboBox4.Text,
            comboBox5.Text,
            comboBox6.Text
        };

        var module = new Wires(wires);
        module.Solve();
    }
}