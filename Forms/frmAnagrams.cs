using System.Linq;

namespace KTANE_Assistant.Forms;

// ReSharper disable once EmptyGeneralCatchClause
public partial class frmAnagrams : ModuleForm
{
    private Dictionary<string, string> data = new()
    {
        { "ADEKPY", "KEYPAD" },
        { "ADIMRS", "DISARM" },
        { "AEFLMS", "FLAMES" },
        { "AEHRSS", "RASHES" },
        { "AEKLRV", "KEVLAR" },
        { "AEMRST", "MASTER" },
        { "AENOPW", "WEAPON" },
        { "AEPPRS", "SAPPER" },
        { "AMORRT", "MORTAR" },
        { "BNOTTU", "BUTTON" },
        { "BOORST", "ROBOTS" },
        { "BRSSTU", "BURSTS" },
        { "CDEEIV", "DEVICE" },
        { "CEERSU", "RECUSE" },
        { "CEKORT", "ROCKET" },
        { "DEEFSU", "DEFUSE" },
        { "DEGITW", "WIDGET" },
        { "DELMOU", "MODULE" },
        { "DELOOP", "LOOPED" },
        { "DERSTU", "DUSTER" },
        { "EELRTT", "LETTER" },
        { "EEMSTX", "SEMTEX" },
        { "ENOPRS", "PERSON" },
        { "GIINRW", "WIRING" }
    };

    public frmAnagrams()
    {
        InitializeComponent();
    }

    private void btnSolve_Click(object sender, EventArgs e)
    {
        var permutations = GetPermutations(txtAnagram.Text, 6);

        foreach (var s in permutations)
            try
            {
                MessageBox.Show(data[s]);
            }
            catch
            {
            }
    }

    private IEnumerable<string> GetPermutations(string letters, int length)
    {
        if (length == 1) return letters.Select(c => c.ToString());
        return GetPermutations(letters, length - 1)
            .SelectMany(t => letters.Where(e => !t.Contains(e)),
                (t1, t2) => t1 + t2);
    }
}