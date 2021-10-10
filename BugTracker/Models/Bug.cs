using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Models
{
    public class Bug
    {
        public int Id { get; set; }
        public string BugIssue { get; set; }
        public string Project { get; set; }
        public Bug()
        {

        }
    }
}
