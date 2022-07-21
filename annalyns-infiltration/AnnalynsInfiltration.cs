using System;

static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake)
    {
        if ( knightIsAwake == false)
        {
           return true;
        }
        else
        {
            return false;
        }
    }

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        if((knightIsAwake==false)&&(archerIsAwake==false)&&(prisonerIsAwake==false))
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        if((archerIsAwake==false)&&(prisonerIsAwake==true))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        if(((archerIsAwake==false)&&(petDogIsPresent==true))||((knightIsAwake==false)&&(archerIsAwake==false)&&(prisonerIsAwake==true)&&(petDogIsPresent==false)))
        {
            return true;
        }
        else
        {
            return false;
        }

    }
}