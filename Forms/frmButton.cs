using Button = KTANE_Assistant.Modules.Button;

namespace KTANE_Assistant.Forms;

public partial class frmButton : Form
{
    public Button button;

    public frmButton()
    {
        InitializeComponent();
    }

    private void solve(object sender, EventArgs e)
    {
        button = new Button(dropDownColour.Text, dropDownText.Text);
        button.Solve();
    }
}