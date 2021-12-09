/// <reference path="../../angular.js/angular.js" />
buildingApp.controller('buildingController', function ($scope, Upload, $timeout, buildingService) {
    $scope.newBuilding = {};
    $scope.message = "";
    $scope.UploadFiles = function (files) {
        $scope.SelectedFiles = files;
        //$scope.newBuilding.ImageName = files[0].name;
        //$scope.clickedBuilding.ImageName = files[0].name;

    };
    BuildingList();
    function BuildingList() {
        buildingService.buildingList().then(function (result) {
            $scope.buildings = result.data;
        })
    }
    $scope.Insert = function () {
        //if ($scope.SelectedFiles && $scope.SelectedFiles.length) {
        //    UploadFile();
        //}
        buildingService.insert($scope.newBuilding).then(function (returnId) {
            if ($scope.SelectedFiles && $scope.SelectedFiles.length) {
                UploadFile(returnId.data);
            }
        }).then(function (result) {
            $scope.message = "Building Save Succfully";
            ClearAll();
            BuildingList();
        });
    }
    $scope.ClearMessage = function () {
        $scope.message = "";
    }
    $scope.UpdateBuilding = function () {
        buildingService.updateBuilding($scope.clickedBuilding).then(function (returnId) {
            if ($scope.SelectedFiles && $scope.SelectedFiles.length) {
                UploadFile(returnId.data);
            }
        }).then(function (result) {
            $scope.Message = "Data updated successfully";
            $scope.building = result.data;
            BuildingList();
        }, function () {
            alert(result);
        });
    };
    function UploadFile(id) {
        Upload.upload({
            url: "/User/FileUpload/ApartmentBuildingImageUpload?id=" + id,
            data: {
                files: $scope.SelectedFiles
            }
        }).then(function (response) {
            $timeout(function () {
                $scope.Result = response.data;
                BuildingList();
            });
        }, function (response) {
            if (response.status > 0) {
                var errorMsg = response.status + ': ' + response.data;
                alert(errorMsg);
            }
        });
    }
    function ClearAll() {
        $scope.newBuilding = null;
        $(".change_image").val('');
        $('.change_edit').attr('src', 'images/app_images/no-image.png');
    }
    $scope.SelectedBuilding = function (building) {
        $scope.clickedBuilding = building;
    };
    $scope.DeleteBuilding = function (id) {
        buildingService.deleteBuilding(id).then(function () {
            $scope.Message = "Data deleted successfully"
            BuildingList();
        }, function (result) {
            alert(result);
        })
    };
});
apartmentApp.controller('apartmentController', function ($scope, Upload, $timeout, apartmentService) {
    $scope.newApartment = {};
    $scope.message = "";
    //$scope.AllFacilityCode = {};
    //$scope.newApartment.FacilityCode = $scope.AllFacilityCode;
    $scope.UploadFiles = function (files) {
        $scope.SelectedFiles = files;
        //$scope.newApartment.ImageName = files[0].name;
        //$scope.clickedApartment.ImageName = files[0].name;
    };
    ApartmentList();
    function ApartmentList() {
        apartmentService.apartmentList().then(function (result) {
            $scope.apartments = result.data;
        })
    }
    $scope.FillDropDownValue = function () {
        apartmentService.typeList().then(function (result) {
            $scope.types = result.data;
        });
        apartmentService.buildingList().then(function (result) {
            $scope.buildings = result.data;
        });
        apartmentService.facilityList().then(function (result) {
            $scope.facilities = result.data;
        });
    }
    $scope.ApartmentImages = function (id) {
        apartmentService.apartmentImages(id).then(function (result) {
            $scope.images = result.data;
        });
    }
    $scope.Insert = function () {
        apartmentService.insert($scope.newApartment).then(function (returnId) {
            if ($scope.SelectedFiles && $scope.SelectedFiles.length) {
                UploadFile(returnId.data);
            }
        }).then(function (result) {
            $scope.message = "Apartment Save Succfully";
            ClearAll();
            ApartmentList();
        });
    }
    $scope.ClearMessage = function () {
        $scope.message = "";
    }
    function UploadFile(id) {
        Upload.upload({
            url: "/User/FileUpload/ApartmentImageUpload?id=" + id,
            data: {
                files: $scope.SelectedFiles
            }
        }).then(function (response) {
            $timeout(function () {
                $scope.Result = response.data;
            });
        }, function (response) {
            if (response.status > 0) {
                var errorMsg = response.status + ': ' + response.data;
                alert(errorMsg);
            }
        });
    }
    function ClearAll() {
        $scope.newApartment = null;
        $(".change_image").val('');
        $('.change_edit').attr('src', 'images/app_images/no-image.png');
    }
    $scope.SelectedApartment = function (apartment) {
        $scope.clickedApartment = apartment;
        apartmentService.apartmentImages(apartment.AptId).then(function (result) {
                $scope.images = result.data;
        });
        apartmentService.typeList().then(function (result) {
            $scope.types = result.data;
        });
        apartmentService.buildingList().then(function (result) {
            $scope.buildings = result.data;
        });
        apartmentService.facilityList().then(function (result) {
            $scope.facilities = result.data;
        });
    };
    $scope.UpdateApartment = function () {
        apartmentService.updateApartment($scope.clickedApartment).then(function (returnId) {
            if ($scope.SelectedFiles && $scope.SelectedFiles.length) {
                UploadFile(returnId.data);
            }
        }).then(function (result) {
            $scope.Message = "Data updated successfully";
            $scope.apartment = result.data;
            ApartmentList();
        }, function () {
            alert(result);
        });
    };
    $scope.DeleteApartment = function (id) {
        apartmentService.deleteApartment(id).then(function () {
            $scope.Message = "Data deleted successfully"
            ApartmentList();
        }, function (result) {
            alert(result);
        })
    };

    $scope.DeleteImages = function (id) {
        apartmentService.deleteImages(id).then(function (resultImage) {
            $scope.images = resultImage.data;
        }, function (result) {
            alert(result);
        })
    }
});