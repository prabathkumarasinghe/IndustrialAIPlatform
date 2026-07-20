from pydantic import BaseModel


class PredictionRequest(BaseModel):
    machine_id: str
    temperature: float
    vibration: float
    pressure: float
    runtime_hours: float