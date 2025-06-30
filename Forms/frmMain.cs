using Newtonsoft.Json;

namespace KTANE_Assistant.Forms;

#pragma warning disable CS8604 // Possible null reference argument.
public partial class frmMain : Form
{
    public frmMain()
    {
        InitializeComponent();
    }

    private void saveEdgeworkButton_Click(object sender, EventArgs e)
    {
        string json = JsonConvert.SerializeObject(Assistant.Instance.Bomb);
        File.WriteAllText("Edgework.json", json);
        MessageBox.Show("Saved Edgework");
    }

    private void btnChangeEdgework_Click(object sender, EventArgs e)
    {
        Assistant.Instance.Strikes = 0;
        Program.switchForm(ModuleSelector.SelectForm("Edgework Input"));
    }

    private void frmMain_Load(object sender, EventArgs e)
    {
        setButtonText(0);
    }

    private void btnAG_Click(object sender, EventArgs e)
    {
        setButtonText(0);
    }
     

    private void btnHN_Click(object sender, EventArgs e)
    {
        setButtonText(1);
    }
    private void btnOU_Click(object sender, EventArgs e)
    {
        setButtonText(2);
    }

    private void btnVZ_Click(object sender, EventArgs e)
    {
        setButtonText(3);
    }

    private void selectModule(object sender, EventArgs e)
    {
        Button btn = (Button)sender;
        Program.switchForm(ModuleSelector.SelectForm(btn.Text));
    }

    private void setButtonText(int page)
    {
        List<Button> moduleButtons = tableLayoutPanel1.Controls.Cast<Button>().OrderBy(r => r.TabIndex).ToList();
        string[] moduleNames = new string[40];
        switch (page)
        {
            case 0:
                moduleNames = File.ReadAllLines(@"Resources/modules A-G.txt");
                break;
            case 1:
                moduleNames = File.ReadAllLines(@"Resources/modules H-N.txt");
                break;
            case 2:
                moduleNames = File.ReadAllLines(@"Resources/modules O-U.txt");
                break;
            case 3:
                moduleNames = File.ReadAllLines(@"Resources/modules V-Z.txt");
                break;
        }
        foreach (var button in moduleButtons)
        {
            button.Visible = true;
            try
            {
                button.Text = moduleNames[moduleButtons.IndexOf(button)];
            }
            catch (IndexOutOfRangeException)
            {
                button.Visible = false;
            }
        }
    }
}