using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Cheque.Web
{
    public class ConverterController : ApiController
    {
        // GET: api/Converter/5
        [HttpGet]
        [Route("api/Converter/{amount:decimal}/")]
        public IHttpActionResult Get(double amount)
        {
            try
            {
               // var convertedNumber = Double.Parse(number);
                var converter = new Helper.ConvertNumberToWords();
                return Ok(converter.ConvertIt(amount));
            }
            catch (Exception)
            {
               return  StatusCode(HttpStatusCode.InternalServerError);
            }
                
                
                
        }
       
    }
}
