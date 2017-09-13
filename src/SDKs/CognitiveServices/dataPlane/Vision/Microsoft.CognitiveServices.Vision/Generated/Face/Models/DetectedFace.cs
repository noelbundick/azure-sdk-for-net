// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.CognitiveServices.Vision.Face.Models
{
    using Microsoft.CognitiveServices;
    using Microsoft.CognitiveServices.Vision;
    using Microsoft.CognitiveServices.Vision.Face;
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Detected Face object.
    /// </summary>
    public partial class DetectedFace
    {
        /// <summary>
        /// Initializes a new instance of the DetectedFace class.
        /// </summary>
        public DetectedFace()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DetectedFace class.
        /// </summary>
        public DetectedFace(FaceRectangle faceRectangle, string faceId = default(string), FaceLandmarks faceLandmarks = default(FaceLandmarks))
        {
            FaceId = faceId;
            FaceRectangle = faceRectangle;
            FaceLandmarks = faceLandmarks;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "faceId")]
        public string FaceId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "faceRectangle")]
        public FaceRectangle FaceRectangle { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "faceLandmarks")]
        public FaceLandmarks FaceLandmarks { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (FaceRectangle == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "FaceRectangle");
            }
            if (FaceId != null)
            {
                if (FaceId.Length > 64)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "FaceId", 64);
                }
            }
            if (FaceRectangle != null)
            {
                FaceRectangle.Validate();
            }
            if (FaceLandmarks != null)
            {
                FaceLandmarks.Validate();
            }
        }
    }
}