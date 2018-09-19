using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace ThanhTraNhaTrang.Controllers.System
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public JsonResult LoadData()
        {
            //info - json
            List<DataAccess.DataContext.Sys_UserList> data = new Business.Controllers.System.Sys_UserList().LoadData();

            return Json(new {
                data = data,
                statu = true
            }, JsonRequestBehavior.AllowGet);
        }

        public JsonResult SaveData(string strData, bool isInsert)
        {
            //info - json: message, statu
            string message = string.Empty;
            bool statu = false;
            DataAccess.DataContext.Sys_UserList ob = new JavaScriptSerializer().Deserialize<DataAccess.DataContext.Sys_UserList>(strData);
            Business.Controllers.IAccessModel access = new Business.Controllers.System.Sys_UserList(ob);

            #region Insert - Update

            if(isInsert)
            {
                statu = access.InsertData() > 0;
                if(statu)
                {
                    message = ControllerLibrary.DeclaredValue.MessageUnit.Instance.InsertSuccess;
                }
                else
                {
                    message = ControllerLibrary.DeclaredValue.MessageUnit.Instance.InsertFailure;
                }
            }
            else
            {
                statu =  access.UpdateData() > 0;
                if (statu)
                {
                    message = ControllerLibrary.DeclaredValue.MessageUnit.Instance.UpdateSuccess;

                }
                else
                {
                    message = ControllerLibrary.DeclaredValue.MessageUnit.Instance.UpdateFailure;
                }
            }
            #endregion

            return Json(new {
                message = message,
                statu = statu
            });
        }
    }
}