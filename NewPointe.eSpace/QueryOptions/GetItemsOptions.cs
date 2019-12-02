using System;

using NewPointe.eSpace.Models;
using NewPointe.Util.QueryString;

namespace NewPointe.eSpace
{
    [Serializable]
    public class GetItemsOptions
    {

        /// <summary>
        /// Item type, can be space, resource, service, don't pass it at all if you want to get all items
        /// </summary>
        [QueryStringProperty("type")]
        public ItemType? Type { get; set; }

        /// <summary>
        /// Item Id, pass this parameter
        /// </summary>
        [QueryStringProperty("itemId")]
        public int? ItemId { get; set; }

        /// <summary>
        /// Location Ids by comma separated, don't pass it at all if you want to get all items
        /// </summary>
        [QueryStringProperty("locationIds")]
        public int[] LocationIds { get; set; }

    }
}
