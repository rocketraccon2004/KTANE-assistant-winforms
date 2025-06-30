using KTANE_Assistant.Modules;

namespace KTANE_Assistant.Forms;

public partial class frmWireSequences : Form
{
    private WireSequences module;

    public frmWireSequences()
    {
        InitializeComponent();
        module = new WireSequences();
    }

    private void btnSolve_Click(object sender, EventArgs e)
    {
        var colour1 = cbWire1Colour.Text;
        var colour2 = cbWire2Colour.Text;
        var colour3 = cbWire3Colour.Text;

        var letter1 = cbWire1End.Text;
        var letter2 = cbWire2End.Text;
        var letter3 = cbWire3End.Text;

        module.setWires(colour1, colour2, colour3, letter1, letter2, letter3);
        module.Solve();
    }
}