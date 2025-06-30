#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

namespace KTANE_Assistant.Forms;

public partial class frmEdgeworkInput : Form
{
    public frmEdgeworkInput()
    {
        InitializeComponent();
    }

    private void submitButton_Click(object sender, EventArgs e)
    {
        int batteries;
        int holders;
        int plates;
        List<Indicator> indicators;
        var serial = serialNumberTextBox.Text.ToUpper();

        if(serial.Length != 6)
        {
            Utils.throwError("Invalid parameter: Serial must be 6 characters");
        }
        if (!int.TryParse(serial[5].ToString(), out _))
        {
            Utils.throwError("Invalid Parameter: Serial must end in digit");
            return;
        }
        if (!int.TryParse(batteryTextBox.Text, out batteries))
        {
            Utils.throwError($"Invalid Parameter: Batteries ({batteryTextBox.Text})");
            return;
        }
        if (!int.TryParse(batteryHolderTextBox.Text, out holders))
        {
            Utils.throwError($"Invalid Parameter: Holders ({batteryHolderTextBox.Text})");
            return;
        }
        if (!int.TryParse(portPlateNumTextBox.Text, out plates))
        {
            Utils.throwError($"Invalid Parameter: Plates ({portPlateNumTextBox.Text})");
            return;
        }
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
            p.start(batteries, holders, plates, indicators, serial);
            return;
        }

        Assistant.Instance.Bomb = new Bomb(batteries, holders, serial, plates, null, indicators);
        Program.switchForm(Utils.getMainForm());
    }

    private void btnReset_Click(object sender, EventArgs e)
    {
        foreach (Control c in Controls)
        {
            if (c is TextBox)
            {
                TextBox tb = (TextBox)c;
                tb.Text = string.Empty;
            }
            else if (c is CheckBox)
            {
                CheckBox cb = (CheckBox)c;
                cb.Checked = false;
            }
        }
    }
}