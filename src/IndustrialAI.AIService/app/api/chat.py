from fastapi import APIRouter

from app.chat.chat_service import ChatService
from app.schemas.chat_request import ChatRequest
from app.schemas.chat_response import ChatResponse

router = APIRouter(
    prefix="/chat",
    tags=["AI Chat"]
)

service = ChatService()


@router.post(
    "",
    response_model=ChatResponse
)
async def chat(request: ChatRequest):

    return service.ask(request.question)