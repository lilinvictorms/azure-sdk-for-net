// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class DictionaryDecompounderTokenFilter : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (WordList != null && WordList.Any())
            {
                writer.WritePropertyName("wordList");
                writer.WriteStartArray();
                foreach (var item in WordList)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            else
            {
                writer.WriteNull("wordList");
            }
            if (MinWordSize != null)
            {
                writer.WritePropertyName("minWordSize");
                writer.WriteNumberValue(MinWordSize.Value);
            }
            if (MinSubwordSize != null)
            {
                writer.WritePropertyName("minSubwordSize");
                writer.WriteNumberValue(MinSubwordSize.Value);
            }
            if (MaxSubwordSize != null)
            {
                writer.WritePropertyName("maxSubwordSize");
                writer.WriteNumberValue(MaxSubwordSize.Value);
            }
            if (OnlyLongestMatch != null)
            {
                writer.WritePropertyName("onlyLongestMatch");
                writer.WriteBooleanValue(OnlyLongestMatch.Value);
            }
            writer.WritePropertyName("@odata.type");
            writer.WriteStringValue(ODataType);
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WriteEndObject();
        }

        internal static DictionaryDecompounderTokenFilter DeserializeDictionaryDecompounderTokenFilter(JsonElement element)
        {
            IList<string> wordList = default;
            int? minWordSize = default;
            int? minSubwordSize = default;
            int? maxSubwordSize = default;
            bool? onlyLongestMatch = default;
            string odataType = default;
            string name = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("wordList"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(item.GetString());
                        }
                    }
                    wordList = array;
                    continue;
                }
                if (property.NameEquals("minWordSize"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minWordSize = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("minSubwordSize"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minSubwordSize = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxSubwordSize"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxSubwordSize = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("onlyLongestMatch"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    onlyLongestMatch = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("@odata.type"))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
            }
            return new DictionaryDecompounderTokenFilter(odataType, name, wordList, minWordSize, minSubwordSize, maxSubwordSize, onlyLongestMatch);
        }
    }
}
