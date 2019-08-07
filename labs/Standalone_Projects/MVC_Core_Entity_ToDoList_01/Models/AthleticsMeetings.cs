using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Core_Entity_ToDoList_01.Models
{
    public class AthleticsMeetings
    {
        public int AthleticsMeetingsID { get; set; }
        public string MeetingName { get; set; }
        public string MeetingLocation { get; set; }

        [Display(Name = "MeetingDate")]
        [DataType(DataType.Date)]
        public DateTime MeetingDate { get; set; }
    }
}
