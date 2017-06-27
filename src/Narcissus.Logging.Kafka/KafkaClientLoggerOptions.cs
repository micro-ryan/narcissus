using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Narcissus.Logging.Kafka
{
    public struct KafkaClientLoggerOptions
    {
        public string BrokerList { get; set; }
        public string Topic { get; set; }
    }
}
