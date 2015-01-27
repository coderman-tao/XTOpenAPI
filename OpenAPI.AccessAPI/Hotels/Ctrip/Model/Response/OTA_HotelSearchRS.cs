using OpenAPI.AccessAPI.Hotels.Ctrip.Hotel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenAPI.AccessAPI.Hotels.Ctrip.Model.Response
{
    [Serializable]
    public class OTA_HotelSearchRS : BaseReturnEntity
    {
        private List<CtripHotelRepEntity> hotelList = new List<CtripHotelRepEntity>();

        /// <summary>
        /// 酒店信息列表
        /// </summary>
        public List<CtripHotelRepEntity> HotelList
        {
            get
            {
                return this.hotelList;
            }
            set
            {
                this.hotelList = value;
            }
        }
    }
}
