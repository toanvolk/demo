﻿using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Infrastructure;
using System.Linq;

namespace ControllerLibrary.Language
{
    public static class Sys_Languages
    {
        private static DataAccess.DataContext.TTNhaTrangDBContext mDb_Context = DataAccess.DataContext.TTNhaTrangDBContext.Instance;
        public static string ReturnMessageName(string _MessageKey)
        {
            string mMessageName = _MessageKey;
            var mResult = mDb_Context.Sys_MessageList.Where(ob => ob.MessageKey == _MessageKey).FirstOrDefault();
            if (mResult != null) mMessageName = mResult.MessageName.ToString();
            return mMessageName;
        }

        public static int GetMaxLength<TEntity>(string field)
        {
            var Context = ((IObjectContextAdapter)mDb_Context).ObjectContext;
            var item = Context.MetadataWorkspace.GetItem<EntityType>(typeof(TEntity).FullName, DataSpace.CSpace);
            return (int)item.Properties[field].TypeUsage.Facets["MaxLength"].Value;
        }
        //public int ReturnMaxMaxLength(string _MessageKey)
        //{
        //    int sss = GetMaxLength<DataAccess.DataContext.Sys_UserList>("");
        //    string mMessageName = _MessageKey;
        //    var mResult = mDb_Context.Sys_MessageList.Where(ob => ob.MessageKey == _MessageKey).FirstOrDefault();
        //    if (mResult != null) mMessageName = mResult.MessageName.ToString();
        //    return mMessageName;
        //}
    }
}