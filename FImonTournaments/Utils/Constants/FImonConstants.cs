namespace FImonTournaments.Utils.Constants;

public class FImonConstants
{
    public const int BaseAttack = 4;
    public const int BaseSpeed = 4;
    public const int BaseHP = 18;
    public const int StatsVariety = 2;

    public const int MaxAttack = BaseAttack + StatsVariety;
    public const int MaxSpeed = BaseSpeed + StatsVariety;

    public const int MinAttack = BaseAttack - StatsVariety;
    public const int MinSpeed = BaseSpeed - StatsVariety;
}