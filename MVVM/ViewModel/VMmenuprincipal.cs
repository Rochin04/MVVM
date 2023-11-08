using System;
using System.Collections.Generic;
using System.Text;
using MVVM.View;
using MVVM.Model;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Windows.Input;
using MVVM.View;
using MVVM.Model;
using static System.Net.WebRequestMethods;

namespace MVVM.ViewModel
{
    public class VMmenuprincipal : BaseViewModel
    {
        #region Variables
        string _Texto;
        public List<Mmenuprincipal> listapaginas { get; set; }
        #endregion
        #region CONSTRUCTOR
        public void MostrarPaginas()
        {
            listapaginas = new List<Mmenuprincipal>
            {
                new Mmenuprincipal
                {
                    pagina = "Entry, datapicker, picker, lable, navegacion",
                    icono = "https://i.ibb.co/w4tnkvr/ectoplasma.png"
                },
                new Mmenuprincipal
                {
                    pagina = "Coleccion view sin enlace a base de datos",
                    icono = "https://i.ibb.co/vhMGL81/ataud.png"
                },
                new Mmenuprincipal
                {
                    pagina = "crud pokemon",
                    icono = "https://i.ibb.co/ChJCRp1/guadana.png"
                },
            };
        }
        public async Task Navegar(Mmenuprincipal parametros)
        {
            string pagina;
            pagina = parametros.pagina;
            if (pagina.Contains("Entry, datapicker"))
            {
                await Navigation.PushAsync(new Page1());
            }
            if (pagina.Contains("Coleccion view sin enlace"))
            {
                await Navigation.PushAsync(new Page2());
            }
            if (pagina.Contains("crud pokemon"))
            {
                await Navigation.PushAsync(new PokemonCrud());
            }
        }
        #endregion
        public VMmenuprincipal(INavigation navigation)
        {
            Navigation = navigation;
            MostrarPaginas();
        }
        //public async Task Volver()
        //{
        //    await Navigation.PopAsync();
        //}

        //public ICommand Volvercommand => new Command(async () => await Volver());
        //public ICommand ProcesoSimplecommand => new Command(ProcesoSimple);
        //public ICommand Alertacommand => new Command<MuUsuario>(async (p) => await Alerta(p));
        public ICommand Navegarcommand => new Command<Mmenuprincipal>(async (p) => await Navegar(p));
    }
}
