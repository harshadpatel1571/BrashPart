var app = angular.module('myApp', []);

app.controller('ListDilerCompanyController', function ($scope, $http) {

    $scope.onLoad = () => {
        //let obj = {
        //    id: 0,
        //    year: "0"
        //}
        //$scope.onDataLoad = angular.copy(obj);
        //$scope.bind_year_ddl();
        $scope.getAlldata();
    }

    $scope.getAlldata = () => {
        debugger;
        try {

            //if ($scope.onDataLoad.year == 0) {
            //    toastr.error('Select Holiday Year First !!');
            //    return false;
            //}

            //$("#card_holiday").prepend('<div class="spinner-grow text-secondary" role="status" id="preloader" style="width: 3rem; height: 3rem; margin-top: 30%; margin-left: 50%; position: absolute"><span class= "visually-hidden" > Loading...</span ></div >');

            //var data = {
            //    year: $scope.onDataLoad.year,
            //    id: $scope.onDataLoad.id
            //}

            $http.post("/DilerCompany/Get_data", { responseType: 'json' })
                .then(function (response) {
                    $scope.DilerCompanyData = response.data;
                    $("#preloader").remove();
                });
        }
        catch (error) {
            console.log(error)
        }
        finally {

        }
    }

    $scope.getId = (index) => {
        debugger;
        $scope.index = index;
    }

    $scope.delete = () => {
        try {

            let ID = $scope.DilerCompanyData[$scope.index].DC_id

            $http.post("/DilerCompany/Delete", { id: ID }, { responseType: 'json' })
                .then(function (response) {
                    $scope.getAlldata();
                    $('#deletemodal').modal('hide');
                });
        }
        catch (error) {
            console.log(error)
        }
        finally {

        }
    }

    //$scope.bind_year_ddl = () => {
    //    debugger;
    //    try {
    //        $http.post("/Holiday/Bind_year_ddl", { responseType: 'json' })
    //            .then(function (response) {
    //                $scope.getYear = response.data;
    //            });
    //    }
    //    catch (error) {
    //        console.log(error)
    //    }
    //    finally {

    //    }
    //}

});