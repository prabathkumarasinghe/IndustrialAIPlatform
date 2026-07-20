class RemainingLifeService:

    def estimate(self, data):

        health = 100

        health -= max(0, data.temperature - 70) * 0.6
        health -= max(0, data.vibration - 2) * 10
        health -= max(0, data.pressure - 15) * 3

        rul = int(max(100, health * 50))

        return {
            "remaining_useful_life": rul,
            "unit": "hours"
        }