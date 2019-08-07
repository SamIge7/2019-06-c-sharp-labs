using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MVC_Core_Entity_ToDoList_01.Models
{
    public class Task
    {
        public int TaskID { get; set; }
        public string TaskName { get; set; }
        [Display(Name = "DueDate")]
        [DataType(DataType.Date)]
        public DateTime DueDate { get; set; }
        //Foreign Key CategoryID
        public int? CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}
