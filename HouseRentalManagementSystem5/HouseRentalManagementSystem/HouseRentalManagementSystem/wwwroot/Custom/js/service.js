buildingApp.service('buildingService', function ($http) {
    this.buildingList = function () {
        var response = $http.get('ApartmentBuilding/GetAll');
        return response;
    };
    this.insert = function (building) {
        var response = $http({
            method: "Post",
            url: "ApartmentBuilding/Create",
            data: building,
            contentType: false,
            processData: false
        });
        return response;
    };
    this.updateBuilding = function (building) {
        var response = $http({
            method: 'post',
            url: 'ApartmentBuilding/Edit',
            data: building,
            contentType: false,
            processData: false
        });
        return response;
    };
    this.deleteBuilding  = function (id) {
        var response = $http({
            method: 'post',
            url: "ApartmentBuilding/Delete?id=" + id,
            params: { BuildingId: JSON.stringify(id) }
        });
        return response;
    }
});
apartmentApp.service('apartmentService', function ($http) {
    this.apartmentList = function () {
        var response = $http.get('Apartment/GetAll');
        return response;
    };
    this.insert = function (apartment) {
        var response = $http({
            method: "Post",
            url: "Apartment/Create",
            data: apartment,
            headers: {
                'Content-Type': 'application/json'
            }
        });
        return response;
    };
    this.updateApartment= function (apartment) {
        var response = $http({
            method: 'post',
            url: 'Apartment/Edit',
            data: JSON.stringify(apartment)
        });
        return response;
    };
    this.deleteApartment = function (id) {
        var response = $http({
            method: 'post',
            url: "Apartment/Delete?id=" + id,
            params: { AptId: JSON.stringify(id) }
        });
        return response;
    };
    this.typeList = function () {
        var response = $http.get('Apartment/GetAllType');
        return response;
    };
    this.buildingList = function () {
        var response = $http.get('ApartmentBuilding/GetAll');
        return response;
    };
    this.facilityList = function () {
        var response = $http.get('Apartment/GetAllFacility');
        return response;
    }; 
    this.apartmentImages = function (id) {
        var response = $http.get("Apartment/GetApartmentImages?id=" + id);
        return response;
    };
    this.deleteImages = function (id) {
        var response = $http({
            method: 'post',
            url: "Apartment/DeleteImage?id=" + id,
            params: { AptId: JSON.stringify(id) }
        });
        return response;
    };
});