using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkLoad
{
    class Program
    {
        static double ReadDouble(string message)
        {
            double result;
            bool parsed;
            do
            {
                Console.WriteLine(message);
                string d = Console.ReadLine();
                parsed = double.TryParse(d, out result);
            } while (!parsed);
            return result;
        }
        static LongBalk MaKeLength()
        {
            LongBalk longBalk = new LongBalk();
            longBalk.Length = ReadDouble("Enter the size balk ");
            return longBalk;
        }


        static void Force (Force force)
        {
            force.Value = ReadDouble("Enter the value");
            force.Angle = ReadDouble("Enter the Angle");
        }

        static Moment MakeMoment()
        {
            Moment moment = new Moment();
            moment.Value = ReadDouble("Enter the value");
            return moment;
        }

        static FixedPillar MaKeFixed()
        {
            FixedPillar fix = new FixedPillar();
            fix.Distance = ReadDouble("Enter the value ");
            return fix;
        }
        static FloatingPillar MakeFloat()
        {
            FloatingPillar floating = new FloatingPillar();
            floating.Distance = ReadDouble("Enter the value ");
            return floating;
        }
        static Anchorage MakeAnchorage()
        {
            Anchorage anchorage = new Anchorage();
            anchorage.Distance = ReadDouble("Enter the value ");
            return anchorage;
        }

        static Pillar MakePillar()
        {
            Pillar pillar;
            Console.WriteLine("enter the type of support:F=Fixed/ D=Float/ A=Anchorage ");
            string size = Console.ReadLine();
            switch (size)
            {
                case "F":
                    pillar = MaKeFixed();
                    break;
                case "D":
                    pillar = MakeFloat();
                    break;
                case "A":
                    pillar = MakeAnchorage();
                    break;
                default:
                    pillar = null;
                    Console.WriteLine("you clicked an unknown letter!");
                    break;
            }
            return pillar;
        }
        
        static UniformlyDistributed MakeUniform()
        {
            UniformlyDistributed uniform = new UniformlyDistributed();
            uniform.Distance = ReadDouble("Enter the value");
            return uniform;
        }
        static TransverseLoad MakeTransvers()
        {
            TransverseLoad transvers = new TransverseLoad();
            transvers.Distance = ReadDouble("Enter the value");
            return transvers;
        }
        static MomentLoad MakeMomentLoad()
        {
            MomentLoad momentload = new MomentLoad();
            momentload.Distance = ReadDouble("Enter the value");
            return momentload;
        }

        static Loading MakeLoading()
        {
            Loading loading;
            Console.WriteLine("enter the type load: U-UniformlyDistributed /T-TransverseLoad M-MomentLoad ");
            string size = Console.ReadLine();
            switch (size)
            {
                case "U":
                    loading = MakeUniform();
                    break;
                case "T":
                    loading = MakeTransvers();
                    break;
                case "M":
                    loading = MakeMomentLoad();
                    break;
                default:
                    loading = null;
                    Console.WriteLine("you clicked an unknown letter!");
                    break;
            }
            return loading;
        }
        static void Main(string[] args)
        {
            //   MaKeLength();

            Console.WriteLine("enter the number of supports:");
            string number = Console.ReadLine();
            int N = Convert.ToInt32(number);

            Pillar[] pillars = new Pillar[N];
            for (int i = 0; i < pillars.Length; i++)
            {
                Pillar pillar = null;
                do
                {
                     pillar= MakePillar();
                }
                while (pillar == null);
                pillars[i] = pillar;
            }

            Console.WriteLine("enter the number of loads:");
            string loads = Console.ReadLine();
            int L = Convert.ToInt32(loads);

            Loading[] loadings = new Loading[L];
            for (int i = 0; i < loadings.Length; i++)
            {
                Loading loading = null;
                do
                {
                    loading = MakeLoading();
                }
                while (loading == null);
                loadings[i] = loading;
            }
            Console.ReadKey();
        }
    }
}
