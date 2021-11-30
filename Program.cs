using System;
using Garage;

namespace custom_colors_and_sounds
{
    class Program
    {
        static void Main(string[] args)
        {
            Cessna csna = new Cessna();
            Ram ram = new Ram();
            Tesla tesla = new Tesla();
            Zero zero = new Zero();

            zero.Drive();
            zero.Turn("left");
            zero.Stop();

            tesla.Drive();
            tesla.Turn("right");
            tesla.Stop();

            ram.Drive();
            ram.Turn("right");
            ram.Stop();

            csna.Drive();
            csna.Turn("left");
            csna.Stop();
        }
    }
}
