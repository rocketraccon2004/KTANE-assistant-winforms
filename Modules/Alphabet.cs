using System.Linq;

namespace KTANE_Assistant.Modules;

public class Alphabet : Module
{
    private string letter1;
    private string letter2;
    private string letter3;
    private string letter4;

    private List<string> words = new()
    {
        "JQXZ",
        "QEW",
        "AC",
        "ZNY",
        "TJL",
        "OKBV",
        "DFW",
        "YKQ",
        "LXE",
        "GS",
        "VSI",
        "PQJS",
        "VCN",
        "JR",
        "IRNM",
        "OP",
        "QYDX",
        "HDU",
        "PKD",
        "ARGF"
    };

    public Alphabet(string letter1, string letter2, string letter3, string letter4)
    {
        this.letter1 = letter1;
        this.letter2 = letter2;
        this.letter3 = letter3;
        this.letter4 = letter4;
    }


    public void Solve()
    {
        List<char> letters =
        [
            letter1.ToUpper()[0],
            letter2.ToUpper()[0],
            letter3.ToUpper()[0],
            letter4.ToUpper()[0]
        ];

        var usedLetters = new HashSet<char>();
        var remainingLetters = letters;
        var foundWords = new List<string>();
        while (true)
        {
            var validWords = FindWords(new string(remainingLetters.ToArray()), usedLetters);

            if (!validWords.Any()) break;
            var word = validWords.First();
            foundWords.Add(word);
            foreach (var letter in word)
            {
                usedLetters.Add(letter);
                remainingLetters.Remove(letter);
            }
        }

        var remaining = new string(remainingLetters.OrderBy(c => c).ToArray());
        MessageBox.Show($"Press {string.Join(", ", foundWords)}{remaining}");
    }

    private IEnumerable<string> GetPermutations(string letters, int length)
    {
        if (length == 1) return letters.Select(c => c.ToString());
        return GetPermutations(letters, length - 1)
            .SelectMany(t => letters.Where(e => !t.Contains(e)),
                (t1, t2) => t1 + t2);
    }

    private List<string> FindWords(string input, HashSet<char> usedLetters)
    {
        var permutations = new List<string>();

        for (var i = 2; i <= input.Length; i++) permutations.AddRange(GetPermutations(input, i));

        var validWords = permutations
            .Where(p => words.Contains(p) && p.All(c => !usedLetters.Contains(c)))
            .Distinct()
            .OrderBy(w => w)
            .ToList();

        return validWords;
    }
}