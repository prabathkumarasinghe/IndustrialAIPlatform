from openai import AzureOpenAI

from app.config import settings


class AzureOpenAIService:

    def __init__(self):
        self.client = AzureOpenAI(
            api_key=settings.azure_openai_api_key,
            api_version="2024-02-01",
            azure_endpoint=settings.azure_openai_endpoint
        )

    def get_chat_completion(
        self,
        messages,
        temperature=0.3,
        max_tokens=500
    ):
        response = self.client.chat.completions.create(
            model=settings.azure_openai_deployment,
            messages=messages,
            temperature=temperature,
            max_tokens=max_tokens
        )

        return response.choices[0].message.content

    def generate_embedding(self, text: str):
        response = self.client.embeddings.create(
            model=settings.azure_openai_embedding_deployment,
            input=text
        )

        return response.data[0].embedding