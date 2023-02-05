'use strict';

app.controller('loginPageCtrl', ['$scope', '$window', '$timeout', 'toastr','loginPageService','navigateService',
    function ($scope, $window, $timeout, toastr, loginPageService, navigateService) {
        //toastr.success('Hello world!', 'Toastr fun!');
        $scope.user = {
            Username: "",
            Password: ""
        };
        $scope.disable = {
            BtnLogin: false
        };
        this.$onInit = function () {
            localStorage.removeItem(appConfigs.accessKey);
            localStorage.removeItem(appConfigs.usernameKey);
            if (TPFScHeader()) {
                navigateService.toHomePage();
            }
        };

        //$scope.ToLogin = function (e) {
        //    if (e.which === 13) {
        //        $scope.Login();
        //    }
        //};
        $scope.toke = [];
        /*$scope.error1 = [];*/

        $scope.Login = function () {
            $scope.disable.BtnLogin = true;
            loginPageService.loginService($scope.user).then(
                //function (res) {
                //    console.log(res);
                //    //$scope.token = res.data;
                //    //localStorage.setItem(appConfigs.accessKey, $scope.token);
                //    //localStorage.setItem(appConfigs.usernameKey, $scope.user.Username);

                //    var token = res.data;
                //    localStorage.setItem(appConfigs.accessKey, token);
                //    localStorage.setItem(appConfigs.usernameKey, $scope.user.Username);

                //    navigateService.toHomePage();
                //    $scope.disable.BtnLogin = false;
                //},
                //function (err) {
                //    toastr.error(err.data, 'Error');
                //    $scope.disable.BtnLogin = false;
                //}
                //,
                function (res) {
                    if (res.data == null) {
                        console.log("Login Error!");
                        var error = "Username/password is not correct";
                        toastr.error(error, 'Error');
                        $scope.disable.BtnLogin = false;
                    }
                    else {
                        console.log(res);
                        $scope.token = res.data;
                        localStorage.setItem(appConfigs.accessKey, $scope.token);
                        localStorage.setItem(appConfigs.usernameKey, $scope.user.Username);
                        //$window.localStorage.getItem(appConfigs.accessKey, $scope.token);
                        //$window.localStorage.getItem(appConfigs.usernameKey, $scope.user.Username)
                        navigateService.toHomePage();
                        $scope.disable.BtnLogin = false;
                    }

                }
            );
        };
    }]);