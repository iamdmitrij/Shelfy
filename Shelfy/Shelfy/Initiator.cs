using Topshelf;

namespace Shelfy
{
    public class Initiator
    {
        public Initiator()
        {
        }

        public void Execute()
        {
            var service = HostFactory.New(x =>
             {
                 x.SetServiceName("Shelfy");
                 x.SetInstanceName("ShelfyShelf");
                 x.SetDescription("ShelfyShelfShelfsky");
                 x.Service<CuriousRunner>(c =>
                 {
                     c.ConstructUsing(instance => new CuriousRunner(instance.ServiceName));
                     c.WhenStarted(instance => instance.Run());
                     c.WhenStopped(instance => instance.StandStill());
                 });

                 x.RunAsLocalService();
                 x.StartAutomatically();
             });

            service.Run();
        }
    }
}
