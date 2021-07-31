using BOL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UrlBL
    {
        private UrlDb urlDb;
        public UrlBL()
        {
            urlDb = new UrlDb();
        }
        public IEnumerable<tbl_Url> GetALL()
        {
            return urlDb.GetALL();
        }
        public void Insert(tbl_Url _tbl_Url)
        {
            urlDb.Insert(_tbl_Url);
        }
        public void Update(tbl_Url _tbl_Url)
        {
            urlDb.Update(_tbl_Url);
        }
        public void Delete(int Id)
        {
            urlDb.Delete(Id);
        }
        public void Save(tbl_Url _tbl_Url)
        {
            urlDb.Save(_tbl_Url);
        }
        public tbl_Url GetById(int Id)
        {
            return GetById(Id);
        }
    }
}
