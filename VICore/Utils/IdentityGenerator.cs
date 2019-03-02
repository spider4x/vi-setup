using Bogus;
using Bogus.Bson;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VICore
{
    public class IdentityGenerator
    {
        public Identity Generate() {
            var testUsers = new Faker<Identity>()
                .CustomInstantiator(f => new Identity())

                .RuleFor(u => u.gender, f => f.PickRandom<Identity.Gender>())
                .RuleFor(u => u.FullName, (f, u) => f.Name.FullName())
                .RuleFor(u => u.Birthday, (f, u) => f.Person.DateOfBirth)
                .RuleFor(u => u.Address, (f, u) => f.Address.FullAddress())
                .RuleFor(u => u.Phone, (f, u) => f.Phone.PhoneNumber())

                .RuleFor(u => u.onlineCharacteristics, (f, u) => new Identity.OnlineCharacteristics
                {
                    Username = f.Internet.UserName(),
                    Password = f.Internet.Password(),
                    BrowserUserAgent = f.Internet.UserAgent(),
                    Email = f.Internet.Email()
                });

            return testUsers.Generate();
        }
        public string GenerateJson() {
            return GetJson(Generate());
        }
        public string GetJson(Identity identity) => JsonConvert.SerializeObject(identity);
    }
}
