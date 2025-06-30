namespace KTANE_Assistant.Forms;

public partial class frmAnagrams : Form
{
    private static readonly List<List<string>> Words = new()
    {
        new List<string> {"stream", "master", "tamers"},
        new List<string> {"looped", "poodle", "pooled"},
        new List<string> {"cellar", "caller", "recall"},
        new List<string> {"seated", "sedate", "teased"},
        new List<string> {"rescue", "secure", "recuse"},
        new List<string> {"rashes", "shears", "shares"},
        new List<string> {"barely", "barley", "bleary"},
        new List<string> {"duster", "rusted", "rudest"}
    };

    public frmAnagrams()
    {
        InitializeComponent();
    }

    private void btnSolve_Click(object sender, EventArgs e)
    {
        string anagram = txtAnagram.Text.ToLower();
        foreach (var words in Words)
        {
            if (words.Contains(anagram))
            {
                int index = words.IndexOf(anagram);
                int rand = Utils.RNG(0, words.Count);
                while (rand == index)
                {
                    rand = Utils.RNG(0, words.Count);
                }

                MessageBox.Show(words[rand]);
                return;
            }
        }
    }
}