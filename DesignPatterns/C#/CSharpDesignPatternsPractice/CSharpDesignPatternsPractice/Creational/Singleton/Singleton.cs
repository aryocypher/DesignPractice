using CSharpDesignPatternsPractice.Creational.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

//Singleton si= Singleton.GetInstance();
//Console.WriteLine(si.Text);


namespace CSharpDesignPatternsPractice.Creational.Singleton
{

    public class Singleton
    {
        private static Singleton instance;

        public int Text { get; set; }

        public Singleton()
        {
                Text = 0;
        }
        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
    }
}
