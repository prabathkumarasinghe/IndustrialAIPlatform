from fastapi import APIRouter

from app.schemas import (
    ForecastRequest,
    ForecastResponse
)

from app.services.forecast_service import ForecastService

router = APIRouter(
    prefix="/forecast",
    tags=["Forecasting"]
)

service = ForecastService()


@router.post(
    "",
    response_model=ForecastResponse
)
async def forecast(request: ForecastRequest):

    return service.forecast(request)