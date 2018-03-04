namespace ACE.Server.Physics.Animation
{
    public class MovementParameters
    {
        public int Bitfield;

        // default true?
        public bool CanWalk;    
        public bool CanRun;
        public bool CanSidestep;
        public bool CanWalkBackwards;
        public bool FailWalk;
        public bool UseFinalHeading;
        public bool Sticky;
        public bool MoveAway;
        public bool MoveTowards;
        public bool UseSpheres;
        public bool SetHoldKey;
        public bool Autonomous;
        public bool ModifyRawState;
        public bool ModifyInterpretedState;
        public bool CancelMoveTo;
        public bool StopCompletely;
        public bool DisableJumpDuringLink;

        public float DistanceToObject;
        public float MinDistance;
        public float DesiredHeading;
        public float Speed;
        public float FailDistance;
        public float WalkRunThreshold;
        public int ContextID;
        public HoldKey HoldKeyToApply;
        public int ActionStamp;
    }
}