from pathlib import Path

import joblib
import numpy as np
from sklearn.ensemble import IsolationForest


X = np.random.normal(
    loc=50,
    scale=10,
    size=(1000, 4)
)

model = IsolationForest(
    contamination=0.05,
    random_state=42
)

model.fit(X)

MODEL_PATH = (
    Path(__file__).resolve().parents[2]
    / "trained_models"
    / "anomaly_model.pkl"
)

MODEL_PATH.parent.mkdir(exist_ok=True)

joblib.dump(model, MODEL_PATH)

print(f"Model saved to: {MODEL_PATH}")