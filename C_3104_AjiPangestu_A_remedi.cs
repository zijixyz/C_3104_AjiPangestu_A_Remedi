//// Soal Nomer Satu
///
//using System;

//public class Sekolah
//{
//    // Atribut
//    public string idSekolah;
//    public string namaSekolah;
//    public int jumlahPaketDiterima;

//    // Constructor
//    public Sekolah(string idSekolah, string namaSekolah, int jumlahPaketDiterima)
//    {
//        this.idSekolah = idSekolah;
//        this.namaSekolah = namaSekolah;
//        this.jumlahPaketDiterima = jumlahPaketDiterima;
//    }

//    // Method untuk menampilkan informasi sekolah
//    public void TampilInfo()
//    {
//        Console.WriteLine("=== Informasi Sekolah Penerima MBG ===");
//        Console.WriteLine($"ID Sekolah         : {idSekolah}");
//        Console.WriteLine($"Nama Sekolah       : {namaSekolah}");
//        Console.WriteLine($"Jumlah Paket Diterima : {jumlahPaketDiterima}");
//        Console.WriteLine();
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        // Membuat objek Sekolah pertama
//        Sekolah sekolah1 = new Sekolah("SCH001", "SD Negeri 1 Jakarta", 150);

//        // Membuat objek Sekolah kedua
//        Sekolah sekolah2 = new Sekolah("SCH002", "SMP Negeri 5 Bandung", 200);

//        // Menampilkan informasi kedua sekolah
//        sekolah1.TampilInfo();
//        sekolah2.TampilInfo();
//    }
//}

//==================================================================================================

////Soal Nomer Dua

//using System;

//public class PaketMBG
//{
//    // Atribut private (encapsulation)
//    private string idPaket;
//    private string namaPaket;
//    private int stokDapur;

//    // Properties (getter & setter)
//    public string IdPaket
//    {
//        get { return idPaket; }
//        set { idPaket = value; }
//    }

//    public string NamaPaket
//    {
//        get { return namaPaket; }
//        set { namaPaket = value; }
//    }

//    // Stok hanya bisa dibaca dari luar (get),
//    // tidak bisa diubah langsung karena di private set
//    public int StokDapur
//    {
//        get { return stokDapur; }
//        private set
//        {
//            if (value < 0)
//            {
//                Console.WriteLine("Stok tidak boleh negatif!");
//                return;
//            }
//            stokDapur = value;
//        }
//    }

//    // Constructor
//    public PaketMBG(string idPaket, string namaPaket, int stokAwal)
//    {
//        this.idPaket = idPaket;
//        this.namaPaket = namaPaket;
//        this.stokDapur = stokAwal;
//    }

//    // Method khusus untuk mengurangi stok
//    public void KurangiStok(int jumlah)
//    {
//        if (jumlah <= 0)
//        {
//            Console.WriteLine("Jumlah pengurangan harus lebih dari 0!");
//            return;
//        }

//        if (jumlah > stokDapur)
//        {
//            Console.WriteLine($"Stok tidak cukup! Stok tersedia: {stokDapur}, diminta: {jumlah}");
//            return;
//        }

//        stokDapur -= jumlah;
//        Console.WriteLine($"Stok berhasil dikurangi {jumlah}. Sisa stok: {stokDapur}");
//    }

//    // Method tampil info
//    public void TampilInfo()
//    {
//        Console.WriteLine("=== Informasi Paket MBG ===");
//        Console.WriteLine($"ID Paket   : {idPaket}");
//        Console.WriteLine($"Nama Paket : {namaPaket}");
//        Console.WriteLine($"Stok Dapur : {stokDapur}");
//        Console.WriteLine();
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        // Membuat objek PaketMBG
//        PaketMBG paket1 = new PaketMBG("PKT001", "Nasi Ayam + Sayur", 100);
//        paket1.TampilInfo();

//        // Uji KurangiStok
//        paket1.KurangiStok(30);   // berhasil -> sisa 70
//        paket1.KurangiStok(-5);   // gagal    -> jumlah harus > 0
//        paket1.KurangiStok(500);  // gagal    -> melebihi stok
//        paket1.KurangiStok(70);   // berhasil -> sisa 0

//        paket1.TampilInfo();
//    }
//}

//======================================================================================================

////Soal Nomer Tiga

//using System;

//// ==================== CLASS INDUK ====================
//public class PaketMBG
//{
//    // Atribut private
//    private string idPaket;
//    private string namaPaket;
//    private int stokDapur;

//    // Properties
//    public string IdPaket
//    {
//        get { return idPaket; }
//        set { idPaket = value; }
//    }

//    public string NamaPaket
//    {
//        get { return namaPaket; }
//        set { namaPaket = value; }
//    }

//    public int StokDapur
//    {
//        get { return stokDapur; }
//        private set
//        {
//            if (value < 0)
//            {
//                Console.WriteLine("Stok tidak boleh negatif!");
//                return;
//            }
//            stokDapur = value;
//        }
//    }

//    // Constructor
//    public PaketMBG(string idPaket, string namaPaket, int stokAwal)
//    {
//        this.idPaket = idPaket;
//        this.namaPaket = namaPaket;
//        this.stokDapur = stokAwal;
//    }

//    // Method kurangi stok
//    public void KurangiStok(int jumlah)
//    {
//        if (jumlah <= 0)
//        {
//            Console.WriteLine("Jumlah pengurangan harus lebih dari 0!");
//            return;
//        }

//        if (jumlah > stokDapur)
//        {
//            Console.WriteLine($"Stok tidak cukup! Stok tersedia: {stokDapur}, diminta: {jumlah}");
//            return;
//        }

//        stokDapur -= jumlah;
//        Console.WriteLine($"Stok '{namaPaket}' berkurang {jumlah}. Sisa stok: {stokDapur}");
//    }

//    // Method tampil info
//    public virtual void TampilInfo()
//    {
//        Console.WriteLine("=== Informasi Paket MBG ===");
//        Console.WriteLine($"ID Paket   : {idPaket}");
//        Console.WriteLine($"Nama Paket : {namaPaket}");
//        Console.WriteLine($"Stok Dapur : {stokDapur}");
//        Console.WriteLine();
//    }
//}

//// ==================== CLASS TURUNAN 1 ====================
//public class PaketReguler : PaketMBG
//{
//    // Harga per paket (atribut khusus PaketReguler)
//    private int harga;

//    // Constructor
//    public PaketReguler(string idPaket, string namaPaket, int stokAwal)
//        : base(idPaket, namaPaket, stokAwal)
//    {
//        this.harga = 15000;
//    }

//    // Property harga dengan hanya melihat
//    public int Harga
//    {
//        get { return harga; }
//    }

//    // Isi paket reguler
//    public void TampilIsiPaket()
//    {
//        Console.WriteLine("Isi Paket : Nasi, Ayam, Sayur, Buah");
//    }

//    // Override method induk
//    public override void TampilInfo()
//    {
//        Console.WriteLine("=== Informasi Paket REGULER ===");
//        Console.WriteLine($"ID Paket   : {IdPaket}");
//        Console.WriteLine($"Nama Paket : {NamaPaket}");
//        Console.WriteLine($"Stok Dapur : {StokDapur}");
//        Console.WriteLine($"Harga      : Rp{harga:N0} / paket");
//        TampilIsiPaket();
//        Console.WriteLine();
//    }
//}

//// ==================== CLASS TURUNAN 2 ====================
//public class PaketKhusus : PaketMBG
//{
//    // Atribut tambahan
//    private string jenisDiet;
//    private int harga;

//    // Constructor
//    public PaketKhusus(string idPaket, string namaPaket, int stokAwal, string jenisDiet)
//        : base(idPaket, namaPaket, stokAwal)
//    {
//        this.jenisDiet = jenisDiet;
//        this.harga = 20000;
//    }

//    // Property jenisDiet
//    public string JenisDiet
//    {
//        get { return jenisDiet; }
//        set { jenisDiet = value; }
//    }

//    public int Harga
//    {
//        get { return harga; }
//    }

//    // Override method induk
//    public override void TampilInfo()
//    {
//        Console.WriteLine("=== Informasi Paket KHUSUS ===");
//        Console.WriteLine($"ID Paket   : {IdPaket}");
//        Console.WriteLine($"Nama Paket : {NamaPaket}");
//        Console.WriteLine($"Stok Dapur : {StokDapur}");
//        Console.WriteLine($"Harga      : Rp{harga:N0} / paket");
//        Console.WriteLine($"Jenis Diet : {jenisDiet}");
//        Console.WriteLine();
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        // Objek PaketReguler
//        PaketReguler reguler1 = new PaketReguler("REG001", "Nasi Ayam Sayur Buah", 100);
//        reguler1.TampilInfo();

//        // Objek PaketKhusus
//        PaketKhusus khusus1 = new PaketKhusus("KHS001", "Paket Vegetarian", 50, "Vegetarian");
//        khusus1.TampilInfo();

//        PaketKhusus khusus2 = new PaketKhusus("KHS002", "Paket Rendah Gula", 40, "Rendah Gula");
//        khusus2.TampilInfo();

//        // Bukti inheritance: method KurangiStok dari induk bisa dipakai
//        Console.WriteLine("--- Uji warisan method KurangiStok() ---");
//        reguler1.KurangiStok(20);
//        khusus1.KurangiStok(10);

//        Console.WriteLine();
//        reguler1.TampilInfo();
//        khusus1.TampilInfo();
//    }
//}

//======================================================================================================

////Soal Nomer Empat

//using System;

//// ==================== CLASS INDUK ====================
//public class PaketMBG
//{
//    // Atribut private
//    private string idPaket;
//    private string namaPaket;
//    private int stokDapur;

//    // Properties
//    public string IdPaket
//    {
//        get { return idPaket; }
//        set { idPaket = value; }
//    }

//    public string NamaPaket
//    {
//        get { return namaPaket; }
//        set { namaPaket = value; }
//    }

//    public int StokDapur
//    {
//        get { return stokDapur; }
//        private set
//        {
//            if (value < 0)
//            {
//                Console.WriteLine("Stok tidak boleh negatif!");
//                return;
//            }
//            stokDapur = value;
//        }
//    }

//    // Constructor
//    public PaketMBG(string idPaket, string namaPaket, int stokAwal)
//    {
//        this.idPaket = idPaket;
//        this.namaPaket = namaPaket;
//        this.stokDapur = stokAwal;
//    }

//    // Method kurangi stok
//    public void KurangiStok(int jumlah)
//    {
//        if (jumlah <= 0)
//        {
//            Console.WriteLine("Jumlah pengurangan harus lebih dari 0!");
//            return;
//        }

//        if (jumlah > stokDapur)
//        {
//            Console.WriteLine($"Stok tidak cukup! Stok tersedia: {stokDapur}, diminta: {jumlah}");
//            return;
//        }

//        stokDapur -= jumlah;
//        Console.WriteLine($"Stok '{namaPaket}' berkurang {jumlah}. Sisa stok: {stokDapur}");
//    }

//    // Method tampil info
//    public virtual void TampilInfo()
//    {
//        Console.WriteLine("=== Informasi Paket MBG ===");
//        Console.WriteLine($"ID Paket   : {idPaket}");
//        Console.WriteLine($"Nama Paket : {namaPaket}");
//        Console.WriteLine($"Stok Dapur : {stokDapur}");
//        Console.WriteLine();
//    }

//    // Method virtual polymorphism
//    public virtual int HitungBiaya(int jumlah)
//    {
//        // Default di class induk (tidak dipakai langsung, akan di-override)
//        return 0;
//    }
//}

//// ==================== CLASS TURUNAN 1 ====================
//public class PaketReguler : PaketMBG
//{
//    private int harga = 15000;

//    public PaketReguler(string idPaket, string namaPaket, int stokAwal)
//        : base(idPaket, namaPaket, stokAwal)
//    {
//    }

//    public int Harga
//    {
//        get { return harga; }
//    }

//    public void TampilIsiPaket()
//    {
//        Console.WriteLine("Isi Paket : Nasi, Ayam, Sayur, Buah");
//    }

//    public override void TampilInfo()
//    {
//        Console.WriteLine("=== Informasi Paket REGULER ===");
//        Console.WriteLine($"ID Paket   : {IdPaket}");
//        Console.WriteLine($"Nama Paket : {NamaPaket}");
//        Console.WriteLine($"Stok Dapur : {StokDapur}");
//        Console.WriteLine($"Harga      : Rp{harga:N0} / paket");
//        TampilIsiPaket();
//        Console.WriteLine();
//    }

//    // Overriding method HitungBiaya untuk PaketReguler
//    public override int HitungBiaya(int jumlah)
//    {
//        return jumlah * 15000;
//    }
//}

//// ==================== CLASS TURUNAN 2 ====================
//public class PaketKhusus : PaketMBG
//{
//    private string jenisDiet;
//    private int harga = 20000;

//    public PaketKhusus(string idPaket, string namaPaket, int stokAwal, string jenisDiet)
//        : base(idPaket, namaPaket, stokAwal)
//    {
//        this.jenisDiet = jenisDiet;
//    }

//    public string JenisDiet
//    {
//        get { return jenisDiet; }
//        set { jenisDiet = value; }
//    }

//    public int Harga
//    {
//        get { return harga; }
//    }

//    public override void TampilInfo()
//    {
//        Console.WriteLine("=== Informasi Paket KHUSUS ===");
//        Console.WriteLine($"ID Paket   : {IdPaket}");
//        Console.WriteLine($"Nama Paket : {NamaPaket}");
//        Console.WriteLine($"Stok Dapur : {StokDapur}");
//        Console.WriteLine($"Harga      : Rp{harga:N0} / paket");
//        Console.WriteLine($"Jenis Diet : {jenisDiet}");
//        Console.WriteLine();
//    }

//    // Overriding method HitungBiaya untuk PaketKhusus
//    public override int HitungBiaya(int jumlah)
//    {
//        return jumlah * 20000;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        // Polymorphism
//        PaketMBG[] daftarPaket = new PaketMBG[3];

//        daftarPaket[0] = new PaketReguler("REG001", "Nasi Ayam Sayur Buah", 100);
//        daftarPaket[1] = new PaketKhusus("KHS001", "Paket Vegetarian", 50, "Vegetarian");
//        daftarPaket[2] = new PaketKhusus("KHS002", "Paket Rendah Gula", 40, "Rendah Gula");

//        // Array jumlah paket yang mau dihitung biayanya
//        int[] jumlahPesan = { 50, 30, 20 };

//        Console.WriteLine("========== PERHITUNGAN BIAYA MBG ==========\n");

//        for (int i = 0; i < daftarPaket.Length; i++)
//        {
//            PaketMBG paket = daftarPaket[i];   // tipe induk
//            int jumlah = jumlahPesan[i];

//            int biaya = paket.HitungBiaya(jumlah);   // polymorphism!

//            Console.WriteLine($"Paket   : {paket.NamaPaket} (ID: {paket.IdPaket})");
//            Console.WriteLine($"Jumlah  : {jumlah} paket");
//            Console.WriteLine($"Biaya   : Rp{biaya:N0}");
//            Console.WriteLine("-------------------------------------------");
//        }

//        // ===== Tambahan: bukti polymorphism lewat method =====
//        Console.WriteLine("\n========== UJI POLYMORPHISM VIA METHOD ==========\n");
//        CetakBiaya(daftarPaket[0], 10);   // PaketReguler
//        CetakBiaya(daftarPaket[1], 10);   // PaketKhusus
//    }

//    static void CetakBiaya(PaketMBG paket, int jumlah)
//    {
//        int biaya = paket.HitungBiaya(jumlah);
//        Console.WriteLine($"{paket.NamaPaket} x {jumlah} = Rp{biaya:N0}");
//    }
//}

//=======================================================================================================

////Soal Nomer Lima

//using System;

//// Abstract class induk
//public abstract class PaketMBG
//{
//    // Atribut private
//    private string idPaket;
//    private string namaPaket;
//    private int stokDapur;

//    // Properties
//    public string IdPaket
//    {
//        get { return idPaket; }
//        set { idPaket = value; }
//    }

//    public string NamaPaket
//    {
//        get { return namaPaket; }
//        set { namaPaket = value; }
//    }

//    public int StokDapur
//    {
//        get { return stokDapur; }
//        private set
//        {
//            if (value < 0)
//            {
//                Console.WriteLine("Stok tidak boleh negatif!");
//                return;
//            }
//            stokDapur = value;
//        }
//    }

//    // Constructor
//    public PaketMBG(string idPaket, string namaPaket, int stokAwal)
//    {
//        this.idPaket = idPaket;
//        this.namaPaket = namaPaket;
//        this.stokDapur = stokAwal;
//    }

//    // Method kurangi stok
//    public void KurangiStok(int jumlah)
//    {
//        if (jumlah <= 0)
//        {
//            Console.WriteLine("Jumlah pengurangan harus lebih dari 0!");
//            return;
//        }

//        if (jumlah > stokDapur)
//        {
//            Console.WriteLine($"Stok tidak cukup! Stok tersedia: {stokDapur}, diminta: {jumlah}");
//            return;
//        }

//        stokDapur -= jumlah;
//        Console.WriteLine($"Stok '{namaPaket}' berkurang {jumlah}. Sisa stok: {stokDapur}");
//    }

//    // Method tampil info
//    public virtual void TampilInfo()
//    {
//        Console.WriteLine("=== Informasi Paket MBG ===");
//        Console.WriteLine($"ID Paket   : {idPaket}");
//        Console.WriteLine($"Nama Paket : {namaPaket}");
//        Console.WriteLine($"Stok Dapur : {stokDapur}");
//        Console.WriteLine();
//    }

//    // Abstract method
//    public abstract int HitungBiaya(int jumlah);
//}

//// ==================== CLASS TURUNAN 1 ====================
//public class PaketReguler : PaketMBG
//{
//    private int harga = 15000;

//    public PaketReguler(string idPaket, string namaPaket, int stokAwal)
//        : base(idPaket, namaPaket, stokAwal)
//    {
//    }

//    public int Harga
//    {
//        get { return harga; }
//    }

//    public void TampilIsiPaket()
//    {
//        Console.WriteLine("Isi Paket : Nasi, Ayam, Sayur, Buah");
//    }

//    public override void TampilInfo()
//    {
//        Console.WriteLine("=== Informasi Paket REGULER ===");
//        Console.WriteLine($"ID Paket   : {IdPaket}");
//        Console.WriteLine($"Nama Paket : {NamaPaket}");
//        Console.WriteLine($"Stok Dapur : {StokDapur}");
//        Console.WriteLine($"Harga      : Rp{harga:N0} / paket");
//        TampilIsiPaket();
//        Console.WriteLine();
//    }

//    // Implementasi dari abstract method
//    public override int HitungBiaya(int jumlah)
//    {
//        return jumlah * 15000;
//    }
//}

//// ==================== CLASS TURUNAN 2 ====================
//public class PaketKhusus : PaketMBG
//{
//    private string jenisDiet;
//    private int harga = 20000;

//    public PaketKhusus(string idPaket, string namaPaket, int stokAwal, string jenisDiet)
//        : base(idPaket, namaPaket, stokAwal)
//    {
//        this.jenisDiet = jenisDiet;
//    }

//    public string JenisDiet
//    {
//        get { return jenisDiet; }
//        set { jenisDiet = value; }
//    }

//    public int Harga
//    {
//        get { return harga; }
//    }

//    public override void TampilInfo()
//    {
//        Console.WriteLine("=== Informasi Paket KHUSUS ===");
//        Console.WriteLine($"ID Paket   : {IdPaket}");
//        Console.WriteLine($"Nama Paket : {NamaPaket}");
//        Console.WriteLine($"Stok Dapur : {StokDapur}");
//        Console.WriteLine($"Harga      : Rp{harga:N0} / paket");
//        Console.WriteLine($"Jenis Diet : {jenisDiet}");
//        Console.WriteLine();
//    }

//    //  Implementasi dari abstract method
//    public override int HitungBiaya(int jumlah)
//    {
//        return jumlah * 20000;
//    }
//}
//class Program
//{
//    static void Main()
//    {
//        PaketMBG[] daftarPaket = new PaketMBG[3];

//        daftarPaket[0] = new PaketReguler("REG001", "Nasi Ayam Sayur Buah", 100);
//        daftarPaket[1] = new PaketKhusus("KHS001", "Paket Vegetarian", 50, "Vegetarian");
//        daftarPaket[2] = new PaketKhusus("KHS002", "Paket Rendah Gula", 40, "Rendah Gula");

//        int[] jumlahPesan = { 50, 30, 20 };

//        Console.WriteLine("========== PERHITUNGAN BIAYA MBG ==========\n");

//        for (int i = 0; i < daftarPaket.Length; i++)
//        {
//            PaketMBG paket = daftarPaket[i];
//            int jumlah = jumlahPesan[i];

//            // Memanggil abstract method yang sudah diimplementasikan
//            int biaya = paket.HitungBiaya(jumlah);

//            Console.WriteLine($"Paket   : {paket.NamaPaket} (ID: {paket.IdPaket})");
//            Console.WriteLine($"Jumlah  : {jumlah} paket");
//            Console.WriteLine($"Biaya   : Rp{biaya:N0}");
//            Console.WriteLine("-------------------------------------------");
//        }
//    }
//}

//========================================================================================================

//// Soal Nomer Enam

//using System;

//// Interface
//public interface DapatDidistribusikan
//{
//    // Method wajib diimplementasikan oleh class yang memakai interface ini
//    void KirimPaket();
//}

//// Abstract class induk
//public abstract class PaketMBG
//{
//    private string idPaket;
//    private string namaPaket;
//    private int stokDapur;

//    public string IdPaket
//    {
//        get { return idPaket; }
//        set { idPaket = value; }
//    }

//    public string NamaPaket
//    {
//        get { return namaPaket; }
//        set { namaPaket = value; }
//    }

//    public int StokDapur
//    {
//        get { return stokDapur; }
//        private set
//        {
//            if (value < 0)
//            {
//                Console.WriteLine("Stok tidak boleh negatif!");
//                return;
//            }
//            stokDapur = value;
//        }
//    }

//    public PaketMBG(string idPaket, string namaPaket, int stokAwal)
//    {
//        this.idPaket = idPaket;
//        this.namaPaket = namaPaket;
//        this.stokDapur = stokAwal;
//    }

//    public void KurangiStok(int jumlah)
//    {
//        if (jumlah <= 0)
//        {
//            Console.WriteLine("Jumlah pengurangan harus lebih dari 0!");
//            return;
//        }

//        if (jumlah > stokDapur)
//        {
//            Console.WriteLine($"Stok tidak cukup! Stok tersedia: {stokDapur}, diminta: {jumlah}");
//            return;
//        }

//        stokDapur -= jumlah;
//        Console.WriteLine($"Stok '{namaPaket}' berkurang {jumlah}. Sisa stok: {stokDapur}");
//    }

//    public virtual void TampilInfo()
//    {
//        Console.WriteLine("=== Informasi Paket MBG ===");
//        Console.WriteLine($"ID Paket   : {idPaket}");
//        Console.WriteLine($"Nama Paket : {namaPaket}");
//        Console.WriteLine($"Stok Dapur : {stokDapur}");
//        Console.WriteLine();
//    }

//    public abstract int HitungBiaya(int jumlah);
//}

//// ==================== CLASS TURUNAN 1 ====================
//public class PaketReguler : PaketMBG
//{
//    private int harga = 15000;

//    public PaketReguler(string idPaket, string namaPaket, int stokAwal)
//        : base(idPaket, namaPaket, stokAwal)
//    {
//    }

//    public int Harga
//    {
//        get { return harga; }
//    }

//    public void TampilIsiPaket()
//    {
//        Console.WriteLine("Isi Paket : Nasi, Ayam, Sayur, Buah");
//    }

//    public override void TampilInfo()
//    {
//        Console.WriteLine("=== Informasi Paket REGULER ===");
//        Console.WriteLine($"ID Paket   : {IdPaket}");
//        Console.WriteLine($"Nama Paket : {NamaPaket}");
//        Console.WriteLine($"Stok Dapur : {StokDapur}");
//        Console.WriteLine($"Harga      : Rp{harga:N0} / paket");
//        TampilIsiPaket();
//        Console.WriteLine();
//    }

//    public override int HitungBiaya(int jumlah)
//    {
//        return jumlah * 15000;
//    }
//}

//// ==================== CLASS TURUNAN 2 ====================
//public class PaketKhusus : PaketMBG
//{
//    private string jenisDiet;
//    private int harga = 20000;

//    public PaketKhusus(string idPaket, string namaPaket, int stokAwal, string jenisDiet)
//        : base(idPaket, namaPaket, stokAwal)
//    {
//        this.jenisDiet = jenisDiet;
//    }

//    public string JenisDiet
//    {
//        get { return jenisDiet; }
//        set { jenisDiet = value; }
//    }

//    public int Harga
//    {
//        get { return harga; }
//    }

//    public override void TampilInfo()
//    {
//        Console.WriteLine("=== Informasi Paket KHUSUS ===");
//        Console.WriteLine($"ID Paket   : {IdPaket}");
//        Console.WriteLine($"Nama Paket : {NamaPaket}");
//        Console.WriteLine($"Stok Dapur : {StokDapur}");
//        Console.WriteLine($"Harga      : Rp{harga:N0} / paket");
//        Console.WriteLine($"Jenis Diet : {jenisDiet}");
//        Console.WriteLine();
//    }

//    public override int HitungBiaya(int jumlah)
//    {
//        return jumlah * 20000;
//    }
//}

//// Class Sekolah
//public class Sekolah
//{
//    public string idSekolah;
//    public string namaSekolah;
//    public int jumlahPaketDiterima;

//    public Sekolah(string idSekolah, string namaSekolah, int jumlahPaketDiterima)
//    {
//        this.idSekolah = idSekolah;
//        this.namaSekolah = namaSekolah;
//        this.jumlahPaketDiterima = jumlahPaketDiterima;
//    }

//    public void TampilInfo()
//    {
//        Console.WriteLine("=== Informasi Sekolah Penerima MBG ===");
//        Console.WriteLine($"ID Sekolah            : {idSekolah}");
//        Console.WriteLine($"Nama Sekolah          : {namaSekolah}");
//        Console.WriteLine($"Jumlah Paket Diterima : {jumlahPaketDiterima}");
//        Console.WriteLine();
//    }
//}

//// Class Distribusi MBG yang mengimplementasikan interface DapatDidistribusikan
//public class DistribusiMBG : DapatDidistribusikan
//{
//    // Atribut
//    private Sekolah sekolahTujuan;
//    private PaketMBG paket;
//    private int jumlah;

//    // Constructor
//    public DistribusiMBG(Sekolah sekolahTujuan, PaketMBG paket, int jumlah)
//    {
//        this.sekolahTujuan = sekolahTujuan;
//        this.paket = paket;
//        this.jumlah = jumlah;
//    }

//    // Implementasi method dari interface
//    public void KirimPaket()
//    {
//        Console.WriteLine($">>> Proses distribusi: {paket.NamaPaket} -> {sekolahTujuan.namaSekolah}");
//        Console.WriteLine($"    Jumlah diminta: {jumlah} paket | Stok tersedia: {paket.StokDapur}");

//        // Aturan 1: jumlah harus > 0
//        if (jumlah <= 0)
//        {
//            Console.WriteLine($"[GAGAL] Jumlah paket harus lebih dari 0! (diminta: {jumlah})");
//            Console.WriteLine("        Stok dapur dan jumlah diterima sekolah TIDAK berubah.");
//            Console.WriteLine();
//            return;
//        }

//        // Aturan 2: jumlah tidak boleh melebihi stok
//        if (jumlah > paket.StokDapur)
//        {
//            Console.WriteLine($"[GAGAL] Stok tidak mencukupi! Stok tersedia: {paket.StokDapur}, diminta: {jumlah}");
//            Console.WriteLine("        Stok dapur dan jumlah diterima sekolah TIDAK berubah.");
//            Console.WriteLine();
//            return;
//        }

//        // Aturan 3: pengiriman berhasil
//        paket.KurangiStok(jumlah);                  // stok dapur berkurang
//        sekolahTujuan.jumlahPaketDiterima += jumlah; // paket diterima sekolah bertambah

//        Console.WriteLine($"[SUKSES] Distribusi MBG berhasil! Sebanyak {jumlah} paket makanan " +
//                          $"telah dikirim ke sekolah {sekolahTujuan.namaSekolah}.");
//        Console.WriteLine($"         Sisa stok dapur: {paket.StokDapur} | Total diterima sekolah: {sekolahTujuan.jumlahPaketDiterima}");
//        Console.WriteLine();
//    }
//}
//class Program
//{
//    static void Main()
//    {
//        // Data sekolah
//        Sekolah sekolah1 = new Sekolah("SCH001", "SD Negeri 1 Jakarta", 0);
//        Sekolah sekolah2 = new Sekolah("SCH002", "SMP Negeri 5 Bandung", 0);

//        // Data paket
//        PaketReguler reguler = new PaketReguler("REG001", "Nasi Ayam Sayur Buah", 100);
//        PaketKhusus khusus = new PaketKhusus("KHS001", "Paket Vegetarian", 30, "Vegetarian");

//        Console.WriteLine("========== SIMULASI DISTRIBUSI MBG ==========\n");

//        // ---- Skenario 1: berhasil ----
//        DistribusiMBG d1 = new DistribusiMBG(sekolah1, reguler, 40);
//        d1.KirimPaket();

//        // ---- Skenario 2: gagal karena jumlah <= 0 ----
//        DistribusiMBG d2 = new DistribusiMBG(sekolah2, reguler, 0);
//        d2.KirimPaket();

//        // ---- Skenario 3: gagal karena melebihi stok ----
//        DistribusiMBG d3 = new DistribusiMBG(sekolah2, khusus, 999);
//        d3.KirimPaket();

//        // ---- Skenario 4: berhasil ke sekolah lain ----
//        DistribusiMBG d4 = new DistribusiMBG(sekolah2, khusus, 20);
//        d4.KirimPaket();

//        // ---- Tampilkan kondisi akhir ----
//        Console.WriteLine("========== KONDISI AKHIR ==========\n");
//        sekolah1.TampilInfo();
//        sekolah2.TampilInfo();
//        reguler.TampilInfo();
//        khusus.TampilInfo();
//    }
//}

// ========================================================================================================

//// Soal Nomer Tujuh

//using System;
//using System.Collections.Generic;

//// Interface
//public interface DapatDidistribusikan
//{
//    void KirimPaket();
//}

//// Abstract class induk
//public abstract class PaketMBG
//{
//    private string idPaket;
//    private string namaPaket;
//    private int stokDapur;

//    public string IdPaket
//    {
//        get { return idPaket; }
//        set { idPaket = value; }
//    }

//    public string NamaPaket
//    {
//        get { return namaPaket; }
//        set { namaPaket = value; }
//    }

//    public int StokDapur
//    {
//        get { return stokDapur; }
//        private set
//        {
//            if (value < 0)
//            {
//                Console.WriteLine("Stok tidak boleh negatif!");
//                return;
//            }
//            stokDapur = value;
//        }
//    }

//    public PaketMBG(string idPaket, string namaPaket, int stokAwal)
//    {
//        this.idPaket = idPaket;
//        this.namaPaket = namaPaket;
//        this.stokDapur = stokAwal;
//    }

//    public void KurangiStok(int jumlah)
//    {
//        if (jumlah <= 0)
//        {
//            Console.WriteLine("Jumlah pengurangan harus lebih dari 0!");
//            return;
//        }

//        if (jumlah > stokDapur)
//        {
//            Console.WriteLine($"Stok tidak cukup! Stok tersedia: {stokDapur}, diminta: {jumlah}");
//            return;
//        }

//        stokDapur -= jumlah;
//        Console.WriteLine($"Stok '{namaPaket}' berkurang {jumlah}. Sisa stok: {stokDapur}");
//    }

//    public virtual void TampilInfo()
//    {
//        Console.WriteLine("=== Informasi Paket MBG ===");
//        Console.WriteLine($"ID Paket   : {idPaket}");
//        Console.WriteLine($"Nama Paket : {namaPaket}");
//        Console.WriteLine($"Stok Dapur : {stokDapur}");
//        Console.WriteLine();
//    }

//    public abstract int HitungBiaya(int jumlah);
//}

//// ==================== CLASS TURUNAN 1 ====================
//public class PaketReguler : PaketMBG
//{
//    private int harga = 15000;

//    public PaketReguler(string idPaket, string namaPaket, int stokAwal)
//        : base(idPaket, namaPaket, stokAwal)
//    {
//    }

//    public int Harga
//    {
//        get { return harga; }
//    }

//    public override void TampilInfo()
//    {
//        Console.WriteLine("=== Informasi Paket REGULER ===");
//        Console.WriteLine($"ID Paket   : {IdPaket}");
//        Console.WriteLine($"Nama Paket : {NamaPaket}");
//        Console.WriteLine($"Stok Dapur : {StokDapur}");
//        Console.WriteLine($"Harga      : Rp{harga:N0} / paket");
//        Console.WriteLine("Isi Paket  : Nasi, Ayam, Sayur, Buah");
//        Console.WriteLine();
//    }

//    public override int HitungBiaya(int jumlah)
//    {
//        return jumlah * 15000;
//    }
//}

//// ==================== CLASS TURUNAN 2 ====================
//public class PaketKhusus : PaketMBG
//{
//    private string jenisDiet;
//    private int harga = 20000;

//    public PaketKhusus(string idPaket, string namaPaket, int stokAwal, string jenisDiet)
//        : base(idPaket, namaPaket, stokAwal)
//    {
//        this.jenisDiet = jenisDiet;
//    }

//    public string JenisDiet
//    {
//        get { return jenisDiet; }
//        set { jenisDiet = value; }
//    }

//    public int Harga
//    {
//        get { return harga; }
//    }

//    public override void TampilInfo()
//    {
//        Console.WriteLine("=== Informasi Paket KHUSUS ===");
//        Console.WriteLine($"ID Paket   : {IdPaket}");
//        Console.WriteLine($"Nama Paket : {NamaPaket}");
//        Console.WriteLine($"Stok Dapur : {StokDapur}");
//        Console.WriteLine($"Harga      : Rp{harga:N0} / paket");
//        Console.WriteLine($"Jenis Diet : {jenisDiet}");
//        Console.WriteLine();
//    }

//    public override int HitungBiaya(int jumlah)
//    {
//        return jumlah * 20000;
//    }
//}

//// Class Sekolah
//public class Sekolah
//{
//    public string idSekolah;
//    public string namaSekolah;
//    public int jumlahPaketDiterima;

//    public Sekolah(string idSekolah, string namaSekolah, int jumlahPaketDiterima)
//    {
//        this.idSekolah = idSekolah;
//        this.namaSekolah = namaSekolah;
//        this.jumlahPaketDiterima = jumlahPaketDiterima;
//    }

//    public void TampilInfo()
//    {
//        Console.WriteLine("=== Informasi Sekolah Penerima MBG ===");
//        Console.WriteLine($"ID Sekolah            : {idSekolah}");
//        Console.WriteLine($"Nama Sekolah          : {namaSekolah}");
//        Console.WriteLine($"Jumlah Paket Diterima : {jumlahPaketDiterima}");
//        Console.WriteLine();
//    }
//}

//// Class Distribusi MBG
//public class DistribusiMBG : DapatDidistribusikan
//{
//    private Sekolah sekolahTujuan;
//    private PaketMBG paket;
//    private int jumlah;

//    public DistribusiMBG(Sekolah sekolahTujuan, PaketMBG paket, int jumlah)
//    {
//        this.sekolahTujuan = sekolahTujuan;
//        this.paket = paket;
//        this.jumlah = jumlah;
//    }

//    public void KirimPaket()
//    {
//        if (jumlah <= 0)
//        {
//            Console.WriteLine($"[GAGAL] Jumlah paket harus lebih dari 0! (diminta: {jumlah})");
//            return;
//        }

//        if (jumlah > paket.StokDapur)
//        {
//            Console.WriteLine($"[GAGAL] Stok tidak mencukupi! Stok tersedia: {paket.StokDapur}, diminta: {jumlah}");
//            return;
//        }

//        paket.KurangiStok(jumlah);
//        sekolahTujuan.jumlahPaketDiterima += jumlah;

//        Console.WriteLine($"[SUKSES] Distribusi MBG berhasil! Sebanyak {jumlah} paket makanan " +
//                          $"telah dikirim ke sekolah {sekolahTujuan.namaSekolah}.");
//        Console.WriteLine();
//    }
//}

//// Class PengelolaMBG
//public class PengelolaMBG
//{
//    /*
//     * HUBUNGAN ANTAR CLASS
//     *
//     * PengelolaMBG memiliki List<Sekolah> dan List<PaketMBG>.
//     *
//     * Relasi antara PengelolaMBG dan Sekolah termasuk aggregation karena
//     * Objek Sekolah dan PaketMBG dibuat DI LUAR PengelolaMBG
//     * (di Main), lalu hanya "dimasukkan" ke dalam List milik
//     * PengelolaMBG lewat method TambahSekolah() / TambahPaket().
//     */

//    // List untuk menyimpan kumpulan objek Sekolah dan PaketMBG
//    private List<Sekolah> daftarSekolah;
//    private List<PaketMBG> daftarPaket;

//    // Constructor
//    public PengelolaMBG()
//    {
//        daftarSekolah = new List<Sekolah>();
//        daftarPaket = new List<PaketMBG>();
//    }

//    // Method untuk mendaftarkan sekolah penerima
//    public void TambahSekolah(Sekolah sekolah)
//    {
//        daftarSekolah.Add(sekolah);
//        Console.WriteLine($"Sekolah '{sekolah.namaSekolah}' berhasil didaftarkan.");
//    }

//    // Method untuk menambahkan paket ke persediaan dapur
//    public void TambahPaket(PaketMBG paket)
//    {
//        daftarPaket.Add(paket);
//        Console.WriteLine($"Paket '{paket.NamaPaket}' berhasil ditambahkan ke persediaan dapur.");
//    }

//    // Method untuk menampilkan seluruh data MBG
//    public void TampilkanDataMBG()
//    {
//        Console.WriteLine("\n==================================================");
//        Console.WriteLine("           DATA SEKOLAH PENERIMA MBG");
//        Console.WriteLine("==================================================");

//        if (daftarSekolah.Count == 0)
//        {
//            Console.WriteLine("(Belum ada sekolah terdaftar)");
//        }
//        else
//        {
//            for (int i = 0; i < daftarSekolah.Count; i++)
//            {
//                Console.WriteLine($"{i + 1}. [{daftarSekolah[i].idSekolah}] {daftarSekolah[i].namaSekolah}");
//                Console.WriteLine($"   Jumlah paket diterima: {daftarSekolah[i].jumlahPaketDiterima}");
//            }
//        }

//        Console.WriteLine("\n==================================================");
//        Console.WriteLine("           DAFTAR PAKET & STOK DAPUR");
//        Console.WriteLine("==================================================");

//        if (daftarPaket.Count == 0)
//        {
//            Console.WriteLine("(Belum ada paket terdaftar)");
//        }
//        else
//        {
//            for (int i = 0; i < daftarPaket.Count; i++)
//            {
//                PaketMBG p = daftarPaket[i];
//                Console.WriteLine($"{i + 1}. [{p.IdPaket}] {p.NamaPaket}");
//                Console.WriteLine($"   Stok tersedia : {p.StokDapur} paket");

//                // Polymorphism: HitungBiaya() mengikuti jenis paket
//                Console.WriteLine($"   Biaya per 10 paket : Rp{p.HitungBiaya(10):N0}");

//                // Cek tipe untuk info tambahan
//                if (p is PaketKhusus pk)
//                {
//                    Console.WriteLine($"   Jenis Diet    : {pk.JenisDiet}");
//                }
//                else if (p is PaketReguler)
//                {
//                    Console.WriteLine($"   Isi Paket     : Nasi, Ayam, Sayur, Buah");
//                }
//            }
//        }
//        Console.WriteLine();
//    }
//}
//class Program
//{
//    static void Main()
//    {
//        // 1. Buat objek PengelolaMBG
//        PengelolaMBG pengelola = new PengelolaMBG();

//        // 2. Buat objek Sekolah
//        Sekolah s1 = new Sekolah("SCH001", "SD Negeri 1 Jakarta", 0);
//        Sekolah s2 = new Sekolah("SCH002", "SMP Negeri 5 Bandung", 0);
//        Sekolah s3 = new Sekolah("SCH003", "SMA Negeri 3 Surabaya", 0);

//        // 3. Buat objek PaketMBG
//        PaketReguler p1 = new PaketReguler("REG001", "Nasi Ayam Sayur Buah", 100);
//        PaketKhusus p2 = new PaketKhusus("KHS001", "Paket Vegetarian", 30, "Vegetarian");
//        PaketKhusus p3 = new PaketKhusus("KHS002", "Paket Rendah Gula", 40, "Rendah Gula");

//        // 4. Daftarkan ke pengelola
//        Console.WriteLine("=== PENDAFTARAN ===\n");
//        pengelola.TambahSekolah(s1);
//        pengelola.TambahSekolah(s2);
//        pengelola.TambahSekolah(s3);

//        pengelola.TambahPaket(p1);
//        pengelola.TambahPaket(p2);
//        pengelola.TambahPaket(p3);

//        // 5. Tampilkan seluruh data
//        pengelola.TampilkanDataMBG();

//        // 6. Simulasi distribusi
//        Console.WriteLine("=== SIMULASI DISTRIBUSI ===\n");
//        DistribusiMBG d1 = new DistribusiMBG(s1, p1, 40);
//        d1.KirimPaket();

//        DistribusiMBG d2 = new DistribusiMBG(s2, p2, 15);
//        d2.KirimPaket();

//        DistribusiMBG d3 = new DistribusiMBG(s3, p1, 70);
//        d3.KirimPaket();

//        // 7. Tampilkan data setelah distribusi
//        Console.WriteLine("=== DATA SETELAH DISTRIBUSI ===");
//        pengelola.TampilkanDataMBG();

//        Console.WriteLine("=== BUKTI AGGREGATION ===");
//        pengelola = null;
//        Console.WriteLine("PengelolaMBG di-set null. Objek di dalamnya masih bisa diakses:");
//        s1.TampilInfo();
//        p1.TampilInfo();
//    }
//}