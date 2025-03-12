using Newtonsoft.Json;

namespace KTANE_Assistant.Forms;

#pragma warning disable CS8604 // Possible null reference argument.
public partial class frmMain : ModuleForm
{
    public frmMain()
    {
        InitializeComponent();
        btnSolve.Visible = false;
        btnBack.Visible = false;
    }

    private void saveEdgeworkButton_Click(object sender, EventArgs e)
    {
        StreamWriter sw = new StreamWriter("Edgework.json");
        JsonSerializer serializer = new JsonSerializer();
        serializer.NullValueHandling = NullValueHandling.Ignore;
        JsonWriter writer = new JsonTextWriter(sw);
        serializer.Serialize(writer, Assistant.instance.bomb);
        MessageBox.Show("Saved Edgework");
    }

    private void btnChangeEdgework_Click(object sender, EventArgs e)
    {
        Assistant.instance.strikes = 0;
        Program.switchForm(Utils.SelectModuleForm("Edgework Input"));
    }

    private void btnSelect_Click(object sender, EventArgs e)
    {
        Program.switchForm(Utils.SelectModuleForm(dropDownModules.Text));
    }
}