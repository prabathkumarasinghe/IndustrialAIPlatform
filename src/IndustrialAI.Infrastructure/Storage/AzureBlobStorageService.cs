using Azure.Storage.Blobs;

public class AzureBlobStorageService
{
    private readonly BlobServiceClient _client;

    public AzureBlobStorageService(BlobServiceClient client)
    {
        _client = client;
    }
}