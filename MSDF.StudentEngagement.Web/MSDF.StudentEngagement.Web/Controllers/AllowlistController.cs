using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MSDF.StudentEngagement.Persistence.CommandsAndQueries.Queries;
using Newtonsoft.Json;

namespace MSDF.StudentEngagement.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AllowlistController : ControllerBase
    {
        private readonly ILearningAppQueries _learningAppQueries;

        public AllowlistController(ILearningAppQueries learningAppQueries)
        {
            this._learningAppQueries = learningAppQueries;
        }

        // GET: api/Allowlist
        [HttpGet]
        public async Task<string> Get()
        {
            var Allowlist = (await _learningAppQueries.GetAll())
                .Select(la => new { app = la.LearningAppIdentifier, regex = la.AllowlistRegex })
                .ToList();

            var AllowlistJson = JsonConvert.SerializeObject(Allowlist);
            
            return AllowlistJson;
        }
    }
}
