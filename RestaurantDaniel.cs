using System;

namespace KISS.kiss
{
    public class RestaurantDaniel
    {
        public static void Main()
        {
        }

        public static decimal CalcularTotal(decimal[] precios, decimal? tipPorsentage)
        {
            decimal total = 0;
            foreach (decimal prec in precios)
            {
                total += prec;
            }

            total = tipPorsentage.HasValue ? total += total * (tipPorsentage.Value / 100) : total += total * 0.10m;

            return total;
        }
    }
}