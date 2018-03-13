// This file is part of Hangfire.
// Copyright © 2015 Sergey Odinokov.
// 
// Hangfire is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as 
// published by the Free Software Foundation, either version 3 
// of the License, or any later version.
// 
// Hangfire is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public 
// License along with Hangfire. If not, see <http://www.gnu.org/licenses/>.

using Hangfire.SqlServer;
using Hangfire.SqlServer.Msmq;
using Hangfire.States;
using System;
using System.Messaging;

// ReSharper disable once CheckNamespace
namespace Hangfire
{
    public static class MsmqExtensions
    {
        public static IGlobalConfiguration<SqlServerStorage> UseMsmqQueues(
            this IGlobalConfiguration<SqlServerStorage> configuration,
            string pathPattern, 
            params string[] queues)
        {
            return UseMsmqQueues(configuration, MsmqTransactionType.Internal, pathPattern, queues);
        }

        public static IGlobalConfiguration<SqlServerStorage> UseMsmqQueues(
            this IGlobalConfiguration<SqlServerStorage> configuration,
            MsmqTransactionType transactionType,
            string pathPattern,
            params string[] queues)
        {
            if (queues.Length == 0)
            {
                queues = new[] { EnqueuedState.DefaultQueue };
            }

            var provider = new MsmqJobQueueProvider(pathPattern, queues, transactionType);
            configuration.Entry.QueueProviders.Add(provider, queues);

            return configuration;
        }

        // https://www.cnblogs.com/ecin/p/6201262.html#%E4%B8%8Equartznet%E5%AF%B9%E6%AF%94
        // 与MSMQ集成
        public static IGlobalConfiguration<SqlServerStorage> UseMsmq(this IGlobalConfiguration<SqlServerStorage> configuration, string pathPattern, params string[] queues)
        {
            if (string.IsNullOrEmpty(pathPattern)) throw new ArgumentNullException(nameof(pathPattern));
            if (queues == null) throw new ArgumentNullException(nameof(queues));

            foreach (var queueName in queues)
            {
                var path = string.Format(pathPattern, queueName);

                if (!MessageQueue.Exists(path))
                    using (var queue = MessageQueue.Create(path, transactional: true))
                        queue.SetPermissions("Everyone", MessageQueueAccessRights.FullControl);
            }
            return configuration.UseMsmqQueues(pathPattern, queues);
        }
    }
}
