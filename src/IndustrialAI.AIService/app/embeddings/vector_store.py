class VectorStore:

    def prepare_document(
        self,
        document_id: str,
        content: str,
        embedding: list[float]
    ):

        return {
            "id": document_id,
            "content": content,
            "contentVector": embedding
        }