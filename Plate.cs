namespace KTANE_Assistant;

public struct Plate
{
    public bool empty;
    public bool dvid;
    public bool parallel;
    public bool ps2;
    public bool rj45;
    public bool serial;
    public bool rca;
}

public enum Port
{
    dvid,
    parallel,
    ps2,
    rj45,
    serial,
    rca
}