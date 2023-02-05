//app.controller("backOrderChangeReplaceItemCtrl", ['$scope', 'toastr','backOrderReplaceItemService',
//function ($scope, toastr, backOrderReplaceItemService)

app.controller("backOrderAddItemCtrl", ['$scope', 'toastr','backOrderAddItemService',
    function ($scope, toastr, backOrderAddItemService) {
        $scope.changeBackOrderAddItemObj = {
            ClubCode: "ITT",
            UploadID: 34513,
            GroupIDList: "",
            RecordIDList: "20246184,20246185,20246186",
            ItemType: "Product",//----Product Letter Card Envelope
            ItemID: "55",
            Note: "ITT",
            IsRun: false
        }
        $scope.viewData = [];
        $scope.onchangeBackOderAddItemSubmit = function () {
            console.log($scope.changeBackOrderAddItemObj);
            if ($scope.changeBackOrderAddItemObj.ClubCode == "") {
                var error = "ClubCode is not null";
                toastr.error(error, 'Error');
            }
            else if ($scope.changeBackOrderAddItemObj.UploadID == "") {
                var error = "UploadID is not null";
                toastr.error(error, 'Error');
            }
            else if ($scope.changeBackOrderAddItemObj.RecordIDList == "") {
                var error = "RecordIDList is not null";
                toastr.error(error, 'Error');
            }
            else if ($scope.changeBackOrderAddItemObj.ItemType == "") {
                var error = "Item Type is not null";
                toastr.error(error, 'Error');
            }
            else if ($scope.changeBackOrderAddItemObj.ItemID == "") {
                var error = "ItemID is not null";
                toastr.error(error, 'Error');
            }
            else if ($scope.changeBackOrderAddItemObj.Note == "") {
                var error = "Note is not null";
                toastr.error(error, 'Error');
            }
            else {
                backOrderAddItemService.changeBackOrderAddItem($scope.changeBackOrderAddItemObj).then(
                    function (response) {
                        console.log(response.data);
                        if (response.data.length === 0) {
                            var error = "No Back Order Add Item found";
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
