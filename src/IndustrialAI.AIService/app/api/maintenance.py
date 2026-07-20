from fastapi import APIRouter

from app.maintenance.health_score import HealthScoreService
from app.maintenance.remaining_life import RemainingLifeService
from app.maintenance.maintenance_advisor import MaintenanceAdvisor

from app.schemas.maintenance_request import MaintenanceRequest
from app.schemas.maintenance_advice_response import MaintenanceAdviceResponse
from app.schemas.remaining_life_response import RemainingLifeResponse


router = APIRouter(
    tags=["Maintenance"]
)

health_service = HealthScoreService()
remaining_life_service = RemainingLifeService()
advisor = MaintenanceAdvisor()


@router.post(
    "/remaining-life",
    response_model=RemainingLifeResponse
)
async def remaining_life(request: MaintenanceRequest):

    return remaining_life_service.estimate(request)


@router.post(
    "/maintenance-advice",
    response_model=MaintenanceAdviceResponse
)
async def maintenance_advice(request: MaintenanceRequest):

    return advisor.recommend(request)