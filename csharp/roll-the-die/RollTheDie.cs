using System;

public class Player
{
    public int RollDie()
    {
        return new Random().Next(1, 19); //Next is inclusive of the lower bound but exclusive of the upper bound, so [1,19)
        throw new NotImplementedException("Please implement the Player.RollDie() method");
    }

    public double GenerateSpellStrength()
    {
        return new Random().NextDouble() * 100; // [1,101)
        throw new NotImplementedException("Please implement the Player.GenerateSpellStrength() method");
    }
}
