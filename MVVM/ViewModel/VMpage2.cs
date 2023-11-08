using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using MVVM.View;
using MVVM.Model;
using static System.Net.WebRequestMethods;

namespace MVVM.ViewModel
{
    public class VMpage2 : BaseViewModel
    {
        string _Texto;
        public List<MuUsuario> ListaUsuarios {  get; set; }
        public VMpage2(INavigation navigation)
        {
            Navigation = navigation;
            MostrarUsuarios();
        }

        public async Task Volver()
        {
            await Navigation.PopAsync();
        }
        public async Task Alerta(MuUsuario parametros)
        {
            await DisplayAlert("Titulo", parametros.nombre, "Ok");
        }
        public void ProcesoSimple()
        {

        }
        public void MostrarUsuarios()
        {
            ListaUsuarios = new List<MuUsuario>
            {
                new MuUsuario
                {
                    nombre = "Frank",
                    Imagen = "https://i.ibb.co/w4tnkvr/ectoplasma.png"
                },
                new MuUsuario
                {
                    nombre = "Janck",
                    Imagen = "https://i.ibb.co/vhMGL81/ataud.png"
                },
                new MuUsuario
                {
                    nombre = "Jack",
                    Imagen = "https://i.ibb.co/ChJCRp1/guadana.png"
                },
            };
        }
        public ICommand Volvercommand => new Command(async () => await Volver());
        //public ICommand ProcesoSimplecommand => new Command(ProcesoSimple);
        public ICommand Alertacommand => new Command<MuUsuario>(async (p) => await Alerta(p));
    }
}
