using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace CommandMemo_Mvc.Models.Element
{
    /// <summary>
    /// Jsonファイル内容モデル
    /// </summary>
    [DataContract]
    public class CommandContentJsonModel
    {
        /// <summary>
        /// コマンドの内容
        /// </summary>

        [DataMember(Name = "command")]
        public string Command { get; set; }

        /// <summary>
        /// コマンドの説明
        /// </summary>
        [DataMember(Name = "description")]
        public string Description { get; set; }
    }
}
