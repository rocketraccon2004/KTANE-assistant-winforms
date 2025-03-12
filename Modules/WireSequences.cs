using System.Linq;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.

namespace KTANE_Assistant.Modules;
#nullable enable
public class WireSequences : Module
{
    private static Dictionary<int, string[]> redOccurences = new()
    {
        { 1, new[] { "C" } },
        { 2, new[] { "B" } },
        { 3, new[] { "A" } },
        { 4, new[] { "A", "C" } },
        { 5, new[] { "B" } },
        { 6, new[] { "A", "C" } },
        { 7, new[] { "A", "B", "C" } },
        { 8, new[] { "A", "B" } },
        { 9, new[] { "B" } }
    };

    private static Dictionary<int, string[]> blueOccurences = new()
    {
        { 1, new[] { "B" } },
        { 2, new[] { "A", "C" } },
        { 3, new[] { "B" } },
        { 4, new[] { "A" } },
        { 5, new[] { "B" } },
        { 6, new[] { "B", "C" } },
        { 7, new[] { "C" } },
        { 8, new[] { "A", "C" } },
        { 9, new[] { "A" } }
    };

    private static Dictionary<int, string[]> blackOccurences = new()
    {
        { 1, new[] { "A", "B", "C" } },
        { 2, new[] { "A", "C" } },
        { 3, new[] { "B" } },
        { 4, new[] { "A", "C" } },
        { 5, new[] { "B" } },
        { 6, new[] { "B", "C" } },
        { 7, new[] { "A", "B" } },
        { 8, new[] { "C" } },
        { 9, new[] { "C" } }
    };

    private int _blackWires;
    private int _blueWires;
    private int _redWires;

    private string colour1;
    private string colour2;
    private string colour3;

    private string letter1;
    private string letter2;
    private string letter3;

    public void setWires(string colour1, string colour2, string colour3, string letter1, string letter2, string letter3)
    {
        this.colour1 = colour1;
        this.colour2 = colour2;
        this.colour3 = colour3;
        this.letter1 = letter1;
        this.letter2 = letter2;
        this.letter3 = letter3;
    }

    public void Solve()
    {
        if ((colour2 == string.Empty) | (letter2 == string.Empty))
            MessageBox.Show(Solve(colour1, letter1));
        else if ((colour3 == string.Empty) | (letter3 == string.Empty))
            MessageBox.Show($"{Solve(colour1, letter1)}; {Solve(colour2, letter2)}");
        else
            MessageBox.Show($"{Solve(colour1, letter1)}; {Solve(colour2, letter2)}; {Solve(colour3, letter3)}");
    }


    private string Solve(string Colour, string Letter)
    {
        var targetDictionary = new Dictionary<int, string[]>();
        var targetWireCount = 0;

        switch (Colour)
        {
            case "Red":
                _redWires++;
                targetWireCount = _redWires;
                targetDictionary = redOccurences;
                break;
            case "Blue":
                _blueWires++;
                targetWireCount = _blueWires;
                targetDictionary = blueOccurences;
                break;
            case "Black":
                _blackWires++;
                targetWireCount = _blackWires;
                targetDictionary = blackOccurences;
                break;
        }

        return $"{(targetDictionary[targetWireCount].Contains(Letter) ? "Cut" : "Don't Cut")}";
    }
}