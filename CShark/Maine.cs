using System;

namespace CShark
{
    public class Maine
    {
        static void Main(string[] args)
        {
            Maine maine= new Maine();
            Console.WriteLine("Здарова паттернщик!!");
            
            Logger.getInstance().Debug("Это СИНГЛТОН");
            maine.ThisSingleton();
        }

        private void ThisSingleton()
        {
            Logger.getInstance().Debug("СИНГЛТОН ИЗ МЭЙНА");
        }
    }
}