﻿/// <reference path="HelperController.js" />

var QuanHuyenConfig = {
    searchString: '',
    pageSize: 10,
    pageIndex: 1,
}
var QuanHuyenMain = {
    init: function()
    {
        $(document).ready(function () {
            QuanHuyenMain.registerEventOnLoaded();
        });
    },
    registerEventOnLoaded: function()
    {
        $("#btnAdd").off('click').on('click', function () {
            $("#modalAddEdit").modal({ backdrop: 'static', keyboard: false });
            $("#lblTitle").text("Thêm quận/huyện");
        });
       
    },
}
QuanHuyenMain.init();