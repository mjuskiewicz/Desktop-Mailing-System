using System;

namespace DesktopMailingSystem.Infrastructure
{
    public class BaseViewModel<T>
    {
        private readonly T _controller;

        public BaseViewModel(T controller)
        {
            if (controller == null)
            {
                throw new ArgumentNullException("controller");
            }

            _controller = controller;
        }

        protected T Controller
        {
            get
            {
                return _controller;
            }
        }
    }
}
