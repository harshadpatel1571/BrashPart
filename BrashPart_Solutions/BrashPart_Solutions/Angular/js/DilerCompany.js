function GetParaVal(param) {
    var url = window.location.href.slice(window.location.href.indexOf('?') + 1);
    for (var i = 0; i < url.length; i++) {
        var urlparam = url.split('=');
        if (urlparam[0] == param) {
            return urlparam[1];
        }
    }
}

var app = angular.module('myApp', []);

app.controller('DilerCompanyController', function ($scope, $http) {

    $scope.onLoad = async () => {
        debugger;
        let DataObj = {
            DC_id: "0",
            DC_CompanyName: "",
            DC_OwnerName: "",
            CM_CompanyId: "0",
            Sub_CmId: "0",
            CM_CountryID: "0",
            SM_StateID: "0",
            CM_CityId: "0",
            DC_PhoneNo: "",
            DC_PhoneNo1: "",
            DC_Address: "",
            DC_Email: "",
            DC_GSTNO: "",
            DC_IsActive: "0"
        }
        $scope.DilerCompanyData = angular.copy(DataObj);
        //$scope.BindEmployee();

        var temp = GetParaVal('temp');
        if (temp > 0) {
            await $scope.EditAdvance(temp);
        }
        //$scope.onDataLoad();
    }

    $scope.SaveData = () => {
        debugger;
        try {

            let obj = angular.copy($scope.DilerCompanyData);

            //if ($scope.DilerCompanyData.am_emp_id == "0") {

            //    toastr.error("Select Employee First !!");
            //    $('#ddlemployee').addClass('border-danger');
            //    return false
            //}

            //if ($scope.DilerCompanyData.am_date == "") {

            //    toastr.error("Enter Advance Date First !!");
            //    $('#txtdate').addClass('border-danger');
            //    return false
            //}

            //if ($scope.DilerCompanyData.am_amount == "") {

            //    toastr.error("Enter Advance Amount First !!");
            //    $('#txtamount').addClass('border-danger');
            //    return false
            //}

            //obj.am_date = obj.am_date == '' ? '' : moment(obj.am_date, 'DD-MM-YYYY').format('YYYY/MM/DD');

            $http.post("/DilerCompany/Save", { dc: obj }, { responseType: 'json' })
                .then(function (response) {
                    debugger;
                    if (response.data <= 0) {
                        //toastr.success('Employee Save Sucess..');
                        window.location.href = '/Advance/ListAdvance';
                    }
                });
        }
        catch (error) {
            console.log(error);
        }
        finally {

        }
    }

    $scope.EditAdvance = async (eid) => {
        debugger;
        try {

            await $http.post("/Advance/Get_Advance_data_by_id", { id: eid }, { responseType: 'json' })
                .then(function (response) {
                    let Iddata = JSON.parse(JSON.stringify(response.data))[0];
                    Iddata.am_emp_id = Iddata.am_emp_id.toString();
                    $scope.DilerCompanyData = Iddata;
                });
        }
        catch (error) {
            console.log(error)
        }
        finally {

        }
    }

    // Bind Employee Dropdown...
    //$scope.BindEmployee = () => {
    //    debugger;
    //    try {

    //        $http.post("/Employee/Bind_employee_ddl", { responseType: 'json' })
    //            .then(function (response) {
    //                $scope.Employeeddl = response.data;
    //            });
    //    }
    //    catch (error) {
    //        console.log(error)
    //    }
    //    finally {

    //    }
    //}
});