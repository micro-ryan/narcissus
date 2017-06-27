using Narcissus.Logging.Abstract;
using Narcissus.Logging.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Narcissus.Logging.Kafka
{
    public class KafkaClientLoggerProvider : LoggerProvider
    {
        private readonly KafkaClientLoggerOptions _options;
        public KafkaClientLoggerProvider(KafkaClientLoggerOptions options) : base()
        {
            this._options = options;
        }

        public override ILogger Create(string catalog)
        {
            return new KafkaClientLogger( catalog, this._options);
        }

        public override void Dispose()
        {

        }
    }
}
