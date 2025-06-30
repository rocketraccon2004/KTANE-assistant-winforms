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

    public void strikeButton(bool shift)
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

    public void backButton()
    {
        Program.switchForm(Utils.getMainForm());        
    }
}