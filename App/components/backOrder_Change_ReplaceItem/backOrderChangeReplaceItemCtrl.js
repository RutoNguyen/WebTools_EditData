

app.controller("backOrderChangeReplaceItemCtrl", ['$scope', 'toastr','backOrderReplaceItemService',
    function ($scope, toastr , backOrderReplaceItemService) {
        $scope.changeBackOrderReplaceItemObj = {
            ClubCode: "ITT",
            UploadID: 34513,
            GroupIDList: "",
            RecordIDList: "20246184,20246185,20246186",
            ItemType: "Product",//----Product Letter Card Envelope
            FromItemID: "57",
            ToItemID: "55",
            Note: "IT-Test",
            IsRun: false
        }
        $scope.viewData = [];

        $scope.onchangeBackOrderReplaceItemSubmit = function () {
            console.log($scope.changeBackOrderReplaceItemObj);
            if ($scope.changeBackOrderReplaceItemObj.ClubCode == "") {
                var error = "ClubCode is not null";
                toastr.error(error, 'Error');
            }
            else if ($scope.changeBackOrderReplaceItemObj.UploadID == "") {
                var error = "UploadID is not null";
                toastr.error(error, 'Error');
            }
            else if ($scope.changeBackOrderReplaceItemObj.RecordIDList == "") {
                var error = "RecordIDList is not null";
                toastr.error(error, 'Error');
            }
            else if ($scope.changeBackOrderReplaceItemObj.ItemType == "") {
                var error = "Item Type is not null";
                toastr.error(error, 'Error');
            }
            else if ($scope.changeBackOrderReplaceItemObj.FromItemID == "") {
                var error = "FromItemID is not null";
                toastr.error(error, 'Error');
            }
            else if ($scope.changeBackOrderReplaceItemObj.ToItemID == "") {
                var error = "ToItemID is not null";
                toastr.error(error, 'Error');
            }
            else if ($scope.changeBackOrderReplaceItemObj.Note == "") {
                var error = "Note is not null";
                toastr.error(error, 'Error');
            }
            else {
                backOrderReplaceItemService.changeBackOrderReplaceItem($scope.changeBackOrderReplaceItemObj).then(
                    function (response) {
                        console.log(response.data);
                        if (response.data.length === 0) {
                            var error = "No Back Order Replace Item found";
                            toastr.error(error, 'Error');
                            //009589000
                        }
                        else {

                            $scope.viewData = response.data;
                        }
                    },
                    function (err) {
                        console.log(err);
                        var mess_err = err.data.ExceptionMessage;
                        toastr.error(mess_err, "Data is incorrect");
                    }
                );
            }
        }
    }]);