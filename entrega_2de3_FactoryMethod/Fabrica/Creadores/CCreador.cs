namespace MetodoFabrica02.Fabrica.Creadores
{
    internal class CCreador
    {
        internal static ELECTRODOM MetodoFabrica(int dinero)
        {
            ELECTRODOM temp = null;

            if (dinero > 1000)
            {
                temp = new CLicuadora();
            }
            else
            {
                temp = new CCelular();
            }
            return temp;
        }

    }
}