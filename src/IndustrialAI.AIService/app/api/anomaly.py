from fastapi import APIRouter

router = APIRouter(prefix="/anomaly", tags=["Anomaly Detection"])


@router.post("/")
async def detect(data: dict):
    return {
        "success": True,
        "anomaly": False,
        "score": 0.12
    }