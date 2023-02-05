
'use strict';
app.controller("orderManualRemoveItemCtrl", ['$scope', 'toastr', 'orderManualRemoveItemService',
    function ($scope, toastr, orderManualRemoveItemService) {
        $scope.orderManualRemoveItemObj = {
            clubID: "ITT",
            orderID: 809589632,
            itemType: "item",
            clubRefID: "",
            flag: "",
            statusnotes: "",
            TPF_Notes: "IT-TEST",
            IsRun: false
        };

        $scope.viewData = [];
        $scope.onOrderManualRemoveSubmit = function () {
            console.log($scope.orderManualRemoveItemObj);
            if ($scope.orderManualRemoveItemObj.ClubCode == "") {
                var error = "ClubCode is not null";
                toastr.error(error, 'Error');
            }
            else if ($scope.orderManualRemoveItemObj.OrderID == "") {
                var error = "OrderID is not null";
                toastr.error(error, 'Error');
            }
            else if ($scope.orderManualRemoveItemObj.Note == "") {
                var error = "Note is not null";
                toastr.error(error, 'Error');
            }
            else {
                orderManualRemoveItemService.orderManualRemoveItem($scope.orderManualRemoveItemObj).then(
                    function (response) {
                        console.log(response.data);
                        if (response.data.length === 0) {
                            var error = "No Order found";
                            toastr.error(error, 'Error');
                        }
                        else {

                            $scope.viewData = response.data;
                        }
                    },
                    function (err) {
                        console.log(err);
                        var mess_err = err.data.InnerException.ExceptionMessage;
                        toastr.error(mess_err, "data is incorrect");
                    }
                );
            }
        }
    }]);
