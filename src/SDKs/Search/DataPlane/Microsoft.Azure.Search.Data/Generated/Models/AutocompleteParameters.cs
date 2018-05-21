// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Search.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Additional parameters for AutocompleteGet operation.
    /// </summary>
    public partial class AutocompleteParameters
    {
        /// <summary>
        /// Initializes a new instance of the AutocompleteParameters class.
        /// </summary>
        public AutocompleteParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AutocompleteParameters class.
        /// </summary>
        /// <param name="fuzzy">A value indicating whether to use fuzzy
        /// matching for the autocomplete query. Default is false. When set to
        /// true, the query will find terms even if there's a substituted or
        /// missing character in the search text. While this provides a better
        /// experience in some scenarios it comes at a performance cost as
        /// fuzzy autocomplete queries are slower and consume more
        /// resources.</param>
        /// <param name="highlightPostTag">A string tag that is appended to hit
        /// highlights. Must be set with HighlightPreTag. If omitted, hit
        /// highlighting is disabled.</param>
        /// <param name="highlightPreTag">A string tag that is prepended to hit
        /// highlights. Must be set with HighlightPostTag. If omitted, hit
        /// highlighting is disabled.</param>
        /// <param name="minimumCoverage">A number between 0 and 100 indicating
        /// the percentage of the index that must be covered by am autocomplete
        /// query in order for the query to be reported as a success. This
        /// parameter can be useful for ensuring search availability even for
        /// services with only one replica. The default is 80.</param>
        /// <param name="searchFields">The comma-separated list of field names
        /// to consider when querying for auto-completed terms.</param>
        /// <param name="top">The number of auto-completed terms to retrieve.
        /// This must be a value between 1 and 100. The default is to
        /// 5.</param>
        public AutocompleteParameters(bool? fuzzy = default(bool?), string highlightPostTag = default(string), string highlightPreTag = default(string), double? minimumCoverage = default(double?), IList<string> searchFields = default(IList<string>), int? top = default(int?))
        {
            Fuzzy = fuzzy;
            HighlightPostTag = highlightPostTag;
            HighlightPreTag = highlightPreTag;
            MinimumCoverage = minimumCoverage;
            SearchFields = searchFields;
            Top = top;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a value indicating whether to use fuzzy matching for
        /// the autocomplete query. Default is false. When set to true, the
        /// query will find terms even if there's a substituted or missing
        /// character in the search text. While this provides a better
        /// experience in some scenarios it comes at a performance cost as
        /// fuzzy autocomplete queries are slower and consume more resources.
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        public bool? Fuzzy { get; set; }

        /// <summary>
        /// Gets or sets a string tag that is appended to hit highlights. Must
        /// be set with HighlightPreTag. If omitted, hit highlighting is
        /// disabled.
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        public string HighlightPostTag { get; set; }

        /// <summary>
        /// Gets or sets a string tag that is prepended to hit highlights. Must
        /// be set with HighlightPostTag. If omitted, hit highlighting is
        /// disabled.
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        public string HighlightPreTag { get; set; }

        /// <summary>
        /// Gets or sets a number between 0 and 100 indicating the percentage
        /// of the index that must be covered by am autocomplete query in order
        /// for the query to be reported as a success. This parameter can be
        /// useful for ensuring search availability even for services with only
        /// one replica. The default is 80.
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        public double? MinimumCoverage { get; set; }

        /// <summary>
        /// Gets or sets the comma-separated list of field names to consider
        /// when querying for auto-completed terms.
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        public IList<string> SearchFields { get; set; }

        /// <summary>
        /// Gets or sets the number of auto-completed terms to retrieve. This
        /// must be a value between 1 and 100. The default is to 5.
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        public int? Top { get; set; }

    }
}
