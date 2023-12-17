using LabTask_12._17._2023.Domain.Models;
using LabTask_12._17._2023.Service.Exceptions;
using LabTask_12._17._2023.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask_12._17._2023.Service.Services
{
    public class PersonService : IPerson
    {
        public void Filter(List<Person> persons, Predicate<Person> filter)
        {
            List<Person> personsList = FillStatic();
            var editedList =  personsList.FindAll(filter);
            if (editedList.Count==0)
            {
                throw new NotFoundException();
            }
            foreach (Person person in editedList)
            {
                Console.WriteLine(person);

            }
        }
        public static List<Person> FillStatic()
        {
            Person person1 = new Person() {Id=1,Name="Nadir",SurName="Nadirov",Adress="Adress",CreatedAt = DateTime.Now,DeletedAt = DateTime.Now,Salary = 1400,UpdatedAt = DateTime.Now };
            Person person2 = new Person() { Id = 2, Name = "Teymur", SurName = "Nadirov", Adress = "Adress", CreatedAt = DateTime.Now, DeletedAt = DateTime.Now, Salary = 1400, UpdatedAt = DateTime.Now };
            Person person3 = new Person() { Id = 3, Name = "Nihad", SurName = "Nadirov", Adress = "Adress", CreatedAt = DateTime.Now, DeletedAt = DateTime.Now, Salary = 1400, UpdatedAt = DateTime.Now };
            List<Person> list = new List<Person>() { person1, person2 };
            return list;

        }
    }
}
