

namespace CSP.Server.Services.GeekProfile;

public interface IGeekProfileService
{
    string CreateGeekProfile(GeekProfileInfo geekProfileInfo);
    public Task<List<GeekProfileInfo>> GetAllGeekProfiles();
    public GeekProfileInfo GetGeekProfileInfo(int profileId);
    public Task<string> UpdateGeekProfile(GeekProfileInfo geekProfile);
    public string DeleteGeekProfile(GeekProfileInfo geekProfile);
}
