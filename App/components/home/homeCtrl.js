'use strict';
app.controller('homeCtrl', ['$scope', 'navigateService',
    function ($scope, navigateService) {
        $scope.user = TPFUserName();

        this.$onInit = function () {
            if (TPFScHeader() === null) {
                navigateService.toLogin();
            }
        };
        $scope.Logout = function () {
            localStorage.removeItem(appConfigs.accessKey);
            localStorage.removeItem(appConfigs.usernameKey);
            navigateService.toLogin();
        };

        $scope.CreateShippingReqeust = function () {
            navigateService.toCreateShipment();
        };
    }]);
