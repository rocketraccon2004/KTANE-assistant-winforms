using System.Linq;

namespace KTANE_Assistant.Modules;

public class blindAlley : Module
{
    public List<int> Solve()
    {
        var toReturn = new List<int>();
        var trueConditions = new List<int>();
        for (var i = 0; i < 8; i++) trueConditions.Add(Solve(i + 1));

        for (var i = 0; i < 8; i++)
            if (trueConditions[i] == trueConditions.Max())
                toReturn.Add(i + 1);

        return toReturn;
    }

    public int Solve(int which)
    {
        var toReturn = 0;
        switch (which)
        {
            case 1:
                if (bomb.hasIndicator(IndicatorType.BOB, false)) toReturn++;

                if (bomb.hasIndicator(IndicatorType.CAR, true)) toReturn++;

                if (bomb.hasIndicator(IndicatorType.IND, true)) toReturn++;

                if (!isOdd(bomb.holders)) toReturn++;
                break;
            case 2:
                if (bomb.hasIndicator(IndicatorType.CAR, false)) toReturn++;

                if (bomb.hasIndicator(IndicatorType.NSA, false)) toReturn++;

                if (bomb.hasIndicator(IndicatorType.FRK, true)) toReturn++;

                if (bomb.hasPort(Port.rj45)) toReturn++;
                break;
            case 3:
                if (bomb.hasIndicator(IndicatorType.FRQ, false)) toReturn++;

                if (bomb.hasIndicator(IndicatorType.IND, false)) toReturn++;

                if (bomb.hasIndicator(IndicatorType.TRN, false)) toReturn++;

                if (bomb.hasPort(Port.dvid)) toReturn++;
                break;
            case 4:
                if (bomb.hasIndicator(IndicatorType.SIG, false)) toReturn++;

                if (bomb.hasIndicator(IndicatorType.SND, false)) toReturn++;

                if (bomb.hasIndicator(IndicatorType.NSA, true)) toReturn++;

                if (!isOdd(bomb.batteries)) toReturn++;
                break;
            case 5:
                if (bomb.hasIndicator(IndicatorType.BOB, true)) toReturn++;

                if (bomb.hasIndicator(IndicatorType.CLR, true)) toReturn++;

                if (bomb.hasPort(Port.ps2)) toReturn++;

                if (bomb.hasPort(Port.serial)) toReturn++;
                break;
            case 6:
                if (bomb.hasIndicator(IndicatorType.FRQ, true)) toReturn++;

                if (bomb.hasIndicator(IndicatorType.SIG, true)) toReturn++;

                if (bomb.hasIndicator(IndicatorType.TRN, true)) toReturn++;

                foreach (var c in bomb.serial)
                    if (char.IsDigit(c))
                        if (!isOdd((int)char.GetNumericValue(c)))
                        {
                            toReturn++;
                            break;
                        }

                break;
            case 7:
                if (bomb.hasIndicator(IndicatorType.FRK, false)) toReturn++;

                if (bomb.hasIndicator(IndicatorType.MSA, true)) toReturn++;

                if (bomb.hasPort(Port.parallel)) toReturn++;

                if (bomb.hasVowelInSerial()) toReturn++;
                break;
            case 8:
                if (bomb.hasIndicator(IndicatorType.CLR, false)) toReturn++;

                if (bomb.hasIndicator(IndicatorType.MSA, false)) toReturn++;

                if (bomb.hasIndicator(IndicatorType.SND, true)) toReturn++;

                if (bomb.hasPort(Port.rca)) toReturn++;
                break;
        }

        return toReturn;
    }
}