using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< HEAD

=======
>>>>>>> 31e2641905988b0b302ed7420f3bb0185a4ec83e
namespace Projet_GONLO
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MenuAccueil());
            //Application.Run(new CreationPerso());
            Application.Run(new StartForm());
            //Application.Run(new Pazaak());

        }
    }
}
