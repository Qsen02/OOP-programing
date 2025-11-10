namespace CathcingExceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person pesho = new Person("Pesho", "Peshev", 24);

            try
            {
                Person noName = new Person(string.Empty, "Goshev", 31);
                Person noLastName = new Person("Ivan", null, 63);
                Person negativeAge = new Person("Stoyan", "Kolev", -1);
                Person tooOldForThisProgram = new Person("Iskren", "Ivanov", 121);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Exception thrown: {ex.Message}");
            }
            catch (ArgumentOutOfRangeException ex) 
            {
                Console.WriteLine($"Exception thrown: {ex.Message}");
            }
        }
    }
}
