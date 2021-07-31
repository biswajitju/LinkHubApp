using BOL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UrlDb
    {
        private LinkHubDBContext linkHubDBContext;
        public UrlDb()
        {
            linkHubDBContext = new LinkHubDBContext();
        }

        public IEnumerable<tbl_Url> GetALL()
        {
            return linkHubDBContext.tbl_Url.ToList();
        }
        public void  Insert(tbl_Url _tbl_Url)
        {
            linkHubDBContext.tbl_Url.Add(_tbl_Url);
        }
        public void Update(tbl_Url _tbl_Url)
        {
            linkHubDBContext.Entry(_tbl_Url).State = EntityState.Modified;
        }
        public void Delete(int Id)
        {
            tbl_Url _tbl_Url = linkHubDBContext.tbl_Url.Find(Id);
            linkHubDBContext.tbl_Url.Remove(_tbl_Url);

        }
        public void Save(tbl_Url _tbl_Url)
        {
            linkHubDBContext.SaveChanges();
        }
        public tbl_Url GetById(int Id)
        {
            return linkHubDBContext.tbl_Url.Find(Id);
        }
    }
}
