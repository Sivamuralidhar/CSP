using CSP.Server.Services.CSProfile;
using CSP.Server.Services.GeekProfile;
using Microsoft.AspNetCore.Mvc;

namespace CSP.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CSPProfileController : ControllerBase
    {
        private ApplicationDbContext _db;
        private readonly ICorporateServiceProviderProfileService _corporateServiceProviderProfileService;
        private ILogger<CSPProfileController> _logger;
        public CSPProfileController(ApplicationDbContext dbContext, ICorporateServiceProviderProfileService corporateServiceProviderProfileService, ILogger<CSPProfileController> logger)
        {
            _db = dbContext;
            _corporateServiceProviderProfileService = corporateServiceProviderProfileService;
            _logger = logger;
        }


        [HttpGet]
        public async Task<ActionResult<List<CSPProfileInfo>>> GetAllCSPProfiles()
        {
            var empList = await _corporateServiceProviderProfileService.GetAllCSPProfiles();
            return Ok(empList);
        }


        public async Task<ActionResult<CSPProfileInfo>> GetCSPProfileInfoByProfileId(int profileId)
        {
            var empList = await _corporateServiceProviderProfileService.GetCSPProfileInfo(profileId);
            return Ok(empList);
        }

        [HttpPost("CreateCorporateServiceProviderProfile")]
        public async Task<ActionResult<string>> CreateCorporateServiceProviderProfile(CSPProfileInfo cSPProfileInfo)
        {
            try
            {
                var data = _corporateServiceProviderProfileService.CreateCorporateServiceProviderProfile(cSPProfileInfo);
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
