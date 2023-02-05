'user strict';

//orderService
//oderService
app.service('orderManualRemoveItemService', ['$http', function ($http) {

    this.baseUrl = appConfigs.apiBaseUrl + "orderRoute/";

    this.orderManualRemoveItem = function (data) {
        return $http({
            method: 'POST',
            url: this.baseUrl + 'orderManualRemoveItem',
            data: data
        });
    };
}]);