using KTANE_Assistant.Modules;

namespace KTANE_Assistant.Forms;

public partial class frmAlphabet : ModuleForm
{
    public frmAlphabet()
    {
        InitializeComponent();
    }

    private void btnSolve_Click(object sender, EventArgs e)
    {
        var module = new Alphabet(txtLetter1.Text, txtLetter2.Text, txtLetter3.Text, txtLetter4.Text);
        module.Solve();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        txtLetter1.Text = string.Empty;
        txtLetter2.Text = string.Empty;
        txtLetter3.Text = string.Empty;
        txtLetter4.Text = string.Empty;
    }
}