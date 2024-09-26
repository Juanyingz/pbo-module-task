public class Hewan
{
    public string Nama;
    public int Umur;

    public Hewan(string nama, int umur)
    {
        Nama = nama;
        Umur = umur;
    }
    public virtual string Suara()
    {
        return "Hewan ini bersuara";
    }
    public virtual string InfoHewan()
    {
        return $"Nama: {Nama}, Umur: {Umur} tahun";
    }
}


public class Mamalia : Hewan
{
    public int JumlahKaki;

    public Mamalia(string nama, int umur, int jumlahKaki) : base(nama, umur)
    {
        JumlahKaki = jumlahKaki;
    }
    public override string InfoHewan()
    {
        return base.InfoHewan() + $", Jumlah Kaki: {JumlahKaki}";
    }
}

public class Reptil : Hewan
{
    public double PanjangTubuh;

    public Reptil(string nama, int umur, double panjangTubuh) : base(nama, umur)
    {
        PanjangTubuh = panjangTubuh;
    }
    public override string InfoHewan()
    {
        return base.InfoHewan() + $", Panjang Tubuh: {PanjangTubuh}";
    }
}

public class Singa : Mamalia
{
    public Singa(string nama, int umur, int jumlahKaki) : base(nama, umur, jumlahKaki) { }

    public override string Suara()
    {
        return "Singa Mengaum";
    }
    public void Mengaum()
    {
        Console.WriteLine("Singa ini mengaum : RRRAAAWWWWRRRRRRRRRR");
    }
}

public class Gajah : Mamalia
{
    public Gajah(string nama, int umur, int jumlahKaki) : base(nama, umur, jumlahKaki) { }

    public override string Suara()
    {
        return "Gajah mengeluarkan suara seperti suara terompet: PRROOOTTTTT";
    }
}

public class Ular : Reptil
{
    public Ular(string nama, int umur, double panjangTubuh) : base(nama, umur, panjangTubuh) { }

    public override string Suara()
    {
        return "Suara Ular mendesis: SSSSSSEEEEESSSSSSS";
    }

    public void Merayap()
    {
        Console.WriteLine("Ular bergerak dengan cara merayap");
    }
}

public class Buaya : Reptil
{
    public Buaya(string nama, int umur, double panjangTubuh) : base(nama, umur, panjangTubuh) { }

    public override string Suara()
    {
        return "Buaya menggeram";
    }
}


public class KebunBinatang
{
    private List<Hewan> koleksiHewan = new List<Hewan>();

    public void TambahHewan(Hewan hewan)
    {
        koleksiHewan.Add(hewan);
    }

    public void DaftarHewan()
    {
        foreach (var hewan in koleksiHewan)
        {
            Console.WriteLine(hewan.InfoHewan());
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        KebunBinatang kebun = new KebunBinatang();

        Singa singa = new Singa("SANBI", 20, 4);
        Gajah gajah = new Gajah("SOYOU", 17, 4);
        Ular ular = new Ular("AODA", 31, 5.9);
        Buaya buaya = new Buaya("Kanto", 23, 4.7);


        kebun.TambahHewan(singa);
        kebun.TambahHewan(gajah);
        kebun.TambahHewan(ular);
        kebun.TambahHewan(buaya);
        kebun.DaftarHewan();


        Console.WriteLine(singa.Suara());
        Console.WriteLine(gajah.Suara());
        Console.WriteLine(ular.Suara());
        Console.WriteLine(buaya.Suara());

        
        Console.WriteLine(gajah.Suara());
        Console.WriteLine(ular.Suara());
        
        singa.Mengaum();
        Console.WriteLine(singa.InfoHewan());
        
        ular.Merayap();
        
        Reptil reptil = buaya;
        Console.WriteLine(reptil.Suara());
    }
}