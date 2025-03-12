using KTANE_Assistant.Modules;

namespace KTANE_Assistant.Forms;

public partial class frmFollowTheLeader : ModuleForm
{
    public frmFollowTheLeader()
    {
        InitializeComponent();
    }

    private void btnSolve_Click(object sender, EventArgs e)
    {
        var module = new followTheLeader(txtColours.Text, txtNumbers.Text);
        module.Solve();
    }

    private void frmFollowTheLeader_Load(object sender, EventArgs e)
    {
        lblGuide.Text = @"red - r
blue - b
black - blk
white - w
green - g
yellow - y";
    }
}