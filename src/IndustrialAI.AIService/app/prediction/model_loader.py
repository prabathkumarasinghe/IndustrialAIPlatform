from pathlib import Path

import joblib


MODEL_PATH = (
    Path(__file__).resolve().parents[2]
    / "trained_models"
    / "failure_model.pkl"
)


class ModelLoader:

    _model = None

    @classmethod
    def load_model(cls):

        if cls._model is None:
            cls._model = joblib.load(MODEL_PATH)

        return cls._model