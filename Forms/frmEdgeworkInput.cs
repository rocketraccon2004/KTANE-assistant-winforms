#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

namespace KTANE_Assistant.Forms;

public partial class frmEdgeworkInput : ModuleForm
{
    public frmEdgeworkInput()
    {
        InitializeComponent();
        disableButtons();
    }

    private void frmEdgeworkInput_Load(object sender, EventArgs e)
    {
        foreach (var s in Enum.GetNames(typeof(Day))) dayOfWeekComboBox.Items.Add(s);
    }

    private void submitButton_Click(object sender, EventArgs e)
    {
        int batteries;
        int holders;
        int plates;
        List<Indicator> indicators;
        var day = (Day)Enum.Parse(typeof(Day), dayOfWeekComboBox.Text);
        var serial = serialNumberTextBox.Text;

        if (!int.TryParse(serial[5].ToString(), out _)) MessageBox.Show("Invalid Parameter: Serial must end in digit");

        if (!int.TryParse(batteryTextBox.Text, out batteries))
            MessageBox.Show($"Invalid Parameter: Batteries ({batteryTextBox.Text})");
        if (!int.TryParse(batteryHolderTextBox.Text, out holders))
            MessageBox.Show($"Invalid Parameter: Holders ({batteryHolderTextBox.Text})");
        if (!int.TryParse(portPlateNumTextBox.Text, out plates))
            MessageBox.Show($"Invalid Parameter: Plates ({portPlateNumTextBox.Text})");

        indicators = new List<Indicator>
        {
            new()
            {
                name = IndicatorType.SND,
                lit = sndLitCheckBox.Checked,
                visible = sndVisibleCheckBox.Checked
            },
            new()
            {
                name = IndicatorType.CLR,
                lit = clrLitCheckBox.Checked,
                visible = clrVisibleCheckBox.Checked
            },
            new()
            {
                name = IndicatorType.CAR,
                lit = carLitCheckBox.Checked,
                visible = carVisibleCheckBox.Checked
            },
            new()
            {
                name = IndicatorType.IND,
                lit = indLitCheckBox.Checked,
                visible = indVisibleCheckBox.Checked
            },
            new()
            {
                name = IndicatorType.FRQ,
                lit = frqLitCheckBox.Checked,
                visible = frqVisibleCheckBox.Checked
            },
            new()
            {
                name = IndicatorType.SIG,
                lit = sigLitCheckBox.Checked,
                visible = sigVisibleCheckBox.Checked
            },
            new()
            {
                name = IndicatorType.NSA,
                lit = nsaLitCheckBox.Checked,
                visible = nsaVisibleCheckBox.Checked
            },
            new()
            {
                name = IndicatorType.MSA,
                lit = msaLitCheckBox.Checked,
                visible = msaVisibleCheckBox.Checked
            },
            new()
            {
                name = IndicatorType.TRN,
                lit = trnLitCheckBox.Checked,
                visible = trnVisibleCheckBox.Checked
            },
            new()
            {
                name = IndicatorType.BOB,
                lit = bobLitCheckBox.Checked,
                visible = bobVisibleCheckBox.Checked
            },
            new()
            {
                name = IndicatorType.FRK,
                lit = frkLitCheckBox.Checked,
                visible = frkVisibleCheckBox.Checked
            }
        };

        if (plates != 0)
        {
            var p = new frmPlates();
            p.start(batteries, holders, plates, day, indicators, serial);
            return;
        }

        Assistant.instance.bomb = new Bomb(batteries, holders, serial, day, plates, null, indicators);
        Program.switchForm(Utils.getMainForm());
    }
}