using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.DataContext;
using System.Reflection;

namespace DataAccess.Models.System
{
    public class Sys_UserModel 
    {
        private DataContext.TTNhaTrangDBContext mDb_Context = DataContext.TTNhaTrangDBContext.Instance;
        private DataContext.Sys_UserList objectData { get; set; }
        public List<DataContext.Sys_UserList> LoadData()
        {
            return mDb_Context.Sys_UserList.ToList();
        }
        public int InsertData(Sys_UserList t)
        {
            mDb_Context.Sys_UserList.Add(t);
            return mDb_Context.SaveChanges();
        }

        public int UpdateData(Sys_UserList t)
        {
            

            Sys_UserList ob = mDb_Context.Sys_UserList.FirstOrDefault(o=>o.UserID == t.UserID);
            if (ob == null)
                return -1;

            ob.UserID = t.UserID;
            ob.Email = t.Email;
            ob.FullName = t.FullName;
            ob.Dirthday = t.Dirthday;
            ob.Sex = t.Sex;
            ob.UserGroupID = t.UserGroupID;
            ob.UserGroupName = t.UserGroupName;
            ob.PassWord = t.PassWord;
            ob.IsAdmin = t.IsAdmin;
            ob.Note = t.Note;
            ob.IsActivate = t.IsActivate;
            ob.UserCreate = t.UserCreate;
            ob.DateCreate = t.DateCreate;
            ob.UserUpdate = t.UserUpdate;
            ob.DateUpdate = t.DateUpdate;

            return mDb_Context.SaveChanges();
        }
       
        public int DeleteData(Sys_UserList t)
        {
            throw new NotImplementedException();
        }
    }
}
