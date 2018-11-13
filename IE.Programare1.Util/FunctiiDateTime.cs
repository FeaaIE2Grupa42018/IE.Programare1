namespace IE.Programare1.Util
{
    public class FunctiiDateTime
    {
        public static string ObtineNumaLuna(int pozitieLuna)
        {
            string[] luni = new string[12] { "Ian", "Feb", "Mar", "Apr", "Mai", "Iun", "Iul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            string numeLuna = luni[pozitieLuna - 1];
            return numeLuna;
        }
    }
}
