from pydantic import BaseModel


class MaintenanceAdviceResponse(BaseModel):
    recommendation: str
    priority: str