using BowlingGameKata;
using System;
using System.Collections.Generic;
using System.Text;

namespace BowlingGameKata;

public class Frame
{
    public List<int> Rolls { get; } = [];
    public bool IsStrike => Rolls.Count == 1 && Rolls[0] == 10;
    public bool IsSpare => Rolls.Count == 2 && Rolls[0] + Rolls[1] == 10;
    public record Pins(int PinsStanding, int PinsKnockedDown)
    {
        public static Pins Reset() => new(10, 0);
    }
    public void Roll(Pins pins, IPinDropper dropper)
    {
        int pinsDown = dropper.GetPinsDown(pins.PinsStanding);
        Rolls.Add(pinsDown);
    }
    public int PlayFrame(IPinDropper dropper)
    {
        Pins pins = new(10, 0);
        while (Rolls.Count < 2 && pins.PinsStanding > 0)
        {
            Roll(pins, dropper);
            pins = new Pins(pins.PinsStanding - Rolls[^1], pins.PinsKnockedDown + Rolls[^1]);
        }
        return Rolls.Sum();
    }
}
