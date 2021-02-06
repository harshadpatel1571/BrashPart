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

app.controller('SubcompanyListController', function ($scope, $http) {

    $scope.Onload = () => {
        //let obj = {
        //    id: ''    
        //}
      //  $scope.SubCompany = angular.copy(obj);
       
    }

    $scope.getbyId = (Subid) => {
        ///alert(id);
        debugger;
        $http.post("/SubCompany/ChekSubCompanyList", { id: Subid }, { responseType: 'json' })
            .then(function (response) {
                debugger;
                $scope.SubCompany = response.data;
            });
    }

    $scope.SubCompanyData = (index) => {
        debugger;
        let SubCompanyId = $scope.SubCompany[index].Sub_CmId;

        $http.post("/SubCompany/SubCompanySession", { Sub_CmId: SubCompanyId }, { responseType: 'json' })
            .then(function (response) {

                $scope.SubCompanySession = response.data;
            });
    }
    var temp = GetParaVal('id');
    if (temp > 0) {
        $scope.getbyId(temp);
    }
});