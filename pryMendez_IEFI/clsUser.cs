using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryMendez_IEFI
{
    public class clsUser
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public DateTime Birthday { get; set; }
        public int Age { get; set; }
        public bool Admin { get; set; }
        public List<string> Tasks { get; set; } = new List<string>();
    }
}
