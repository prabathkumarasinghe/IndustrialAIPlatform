import pandas as pd
from prophet import Prophet


class ProphetModel:

    def forecast(self, values: list[float], periods: int):

        df = pd.DataFrame({
            "ds": pd.date_range(
                start="2024-01-01",
                periods=len(values),
                freq="D"
            ),
            "y": values
        })

        model = Prophet(
            daily_seasonality=False,
            weekly_seasonality=True
        )

        model.fit(df)

        future = model.make_future_dataframe(periods=periods)

        forecast = model.predict(future)

        result = forecast.tail(periods)["yhat"].round(2).tolist()

        return result