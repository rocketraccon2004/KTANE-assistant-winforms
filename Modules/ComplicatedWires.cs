namespace KTANE_Assistant.Modules;

public class ComplicatedWires : Module
{
    private readonly string cut = "Cut";
    private readonly string dont = "Don't Cut";
    private bool blueWire;
    private bool LED;

    private bool redWire;
    private bool Star;

    public ComplicatedWires(bool redWire, bool blueWire, bool lED, bool star)
    {
        this.redWire = redWire;
        this.blueWire = blueWire;
        LED = lED;
        Star = star;
    }

    public void Solve()
    {
        MessageBox.Show(cutWire());
    }

    private string cutWire()
    {
        if (redWire & blueWire & LED & Star) return dont;

        if (redWire & blueWire & LED & !Star)
        {
            if (!isOdd(bomb.getLastDigitOfSerial())) return cut;
            return dont;
        }

        if (redWire & blueWire & !LED & Star)
        {
            if (bomb.hasPort(Port.parallel)) return cut;
            return dont;
        }

        if (redWire & blueWire & !LED & !Star)
        {
            if (!isOdd(bomb.getLastDigitOfSerial())) return cut;
            return dont;
        }

        if (redWire & !blueWire & LED)
        {
            if (Assistant.instance.bomb.batteries >= 2) return cut;
            return dont;
        }

        if (redWire & !blueWire & !LED & Star) return cut;

        if (redWire & !blueWire & !LED & !Star)
        {
            if (!isOdd(bomb.getLastDigitOfSerial())) return cut;
            return dont;
        }

        if (!redWire & blueWire & LED)
        {
            if (bomb.hasPort(Port.parallel)) return cut;
            return dont;
        }

        if (!redWire & blueWire & !LED & Star) return dont;

        if (!redWire & !blueWire & LED & Star)
        {
            if (Assistant.instance.bomb.batteries >= 2) return cut;
            return dont;
        }

        if (!redWire & !blueWire & LED & !Star) return dont;

        if (!redWire & !blueWire & !LED) return cut;
        return "Error";
    }
}