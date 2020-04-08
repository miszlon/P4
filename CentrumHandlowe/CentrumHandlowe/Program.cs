using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentrumHandlowe
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new CentrumHandloweEntities())
            {
                context.Database.Log = Console.WriteLine;

                #region ----ZADANIE 1---- WYSWIETLANIE_POMIESZCZEŃ_I_STAND
                //var Stand = context.Obiekty.OfType<Stand>().ToArray();
                //var Pomieszczenia = context.Obiekty.OfType<Pomieszczenie>().ToArray();
                //Console.WriteLine("Obiekty typu Stand:");
                //foreach (var item in Stand)
                //{
                //    Console.WriteLine(item.Nazwa);
                //}

                //Console.WriteLine();
                //Console.WriteLine("Obiekty typu Pomieszczenia:");
                //foreach (var item in Pomieszczenia)
                //{
                //    Console.WriteLine(item.Nazwa);
                //}
                #endregion

                #region ----ZADANIE 2---- DODAĆ MIN. PO JEDNYM OBIEKCIE KAŻDEGO TYPU
                #region INICJACJA_NOWYCH_OBIEKTÓW_KAŻDEGO_TYPU
                var CCC = new Pomieszczenie
                {
                    IdObiektu = 22,
                    Nazwa = "CCC",
                    NazwaTechniczna = "Obuwnicy",
                    PowCalkowita = 200,
                    TypDzialalnosci = "Odzież",
                    PowWynajmu = 200,
                    CenaWynajmu = 20000,
                    RozpWynajmu = DateTime.Today,
                    ZakWynajmu = new DateTime(2019, 01, 01)
                };
                var Poziom3 = new Poziom
                {
                    IdObiektu = 23,
                    Nazwa = "Poziom3",
                    NazwaTechniczna = "Level3",
                    PowCalkowita = 20000
                };
                var Korytarz2 = new Korytarz
                {
                    IdObiektu = 24,
                    PowCalkowita = 10000
                };
                var ObiektDoWynajecia = new ObiektDoWynajecia
                {
                    IdObiektu = 25,
                    TypDzialalnosci = "Gastronomia",
                    CenaWynajmu = 15000,
                    RozpWynajmu = new DateTime(2020, 06, 01),
                    ZakWynajmu = new DateTime(2025, 12, 31),
                };
                var PomieszczenieTechniczne = new PomieszczenieTechniczne
                {
                    IdObiektu = 26,
                    Nazwa = "Składzik na chemię czyszczącą",
                    NazwaTechniczna = "Składzik - poziom 1",
                    PowCalkowita = 20
                };
                var StandPoziom1 = new Stand
                {
                    IdObiektu = 27,
                    Nazwa = "Marihuana lecznicza",
                    NazwaTechniczna = "Dilerka",
                    PowCalkowita = 20,
                    CenaWynajmu = 2000,
                    TypDzialalnosci = "Artykuły spożywcze"
                };
                var Parking = new Parking
                {
                    IdObiektu = 28,
                    Nazwa = "Parking 2",
                    NazwaTechniczna = "Parking podziemny poziom -2",
                    LiczbaMiejscPark = 550
                };
                #endregion

                #region DODANIE_NOWYCH_OBIEKTÓW_DO_BAZY
                //context.Obiekty.Add(Parking);
                //context.Obiekty.Add(StandPoziom1);
                //context.Obiekty.Add(PomieszczenieTechniczne);
                //context.Obiekty.Add(ObiektDoWynajecia);
                //context.Obiekty.Add(Korytarz2);
                //context.Obiekty.Add(Poziom3);
                //context.Obiekty.Add(CCC);
                #endregion
                #endregion

                #region ----Zadanie 3 ---- ZMODYFIKOWAĆ OBIEKT WPROWADZONY W MSSMS
                var UpdateDb = context.Obiekty.SqlQuery("UPDATE dbo.Obiekty SET Nazwa = 'CinemaCity' WHERE Nazwa = 'MultiKino'");
                #endregion

                #region ----ZADANIE 4---- USUWANIE_OBIEKTÓW_Z_BAZY_DODANYCH
                //context.Obiekty.Remove(context.Obiekty.First(x => x.IdObiektu == 22));
                //context.Obiekty.Remove(context.Obiekty.First(x => x.IdObiektu == 23));
                //context.Obiekty.Remove(context.Obiekty.First(x => x.IdObiektu == 24));
                //context.Obiekty.Remove(context.Obiekty.First(x => x.IdObiektu == 25));
                //context.Obiekty.Remove(context.Obiekty.First(x => x.IdObiektu == 26));
                //context.Obiekty.Remove(context.Obiekty.First(x => x.IdObiektu == 27));
                //context.Obiekty.Remove(context.Obiekty.First(x => x.IdObiektu == 28));
                #endregion

                context.SaveChanges();
                Console.ReadLine();

            }
        }
    }
}
