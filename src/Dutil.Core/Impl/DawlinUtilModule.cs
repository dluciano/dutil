using Autofac;
using Dutil.Core.Abstract;

namespace Dutil.Core.Impl
{
    public sealed class DawlinUtilModule : Module
    {
        protected override void Load(ContainerBuilder builder) =>
            builder.RegisterType<ListRandomizer>().As<IListRandomizer>();
    }
}