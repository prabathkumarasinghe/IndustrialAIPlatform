from pydantic import BaseModel


class ForecastRequest(BaseModel):
    values: list[float]
    periods: int = 7