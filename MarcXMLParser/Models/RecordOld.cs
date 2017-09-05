using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MarcXMLParser.Models
{
    //Klasa koja sadrži propertye za sva polja koja mogu biti u MARC21 zapisu
    //Polja su rađena prema uputama NSK za pregledne zapise, te su neka dodatno ubačena koja nedostaju u uputama
    //Iznad svakog polja se nalazi njegov kratak opis
    //Sva polja koja imaju podpolja su napravljena kao klasa koja sadrži propertye za ta podpolja
    //Opis tih polja se nalazi iznad klase
    //Ukoliko je neki indikator polja prazan, ne radi se njegov property
    //Ukoliko ima, property za njega se radi unutar klase za to polje
    public class RecordOld
    {
        //Uvodno polje
        public string Leader { get; set; }

#region Kontrolna polja 00X - property
        //Kontrolni broj
        public string ControlField001 { get; set; }
        //Identifikator kontrolnog broja
        public string ControlField003 { get; set; }
        //Datum i vrijeme posljednje izmjene
        public string ControlField005 { get; set; }
        //Elementi podataka nepromjenjive duljine
        public string ControlField008 { get; set; }
        #endregion

#region Brojevi i kodovi 01X-09X - property
        public Datafield034 Datafield034 { get; set; }
        //IEnumerable jer ih može biti više
        public IEnumerable<Datafield035> Datafield035 { get; set; }
        public Datafield040 Datafield040 { get; set; }
        public Datafield043 Datafield043 { get; set; }
        public Datafield065 Datafield065 { get; set; }
        public Datafield072 Datafield072 { get; set; }
        public Datafield080 Datafield080 { get; set; }
        #endregion

#region Odrednice - općenito - property
        public Datafield100 Datafield100 { get; set; }
        public Datafield110 Datafield110 { get; set; }
        public Datafield111 Datafield111 { get; set; }
        public Datafield130 Datafield130 { get; set; }
        public Datafield150 Datafield150 { get; set; }
        public Datafield151 Datafield151 { get; set; }
        public Datafield155 Datafield155 { get; set; }
        public Datafield180 Datafield180 { get; set; }
        public Datafield181 Datafield181 { get; set; }
        public Datafield182 Datafield182 { get; set; }
        public Datafield185 Datafield185 { get; set; }
        #endregion

        public Datafield245 Datafield245 { get; set; }
        public Datafield260 Datafield260 { get; set; }
        public Datafield300 Datafield300 { get; set; }
        public IEnumerable<Datafield360> Datafield360 { get; set; }
        public Datafield440 Datafield440 { get; set; }


#region Opće uputnice - 4XX - property
        public Datafield400 Datafield400 { get; set; }
        public Datafield410 Datafield410 { get; set; }
        public Datafield411 Datafield411 { get; set; }
        public Datafield430 Datafield430 { get; set; }
        public Datafield450 Datafield450 { get; set; }
        public Datafield451 Datafield451 { get; set; }
        public Datafield455 Datafield455 { get; set; }
        public Datafield480 Datafield480 { get; set; }
        public Datafield481 Datafield481 { get; set; }
        public Datafield482 Datafield482 { get; set; }
        public Datafield485 Datafield485 { get; set; }
#endregion

#region Unakrsne uputnice - 5XX - property
        public IEnumerable<Datafield500> Datafield500 { get; set; }
        public Datafield510 Datafield510 { get; set; }
        public Datafield511 Datafield511 { get; set; }
        public Datafield530 Datafield530 { get; set; }
        public Datafield550 Datafield550 { get; set; }
        public Datafield551 Datafield551 { get; set; }
        public Datafield555 Datafield555 { get; set; }
        public Datafield580 Datafield580 { get; set; }
        public Datafield581 Datafield581 { get; set; }
        public Datafield582 Datafield582 { get; set; }
        public Datafield585 Datafield585 { get; set; }
        #endregion

#region Napomene - 6XX - property
        public IEnumerable<Datafield653> Datafield653 { get; set; }
        public IEnumerable<Datafield665> Datafield665 { get; set; }
        public IEnumerable<Datafield666> Datafield666 { get; set; }
        public IEnumerable<Datafield667> Datafield667 { get; set; }
        public IEnumerable<Datafield670> Datafield670 { get; set; }
        public IEnumerable<Datafield675> Datafield675 { get; set; }
        public IEnumerable<Datafield678> Datafield678 { get; set; }
        public IEnumerable<Datafield680> Datafield680 { get; set; }
        public IEnumerable<Datafield681> Datafield681 { get; set; }
        public IEnumerable<Datafield682> Datafield682 { get; set; }
        public IEnumerable<Datafield688> Datafield688 { get; set; }
#endregion

        public Datafield750 Datafield750 { get; set; }
        public Datafield751 Datafield751 { get; set; }
        public Datafield856 Datafield856 { get; set; }
        public Datafield952 Datafield952 { get; set; }
        public Datafield998 Datafield998 { get; set; }
    }


#region Brojevi i kodovi 01X-09X - klase
    //Kodirani kartografski matematički podatci
    public class Datafield034
    {
        //Vrsta prstena
        public string ind2 { get; set; }
        //Koordinate najzapadnija dužina
        public string SubfieldD { get; set; }
        //Koordinate najistočnija dužina
        public string SubfieldE { get; set; }
        //Koordinate najsjevernija širina
        public string SubfieldF { get; set; }
        //Koordinate najjužnija širina
        public string SubfieldG { get; set; }
        //Izvor
        public string Subfield2 { get; set; }
    }
    //Sistemski kontrolni broj
    public class Datafield035
    {
        //Sistemski kontrolni broj (strojno generiran)
        public string SubfieldA { get; set; }
        //Sistemski kontrolni broj (ostali - upisani konverzijom)
        public string Subfield9 { get; set; }
    }
    //Izvor katalogizacije
    public class Datafield040
    {
        //Izvorno bibliografsko središte
        public string SubfieldA { get; set; }
        //Jezik katalogizacije
        public string SubfieldB { get; set; }
        //Ustanova koja preuzima zapis
        public string SubfieldC { get; set; }
        //Ustanova koja mijenja zapis
        public string SubfieldD { get; set; }
        //Pravila deskriptivne katalogizacije
        public string SubfieldE { get; set; }
        //Pravila izrade predmetnih odrednica/tezaurusa
        public string SubfieldF { get; set; }
    }
    //Kod geografskog područja
    public class Datafield043
    {
        //Kod geografskog područja
        public string SubfieldA { get; set; }
    }
    //Drugi klasifikacijski brojevi
    public class Datafield065
    {
        //Element klasifikacijskog broja - pojedinačni broj ili početni broj niza
        public string SubfieldA { get; set; }
        //Tekstualno objašnjenje
        public string SubfieldC { get; set; }
        //Izvor broja
        public string Subfield2 { get; set; }
    }
    //Kod predmetne kategorije
    public class Datafield072
    {
        //Drugi indikator je 7
        public string Ind2 { get { return 7.ToString(); } }
        //Kod predmetne kategorije
        public string SubfieldA { get; set; }
        //Kod predmetne podkategorije
        public string SubfieldX { get; set; }
        //Izvor koda
        public string Subfield2 { get; set; }
        //Drugi (lokalni) izvor podataka
        public string Subfield9 { get; set; }
    }
    //Broj univerzalne decimalne klasifikacije
    public class Datafield080
    {
        //Broj univerzalne decimalne klasifikacije
        public string SubfieldA { get; set; }
        //Izdanje
        public string Subfield2 { get; set; }
    }

    #endregion


#region Odrednice - općenito - 1XX- klase
    //Odrednica - osobno ime
    public class Datafield100
    {
        //Prvi indikator određuje oblik osobnog imena
        // 0 - ime, 1 - prezime, 3- obiteljsko ime
        public string Ind1 { get; set; }
        //Osobno ime
        public string SubfieldA { get; set; }
        //Numeracija - rimski brojevi
        public string SubfieldB { get; set; }
        //Titule i ostali doatci imenu, osim datuma
        public string SubfieldC { get; set; }
        //Datumi pridruženi imenu
        public string SubfieldD { get; set; }
        //Naslov djela
        public string SubfieldT { get; set; }
        //Dodatna odrednica za žanr/oblik
        public string SubfieldV { get; set; }
        //Dodatna odrednica za opći pojam
        public string SubfieldX { get; set; }
        //Dodatna odrednica za vrijeme
        public string SubfieldY { get; set; }
        //Dodatna odrednica za geografsko ime
        public string SubfieldZ { get; set; }
    }
    //Odrednica - naziv korporativnog tijela
    public class Datafield110
    {
        //Prvi indikator određuje oblik naziva korporativnog tijela
        //0 - Premetnuti naziv
        //1 - Naziv pod jurisdikcijom/sjedištem
        //2 - naziv u izravnom redoslijedu
        public string Ind1 { get; set; }
        //Naziv korporativnog tijela ili jurisdikcije/sjedišta
        public string SubfieldA { get; set; }
        //Podređena jedinica
        public string SubfieldB { get; set; }
        //Naslov djela
        public string SubfieldT { get; set; }
        //Dodatna odrednica za žanr/oblik
        public string SubfieldV { get; set; }
        //Dodatna odrednica za opći pojam
        public string SubfieldX { get; set; }
        //Dodatna odrednica za vrijeme
        public string SubfieldY { get; set; }
        //Dodatna odrednica za geografsko ime
        public string SubfieldZ { get; set; }
    }
    //Odrednica - naziv sastanka
    public class Datafield111
    {
        //Prvi indikator određuje oblik naziva sastanka
        //0 - Premetnuti naziv
        //1 - Naziv pod jurisdikcijom/sjedištem
        //2 - naziv u izravnom redoslijedu
        public string Ind1 { get; set; }
        //Naziv sastanka ili jurisdikcije/sjedišta
        public string SubfieldA { get; set; }
        //Mjesto sastanka
        public string SubfieldC { get; set; }
        //Datum sastanka
        public string SubfieldD { get; set; }
        //Broj dijela/sastanka
        public string SubfieldN { get; set; }
        //Naslov djela
        public string SubfieldT { get; set; }
        //Dodatna odrednica za žanr/oblik
        public string SubfieldV { get; set; }
        //Dodatna odrednica za opći pojam
        public string SubfieldX { get; set; }
        //Dodatna odrednica za vrijeme
        public string SubfieldY { get; set; }
        //Dodatna odrednica za geografsko ime
        public string SubfieldZ { get; set; }
    }
    //Odrednica - jedinstveni naslov
    public class Datafield130
    {
        //Drugi indikator sadrži broj početnih znakova koji se isključuju iz abecednog redanja 0-9
        public string Ind2 { get; set; }
        //Jedinstveni naslov
        public string SubfieldA { get; set; }
        //Datum potpisivanja sporazuma
        public string SubfieldD { get; set; }
        //Datum djela
        public string SubfieldF { get; set; }
        //Raznovrsni podatci
        public string SubfieldG { get; set; }
        //Medij
        public string SubfieldH { get; set; }
        //Pododrednica za oblik
        public string SubfieldK { get; set; }
        //Jezik djela
        public string SubfieldL { get; set; }
        //Medij izvedbe glazbe
        public string SubfieldM { get; set; }
        //Broj dijela djela
        public string SubfieldN { get; set; }
        //Podatak o glazbenom aranžmanu
        public string SubfieldO { get; set; }
        //Naziv dijela djela
        public string SubfieldP { get; set; }
        //Tonalitet za glazbu
        public string SubfieldR { get; set; }
        //Verzija
        public string SubfieldS { get; set; }
        //Dodatna odrednica za žanr/oblik
        public string SubfieldV { get; set; }
        //Dodatna odrednica za opći pojam
        public string SubfieldX { get; set; }
        //Dodatna odrednica za vrijeme
        public string SubfieldY { get; set; }
        //Dodatna odrednica za geografsko ime
        public string SubfieldZ { get; set; }
    }
    //Odrednica - opći pojam
    public class Datafield150
    {
        //Opći pojam
        public string SubfieldA { get; set; }
        //Dodatna odrednica za žanr/oblik
        public string SubfieldV { get; set; }
        //Dodatna odrednica za opći pojam
        public string SubfieldX { get; set; }
        //Dodatna odrednica za vrijeme
        public string SubfieldY { get; set; }
        //Dodatna odrednica za geografsko ime
        public string SubfieldZ { get; set; }
    }
    //Odrednica - geografsko ime
    public class Datafield151
    {
        //Geografsko ime
        public string SubfieldA { get; set; }
        //Dodatna odrednica za žanr/oblik
        public string SubfieldV { get; set; }
        //Dodatna odrednica za opći pojam
        public string SubfieldX { get; set; }
        //Dodatna odrednica za vrijeme
        public string SubfieldY { get; set; }
        //Dodatna odrednica za geografsko ime
        public string SubfieldZ { get; set; }
    }
    //Odrednica - žanr/oblik
    public class Datafield155
    {
        //Žanr/oblik
        public string SubfieldA { get; set; }
        //Dodatna odrednica za žanr/oblik
        public string SubfieldV { get; set; }
        //Dodatna odrednica za opći pojam
        public string SubfieldX { get; set; }
        //Dodatna odrednica za vrijeme
        public string SubfieldY { get; set; }
        //Dodatna odrednica za geografsko ime
        public string SubfieldZ { get; set; }
    }
    //Odrednica - dodatna oznaka za opći pojam
    public class Datafield180
    {
        //Dodatna odrednica za žanr/oblik
        public string SubfieldV { get; set; }
        //Dodatna odrednica za opći pojam
        public string SubfieldX { get; set; }
        //Dodatna odrednica za vrijeme
        public string SubfieldY { get; set; }
        //Dodatna odrednica za geografsko ime
        public string SubfieldZ { get; set; }
    }
    //Odrednica - dodatna geografska oznaka
    public class Datafield181
    {
        //Dodatna odrednica za žanr/oblik
        public string SubfieldV { get; set; }
        //Dodatna odrednica za opći pojam
        public string SubfieldX { get; set; }
        //Dodatna odrednica za vrijeme
        public string SubfieldY { get; set; }
        //Dodatna odrednica za geografsko ime
        public string SubfieldZ { get; set; }
    }
    //Odrednica - dodatna vremenska oznaka
    public class Datafield182
    {
        //Dodatna odrednica za žanr/oblik
        public string SubfieldV { get; set; }
        //Dodatna odrednica za opći pojam
        public string SubfieldX { get; set; }
        //Dodatna odrednica za vrijeme
        public string SubfieldY { get; set; }
        //Dodatna odrednica za geografsko ime
        public string SubfieldZ { get; set; }
    }
    //Odrednica - dodatna ozaka za žanr/oblik
    public class Datafield185
    {
        //Dodatna odrednica za žanr/oblik
        public string SubfieldV { get; set; }
        //Dodatna odrednica za opći pojam
        public string SubfieldX { get; set; }
        //Dodatna odrednica za vrijeme
        public string SubfieldY { get; set; }
        //Dodatna odrednica za geografsko ime
        public string SubfieldZ { get; set; }
    }
    #endregion


    //Polje izjave o naslovu
    public class Datafield245
    {
        //Naslov
        public string SubfieldA { get; set; }
        //Ostatak naslova
        public string SubfieldB { get; set; }
        //Izjava o odgovornosti
        public string SubfieldC { get; set; }
        //Uključivi datumi
        public string SubfieldF { get; set; }
        //Skupni datumi
        public string SubfieldG { get; set; }
        //Medij
        public string SubfieldH { get; set; }
        //Oblik
        public string SubfieldK { get; set; }
        //Broj dijelova djela
        public string SubfieldN { get; set; }
        //Naziv dijela djela
        public string SubfieldP { get; set; }
        //Verzija
        public string SubfieldS { get; set; }

    }
    //Polje o izdavanju i distribuciji
    public class Datafield260
    {
        //Mjesto izdavanja, distribucije
        public string SubfieldA { get; set; }
        //Naziv izdavača, distributera
        public string SubfieldB { get; set; }
        //Datum izdavanja, distribucije
        public string SubfieldC { get; set; }
        //Mjesto proizvodnje
        public string SubfieldE { get; set; }
        //Proizvođač
        public string SubfieldF { get; set; }
        //Datum proizvodnje
        public string SubfieldG { get; set; }
        //Navedeni materijali
        public string Subfield3 { get; set; }
    }
    //Polje fizičkog opisa
    public class Datafield300
    {
        //Opseg
        public string SubfieldA { get; set; }
        //Drugi fizički detalji
        public string SubfieldB { get; set; }
        //Dimezije
        public string SubfieldC { get; set; }
        //Popratni materijal
        public string SubfieldE { get; set; }
        //Tip jedinici
        public string SubfieldF { get; set; }
        //Veličina jedinice
        public string SubfieldG { get; set; }
        //Navedeni materijali
        public string Subfield3 { get; set; }
    }
    //Polje složenih uputnica - predmetne odrednice
    public class Datafield360
    {
        //Tekst objašnjenja
        public string SubfieldI { get; set; }
        //Odradnica na koju se poziva
        public string SubfieldA { get; set; }
    }
    //Polje izjava serije/dodane naslovnice
    public class Datafield440
    {
        //Naslov
        public string SubfieldA { get; set; }
    }

#region Opće uputnice - 4XX - klase
    //Opća uputnica - osobno ime
    public class Datafield400
    {
        //Prvi indikator određuje oblik osobnog imena
        // 0-Ime, 1-Prezime, 3-Obiteljsko ime
        public string Ind1 { get; set; }
        //Osobno ime
        public string SubfieldA { get; set; }
        //Numeracija - rimski brojevi
        public string SubfieldB { get; set; }
        //Titule i ostali doatci imenu, osim datuma
        public string SubfieldC { get; set; }
        //Naslov djela
        public string SubfieldT { get; set; }
        //Datumi pridruženi imenu
        public string SubfieldD { get; set; }
        //Podatak o odnosu
        public string SubfieldI { get; set; }
        //Kontrola podpolja
        // /0 - Poseban odnos
        // /1 - Ograničenje upotrebe uputnice
        // /2 - Raniji oblik odrednice
        // /3 - Prikaz uputnice
        public string SubfieldW { get; set; }
        //Dodatna odrednica za žanr/oblik
        public string SubfieldV { get; set; }
        //Dodatna odrednica za opći pojam
        public string SubfieldX { get; set; }
        //Dodatna odrednica za vrijeme
        public string SubfieldY { get; set; }
        //Dodatna odrednica za geografsko ime
        public string SubfieldZ { get; set; }
    }
    //Opća uputnica - naziv korporativnog tijela
    public class Datafield410
    {
        //Prvi indikator određuje oblik naziva korporativnog tijela
        //3 Premetnuti naziv
        //4 Naziv pod jurisdikcijom/ sjedištem
        //5 Naziv u izravnom redoslijedu
        public string Ind1 { get; set; }
        //Naziv korporativnog tijela ili jurisdikcije/sjedišta
        public string SubfieldA { get; set; }
        //Podređena jedinica
        public string SubfieldB { get; set; }
        //Naslov djela
        public string SubfieldT { get; set; }
        //Podatak o odnosu
        public string SubfieldI { get; set; }
        //Kontrola podpolja
        // /0 - Poseban odnos
        // /1 - Ograničenje upotrebe uputnice
        // /2 - Raniji oblik odrednice
        // /3 - Prikaz uputnice
        public string SubfieldW { get; set; }
        //Dodatna odrednica za žanr/oblik
        public string SubfieldV { get; set; }
        //Dodatna odrednica za opći pojam
        public string SubfieldX { get; set; }
        //Dodatna odrednica za vrijeme
        public string SubfieldY { get; set; }
        //Dodatna odrednica za geografsko ime
        public string SubfieldZ { get; set; }
    }
    //Opća uputnica - naziv sastanka
    public class Datafield411
    {
        //Prvi indikator određuje oblik naziva sastanka
        //0 Premetnuti naziv
        //1 Naziv pod sjedištem/jurisdikcijom
        //2 Naziv u izravnom redoslijedu
        public string Ind1 { get; set; }
        //Naziv sastanka ili jurisdikcije/sjedišta
        public string SubfieldA { get; set; }
        //Mjesto sastanka
        public string SubfieldC { get; set; }
        //Datum sastanka
        public string SubfieldD { get; set; }
        //Broj dijela/sastanka
        public string SubfieldN { get; set; }
        //Naslov djela
        public string SubfieldT { get; set; }
        //Podatak o odnosu
        public string SubfieldI { get; set; }
        //Kontrola podpolja
        // /0 - Poseban odnos
        // /1 - Ograničenje upotrebe uputnice
        // /2 - Raniji oblik odrednice
        // /3 - Prikaz uputnice
        public string SubfieldW { get; set; }
        //Dodatna odrednica za žanr/oblik
        public string SubfieldV { get; set; }
        //Dodatna odrednica za opći pojam
        public string SubfieldX { get; set; }
        //Dodatna odrednica za vrijeme
        public string SubfieldY { get; set; }
        //Dodatna odrednica za geografsko ime
        public string SubfieldZ { get; set; }
    }
    //Opća uputnica - jedinstveni naslov
    public class Datafield430
    {
        //Drugi indikator sadrži broj početnih znakova koji se isključuju iz abecednog redanja 0-9
        public string Ind2 { get; set; }
        //Jedinstveni naslov
        public string SubfieldA { get; set; }
        //Datum potpisivanja sporazuma
        public string SubfieldD { get; set; }
        //Datum djela
        public string SubfieldF { get; set; }
        //Raznovrsni podatci
        public string SubfieldG { get; set; }
        //Medij
        public string SubfieldH { get; set; }
        //Pododrednica za oblik
        public string SubfieldK { get; set; }
        //Jezik djela
        public string SubfieldL { get; set; }
        //Medij izvedbe glazbe
        public string SubfieldM { get; set; }
        //Broj dijela djela
        public string SubfieldN { get; set; }
        //Podatak o glazbenom aranžmanu
        public string SubfieldO { get; set; }
        //Naziv dijela djela
        public string SubfieldP { get; set; }
        //Tonalitet za glazbu
        public string SubfieldR { get; set; }
        //Verzija
        public string SubfieldS { get; set; }
        //Podatak o odnosu
        public string SubfieldI { get; set; }
        //Kontrola podpolja
        // /0 - Poseban odnos
        // /1 - Ograničenje upotrebe uputnice
        // /2 - Raniji oblik odrednice
        // /3 - Prikaz uputnice
        public string SubfieldW { get; set; }
        //Dodatna odrednica za žanr/oblik
        public string SubfieldV { get; set; }
        //Dodatna odrednica za opći pojam
        public string SubfieldX { get; set; }
        //Dodatna odrednica za vrijeme
        public string SubfieldY { get; set; }
        //Dodatna odrednica za geografsko ime
        public string SubfieldZ { get; set; }
    }
    //Opća uputnica - opći pojam
    public class Datafield450
    {
        //Opći pojam
        public string SubfieldA { get; set; }
        //Podatak o odnosu
        public string SubfieldI { get; set; }
        //Kontrola podpolja
        // /0 - Poseban odnos
        // /1 - Ograničenje upotrebe uputnice
        // /2 - Raniji oblik odrednice
        // /3 - Prikaz uputnice
        public string SubfieldW { get; set; }
        //Dodatna odrednica za žanr/oblik
        public string SubfieldV { get; set; }
        //Dodatna odrednica za opći pojam
        public string SubfieldX { get; set; }
        //Dodatna odrednica za vrijeme
        public string SubfieldY { get; set; }
        //Dodatna odrednica za geografsko ime
        public string SubfieldZ { get; set; }
    }
    //Opća uputnica - geografsko ime
    public class Datafield451
    {
        //Geografsko ime
        public string SubfieldA { get; set; }
        //Podatak o odnosu
        public string SubfieldI { get; set; }
        //Kontrola podpolja
        // /0 - Poseban odnos
        // /1 - Ograničenje upotrebe uputnice
        // /2 - Raniji oblik odrednice
        // /3 - Prikaz uputnice
        public string SubfieldW { get; set; }
        //Dodatna odrednica za žanr/oblik
        public string SubfieldV { get; set; }
        //Dodatna odrednica za opći pojam
        public string SubfieldX { get; set; }
        //Dodatna odrednica za vrijeme
        public string SubfieldY { get; set; }
        //Dodatna odrednica za geografsko ime
        public string SubfieldZ { get; set; }
    }
    //Opća uputnica - žanr/oblik
    public class Datafield455
    {
        //Žanr/oblik
        public string SubfieldA { get; set; }
        //Podatak o odnosu
        public string SubfieldI { get; set; }
        //Kontrola podpolja
        // /0 - Poseban odnos
        // /1 - Ograničenje upotrebe uputnice
        // /2 - Raniji oblik odrednice
        // /3 - Prikaz uputnice
        public string SubfieldW { get; set; }
        //Dodatna odrednica za žanr/oblik
        public string SubfieldV { get; set; }
        //Dodatna odrednica za opći pojam
        public string SubfieldX { get; set; }
        //Dodatna odrednica za vrijeme
        public string SubfieldY { get; set; }
        //Dodatna odrednica za geografsko ime
        public string SubfieldZ { get; set; }
    }
    //Opća uputnica - dodatna oznaka za opći pojam
    public class Datafield480
    {
        //Dodatna oznaka za opći pojam
        public string SubfieldX { get; set; }
        //Podatak o odnosu
        public string SubfieldI { get; set; }
        //Kontrola podpolja
        // /0 - Poseban odnos
        // /1 - Ograničenje upotrebe uputnice
        // /2 - Raniji oblik odrednice
        // /3 - Prikaz uputnice
        public string SubfieldW { get; set; }
        //Dodatna odrednica za žanr/oblik
        public string SubfieldV { get; set; }
        //Dodatna odrednica za vrijeme
        public string SubfieldY { get; set; }
        //Dodatna odrednica za geografsko ime
        public string SubfieldZ { get; set; }
    }
    //Opća uputnica - dodatna geografska oznaka
    public class Datafield481
    {
        //Dodatna geografska oznaka
        public string SubfieldZ { get; set; }
        //Podatak o odnosu
        public string SubfieldI { get; set; }
        //Kontrola podpolja
        // /0 - Poseban odnos
        // /1 - Ograničenje upotrebe uputnice
        // /2 - Raniji oblik odrednice
        // /3 - Prikaz uputnice
        public string SubfieldW { get; set; }
        //Dodatna odrednica za žanr/oblik
        public string SubfieldV { get; set; }
        //Dodatna odrednica za opći pojam
        public string SubfieldX { get; set; }
        //Dodatna odrednica za vrijeme
        public string SubfieldY { get; set; }
    }
    //Opća uputnica - dodatna vremenska oznaka
    public class Datafield482
    {
        //Dodatna vremenska oznaka
        public string SubfieldY { get; set; }
        //Podatak o odnosu
        public string SubfieldI { get; set; }
        //Kontrola podpolja
        // /0 - Poseban odnos
        // /1 - Ograničenje upotrebe uputnice
        // /2 - Raniji oblik odrednice
        // /3 - Prikaz uputnice
        public string SubfieldW { get; set; }
        //Dodatna odrednica za žanr/oblik
        public string SubfieldV { get; set; }
        //Dodatna odrednica za opći pojam
        public string SubfieldX { get; set; }
        //Dodatna odrednica za geografsko ime
        public string SubfieldZ { get; set; }
    }
    //Opća uputnica - dodatna oznaka za oblik
    public class Datafield485
    {
        //Dodatna oznaka za oblik
        public string SubfieldV { get; set; }
        //Podatak o odnosu
        public string SubfieldI { get; set; }
        //Kontrola podpolja
        // /0 - Poseban odnos
        // /1 - Ograničenje upotrebe uputnice
        // /2 - Raniji oblik odrednice
        // /3 - Prikaz uputnice
        public string SubfieldW { get; set; }
        //Dodatna odrednica za opći pojam
        public string SubfieldX { get; set; }
        //Dodatna odrednica za vrijeme
        public string SubfieldY { get; set; }
        //Dodatna odrednica za geografsko ime
        public string SubfieldZ { get; set; }
    }
    #endregion


#region Unakrsne uputnice - 5XX - klase
    //Unakrsna uputnica - osobno ime
    public class Datafield500
    {
        //Prvi indikator određuje oblik osobnog imena
        // 0-Ime, 1-Prezime, 3-Obiteljsko ime
        public string Ind1 { get; set; }
        //Osobno ime
        public string SubfieldA { get; set; }
        //Numeracija - rimski brojevi
        public string SubfieldB { get; set; }
        //Titule i ostali doatci imenu, osim datuma
        public string SubfieldC { get; set; }
        //Naslov djela
        public string SubfieldT { get; set; }
        //Datumi pridruženi imenu
        public string SubfieldD { get; set; }
        //Podatak o odnosu
        public string SubfieldI { get; set; }
        //Kontrola podpolja
        // /0 - Poseban odnos
        // /1 - Ograničenje upotrebe uputnice
        // /2 - Raniji oblik odrednice
        // /3 - Prikaz uputnice
        public string SubfieldW { get; set; }
        //Dodatna odrednica za žanr/oblik
        public string SubfieldV { get; set; }
        //Dodatna odrednica za opći pojam
        public string SubfieldX { get; set; }
        //Dodatna odrednica za vrijeme
        public string SubfieldY { get; set; }
        //Dodatna odrednica za geografsko ime
        public string SubfieldZ { get; set; }
    }
    //Unakrsna uputnica - naziv korporativnog tijela
    public class Datafield510
    {
        //Prvi indikator određuje oblik naziva korporativnog tijela
        //6 Premetnuti naziv
        //7 Naziv pod jurisdikcijom/ sjedištem
        //8 Naziv u izravnom redoslijedu
        public string Ind1 { get; set; }
        //Naziv korporativnog tijela ili jurisdikcije/sjedišta
        public string SubfieldA { get; set; }
        //Podređena jedinica
        public string SubfieldB { get; set; }
        //Naslov djela
        public string SubfieldT { get; set; }
        //Podatak o odnosu
        public string SubfieldI { get; set; }
        //Kontrola podpolja
        // /0 - Poseban odnos
        // /1 - Ograničenje upotrebe uputnice
        // /2 - Raniji oblik odrednice
        // /3 - Prikaz uputnice
        public string SubfieldW { get; set; }
        //Dodatna odrednica za žanr/oblik
        public string SubfieldV { get; set; }
        //Dodatna odrednica za opći pojam
        public string SubfieldX { get; set; }
        //Dodatna odrednica za vrijeme
        public string SubfieldY { get; set; }
        //Dodatna odrednica za geografsko ime
        public string SubfieldZ { get; set; }
    }
    //Unakrsna uputnica - naziv sastanka
    public class Datafield511
    {
        //Prvi indikator određuje oblik naziva sastanka
        //0 Naziv u premetnutom obliku
        //1 Naziv pod sjedištem/jurisdikcijom
        //2 Naziv u izravnom redoslijedu
        public string Ind1 { get; set; }
        //Naziv sastanka ili jurisdikcije/sjedišta
        public string SubfieldA { get; set; }
        //Mjesto sastanka
        public string SubfieldC { get; set; }
        //Datum sastanka
        public string SubfieldD { get; set; }
        //Naslov djela
        public string SubfieldT { get; set; }
        //Podatak o odnosu
        public string SubfieldI { get; set; }
        //Kontrola podpolja
        // /0 - Poseban odnos
        // /1 - Ograničenje upotrebe uputnice
        // /2 - Raniji oblik odrednice
        // /3 - Prikaz uputnice
        public string SubfieldW { get; set; }
        //Dodatna odrednica za žanr/oblik
        public string SubfieldV { get; set; }
        //Dodatna odrednica za opći pojam
        public string SubfieldX { get; set; }
        //Dodatna odrednica za vrijeme
        public string SubfieldY { get; set; }
        //Dodatna odrednica za geografsko ime
        public string SubfieldZ { get; set; }
    }
    //Unakrsna uputnica - jedinstveni naslov
    public class Datafield530
    {
        //Drugi indikator sadrži broj početnih znakova koji se isključuju iz abecednog redanja 0-9
        public string Ind2 { get; set; }
        //Jedinstveni naslov
        public string SubfieldA { get; set; }
        //Datum potpisivanja sporazuma
        public string SubfieldD { get; set; }
        //Datum djela
        public string SubfieldF { get; set; }
        //Raznovrsni podatci
        public string SubfieldG { get; set; }
        //Medij
        public string SubfieldH { get; set; }
        //Pododrednica za oblik
        public string SubfieldK { get; set; }
        //Jezik djela
        public string SubfieldL { get; set; }
        //Medij izvedbe glazbe
        public string SubfieldM { get; set; }
        //Broj dijela djela
        public string SubfieldN { get; set; }
        //Podatak o glazbenom aranžmanu
        public string SubfieldO { get; set; }
        //Naziv dijela djela
        public string SubfieldP { get; set; }
        //Tonalitet za glazbu
        public string SubfieldR { get; set; }
        //Verzija
        public string SubfieldS { get; set; }
        //Podatak o odnosu
        public string SubfieldI { get; set; }
        //Kontrola podpolja
        // /0 - Poseban odnos
        // /1 - Ograničenje upotrebe uputnice
        // /2 - Raniji oblik odrednice
        // /3 - Prikaz uputnice
        public string SubfieldW { get; set; }
        //Dodatna odrednica za žanr/oblik
        public string SubfieldV { get; set; }
        //Dodatna odrednica za opći pojam
        public string SubfieldX { get; set; }
        //Dodatna odrednica za vrijeme
        public string SubfieldY { get; set; }
        //Dodatna odrednica za geografsko ime
        public string SubfieldZ { get; set; }
    }
    //Unakrsna uputnica - opći pojam
    public class Datafield550
    {
        //Opći pojam
        public string SubfieldA { get; set; }
        //Podatak o odnosu
        public string SubfieldI { get; set; }
        //Kontrola podpolja
        // /0 - Poseban odnos
        // /1 - Ograničenje upotrebe uputnice
        // /2 - Raniji oblik odrednice
        // /3 - Prikaz uputnice
        public string SubfieldW { get; set; }
        //Dodatna odrednica za žanr/oblik
        public string SubfieldV { get; set; }
        //Dodatna odrednica za opći pojam
        public string SubfieldX { get; set; }
        //Dodatna odrednica za vrijeme
        public string SubfieldY { get; set; }
        //Dodatna odrednica za geografsko ime
        public string SubfieldZ { get; set; }
    }
    //Unakrsna uputnica - geografsko ime
    public class Datafield551
    {
        //Geografsko ime
        public string SubfieldA { get; set; }
        //Podatak o odnosu
        public string SubfieldI { get; set; }
        //Kontrola podpolja
        // /0 - Poseban odnos
        // /1 - Ograničenje upotrebe uputnice
        // /2 - Raniji oblik odrednice
        // /3 - Prikaz uputnice
        public string SubfieldW { get; set; }
        //Dodatna odrednica za žanr/oblik
        public string SubfieldV { get; set; }
        //Dodatna odrednica za opći pojam
        public string SubfieldX { get; set; }
        //Dodatna odrednica za vrijeme
        public string SubfieldY { get; set; }
        //Dodatna odrednica za geografsko ime
        public string SubfieldZ { get; set; }
    }
    //Unakrsna uputnica - žanr/oblik
    public class Datafield555
    {
        //Žanr/oblik
        public string SubfieldA { get; set; }
        //Podatak o odnosu
        public string SubfieldI { get; set; }
        //Kontrola podpolja
        // /0 - Poseban odnos
        // /1 - Ograničenje upotrebe uputnice
        // /2 - Raniji oblik odrednice
        // /3 - Prikaz uputnice
        public string SubfieldW { get; set; }
        //Dodatna odrednica za žanr/oblik
        public string SubfieldV { get; set; }
        //Dodatna odrednica za opći pojam
        public string SubfieldX { get; set; }
        //Dodatna odrednica za vrijeme
        public string SubfieldY { get; set; }
        //Dodatna odrednica za geografsko ime
        public string SubfieldZ { get; set; }
    }
    //Unakrsna uputnica - dodatna oznaka za opći pojam
    public class Datafield580
    {
        //Dodatna odrednica za opći pojam
        public string SubfieldX { get; set; }
        //Podatak o odnosu
        public string SubfieldI { get; set; }
        //Kontrola podpolja
        // /0 - Poseban odnos
        // /1 - Ograničenje upotrebe uputnice
        // /2 - Raniji oblik odrednice
        // /3 - Prikaz uputnice
        public string SubfieldW { get; set; }
        //Dodatna odrednica za žanr/oblik
        public string SubfieldV { get; set; }
        //Dodatna odrednica za vrijeme
        public string SubfieldY { get; set; }
        //Dodatna odrednica za geografsko ime
        public string SubfieldZ { get; set; }
    }
    //Unakrsna uputnica - dodatna geografska oznaka
    public class Datafield581
    {
        //Dodatna geografska oznaka
        public string SubfieldZ { get; set; }
        //Podatak o odnosu
        public string SubfieldI { get; set; }
        //Kontrola podpolja
        // /0 - Poseban odnos
        // /1 - Ograničenje upotrebe uputnice
        // /2 - Raniji oblik odrednice
        // /3 - Prikaz uputnice
        public string SubfieldW { get; set; }
        //Dodatna odrednica za žanr/oblik
        public string SubfieldV { get; set; }
        //Dodatna odrednica za opći pojam
        public string SubfieldX { get; set; }
        //Dodatna odrednica za vrijeme
        public string SubfieldY { get; set; }
    }
    //Unakrsna uputnica - dodatna vremenska oznaka
    public class Datafield582
    {
        //Dodatna vremenska oznaka
        public string SubfieldY { get; set; }
        //Podatak o odnosu
        public string SubfieldI { get; set; }
        //Kontrola podpolja
        // /0 - Poseban odnos
        // /1 - Ograničenje upotrebe uputnice
        // /2 - Raniji oblik odrednice
        // /3 - Prikaz uputnice
        public string SubfieldW { get; set; }
        //Dodatna odrednica za žanr/oblik
        public string SubfieldV { get; set; }
        //Dodatna odrednica za opći pojam
        public string SubfieldX { get; set; }
        //Dodatna odrednica za geografsko ime
        public string SubfieldZ { get; set; }
    }
    //Unakrsna uputnica - dodatna oznaka za oblik
    public class Datafield585
    {
        //Dodatna oznaka za oblik
        public string SubfieldV { get; set; }
        //Podatak o odnosu
        public string SubfieldI { get; set; }
        //Kontrola podpolja
        // /0 - Poseban odnos
        // /1 - Ograničenje upotrebe uputnice
        // /2 - Raniji oblik odrednice
        // /3 - Prikaz uputnice
        public string SubfieldW { get; set; }
        //Dodatna odrednica za opći pojam
        public string SubfieldX { get; set; }
        //Dodatna odrednica za vrijeme
        public string SubfieldY { get; set; }
        //Dodatna odrednica za geografsko ime
        public string SubfieldZ { get; set; }
    }
    #endregion


#region Napomene - 6XX - klase
    //Napomena o indeksiranju  pojma - nekontrolirano
    public class Datafield653
    {
        //Nekontrolirani pojam
        public string SubfieldA { get; set; }
    }
    //Napomena o povijesti
    public class Datafield665
    {
        //Napomena o povijesti
        public string SubfieldA { get; set; }
    }
    //Opća objasnidbena uputnica - imena
    public class Datafield666
    {
        //Opća objasnidbena uputnica
        public string SubfieldA { get; set; }
    }
    //Opća interna napomena
    public class Datafield667
    {
        //Opća interna napomena
        public string SubfieldA { get; set; }
    }
    //Izvor pronađenih podataka
    public class Datafield670
    {
        //Izvor
        public string SubfieldA { get; set; }
        //Pronađeni podatak
        public string SubfieldB { get; set; }
        //Jedinstveni identifikator građe (URI)
        public string SubfieldU { get; set; }
    }
    //Izvor gdje podatci nisu pronađeni
    public class Datafield675
    {
        //Izvor
        public string SubfieldA { get; set; }
    }
    //Biografski ili povijesni podatci
    public class Datafield678
    {
        //Prvi indikator identificira vrstu podatka sadržanu u polju
        //0 Biografski podatak
        //1 Administrativna povijest
        public string Ind1 { get; set; }
        //Biografski ili povijesni podataka
        public string SubfieldA { get; set; }
        //Objašnjenje
        public string SubfieldB { get; set; }
        //Jedinstveni identifikator građe (URI)
        public string SubfieldU { get; set; }
    }
    //Opća napomena
    public class Datafield680
    {
        //Odrednica ili dodatna oznaka
        public string SubfieldA { get; set; }
        //Tekst objašnjenja 
        public string SubfieldI { get; set; }
    }
    //Napomena o primjeru - predmet
    public class Datafield681
    {
        //Odrednica ili dodatna oznaka
        public string SubfieldA { get; set; }
        //Tekst objašnjenja
        public string SubfieldI { get; set; }
    }
    //Napomena o izbrisanoj odrednici
    public class Datafield682
    {
        //Zamjenska odrednica
        public string SubfieldA { get; set; }
        //Tekst objašnjenja
        public string SubfieldI { get; set; }
    }
    //Napomena o povijesti primjene
    public class Datafield688
    {
        //Napomena o povijesti primjene
        public string SubfieldA { get; set; }
    }
#endregion


    //Usvojena odrednica za povezivanje - opći pojam
    public class Datafield750
    {
        //Drugi identifikator - 7 izvor naveden u potpolju $2
        public string Ind2 { get; set; }
        //Opći pojam
        public string SubfieldA { get; set; }
        //Izvor odrednice ili pojma
        public string Subfield2 { get; set; }
        //Dodatna odrednica za žanr/oblik
        public string SubfieldV { get; set; }
        //Dodatna odrednica za opći pojam
        public string SubfieldX { get; set; }
        //Dodatna odrednica za vrijeme
        public string SubfieldY { get; set; }
        //Dodatna odrednica za geografsko ime
        public string SubfieldZ { get; set; }
    }

    //Usvojena odrednica za povezivanje - geografsko ime
    public class Datafield751
    {
        //Drugi identifikator - 7 izvor naveden u potpolju $2
        public string Ind2 { get; set; }
        //Geografsko ime
        public string SubfieldA { get; set; }
        //Izvor odrednice ili pojma
        public string Subfield2 { get; set; }
        //Dodatna odrednica za žanr/oblik
        public string SubfieldV { get; set; }
        //Dodatna odrednica za opći pojam
        public string SubfieldX { get; set; }
        //Dodatna odrednica za vrijeme
        public string SubfieldY { get; set; }
        //Dodatna odrednica za geografsko ime
        public string SubfieldZ { get; set; }
    }

    //Elektronička lokacija i pristup
    public class Datafield856
    {
        //Prvi indikator
        //Određuje način pristupa elektroničkom izvoru informacija.Kada se URL upisuje u potpolje $u
        //vrijednost odgovara načinu pristupa (URL shemi), koja je prvi element u nizu.
        // 4 HTTP (pristup elektroničkom izvoru putem Hypertext Transfer Protocol-a)
        public string Ind1 { get; set; }
        //Jedinstveni identifikator izvora - elektronički pristup (URI)
        public string SubfieldU { get; set; }
        //Tekstualna inačica poveznice (URI-a)
        public string SubfieldY { get; set; }
        //Javna napomena
        public string SubfieldZ { get; set; }
    }

    //Polje lokanog korištenja - ogledna odrednica
    public class Datafield952
    {
        //Tekst
        public string SubfieldA { get; set; }
    }

    //Polje lokanog korištenja
    public class Datafield998
    {
        //Informacija o katalogizatorima koji su izradili zapis
        public string SubfieldC { get; set; }
    }
}