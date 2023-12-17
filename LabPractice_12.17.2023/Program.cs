using LabTask_12._17._2023.Domain.Models;
using LabTask_12._17._2023.Service.Services;

PersonService personService = new PersonService();
personService.Filter(PersonService.FillStatic(), p => p.Salary < 500);
