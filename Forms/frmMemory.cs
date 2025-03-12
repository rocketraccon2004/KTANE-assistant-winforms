using KTANE_Assistant.Modules;

namespace KTANE_Assistant.Forms;

public partial class frmMemory : ModuleForm
{
    private Memory module;
    private int round = 1;

    public frmMemory()
    {
        InitializeComponent();
    }

    private void updateLabel()
    {
        lblRound.Text = $"Round {round} of 5";
    }

    private void btnBack_Click(object sender, EventArgs e)
    {
        if (round == 1)
        {
            Program.switchForm(Utils.getMainForm());
            return;
        }

        round--;
        updateLabel();
    }

    private void btnSolve_Click(object sender, EventArgs e)
    {
        module.setRound(round, txtDisplay.Text, txtNum1.Text, txtNum2.Text, txtNum3.Text, txtNum4.Text);
        module.Solve();
    }

    private void frmMemory_Load(object sender, EventArgs e)
    {
        module = new Memory(new List<TextBox>{txtNum1, txtNum2, txtNum3, txtNum4});
    }
}