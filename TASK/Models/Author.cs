using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK.Models
{
        public class Author
        {
            public int Id { get; set; }

            public string Name { get; set; } = string.Empty;

            public DateTime DateOfBirth { get; set; }

            public string Address { get; set; } = string.Empty;

            public int Age { get; set; }
        }

}
