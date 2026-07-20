from pydantic import BaseModel


class AnomalyResponse(BaseModel):
    is_anomaly: bool
    anomaly_score: float