﻿using System.Collections.Generic;

public class Corporal : Soldier
{
    private const double OverAllSKillMultiplier = 2.5d;
    private const string Gun = "Gun";
    private const string AutomaticMachine = "AutomaticMachine";
    private const string Helmet = "Helmet";
    private const string MachineGun = "MachineGun";
    private const string Knife = "Knife";

    private static readonly List<string> WeaponsAllowedReadOnly = new List<string>
    {
        Gun,
        AutomaticMachine,
        MachineGun,
        Helmet,
        Knife,
    };

    public Corporal(string name, int age, double experience, double endurance)
        : base(name, age, experience, endurance)
    {
        InitilizeWeapons();
    }

    protected override void InitilizeWeapons()
    {
        foreach (var weapon in WeaponsAllowedReadOnly)
        {
            this.Weapons[weapon] = null;
        }
    }

    public override double OverallSkill
    {
        get { return (this.Age + this.Experience) * OverAllSKillMultiplier; }
    }
}