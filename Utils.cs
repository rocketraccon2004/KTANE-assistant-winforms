using KTANE_Assistant.Forms;
// ReSharper disable ConditionIsAlwaysTrueOrFalseAccordingToNullableAPIContract

#pragma warning disable CS8618
#nullable enable
namespace KTANE_Assistant;

public static class Utils
{
    private static frmFollowTheLeader followTheLeader;
    private static frmAdjacentLetters adjacentLetters;
    private static frmAdventureGame adventureGame;
    private static frmAlphabet alphabet;
    private static frmAnagrams anagrams;
    private static frmButton button;
    private static frmComplicatedWires complicatedWires;
    private static frmColourFlash colourFlash;
    private static frmEdgeworkInput edgeworkInput;
    private static frmKeypads keypads;
    private static frmKnob knob;
    private static frmMain main;
    private static frmMaze maze;
    private static frmMemory memory;
    private static frmPassword password;
    private static frmSimon simonSays;
    private static frmSkewedSlots skewedSlots;
    private static frmWhosOnFirst whosOnFirst;
    private static frmWires wires;
    private static frmWireSequences wireSequences;
    private static frm3dMaze dMaze;
    private static frmBlindAlley blindAlley;
    private static frmLEDEncryption LEDEncryption;

    public static Form? SelectModuleForm(string Module)
    {
        switch (Module)
        {
            case "3d Maze":
                if (dMaze == null) dMaze = new frm3dMaze();
                return dMaze;
            case "Adjacent Letters":
                if (adjacentLetters is null) adjacentLetters = new frmAdjacentLetters();
                return adjacentLetters;
            case "Adventure Game":
                if (adventureGame is null) adventureGame = new frmAdventureGame();
                return adventureGame;
            case "Alphabet":
                if (alphabet is null) alphabet = new frmAlphabet();
                return alphabet;
            case "Anagrams":
                if (anagrams is null) anagrams = new frmAnagrams();
                return anagrams;

            case "Blind Alley":
                if (blindAlley is null) blindAlley = new frmBlindAlley();
                return blindAlley;
            case "Button":
                if (button is null) button = new frmButton();
                return button;
            case "Complicated Wires":
                if (complicatedWires is null) complicatedWires = new frmComplicatedWires();
                return complicatedWires;
            case "Colour Flash":
                if (colourFlash is null) colourFlash = new frmColourFlash();
                return colourFlash;
            case "Edgework Input":
                if (edgeworkInput is null) edgeworkInput = new frmEdgeworkInput();
                return edgeworkInput;
            case "Follow the Leader":
                if (followTheLeader is null) followTheLeader = new frmFollowTheLeader();
                return followTheLeader;
            case "Keypads":
                if (keypads is null) keypads = new frmKeypads();
                return keypads;
            case "Knob":
                if (knob is null) knob = new frmKnob();
                return knob;
            case "LED Encryption":
                if (LEDEncryption is null) LEDEncryption = new frmLEDEncryption();
                return LEDEncryption;
            case "Maze":
                if (maze is null) maze = new frmMaze();
                return maze;
            case "Memory":
                if (memory is null) memory = new frmMemory();
                return memory;
            case "Password":
                if (password is null) password = new frmPassword();
                return password;
            case "Simon Says":
                if (simonSays is null) simonSays = new frmSimon();
                return simonSays;
            case "Wires":
                if (wires is null) wires = new frmWires();
                return wires;
            case "Wire Sequences":
                if (wireSequences is null) wireSequences = new frmWireSequences();
                return wireSequences;
            case "Skewed Slots":
                if (skewedSlots is null) skewedSlots = new frmSkewedSlots();
                return skewedSlots;
            case "Who's On First":
                if (whosOnFirst is null) whosOnFirst = new frmWhosOnFirst();
                return whosOnFirst;
        }

        return null;
    }


    public static Form getMainForm()
    {
        if (main == null) main = new frmMain();
        return main;
    }

    public static void throwError(string error)
    {
        MessageBox.Show(error, "Error - KTANE Diffuser", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}