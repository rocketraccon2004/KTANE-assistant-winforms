#pragma warning disable CS8602 // Dereference of a possibly null reference.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace KTANE_Assistant.Forms;

public partial class frmPlates : Form
{
    private int batteries;
    private int currentIteration = 1;
    private int holders;
    private List<Indicator> indicators;
    private Plate[] plateArray;
    private int plates;
    private string serial;

    public frmPlates()
    {
        InitializeComponent();
    }

    public void start(int batteries, int holders, int plates, List<Indicator> indicators, string serial)
    {
        Program.switchForm(this);
        this.batteries = batteries;
        this.holders = holders;
        this.plates = plates;
        this.indicators = indicators;
        this.serial = serial;
        plateArray = new Plate[plates];
        updateLabel();
    }

    private void updateLabel()
    {
        label1.Text = $"Plate {currentIteration} of {plates}";
    }

    private void backButton_Click(object sender, EventArgs e)
    {
        currentIteration--;
        updateLabel();
    }

    private void submitButton_Click(object sender, EventArgs e)
    {
        var p = new Plate
        {
            dvid = DviCheckBox.Checked,
            parallel = parellelCheckBox.Checked,
            ps2 = psCheckBox.Checked,
            rj45 = rjCheckBox.Checked,
            serial = serialCheckBox.Checked,
            rca = RcaCheckBox.Checked,
            empty = isEmpty()
        };
        plateArray[currentIteration - 1] = p;
        if (currentIteration != plates)
        {
            currentIteration++;
            updateLabel();
            return;
        }

        Assistant.Instance.Bomb = new Bomb(batteries, holders, serial, getEmptyPlates(), plateArray, indicators);
        Program.switchForm(Utils.getMainForm());
    }

    private int getEmptyPlates()
    {
        var count = 0;
        foreach (var p in plateArray)
            if (p.empty)
                count++;

        return count;
    }

    private bool isEmpty()
    {
        return !serialCheckBox.Checked && !DviCheckBox.Checked && !parellelCheckBox.Checked && !psCheckBox.Checked &&
               !rjCheckBox.Checked && !RcaCheckBox.Checked;
    }
}