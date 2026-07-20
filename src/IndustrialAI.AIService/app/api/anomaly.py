from fastapi import APIRouter

from app.anomaly_detection.detector import AnomalyDetector
from app.schemas.anomaly_request import AnomalyRequest
from app.schemas.anomaly_response import AnomalyResponse

router = APIRouter(
    prefix="/anomaly",
    tags=["Anomaly Detection"]
)

detector = AnomalyDetector()


@router.post(
    "",
    response_model=AnomalyResponse
)
async def detect_anomaly(request: AnomalyRequest):

    return detector.detect(request)