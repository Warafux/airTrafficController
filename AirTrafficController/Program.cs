using System;

namespace AirTrafficController
{
#if WINDOWS || LINUX
    /// <summary>
    /// The main class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            menuForm menu = new menuForm();
            Game1 game = new Game1();

            menu.Show();
            menu.setGame(game);

            game.Run();
            game.setMenu(menu);
        }
    }
#endif
}
