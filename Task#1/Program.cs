namespace Program
{
    class Program
    {
        public static void Main(string[] agrs)
        {
            List<Exception> ExceptionList = new List<Exception>() 
            {
                new DirectoryNotFoundException(), // Недопустимая часть пути каталога 
                new DivideByZeroException(),//Нельзя делить на ноль
                new DriveNotFoundException(), // диск не доступен
                new FileNotFoundException(), // Файл не существует
                new FormatException() // Значение находиться не в формате
            };
            foreach(Exception ex in ExceptionList)
            {
                try
                {
                    throw ex;
                }
                catch(DirectoryNotFoundException exc)
                {
                    Console.WriteLine(exc.Message);
                }
                catch (DivideByZeroException exc)
                {
                    Console.WriteLine(exc.Message);
                }
                catch (DriveNotFoundException exc)
                {
                    Console.WriteLine(exc.Message);
                }
                catch(FileNotFoundException exc)
                {
                    Console.WriteLine(exc.Message);
                }
                catch(FormatException exc)
                {
                    Console.WriteLine(exc.Message);
                }
            }
            
        }
    }
}