using CommandMemo_Mvc.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CommandMemo_Mvc.CS.Json.Logic
{
    public static class JsonFileRead
    {
        /// <summary>
        /// Jsonファイルの読み取り
        /// </summary>
        /// <returns></returns>
        public static async Task<CommandJsonModel> ReadCommandJson(this JsonBase jsonBase, string filePath)
        {
            string fileText = null;
            using (StreamReader sr = new StreamReader(filePath, System.Text.Encoding.GetEncoding("UTF-8")))
            {
                fileText = await sr.ReadToEndAsync();
            }
            var commands = JsonConvert.DeserializeObject<CommandJsonModel>(fileText);

            return commands;
        }
    }
}
