using KTANE_Assistant.Modules;

namespace KTANE_Assistant.Forms;

public partial class frmAstrology : Form
{
    public Astrology module;

    public frmAstrology()
    {
        InitializeComponent();
    }

    private void onLoad(object sender, EventArgs e)
    {
        module = new Astrology();
    }

    public void setZodiac(string zodiac)
    {
        btnZodiac.Image = getImage(zodiac);
    }

    public void setBody(string body)
    {
        btnBody.Image = getImage(body);
    }

    public void setElement(string element)
    {
        btnElement.Image = getImage(element);
    }

    private static Image getImage(string name)
    {
        return Image.FromFile($"Resources/Astrology/{name}.png");
    }

    private void btnElement_Click(object sender, EventArgs e)
    {
        frmAstrologyElement form = new frmAstrologyElement();
        form.selectElement(this);
    }

    private void btnBody_Click(object sender, EventArgs e)
    {
        frmAstrologyBody form = new frmAstrologyBody();
        form.selectBody(this);
    }

    private void btnZodiac_Click(object sender, EventArgs e)
    {
        frmAstrologyZodiac form = new frmAstrologyZodiac();
        form.selectZodiac(this);
    }

    private void btnSolve_Click(object sender, EventArgs e)
    {
        module.solve();
    }
}