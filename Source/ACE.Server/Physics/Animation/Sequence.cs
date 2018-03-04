using System.Collections.Generic;
using System.Numerics;
using ACE.Entity;

namespace ACE.Server.Physics.Animation
{
    public class Sequence
    {
        public int ID;
        public List<AnimSequenceNode> AnimList;
        public AnimSequenceNode FirstCyclic;
        public Vector3 Velocity;
        public Vector3 Omega;
        public PhysicsObj HookObj;
        public double FrameNumber;
        public AnimSequenceNode CurrAnim;
        public AnimFrame PlacementFrame;
        public int PlacementFrameId;
        public int IsTrivial;

        public Sequence()
        {

        }

        public Sequence(bool id)
        {
            ID = id ? 1 : 0;
        }

        public Sequence(int id)
        {
            ID = id;
        }

        public Sequence(Frame frame)
        {

        }

        public Sequence(List<PhysicsPart> parts)
        {

        }

        public void AppendAnimation(AnimData animData)
        {

        }

        public void ClearAnimations()
        {

        }

        public AnimFrame GetCurrAnimFrame()
        {
            return null;
        }

        public int GetCurrFrameNumber()
        {
            return -1;
        }

        public bool HasAnims()
        {
            return false;
        }

        public void SetObject(PhysicsObj physObj)
        {

        }

        public void SetPlacementFrame(AnimFrame frame, int id)
        {

        }

        public void Update(double quantum, AFrame offsetFrame)
        {

        }
    }
}