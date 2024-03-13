// See https://aka.ms/new-console-template for more information
using System.Transactions;
using static KodeBuah;
using static PosisiKarakterGame;

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

public enum trigger { TombolS, TombolW, TombolX };
public enum status { Berdiri, Jongkok, Tengkurap,Terbang };

public class PosisiKarakterGame
{

    public status currentState = status.Berdiri;

    public class Transisi
    {
        public status Awal;
        public status Akhir;
        public trigger Trigger;

        public Transisi(status Awal, status Akhir, trigger Trigger)
        {
            this.Awal = Awal;
            this.Akhir = Akhir;
            this.Trigger = Trigger;
        }
    }

    Transisi[] transition =
    {
        new Transisi(status.Berdiri, status.Terbang, trigger.TombolW),
        new Transisi(status.Jongkok, status.Berdiri, trigger.TombolW),
        new Transisi(status.Tengkurap, status.Jongkok, trigger.TombolW),
        new Transisi(status.Jongkok, status.Tengkurap, trigger.TombolS),
        new Transisi(status.Berdiri, status.Jongkok, trigger.TombolS),
        new Transisi(status.Terbang, status.Berdiri, trigger.TombolS),
        new Transisi(status.Terbang, status.Jongkok, trigger.TombolX)
    };

    public status NextState(status Awal, trigger Trigger)
    {
        status stateAkhir = Awal;

        for (int i = 0; i < transition.Length; i++)
        {
            Transisi perubahan = transition[i];

            if (Awal == perubahan.Awal && Trigger == perubahan.Trigger)
            {
                stateAkhir = perubahan.Akhir;
            }
        }

        return stateAkhir;
    }
    public void Aktivasi(trigger Trigger)
        {
            status stateAwal = currentState;
            currentState = NextState(currentState, Trigger);

            if(Trigger == trigger.TombolS)
            {
                Console.WriteLine("Tombol arah Bawah ditekan");
            }

            if(Trigger == trigger.TombolW)
            {
                Console.WriteLine("Tombol arah Atas ditekan");
            }
        }
}


public class mainClass
{
    public static void Main(String[] args)
    {
        //Console.WriteLine(1302223083 % 3);
        // NIM % 3 = 0

        EnumBuah list = EnumBuah.Durian;
        String kodeBuah = getKodeBuah(list);
        Console.WriteLine("Buah {1}, kode Buahnya adalah {0}", kodeBuah, list);

        PosisiKarakterGame machine = new PosisiKarakterGame();
       
        
        machine.Aktivasi(trigger.TombolS);

        machine.Aktivasi(trigger.TombolW);

    }
}

