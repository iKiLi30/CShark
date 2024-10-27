using System;

namespace CShark
{
    public class Maine
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здарова паттернщик!!");
            Logger.getInstance().Debug("Это СИНГЛТОН");
                        
        }
    }
}