angular.module('ltdf').controller('ltdfDashboardController', [
    '$scope', '$http', 'ltdfDashboardService',
    function($scope, $http, ltdfDashboardService) {
        $scope.model = {};
        $scope.model.imagePath = "http://localhost/LeTourDeFrance.Frontend/Content/Images/stage-1.jpg";


        (function() {
            ltdfDashboardService.getRiders()
                .success(function(data) {
                    $scope.model.riders = data;
                    console.log('yay');
                    console.log(data);
                })
                .error(function(data) {
                        console.log('nay');
                    }
                );
            ltdfDashboardService.getStages().
                success(function(data) {
                    $scope.model.stages = data;
                    console.log('yay');
                    console.log(data);
                    $scope.model.selectedStage = $scope.model.stages[0];
                })
                .error(function(data) {
                        console.log('nay');
                    }
                );
        })();

        $scope.loadImageOnClick = function(stage) {
            console.log("clicked stage: " + stage);
            $scope.model.imagePath = 'http://localhost/LeTourDeFrance.Frontend/Content/Images/stage-' + stage + '.jpg';
            $scope.model.selectedStage = $scope.model.stages[stage - 1];
            console.log($scope.model.selectedStage);
        };
    }
]);