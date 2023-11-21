using P03.Detail_Printer.Interfaces;
using System;
using System.Collections.Generic;

namespace P03.DetailPrinter
{
    public class DetailsPrinter
    {
        private List<INameble> employees;
        private string name;
        private ICollection<string> documents;

        public DetailsPrinter()
        {
            this.employees = new List<INameble>()
            {
                new Employee(name),
                new Manager(name, documents)
            };
        }

        public void PrintDetails()
        {
            foreach (var employee in this.employees)
            {
                employee.Print();
            }
        }
    }
}
