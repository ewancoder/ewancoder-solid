namespace Ewancoder.Solid.Patterns
{
    using System;

    public abstract class Singleton<T> where T : class
    {
        protected Singleton() { }

        public static T Instance => lazy.Value;

        private static readonly Lazy<T> lazy = new Lazy<T>(CreateInstance);

        private static T CreateInstance()
            => Activator.CreateInstance(typeof(T), true) as T;
    }
}