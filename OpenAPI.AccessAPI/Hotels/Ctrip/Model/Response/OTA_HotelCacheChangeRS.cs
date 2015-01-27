using OpenAPI.AccessAPI.Hotels.Ctrip.Hotel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenAPI.AccessAPI.Hotels.Ctrip.Model.Response
{
    public class OTA_HotelCacheChangeRS : BaseReturnEntity
    {
        private List<HotelCacheChange> hotelCacheChangeList = new List<HotelCacheChange>();

        /// <summary>
        /// 存刷新信息列表
        /// </summary>
        public List<HotelCacheChange> HotelCacheChangeList
        {
            get
            {
                return this.hotelCacheChangeList;
            }
            set
            {
                this.hotelCacheChangeList = value;
            }
        }
    }
}
