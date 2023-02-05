
'use strict';
app.controller("orderChangeAdderssCtrl", ['$scope', 'toastr', 'orderService',
    function ($scope, toastr, orderService) {
        $scope.changeOrderAddressObj = {
            ClubCode: "ITT",
            OrderID: 809589632,
            Street1: "",
            Street2: "",
            Suburb: "",
            State: "",
            PostCode: "",
            Country: "",
            CompanyName: "",
            Phone: "",
            Note: "IT-TEST",
            IsRun: false
        };

        $scope.viewData = [];
        $scope.onChangeOrderAddressSubmit = function () {
            console.log($scope.changeOrderAddressObj);
            if ($scope.changeOrderAddressObj.ClubCode == "") {
                var error = "ClubCode is not null";
                toastr.error(error, 'Error');
            }
            else if ($scope.changeOrderAddressObj.OrderID == "") {
                var error = "OrderID is not null";
                toastr.error(error, 'Error');
            }
            else if ($scope.changeOrderAddressObj.Note == "") {
                var error = "Note is not null";
                toastr.error(error, 'Error');
            }
            else {
                orderService.changeOrderAddress($scope.changeOrderAddressObj).then(
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
