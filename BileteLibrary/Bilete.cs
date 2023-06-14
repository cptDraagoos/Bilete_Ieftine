using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace BileteLibrary
{
    public class Bilete
    {
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';

        public int IdBilet { get; set; }
        public string NumeArtist { get; set; }
        public string LocatieConcert { get; set; }
        public int NumarBilete { get; set; }
        public int PretBilete { get; set; }
        public string TipAcces{ get; set; }   
        public DateTime DataCumparare { get; set; }
        public DateTime DataConcert { get; set; }

        public Bilete(int idBilet=0, string numeArtist = "NECUNOSCUT", string locatieConcert = "NECUNOSCUTA", int numarBilete = 0, int pretBilete = 0, string tipAcces = "NECUNOSCUT", DateTime dataCumparare = default, DateTime dataConcert = default)
        {
            IdBilet = idBilet;
            NumeArtist = numeArtist;
            LocatieConcert = locatieConcert;
            TipAcces = tipAcces;
            NumarBilete = numarBilete;
            PretBilete = pretBilete;
            DataCumparare = dataCumparare;
            DataConcert = dataConcert;
        }

        private const int ID_BILET = 0;
        private const int NUME_ARTIST = 1;
        private const int LOCATIE_CONCERT = 2;
        private const int NUMAR_BILETE = 3;
        private const int PRET_BILETE = 4;
        private const int DATA_CUMPARARE = 5;
        private const int DATE_CONCERT = 6;
        private const int TIP_ACCES = 7;

        public Bilete(string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);

            IdBilet = int.Parse(dateFisier[ID_BILET]);
            NumeArtist = dateFisier[NUME_ARTIST];
            LocatieConcert = dateFisier[LOCATIE_CONCERT];
            NumarBilete = int.Parse(dateFisier[NUMAR_BILETE]);
            PretBilete = int.Parse(dateFisier[PRET_BILETE]);
            TipAcces = dateFisier[TIP_ACCES];
            DateTime.TryParse(dateFisier[DATA_CUMPARARE],out DateTime DataCumparare);
            DataConcert = DateTime.Parse(dateFisier[DATE_CONCERT]);
        }

        public string Conversie_fisier()
        {
            string BileteFisier = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{8}{0}{6}{0}{7}{0}",
                SEPARATOR_PRINCIPAL_FISIER,
                IdBilet.ToString(),
                (NumeArtist ?? "NECUNOSCUT"),
                (LocatieConcert ?? "NECUNOSCUT"),
                NumarBilete.ToString(),
                PretBilete.ToString(),
                (DataCumparare.ToString() ?? "NECUNOSCUT"),
                (DataConcert.ToString() ?? "NECUNOSCUT"),
                (TipAcces ?? "NECUNOSCUT"));
            return BileteFisier;
        }

        public string Info()
        {
            string Info = string.Format("{0}: {1} vor venii sustine concertul in {2} la data de {5}. Numarul de bilete este {3} la pretul de {4} pentru acces de tip {6}",
                IdBilet.ToString(),
                (NumeArtist ?? "NECUNOSCUT"),
                (LocatieConcert ?? "NECUNOSCUT"),
                NumarBilete.ToString(),
                PretBilete.ToString(),
                (DataConcert.ToString() ?? "NECUNOSCUT"),
                (TipAcces ?? "NECUNOSCUT"));
            return Info;
        }
    }
}
