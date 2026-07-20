from pathlib import Path

import joblib
import numpy as np
from sklearn.ensemble import RandomForestClassifier


X = np.random.rand(1000, 4)
y = np.random.randint(0, 2, 1000)

model = RandomForestClassifier(random_state=42)

model.fit(X, y)

MODEL_PATH = (
    Path(__file__).resolve().parents[2]
    / "trained_models"
    / "failure_model.pkl"
)

MODEL_PATH.parent.mkdir(exist_ok=True)

joblib.dump(model, MODEL_PATH)

print(f"Model saved to: {MODEL_PATH}")