namespace Lands.Infrastructure
{
    using Lands.ViewModels;
    class InstanaceLocator
    {
        #region Properties
        public MainViewModel Main
        {
            get;
            set;
        }
        #endregion

        #region Constructors
        public InstanaceLocator()
        {
            this.Main = new MainViewModel();
        }
        #endregion
    }
}
