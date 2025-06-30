namespace KTANE_Assistant.Modules;

public class Astrology : Module
{
    public string element;
    public string body;
    public string zodiac;

    private List<string> zodiacs = new()
    {
        "Aries",
        "Taurus",
        "Gemini",
        "Cancer",
        "Leo",
        "Virgo",
        "Libra",
        "Scorpio",
        "Sagittarius",
        "Capricorn",
        "Aquarius",
        "Pisces"
    };

    private List<string> elements = new()
    {
        "Fire",
        "Water",
        "Earth",
        "Air"
    };

    private List<string> bodies = new()
    {
        "Sun",
        "Moon",
        "Mercury",
        "Venus",
        "Mars",
        "Jupiter",
        "Saturn",
        "Uranus",
        "Neptune",
        "Pluto"
    };

    public void solve()
    {
        //[element, body]
        int[,] elementBodyScores = CSVToArray("ElementBodyScores");
        //[body, zodiac]
        int[,] bodyZodiacScores = CSVToArray("BodyZodiacScores");
        //[element, zodiac]
        int[,] elementZodiacScores = CSVToArray("ElementZodiacScores");

        int elementIndex = elements.IndexOf(element);
        int bodyIndex = bodies.IndexOf(body);
        int zodiacIndex = zodiacs.IndexOf(zodiac);

        int omenScore = elementBodyScores[elementIndex, bodyIndex] + elementZodiacScores[elementIndex, zodiacIndex] + bodyZodiacScores[bodyIndex, zodiacIndex];

        omenScore = compareWithSerial(zodiac.ToUpper(), omenScore);
        omenScore = compareWithSerial(body.ToUpper(), omenScore);
        omenScore = compareWithSerial(element.ToUpper(), omenScore);

        if (omenScore == 0)
        {
            MessageBox.Show("Press NO OMEN at any time");
            return;
        }
        
        if (omenScore > 0)
        {
            MessageBox.Show($"Press GOOD OMEN anytime the timer shows a {omenScore}");
            return;
        }

        if (omenScore < 0)
        {
            MessageBox.Show($"Press POOR OMEN anytime the timer shows a {Math.Abs(omenScore)}");
            return;
        }
    }

    public int compareWithSerial(string toCompare, int omenScore)
    {
        if (toCompare.Intersect(bomb.serial).Any())
            return omenScore + 1;
        else
            return omenScore - 1;
    }

    public static int[,] CSVToArray(string name)
    {
        string[] lines = File.ReadAllLines($"Resources/Astrology/{name}.csv");
        int rowCount = lines.Length;
        int colCount = lines[0].Split(',').Length;

        int[,] result = new int[rowCount, colCount];

        for (int i = 0; i < rowCount; i++)
        {
            string[] values = lines[i].Split(',');
            for (int j = 0; j < colCount; j++)
            {
                result[i, j] = int.Parse(values[j]);
            }
        }

        return result;
    }
}
