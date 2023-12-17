using LabTask_12._17._2023.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask_12._17._2023.Service.Interfaces
{
    internal interface IPerson
    {
        void Filter(List<Person> persons, Predicate<Person> filter);
    }
}
