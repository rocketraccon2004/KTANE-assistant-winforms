using KTANE_Assistant.Modules;

namespace KTANE_Assistant.Forms;

public partial class frm3dMazeStage2 : Form
{
    private frm3dMaze firstStageForm;

    public frm3dMazeStage2()
    {
        InitializeComponent();
    }

    public frm3dMazeStage2(
        frm3dMaze firstStageForm
    )
    {
        InitializeComponent();

        UpdateForm(firstStageForm);
    }

    private _3DMaze Module => firstStageForm.Module;

    public void UpdateForm(
        frm3dMaze firstStageForm
    )
    {
        var cardinals = new[] { "North", "East", "South", "West" };

        cardinalComboBox.Items.Clear();
        cardinalComboBox.Items.AddRange(cardinals);
        cardinalComboBox.Text = cardinals[0];
        cardinalComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

        this.firstStageForm = firstStageForm;
    }

    private void submitButton_Click(object sender, EventArgs e)
    {
        //find the goal cardinal
        var goalCardinal = cardinalComboBox.Text.ToUpper();

        Module.MainCardinalGoal = goalCardinal;

        //find the goal node
        var row = Module.FindRow();

        var column = Module.FindColumn();

        Module.MainGoal = Module.Maze[row, column];


        Module.UpdateGoal();

        Module.Solve();

        Hide();
        firstStageForm.UpdateForm();
        firstStageForm.Show();
    }

    private void btnBack_Click(object sender, EventArgs e)
    {
        firstStageForm.Show();
        Hide();
    }

    private void btnStrike_Click(object sender, EventArgs e)
    {
        Assistant.Instance.strikeButtonClicked(ModifierKeys.HasFlag(Keys.Shift));
    }
}