using KTANE_Assistant.Modules;

namespace KTANE_Assistant.Forms;

public partial class frmComplicatedWires : ModuleForm
{
    private ComplicatedWires module;

    public frmComplicatedWires()
    {
        InitializeComponent();
    }

    private void btnSolve_Click(object sender, EventArgs e)
    {
        module = new ComplicatedWires(cbRedWire.Checked, cbBlueWire.Checked, cbLED.Checked, cbStar.Checked);
        module.Solve();
    }
}