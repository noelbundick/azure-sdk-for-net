// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Media.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Properties of the Streaming Locator.
    /// </summary>
    public partial class AssetStreamingLocator
    {
        /// <summary>
        /// Initializes a new instance of the AssetStreamingLocator class.
        /// </summary>
        public AssetStreamingLocator()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AssetStreamingLocator class.
        /// </summary>
        /// <param name="name">Streaming Locator name.</param>
        /// <param name="assetName">Asset Name.</param>
        /// <param name="created">The creation time of the Streaming
        /// Locator.</param>
        /// <param name="startTime">The start time of the Streaming
        /// Locator.</param>
        /// <param name="endTime">The end time of the Streaming
        /// Locator.</param>
        /// <param name="streamingLocatorId">StreamingLocatorId of the
        /// Streaming Locator.</param>
        /// <param name="streamingPolicyName">Name of the Streaming Policy used
        /// by this Streaming Locator.</param>
        /// <param name="defaultContentKeyPolicyName">Name of the default
        /// ContentKeyPolicy used by this Streaming Locator.</param>
        public AssetStreamingLocator(string name = default(string), string assetName = default(string), System.DateTime created = default(System.DateTime), System.DateTime startTime = default(System.DateTime), System.DateTime endTime = default(System.DateTime), System.Guid streamingLocatorId = default(System.Guid), string streamingPolicyName = default(string), string defaultContentKeyPolicyName = default(string))
        {
            Name = name;
            AssetName = assetName;
            Created = created;
            StartTime = startTime;
            EndTime = endTime;
            StreamingLocatorId = streamingLocatorId;
            StreamingPolicyName = streamingPolicyName;
            DefaultContentKeyPolicyName = defaultContentKeyPolicyName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets streaming Locator name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets asset Name.
        /// </summary>
        [JsonProperty(PropertyName = "assetName")]
        public string AssetName { get; private set; }

        /// <summary>
        /// Gets the creation time of the Streaming Locator.
        /// </summary>
        [JsonProperty(PropertyName = "created")]
        public System.DateTime Created { get; private set; }

        /// <summary>
        /// Gets the start time of the Streaming Locator.
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public System.DateTime StartTime { get; private set; }

        /// <summary>
        /// Gets the end time of the Streaming Locator.
        /// </summary>
        [JsonProperty(PropertyName = "endTime")]
        public System.DateTime EndTime { get; private set; }

        /// <summary>
        /// Gets streamingLocatorId of the Streaming Locator.
        /// </summary>
        [JsonProperty(PropertyName = "streamingLocatorId")]
        public System.Guid StreamingLocatorId { get; private set; }

        /// <summary>
        /// Gets name of the Streaming Policy used by this Streaming Locator.
        /// </summary>
        [JsonProperty(PropertyName = "streamingPolicyName")]
        public string StreamingPolicyName { get; private set; }

        /// <summary>
        /// Gets name of the default ContentKeyPolicy used by this Streaming
        /// Locator.
        /// </summary>
        [JsonProperty(PropertyName = "defaultContentKeyPolicyName")]
        public string DefaultContentKeyPolicyName { get; private set; }

    }
}
