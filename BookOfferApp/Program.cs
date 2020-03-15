using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookOfferApp
{
    static class Program
    {
        //programı açan kullanıcının idsi burada tutuluyor.
        //başka formlardan da bu id uye er5işmem için burada tanımladım.
        public static int CurrentUserId;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //hangi formdan başlayacağını buradan belirtiyoruz. frmLogin formundan başlıyor program.
            Application.Run(new frmLogin());
        }
    }
}
