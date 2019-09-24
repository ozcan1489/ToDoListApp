using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListApp.Entities
{
    public class EFNoticeDal : INoticeDal
    {
        public List<Notice> Notices()
        {
            using (DbAppContext dbAppContext = new DbAppContext())
            {
                return dbAppContext.Notices.ToList();
            }
        }
    }
}
