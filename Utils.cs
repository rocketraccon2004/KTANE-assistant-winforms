using System.Threading.Tasks;
using KTANE_Assistant.Forms;
using System.Windows.Forms;
#pragma warning disable CS8602 // Dereference of a possibly null reference.

namespace KTANE_Assistant;

public static class Utils
{
    private static frmMain main;

    public static Form getMainForm()
    {
        if (main == null) main = new frmMain();
        return main;
    }
    
    public static void throwError(string error)
    {
        MessageBox.Show(error, "Error - KTANE Assistant", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
    
    public static void showMessageBox(string message)
    {
        MessageBox.Show(message, "KTANE Assistant", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
   
    public static int RNG(int min, int max)
    {
        return new Random().Next(min, max);
    }
}