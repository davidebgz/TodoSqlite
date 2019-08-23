using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TodoSqlite.Helpers
{
    public sealed class AsyncLock
    {
        private readonly SemaphoreSlim _semaphore = new SemaphoreSlim(1, 1);
        private readonly Task<IDisposable> _releaser;
        public AsyncLock()
        {
            _releaser = Task.FromResult((IDisposable)new Releaser(this));
        }
        public Task<IDisposable> LockAsync()
        {
            var wait = _semaphore.WaitAsync();
            return wait.IsCompleted ?
                _releaser :
                wait.ContinueWith((_, state) => (IDisposable)state,
                _releaser.Result, CancellationToken.None,
                TaskContinuationOptions.ExecuteSynchronously, TaskScheduler.Default);
        }
        private sealed class Releaser : IDisponsable
        {
            private readonly AsyncLock m_ToRelease;
            internal Releser(AsyncLock toRelease)
            {
                m_ToRelease = toRelease;
            }
            public void Dispose()
            {
                m_ToRelease._semaphore.Release();
            }
        }

    }
}
