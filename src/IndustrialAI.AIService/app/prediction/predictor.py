from app.prediction.model_loader import ModelLoader


class Predictor:

    def predict(self, data):

        model = ModelLoader.load_model()

        features = [[
            data.temperature,
            data.vibration,
            data.pressure,
            data.runtime_hours
        ]]

        prediction = model.predict(features)[0]

        probability = model.predict_proba(features)[0][1]

        return {
            "equipment_failure": bool(prediction),
            "probability": round(float(probability), 4),
            "confidence": round(float(max(probability, 1 - probability)), 4)
        }