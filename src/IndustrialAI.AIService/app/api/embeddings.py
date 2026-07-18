from fastapi import APIRouter

router = APIRouter(prefix="/embeddings", tags=["Embeddings"])


@router.post("/")
async def embeddings(data: dict):
    return {
        "success": True,
        "vector_size": 3072
    }