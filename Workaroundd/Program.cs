using Business.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Workaroundd
{
	class Program
	{
		static void Main(string[] args)
		{
			//Degiskenler();

			Vatandas vatandas = new Vatandas();

			SelamVer();
			SelamVer();
			SelamVer();

			SelamVerParametreli(isim: "Emir");
			SelamVerParametreli(isim: "Emre");
			SelamVerParametreli(isim: "Yusuf");
			SelamVerParametreli();

			int sonuc = Topla();

			Topla2(50);

			//Diziler / Arrays
			string ogrenci1 = "Emir";
			string ogrenci2 = "Emre";
			string ogrenci3 = "Yusuf";

			string[] ogrenciler = new string[3];

			ogrenciler[0] = "Emir";
			ogrenciler[1] = "Emre";
			ogrenciler[2] = "Yusuf";
			//ogrenciler[3] = "İlker";
			ogrenciler = new string[4];
			ogrenciler[3] = "İlker";

			for (int i = 0; i < ogrenciler.Length; i++)
			{
				Console.WriteLine(ogrenciler[i]);
			}

			string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
			string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

			sehirler2 = sehirler1;
			sehirler1[0] = "Adana";
			Console.WriteLine(sehirler2[0]);

			int sayi1 = 10;
			int sayi2 = 20;
			sayi2 = sayi1;
			sayi1 = 30;
			Console.WriteLine(sayi2);

			foreach (string sehir in sehirler1)
			{
				Console.WriteLine(sehir);
			}

			Person person1 = new Person();
			person1.FirstName = "MUHAMMED EMİR";
			person1.LastName = "GÖZCÜ";
			person1.DateOfBirthYear = 2001;
			person1.NationalIdentity = 123;

			List<string> yeniSehirler = new List<string> { "Ankara 1", "İstanbul 1", "İzmir 1" };
			yeniSehirler.Add("Antalya 1");

			foreach (string sehir in yeniSehirler)
			{
				Console.WriteLine(sehir);
			}

			PttManager pttManager = new PttManager(new PersonManager());
			pttManager.GiveMask(person1);
		}

		//metot
		static void SelamVer()
		{
			Console.WriteLine("Merhaba");
		}

		static void SelamVerParametreli(string isim = "İsimsiz")
		{
			Console.WriteLine("Merhaba " + isim);
		}

		static int Topla()
		{
			return 5;
		}
		static int Topla2(int sayi1 = 5, int sayi2 = 10)
		{
			int sonuc = sayi1 + sayi2;
			Console.WriteLine("Toplam: " + sonuc);
			return sonuc;
		}

		private static void Degiskenler()
		{
			string mesaj = "Merhaba";
			double tutar = 123.213;
			int sayi = 100;
			bool girisYapmisMi = false;

			string ad = "Emir";
			string soyad = "Gözcü";
			int dogumYili = 2001;
			long tcNo = 12345678910;

			Console.WriteLine(mesaj);
			Console.WriteLine(tutar);
			Console.WriteLine(sayi);
			Console.WriteLine(girisYapmisMi);
		}
	}
	public class Vatandas
	{
		//property
		public string Ad { get; set; }
		public string Soyad { get; set; }
		public int DogumYili { get; set; }
		public long TcNo { get; set; }
	}
}
