using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Asp5RIWebsite.Storage
{
    public class TestDataStorage : IStorage
    {
        private List<Company> companies;

        public TestDataStorage()
        {
            companies = new List<Company>()
            {
                new Company { Id = GenerateId(), Name = "Apple Inc" },
                new Company { Id = GenerateId(), Name = "Google Inc" },
                new Company { Id = GenerateId(), Name = "Microsoft Inc" },
            };
        }

        public Company[] GetCompanies()
        {
            return companies.ToArray();
        }

        private string GenerateId()
        {
#if DNX451
            return MongoDB.Bson.ObjectId.GenerateNewId().ToString();
#else
            return Guid.NewGuid().ToString();
#endif
        }
    }
}
