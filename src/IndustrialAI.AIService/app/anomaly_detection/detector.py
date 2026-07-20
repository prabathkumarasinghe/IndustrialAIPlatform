from app.anomaly_detection.isolation_forest import IsolationForestModel


class AnomalyDetector:

    def __init__(self):
        self.model = IsolationForestModel()

    def detect(self, data):

        values = [
            data.temperature,
            data.vibration,
            data.pressure,
            data.runtime_hours
        ]

        return self.model.detect(values)