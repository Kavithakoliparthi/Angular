using EmployeeDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EmployeeService.Controllers
{
   public class EmployeesController : ApiController
   {
    //    public IEnumerable<Employee> Get()
    //    {
    //        using (EmployeeDBEntities e = new EmployeeDBEntities())
    //        {
    //            return e.Employees.ToList();
    //        }
    //    }

       
        //public Employee Get(int id)
        //{
        //    using (EmployeeDBEntities e = new EmployeeDBEntities())
        //    {
        //        return e.Employees.FirstOrDefault(emp => emp.ID == id);
        //    }
        //}
        public HttpResponseMessage Get(int id)
        {
            using (EmployeeDBEntities entities = new EmployeeDBEntities())
            {
                var entity = entities.Employees.FirstOrDefault(e => e.ID == id);
                if(entity != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, entity);
                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Employee id"+id.ToString()+"not found");
                }
            }
        }
        public HttpResponseMessage Post([FromBody] Employee employee)
        {
            try
            {
                using (EmployeeDBEntities e = new EmployeeDBEntities())
                {
                    e.Employees.Add(employee);
                    e.SaveChanges();
                    var message = Request.CreateResponse(HttpStatusCode.Created, employee);
                    message.Headers.Location = new Uri(employee.ID.ToString());
                    return message;
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                using (EmployeeDBEntities entities = new EmployeeDBEntities())
                {
                    var entity = entities.Employees.Remove(entities.Employees.FirstOrDefault(e => e.ID == id));
                    if (entity == null)
                    {
                        return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Employee with Id =" + id.ToString());
                    }
                    else
                    {
                        entities.Employees.Remove(entity);
                        entities.SaveChanges();
                        return Request.CreateResponse(HttpStatusCode.OK);
                    }
                }
            }
            catch(Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest,ex);
            }
        }
        //public void put(int id,[FromBody]Employee employee)
        //{
        //    using (EmployeeDBEntities entities = new EmployeeDBEntities())
        //    {
        //        var entity = entities.Employees.FirstOrDefault(e => e.ID == id);

        //        entity.Name = employee.Name;
        //        entity.Gender = employee.Gender;
        //        entity.Salary = employee.Salary;
        //        entities.SaveChanges();
        //    }
        //}
        public HttpResponseMessage put([FromBody] int id, [FromUri]Employee employee)
        {
            try {
                using (EmployeeDBEntities entities = new EmployeeDBEntities())
                {
                    var entity = entities.Employees.FirstOrDefault(e => e.ID == id);
                    if (entity == null)
                    {
                        return Request.CreateResponse(HttpStatusCode.NotFound, "Employee with id=" + id.ToString() + "not found");
                    }
                    else
                    {
                        entity.Name = employee.Name;
                        entity.Gender = employee.Gender;
                        entity.Salary = employee.Salary;
                        entities.SaveChanges();
                        return Request.CreateResponse(HttpStatusCode.OK, entity);
                    }
                }
            }
            catch(Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }
    }
}

