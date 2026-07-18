from fastapi import FastAPI

from app.api.prediction import router as prediction_router
from app.api.forecasting import router as forecasting_router
from app.api.anomaly import router as anomaly_router
from app.api.maintenance import router as maintenance_router
from app.api.chat import router as chat_router
from app.api.embeddings import router as embeddings_router

app = FastAPI(
    title="Industrial AI Service",
    version="1.0.0"
)

app.include_router(prediction_router)
app.include_router(forecasting_router)
app.include_router(anomaly_router)
app.include_router(maintenance_router)
app.include_router(chat_router)
app.include_router(embeddings_router)


@app.get("/")
def root():
    return {"message": "Industrial AI Service is running"}