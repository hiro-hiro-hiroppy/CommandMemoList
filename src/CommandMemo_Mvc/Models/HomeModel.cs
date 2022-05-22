using CommandMemo_Mvc.Models.Element;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommandMemo_Mvc.Models
{
    /// <summary>
    /// Home画面モデル
    /// </summary>
    public class HomeModel
    {
        /// <summary>
        /// タイトル集
        /// </summary>
        public List<string> Titles { get; set; }

        /// <summary>
        /// コマンド集
        /// </summary>
        public List<CommandContentJsonModel> Commands { get; set; }

        /// <summary>
        /// 選択したタイトルのインデックス番号
        /// </summary>
        public int? SelectedTitleIndex { get; set; }
    }
}
