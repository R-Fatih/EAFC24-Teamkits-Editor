using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EAFC24_Teamkits_Editor_WinForms.Helpers
{
    public static class TsvExporter
    {
        public static string ToDelimitedText<T>(this List<T> list, char delimiter = '\t', bool includeHeader = false, bool trimTrailingNewLineIfExists = false)
            where T : class, new()
        {
            int itemCount = list.Count;
            if (itemCount == 0) return string.Empty;

            var properties = typeof(T).GetProperties();
            int propertyCount = properties.Length;
            var outputBuilder = new StringBuilder();

            AddHeaderIfRequired(outputBuilder, includeHeader, properties, propertyCount, delimiter);

            for (int itemIndex = 0; itemIndex < itemCount; itemIndex++)
            {
                T listItem = list[itemIndex];
                AppendListItemToOutputBuilder(outputBuilder, listItem, properties, propertyCount, delimiter);

                AddNewLineIfRequired(trimTrailingNewLineIfExists, itemIndex, itemCount, outputBuilder);
            }

            var output = outputBuilder.ToString();
            return output;
        }

        private static void AddHeaderIfRequired(StringBuilder outputBuilder, bool includeHeader, PropertyInfo[] properties, int propertyCount, char delimiter)
        {
            if (!includeHeader) return;

            for (int propertyIndex = 0; propertyIndex < properties.Length; propertyIndex++)
            {
                var property = properties[propertyIndex];
                var propertyName = property.Name;
                outputBuilder.Append(propertyName);
                AddDelimiterIfRequired(outputBuilder, propertyCount, delimiter, propertyIndex);
            }
            outputBuilder.Append(Environment.NewLine);
        }

        private static void AddDelimiterIfRequired(StringBuilder outputBuilder, int propertyCount, char delimiter, int propertyIndex)
        {
            bool isLastProperty = (propertyIndex + 1 == propertyCount);
            if (!isLastProperty)
            {
                outputBuilder.Append(delimiter);
            }
        }

        private static void AppendListItemToOutputBuilder<T>(StringBuilder outputBuilder, T listItem, PropertyInfo[] properties, int propertyCount, char delimiter)
        {
            for (int propertyIndex = 0; propertyIndex < properties.Length; propertyIndex++)
            {
                var property = properties[propertyIndex];
                var propertyValue = property.GetValue(listItem);
                outputBuilder.Append(propertyValue);

                AddDelimiterIfRequired(outputBuilder, propertyCount, delimiter, propertyIndex);
            }
        }

        private static void AddNewLineIfRequired(bool trimTrailingNewLineIfExists, int itemIndex, int itemCount, StringBuilder outputBuilder)
        {
            bool isLastItem = (itemIndex + 1 == itemCount);
            if (!isLastItem || !trimTrailingNewLineIfExists)
            {
                outputBuilder.Append(Environment.NewLine);
            }
        }
    }

}
