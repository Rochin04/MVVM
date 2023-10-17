using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVM.ViewModel
{
    class VMpatron : BaseViewModel
    {
        #region CONSTRUCTOR
        public VMpatron(INavigation navigation)
        {
            Navigation = navigation;
        }
        #region PROCESOS
        public async Task ProcesoAsyncrono()
        {

        }
        public void ProcesoSimple()
        {

        }
        #endregion
        #endregion
        #region COMANDO
        public ICommand ProcesoAsyncronocommand => new Command(async () => await ProcesoAsyncrono());
        public ICommand ProcesoSimCommand => new Command(ProcesoSimple);
        #endregion
        
    }
}
