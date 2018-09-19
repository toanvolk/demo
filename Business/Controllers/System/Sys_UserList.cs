using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Controllers.System
{
    public class Sys_UserList : IAccessModel
    {
        private DataAccess.DataContext.Sys_UserList objectData { get; set; }
        public Sys_UserList(DataAccess.DataContext.Sys_UserList ob)
        {
            objectData = ob;
        }
        public Sys_UserList() { }
        public List<DataAccess.DataContext.Sys_UserList> LoadData()
        {
            return new DataAccess.Models.System.Sys_UserModel().LoadData();
        }

        public int InsertData()
        {
            return new DataAccess.Models.System.Sys_UserModel().InsertData(objectData);
        }

        public int UpdateData()
        {
            return new DataAccess.Models.System.Sys_UserModel().UpdateData(objectData);
        }

        public int DeleteData()
        {
            throw new NotImplementedException();
        }

        void IAccessModel.LoadData()
        {
            throw new NotImplementedException();
        }
    }
}
