# 💻 C# Eğitim Kampı — Çalışma Defteri

> İlk `Console.WriteLine`'dan metotlara uzanan C# öğrenme yolculuğumun proje proje kaydı.

Bu solution, katıldığım C# eğitim kampı boyunca adım adım geliştirdiğim **8 projeyi** barındırır. Her proje tek bir konuya odaklanır; böylece hem konu tekrarı yaparken hem de ileride benzer bir yapıya ihtiyaç duyduğumda hızlıca referans alabiliyorum.

---

## 📌 İçindekiler

- [Kullanılan Teknolojiler](#-kullanılan-teknolojiler)
- [Solution Yapısı](#-solution-yapısı)
- [Projeler](#-projeler)
- [Projeyi Çalıştırma](#-projeyi-çalıştırma)
- [Öğrenme Notları](#-öğrenme-notları)
- [Yol Haritası](#-yol-haritası)

---

## 🧰 Kullanılan Teknolojiler

| Katman | Teknoloji | Nerede Kullanıldı |
|--------|-----------|-------------------|
| Dil / Platform | C# — .NET Framework 4.7.2 | Tüm projeler |
| Arayüz | Konsol uygulaması | Tüm projeler |
| Temel Konular | Değişkenler, karar yapıları, döngüler | 01–05 |
| Veri Yapıları | Diziler, `foreach` ile gezinme | 06–07 |
| Kod Organizasyonu | Metotlar, parametre, `return`, overload | 08 |
| IDE | Visual Studio | Tüm projeler |

---

## 🗂️ Solution Yapısı

```
CSharpEgitimkampi_Uygulama1/
├── 01_MainSubjects/
├── 02_Variables/
├── 03_MakingDecision/
├── 04_Loops/
├── 05_LoopWithStars/
├── 06_Arrays/
├── 07_ForEach/
├── 08_Methods/
├── CSharpEgitimKampi.slnx
└── README.md
```

---

## 🧩 Projeler

### 01 · MainSubjects — Temel Kavramlar
İlk çalıştırılabilir programı yazdım. `Console.WriteLine` ile ekrana çıktı verme, `Console.ReadLine` ile kullanıcıdan girdi alma ve bir C# programının `Main` metoduyla nasıl başladığını öğrendim.

**Kazanım:** Programın giriş noktası, derleme–çalıştırma döngüsü.

---

### 02 · Variables — Değişkenler ve Veri Türleri
`int`, `double`, `decimal`, `string`, `bool` gibi türleri tanıyıp aralarındaki farkları gördüm. Tür dönüşümlerini (`Convert`, `Parse`, `TryParse`) denedim ve hangi veriyi hangi türde tutmam gerektiğini kavradım.

**Kazanım:** Bellekte veri tutma, güvenli tür dönüşümü.

---

### 03 · MakingDecision — Karar Yapıları
`if`, `else if`, `else` ve `switch` yapılarıyla programın koşula göre farklı davranmasını sağladım. Karşılaştırma ve mantıksal operatörleri kullanarak not değerlendirme, çift/tek kontrolü gibi örnekler yazdım.

**Kazanım:** Koşullu akış kontrolü.

---

### 04 · Loops — Döngüler
`for`, `while` ve `do-while` döngülerini karşılaştırdım. Çarpım tablosu, faktöriyel hesaplama ve sayı toplama gibi tekrarlı işlemleri otomatikleştirdim. `break` ve `continue` ile döngü akışına müdahale etmeyi öğrendim.

**Kazanım:** Tekrarlı işleri otomatikleştirme, sonsuz döngüden kaçınma.

---

### 05 · LoopWithStars — İç İçe Döngülerle Şekil Çizimi
Yıldız karakteriyle üçgen, piramit ve kare gibi desenler çizdim. Bu proje iç içe döngülerin (nested loop) mantığını oturtmam açısından en öğretici olanıydı — dış döngü satırı, iç döngü sütunu yönetiyor.

**Kazanım:** İç içe döngü mantığı, satır/sütun ilişkisi.

---

### 06 · Arrays — Diziler
Dizi tanımlama, eleman atama ve indeksle erişim konularını çalıştım. Dizi üzerinde en büyük/en küçük elemanı bulma, toplam ve ortalama hesaplama gibi klasik problemleri çözdüm.

**Kazanım:** Toplu veriyi indeksle yönetme.

---

### 07 · ForEach — Foreach Döngüsü
`foreach` döngüsünü `for` ile karşılaştırarak ne zaman hangisini kullanmam gerektiğini öğrendim. Öğrenci notları üzerinden ortalama hesaplayıp geçme/kalma durumunu belirleyen bir sınav değerlendirme örneği yazdım.

**Kazanım:** Koleksiyonlar üzerinde okunabilir gezinme.

---

### 08 · Methods — Metotlar
Tekrarlanan kodu metotlara taşıdım. Parametre alan, geriye değer döndüren (`return`) ve `void` olan metotlar yazdım; aynı isimde farklı imzalarla çalışan metotları (overload) denedim.

**Kazanım:** Kod tekrarını azaltma, okunabilir ve tekrar kullanılabilir yapı kurma.

---

## ▶️ Projeyi Çalıştırma

```bash
git clone https://github.com/Semihk74/CSharpEgitimkampi_Uygulama1.git
```

1. `CSharpEgitimKampi.slnx` dosyasını Visual Studio ile açın.
2. Çalıştırmak istediğiniz projeye sağ tıklayıp **Set as Startup Project** deyin.
3. `F5` ile başlatın.

---

## 📝 Öğrenme Notları

- Hata mesajını okumadan kod değiştirmek en çok vakit kaybettiren alışkanlıkmış; artık önce `Exception` mesajını okuyorum.
- `TryParse`, `Parse`'a göre çok daha güvenli — kullanıcı girdisinde varsayılanım oldu.
- İç içe döngülerde kâğıda satır/sütun çizmek, kodu kafada çalıştırmaktan çok daha hızlı sonuç veriyor.
- Bir kod bloğunu ikinci kez kopyalıyorsam, muhtemelen o bir metot olmalı.

---

## 🗺️ Yol Haritası

- [ ] Nesne yönelimli programlama (class, encapsulation, inheritance)
- [ ] Koleksiyonlar (`List<T>`, `Dictionary<TKey, TValue>`) ve LINQ
- [ ] ADO.NET ile veritabanı bağlantılı uygulama
- [ ] Windows Forms ile arayüzlü CRUD uygulaması
- [ ] Entity Framework ile ORM'e geçiş
- [ ] Katmanlı mimari (Entity / DAL / BLL / UI)
- [ ] ASP.NET Core ile web tarafına geçiş

---

Bu depo, öğrendikçe büyümeye devam edecek. Sorularınız veya önerileriniz olursa **issue** açmaktan çekinmeyin. ⭐

**Semih** · [github.com/Semihk74](https://github.com/Semihk74)
