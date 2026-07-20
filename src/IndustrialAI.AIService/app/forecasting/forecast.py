from app.forecasting.prophet_model import ProphetModel


class ForecastService:

    def __init__(self):
        self.model = ProphetModel()

    def predict(self, values, periods):

        forecast = self.model.forecast(values, periods)

        return {
            "forecast": forecast
        }