using System;

namespace _01_01
{
    /// <image url="$(ProjectDir)/img1.png"/>
    class Program
    {
        static void Main(string[] args)
        {
            Campainha campainha = new Campainha();
            campainha.Tocar();
            Console.ReadKey();
        }
    }

    class Campainha
    {
        public Action OnCampainhaTocou { get; set; }

        public void Tocar()
        {
            if (OnCampainhaTocou != null)
            {
                OnCampainhaTocou();
            }
            
        }
    }
}


