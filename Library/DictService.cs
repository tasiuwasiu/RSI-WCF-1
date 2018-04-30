using System;
using System.Collections.Generic;


namespace Library
{
    /// <summary>
    /// Klasa implementujaca interfejs kontaktu
    /// Autor: Rafal Wasik
    /// </summary>
    public class DictService : IDictService
    {
        Dictionary<string, String> dict = new Dictionary<string, string>();

        /// <summary>
        /// Metoda dodaje nowe tlumaczenie do slownika
        /// </summary>
        /// <param name="n1">string - klucz</param>
        /// <param name="n2">string - wartosc</param>
        /// <returns>bool -  czy tlumaczenie zostalo dodane</returns>
        public bool addWord (String n1, String n2)
        {
            try
            {
                dict.Add(n1, n2);
            }
            catch (ArgumentException e)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Metoda modyfikuje tlumaczenie w slowniku
        /// </summary>
        /// <param name="n1">string - klucz</param>
        /// <param name="n2">string - wartosc</param>
        /// <returns>bool - czy tlumaczenie zostalo zmodyfikowane</returns>
        public bool modifyWord(String n1, String n2)
        {
            if (dict.ContainsKey(n1))
            {
                dict.Remove(n1);
                dict.Add(n1, n2);
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// Metoda usuwa tlumaczenie ze slownika
        /// </summary>
        /// <param name="n">string - klucz</param>
        /// <returns>bool - czy tlumaczenie zostalo usuniete</returns>
        public bool removeWord(String n)
        {
            if (dict.Remove(n))
                return true;
            else
                return false;
        }

        /// <summary>
        /// Metoda wyszukuje tlumaczenie w slowniku
        /// </summary>
        /// <param name="n">string - klucz</param>
        /// <returns>wartosc do wyswietlenia</returns>
        public String searchWord(String n)
        {
            string val = "";
            if (dict.TryGetValue(n, out val))
            {
                return val;
            }
            else
                return "Nie odnaleziono!";

        }
    }
}
