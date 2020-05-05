using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using System.Collections;
using Newtonsoft.Json.Linq;

namespace EPocalipse.Json.Viewer
{
    public enum JsonType { Object, Array, Value };

    class JsonParseError : ApplicationException
    {
        public JsonParseError() : base() { }
        public JsonParseError(string message) : base(message) { }
        protected JsonParseError(SerializationInfo info, StreamingContext context) : base(info, context) { }
        public JsonParseError(string message, Exception innerException) : base(message, innerException) { }

    }

    public class JsonObjectTree
    {
        private JsonObject _root;

        public static JsonObjectTree Parse(string json)
        {
            //Parse the JSON string
            object jsonObject;
            try
            {
                jsonObject = JsonConvert.DeserializeObject(json);
            }
            catch (Exception e)
            {
                throw new JsonParseError(e.Message, e);
            }
            //Parse completed, build the tree
            return new JsonObjectTree(jsonObject);
        }

        public JsonObjectTree(object rootObject)
        {
            _root = ConvertToObject("JSON", rootObject);
        }

        private JsonObject ConvertToObject(string id, object jsonObject)
        {
            JsonObject obj = CreateJsonObject(jsonObject);
            obj.Id = id;
            AddChildren(jsonObject, obj);
            return obj;
        }

        private void AddChildren(object jsonObject, JsonObject obj)
        {
            JObject javaScriptObject = jsonObject as JObject;
            if (javaScriptObject != null)
            {
                foreach (KeyValuePair<string, JToken> pair in javaScriptObject)
                {
                    obj.Fields.Add(ConvertToObject(pair.Key, pair.Value));
                }
            }
            else
            {
                JArray javaScriptArray = jsonObject as JArray;
                if (javaScriptArray != null)
                {
                    for (int i = 0; i < javaScriptArray.Count; i++)
                    {
                        obj.Fields.Add(ConvertToObject("[" + i.ToString() + "]", javaScriptArray[i]));
                    }
                }
            }
        }

        private JsonObject CreateJsonObject(object jsonObject)
        {
            JsonObject obj = new JsonObject();
            if (jsonObject is JArray)
                obj.JsonType = JsonType.Array;
            else if (jsonObject is JObject)
                obj.JsonType = JsonType.Object;
            else
            {
                obj.JsonType = JsonType.Value;
                obj.Value = jsonObject;
            }
            return obj;
        }

        public JsonObject Root
        {
            get
            {
                return _root;
            }
        }

    }
}
