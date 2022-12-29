using CSP.Server.Services.GeekProfile;
using Microsoft.AspNetCore.Mvc;


namespace CSP.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GeekProfileController : ControllerBase
    {
        private readonly IGeekProfileService _geekProfileService;
        private ILogger<GeekProfileController> _logger;
        public GeekProfileController(IGeekProfileService geekProfileService, ILogger<GeekProfileController> logger)
        {

            _geekProfileService = geekProfileService;
            _logger = logger;
        }


        [HttpGet("GetGeekProfiles")]
        public async Task<ActionResult<List<GeekProfileInfo>>> GetGeekProfiles()
        {
            var empList = await _geekProfileService.GetAllGeekProfiles();
            return Ok(empList);
        }


        public async Task<ActionResult<GeekProfileInfo>> GetGeekProfileByProfileId(int profileId)
        {
            var empList = _geekProfileService.GetGeekProfileInfo(1);
            return Ok(empList);
        }

        [HttpPost("CreateGeekProfiles")]
        public async Task<ActionResult<string>> CreateGeekProfiles(GeekProfileInfo geekProfileInfo)
        {
            try
            {
                var data = _geekProfileService.CreateGeekProfile(geekProfileInfo);
                return (Ok(data));
            }
            catch (Exception ex)
            {
                _logger.LogError($"logging error object{ex}");
            }
            return "";
        }
    }
}
