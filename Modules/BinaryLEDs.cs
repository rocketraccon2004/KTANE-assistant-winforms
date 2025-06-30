
namespace KTANE_Assistant.Modules;

public class BinaryLEDs : Module
{
    int binary;

    List<int> pattern1 = new() { 17, 15, 6, 2, 24, 8, 26, 25, 21, 24, 1, 15, 18, 8, 8, 18, 15, 1, 24, 21, 25, 26, 8, 24, 2, 6, 15 };
    List<int> pattern2 = new() { 18, 15, 19, 31, 12, 6, 19, 21, 11, 16, 19, 2, 1, 29, 1, 2, 19, 16, 11, 21, 19, 6, 12, 31, 19, 15 };
    List<int> pattern3 = new() { 8, 25, 1, 15, 20, 15, 9, 3, 6, 24, 1, 24, 5, 26, 5, 24, 1, 24, 6, 3, 9, 15, 20, 15, 1, 25 };
    List<int> pattern4 = new() { 21, 27, 6, 12, 27, 20, 7, 1, 19, 15, 3, 13, 9, 28, 9, 13, 3, 15, 19, 1, 7, 20, 27, 12, 6, 27 };
    List<int> pattern5 = new() { 3, 21, 14, 22, 7, 28, 16, 27, 22, 17, 26, 2, 31, 15, 31, 2, 26, 17, 22, 27, 16, 28, 7, 22, 14, 21 };
    List<int> pattern6 = new() { 8, 22, 30, 19, 1, 25, 31, 16, 9, 7, 6, 13, 9, 7, 9, 13, 6, 7, 9, 16, 31, 25, 1, 19, 30, 22 };
    List<int> pattern7 = new() { 5, 18, 12, 7, 5, 12, 31, 16, 10, 15, 17, 9, 12, 25, 12, 9, 17, 15, 10, 16, 31, 12, 5, 7, 12, 18 };
    List<int> pattern8 = new() { 4, 20, 18, 25, 20, 4, 24, 29, 17, 16, 12, 16, 29, 19, 29, 16, 12, 16, 17, 29, 24, 4, 20, 25, 18, 20 };
    List<int> pattern = new();


    public void solve(int binary)
    {
        
        pattern.Add(binary);
        //MessageBox.Show(binary.ToString());

        KeyValuePair<int, List<int>> kvp = getPossibleSolutions();
        int possibleSolutions = kvp.Key;

        if (possibleSolutions == 1)
        {
            MessageBox.Show(getSolutionMessage(kvp.Value[0]));
        }
        else
        {
            MessageBox.Show($@"Possible Solutions: {possibleSolutions}
Enter Next Solution");
        }
    }

    private KeyValuePair<int, List<int>> getPossibleSolutions()
    {
        List<int> possibleSolutions = new List<int>();
        int count = 0;
        
        if (ContainsSubsequence(pattern1, pattern))
        {
            possibleSolutions.Add(1);
            count++;
        }

        if (ContainsSubsequence(pattern2, pattern))
        {
            possibleSolutions.Add(2);
            count++;
        }

        if (ContainsSubsequence(pattern3, pattern))
        {
            possibleSolutions.Add(3);
            count++;
        }

        if (ContainsSubsequence(pattern4, pattern))
        {
            possibleSolutions.Add(4);
            count++;
        }

        if (ContainsSubsequence(pattern5, pattern))
        {
            possibleSolutions.Add(5);
            count++;
        }

        if (ContainsSubsequence(pattern6, pattern))
        {
            possibleSolutions.Add(6);
            count++;
        }

        if (ContainsSubsequence(pattern7, pattern))
        {
            possibleSolutions.Add(7);
            count++;
        }

        if (ContainsSubsequence(pattern8, pattern))
        {
            possibleSolutions.Add(8);
            count++;
        }

        return new KeyValuePair<int, List<int>>(count, possibleSolutions);
    }

    private bool ContainsSubsequence(List<int> list, List<int> sequence)
    {
        for (int i = 0; i <= list.Count - sequence.Count; i++)
        {
            if (list.GetRange(i, sequence.Count).SequenceEqual(sequence))
                return true;
        }
        return false;
    }

    private string getSolutionMessage(int solution)
    {
        MessageBox.Show(solution.ToString());
        switch (solution)
        {
            case 1:
                return @"Cut green on 2 (00010)";
            case 2:
                return @"Cut green on 11 (01011)";
            case 3:
                return @"Cut green on 25 (11001)";
            case 4:
                return @"Cut green on 9 (01001)";
            case 5:
                return @"Cut green on 28 (11100)";
            case 6:
                return @"Cut green on 6 (00110)";
            case 7:
                return @"Cut blue on 15 (01111)";
            case 8:
                return @"Cut blue on 12 (01100)";
            default:
               return "Code died";
        }
    }
}
