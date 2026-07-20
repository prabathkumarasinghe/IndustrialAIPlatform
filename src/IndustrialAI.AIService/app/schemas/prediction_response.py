from pydantic import BaseModel


class PredictionResponse(BaseModel):
    equipment_failure: bool
    probability: float
    confidence: float