using System;
 namespace Degisken
 { 
  class Program
  {
    static void Main(string[] args) 
   {
    int deger=2;
    Console.WriteLine(deger);
//string degisken=null; 
//string Degisken=null;
//int= 3 degisken *olmaz;
//string class=null -olmaz cunku class zaten kullanilan bir fonksiyondur ama bazisini kabul edebilir;
//ayni degiskeni ayni class icerisinde kullanamazsin. Ayni ad kullanilmaz
//alttre degisken isimlerinde kullanilir ancak bosluk kullanilamaz
//string degisken=" " bosluklar onemlidir. Karakter olarak algilanir/ Burada if(degisken=="") false olarak geri doneceltir
//byte b=5; //byte bir byte yer kaplar 0 ile 255 arasi
//sbyte c=5; //sbyte 1 byte yer kaplar =128 ile 127 arasi
//short s=5;// bellekte 2 byte yer kaplar -32768 ile 32768
//ushort us=5; // bellekte 2 byte 0 ile 65365
//Int16 i16=2; //2 byte 
//int i=2; //4 byte
//Int32 i32=2; //4 byte
//Int64 i64=2; //8 byte
//uint ui=2;    //4 byte
//long l=4; //8 byte
//ulong ul=4; //8 byte
//float f=4.4; //8 byte reel sayilar
//double d=5;//8 byte
//decimal de=5;//16 byte

//char ch="2"; //
//string str="Emine" ;//sinirsiz yer kaplar 

//bool bl=true; //

     DateTime dt=DateTime.Now;
     Console.WriteLine(dt);
    object o1="x";
    object o2="y";
    object o3="3";
    object o4="3.4";

// string ifadeler
    string strl=string.Empty;
    strl = "Emine Dursun";
    string ad="Dilan";
    string soyad="Dursun";
    string tamisim=ad+""+soyad;
// integer tanimlama sekilleri
   int integer1=3;
   int integer2=2;
   int integer3=integer1*integer2;
  //boolean ifadeler
    bool bool1=10<2; 
  //Degisken donusumleri
    string str20="20"; 
    int int20=20;
    string yeniDeger=str20+int20.ToString(); //ciktisi 2020
    Console.WriteLine(yeniDeger);
    int int21= int20 + Convert.ToInt32(str20); //ciktisi 40
    Console.WriteLine(int21);
    int int22= int20 + int.Parse(str20); //ciktisi 40
    //datetime
    string datetime=DateTime.Now.ToString("dd.MM.yyyy");
    Console.WriteLine(datetime);
    string datetime2=DateTime.Now.ToString("dd/MM/yyyy");
    Console.WriteLine(datetime2);
    //saat
    string hour=DateTime.Now.ToString("HH.mm");
    Console.WriteLine(hour);
    
    }  
  }
 }// See https://aka.ms/new-console-template for more information

