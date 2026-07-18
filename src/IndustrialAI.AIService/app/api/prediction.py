from fastapi import APIRouter

router = APIRouter(prefix="/prediction", tags=["Prediction"])


@router.post("/")
async def predict(data: dict):
    return {
        "success": True,
        "prediction": "Normal",
        "confidence": 0.96
    }