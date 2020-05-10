using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppJsonTest
{
    public class Student
    {

        /// <summary>
        /// Navn på Studerende
        /// </summary>
        public string Navn { get; set; }

        /// <summary>
        /// Adresse på studerende
        /// </summary>
        public string Adresse { get; set; }

        /// <summary>
        /// Cosntructor som taget to parametre
        /// </summary>
        /// <param name="navn">navn på studerende</param>
        /// <param name="adresse">adresse på studerende</param>
        public Student(string navn, string adresse)
        {
            this.Navn = navn;
            this.Adresse = adresse;
        }

        /// <summary>
        /// default constructor
        /// </summary>
        public Student()
        {

        }

        /// <summary>
        /// Override af ToString() metoden
        /// </summary>
        /// <returns>navn og adresse på den studerende</returns>
        public override string ToString()
        {
            return $"Navn: {Navn} , Adresse: {Adresse}";
        }
    }
}
