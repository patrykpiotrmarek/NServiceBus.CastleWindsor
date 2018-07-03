using NServiceBus_6.ContainerTests;
using NServiceBus_6.ObjectBuilder.CastleWindsor;
using NUnit.Framework;

[SetUpFixture]
public class SetUpFixture
{
    public SetUpFixture()
    {
        TestContainerBuilder.ConstructBuilder = () => new WindsorObjectBuilder();
    }

}