using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListApp.Entities;

namespace ToDoListApp.Business
{
    public class NoticeManager : INoticeService
    {
        private INoticeDal _noticeDal;

        public NoticeManager(INoticeDal noticeDal)
        {
            _noticeDal = noticeDal;
        }

        public List<Notice> Notices()
        {
            return _noticeDal.Notices();
        }

    }
}
