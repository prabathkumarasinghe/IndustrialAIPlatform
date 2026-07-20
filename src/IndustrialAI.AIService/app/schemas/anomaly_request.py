from pydantic import BaseModel


class AnomalyRequest(BaseModel):
    temperature: float
    vibration: float
    pressure: float
    runtime_hours: float