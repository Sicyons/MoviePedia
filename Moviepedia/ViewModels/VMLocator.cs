using CommonServiceLocator;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight;

namespace Moviepedia.ViewModels
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// </summary>
    public class VMLocator
    {
        #region Properties
        public VMMain Main
        {
            get
            {
                return ServiceLocator.Current.GetInstance<VMMain>();
            }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the VMLocator class.
        /// </summary>
        public VMLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register<VMMain>();
        }// VMLocator()
        #endregion

        #region Public interface
        static public void Cleanup()
        {
        }// Cleanup()
        #endregion
    }
}