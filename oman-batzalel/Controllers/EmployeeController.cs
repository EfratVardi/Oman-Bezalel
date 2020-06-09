using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Bll;
using Dto;
using Dal;

namespace oman_batzalel.Controllers
{
    [RoutePrefix("api/Employee")]
    public class EmployeeController : ApiController
    {

        [Route("GetAll")]
        public IHttpActionResult GetAll()
        {
            try
            {
                var q =EmployeeBll.GetAllEmployees();
                return Ok(q);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [Route("DeleteEmployee/{id}")]
        public IHttpActionResult DeleteEmployee(int id)
        {
           EmployeeBll.DeleteEmployee(id);
            
                return Ok();
            
           
        }
        [Route("AddEmployee")]
        public IHttpActionResult AddEmployee([FromBody] Employee e )
        {
            
            EmployeeBll.AddEmployee(e);
            return Ok();


        }
        [Route("UpdateEmployee/{id}")]
        public IHttpActionResult UpdateEmployee(int id, [FromBody] Employee e)
        {

            EmployeeBll.UpdateEmployee(id,e);

            return Ok();

        }


    }



           
}
