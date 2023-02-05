'user strict';

//orderService
//oderService
app.service('orderService', ['$http', function ($http) {

    this.baseUrl = appConfigs.apiBaseUrl + "orderRoute/";

    this.changeOrderAddress = function (data) {
        return $http({
            method: 'POST',
            url: this.baseUrl + 'changeOrderAddress',
            data: data
        });
    };
}]);