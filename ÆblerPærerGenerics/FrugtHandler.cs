﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÆblerPærerGenerics
{
    public static class FrugtHandler
    {

        public static decimal CalculateSumÆbler(List<Æbler> list)
        {
            decimal sum = 0;
            foreach (var l in list)
            {
                sum += (l.Pris * l.Lager);
            }

            return sum;
        }

        public static decimal CalculateSumPærer(List<Pærer> list)
        {
            decimal sum = 0;
            foreach (var l in list)
            {
                sum += (l.Pris * l.Lager);
            }

            return sum;
        }
    }
}
