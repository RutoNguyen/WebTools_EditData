'use strict';
app.service('navigateService', ['$http', '$location', function ($http, $location) {
    this.toLogin = function () {
        $location.path("/loginPage");
    };
    this.toHomePage = function () {
        $location.path("/home/order_Change_Address");
    };
    this.toCreateShipment = function () {
        $location.path("/home/shipping-request").search({ reqId: null, po: null });
    };

    //this.toEditRequest = function (reqId) {
    //    var url = appConfigs.apiBaseUrl + "#!/home/wip-request?reqId=" + reqId;
    //    window.open(url);
    //};
}]);