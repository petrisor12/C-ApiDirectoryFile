using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EsercitazioneApiDirectoryFile.Dati;
using EsercitazioneApiDirectoryFile.ProgettoApi.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EsercitazioneApiDirectoryFile.ProgettoApi.Controllers
{
    [Route("api/[controller]")]
    public class DatiController : Controller
    {
        private IDati _data;
        public DatiController(IDati dataAccess)
        {
            this._data = dataAccess;

        }
        // GET: api/values
        [HttpGet]
        public ActionResult <FolderModel> Get()
        {
            try
            {
                var dati = _data.GetFolder();



                return Ok(dati);
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex);
            }
        }

        /*   public ActionResult<IEnumerable<FileModel>> Get()
           {
               try
               {
                   var list = _data.GetFile();



                   return Ok(list);
               }
               catch (Exception ex)
               {

                   return StatusCode(500, ex);
               }

           } */

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
