using KTANE_Assistant.Modules;

namespace KTANE_Assistant.Forms;

public partial class frmAlphabet : Form
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

    private void btnReset_Click(object sender, EventArgs e)
    {
        txtLetter1.Text = string.Empty;
        txtLetter2.Text = string.Empty;
        txtLetter3.Text = string.Empty;
        txtLetter4.Text = string.Empty;
        txtLetter1.Select();
    }

    private void TextBox_TextChanged(object sender, EventArgs e)
    {
        TextBox tb = (TextBox)sender;
        var tabIndex = tb.TabIndex;
        var controls = tableLayoutPanel1.Controls.Cast<Control>().Where(r => r.TabIndex > tabIndex);
        if (controls.Any())
        {
            controls.OrderBy(r => r.TabIndex).First().Select();
        }
    }

    private void frmAlphabet_Load(object sender, EventArgs e)
    {
        txtLetter1.Select();
    }
}