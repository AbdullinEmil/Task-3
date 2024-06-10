///Задание 3
public class CreditCard
{
    string CardNumber;
    string HolderFIO;
    int CVC;
    string ExpireDate;
    public void CinCreditCard()
    {
        Console.WriteLine("Введите номер карты: (16 символов) ");
        string CardNumber = Console.ReadLine();

        Console.WriteLine("Введите ФИО Владельца Карты: ");
        string HolderFIO = Console.ReadLine();

        Console.WriteLine("Введите CVC Код Карты: ");
        string CVCInput = Console.ReadLine();

        Console.WriteLine("Введите Срок Работы Карты До: (дата.месяц.год) ");
        string ExpireDate = Console.ReadLine();
    }
    public void showCreditCard()
    {
        Console.WriteLine("Номер Карты: ", CardNumber);
        Console.WriteLine("ФИО Владельца: ", HolderFIO);
        Console.WriteLine("CVC Код: ", CVC);
        Console.WriteLine("Срок Работы Карты До: ", ExpireDate);
    }
}


