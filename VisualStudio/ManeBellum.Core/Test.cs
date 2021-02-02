using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// https://docs.unity3d.com/Manual/UsingDLL.html
/// </summary>
namespace ManeBellum.Core
{
    public class MyUtilities
    {

        public int c;

        public void AddValues(int a, int b)
        {
            c = a + b;
        }

        public static int GenerateRandom(int min, int max)
        {
            System.Random rand = new System.Random();
            return rand.Next(min, max);
        }
    }

}
