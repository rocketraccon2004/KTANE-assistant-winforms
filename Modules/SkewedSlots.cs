namespace KTANE_Assistant.Modules;

public class SkewedSlots : Module
{
    private int slot1;
    private int slot1Orig;
    private int slot2;
    private int slot2Orig;
    private int slot3;
    private int slot3Orig;

    public string setSlot(int slotNo, string slot)
    {
        switch (slotNo)
        {
            case 1:
                if (!int.TryParse(slot, out slot1Orig))
                {
                    throwError($"Not a number: {slot}");
                    return string.Empty;
                }

                break;
            case 2:
                if (!int.TryParse(slot, out slot2Orig))
                {
                    throwError($"Not a number: {slot}");
                    return string.Empty;
                }

                break;
            case 3:
                if (!int.TryParse(slot, out slot3Orig))
                {
                    throwError($"Not a number: {slot}");
                    return string.Empty;
                }

                break;
        }

        return solveSlot(slotNo);
    }

    public void Solve()
    {
        throw new NotImplementedException();
    }

    private string solveSlot(int slotNo)
    {
        var slot = 0;
        switch (slotNo)
        {
            case 1:
                slot = slot1Orig;
                slot1 = slot1Orig;
                break;
            case 2:
                slot = slot2Orig;
                slot2 = slot2Orig;
                break;
            case 3:
                slot = slot3Orig;
                slot3 = slot3Orig;
                break;
        }

        if (slot == 2)
            slot = 5;
        else if (slot == 7) slot = 0;

        slot += bomb.countLitIndicators();
        slot -= bomb.countUnlitIndicators();

        if (slot % 3 == 0)
            slot += 4;
        else if (slot > 7)
            slot *= 2;
        else if (slot < 3 && !isOdd(slot))
            slot /= 2;
        else if (bomb.hasPort(Port.rca) || bomb.hasPort(Port.ps2))
            switch (slotNo)
            {
                case 1:
                    slot1 = solveSlot1(slot);

                    while (slot1 > 9) slot1 -= 10;
                    while (slot1 < 0) slot1 += 10;

                    return slot1.ToString();
                case 2:
                    slot2 = solveSlot2(slot);

                    while (slot2 > 9) slot2 -= 10;
                    while (slot2 < 0) slot2 += 10;

                    return slot2.ToString();
                case 3:
                    slot3 = solveSlot3(slot);

                    while (slot3 > 9) slot3 -= 10;
                    while (slot3 < 0) slot3 += 10;

                    return slot3.ToString();
                default:
                    return string.Empty;
            }
        else
            slot += bomb.batteries;

        switch (slotNo)
        {
            case 1:
                slot1 = solveSlot1(slot);

                while (slot1 > 9) slot1 -= 10;
                while (slot1 < 0) slot1 += 10;

                return slot1.ToString();
            case 2:
                slot2 = solveSlot2(slot);

                while (slot2 > 9) slot2 -= 10;
                while (slot2 < 0) slot2 += 10;


                return slot2.ToString();
            case 3:
                slot3 = solveSlot3(slot);

                while (slot3 > 9) slot3 -= 10;
                while (slot3 < 0) slot3 += 10;


                return slot3.ToString();
            default:
                return string.Empty;
        }
    }

    private int solveSlot1(int slot)
    {
        if (!isOdd(slot) && slot > 5) return slot / 2;

        if (isPrime(slot)) return slot + bomb.getLastDigitOfSerial();

        if (bomb.hasPort(Port.parallel)) return slot * -1;

        if (isOdd(slot2Orig)) return slot;

        return slot - 2;
    }

    private int solveSlot2(int slot)
    {
        if (bomb.hasIndicator(IndicatorType.BOB, false)) return slot;

        if (slot == 0) return slot1Orig;

        if (isFibonacci(slot)) return slot + nextFibonacci(slot);

        if (slot >= 7) return slot + 4;

        return slot * 3;
    }

    private int solveSlot3(int slot)
    {
        if (bomb.hasPort(Port.serial)) return slot + bomb.getLargestDigitInSerial();

        if (slot3Orig == slot1Orig || slot3Orig == slot2Orig) return slot;

        if (slot >= 5)
        {
            var toReturn = 0;

            var binary = Convert.ToString(slot3Orig, 2);

            foreach (var c in binary) toReturn += int.Parse(c.ToString());

            return toReturn;
        }

        return slot + 1;
    }
}