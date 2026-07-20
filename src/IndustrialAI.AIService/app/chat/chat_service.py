from app.chat.prompt_builder import PromptBuilder
from app.services.azure_openai_service import AzureOpenAIService


class ChatService:

    def __init__(self):

        self.openai = AzureOpenAIService()

    def ask(self, question: str):

        prompt = PromptBuilder.build(question)

        messages = [
            {
                "role": "system",
                "content": "You are an industrial maintenance expert."
            },
            {
                "role": "user",
                "content": prompt
            }
        ]

        answer = self.openai.get_chat_completion(messages)

        return {
            "answer": answer
        }