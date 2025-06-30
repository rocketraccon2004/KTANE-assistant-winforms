using System.Linq;

namespace KTANE_Assistant.Modules;

public class AdventureGame : Module
{
    private bool Balloon,
        Battery,
        Bellows,
        CrystalBall,
        Feather,
        HardDrive,
        Lamp,
        Moonstone,
        SmallDog,
        Stepladder,
        Sunstone,
        Symbol,
        Ticket,
        Trophy;

    private bool Broadsword, Caber, NastyKnife, Longbow, MagicOrb, Grimoire;

    private Monster Demon = new(50, 50, 50);
    private Monster Dragon = new(10, 11, 13);
    private Monster Eagle = new(4, 7, 3);
    private Monster Goblin = new(3, 6, 5);
    private Monster Golem = new(9, 4, 7);
    private float gravity;
    private Monster Lizard = new(4, 6, 3);

    private int STR, DEX, INT, heightFeet, heightInches, temperature, pressure;

    private string strSTR,
        strDEX,
        strINT,
        strHeightFeet,
        strHeightInches,
        strTemperature,
        strPressure,
        strGravity,
        monsterName;

    private Monster toFight = new(0, 0, 0);
    private Monster Troll = new(8, 5, 4);
    private Monster Wizard = new(4, 3, 8);

    public void Solve()
    {
        if (!int.TryParse(strDEX, out DEX))
        {
            throwError($"Invalid Input: DEX ({strDEX})");
            return;
        }

        if (!int.TryParse(strSTR, out STR))
        {
            throwError($"Invalid Input: STR ({strSTR})");
            return;
        }

        if (!int.TryParse(strINT, out INT))
        {
            throwError($"Invalid Input: INT ({strINT})");
            return;
        }

        if (!int.TryParse(strHeightFeet, out heightFeet))
        {
            throwError($"Invalid Input: Height ({strHeightFeet})");
            return;
        }

        if (!int.TryParse(strHeightInches, out heightInches))
        {
            throwError($"Invalid Input: Height ({strHeightInches})");
            return;
        }

        if (!int.TryParse(strTemperature, out temperature))
        {
            throwError($"Invalid Input: Temperature ({strTemperature})");
            return;
        }

        if (!float.TryParse(strGravity, out gravity))
        {
            throwError($"Invalid Input: Gravity ({strGravity})");
            return;
        }

        if (!int.TryParse(strPressure, out pressure))
        {
            throwError($"Invalid Input: Pressure ({strPressure})");
            return;
        }

        switch (monsterName)
        {
            case "Demon":
                toFight = Demon;
                break;
            case "Dragon":
                toFight = Dragon;
                break;
            case "Eagle":
                toFight = Eagle;
                break;
            case "Goblin":
                toFight = Goblin;
                break;
            case "Golem":
                toFight = Golem;
                break;
            case "Troll":
                toFight = Troll;
                break;
            case "Lizard":
                toFight = Lizard;
                break;
            case "Wizard":
                toFight = Wizard;
                break;
        }

        var weapons = new List<Weapon>();
        var items = new List<Item>();
        var toUse = new List<Item>();
        var weaponValues = new List<int>();
        var weaponsWithValues = new Dictionary<Weapon, int>();
        var weaponToUse = Weapon.Broadsword;

        if (Broadsword) weapons.Add(Weapon.Broadsword);
        if (Caber) weapons.Add(Weapon.Caber);
        if (NastyKnife) weapons.Add(Weapon.Nasty_Knife);
        if (Longbow) weapons.Add(Weapon.Longbow);
        if (MagicOrb) weapons.Add(Weapon.Magic_Orb);
        if (Grimoire) weapons.Add(Weapon.Grimoire);

        if (Balloon) items.Add(Item.Balloon);
        if (Battery) items.Add(Item.Battery);
        if (Bellows) items.Add(Item.Bellows);
        if (CrystalBall) items.Add(Item.Crystal_Ball);
        if (Feather) items.Add(Item.Feather);
        if (HardDrive) items.Add(Item.Hard_Drive);
        if (Lamp) items.Add(Item.Lamp);
        if (Moonstone) items.Add(Item.Moonstone);
        if (SmallDog) items.Add(Item.Small_Dog);
        if (Stepladder) items.Add(Item.Stepladder);
        if (Sunstone) items.Add(Item.Sunstone);
        if (Ticket) items.Add(Item.Ticket);
        if (Trophy) items.Add(Item.Trophy);
        if (Symbol) items.Add(Item.Symbol);

        foreach (var i in items)
            if (shouldUseItem(i))
                toUse.Add(i);

        foreach (var weapon in weapons)
        {
            var weaponValue = getWeaponValue(weapon);
            weaponValues.Add(weaponValue);
            weaponsWithValues.Add(weapon, weaponValue);
        }

        var value = weaponValues.Max();

        foreach (var w in weaponsWithValues.Keys)
        {
            if (weaponsWithValues[w] == value)
            {
                weaponToUse = w;
                break;
            }
        }
        
        List<string> strToUse = new();
        
        foreach (Item i in toUse)
        {
            strToUse.Add(i.ToString().Replace('_', ' '));
        }

        MessageBox.Show($"Use {string.Join(", ", strToUse.Distinct())} then {weaponToUse.ToString().Replace('_', ' ')}");
    }

    private int getWeaponValue(Weapon weapon)
    {
        switch (weapon)
        {
            case Weapon.Broadsword:
                return STR - toFight.STR;
            case Weapon.Caber:
                return STR + 2 - toFight.STR;
            case Weapon.Grimoire:
                return INT + 2 - toFight.INT;
            case Weapon.Longbow:
                return DEX + 2 - toFight.DEX;
            case Weapon.Nasty_Knife:
                return DEX - toFight.DEX;
            case Weapon.Magic_Orb:
                return INT - toFight.INT;
            default:
                throw new Exception($"Unknown Weapon {weapon.ToString()}");
        }
    }

    public void setStats(string STR, string DEX, string INT, string heightFeet, string heightInches, string temperature,
        string gravity, string pressure, string monsterName)
    {
        strSTR = STR;
        strDEX = DEX;
        strINT = INT;
        strHeightFeet = heightFeet;
        strHeightInches = heightInches;
        strTemperature = temperature;
        strGravity = gravity;
        strPressure = pressure;
        this.monsterName = monsterName;
    }

    public void setWeapons(bool Broadsword, bool Caber, bool NastyKnife, bool Longbow, bool MagicOrb, bool Grimoire)
    {
        this.Broadsword = Broadsword;
        this.Caber = Caber;
        this.NastyKnife = NastyKnife;
        this.Longbow = Longbow;
        this.MagicOrb = MagicOrb;
        this.Grimoire = Grimoire;
    }

    public void setItems(bool balloon, bool battery, bool bellows, bool crystalball, bool feather, bool harddrive,
        bool lamp, bool moonstone, bool smalldog, bool stepladder, bool sunstone, bool symbol, bool ticket, bool trophy)
    {
        Balloon = balloon;
        Battery = battery;
        Bellows = bellows;
        CrystalBall = crystalball;
        Feather = feather;
        HardDrive = harddrive;
        Lamp = lamp;
        Moonstone = moonstone;
        SmallDog = smalldog;
        Stepladder = stepladder;
        Sunstone = sunstone;
        Symbol = symbol;
        Ticket = ticket;
        Trophy = trophy;
    }

    private bool shouldUseItem(Item item)
    {
        switch (item)
        {
            case Item.Balloon:
                return (gravity < 9.3f || pressure > 110) && toFight != Eagle;
            case Item.Battery:
                return Assistant.Instance.Bomb.batteries <= 1 && toFight != Wizard && toFight != Golem;
            case Item.Bellows:
                if (toFight == Dragon || toFight == Eagle) return pressure > 105;

                return pressure < 95;
            case Item.Crystal_Ball:
                return INT > bomb.getLastDigitOfSerial() && toFight != Wizard;
            case Item.Feather:
                return DEX > STR || DEX > INT;
            case Item.Hard_Drive:
                return bomb.hasDuplicatePorts();
            case Item.Lamp:
                return temperature < 12 && toFight != Lizard;
            case Item.Moonstone:
                return bomb.countUnlitIndicators() >= 2;
            case Item.Symbol:
                return toFight == Demon || toFight == Golem || temperature > 31;
            case Item.Small_Dog:
                return toFight != Demon && toFight != Dragon && toFight != Troll;
            case Item.Stepladder:
                return heightFeet < 4 && toFight != Goblin && toFight != Lizard;
            case Item.Sunstone:
                return bomb.countLitIndicators() >= 2;
            case Item.Ticket:
                return ticketHeight() && gravity <= 9.2f && gravity < 10.4f;
            case Item.Trophy:
                return STR > bomb.getFirstDigitOfSerial() || toFight == Troll;
            default:
                throw new Exception($"Unknown Item: {item.ToString()}");
        }
    }

    private bool ticketHeight()
    {
        if (heightFeet == 4) return heightInches >= 6;

        return heightFeet > 4;
    }

    private enum Weapon
    {
        Broadsword,
        Caber,
        Nasty_Knife,
        Longbow,
        Magic_Orb,
        Grimoire
    }

    private enum Item
    {
        Balloon,
        Battery,
        Bellows,
        Crystal_Ball,
        Feather,
        Hard_Drive,
        Lamp,
        Moonstone,
        Small_Dog,
        Stepladder,
        Sunstone,
        Symbol,
        Ticket,
        Trophy
    }

    private class Monster
    {
        public int DEX;
        public int INT;
        public int STR;

        public Monster(int STR, int DEX, int INT)
        {
            this.STR = STR;
            this.DEX = DEX;
            this.INT = INT;
        }
    }
}