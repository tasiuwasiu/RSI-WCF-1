using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Library
{
    /// <summary>
    /// Interfejs kontraktu
    /// Autor: Rafal Wasik
    /// </summary>
    [ServiceContract]
    public interface IDictService
    {
        /// <summary>
        /// Metoda dodaje nowe tlumaczenie do slownika
        /// </summary>
        /// <param name="n1">string - klucz</param>
        /// <param name="n2">string - wartosc</param>
        /// <returns>bool - czy tlumaczenie zostalo dodane</returns>
        [OperationContract]
        bool addWord(String n1, String n2);

        /// <summary>
        /// Metoda modyfikuje tlumaczenie w slowniku
        /// </summary>
        /// <param name="n1">string - klucz</param>
        /// <param name="n2">string - wartosc</param>
        /// <returns>bool - czy tlumaczenie zostalo zmodyfikowane</returns>
        [OperationContract]
        bool modifyWord(String n1, String n2);

        /// <summary>
        /// Metoda usuwa tlumaczenie ze slownika
        /// </summary>
        /// <param name="n">string - klucz</param>
        /// <returns>bool - czy tlumaczenie zostalo usuniete</returns>
        [OperationContract]
        bool removeWord(String n);

        /// <summary>
        /// Metoda wyszukuje tlumaczenie w slowniku
        /// </summary>
        /// <param name="n">string - klucz</param>
        /// <returns>wartosc do wyswietlenia</returns>
        [OperationContract]
        String searchWord(String n);

    }
}
