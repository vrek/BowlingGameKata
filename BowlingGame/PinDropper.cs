using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace BowlingGameKata;

public class PinDropper : IPinDropper
{
    public int GetPinsDown(int max) => RandomNumberGenerator.GetInt32(0, max+1);
}
