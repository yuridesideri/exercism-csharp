using System;

static class QuestLogic {
    public static bool CanFastAttack( bool knightIsAwake ) {
        return !knightIsAwake;
        throw new NotImplementedException("Please implement the (static) QuestLogic.CanFastAttack() method");
    }

    public static bool CanSpy( bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake ) {
        bool[] peopleStates = { knightIsAwake, archerIsAwake, prisonerIsAwake };

        int countPeopleAwake = 0;

        for(int i = 0; i < peopleStates.Length; i++) {
            if(peopleStates[i]) {
                countPeopleAwake++;
            }
        }

        if(countPeopleAwake >= 1) {
            return true;
        } else {
            return false;
        }

        throw new NotImplementedException("Please implement the (static) QuestLogic.CanSpy() method");
    }

    public static bool CanSignalPrisoner( bool archerIsAwake, bool prisonerIsAwake ) {
        if(!archerIsAwake && prisonerIsAwake) {
            return true;
        } else { return false; }
        throw new NotImplementedException("Please implement the (static) QuestLogic.CanSignalPrisoner() method");
    }

    public static bool CanFreePrisoner( bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent ) {
        if(!archerIsAwake && petDogIsPresent) {
            return true;
        } else if(!petDogIsPresent && prisonerIsAwake && !knightIsAwake && !archerIsAwake) {
            return true;
        } else {
            return false;
        }
        throw new NotImplementedException("Please implement the (static) QuestLogic.CanFreePrisoner() method");
    }
}
