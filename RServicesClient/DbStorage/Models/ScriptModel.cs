using System;

namespace DataAnalyzer.DbStorage.Models
{
    public class ScriptModel
    {
        public Int32 ID { get; set; }
        public String Name { get; set; }
        public String Script { get; set; }
        public String SqlInput { get; set; }

        public Int32 CategoryId { get; set; }
    }

}
