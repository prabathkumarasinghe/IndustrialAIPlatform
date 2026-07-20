from statistics import mean


class FeatureEngineering:

    @staticmethod
    def create_features(values):

        if not values:
            return {}

        return {
            "mean": round(mean(values), 4),
            "maximum": max(values),
            "minimum": min(values),
            "range": round(max(values) - min(values), 4)
        }