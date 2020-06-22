namespace Estatica
{
    public static class Converter
    {
        public static float cotaçaoEuro = 5.89f;
        public static float cotaçaoDolar = 5.29f;
        public static float DolarParaReal( float valor ){
            return valor / cotaçaoDolar;
        }
        public static float RealParaDolar( float valor ){
            return valor * cotaçaoDolar;
        }
        public static float EuroParaReal( float valor ){
            return valor * cotaçaoEuro;
        }
        public static float RealParaEuro( float valor ){
            return valor / cotaçaoEuro;
        }


    }
}