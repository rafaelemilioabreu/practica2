using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication4.Pages
{
    public class NominaModel : PageModel
    {
        

        public List<string> nombres { get; set; } = new List<string>();
        public List<string> apellidos { get; set; } = new List<string>();
        public List<string> cargo { get; set; } = new List<string>();
        public List<int> salario { get; set; } = new List<int>();

        

        public double ARS(double n)
        {
            n = n * 0.0304;
            if (n > 4098.53)
            {
                n = 4098.53;
            }

            
           
            return n;

        }

        public double AFS(double n)
        {
            n = n*0.0287;
            if (n > 7738.67)
            {
                n = 7738.67;
            }

            return n;
        }

        public double IRS(double n)
        {
            if (n < 416220)
            {
                n = 0;
            }
            else if (n < 624329)
            {
                n = 416220 * 0.15;
            }

            else if(n < 867123)
            {
                n = (624329 * 0.2) + 31216;

            }

            else
            {
                n = (867123 * 0.25) + 79776;
            }

            return n;
        }

        public double Total(double afs, double ars, double irs)
        {
            double total = afs + ars + irs;

            return Math.Round(total);
        }

        public double Neto(double salario, double afs, double ars, double irs)
        {
            double total = salario - Total(afs,ars,irs);

            return Math.Round(total);
        }




        public void OnGet(int ars)

        {
            nombres.Add("Luigi");
            nombres.Add("Piera");
            nombres.Add("Jenrry");
            nombres.Add("Mario");
            nombres.Add("Valerie");

            apellidos.Add("Martinez");
            apellidos.Add("Rosario");
            apellidos.Add("Abreu");
            apellidos.Add("Carrasco");
            apellidos.Add("Rodriguez");

            cargo.Add("Diseñador");
            cargo.Add("Programador");
            cargo.Add("Analista");
            cargo.Add("Auditor");
            cargo.Add("Manager");

            salario.Add(40000);
            salario.Add(120000);
            salario.Add(130000);
            salario.Add(160000);
            salario.Add(624329);

            


            




        }

        

    }


   
}
