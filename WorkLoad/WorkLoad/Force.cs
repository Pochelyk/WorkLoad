using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkLoad
{
    public class LongBalk
    {
        public double Length;
    }

    // Pillar*Pillar*Pillar*Pillar*Pillar*Pillar*Pillar

    class Force
    {
        public double Value;
        public double Angle;
    }
    abstract class Pillar
    {
        public Force Reaction;
        public double Distance;
    }
    class FixedPillar : Pillar
    {
    }
    class FloatingPillar : Pillar
    {
    }
    enum Direction
    {
        left,
        right
    }
    class Moment
    {
        public double Value;
        Direction Sign;
    }
    class Anchorage : Pillar
    {
        public Moment Bending;
    }
    enum Direct
    {
        top,
        bottom
    }

    //Loading*Loading*Loading*Loading*Loading*Loading

    abstract class Loading
    {
        public double Distance;
    }
    class UniformlyDistributed : Loading
    {
        public double value;
        public double length;
        Direct Sign;
    }
    class TransverseLoad : Loading
    {
        public Force Load;
    }
    class MomentLoad : Loading
    {
        public Moment Load;
    }

    class Model
    {
        public LongBalk Balka;

        public Pillar[] Pillars;
        public Loading[] Loadings;
    }
   
}
