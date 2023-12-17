using LabTask_12._17._2023.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask_12._17._2023.Domain.Models
{
    public class Person : BaseEntity
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Salary { get; set; }
        public string Adress { get; set; }

        public override string ToString()
        {
            return $"Id: {Id} Name: {Name} SurName: {SurName} Adress: {Adress} Salary: {Salary}";
        }
    }
}
