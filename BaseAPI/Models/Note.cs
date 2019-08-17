using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseAPI.Models
{
    public class Note
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime DateModified { get; set; }
        public DateTime DateCreated { get; set; }

        public Note()
        {
            Id = Guid.NewGuid();
        }
    }
}
