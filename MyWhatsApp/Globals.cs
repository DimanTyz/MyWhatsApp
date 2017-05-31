using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWhatsApp
{
    public class Globals
    {
        static AppData _db;

        public static AppData DB
        {
            get
            {
                if (_db == null)
                {
                    _db = new AppData();
                }
                return _db;
            }
        }
    }
}
