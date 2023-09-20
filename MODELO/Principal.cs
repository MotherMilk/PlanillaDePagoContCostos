namespace MODELO
{
    public class Principal
    {
        public string validar1 { get; set; }
        public string validar2 { get; set; }


        public decimal validarFrm()
        {
            switch (validar1)
            {
                case "UPES": return 1;
                case "PEPS": return 2;
                case "C/PROMO": return 3;
            }
            return 0;
        }

        public double validarFrm2()
        {
            switch (validar2)
            {
                case "UPES": return 1;
                case "PEPS": return 2;
                case "C/PROMO": return 3;
            }
            return 0;
        }
    }
}