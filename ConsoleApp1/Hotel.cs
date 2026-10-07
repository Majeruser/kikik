using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1

{
    // Készíts egy Hotel nevű recordot!

    // A record az alábbi adatokat tárolja:
    // - Name : string – public, immutable
    // - City : string – public, immutable
    // - Category : string – public, immutable
    // - Owner : string – private, immutable
    // - PricePerNight : int – public, mutable
    // - Rating : double – public , mutable
    // - AvailableRooms : int – private, mutable
    // - TotalRooms : int – private, immutable
    internal record Hotel(string Name, string city, string Cathegory, string owner, int TotalRooms)
    {
        public int PicePerNigth { get; set; }
        public double Rating { get; set; }
        private int AvailabelRooms { get; set; }
        private int Totalrooms { get; set; }
        // Készíts egy public függvényt, amely visszaadja a szálloda egy éjszakára
        // vonatkozó árát!
        public int GetPrice()
        {
            return AvailabelRooms;
        }

        // Készíts egy public függvényt, amely visszaadja a szálloda értékelését!


        // Készíts egy public függvényt, amely visszaadja a szabad szobák számát!


        // Készíts egy public függvényt, amely visszaadja a szálloda tulajdonosát!


        // Készíts egy public függvényt, amely paraméterként kap egy százalékos kedvezményt,
        // és ennek megfelelően csökkenti a PricePerNight értékét!


        // Készíts egy public függvényt, amely paraméterként kap egy százalékos áremelést,
        // és ennek megfelelően növeli a PricePerNight értékét!


        // Készíts egy public függvényt, amely paraméterként kap egy értékelést,
        // és erre az értékre módosítja a Rating értékét!


        // Készíts egy public függvényt, amely eldönti, hogy a szálloda kiemelkedő értékelésű-e!
        // Egy szálloda akkor kiemelkedő, ha a Rating legalább 9.0.


        // Készíts egy public függvényt, amely eldönti, hogy van-e legalább 10 szabad szoba a szállodában!


        // Készíts egy public függvényt, amely visszaadja, hogy hány foglalt szoba van a szállodában!


        // Készíts egy public függvényt, amely kiszámítja, hogy a szálloda szobáinak hány százaléka foglalt!
        // Az eredményt kerekítsd 2 tizedesjegyre!


        // Készíts egy public függvényt, amely paraméterként kap egy lefoglalandó szobaszámot!
        // Ha van legalább ennyi szabad szoba, csökkentse az AvailableRooms értékét a megadott számmal!


        // Készíts egy public függvényt, amely paraméterként kap egy felszabadítandó szobaszámot, és ennek megfelelően növeli az AvailableRooms értékét!
        // Az AvailableRooms értéke nem lehet nagyobb a TotalRooms értékén!

        // Készíts egy public függvényt, amely paraméterként kap egy éjszakaszámot,
        // és visszaadja, hogy egy szoba ennyi éjszakára összesen mennyibe kerül!

        // Készíts egy public függvényt, amely paraméterként kap egy éjszakaszámot és egy szobaszámot,
        // és visszaadja a teljes foglalás árát!

        // Készíts egy public függvényt, amely paraméterként kap egy maximális éjszakánkénti árat,
        // és eldönti, hogy a szálloda olcsóbb-e a megadott összegnél!

        // Készíts egy public függvényt, amely paraméterként kap egy minimum értékelést,
        // és eldönti, hogy a szálloda eléri-e a megadott értékelést!

        // Készíts egy public függvényt, amely visszaadja a szálloda adatait egyetlen stringként!
        // A visszaadott szöveg tartalmazza a szálloda nevét, városát, kategóriáját,
        // éjszakánkénti árát és értékelését!





    }


}

