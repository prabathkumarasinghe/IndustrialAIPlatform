from pydantic import BaseModel


class RemainingLifeResponse(BaseModel):
    remaining_useful_life: int
    unit: str