using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringParser
{
    public class SchemaItem
    {

        public SchemaItem(string name,int start,int length,string type,string remark)
        {
            this.name = name;
            this.start = start;
            this.length = length;
            this.type = type;
            this.remark = remark;

        }

        private string name, type, remark;
        private int start, length;

        private string value;

        public string Name { get { return name; } }
        public string Type { get { return type; } }
        public string Remark { get { return remark; } }
        public int Start { get { return start; } }
        public int Length { get { return length; } }
        public string Value { get { return value; } set { this.value = value; } }

    }
}
