using System;

static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake)
    {
        return knightIsAwake ? false : true; //if knight is awake, return false, else return true
        //return !knightIsAwake;
        //throw new NotImplementedException("Please implement the (static) QuestLogic.CanFastAttack() method");
    }

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        return knightIsAwake || archerIsAwake || prisonerIsAwake ? true : false; //if at least one of them is awake, return true, else return false
        //throw new NotImplementedException("Please implement the (static) QuestLogic.CanSpy() method");
    }

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        return !archerIsAwake && prisonerIsAwake ? true : false; //if archer is not awake and prisoner is awake, return true, else return false
        //throw new NotImplementedException("Please implement the (static) QuestLogic.CanSignalPrisoner() method");
    }

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        return (petDogIsPresent && !archerIsAwake) || (!petDogIsPresent && prisonerIsAwake && !archerIsAwake && !knightIsAwake) ? true : false;  //if pet dog is present and archer is not awake, or pet dog is not present and prisoner is awake and archer and knight are not awake, return true, else return false
        //throw new NotImplementedException("Please implement the (static) QuestLogic.CanFreePrisoner() method");
    }
}
