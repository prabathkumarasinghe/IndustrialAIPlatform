class MaintenanceAdvisor:

    def recommend(self, data):

        if data.temperature > 90:
            return {
                "recommendation":
                    "Critical temperature detected. Stop the machine immediately and inspect the cooling system.",
                "priority": "Critical"
            }

        if data.vibration > 5:
            return {
                "recommendation":
                    "High vibration detected. Inspect bearings, shaft alignment and rotating components.",
                "priority": "High"
            }

        if data.pressure > 20:
            return {
                "recommendation":
                    "Pressure exceeds safe operating range. Inspect valves and pressure relief system.",
                "priority": "High"
            }

        if data.runtime_hours > 5000:
            return {
                "recommendation":
                    "Schedule preventive maintenance based on operating hours.",
                "priority": "Medium"
            }

        return {
            "recommendation":
                "Equipment is operating within normal parameters.",
            "priority": "Low"
        }