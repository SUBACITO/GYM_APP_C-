﻿using BaiTapQuanLy.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapQuanLy
{
    public class clsMain
    {
        public static string path = string.Format(@"{0}\Connection.ini", Application.StartupPath);
        public static string nickname = string.Empty;
        public static Account account = new Account();
    }
}
