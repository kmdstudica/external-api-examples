// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kmd.Studica.Programmes.Client.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class PagedResponseSessionDto
    {
        /// <summary>
        /// Initializes a new instance of the PagedResponseSessionDto class.
        /// </summary>
        public PagedResponseSessionDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PagedResponseSessionDto class.
        /// </summary>
        /// <param name="items">Page of items</param>
        /// <param name="totalItems">Total number of items</param>
        public PagedResponseSessionDto(IList<SessionDto> items = default(IList<SessionDto>), int? totalItems = default(int?))
        {
            Items = items;
            TotalItems = totalItems;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets page of items
        /// </summary>
        [JsonProperty(PropertyName = "items")]
        public IList<SessionDto> Items { get; set; }

        /// <summary>
        /// Gets or sets total number of items
        /// </summary>
        [JsonProperty(PropertyName = "totalItems")]
        public int? TotalItems { get; set; }

    }
}
