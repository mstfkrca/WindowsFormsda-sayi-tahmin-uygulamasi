# 🔢 C# Windows Forms Sayı Tahmin Oyunu

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white) ![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)

Bu proje, C# Windows Forms kullanılarak geliştirilmiş, 3 basamaklı bir sayı tahmin oyunudur. Popüler "Mastermind" ve "Wordle" oyunlarının klasik mantığını temel alır.

Amacınız, bilgisayarın 100 ile 999 arasında tuttuğu 3 basamaklı sayıyı, 10 tahmin hakkı içinde bulmaktır.

## 🎮 Oynanış Görüntüleri

Oyun, yaptığınız her tahmine göre size renkli ipuçları verir:

| Oyun Sırasında (İpuçları) | Kazanma Anı (Tebrikler!) |
| :---: | :---: |
| ![Oyun Sırasında](<img width="548" height="362" alt="Ekran görüntüsü 2025-10-31 160023" src="https://github.com/user-attachments/assets/7c978602-d544-4559-bfa7-b1a796bdbaa1" />
) 
![Kazanma Ekranı](<img width="724" height="474" alt="Ekran görüntüsü 2025-10-31 160524" src="https://github.com/user-attachments/assets/eaa9d348-573d-4fd0-a156-a9c267fbb71f" />
) |

## ✨ Özellikler

* **Rastgele Sayı Üretimi:** Oyun her başladığında 100 ile 999 arasında rastgele bir sayı belirler.
* **Tahmin Hakkı:** Oyuncunun doğru sayıyı bulmak için 10 hakkı vardır.
* **Gelişmiş İpucu Sistemi (Renkler):**
    * 🟩 **Yeşil:** Tahmin ettiğiniz rakam, hedef sayıda var VE doğru basamakta.
    * 🟧 **Turuncu:** Tahmin ettiğiniz rakam, hedef sayıda var ANCAK yanlış basamakta.
    * ⬜ **Beyaz (Varsayılan):** Tahmin ettiğiniz rakam, hedef sayıda hiç yok.
* **Akıllı Mantık:** İpucu sistemi, "115" gibi tekrarlı rakam içeren tahminleri, "123" gibi bir hedefe karşı (Yeşil, Beyaz, Beyaz şeklinde) doğru şekilde işler.
* **Tahmin Geçmişi:** Yapılan tüm tahminler bir liste kutusunda gösterilir.
* **Giriş Doğrulama:** Kullanıcının sadece 3 haneli ve rakamlardan oluşan bir giriş yapması sağlanır.
* **Otomatik Fokus:** Her tahminden sonra imleç, kolaylık olması için otomatik olarak tahmin kutusuna geri döner.

## 📜 Nasıl Oynanır?

1.  Programı çalıştırın.
2.  "Sayı Tahmin Ediniz" kutusuna 3 haneli bir sayı girin.
3.  "tahmin et" butonuna tıklayın.
4.  Soldaki "Yüzler bas.", "Onlar bas.", "Birler bas." etiketlerinin renklerini kontrol edin:
    * **Yeşil** olduysa, o basamaktaki rakamı doğru bildiniz.
    * **Turuncu** olduysa, o basamağa yazdığınız rakam hedef sayıda var, ama yeri burası değil.
    * **Beyaz** kaldıysa, o basamağa yazdığınız rakam hedef sayıda hiç yok.
5.  Tahmin geçmişinizi ve kalan hakkınızı kontrol ederek yeni bir tahminde bulunun.
6.  Sayıyı 10 denemede bulun ve kazanın!

## 🛠️ Kullanılan Teknolojiler

* **Dil:** C#
* **Platform:** .NET Windows Forms
* **IDE:** Visual Studio

## 🚀 Kurulum


1.  Bu depoyu klonlayın (veya ZIP olarak indirin).
2.  Proje dosyasını (`.sln`) Visual Studio ile açın.
3.  "Start" (Başlat) butonuna (veya F5'e) basarak projeyi derleyin ve çalıştırın.
