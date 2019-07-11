﻿using JetBrains.Annotations;
using System;

namespace Volo.Abp
{
    public class DisposeAction : IDisposable
    {
        private readonly Action _action;

        public DisposeAction([NotNull] Action action)
        {
            Check.NotNull(action, nameof(action));

            _action = action;
        }

        public void Dispose()
        {
            _action();
        }
    }
}
