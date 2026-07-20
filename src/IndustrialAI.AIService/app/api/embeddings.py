from fastapi import APIRouter

from app.embeddings.embedder import Embedder
from app.schemas.embedding_request import EmbeddingRequest
from app.schemas.embedding_response import EmbeddingResponse

router = APIRouter(
    prefix="/embeddings",
    tags=["Embeddings"]
)

embedder = Embedder()


@router.post(
    "",
    response_model=EmbeddingResponse
)
async def generate_embedding(request: EmbeddingRequest):

    return embedder.generate(request.text)