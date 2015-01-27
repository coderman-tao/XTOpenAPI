using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenAPI.AccessAPI.Hotels.Ctrip.Hotel.Model
{
    /// <summary>
    /// 入住人
    /// </summary>
    [Serializable]
    public class Person
    {
        public Person()
        { }

        /// <summary>
        /// 姓
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// 名
        /// </summary>
        public string LastName { get; set; }
    }
}
