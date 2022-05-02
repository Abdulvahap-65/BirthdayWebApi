using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BirthdayWebApi.Models;
namespace BirthdayWebApi.Controllers
{
    public class InvitationController : ApiController
    {
        //[HttpGet]
   
        public IEnumerable<InvitationModel>GetAttendees()
        {
            return Database.List.Where(i => i.JoiningCase == true);
        }
        public IEnumerable<InvitationModel> GetNotAttendees()
        {
            return Database.List.Where(i => i.JoiningCase == false);
        }
        //[HttpPost]PostAdd
        public void Add(InvitationModel model)
        {
            if(ModelState.IsValid)
            {
                Database.Add(model);
            }
        
           
        }
    }
}
