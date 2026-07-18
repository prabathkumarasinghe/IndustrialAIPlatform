from fastapi import APIRouter

router = APIRouter(prefix="/chat", tags=["AI Chat"])


@router.post("/")
async def chat(message: dict):
    return {
        "success": True,
        "response": "AI service is ready."
    }