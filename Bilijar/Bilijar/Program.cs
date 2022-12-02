using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilijar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Table> tables = new List<Table>() { 
            new Table{ Id=1,Name="Prvi", Playing= false},
            new Table{ Id=2,Name="Drugi", Playing= false},
            new Table{ Id=3,Name="Treci", Playing= false},
            new Table{ Id=4,Name="Cetvrti", Playing= false},
            new Table{ Id=5,Name="Peti", Playing= false},
            new Table{ Id=6,Name="Sesti", Playing= false},
            new Table{ Id=7,Name="Sedmi", Playing= false},
            new Table{ Id=8,Name="Osmi", Playing= false},
            };
            here:
            Console.WriteLine("Unesite Id stola:");
            int unosKorisnika = Convert.ToInt32(Console.ReadLine());


            Table sto = tables.SingleOrDefault(q => q.Id == unosKorisnika);

            if(sto.Playing!=false)
            {
                Console.WriteLine("Ovaj sto je zauzet");
                Console.WriteLine("Da li zelite da prekinete vreme?(Y/N)");

            }
            else
            {
                sto.Playing = true;
                sto.Started = DateTime.Now;
                goto here;
            }
            
            
            string unos = Console.ReadLine().ToUpper();
            if(unos == "Y")
            {
                PrekidVremena(sto);
                DateDifferenceData differenceData = new DateDifferenceData(sto.Started, sto.Ended);

                Console.WriteLine("Za igru od {0} minuta i {1} sekundi duzni ste {2}",differenceData.Minutes,differenceData.Seconds,differenceData.Minutes*5);


            }else if(unos =="N")
            {
                goto here;
            }
            else
            {
                Console.WriteLine("Pogresan unos probajte ponovo");
            }

        }

        public static void PrekidVremena(Table table)
        {
            table.Ended = DateTime.Now;
            table.Playing = false;

            
        }
    }

    
}
