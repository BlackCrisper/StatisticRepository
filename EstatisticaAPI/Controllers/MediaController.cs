using EstatisticaAPI.Models;
using Microsoft.AspNetCore.Mvc;


namespace EstatisticaAPI.Controllers
{
    [Route("[controller]")]
    public class MediaController : Controller
    {
        [HttpGet]
        [Route("GetMedia")]
       public ActionResult<string> GetMedia(double n1, double n2, double n3, double n4)
       {
            Estatistica estatistica = new Estatistica();

            string[] valores = {n1.ToString(), n2.ToString(), n3.ToString(), n4.ToString()};

            return (estatistica.CalcularMedia(valores)).ToString();
       }

    }
        
}