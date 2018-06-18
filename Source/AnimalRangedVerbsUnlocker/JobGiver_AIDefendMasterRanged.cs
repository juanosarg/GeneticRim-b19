using System;
using Verse;
using RimWorld;

namespace AnimalRangedVerbsUnlocker
{
    public class JobGiver_AIDefendMasterRanged : JobGiver_AIDefendPawnRanged
    {
        private const float RadiusUnreleased = 5f;

        protected override Pawn GetDefendee(Pawn pawn)
        {
            return pawn.playerSettings.Master;
        }

        protected override float GetFlagRadius(Pawn pawn)
        {
            if (pawn.playerSettings.Master.playerSettings.animalsReleased && pawn.training.HasLearned(TrainableDefOf.Release))
            {
                return 50f;
            }
            return 5f;
        }
    }
}