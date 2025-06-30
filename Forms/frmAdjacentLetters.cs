using KTANE_Assistant.Modules;

namespace KTANE_Assistant.Forms;

public partial class frmAdjacentLetters : Form
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

    private void btnReset_Click(object sender, EventArgs e)
    {
        foreach (Control c in tableLayoutPanel1.Controls)
        {
            c.Text = string.Empty;
        }
        txt11.Select();
    }

    private void frmAdjacentLetters_Load(object sender, EventArgs e)
    {
        txt11.Select();
    }
}