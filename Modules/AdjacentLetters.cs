namespace KTANE_Assistant.Modules;

public class AdjacentLetters : Module
{
    private Dictionary<string, string> aboveBelowSolutions = new()
    {
        { "A", "HKPRW" },
        { "B", "CDFYZ" },
        { "C", "DEMTU" },
        { "D", "CJTUW" },
        { "E", "KSUWZ" },
        { "F", "AGJPQ" },
        { "G", "HOQYZ" },
        { "H", "DKPMS" },
        { "I", "EFNUV" },
        { "J", "EHIOS" },
        { "K", "DIORZ" },
        { "L", "ABRVX" },
        { "M", "BFPWX" },
        { "N", "AFGHL" },
        { "O", "IQSTX" },
        { "P", "CFHKR" },
        { "Q", "BDIKN" },
        { "R", "BNOXY" },
        { "S", "GMVYZ" },
        { "T", "CJLSU" },
        { "U", "BILNY" },
        { "V", "AEJQX" },
        { "W", "GLQRT" },
        { "X", "AJNOV" },
        { "Y", "EGMTW" },
        { "Z", "CLMPV" }
    };

    private Dictionary<string, string> leftRightSolutions = new()
    {
        { "A", "GJMOY" },
        { "B", "IKLRT" },
        { "C", "BHIJW" },
        { "D", "IKOPQ" },
        { "E", "ACGIJ" },
        { "F", "CERVY" },
        { "G", "ACFNS" },
        { "H", "LRTUX" },
        { "I", "DLOWZ" },
        { "J", "BQTUW" },
        { "K", "AFPXY" },
        { "L", "GKPTZ" },
        { "M", "EILQT" },
        { "N", "PQRSV" },
        { "O", "HJLUZ" },
        { "P", "DMNOX" },
        { "Q", "CEOPV" },
        { "R", "AEGSU" },
        { "S", "ABEKQ" },
        { "T", "GVXYZ" },
        { "U", "FMVXZ" },
        { "V", "DHMNW" },
        { "W", "DFHMN" },
        { "X", "BDFKW" },
        { "Y", "BCHSU" },
        { "Z", "JNRSY" }
    };

    private string[,] letters;
    public List<TextBox> txts;

    public void Solve()
    {
        var toPress = new List<string>();
        var lettersList = new List<char>();

        foreach (var txt in txts)
        {
            if (!char.TryParse(txt.Text, out var c)) throwError($"Invalid Input: {txt.Text}");

            if (!char.IsUpper(c))
            {
                if (char.IsLower(c))
                    c = char.ToUpper(c);
                else
                    throwError($"Not a letter: {c}");
            }

            lettersList.Add(c);
        }

        var index = 0;
        letters = new string[3, 4];

        for (var row = 0; row < 3; row++)
        for (var column = 0; column < 4; column++)
        {
            letters[row, column] = lettersList[index].ToString();
            index++;
        }

        for (var row = 0; row < 3; row++)
        for (var column = 0; column < 4; column++)
        {
            var current = getLetter(row, column);
            var left = getLetter(row, column - 1);
            var right = getLetter(row, column + 1);
            var above = getLetter(row - 1, column);
            var below = getLetter(row + 1, column);

            var solutionAboveBelow = aboveBelowSolutions[current];
            var solutionLeftRight = leftRightSolutions[current];

            if ((solutionAboveBelow.Contains(above) && above != string.Empty) ||
                (solutionAboveBelow.Contains(below) && below != string.Empty) ||
                (solutionLeftRight.Contains(left) && left != string.Empty) ||
                (solutionLeftRight.Contains(right) && right != string.Empty))
                toPress.Add(current);
        }

        MessageBox.Show($@"Press: {string.Join(",", toPress)}");
    }

    private string getLetter(int row, int column)
    {
        try
        {
            return letters[row, column];
        }
        catch (IndexOutOfRangeException)
        {
            return string.Empty;
        }
    }

    public void reset()
    {
        foreach (var txt in txts) txt.Text = string.Empty;
    }
}