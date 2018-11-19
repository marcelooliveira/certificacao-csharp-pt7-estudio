using System;

namespace _01_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Campainha campainha = new Campainha();
            campainha.OnCampainhaTocou += CampainhaTocou1;
            campainha.OnCampainhaTocou += CampainhaTocou2;
            Console.WriteLine("A campainha será tocada.");
            campainha.Tocar();

            campainha.OnCampainhaTocou -= CampainhaTocou1;
            Console.WriteLine("A campainha será tocada.");
            campainha.Tocar();

            Console.ReadKey();

        }

        static void CampainhaTocou1(object sender, EventArgs args)
        {
            Console.WriteLine("A campainha tocou.(1)");
        }
        static void CampainhaTocou2(object sender, EventArgs args)
        {
            Console.WriteLine("A campainha tocou.(2)");
        }
    }

    class Campainha
    {
        public event EventHandler OnCampainhaTocou;

        public void Tocar()
        {
            if (OnCampainhaTocou != null)
            {
                OnCampainhaTocou(this, new EventArgs());
            }

        }
    }
}

/// < image url="$(ProjectDir)/img2.png"/>


