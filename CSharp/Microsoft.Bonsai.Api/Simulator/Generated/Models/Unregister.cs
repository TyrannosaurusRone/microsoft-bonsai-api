// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Bonsai.SimulatorApi.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Event asking to unregister/delete simulatorSession.
    /// You can create a new session, if you want to continue training with
    /// this simulator.
    /// </summary>
    public partial class Unregister
    {
        /// <summary>
        /// Initializes a new instance of the Unregister class.
        /// </summary>
        public Unregister()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Unregister class.
        /// </summary>
        /// <param name="reason">Possible values include: 'Unspecified',
        /// 'Finished', 'Error', 'NotFound'</param>
        /// <param name="details">Detail message for unregister event.</param>
        public Unregister(UnregisterReason? reason = default(UnregisterReason?), string details = default(string))
        {
            Reason = reason;
            Details = details;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets possible values include: 'Unspecified', 'Finished',
        /// 'Error', 'NotFound'
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public UnregisterReason? Reason { get; set; }

        /// <summary>
        /// Gets or sets detail message for unregister event.
        /// </summary>
        [JsonProperty(PropertyName = "details")]
        public string Details { get; set; }

    }
}
