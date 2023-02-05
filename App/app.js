'use strict';
var appConfigs = {
    fileVesion: 476,
    apiBaseUrl: 'http://localhost:63685/',
    accessKey: "accessKey",
    usernameKey: "usernameKey"
};
//["ngRoute", "cp.ngConfirm", 'angular-loading-bar', 'ngAnimate', 'toastr', 'ngDialog', 'ui.router']
/*"ngRoute", "cp.ngConfirm", 'angular-loading-bar', 'ngAnimate', 'toastr', 'ngDialog', 'ui.router'*/
//tndNotifier, tndToastr
var app = angular.module("ff-app", ["ng", "ngRoute", "cp.ngConfirm", 'angular-loading-bar', 'toastr', 'ngAnimate', 'ngDialog', 'ui.router']).filter('tel', function () { });

app.config(['$stateProvider', '$urlRouterProvider',
    function ($stateProvider, $urlRouterProvider) {
        //$routeProvider
        //    .when("/login", {
        //        templateUrl: "App/components/loginPage/loginPage.html?v=" + appConfigs.fileVesion,
        //        controller: "loginPageCtrl",
        //        cache: false
        //    })
        //    .when("/home", {
        //        templateUrl: "App/components/header/nav.html?v=" + appConfigs.fileVesion,
        //        controller: "navCtrl",
        //        cache: false
        //    })
        //    .when("/backOrderChangeAddress", {
        //        templateUrl: "App/components/backOrder_Change_Address/backOrder_Change_Address.html?v=" + appConfigs.fileVesion,
        //        controller: "backOrderChangeAddressCtrl",
        //        cache: false
        //    })
        //    .when("/orderChangeAdderss", {
        //        templateUrl: "App/components/order_Change_Adderss/order_Change_Adderss.html?v=" + appConfigs.fileVesion,
        //        controller: "orderChangeAdderssCtrl",
        //        cache: false
        //    })
        //    .when("/backOrderChangeReplaceItem", {
        //        templateUrl: "App/components/backOrder_Change_ReplaceItem/backOrder_Change_ReplaceItem.html?v=" + appConfigs.fileVesion,
        //        controller: "backOrderChangeReplaceItemCtrl",
        //        cache: false
        //    })
        //    .when("/backOrderAddItem", {
        //        templateUrl: "App/components/backOrder_Add_Item/backOrder_Add_Item.html?v=" + appConfigs.fileVesion,
        //        controller: "backOrderAddItemCtrl",
        //        cache: false
        //    })
        //    .when("/backOrderRemoveItem", {
        //        templateUrl: "App/components/backOrder_Remove_Item/backOrder_RemoveItem.html?v=" + appConfigs.fileVesion,
        //        controller: "backOrderRemoveItemCtrl",
        //        cache: false
        //    })
        //    .otherwise({ redirectTo: "/login" });
        ///////////////////////////////
        //$stateProvider
        //    .state('loginPage', {
        //        name: "loginPage",
        //        url: '/loginPage',
        //        templateUrl: "App/components/loginPage/loginPage.html?v=" + appConfigs.fileVesion,
        //        /*controller: "loginPageCtrl",*/
        //        cache: false
        //    })
        //    .state('home', {
        //        name: 'home',
        //        url: '/home',
        //        templateUrl: "App/components/home/home.html?v=" + appConfigs.fileVesion,
        //        /*controller: "homeCtrl",*/
        //        cache: false
        //    })
        //    .state('backOrderChangeAddress', {
        //        name: "backOrderChangeAddress",
        //        url: '/backOrderChangeAddress',
        //        templateUrl: "App/components/backOrder_Change_Address/backOrder_Change_Address.html?v=" + appConfigs.fileVesion,
        //        /*controller: "backOrderChangeAddressCtrl",*/
        //        cache: false
        //    })
        //    .state('orderChangeAdderss', {
        //        name: "orderChangeAdderss page",
        //        url: '/orderChangeAdderss',
                
        //        templateUrl: "App/components/order_Change_Adderss/order_Change_Adderss.html?v=" + appConfigs.fileVesion,
        //        controller: "orderChangeAdderssCtrl",
        //        cache: false
        //    })
        //    .state('backOrder_Change_ReplaceItem', {
        //        name: "backOrderChangeReplaceItem",
        //        url: '/backOrderChangeReplaceItem',
                
        //        templateUrl: "App/components/backOrder_Change_ReplaceItem/backOrder_Change_ReplaceItem.html?v=" + appConfigs.fileVesion,
        //        controller: "backOrderChangeReplaceItemCtrl",
        //        cache: false
        //    })
        //    .state('backOrderAddItem', {
        //        name: "backOrderAddItem",
        //        url: '/backOrderAddItem',
                
        //        templateUrl: "App/components/backOrder_Add_Item/backOrder_Add_Item.html?v=" + appConfigs.fileVesion,
        //        controller: "backOrderAddItemCtrl",
        //        cache: false
        //    })
        //    .state('backOrderRemoveItem', {
        //        name: "backOrderRemoveItem",
        //        url: '/backOrderRemoveItem',
        //        //template: "<h1>/backOrderRemoveItem</h1>",
        //        templateUrl: "App/components/backOrder_Remove_Item/backOrder_RemoveItem.html?v=" + appConfigs.fileVesion,
        //        controller: "backOrderRemoveItemCtrl",
        //        cache: false
        //    })
        var loginState = {
            name: "loginPage",
            url: '/loginPage',
            templateUrl: "App/components/loginPage/loginPage.html?v=" + appConfigs.fileVesion,
            cache: false
        };
        var homeState = {
            name: 'home',
            url: '/home',
            templateUrl: "App/components/home/home.html?v=" + appConfigs.fileVesion,
            /*controller: "homeCtrl",*/
            cache: false
        };
        var orderChangeAddressState = {
            name: "home.order_Change_Address",
            url: '/order_Change_Address',
            templateUrl: "App/components/order_Change_Address/order_Change_Address.html?v=" + appConfigs.fileVesion,
            cache: false
        };
        var orderChangeEnvelopeState = {
            name: "home.order_Change_Envelope",
            url: '/order_Change_Envelope',
            templateUrl: "App/components/order_Change_Envelope/order_Change_Envelope.html?v=" + appConfigs.fileVesion,
            cache: false
        };
        var backOrderChangeAddressState = {
            name: "home.backOrder_Change_Address",
            url: '/backOrder_Change_Address',
            templateUrl: "App/components/backOrder_Change_Address/backOrder_Change_Address.html?v=" + appConfigs.fileVesion,
            cache: false
        };
        var backOrderChangeReplaceItemState = {
            name: "home.backOrder_Change_ReplaceItem",
            url: '/backOrder_Change_ReplaceItem',
            templateUrl: "App/components/backOrder_Change_ReplaceItem/backOrder_Change_ReplaceItem.html?v=" + appConfigs.fileVesion,
            cache: false
        };
        var backOrderChangeAddItemState = {
            name: "home.backOrder_Add_Item",
            url: '/backOrder_Add_Item',
            templateUrl: "App/components/backOrder_Add_Item/backOrder_Add_Item.html?v=" + appConfigs.fileVesion,
            cache: false
        };
        var backOrderChangeRemoveItemState = {
            name: "home.backOrder_Remove_Item",
            url: '/backOrder_Remove_Item',
            templateUrl: "App/components/backOrder_Remove_Item/backOrder_Remove_Item.html?v=" + appConfigs.fileVesion,
            cache: false
        };
        $stateProvider.state(loginState);
        $stateProvider.state(homeState);
        $stateProvider.state(orderChangeAddressState);
        $stateProvider.state(orderChangeEnvelopeState);
        $stateProvider.state(backOrderChangeAddressState);
        $stateProvider.state(backOrderChangeReplaceItemState);
        $stateProvider.state(backOrderChangeAddItemState);
        $stateProvider.state(backOrderChangeRemoveItemState);
        

        $urlRouterProvider.otherwise("/loginPage");
    }]);
 
app.config(function(toastrConfig) {
    angular.extend(toastrConfig, {
        allowHtml: true,
        closeButton: true,
        closeHtml: '<button>&times;</button>',
        extendedTimeOut: 1000,
        iconClasses: {
            error: 'toast-error',
            info: 'toast-info',
            success: 'toast-success',
            warning: 'toast-warning'
        },
        messageClass: 'toast-message',
        onHidden: null,
        onShown: null,
        onTap: null,
        progressBar: false,
        tapToDismiss: true,
        templates: {
            toast: 'directives/toast/toast.html',
            progressbar: 'directives/progressbar/progressbar.html'
        },
        timeOut: 5000,
        titleClass: 'toast-title',
        toastClass: 'toast',
        positionClass: 'toast-bottom-right'
    });
});
var TPFScHeader = function () {
    var accessKey = localStorage.getItem(appConfigs.accessKey);
    if (accessKey !== null) {
        return {
            "Authorization": "Bearer " + accessKey
        };
    }
    else {
        return null;
    }
};
var TPFUserName = function () {
    return localStorage.getItem(appConfigs.usernameKey);
};
