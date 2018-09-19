using System;
using System.Linq;
using System.Data.SqlClient; 

namespace DataAccess.Models
{
    public class  Sys_AccountModel
    {
        private DataContext.TTNhaTrangDBContext mDb_Context = null; 

        public Sys_AccountModel()
        {
            //mDb_Context = new DataContext.TTNhaTrangDBContext(); 
        }
        
        public bool Login(string _UserName,string _PassWord)
        {
            //Sử dụng store
            object[] mParam = { new SqlParameter("@UserName", _UserName), new SqlParameter("@Pass", _PassWord) };
            var mResult = mDb_Context.Database.SqlQuery<bool>("Sys_Stp_AccountLogin", mParam).SingleOrDefault();
            // Sử dụng Linq
            //var mResult= mDb_Context.Sys_UserList.Count(x => x.UserID == _UserName && x.PassWord== _PassWord);
            //return (mResult > 0 ? true : false);
            return mResult; 
        }
    }
}
