using KTANE_Assistant.Forms;

namespace KTANE_Assistant;

internal static class Program
{
    /// <summary>
    ///     The main entry point for the application.
    /// </summary>
    [STAThread]
    private static void Main()
    {
        Application.Run(new frmEdgeworkMode());
    }

    public static void switchForm(Form _new)
    {
        var old = Form.ActiveForm;
        if (old != null && _new != null)
        {
            _new.StartPosition = FormStartPosition.Manual;
            _new.Location = old.Location;
            old.Hide();
            _new.Show();
        }
        else
        {
            Utils.throwError("One of the forms is null");
        }
    }
}