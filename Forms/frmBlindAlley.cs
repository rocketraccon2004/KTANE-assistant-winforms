using KTANE_Assistant.Modules;

namespace KTANE_Assistant.Forms;

public partial class frmBlindAlley : ModuleForm
{
    public frmBlindAlley()
    {
        InitializeComponent();
        btnSolve.Visible = false;
    }

    private void frmBlindAlley_Load(object sender, EventArgs e)
    {
        var module = new blindAlley();
        var toPress = module.Solve();
        if (toPress.Contains(1))
            button1.BackColor = Color.Green;
        else
            button1.BackColor = Color.Red;
        if (toPress.Contains(2))
            button2.BackColor = Color.Green;
        else
            button2.BackColor = Color.Red;
        if (toPress.Contains(3))
            button3.BackColor = Color.Green;
        else
            button3.BackColor = Color.Red;
        if (toPress.Contains(4))
            button4.BackColor = Color.Green;
        else
            button4.BackColor = Color.Red;
        if (toPress.Contains(5))
            button5.BackColor = Color.Green;
        else
            button5.BackColor = Color.Red;
        if (toPress.Contains(6))
            button6.BackColor = Color.Green;
        else
            button6.BackColor = Color.Red;
        if (toPress.Contains(7))
            button7.BackColor = Color.Green;
        else
            button7.BackColor = Color.Red;
        if (toPress.Contains(8))
            button8.BackColor = Color.Green;
        else
            button8.BackColor = Color.Red;
    }
}