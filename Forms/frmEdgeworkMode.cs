using Newtonsoft.Json;

namespace KTANE_Assistant.Forms;

#pragma warning disable CS8604 // Possible null reference argument.
public partial class frmEdgeworkMode : ModuleForm
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
        Assistant.instance.bomb = JsonConvert.DeserializeObject<Bomb>(json);
        sr.Close();
        Program.switchForm(Utils.getMainForm());
    }

    private void manualButton_Click(object sender, EventArgs e)
    {
        Program.switchForm(Utils.SelectModuleForm("Edgework Input"));
    }

    private void frmEdgeworkSelection_Load(object sender, EventArgs e)
    {
        Assistant.init();
    }
}