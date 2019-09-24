using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListApp.Entities;

namespace ToDoListApp.Business
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<INoticeService>().To<NoticeManager>().InSingletonScope();
            Bind<INoticeDal>().To<EFNoticeDal>().InSingletonScope();
        }
    }
}
