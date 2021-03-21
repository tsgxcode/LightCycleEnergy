using System;

namespace LightCycleEnergy
{
    class LCE
    {
        public static void Main()
        {
            //LightAmp object/Instance
            LightMap lightMap = new LightMap();

            //Dot notation to access LightMap fields
            lightMap.Width = 10;
            lightMap.Height = 20;

            int area = lightMap.Width * lightMap.Height;

            Console.WriteLine("Making Light Cycles");
            Console.WriteLine("LightMap Area: Width 10 * Height 20:  " + area);
        }
    }
}