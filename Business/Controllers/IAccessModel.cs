using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Controllers
{
    public interface IAccessModel
    {
        void LoadData();
        int InsertData();
        int UpdateData();
        int DeleteData();
    }
}
