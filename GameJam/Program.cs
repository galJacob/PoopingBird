using System;
using System.Threading.Tasks;
using EdgeJs;

namespace GameJam
{
    /// <summary>
    /// The main class.
    /// </summary>
    //public static class Program
    //{
    //    /// <summary>
    //    /// The main entry point for the application.
    //    /// </summary>
    //    [STAThread]
    //    static void Main()
    //    {
    //        using (var game = new Game1())
    //            game.Run();
    //    }
    //}
    class Program
    {
       

        static void Main(string[] args)
        {

            using (var game = new Game1())
               game.Run();
        }


    }

}
