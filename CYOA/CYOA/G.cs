using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CYOA
{
    class G
    {
        // setting up all variables for game
        public static string Usern;
        public static float M = 100000;
        public static String Money = Convert.ToString(M);
        public static float Mood = 5;
        public static float day = 0;
        public static Random Randomizer = new System.Random();
        public static int rng = Randomizer.Next(1 - 20);
        public static int daycount = -1;
        public static int R = 0;


        // setting up all forms for game.
        public static intro intro = new intro();
        public static trade1 Trade1 = new trade1();
        public static Passit Pass1 = new Passit();
        public static Day1 Day1 = new Day1();
        public static BuySell BuySell = new BuySell();
        public static Lifedecision500 Lifedecision500 = new Lifedecision500();
        public static Result Result = new Result();
        public static NewsForm NewsForm = new NewsForm();
        public static path1 path1 = new path1();
        public static path2 path2 = new path2();
        public static Finale finale = new Finale();
    }
}
