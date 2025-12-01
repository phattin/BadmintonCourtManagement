using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUI.Utils;

namespace GUI.Utils
{
    public class Additional
    {
        public string beautyMoney (double money)
        {
            return money.ToString("#,##0 ₫", new CultureInfo("vi-VN"));
        }
    }
}
