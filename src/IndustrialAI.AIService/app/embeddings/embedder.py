from app.services.azure_openai_service import AzureOpenAIService


class Embedder:

    def __init__(self):

        self.openai = AzureOpenAIService()

    def generate(self, text: str):

        embedding = self.openai.generate_embedding(text)

        return {
            "embedding": embedding
        }