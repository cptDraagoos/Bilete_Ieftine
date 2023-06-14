using System;
using BileteLibrary;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeleteMgm
{
    public class Admnistrare
    {
        private const int NrMax_Bilete = 50;
        private string numeFisier;

        public Admnistrare(string numeFisier)
        {
            this.numeFisier = numeFisier;
            Stream streamFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }

        public void AddBilet(Bilete bilete)
        {
            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, true))
            {
                streamWriterFisierText.WriteLine(bilete.Conversie_fisier());
            }
        }

        public Bilete[] getBilete(out int nrBilete)
        {
            Bilete[] bilete = new Bilete[NrMax_Bilete];

            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
                nrBilete = 0;
                while((linieFisier = streamReader.ReadLine()) != null)
                {
                    bilete[nrBilete++] = new Bilete(linieFisier);
                }
            }
            return bilete;
        }
        public Bilete GetBilet(string artist, string locatie)
        {
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    Bilete bilete = new Bilete(linieFisier);
                    if(bilete.NumeArtist == artist && bilete.LocatieConcert == locatie)
                    {
                        return bilete;
                    }
                }
            }
            return new Bilete();
        }
        public Bilete getBilet(int id)
        {
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
                while((linieFisier=streamReader.ReadLine()) != null)
                {
                    Bilete bilete = new Bilete(linieFisier);
                    if(bilete.IdBilet == id)
                    {
                        return bilete;
                    }
                }
            }
            return new Bilete();
        }
    }
}
