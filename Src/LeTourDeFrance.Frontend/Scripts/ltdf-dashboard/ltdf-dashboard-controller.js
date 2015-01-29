angular.module('ltdf').controller('ltdfDashboardController', [
    '$scope', '$http', 'ltdfDashboardService',
    function($scope, $http, ltdfDashboardService) {
        $scope.model = {};
        $scope.model.imagePath = "http://localhost/LeTourDeFrance.Frontend/Content/Images/stage-1.jpg";


        (function() {
            ltdfDashboardService.getStages().
                success(function(data) {
                    $scope.model.stages = data;
                    console.log('yay');
                    console.log(data);
                    $scope.model.selectedStage = $scope.model.stages[0];
                    $scope.model.stagesToShow = split($scope.model.stages, 4);
                })
                .error(function(data) {
                        console.log('nay');
                    }
                );

            
        })();

        $scope.model.nextPage = function(index) {
            for (var i = 0; i < $scope.model.stages.length; i++) {
                $scope.model.stagesToShow = $scope.model.stages.splice(index, 4);
            }
        };

        function split(a, n) {
            var len = a.length, out = [], i = 0;
            while (i < len) {
                var size = Math.ceil((len - i) / n--);
                out.push(a.slice(i, i + size));
                i += size;
            }
            return out;
        }

        $scope.loadImageOnClick = function(stage) {
            console.log("clicked stage: " + stage);
            $scope.model.imagePath = 'http://localhost/LeTourDeFrance.Frontend/Content/Images/stage-' + stage + '.jpg';
            $scope.model.selectedStage = $scope.model.stages[stage - 1];
            console.log($scope.model.selectedStage);
        };
    }
]);