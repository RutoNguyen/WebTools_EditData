//app.controller("backOrderAddItemCtrl", ['$scope', 'toastr','backOrderAddItemService',
//function ($scope, toastr, backOrderAddItemService)
//

app.controller("backOrderRemoveItemCtrl", ['$scope', 'toastr', 'backOrderRemoveItemService',
    function ($scope, toastr, backOrderRemoveItemService) {
        $scope.backOrderRemoveItemObj = {
            ClubCode: "ITT",
            UploadID: 34513,
            GroupIDList: "",
            RecordIDList: "20246184,20246185,20246186",
            ItemType: "Product",//----Product Letter Card Envelope
            ItemIDList: "1",
            Note: "ITT-RemoveItem",
            IsRun: false
        }
        $scope.viewData = [];
        $scope.onBackOderRemoveItemSubmit = function () {
            console.log($scope.backOrderRemoveItemObj);
            if ($scope.backOrderRemoveItemObj.ClubCode == "") {
                var error = "ClubCode is not null";
                toastr.error(error, 'Error');
            }
            else if ($scope.backOrderRemoveItemObj.UploadID == "") {
                var error = "UploadID is not null";
                toastr.error(error, 'Error');
            }
            else if ($scope.backOrderRemoveItemObj.RecordIDList == "") {
                var error = "RecordIDList is not null";
                toastr.error(error, 'Error');
            }
            else if ($scope.backOrderRemoveItemObj.ItemType == "") {
                var error = "Item Type is not null";
                toastr.error(error, 'Error');
            }
            else if ($scope.backOrderRemoveItemObj.ItemIDList == "") {
                var error = "ItemID List is not null";
                toastr.error(error, 'Error');
            }
            else if ($scope.backOrderRemoveItemObj.Note == "") {
                var error = "Note is not null";
                toastr.error(error, 'Error');
            }
            else {
                backOrderRemoveItemService.changeBackOrderRemoveItem($scope.backOrderRemoveItemObj).then(
                    function (response) {
                        console.log(response.data);
                        if (response.data.length === 0) {
                            var error = "No Back Order Remove Item found";
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
                )
            }

        }
    }]);
