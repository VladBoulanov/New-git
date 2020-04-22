using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plaine
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Helicopter
    {
        public byte BladesCount { get; private set; }
        public Helicopter(int maxHeight,byte bladesCount)
        {
            MaxHeight = maxHeight;
            BladesCount = bladesCount;
            CurrentHeight = 0;
        }
        public void WriteAllProperties()
        {

        }
    }
    public class Plaine
    {
      public byte EnginesCount { get; private set; }
      public Plaine(int maxHeight,byte enginesCount)
        {
            MaxHeight = maxHeight;
            EnginesCount = enginesCount;
            CurrentHeight = 0;
        }
        public void WriteAllProperties()
        {

        }
    }
    abstract class Heliplaine
    {
        public int MaxHeight { get; private set; }
        public int CurrentHeight { get; private set; }
        public void TakeUpper(int delta)
        {
            if(delta<=0)
            {
                
            }

        }
    }
}
