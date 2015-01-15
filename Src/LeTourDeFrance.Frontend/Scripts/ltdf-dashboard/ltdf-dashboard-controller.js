﻿angular.module('ltdf').controller('ltdfDashboardController', [
    '$scope', '$http',
    function($scope, $http) {
        $scope.model = {};
        $scope.model.imagePath = "http://localhost/LeTourDeFrance.Frontend/Content/Images/stage-1.jpg";
        


        (function ridersFromServer() {
            $http.get('http://localhost/LeTourDeFrance.Backend/api/riders')
                .then(function(data) {
                        $scope.model.riders = data.data;
                        console.log('yay');
                        console.log(data);
                    },
                    function(data) {
                        console.log('nay');
                    }
                );
        }());

        (function stagesFromServer() {
            $http.get('http://localhost/LeTourDeFrance.Backend/api/stages').
                then(function(data) {
                        $scope.model.stages = data.data;
                        console.log('yay');
                        console.log(data);
                    $scope.model.selectedStage = $scope.model.stages[0];
                },
                    function(data) {
                        console.log('nay');
                    });
            
        }());

        $scope.loadImageOnClick = function(stage) {
            console.log("clicked stage: " + stage);
            $scope.model.imagePath = 'http://localhost/LeTourDeFrance.Frontend/Content/Images/stage-' + stage + '.jpg';
            $scope.model.selectedStage = $scope.model.stages[stage -1];
            console.log($scope.model.selectedStage);
        };
    }
]);