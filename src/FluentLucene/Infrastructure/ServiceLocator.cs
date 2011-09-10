using System;

namespace FluentLucene.Infrastructure
{
    /// <summary>
    /// Implementation of a very simple service locator
    /// </summary>
    internal class ServiceLocator : IServiceLocator
    {
        private readonly ComponentContainer Container = new ComponentContainer();

        public ServiceLocator()
        {
            Container.Instance<IServiceLocator, ServiceLocator>(this);
        }

        /// <summary>
        /// Get a component of the given type
        /// </summary>
        /// <typeparam name="T">The type of the component</typeparam>
        /// <returns>The component of the requested type</returns>
        public T Get<T>()
        {
            return Container.Get<T>();
        }

        /// <summary>
        /// Get a component of the given type
        /// </summary>
        /// <param name="type">The type of the component</param>
        /// <returns>The component of the requested type</returns>
        public object Get(Type type)
        {
            return Container.Get(type);
        }
    }
}