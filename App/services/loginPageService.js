//'user strict';

//app.service('loginPageService', ['$http', function ($http) {

//    this.baseUrl = appConfigs.apiBaseUrl + "account/login";

//    this.loginPage = function (user) {
//        return $http({
//            method: 'POST',
//            url: this.baseUrl,
//            data: user
//        });
//    };
//}]);
'user strict';
app.service('loginPageService', ['$http', '$location', function ($http, $location) {

    this.baseUrl = appConfigs.apiBaseUrl + "account/login";

    this.loginService = function (user) {
        return $http({
            method: 'POST',
            url: this.baseUrl,
            data: user
        });
    };
}]);