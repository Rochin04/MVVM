using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVM.ViewModel
{
    public class VMpagina1 : BaseViewModel
    {
        string _Mensaje;
        string _N1;
        string _N2;
        string _R;
        #region CONSTRUCTOR
        public VMpagina1(INavigation navigation)
        {
            Navigation = navigation;    
        }
        #endregion
        #region PROCESOS
        public async Task Alerta()
        {

        }
        public void Sumas()
        {
            double n1 = 0;
            double n2 = 0;
            double r = 0;
            n1 = Convert.ToDouble(N1);
            n2 = Convert.ToDouble(N2);
            r = Convert.ToDouble(R);
            r = n1 + n2;
            R = r.ToString();
        }
        #endregion
        #region COMANDOS
        public ICommand Alertacommand => new Command(async () => await Alerta());
        public ICommand Sumascommand => new Command(Sumas);
        #endregion
        public string Mensaje
        {
            get { return _Mensaje; }
            set { SetValue(ref _Mensaje, value); }
        }
        public string N1
        {
            get { return _N1; }
            set { SetValue(ref _N1, value); }
        }
        public string N2
        {
            get { return _N2; }
            set { SetValue(ref _N2, value); }
        }
        public string R
        {
            get { return _R; }
            set { SetValue(ref _R, value); }
        }
    }
}
