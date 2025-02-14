// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Automation.Models
{
    using System.Linq;

    /// <summary>
    /// The parameters supplied to the create or update schedule operation.
    /// </summary>
    public partial class ScheduleCreateOrUpdateProperties
    {
        /// <summary>
        /// Initializes a new instance of the ScheduleCreateOrUpdateProperties class.
        /// </summary>
        public ScheduleCreateOrUpdateProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ScheduleCreateOrUpdateProperties class.
        /// </summary>

        /// <param name="description">Gets or sets the description of the schedule.
        /// </param>

        /// <param name="startTime">Gets or sets the start time of the schedule.
        /// </param>

        /// <param name="expiryTime">Gets or sets the end time of the schedule.
        /// </param>

        /// <param name="interval">Gets or sets the interval of the schedule.
        /// </param>

        /// <param name="frequency">Gets or sets the frequency of the schedule.
        /// Possible values include: 'OneTime', 'Day', 'Hour', 'Week', 'Month',
        /// 'Minute'</param>

        /// <param name="timeZone">Gets or sets the time zone of the schedule.
        /// </param>

        /// <param name="advancedSchedule">Gets or sets the AdvancedSchedule.
        /// </param>
        public ScheduleCreateOrUpdateProperties(System.DateTimeOffset startTime, string frequency, string description = default(string), System.DateTimeOffset? expiryTime = default(System.DateTimeOffset?), object interval = default(object), string timeZone = default(string), AdvancedSchedule advancedSchedule = default(AdvancedSchedule))

        {
            this.Description = description;
            this.StartTime = startTime;
            this.ExpiryTime = expiryTime;
            this.Interval = interval;
            this.Frequency = frequency;
            this.TimeZone = timeZone;
            this.AdvancedSchedule = advancedSchedule;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets gets or sets the description of the schedule.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "description")]
        public string Description {get; set; }

        /// <summary>
        /// Gets or sets gets or sets the start time of the schedule.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "startTime")]
        public System.DateTimeOffset StartTime {get; set; }

        /// <summary>
        /// Gets or sets gets or sets the end time of the schedule.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "expiryTime")]
        public System.DateTimeOffset? ExpiryTime {get; set; }

        /// <summary>
        /// Gets or sets gets or sets the interval of the schedule.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "interval")]
        public object Interval {get; set; }

        /// <summary>
        /// Gets or sets gets or sets the frequency of the schedule. Possible values include: &#39;OneTime&#39;, &#39;Day&#39;, &#39;Hour&#39;, &#39;Week&#39;, &#39;Month&#39;, &#39;Minute&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "frequency")]
        public string Frequency {get; set; }

        /// <summary>
        /// Gets or sets gets or sets the time zone of the schedule.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "timeZone")]
        public string TimeZone {get; set; }

        /// <summary>
        /// Gets or sets gets or sets the AdvancedSchedule.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "advancedSchedule")]
        public AdvancedSchedule AdvancedSchedule {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.Frequency == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Frequency");
            }





        }
    }
}