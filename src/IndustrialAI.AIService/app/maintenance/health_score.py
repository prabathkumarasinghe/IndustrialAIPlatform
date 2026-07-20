class HealthScoreService:

    def calculate(self, data):

        score = 100.0

        score -= max(0, data.temperature - 70) * 0.6
        score -= max(0, data.vibration - 2) * 10
        score -= max(0, data.pressure - 15) * 3
        score -= data.runtime_hours / 500

        score = max(0, min(100, score))

        return {
            "health_score": round(score, 2)
        }