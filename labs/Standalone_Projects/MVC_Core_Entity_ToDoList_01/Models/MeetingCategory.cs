using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Core_Entity_ToDoList_01.Models
{
    public class MeetingCategory
    {
        public MeetingCategory()
        {
            AthleticsMeetings = new HashSet<Models.AthleticsMeetings>();
        }
        public int MeetingCategoryID { get; set; }
        public string CategoryName { get; set; }
        public virtual ICollection<Models.AthleticsMeetings> AthleticsMeetings { get; set; }
    }
}
