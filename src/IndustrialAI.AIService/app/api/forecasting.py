from fastapi import APIRouter

router = APIRouter(prefix="/forecasting", tags=["Forecasting"])


@router.post("/")
async def forecast(data: dict):
    return {
        "success": True,
        "forecast": []
    }