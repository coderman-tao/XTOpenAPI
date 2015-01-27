using OpenAPI.AccessAPI.Hotels.Ctrip.Hotel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenAPI.AccessAPI.Hotels.Ctrip.Model.Response
{
    public class OTA_HotelDescriptiveInfoRS : BaseReturnEntity
    {
        /// <summary>
        /// 酒店静态信息
        /// </summary>
        public List<HotelDescriptiveInfo> DescriptiveInfos { set; get; }
    }
}
