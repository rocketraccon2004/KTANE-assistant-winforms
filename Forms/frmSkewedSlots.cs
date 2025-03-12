using KTANE_Assistant.Modules;

namespace KTANE_Assistant.Forms;

public partial class frmSkewedSlots : ModuleForm
{
    private SkewedSlots Module;
    private bool solving;

    public frmSkewedSlots()
    {
        InitializeComponent();
    }

    private void btnSolve_Click(object sender, EventArgs e)
    {
        Module = new SkewedSlots();
        solving = true;
        txtSlot1.Text = Module.setSlot(1, txtSlot1.Text);
        txtSlot2.Text = Module.setSlot(2, txtSlot2.Text);
        txtSlot3.Text = Module.setSlot(3, txtSlot3.Text);
        solving = false;
    }

    private void txtSlot1_TextChanged(object sender, EventArgs e)
    {
        if (!solving)
        {
            txtSlot2.Text = string.Empty;
            txtSlot2.Focus();
        }
    }

    private void txtSlot2_TextChanged(object sender, EventArgs e)
    {
        if (!solving)
        {
            txtSlot3.Text = string.Empty;
            txtSlot3.Focus();
        }
    }
}