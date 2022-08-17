using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oop.E1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            // Uzun uzun bunları yazmak yerine class olusturup bu yazdıgımız username,password,age ve job'ı tek bir çatı altında toplayı her seferinde tek tek değer vermemize gerek kalmıyacak.

            // user 1
            string userName = "Yavuz";
            string password = "123";
            int age = 18;
            string job = "developer";



            // User 2

            string userName2 = "Kemal";
            string passWord2 = "345";
            int age2 = 19;
            string job2 = "student";




        }
    }
}
