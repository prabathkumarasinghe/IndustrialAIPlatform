from app.prediction.predictor import Predictor


class PredictionService:

    def __init__(self):
        self.predictor = Predictor()

    def predict(self, request):

        return self.predictor.predict(request)