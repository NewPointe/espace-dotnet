using System;

namespace NewPointe.Util.QueryString
{

    [AttributeUsage(AttributeTargets.Property, Inherited = true, AllowMultiple = false)]
    sealed class QueryStringPropertyAttribute : Attribute
    {
        readonly string queryStringKey;

        public string QueryStringKey
        {
            get { return queryStringKey; }
        }

        // This is a positional argument
        public QueryStringPropertyAttribute(string queryStringKey)
        {
            this.queryStringKey = queryStringKey;
        }

    }

}