// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;

namespace Microsoft.Azure.Management.Automation.Models
{
    /// <summary>
    /// The properties of the create advanced schedule monthly occurrence.
    /// </summary>
    public partial class AdvancedScheduleMonthlyOccurrence
    {
        private string _day;
        
        /// <summary>
        /// Optional. Day of the occurrence. Must be one of monday, tuesday,
        /// wednesday,thursday, friday, saturday, sunday.
        /// </summary>
        public string Day
        {
            get { return this._day; }
            set { this._day = value; }
        }
        
        private int? _occurrence;
        
        /// <summary>
        /// Optional. Occurrence of the week within the month. Must be between
        /// 1 and 5
        /// </summary>
        public int? Occurrence
        {
            get { return this._occurrence; }
            set { this._occurrence = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the AdvancedScheduleMonthlyOccurrence
        /// class.
        /// </summary>
        public AdvancedScheduleMonthlyOccurrence()
        {
        }
    }
}