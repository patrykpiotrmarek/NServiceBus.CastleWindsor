namespace NServiceBus_6.ContainerTests
{
    using System;
    using ObjectBuilder.Common;

    public static class TestContainerBuilder
    {
        public static Func<IContainer> ConstructBuilder = () => (IContainer)Activator.CreateInstance(Type.GetType("NServiceBus_6.AutofacObjectBuilder,NServiceBus_6.Core"));

    }
}