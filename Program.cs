namespace Ovning3._2_Polymorfism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<UserError> errors = new List<UserError>();
            for (int i = 0; i < 5; i++) 
            { 
                errors.Add(new NumericInputError());
                errors.Add(new TextInputError());
                errors.Add(new FantasilostFelEtt());
                errors.Add(new FantasilostFelTvå());
                errors.Add(new FantasilostFelTre());
            }
            foreach (UserError error in errors)
            {
                int nr = errors.IndexOf(error);
                Console.WriteLine($"Error({nr}): { error.UEMessage()}");
            }
        }
    }
}