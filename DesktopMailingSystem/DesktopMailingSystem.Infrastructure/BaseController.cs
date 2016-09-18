namespace DesktopMailingSystem.Infrastructure
{
    public abstract class BaseController<VM> : IBaseController<VM>
    {
        private VM _viewModel;

        public VM ViewModel
        {
            get
            {
                return _viewModel;
            }
            set
            {
                _viewModel = value;
                OnViewModelAssigned();
            }
        }

        protected virtual void OnViewModelAssigned()
        {
        }
    }
}