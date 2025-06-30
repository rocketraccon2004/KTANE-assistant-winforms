namespace KTANE_Assistant.Modules;

public abstract class Module
{
    public Bomb bomb => Assistant.Instance.Bomb;

    public bool isOdd(int num)
    {
        return num % 2 != 0;
    }

    public void throwError(string error)
    {
        MessageBox.Show(error, "Error - KTANE Diffuser", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    public bool isPrime(int number)
    {
        if (number < 2) return false;

        for (var i = 2; i <= Math.Sqrt(number); i++)
            if (number % i == 0)
                return false;

        return true;
    }

    public static int nextFibonacci(int number)
    {
        if (number == 1) return 1;

        // Start with the first two Fibonacci numbers
        int a = 0, b = 1;

        // Continue generating Fibonacci numbers until the next one is larger than 'number'
        while (b <= number)
        {
            var temp = a + b;
            a = b;
            b = temp;
        }

        return b;
    }

    public bool IsPerfectSquare(int num)
    {
        var sqrt = (int)Math.Sqrt(num);
        return sqrt * sqrt == num;
    }

    public bool isFibonacci(int number)
    {
        if (number < 0)
            return false;
        // Check if 5n^2 + 4 or 5n^2 - 4 is a perfect square
        var test1 = 5 * number * number + 4;
        var test2 = 5 * number * number - 4;

        return IsPerfectSquare(test1) || IsPerfectSquare(test2);
    }

    public static DialogResult ShowInputDialog(ref string input)
    {
        var size = new Size(200, 70);
        var inputBox = new Form();

        inputBox.FormBorderStyle = FormBorderStyle.FixedDialog;
        inputBox.ClientSize = size;
        inputBox.Text = "Name";

        var textBox = new TextBox();
        textBox.Size = new Size(size.Width - 10, 23);
        textBox.Location = new Point(5, 5);
        textBox.Text = input;
        inputBox.Controls.Add(textBox);

        var okButton = new System.Windows.Forms.Button();
        okButton.DialogResult = DialogResult.OK;
        okButton.Name = "okButton";
        okButton.Size = new Size(75, 23);
        okButton.Text = "&OK";
        okButton.Location = new Point(size.Width - 80 - 80, 39);
        inputBox.Controls.Add(okButton);

        var cancelButton = new System.Windows.Forms.Button();
        cancelButton.DialogResult = DialogResult.Cancel;
        cancelButton.Name = "cancelButton";
        cancelButton.Size = new Size(75, 23);
        cancelButton.Text = "&Cancel";
        cancelButton.Location = new Point(size.Width - 80, 39);
        inputBox.Controls.Add(cancelButton);

        inputBox.AcceptButton = okButton;
        inputBox.CancelButton = cancelButton;

        var result = inputBox.ShowDialog();
        input = textBox.Text;
        return result;
    }
}