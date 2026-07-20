from pydantic import BaseModel


class MaintenanceRequest(BaseModel):
    temperature: float
    vibration: float
    pressure: float
    runtime_hours: float