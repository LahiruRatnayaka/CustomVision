using System;

namespace CustomVisionSample1.Models
{
    public static class Configuration
    {
        // Base url of the endpoint to connect to Custom Vision API
        public static string CustomVisionEndpoint { get; set; } = "https://southcentralus.api.cognitive.microsoft.com";
        // Project key of the Custom Vision project
        public static Guid ProjectKey { get; set; } = Guid.Parse("c963f29c-94a3-4f30-aeba-d9984766b118"); //Guid.Parse("7aa53559-8af4-49dd-b846-e06e148b41c5");
        // Prediction key of the image classification model
        public static string PredictKey { get; set; } = "19cea7e4bb694ae3ae6c478430f6a54f";//"0d1a58f338c049b5b5cb56a23af969ad";
        // Training key to train the model
        public static string TrainKey { get; set; } = "a0a31dfaeaaf4b71841f4f8598485606";
    }
}
