using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InterestsApi.Models
{
    public class Interest
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Website> Websites { get; set; }
    }
}
