var app = angular.module('myApp', []);

app.controller('AuthLoginController', function ($scope, $http) {

    $scope.Onload = () => {
        debugger;
        let obj = {
            username: '',
            password: ''
        }
        $scope.AuthData = angular.copy(obj);
    }

    $scope.AuthCheck = () => {
        debugger;

        let obj = angular.copy($scope.AuthData);

        if ($scope.AuthData.username == '') {
            toastr.error('Enter User Name');
            return false;
        }

        if ($scope.AuthData.password == '') {
            toastr.error('Enter Password');
            return false;
        }
        debugger;
        $http.post("/Auth/ChekLogin", { auth: obj }, { responseType: 'json' })
            .then(function (response) {
                debugger;
                $scope.authdataList = response.data;
                if ($scope.authdataList.length == 0) {
                    toastr.error('Enter Correct Username and Password !!');
                    return false;
                }
                else {
                    window.location.href = '/SubCompany/SubCompanuList?id=' + $scope.authdataList[0].FUllUserName;
                }
                //alert($scope.authdataList[0].FUllUserName);
            });
    }

});