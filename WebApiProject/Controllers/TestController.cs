using Microsoft.AspNetCore.Mvc;
using System.Text;
using WebApiProject.Models;

namespace WebApiProject.Controllers
{
    [Route("api/Test")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpPost]
        public IActionResult TestEndpoint(TestObj obj)
        {
            if (obj.Number == 0) // 0 wystąpień = pusty string
                return Ok("");

            var sb = new StringBuilder();

            for (int i = obj.Text.Length-1; i >= 0; i--)
            {
                sb.Append(obj.Text[i]);
            }

            string reversed = sb.ToString();

            // wiem, że zaczynanie pętli od 1 jest "karygodne",
            // ale uznałam, że przy warunku "parzyste wystąpienie"
            // bardziej mylące byłoby iterowanie od 0 i odwracanie
            // warunku - tu 'i' jest wystąpieniem

            sb = new StringBuilder();

            for (int i = 1; i <= obj.Number; i++)
            {
                if (i % 2 == 0)
                    sb.Append(reversed);
                else
                    sb.Append(obj.Text);
            }

            string res = sb.ToString();

            return Ok(res);
        }

    }
}
