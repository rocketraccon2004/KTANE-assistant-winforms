using KTANE_Assistant.Modules;

namespace KTANE_Assistant.Forms;

public partial class frmAdjacentLetters : ModuleForm
{
    private AdjacentLetters module;

    public frmAdjacentLetters()
    {
        module = new AdjacentLetters();
        InitializeComponent();
    }

    private void btnSolve_Click(object sender, EventArgs e)
    {
        module.txts = new List<TextBox>
        {
            txt11,
            txt12,
            txt13,
            txt14,
            txt21,
            txt22,
            txt23,
            txt24,
            txt31,
            txt32,
            txt33,
            txt34
        };
        module.Solve();
    }
}