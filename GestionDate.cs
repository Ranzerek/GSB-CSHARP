﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GSBCSHARP
{
    class GestionDate
    {

        DateTime ajd = DateTime.Now;
        public String dateJour()
        {
            String asString = ajd.ToString("yyyy-MM-dd");
            return asString;
        }

        public String moisPrecedent()
        {
            ajd = ajd.AddMonths(-1);
            String asString = ajd.ToString("yyyyMM");

            return asString;
        }
        public String moisCourant()
        {
        
            String asString = ajd.ToString("yyyyMM");

            return asString;
        }

        public String moisSuivant()
        {
            ajd = ajd.AddMonths(+1);
            String asString = ajd.ToString("yyyyMM");

            return asString;
        }
    }


}
