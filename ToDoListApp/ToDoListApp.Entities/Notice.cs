using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListApp.Entities
{
    public class Notice
    {
        public int NoticeId { get; set; }
        public string NoticeDescription { get; set; }

        [DataType(DataType.Date)]
        public DateTime NoticeDate { get; set; }
    }
}
