using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carsharing
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //GUI
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Form1 app = new Form1();
            Tui app = new Tui();
            //app.show("serializer"); //Diese Zeile auskommentieren wenn SerializedDatabase.cs verwendet werden soll
            app.show("sqlite"); //Diese Zeile auskommentieren wenn Database.cs mit SQLITE verwendet werden soll
            //Application.Run(app);

            //TUI
            //Tui app = new Tui();
            //app.show();
        }
    }
}
