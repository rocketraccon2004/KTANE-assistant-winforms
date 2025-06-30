#pragma warning disable CS8601 // Possible null reference assignment.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
#nullable enable

namespace KTANE_Assistant;

public class Bomb
{
    public int batteries;
    public int emptyPlates;
    public int holders;
    public List<Indicator> indicators;
    public Plate[] plates;
    public string serial;

    public Bomb(int batteries, int holders, string serial, int emptyPlates, Plate[]? plates,
        List<Indicator> indicators)
    {
        this.batteries = batteries;
        this.holders = holders;
        this.serial = serial.ToUpper();
        this.emptyPlates = emptyPlates;
        this.plates = plates;
        this.indicators = indicators;
    }

    public int getLargestDigitInSerial()
    {
        var digits = new List<int>();

        foreach (var c in serial)
            if (char.IsDigit(c))
                digits.Add(int.Parse(c.ToString()));

        return digits.Max();
    }

    public bool hasPort(Port port)
    {
        foreach (var p in plates)
            switch (port)
            {
                case Port.dvid:
                    if (p.dvid) return true;
                    break;
                case Port.parallel:
                    if (p.parallel) return true;
                    break;
                case Port.serial:
                    if (p.serial) return true;
                    break;
                case Port.ps2:
                    if (p.ps2) return true;
                    break;
                case Port.rj45:
                    if (p.rj45) return true;
                    break;
                case Port.rca:
                    if (p.rca) return true;
                    break;
                default:
                    return false;
            }

        return false;
    }

    public List<Indicator> getLitIndicators()
    {
        var toReturn = new List<Indicator>();
        foreach (var i in indicators)
            if (i.lit && i.visible)
                toReturn.Add(i);

        return toReturn;
    }

    public List<Indicator> getUnlitIndicators()
    {
        var toReturn = new List<Indicator>();
        foreach (var i in indicators)
            if (!i.lit && i.visible)
                toReturn.Add(i);

        return toReturn;
    }

    public int getLastDigitOfSerial()
    {
        return (int)char.GetNumericValue(Assistant.Instance.Bomb.serial[5]);
    }

    public int getFirstDigitOfSerial()
    {
        foreach (var c in Assistant.Instance.Bomb.serial)
            if (char.IsDigit(c))
                return (int)char.GetNumericValue(c);
        throw new Exception("No digit in serial");
    }

    public bool hasVowelInSerial()
    {
        return Assistant.Instance.Bomb.serial.Contains('A') | Assistant.Instance.Bomb.serial.Contains('E') |
               Assistant.Instance.Bomb.serial.Contains('I') | Assistant.Instance.Bomb.serial.Contains('O') |
               Assistant.Instance.Bomb.serial.Contains('U');
    }

    public bool hasIndicator(IndicatorType type, bool lit)
    {
        foreach (var i in indicators)
            if (i.name == type && i.lit == lit && i.visible)
                return true;

        return false;
    }

    public bool hasDuplicatePorts()
    {
        var DVID = 0;
        var Parallel = 0;
        var PS2 = 0;
        var RJ45 = 0;
        var Serial = 0;
        var RCA = 0;

        foreach (var plate in Assistant.Instance.Bomb.plates)
        {
            if (plate.dvid) DVID++;

            if (plate.parallel) Parallel++;

            if (plate.ps2) PS2++;

            if (plate.rj45) RJ45++;

            if (plate.serial) Serial++;

            if (plate.rca) RCA++;
        }

        return RCA >= 2 || Serial >= 2 || RJ45 >= 2 || Parallel >= 2 || PS2 >= 2 || DVID >= 2;
    }

    public int countLitIndicators()
    {
        var toReturn = 0;

        foreach (var i in Assistant.Instance.Bomb.indicators)
            if (i.lit && i.visible)
                toReturn++;

        return toReturn;
    }

    public int countUnlitIndicators()
    {
        var toReturn = 0;

        foreach (var i in Assistant.Instance.Bomb.indicators)
            if (!i.lit && i.visible)
                toReturn++;

        return toReturn;
    }

    public char getFirstLetterInSerial()
    {
        foreach (var c in serial)
            if (char.IsLetter(c))
                return c;

        return 'A';
    }
}

public enum Day
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}
#pragma warning restore CS8618
#pragma warning restore CS8601