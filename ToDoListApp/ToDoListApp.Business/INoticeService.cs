using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListApp.Entities;

namespace ToDoListApp.Business
{
    public interface INoticeService
    {
        List<Notice> Notices();
    }
}
