using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using MVVM.View;
using System.Data;
using System.Xml.Serialization;

namespace MVVM.ViewModel
{
    public class VMpagina1 : BaseViewModel
    {
        string _Mensaje;
        string _N1;
        string _N2;
        string _R;
        string _TipoUsuario;
        DateTime _Fecha;
        string _ResultadoFecha;
        #region CONSTRUCTOR
        public VMpagina1(INavigation navigation)
        {
            Navigation = navigation;
            Fecha = DateTime.Now;
        }
        #endregion
        #region PROCESOS
        public async Task Alerta()
        {

        }
        public async Task Navegarpagina2()
        {
            await Navigation.PushAsync(new Page2());
        }
        public async Task NavegarMenu()
        {
            await Navigation.PushAsync(new Menuprincipal());
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
        public DateTime Fecha
        {
            get { return _Fecha; }
            set { _Fecha = value;
                OnpropertyChanged(Fecha.ToString());
            }
        }
        public string ResultadoFecha
        {
            get { return _ResultadoFecha; }
            set { SetValue(ref _ResultadoFecha, value) ; }
        }
        #endregion
        #region COMANDOS
        public ICommand PNavegarpagina2command => new Command(async () => await Navegarpagina2());
        public ICommand PNavegarmenucommand => new Command(async () => await NavegarMenu());
        public ICommand Sumascommand => new Command(Sumas);
        #endregion

        public string TipoUsuario
        {
            get { return _TipoUsuario; }
            set { SetValue(ref _TipoUsuario, value); }
        }
        public string SelecionarTipoUsuario
        {
            get { return _TipoUsuario; }
            set
            {
                SetValue(ref _TipoUsuario, value);
                TipoUsuario = _TipoUsuario;
            }
        }
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
