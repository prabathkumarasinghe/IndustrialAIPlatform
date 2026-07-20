from fastapi import APIRouter

from app.schemas import (
    PredictionRequest,
    PredictionResponse
)

from app.services.prediction_service import PredictionService

router = APIRouter(
    prefix="/prediction",
    tags=["Prediction"]
)

service = PredictionService()


@router.post(
    "/predict",
    response_model=PredictionResponse
)
async def predict(request: PredictionRequest):

    return service.predict(request)