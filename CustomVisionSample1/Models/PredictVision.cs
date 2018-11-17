using Microsoft.Azure.CognitiveServices.Vision.CustomVision.Prediction;
using Microsoft.Azure.CognitiveServices.Vision.CustomVision.Prediction.Models;
using System.IO;

namespace CustomVisionSample1.Models
{
    /// <summary>
    /// Description : Predict the results by various methods
    /// </summary>
    public class PredictVision
    {
        private CustomVisionPredictionClient customVisionPredictionClient { get; set; }

        public PredictVision()
        {
            customVisionPredictionClient = new CustomVisionPredictionClient()
            {
                ApiKey = Configuration.PredictKey,
                Endpoint = Configuration.CustomVisionEndpoint
            };
        }

        /// <summary>
        /// Predict results for the given image url
        /// </summary>
        /// <param name="imagePath"></param>
        /// <returns></returns>
        public ImagePrediction PredictByUrl(string imagePath) {
            if (string.IsNullOrWhiteSpace(imagePath)) return null;
            return customVisionPredictionClient.PredictImageUrl(Configuration.ProjectKey, new ImageUrl() { Url = imagePath });
        }

        /// <summary>
        /// Predict results for the given image
        /// </summary>
        /// <param name="imagePath"></param>
        /// <returns></returns>
        public ImagePrediction PredictByImage(Stream imageStream)
        {
            if (imageStream == null) return null;
            return customVisionPredictionClient.PredictImage(Configuration.ProjectKey, imageStream);
        }
    }
}
