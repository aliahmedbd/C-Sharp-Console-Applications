using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Product
{
    static class IDGENERATOR
    {
        private static int serial_no = 1, preDate;

        public static string generator()
        {
            int dateKeeper;
            string idNo;
            dateKeeper = DateTime.Now.Month;
            if (dateKeeper == preDate)
            {

                idNo = idGen();
                preDate = DateTime.Now.Month;
                return idNo;
            }
            else
            {
                serial_no = 1;
                idNo = idGen();
                preDate = DateTime.Now.Month;
                return idNo;
            }


        }
        public static String idGen()
        {
            string id = DateTime.Now.Year + " - " + DateTime.Now.Month + " - " + serial_no;
            serial_no++;
            return id;
        }

        
    }
}
