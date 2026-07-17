from fastapi import FastAPI

app = FastAPI()

@app.get("/")
def root():
    return {"message": "Industrial AI Service is running"}