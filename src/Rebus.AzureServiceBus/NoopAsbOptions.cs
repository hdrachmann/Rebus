using System;

namespace Rebus.AzureServiceBus
{
    public class NoopAsbOptions : IAsbOptions
    {
        public IAsbOptions AutomaticallyRenewPeekLockEvery(TimeSpan customTimeSpan)
        {
            return this;
        }

        public IAsbOptions DoNotAutomaticallyRenewPeekLock()
        {
            return this;
        }

        public IAsbOptions PrefecthCount(int prefectNumberOfMessages)
        {
            return this;
        }
    }
}