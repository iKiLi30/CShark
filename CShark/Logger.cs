using System;
using static System.Console;

namespace CShark;
/// <summary>
/// ПАТТЕРН СИНГЛТОН СОСТОИТ ИЗ ПРИВАТНОГО ПОЛЯ ТИПА ЭТОГО КЛАССА, ПРИВАТНОГО
/// КОНСТРУКТОРА, PUBLIC МЕТОДА GETiNSTANCE() ВОЗВРАЩАЮЩЕГО INSTAMCE С ПРОВЕРКОЙ
/// ЧТО ОН ЕЩЕ НЕ СОЗДАН!! И РЕАЛИЗАЙИЯ КАКОГО ЛИБО ЕЩЕ ФУНКЦИОНАЛА ПО ЖЕЛАНИЮ 
/// </summary>
public class Logger
{
    private static Logger? instance;
    private Logger()
    {
        WriteLine("Logger is create");     
    }
    static public Logger getInstance()
    {
        if (instance == null) instance = new Logger();
        return instance;
    }

    public void Debug(string name)
    {
        WriteLine(name);
    }


}
