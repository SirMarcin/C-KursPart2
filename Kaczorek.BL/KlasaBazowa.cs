namespace Kaczorek.BL
{
    public abstract class KlasaBazowa
    {
        public bool JestNowy { get; set; }
        public bool MaZmiany { get; set; }
        public StanObiektuOpcje StanObiektu { get; set; }
        public bool DanePrawidlowe
        {
            get
            {
                return true;
            }
        }
    }

    public enum StanObiektuOpcje
    {
        Aktywny,
        Usunięty
    }

}

