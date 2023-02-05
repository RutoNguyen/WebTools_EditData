'user strict';

app.service('backOrderService', ['$http', function ($http) {

    this.baseUrl = appConfigs.apiBaseUrl + "backOrderRoute/";

    this.changeBackOrderAddress = function (data) {
        return $http({
            method: 'POST',
            url: this.baseUrl + 'changeBackOrderAddress',
            data: data
        });
    };
}]);