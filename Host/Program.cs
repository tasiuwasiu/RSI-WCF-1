using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace Host
{
    /// <summary>
    /// Klasa tworzaca nowe polaczenie Hosta
    /// Autor: Rafal Wasik
    /// </summary>
    class Program
    {
        /// <summary>
        /// Metoda main tworzaca oraz uruchamiajaca hosta
        /// </summary>
        static void Main(string[] args)
        {
            Uri baseAddress = new Uri("http://localhost:10013/dictionary");
            ServiceHost myHost = new ServiceHost(typeof(DictService),baseAddress);

            try
            {
                WSHttpBinding myBinding = new WSHttpBinding();
                ServiceEndpoint endpoint1 = myHost.AddServiceEndpoint(typeof(IDictService), myBinding, "endpoint1");
                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                myHost.Description.Behaviors.Add(smb);
                myHost.Open();
                Console.WriteLine("Serwis slownika dziala");
                Console.ReadLine();
                myHost.Close();
            }
            catch (CommunicationException e)
            {
                Console.WriteLine("Host error {0}", e.Message);
                myHost.Abort();
            }
        }
    }
}
