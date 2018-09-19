using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerLibrary.Functions
{
  public class Functions
    {
        DataAccess.DataContext.TTNhaTrangDBContext mDB_Context = null;
        public int GetMaxLength<TEntity>(string field)
        {
            //mDB_Context = new DataAccess.DataContext.TTNhaTrangDBContext(); 
            //var Context = ((IObjectContextAdapter)mDB_Context).ObjectContext;

            mDB_Context = DataAccess.DataContext.TTNhaTrangDBContext.Instance;
            var Context = ((IObjectContextAdapter)mDB_Context).ObjectContext;

            var item = Context.MetadataWorkspace.GetItem<EntityType>(typeof(TEntity).FullName, DataSpace.CSpace);
            return (int)item.Properties[field].TypeUsage.Facets["MaxLength"].Value;
        }
    }
}
