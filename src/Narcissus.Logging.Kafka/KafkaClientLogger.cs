using Confluent.Kafka;
using Narcissus.Logging.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Confluent.Kafka.Serialization;
using Newtonsoft.Json.Linq;

namespace Narcissus.Logging.Kafka
{
    public class KafkaClientLogger : ILogger
    {
        private const string kafkaConfigParameter = "bootstrap.servers";

        private readonly KafkaClientLoggerOptions _options;
        private readonly string _catalog;

        private Producer<Null, string> _producer;
        public KafkaClientLogger(string catalogName, KafkaClientLoggerOptions options)
        {
            this._options = options;
            this._catalog = catalogName;

            var config = new Dictionary<string, object> { { kafkaConfigParameter, _options.BrokerList } };
            this._producer = new Producer<Null, string>(config, null, new StringSerializer(Encoding.UTF8));
        }
        public void Dispose()
        {
            if (_producer != null)  
            {
                _producer.Dispose();
            }
        }

        public async Task LogAsync<TState>(LogLevel type, ILogContext logContext, Exception ex, string message,  TState state, CancellationToken token = default(CancellationToken)) where TState : class
        {
            var log = new Narcissus.Logging.Core.LogMessage<TState>();
            log.LogContext = logContext;
            log.Message = message;
            log.StackTrace = Environment.StackTrace;
            log.State = state;
            log.Level = type;
            await _producer.ProduceAsync(_options.Topic, null, JObject.FromObject(log).ToString());            
        }
    }
}