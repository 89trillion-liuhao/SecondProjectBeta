using System;
using System.Collections.Generic;

using TableConfig;
namespace Model
{
    [Serializable]
    public class BuffModel : BaseModel
    {
        public int id;
        public int Name;
        public string note;
        public int MaxHp;
        public int Atk;
        public int Def;
       
        private Dictionary<string, string> parsePerValue = new Dictionary<string, string>();
        public override object Key()
        {
            return id;
        }
        public Dictionary<string, string> ParsePerValue
        {
            get { return parsePerValue; }
            set { parsePerValue = value; }
        }
    }
}