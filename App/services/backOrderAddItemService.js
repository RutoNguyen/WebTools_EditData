'user strict';

app.service('backOrderAddItemService', ['$http', function ($http) {

    this.baseUrl = appConfigs.apiBaseUrl + "backOrderRoute/";

    this.changeBackOrderAddItem = function (data) {
        return $http({
            method: 'POST',
            url: this.baseUrl + 'changeBackOrderAddItem',
            data: data
        });
    };
}]);