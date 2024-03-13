// See https://aka.ms/new-console-template for more information
using static KodeBuah;

public class KodeBuah
{
    public enum EnumBuah
    {
        Apel, Aprikot, Alpukat, 
        Pisang, Paprika, 
        Blackberry, 
        Ceri, 
        Kelapa,
        Jagung,
        Kurma,
        Durian,
        Anggur,
        Melon,
        Semangka
    } 
    
    public static String getKodeBuah(EnumBuah buah)
    {
        String[] output = { "A00", "B00", "C00", "D00", "E00", "F00", "H00", "I00", "J00", "K00", "L00", "M00", "N00", "O00"};
        return output[(int)buah];
    }
}

public class mainClass
{
    public static void Main(String[] args)
    {
        EnumBuah list = EnumBuah.Durian;
        String kodeBuah = getKodeBuah(list);
        Console.WriteLine("Buah {1}, kode Buahnya adalah {0}", kodeBuah, list);

    }
}

