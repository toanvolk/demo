/// <reference path="HelperController.js" />

var UserConfig = {
    searchString: '',
    pageSize: 10,
    pageIndex: 1,
}
var UserMain = {
    init: function () {
        $(document).ready(function () {
            UserMain.registerEventOnLoaded();
            //UserMain.loadData();
        });
    },
    registerEventOnLoaded: function () {
        $("#btnAdd").off('click').on('click', function () {
            $("#modalAddEdit").modal({ backdrop: 'static', keyboard: false });
            $("#title").text("Thêm người dùng");
        });
    },
    loadData: function () {
        $.ajax({
            url: "/User/LoadData",
            datatype: "json",
            type: "get",

            success: function (response) {
                if (response.statu) {
                    var data = response.data;
                    var html = '';
                    var template = $('#data-template').html();
                    $.each(data, function (i, item) {

                        html += Mustache.render(template, {
                            Index: 1,
                            UserId: item.UserID,
                            Email: item.Email,
                            UserGroupName: item.UserGroupName,
                            Sex: item.Sex,
                            FullName: item.FullName,
                            Note: item.Note,
                            Birthday: moment(item.Dirthday).format('DD-MM-YYYY'),
                            IsAdmin: item.IsAdmin,
                            UserCreate: item.UserCreate,
                            DateCreate: moment(item.DateCreate).format('DD-MM-YYYY'),
                            UserUpdate: item.UserUpdate,
                            DateUpdate: item.DateUpdate
                        });

                    });
                    $('#tblData').html(html);
                }
            }
        });
    },
    saveData: function () {
        var obj = {
            UserID: $("#").val(),
        };

    }
}
UserMain.init();
