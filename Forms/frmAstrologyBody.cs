namespace KTANE_Assistant.Forms;

public partial class frmAstrologyBody : Form
{
    frmAstrology Form;

    public frmAstrologyBody()
    {
        InitializeComponent();
    }

    public void selectBody(frmAstrology Form)
    {
        this.Form = Form;
        Program.switchForm(this);
    }

    private void select(object sender, EventArgs e)
    {
        string Body = ((Button)sender).Name.Replace("btn", string.Empty);
        Form.module.body = Body;
        Form.setBody(Body);
        Program.switchForm(Form);
    }
}