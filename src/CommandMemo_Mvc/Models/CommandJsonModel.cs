using CommandMemo_Mvc.Models.Element;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace CommandMemo_Mvc.Models
{
    /// <summary>
    /// Jsonファイルモデル
    /// </summary>
    [DataContract]
    public class CommandJsonModel
    {
        /// <summary>
        /// タイトル
        /// </summary>
        [DataMember(Name = "title")]
        public string Title { get; set; }

        /// <summary>
        /// コマンドの内容
        /// </summary>
        [DataMember(Name = "contents")]
        public List<CommandContentJsonModel> Contents { get; set; }
    }
}
