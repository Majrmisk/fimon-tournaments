using FImonTournaments.Models.GameObjects.FImons;
using FImonTournaments.Models.GameObjects.FImons.Abstracts;

namespace FImonTournaments.Utils;

public static class Randomizer
{
    private static readonly string[] fimonNames =
    [
        "Bytecub",
        "Circuitchu",
        "Technisaur",
        "Codron",
        "Nanoknight",
        "Sparkbyte",
        "Mechameleon",
        "Glitchling",
        "Cyberflare",
        "Roboquill",
        "Voltroid",
        "Quantumite",
        "Bitwing",
        "Cyberpaw",
        "Nanogon",
        "Gigaflare",
        "Technifin",
        "Mechashell",
        "Datafang",
        "Magnebyte",
        "Logiclash",
        "Voltaic",
        "Circuitpede",
        "Binaryte",
        "Nanodrive",
        "Codewing",
        "Glitchhop",
        "Synapseon",
        "Firewall",
        "Algorithmic",
        "Hexobyte",
        "Terobyte",
        "Gigavolt",
        "Cybertooth",
        "Nanodragon",
        "Megapulse",
        "Technosaur",
        "Datadrive",
        "Magneshield",
        "Bitstorm"
    ];

    private static readonly string[] trainerNames =
    [
        "Ace Trainer",
        "Sparky McFight",
        "Fists of Fury",
        "Punchline Jones",
        "The Iron Wall",
        "The Gentle Breeze",
        "The Unbreakable",
        "Bolt",
        "The Prodigy",
        "The Veteran",
        "Stonewall Jackson",
        "Whirlwind",
        "The Shadow",
        "The Strategist",
        "Iron Fist",
        "The Wall of Steel",
        "The Trickster",
        "The Unseen Force",
        "The Phoenix",
        "The Tactician",
        "The Wallflower",
        "Cinder",
        "The Upstart",
        "The Enigma",
        "The Gentle Giant",
        "The Blitzkrieg",
        "The Maestro"
    ];

    private static readonly Random random = new();

    private static int fimonNamesLeft = fimonNames.Length;
    private static int trainerNamesLeft = trainerNames.Length;

    public static FImon[] GenerateRandomFImons(int amount)
    {
        FImon[] newFImons = new FImon[amount];
        for (var i = 0; i < amount; i++)
        {
            switch ((FImonType)GetRandomNumber(0, 2))
            {
                case FImonType.Fire:
                    newFImons[i] = new Fire();
                    break;
                case FImonType.Water:
                    newFImons[i] = new Water();
                    break;
                case FImonType.Leaf:
                    newFImons[i] = new Leaf();
                    break;
            }
        }
        ResetFImonNames();
        return newFImons;
    }

    public static string GetRandomFImonName()
    {
        if (fimonNamesLeft <= 0)
        {
            ResetFImonNames();
        }

        var randomNumber = random.Next(fimonNamesLeft--);
        (fimonNames[fimonNamesLeft], fimonNames[randomNumber]) = (fimonNames[randomNumber], fimonNames[fimonNamesLeft]);
        return fimonNames[fimonNamesLeft];
    }

    public static string GetRandomTrainerName()
    {
        if (fimonNamesLeft <= 0)
        {
            ResetTrainerNames();
        }

        var randomNumber = random.Next(trainerNamesLeft--);
        (trainerNames[trainerNamesLeft], trainerNames[randomNumber]) = (trainerNames[randomNumber], trainerNames[trainerNamesLeft]);
        return trainerNames[trainerNamesLeft];
    }

    public static int GetRandomNumber(int min, int max)
    {
        return random.Next(min, max + 1);
    }

    private static void ResetFImonNames()
    {
        fimonNamesLeft = fimonNames.Length;
    }

    private static void ResetTrainerNames()
    {
        fimonNamesLeft = fimonNames.Length;
    }
}
