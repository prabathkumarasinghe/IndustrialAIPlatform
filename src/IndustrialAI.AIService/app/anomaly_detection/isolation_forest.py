import numpy as np
from sklearn.ensemble import IsolationForest


class IsolationForestModel:

    def __init__(self):

        self.model = IsolationForest(
            contamination=0.05,
            random_state=42
        )

        # Dummy training data
        X = np.random.normal(
            loc=50,
            scale=10,
            size=(1000, 4)
        )

        self.model.fit(X)

    def detect(self, values):

        sample = np.array([values])

        prediction = self.model.predict(sample)[0]

        score = self.model.decision_function(sample)[0]

        return {
            "is_anomaly": prediction == -1,
            "anomaly_score": round(float(score), 4)
        }