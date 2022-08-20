﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop.E1
{
    public class User
    {
        public string userName { get; set; }
        public string passWord { get; set; }
        public int age { get; set; }
        public string job { get; set; }

         public void Login(string loginDate)
        {
            System.Windows.Forms.MessageBox.Show($"{loginDate} tarihinde {userName} kullanıcısı tarafından {passWord} şifresi ile giriş yapılmıştır.");
        }

    }
}
