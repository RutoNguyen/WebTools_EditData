'user strict';

app.service('backOrderRemoveItemService', ['$http', function ($http) {

    this.baseUrl = appConfigs.apiBaseUrl + "backOrderRoute/";

    this.changeBackOrderRemoveItem = function (data) {
        return $http({
            method: 'POST',
            url: this.baseUrl + 'changeBackOrderRemoveItem',
            data: data
        });
    };
}]);