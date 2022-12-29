using CSP.Client.Utilities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace CSP.Server.Services.GeekProfile
{
    public class GeekProfileService : IGeekProfileService
    {
        private readonly ApplicationDbContext _db;

        public GeekProfileService(ApplicationDbContext db)
        {
            _db = db;
        }

        public string CreateGeekProfile(GeekProfileInfo profile)
        {
            _db.GeekProfiles.Add(profile);
            _db.SaveChanges();
            return "Created Profile Successfully";
        }

        public async Task<List<GeekProfileInfo>> GetAllGeekProfiles()
        {
            try
            {
                var geekProfile = await Task.Run(() => _db.GeekProfiles.OrderByDescending(o => o.GeekProfileId).ToListAsync());                 
                return geekProfile;
            }
            catch (Exception ex)
            {
                return new List<GeekProfileInfo>() { };
            }
        }
        public GeekProfileInfo GetGeekProfileInfo(int profileId)
        {
            GeekProfileInfo geekProfile = _db.GeekProfiles.FirstOrDefault(g => g.GeekProfileId == profileId);
            return geekProfile;
        }

        public Task<string> UpdateGeekProfile(GeekProfileInfo geekProfile)
        {
            var j = _db.GeekProfiles.Update(geekProfile);
            _db.SaveChanges();
            return Task.FromResult("Updated Geek Profile Successfully");
        }

        public string DeleteGeekProfile(GeekProfileInfo geekProfile)
        {
            _db.GeekProfiles.Remove(geekProfile);
            _db.SaveChanges();
            return "Deleted Geek Profile Successfully";
        } 
    }
}
