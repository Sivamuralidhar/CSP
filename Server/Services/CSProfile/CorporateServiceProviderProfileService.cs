using CSP.Server.Controllers;
using CSP.Server.Services.GeekProfile;
using Microsoft.AspNetCore.Mvc;

namespace CSP.Server.Services.CSProfile
{
    public class CSProfileService : ICorporateServiceProviderProfileService
    {
        private ApplicationDbContext _db;
        private ILogger<CSProfileService> _logger;
        public CSProfileService(ApplicationDbContext dbContext, ILogger<CSProfileService> logger)
        {
            _db = dbContext;
            _logger = logger;
        }
        public async Task<string> CreateCorporateServiceProviderProfile(CSPProfileInfo cSPProfileInfo)
        {
            _db.CSPProfiles.Add(cSPProfileInfo);
            _db.SaveChanges();
            return "Created CSP Profile Successfully";
        }
        public async Task<List<CSPProfileInfo>> GetAllCSPProfiles()
        {
            var cspProfile = await Task.Run(() => _db.CSPProfiles.OrderByDescending(o => o.ProfileId).ToListAsync());
            return cspProfile;
        }


        public async Task<CSPProfileInfo> GetCSPProfileInfo(int profileId)
        {
            CSPProfileInfo cSPProfileInfo = _db.CSPProfiles.FirstOrDefault(g => g.ProfileId == profileId);
            return cSPProfileInfo;
        }

        public string DeleteCSPProfile(CSPProfileInfo cSPProfileInfo)
        {
            _db.CSPProfiles.Remove(cSPProfileInfo);
            _db.SaveChanges();
            return "Deleted CSP Profile Successfully";
        }


        public Task<string> UpdateCSPProfile(CSPProfileInfo cSPProfileInfo)
        {
            var j = _db.CSPProfiles.Update(cSPProfileInfo);
            _db.SaveChanges();
            return Task.FromResult("Updated CSP Profile Successfully");
        }

    }
}
