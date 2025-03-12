#pragma warning disable CS8602 // Dereference of a possibly null reference.
using KTANE_Assistant.Modules;

namespace KTANE_Assistant.Forms;

public partial class frmAdventureGame : ModuleForm
{
    private AdventureGame module = new();

    public frmAdventureGame()
    {
        InitializeComponent();
        ddMonster.SelectedIndex = 0;
    }


    private void frmAdventureGame_Load(object sender, EventArgs e)
    {
        MessageBox.Show("Use the potion");
    }

    private void btnSolve_Click(object sender, EventArgs e)
    {
        module.setStats(txtSTR.Text, txtDEX.Text,
            txtINT.Text, txtHeight.Text, txtHeightInches.Text,
            txtTemperature.Text, txtGravity.Text, txtPressure.Text, ddMonster.Text);

        module.setWeapons(cbBroadsword.Checked, cbCaber.Checked, cbNastyKnife.Checked, cbLongbow.Checked,
            cbMagicOrb.Checked, cbGrimoire.Checked);
        module.setItems(cbBalloon.Checked, cbBattery.Checked, cbBellows.Checked, cbCrystalBall.Checked,
            cbFeather.Checked, cbHardDrive.Checked, cbLamp.Checked,
            cbMoonstone.Checked, cbSmallDog.Checked, cbStepladder.Checked,
            cbSunstone.Checked, cbSymbol.Checked, cbTicket.Checked,
            cbTrophy.Checked);
        module.Solve();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        txtSTR.Text = string.Empty;
        txtPressure.Text = string.Empty;
        txtGravity.Text = string.Empty;
        txtTemperature.Text = string.Empty;
        txtHeight.Text = string.Empty;
        txtINT.Text = string.Empty;
        txtDEX.Text = string.Empty;
        cbBroadsword.Checked = false;
        cbGrimoire.Checked = false;
        cbMagicOrb.Checked = false;
        cbLongbow.Checked = false;
        cbNastyKnife.Checked = false;
        cbCaber.Checked = false;
        cbCrystalBall.Checked = false;
        cbTrophy.Checked = false;
        cbTicket.Checked = false;
        cbSymbol.Checked = false;
        cbSunstone.Checked = false;
        cbStepladder.Checked = false;
        cbSmallDog.Checked = false;
        cbMoonstone.Checked = false;
        cbLamp.Checked = false;
        cbHardDrive.Checked = false;
        cbFeather.Checked = false;
        cbBattery.Checked = false;
        cbBalloon.Checked = false;
        cbBellows.Checked = false;
        txtHeightInches.Text = string.Empty;
        ddMonster.SelectedIndex = 0;
    }
}