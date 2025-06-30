using KTANE_Assistant.Forms;

namespace KTANE_Assistant
{
    public static class ModuleSelector
    {
        public static readonly Dictionary<string, Func<Form>> ModuleFactories = new()
        {
            { "3D Maze", () =>  dMaze ??= new frm3dMaze()},
            { "Adjacent Letters", () => adjacentLetters ??= new frmAdjacentLetters() },
            { "Adventure Game", () => adventureGame ??= new frmAdventureGame() },
            { "Alphabet", () => alphabet ??= new frmAlphabet() },
            { "Anagrams", () => anagrams ??= new frmAnagrams() },
            { "Astrology", () => Astrology ??= new frmAstrology() },
            { "Binary LEDs", () => BinaryLEDs ??= new frmBinaryLEDs() },
            { "Blind Alley", () => blindAlley ??= new frmBlindAlley() },
            { "Button", () => button ??= new frmButton() },
            { "Complicated Wires", () => complicatedWires ??= new frmComplicatedWires() },
            { "Colour Flash", () => colourFlash ??= new frmColourFlash() },
            { "Edgework Input", () => edgeworkInput ??= new frmEdgeworkInput() },
            { "Follow the Leader", () => followTheLeader ??= new frmFollowTheLeader() },
            { "Keypads", () => keypads ??= new frmKeypads() },
            { "Knobs", () => knob ??= new frmKnob() },
            { "LED Encryption", () => LEDEncryption ??= new frmLEDEncryption() },
            { "Maze", () => maze ??= new frmMaze() },
            { "Memory", () => memory ??= new frmMemory() },
            { "Password", () => password ??= new frmPassword() },
            { "Simon Says", () => simonSays ??= new frmSimon() },
            { "Wires", () => wires ??= new frmWires() },
            { "Wire Sequences", () => wireSequences ??= new frmWireSequences() },
            { "Skewed Slots", () => skewedSlots ??= new frmSkewedSlots() },
            { "Who's On First", () => whosOnFirst ??= new frmWhosOnFirst() }
        };

        // Cached Instances
        private static frm3dMaze? dMaze;
        private static frmAdjacentLetters? adjacentLetters;
        private static frmAdventureGame? adventureGame;
        private static frmAlphabet? alphabet;
        private static frmAnagrams? anagrams;
        private static frmBlindAlley? blindAlley;
        private static frmButton? button;
        private static frmComplicatedWires? complicatedWires;
        private static frmColourFlash? colourFlash;
        private static frmEdgeworkInput? edgeworkInput;
        private static frmFollowTheLeader? followTheLeader;
        private static frmKeypads? keypads;
        private static frmKnob? knob;
        private static frmLEDEncryption? LEDEncryption;
        private static frmMaze? maze;
        private static frmMemory? memory;
        private static frmPassword? password;
        private static frmSimon? simonSays;
        private static frmWires? wires;
        private static frmWireSequences? wireSequences;
        private static frmSkewedSlots? skewedSlots;
        private static frmWhosOnFirst? whosOnFirst;
        private static frmAstrology? Astrology;
        private static frmBinaryLEDs? BinaryLEDs;

        public static Form? SelectForm(string module)
        {
            if (ModuleFactories.TryGetValue(module, out var formFactory))
            {
                return formFactory();
            }
            Utils.throwError("Module either NYI or Doesn't exist");
            return null;
        }
    }

}
