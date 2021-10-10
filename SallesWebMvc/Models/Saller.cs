using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SallesWebMvc.Models
{
    public class Saller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public double BaseSalary { get; set; }
        public Departament Departament { get; set; }
        public ICollection<SalesRecord> SaleRecords { get; set; } = new List<SalesRecord>();

        public Saller()
        {

        }

        public Saller(int id, string name, string email, DateTime birthDate, double baseSalary, Departament departament)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Departament = departament;
        }
        public void AddSales(SalesRecord sr)
        {
            SaleRecords.Add(sr);
        }
        public void RemovSales(SalesRecord sr)
        {
            SaleRecords.Remove(sr);
        }
        public double TotalSales(DateTime initial, DateTime final)
        {
            return SaleRecords.Where(sr => sr.Date >= initial && sr.Date <= final).Sum(sr => sr.Amount);
        }
    }
}
