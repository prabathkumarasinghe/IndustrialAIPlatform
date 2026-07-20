from app.forecasting.forecast import ForecastService as ForecastEngine


class ForecastService:

    def __init__(self):
        self.engine = ForecastEngine()

    def forecast(self, request):

        return self.engine.predict(
            request.values,
            request.periods
        )