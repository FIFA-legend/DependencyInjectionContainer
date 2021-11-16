using System;

namespace DIContainer
{
    public class ImplementationInfo
    {
        public readonly Type ImplClassType;

        public readonly LifeTime LifeTime;

        public ImplementationInfo(LifeTime lt, Type impl)
        {
            ImplClassType = impl;
            LifeTime = lt;
        }
    }
}