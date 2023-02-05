'user strict';

//orderEnvelopeService
app.service('orderEnvelopeService', ['$http', function ($http) {

    this.baseUrl = appConfigs.apiBaseUrl + "orderRoute/";

    this.changeOrderEnvelope = function (data) {
        return $http({
            method: 'POST',
            url: this.baseUrl + 'changeOrderEnvelope',
            data: data
        });
    };
}]);