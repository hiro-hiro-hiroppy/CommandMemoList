using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CommandMemo_Mvc.CS.Json.Logic
{
    public static class JsonFilePath
    {
        /// <summary>
        /// Jsonフォルダー内部のパスを取得する
        /// </summary>
        /// <param name="jsonBase"></param>
        /// <returns></returns>
        public static List<string> GetJsonFilePaths(this JsonBase jsonBase)
        {
            var dllDirectory = System.AppDomain.CurrentDomain.BaseDirectory;
            var jsonDirectory = Path.Combine(dllDirectory, "Json");
            var jsonFiles = Directory.GetFiles(jsonDirectory, "*.json")?.ToList();

            return jsonFiles;
        }
    }
}
