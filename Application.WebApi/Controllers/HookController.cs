using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Application.Data;
using Application.Service.Services;
using Application.WebApi.Models;

namespace Application.WebApi.Controllers
{
    public class HookController : ApiController
    {

        private IHookService hookService = new HookService();

        public IEnumerable<Hook> Get()
        {

            return hookService.GetHooks();
        }

        //public Hook Get(int id)
        public IHttpActionResult Get(int id)
        {
            //return hookService.GetHook(id);
            var hook = hookService.GetHook(id);
            if (hook == null)
                return NotFound();
            return Ok(hook);
        }

        public IHttpActionResult Post(Hook hook)
        {

            var isAdded = hookService.Add(hook);

            if (isAdded == true)
                return Ok();
            return BadRequest();

        }
        public IHttpActionResult Put(Hook hook)
        {
            var isUpdated = hookService.UpdateHook(hook);
            if (isUpdated == true)
                return Ok();
            return BadRequest();

        }

        public IHttpActionResult Delete(int id)
        {
            var isDeleted = hookService.DeleteHook(id);
            if (isDeleted == true)
                return Ok();
            return BadRequest();

        }
    }
}
