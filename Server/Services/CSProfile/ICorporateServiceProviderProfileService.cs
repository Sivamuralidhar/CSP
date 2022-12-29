namespace CSP.Server.Services.CSProfile
{
    public interface ICorporateServiceProviderProfileService
    {
        Task<string> CreateCorporateServiceProviderProfile(CSPProfileInfo cSPProfileInfo);
        public Task<List<CSPProfileInfo>> GetAllCSPProfiles();
        public Task<CSPProfileInfo> GetCSPProfileInfo(int profileId);
        public Task<string> UpdateCSPProfile(CSPProfileInfo cSPProfileInfo);
        public string DeleteCSPProfile(CSPProfileInfo cSPProfileInfo);
    }
}
