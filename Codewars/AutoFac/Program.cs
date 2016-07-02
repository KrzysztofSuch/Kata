using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;

namespace TryAutoFac
{
    class Program
    {
        private static IContainer Container { get; set; }


        static void Main(string[] args)
        {
            var containerBuilder = new ContainerBuilder();

            containerBuilder.RegisterType<ConsoleOutput>().As<IOutput>();
            containerBuilder.RegisterType<TodayWriter>().As<IDataWriter>();

            Container = containerBuilder.Build();


            WriteDate();
        }

        private static void WriteDate()
        {
            using (var scope = Container.BeginLifetimeScope())
            {
                var writer = scope.Resolve<IDataWriter>();
                writer.WriteData();


            }
        }
    }
}
