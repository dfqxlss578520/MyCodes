using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Dependencies;
using Ninject;          //引入ninject

namespace NinjectTest.Ninject
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;
        public NinjectDependencyResolver()
        {
            this.kernel = new StandardKernel();
            this.AddBings();
        }

        public void AddBings()
        {
            //绑定好接口。
            this.kernel.Bind<IMessageProvider>().To<NinjectMessage>();
        }

        public object GetServer(Type typeServer)
        {
           return this.kernel.TryGet(typeServer);
        }
       
        public IEnumerable<object> GetServices(Type serviceType)
        {
            return this.kernel.GetAll(serviceType);
        }

        public IDependencyScope BeginScope()
        {
            throw new NotImplementedException();
        }

        public object GetService(Type serviceType)
        {
            return this.kernel.TryGet(serviceType);
        }

        
        public void Dispose()
        {
            this.kernel.Dispose();
        }
    }
}