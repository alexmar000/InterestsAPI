using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InterestsApi.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public List<Interest> Interests { get; set; }
    }
}
