'user strict';

app.service('backOrderReplaceItemService', ['$http', function ($http) {

    this.baseUrl = appConfigs.apiBaseUrl + "backOrderRoute/";

    this.changeBackOrderReplaceItem = function (data) {
        return $http({
            method: 'POST',
            url: this.baseUrl + 'changeBackOrderReplaceItem',
            data: data
        });
    };
}]);