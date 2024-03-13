// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

public class kodeBuah
{
    public enum EnumKodepos
    {
        Apel, Aprikot, Alpukat, 
        Pisang, Paprika, 
        Blackberry, 
        Ceri, 
        Kelapa,
        Jagung
    }

    public static String getKodeBuah(EnumKodepos kodeBuah)
    {
        String[] outputKode = { "A00", "B00", "C00", "D00", "E00", "F00", "H00", "I00", "J00"};
        return outputKode[(int)kodeBuah];
    }
}

}
