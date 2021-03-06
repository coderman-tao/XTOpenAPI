﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace OpenAPI.AccessAPI.Hotels.Ctrip.Model
{
    /// <summary>
    /// 地图坐标位置
    /// </summary>
    public enum PositionType
    {
        /// <summary>
        /// 图吧
        /// </summary>
        Mapbar = 501,

        /// <summary>
        /// Google地图
        /// </summary>
        GoogleMap = 502
    }
    /// <summary>
    /// 携程酒店等级枚举
    /// </summary>
    public enum CtripHotelStarLevel
    {
        /// <summary>
        /// 酒店挂牌星级
        /// </summary>
        [Description("酒店挂牌星级")]
        HotelStarRate,

        /// <summary>
        /// 携程星级
        /// </summary>
        [Description("携程星级")]
        CtripStarRate,

        /// <summary>
        /// 用户推荐级别
        /// </summary>
        [Description("用户推荐级别")]
        CtripUserRate,

        /// <summary>
        /// 酒店点评－综合评分
        /// </summary>
        [Description("酒店点评－综合评分")]
        CtripCommRate,

        /// <summary>
        /// 酒店点评－周边环境分类评分
        /// </summary>
        [Description("酒店点评－周边环境分类评分")]
        CommSurroundingRate,

        /// <summary>
        /// 酒店点评－设施设备分类评分
        /// </summary>
        [Description("酒店点评－设施设备分类评分")]
        CommFacilityRate,

        /// <summary>
        /// 酒店点评－房间卫生分类评分
        /// </summary>
        [Description("酒店点评－房间卫生分类评分")]
        CommCleanRate,

        /// <summary>
        /// 酒店点评－酒店服务分类评分
        /// </summary>
        [Description("酒店点评－酒店服务分类评分")]
        CommServiceRate

    }
}
