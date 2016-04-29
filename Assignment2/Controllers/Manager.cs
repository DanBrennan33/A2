using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
// new...
using AutoMapper;
using Assignment2.Models;

namespace Assignment2.Controllers
{
    public class Manager
    {
        // Reference to the data context
        private DataContext ds = new DataContext();

        public Manager()
        {
            // If necessary, add constructor code here
        }

        // Add methods below
        // Controllers will call these methods
        // Ensure that the methods accept and deliver ONLY view model objects and collections
        // The collection return type is almost always IEnumerable<T>

        // Suggested naming convention: Entity + task/action
        // For example:
        // ProductGetAll()
        // ProductGetById()
        // ProductAdd()
        // ProductEdit()
        // ProductDelete()

        public IEnumerable<EmployeeBase> EmployeeGetAll()
        {
            var c = ds.Employees.OrderBy(e => e.LastName).ThenBy(e => e.FirstName);

            return Mapper.Map<IEnumerable<EmployeeBase>>(c);
        }
        public EmployeeBase EmployeeGetOne(int? id)
        {
            var d = ds.Employees.Find(id);

            return (d == null) ? null : Mapper.Map<EmployeeBase>(d);
        }
        public EmployeeBase EmployeeAdd(EmployeeAdd newEmployee)
        {
            var AddedEmployee = ds.Employees.Add(Mapper.Map<Employee>(newEmployee));
            ds.SaveChanges();

            return (AddedEmployee == null) ? null : Mapper.Map<EmployeeBase>(newEmployee);
        }
    }
}