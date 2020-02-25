using System;
using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Filters;

namespace WebApplication.Models
{
    public class UserModelExample : IExamplesProvider<UserModel>
    {
        public UserModel GetExamples()
        {
            return new UserModel
            {
                Id = Guid.NewGuid(),
                Name = "Michel"
            };
        }
    }
}