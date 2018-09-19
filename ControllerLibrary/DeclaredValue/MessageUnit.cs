using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerLibrary.DeclaredValue
{
    public class MessageUnit
    {
        #region Singleton
        private static MessageUnit instance = null;
        private static readonly object padlock = new object();
        public static MessageUnit Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (padlock)
                    {
                        if (instance == null)
                        {
                            instance = new MessageUnit();
                        }
                    }
                }
                return instance;
            }
        }
        private MessageUnit() { }
        #endregion

        public string InsertSuccess = "Thêm thành công";
        public string UpdateSuccess = "Cập nhật thành công";

        public string InsertFailure = "Thêm không thành công";
        public string UpdateFailure = "Cập nhật không thành công";
    }
}
