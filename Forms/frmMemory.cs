using KTANE_Assistant.Modules;
using System.Windows.Forms;

namespace KTANE_Assistant.Forms;

public partial class frmMemory : Form
{
    private Memory module;

    public frmMemory()
    {
        InitializeComponent();
    }

    private void updateLabel()
    {
        lblRound.Text = $"Round {module.round} of 5";
    }

    private void btnBack_Click(object sender, EventArgs e)
    {
        if (module.round == 1)
        {
            Program.switchForm(Utils.getMainForm());
            return;
        }

        module.round--;
        updateLabel();
    }

    private void btnSolve_Click(object sender, EventArgs e)
    {
        module.setTextForRound(txtDisplay.Text, txtNum1.Text, txtNum2.Text, txtNum3.Text, txtNum4.Text);
        module.Solve();
        updateLabel();
        resetTextBoxes();
    }

    private void frmMemory_Load(object sender, EventArgs e)
    {
        module = new Memory(new List<TextBox> { txtNum1, txtNum2, txtNum3, txtNum4 }, this);
        updateLabel();
    }

    private void btnReset_Click(object sender, EventArgs e)
    {
        resetModule();
    }

    private void resetTextBoxes()
    {
        txtDisplay.Text = string.Empty;
        txtNum1.Text = string.Empty;
        txtNum2.Text = string.Empty;
        txtNum3.Text = string.Empty;
        txtNum4.Text = string.Empty;
        txtDisplay.Select();
    }

    private void TextBox_TextChanged(object sender, EventArgs e)
    {
        TextBox tb = (TextBox)sender;
        var tabIndex = tb.TabIndex;
        var controls = Controls.Cast<Control>().Where(r => r.TabIndex > tabIndex && r is TextBox);
        if (controls.Any())
        {
            controls.OrderBy(r => r.TabIndex).First().Select();
        }
    }

    public void resetModule()
    {
        resetTextBoxes();
        module.round = 1;
        updateLabel();
    }
}