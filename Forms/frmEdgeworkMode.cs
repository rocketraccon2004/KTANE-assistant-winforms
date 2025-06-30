using Newtonsoft.Json;
#pragma warning disable CS8601 // Possible null reference assignment.

namespace KTANE_Assistant.Forms;

#pragma warning disable CS8604 // Possible null reference argument.
public partial class frmEdgeworkMode : Form
{
    public frmEdgeworkMode()
    {
        InitializeComponent();
    }

    private void automaticButton_Click(object sender, EventArgs e)
    {
        if (!File.Exists("Edgework.json"))
        {
            MessageBox.Show("The Edgework.json file does not exist.", "Error - KTANE Diffuser", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            return;
        }

        var sr = new StreamReader("Edgework.json");
        var json = string.Empty;
        for (var line = 1; line <= File.ReadAllLines("Edgework.json").Length; line++) json += sr.ReadLine();
        Assistant.Instance.Bomb = JsonConvert.DeserializeObject<Bomb>(json);
        sr.Close();
        Program.switchForm(Utils.getMainForm());
    }

    private void manualButton_Click(object sender, EventArgs e)
    {
        Program.switchForm(ModuleSelector.SelectForm("Edgework Input"));
    }

    private void frmEdgeworkSelection_Load(object sender, EventArgs e)
    {
        Assistant.Init();
    }
}
#pragma warning restore CS8601 // Possible null reference assignment.