

app.controller("backOrderChangeAddressCtrl", ['$scope', 'toastr', 'backOrderService',
    function ($scope, toastr, backOrderService) {
        $scope.changeBackOrderAddressObj = {
            ClubCode: "ITT",
            UploadID: 34513,
            RecordIDList: "20246184,20246185,20246186",
            Street1: "",
            Street2: "",
            Suburb: "",
            State: "",
            PostCode: "",
            Country: "",
            CompanyName: "",
            Phone: "",
            Email: "",
            Note: "IT-TEST",
            IsRun: false
        };

        //$scope.viewData = [];
        $scope.onChangeBackOrderAddressSubmit = function () {
            console.log($scope.changeBackOrderAddressObj);
            if ($scope.changeBackOrderAddressObj.ClubCode == "") {
                var error = "ClubCode is not null";
                toastr.error(error, 'Error');
            }
            else if ($scope.changeBackOrderAddressObj.UploadID == "") {
                var error = "UploadID is not null";
                toastr.error(error, 'Error');
            }
            else if ($scope.changeBackOrderAddressObj.RecordIDList == "") {
                var error = "RecordIDList is not null";
                toastr.error(error, 'Error');
            }
            else if ($scope.changeBackOrderAddressObj.Note == "") {
                var error = "Note is not null";
                toastr.error(error, 'Error');
            }
            else {
                backOrderService.changeBackOrderAddress($scope.changeBackOrderAddressObj).then(
                    function (response) {
                        console.log(response);
                        console.log(response.data);
                        if (response.data.length === 0) {
                            var error = "No Back Order found";
                            toastr.error(error, 'Error');
                            //009589000
                        }
                        else {

                            $scope.viewData = response.data;
                        }
                    },
                    function (err) {
                        console.log(err);
                        var mess_err = err.data.InnerException.ExceptionMessage;
                        toastr.error(mess_err, "Data is incorrect");
                    }
                );
            }

        }
    }]);

//app.controller("backOrderChangeAddressCtrl", function ($scope, backOrderService) {
//    $scope.changeBackOrderAddressObj = {
//        ClubCode: "ITT",
//        UploadID: 34513,
//        RecordIDList: "20246184",
//        Street1: "",
//        Street2: "",
//        Suburb: "",
//        State: "",
//        PostCode: "",
//        Country: "",
//        CompanyName: "",
//        Phone: "",
//        Email: "",
//        Note: "IT-TEST",
//        IsRun: false
//    };
//    $scope.viewData = [];
//    //this.$onInit = function(){
//    //    //console.log(backOrderService);
//    //}
//    $scope.onChangeBackOrderAddressSubmit = function () {
//        console.log($scope.changeBackOrderAddressObj);
//        backOrderService.changeBackOrderAddress($scope.changeBackOrderAddressObj).then(function(response){
//            $scope.viewData = response.data;
//            console.log($scope.viewData);
//        });
//    }
//})
