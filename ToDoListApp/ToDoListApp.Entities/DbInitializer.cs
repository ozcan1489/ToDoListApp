using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListApp.Entities
{
    public class DbInitializer : CreateDatabaseIfNotExists<DbAppContext>
    {
        protected override void Seed(DbAppContext context)
        {
            List<Notice> Notices = new List<Notice>()
            {
            new Notice() {NoticeDescription="Notice Description 1", NoticeDate=DateTime.Parse("1994-02-28")},
            new Notice() {NoticeDescription="Notice Description 2", NoticeDate=DateTime.Parse("1995-02-28")},
            new Notice() {NoticeDescription="Notice Description 3", NoticeDate=DateTime.Parse("1996-02-28")},
            new Notice() {NoticeDescription="Notice Description 4", NoticeDate=DateTime.Parse("1997-02-28")},
            };

            Notices.ForEach(notice => context.Notices.Add(notice));
            context.SaveChanges();
            base.Seed(context);

        }


    }
}
