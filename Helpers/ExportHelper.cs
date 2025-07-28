using System.Text;

namespace WinFormsWorkApp1.Helpers
{
    /// <summary>
    /// 数据导出辅助类
    /// </summary>
    public static class ExportHelper
    {
        /// <summary>
        /// 导出数据到文件
        /// </summary>
        /// <param name="data">要导出的数据</param>
        /// <param name="filePath">文件路径</param>
        public static void ExportToFile(object data, string filePath)
        {
            if (data == null)
                throw new ArgumentNullException(nameof(data));

            var extension = Path.GetExtension(filePath).ToLower();

            switch (extension)
            {
                case ".csv":
                    ExportToCsv(data, filePath);
                    break;
                case ".xlsx":
                    throw new NotSupportedException("Excel导出功能需要安装EPPlus等第三方库");
                default:
                    throw new NotSupportedException($"不支持的文件格式：{extension}");
            }
        }

        /// <summary>
        /// 导出数据到CSV文件
        /// </summary>
        /// <param name="data">要导出的数据</param>
        /// <param name="filePath">CSV文件路径</param>
        private static void ExportToCsv(object data, string filePath)
        {
            var sb = new StringBuilder();

            if (data is IEnumerable<object> items)
            {
                var itemList = items.ToList();
                if (itemList.Count > 0)
                {
                    // 获取第一个对象的属性作为列标题
                    var firstItem = itemList[0];
                    var properties = firstItem.GetType().GetProperties();

                    // 写入标题行
                    sb.AppendLine(string.Join(",", properties.Select(p => p.Name)));

                    // 写入数据行
                    foreach (var item in itemList)
                    {
                        var values = properties.Select(p =>
                        {
                            var value = p.GetValue(item);
                            return value?.ToString()?.Replace(",", "，") ?? "";
                        });
                        sb.AppendLine(string.Join(",", values));
                    }
                }
            }

            File.WriteAllText(filePath, sb.ToString(), Encoding.UTF8);
        }
    }
}
