namespace KTANE_Assistant;

public class Assistant
{
    public static Assistant Instance = null!;

    public Bomb Bomb = null!;

    public int Strikes;

    public static void Init()
    {
        Instance = new Assistant();
    }

    public void strikeButtonClicked(bool shift)
    {
        if (shift)
        {
            Strikes--;
            Utils.showMessageBox("Removed a strike");
            return;
        }
        Strikes++;
        Utils.showMessageBox("Added a strike");
    }

    public void backButtonClicked()
    {
        Program.switchForm(Utils.getMainForm());        
    }

    public void formClosed(FormClosingEventArgs args)
    {
        if (Utils.showYesNoOptionBox("Are you sure you want to quit?") == DialogResult.No)
        {
            args.Cancel = true;
        }
        else
        {
            Application.Exit();
        }
    }
}