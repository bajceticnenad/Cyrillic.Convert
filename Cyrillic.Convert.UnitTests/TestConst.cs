namespace Cyrillic.Convert.UnitTests
{
    public static class TestConst
    {
        public static string SerbianCyrillicLetters = "Љ,Њ,Џ,љ,њ,џ,а,б,в,г,д,ђ,е,ж,з,и,ј,к,л,м,н,о,п,р,с,т,ћ,у,ф,х,ц,ч,ш,А,Б,В,Г,Д,Ђ,Е,Ж,З,И,Ј,К,Л,М,Н,О,П,Р,С,Т,Ћ,У,Ф,Х,Ц,Ч,Ш";
        public static string SerbianLatinLetters = "Lj,Nj,Dž,lj,nj,dž,a,b,v,g,d,đ,e,ž,z,i,j,k,l,m,n,o,p,r,s,t,ć,u,f,h,c,č,š,A,B,V,G,D,Đ,E,Ž,Z,I,J,K,L,M,N,O,P,R,S,T,Ć,U,F,H,C,Č,Š";

        public static string RussianCyrillicLetters = "а,б,в,г,д,е,ё,ж,з,и,й,к,л,м,н,о,п,р,с,т,у,ф,х,ц,ч,ш,щ,ы,ю,я,А,Б,В,Г,Д,Е,Ё,Ж,З,И,Й,К,Л,М,Н,О,П,Р,С,Т,У,Ф,Х,Ц,Ч,Ш,Щ,Ы,Ю,Я"; //special case Э => E, э => e, ъ => '', ь => '', Ъ => '', Ь => ''
        public static string RussianLatinLetters = "a,b,v,g,d,e,yo,zh,z,i,j,k,l,m,n,o,p,r,s,t,u,f,kh,ts,ch,sh,shch,y,ju,ja,A,B,V,G,D,E,Yo,Zh,Z,I,J,K,L,M,N,O,P,R,S,T,U,F,Kh,Ts,Ch,Sh,Shch,Y,Ju,Ja"; //special case sch => щ, shch => щ

        public static string BulgarianCyrillicLetters = "а,б,в,г,д,е,ж,з,и,й,к,л,м,н,о,п,р,с,т,у,ф,х,ц,ч,ш,щ,ы,ю,я,ъ,А,Б,В,Г,Д,Е,Ж,З,И,Й,К,Л,М,Н,О,П,Р,С,Т,У,Ф,Х,Ц,Ч,Ш,Щ,Ы,Ю,Я,Ъ"; //special case Э => E, э => e, ъ => '', ь => '', Ъ => '', Ь => ''
        public static string BulgarianLatinLetters = "a,b,v,g,d,e,zh,z,i,j,k,l,m,n,o,p,r,s,t,u,f,kh,ts,ch,sh,sht,y,yu,ya,ǎ,A,B,V,G,D,E,Zh,Z,I,J,K,L,M,N,O,P,R,S,T,U,F,Kh,Ts,Ch,Sh,Sht,Y,Yu,Ya,Ǎ"; //special case sch => щ, shch => щ

        public static string UkrainianCyrillicLetters = "а,б,в,г,ґ,д,е,є,ж,з,и,і,к,л,м,н,о,п,р,с,т,у,ф,х,ц,ч,ш,щ,ю,я,А,Б,В,Г,Ґ,Д,Е,Є,Ж,З,И,І,К,Л,М,Н,О,П,Р,С,Т,У,Ф,Х,Ц,Ч,Ш,Щ,Ю,Я,зг,Зг,ЗГ,зГ"; //special case: ї,й,Ї,Й,ь
        public static string UkrainianLatinLetters = "a,b,v,h,g,d,e,ie,zh,z,y,i,k,l,m,n,o,p,r,s,t,u,f,kh,ts,ch,sh,shch,iu,ia,A,B,V,H,G,D,E,IE,Zh,Z,Y,I,K,L,M,N,O,P,R,S,T,U,F,Kh,Ts,Ch,Sh,Shch,IU,IA,zgh,Zgh,ZGH,zGH"; //special case: \,Zh,Ts,Ch,Sh,Ie,Iu,Ia , KH,TS,CH,SH,SHCH,

        public static string GeorgianCyrillicLetters = "ჭ,Ჭ,თ,Თ,ჟ,Ჟ,ფ,Ფ,ღ,Ღ,ყ,Ყ,შ,Შ,ჩ,Ჩ,ც,Ც,ძ,Ძ,ხ,Ხ,ა,Ა,ბ,Ბ,გ,Გ,დ,Დ,ე,Ე,ვ,Ვ,ზ,Ზ,ი,Ი,კ,Კ,ლ,Ლ,მ,Მ,ნ,Ნ,ო,Ო,პ,Პ,რ,Რ,ს,Ს,ტ,Ტ,უ,Უ,ქ,Ქ,ჯ,Ჯ,ჰ,Ჰ"; // special case: წ => ts, Წ => Ts
        public static string GeorgianLatinLetters = "tch,Tch,th,Th,zh,Zh,ph,Ph,gh,Gh,qh,Qh,sh,Sh,ch,Ch,ts,Ts,dz,Dz,kh,Kh,a,A,b,B,g,G,d,D,e,E,v,V,z,Z,i,I,k,K,l,L,m,M,n,N,o,O,p,P,r,R,s,S,t,T,u,U,q,Q,j,J,h,H";
    }
}