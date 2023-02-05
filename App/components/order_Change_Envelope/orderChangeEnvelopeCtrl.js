//SELECT ClubName,Code,* FROM dbo.AFL_Clubs
//WHERE Code = 'ITT'

//SELECT envelopetype, orderid,*
//    FROM dbo.AFL_uploadData 
//WHERE clubID = 81 AND envelopetype IS NOT NULL
//--orderid	id
//--808258658	20246190
//--808258659	20246193
'use strict';
app.controller("orderChangeEnvelopeCtrl", ['$scope', 'toastr', 'orderEnvelopeService',
    function ($scope, toastr, orderEnvelopeService) {
        $scope.changeOrderEnvelopeObj = {
            ClubCode: "ITT",
            OrderID: 808258658,
            FromEnvelopeID: "2",
            ToEnvelopeID: "2",
            IsAllowFullyDelivered: true,
            Note: "IT-TEST",
            IsRun: false
        };
        //$scope.viewData = [];
        $scope.onChangeOrderEnvelopeSubmit = function () {
            console.log($scope.changeOrderEnvelopeObj);
            if ($scope.changeOrderEnvelopeObj.ClubCode == "") {
                var error = "ClubCode is not null";
                toastr.error(error, 'Error');
            }
            else if ($scope.changeOrderEnvelopeObj.OrderID == "") {
                var error = "OrderID is not null";
                toastr.error(error, 'Error');
            }
            else if ($scope.changeOrderEnvelopeObj.FromEnvelopeID == "") {
                var error = "FromEnvelopeID is not null";
                toastr.error(error, 'Error');
            }
            else if ($scope.changeOrderEnvelopeObj.ToEnvelopeID == "") {
                var error = "ToEnvelopeID is not null";
                toastr.error(error, 'Error');
            }
            else if ($scope.changeOrderEnvelopeObj.Note == "") {
                var error = "Note is not null";
                toastr.error(error, 'Error');
            }
            else {
                orderEnvelopeService.changeOrderEnvelope($scope.changeOrderEnvelopeObj).then(
                    function (response) {
                        console.log('data:',response);
                        if (response.data.length === 0) {
                            var error = "No Order Envelope found";
                            toastr.error(error, 'Error');
                        }
                        else {
                            $scope.viewData = response.data;
                            console.log('data2:', $scope.viewData);
                        }
                    },
                    function (err) {
                        console.log(err);
                        var mess_err = err.data.ExceptionMessage;
                        toastr.error(mess_err, "data is incorrect");
                    }
                );
            }
        }
    }]);
