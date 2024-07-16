using System;

//using System;: System ad alanını (namespace) kullanıma ekler. Bu, temel C# işlevlerine erişim sağlar.
namespace HelloWorld
//namespace HelloWorld: HelloWorld adlı bir ad alanı tanımlar. Ad alanları, kodun düzenlenmesine yardımcı olur.
{
    class Program
    //class Program: Program adlı bir sınıf tanımlar. Bu sınıf, programın ana işlevselliğini içerir.
    {
        static void Main(string[] args)
        //static void Main(string[] args): Main adlı statik bir yöntem tanımlar. Main yöntemi, programın başlangıç noktasıdır. Program çalıştırıldığında ilk olarak bu yöntem çalışır.
        {
            //Console.WriteLine(...): Konsola bir mesaj yazdırır. Bu örnekte, "Nihat Nadir Börlü\nYazılıma hevesliyim, Patikadan öğrenecek çok şeyim var, ayrıca marka isminden dolayı daha çabuk işe de girebilirim." mesajı yazdırılır.
            Console.WriteLine("Nihat Nadir Börlü\n Yazılıma hevesliyim Patikadan" +
            " öğrenecek cok seyim var ayrica marka isminden dolayi daha cabuk isede girebilirim ");

        }
    }
}