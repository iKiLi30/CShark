using System;

namespace CShark
{
    public class Maine
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здарова паттернщик!!");
            Logger.getInstance().Debug("Это СИНГЛТОН");

            System.Console.WriteLine("Прокси тут");            
            IService service= new Service();
            ProxyService proxy = new ProxyService(service);
            int ansver  = proxy.Sum(5,7);
            System.Console.WriteLine(ansver);

        }
    }
}