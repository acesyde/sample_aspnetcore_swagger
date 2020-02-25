using System;
using Newtonsoft.Json;

namespace WebApplication.Models
{
    public class UserModel
    {
        public Guid Id { get; set; }
        
        [JsonProperty("UserName")]
        public string Name { get; set; }
    }
}