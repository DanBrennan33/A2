using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment2.Controllers
{
    public class EmployeeController : Controller
    {
        private Manager man = new Manager();

        // GET: Employee
        public ActionResult Index()
        {
            return View(man.EmployeeGetAll());
        }

        // GET: Employee/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
                return HttpNotFound();
            else
                return View(man.EmployeeGetOne(id));
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            return View(new EmployeeBase());
        }

        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(EmployeeAdd NewEmployee)
        {
            try
            {
                // TODO: Add insert logic here
                if (!ModelState.IsValid)
                {
                    return View(NewEmployee);
                }
                var AddedEmployee = man.EmployeeAdd(NewEmployee);
                if (AddedEmployee == null)
                {
                    return View(NewEmployee);
                }
                else
                {
                    return RedirectToAction("details", new { id = AddedEmployee.EmployeeId });
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Employee/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
