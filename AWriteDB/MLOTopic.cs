using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWriteDB
{
    public class MloTopic
    {
        public int IdLoTopic { get; set; }

        private string topicName;

        public string TopicName
        {
            get { return topicName; }
            set { topicName = value; }
        }

        private string topicCode;

        public string TopicCode
        {
            get { return topicCode; }
            set { topicCode = value; }
        }

        private string topicShort;

        public string TopicShort
        {
            get { return topicShort; }
            set { topicShort = value; }
        }

        public string TopicDisplay()
        {
            return topicCode + ": " + topicShort;
        }

        public int IdUnitLearningOutcome { get; set; }

    }
}
