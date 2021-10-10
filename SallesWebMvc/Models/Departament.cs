using System;
using System.Collections.Generic;
using SallesWebMvc.Models;
using System.Linq;
using System.Threading.Tasks;

namespace SallesWebMvc.Models
{
    public class Departament
    {
        public int Id{ get; set; }
        public string Name { get; set; }
        public ICollection<Saller> Sellers { get; set; } = new List<Saller>();

        public Departament()
        {

        }

        public Departament(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public void AddSellers(Saller saller)
        {
            Sellers.Add(saller);
        }
        public double TotalSellers(DateTime initial, DateTime final)
        {
            return Sellers.Sum(sallers => sallers.TotalSales(initial, final));
        }
    }
}
