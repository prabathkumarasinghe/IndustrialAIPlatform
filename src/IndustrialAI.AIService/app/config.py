from pydantic import BaseSettings, SettingsConfigDict


class Settings(BaseSettings):
    # Application
    app_name: str = "Industrial AI Service"
    app_version: str = "1.0.0"
    environment: str = "Development"

    # Azure OpenAI
    azure_openai_endpoint: str
    azure_openai_api_key: str
    azure_openai_deployment: str
    azure_openai_embedding_deployment: str

    # Azure AI Search
    azure_search_endpoint: str
    azure_search_api_key: str
    azure_search_index: str

    model_config = SettingsConfigDict(
        env_file=".env",
        case_sensitive=False
    )


settings = Settings()