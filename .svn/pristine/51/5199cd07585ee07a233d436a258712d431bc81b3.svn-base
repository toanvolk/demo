using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Connector
{
   public  class clsConnector
    {
       public string ProviderConnectString()
        {
            return ConfigurationManager.ConnectionStrings["TTNhaTrangDBContext"].ConnectionString.ToString();
        }
        public bool TestConnection(string _StrConnect = null)
        {
            System.Data.SqlClient.SqlConnection mCon = new System.Data.SqlClient.SqlConnection();
            if (_StrConnect != null)
            { mCon.ConnectionString = _StrConnect; }
            else
            { mCon.ConnectionString = ProviderConnectString(); }
            try
            {
                if (mCon.State == ConnectionState.Open) mCon.Close();
                mCon.Open();
                return true;
            }
            catch (Exception ex)
            {
               // MessageBox.Show("Không tìm thấy kết nối server hoặc dữ liệu chưa được tạo, vui lòng kiểm tra lại !", "Lỗi kết nối server");
                return false;
            }
        }
    }
}
