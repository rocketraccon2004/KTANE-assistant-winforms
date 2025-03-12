namespace KTANE_Assistant.Modules;

public class LEDEncryption : Module
{
    public List<int> Solve(int multiplier, char one, char two, char three, char four)
    {
        List<int> toReturn =
        [
            Solve(multiplier, one),
            Solve(multiplier, two),
            Solve(multiplier, three),
            Solve(multiplier, four)
        ];
        return toReturn;
    }

    public int Solve(int multiplier, char toSolve)
    {
        var alphabetIndex = toSolve - 65;
        return alphabetIndex * multiplier % 26;
    }
}