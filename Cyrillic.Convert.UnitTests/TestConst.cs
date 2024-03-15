namespace Cyrillic.Convert.UnitTests
{
    public static class TestConst
    {
        public static string SerbianCyrillicLetters = "Љ,Њ,Џ,љ,њ,џ,а,б,в,г,д,ђ,е,ж,з,и,ј,к,л,м,н,о,п,р,с,т,ћ,у,ф,х,ц,ч,ш";
        public static string SerbianLatinLetters = "Lj,Nj,Dž,lj,nj,dž,a,b,v,g,d,đ,e,ž,z,i,j,k,l,m,n,o,p,r,s,t,ć,u,f,h,c,č,š";

        public static string RussianCyrillicLetters = "a,б,в,г,д,е,ё,ж,з,и,й,к,л,м,н,о,п,р,с,т,у,ф,х,ц,ч,ш,щ,ы,ю,я,А,Б,В,Г,Д,Е,Ё,Ж,З,И,Й,К,Л,М,Н,О,П,Р,С,Т,У,Ф,Х,Ц,Ч,Ш,Щ,Ы,Ю,Я"; //special case Э => E, э => e, ъ => '', ь => '', Ъ => '', Ь => ''
        public static string RussianLatinLetters = "a,b,v,g,d,e,yo,zh,z,i,j,k,l,m,n,o,p,r,s,t,u,f,kh,ts,ch,sh,shch,y,ju,ja,A,B,V,G,D,E,Yo,Zh,Z,I,J,K,L,M,N,O,P,R,S,T,U,F,Kh,Ts,Ch,Sh,Shch,Y,Ju,Ja"; //special case sch => щ, shch => щ


    }
}
