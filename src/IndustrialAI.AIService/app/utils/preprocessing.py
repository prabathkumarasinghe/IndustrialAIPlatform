from typing import List


class DataPreprocessor:

    @staticmethod
    def normalize(values: List[float]) -> List[float]:
        """
        Min-Max normalization.
        """

        if not values:
            return values

        minimum = min(values)
        maximum = max(values)

        if minimum == maximum:
            return [0.0 for _ in values]

        return [
            round((v - minimum) / (maximum - minimum), 4)
            for v in values
        ]

    @staticmethod
    def clean_missing(values: List[float]) -> List[float]:
        """
        Replace missing values with 0.
        """

        return [
            0 if value is None else value
            for value in values
        ]