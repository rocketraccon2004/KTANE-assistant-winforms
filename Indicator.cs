﻿namespace KTANE_Assistant;

public struct Indicator
{
    public IndicatorType name;
    public bool visible;
    public bool lit;
}

public enum IndicatorType
{
    SND,
    CLR,
    CAR,
    IND,
    FRQ,
    SIG,
    NSA,
    FRK,
    MSA,
    TRN,
    BOB
}