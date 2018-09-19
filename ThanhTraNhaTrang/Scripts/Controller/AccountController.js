/// <reference path="HelperController.js" />

var AccountConfig = {
    searchString: '',
    pageSize: 10,
    pageIndex: 1,
}
var AccountMain = {
    init: function()
    {
        $(document).ready(function () {
            AccountMain.registerEventOnLoaded();
        });
    },
    registerEventOnLoaded: function()
    {
        $("#btnLogin").off('click').on('click', function () {
            
        });
       
    },
}
AccountMain.init();
