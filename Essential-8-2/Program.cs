namespace Essential8_2
{
    class Program
    {

        static void Main()
        {
            const int ManagerHours = 190;
            const int DeveloperHours = 180;
            const int DesignerHours = 140;

            Accountant accountant = new Accountant();

            Console.WriteLine("bonus for manager: " + accountant.AskForBonus(Position.Manager, ManagerHours));//true
            Console.WriteLine("bonus for developer: " + accountant.AskForBonus(Position.Developer, DeveloperHours));//false
            Console.WriteLine("bonus for designer: " + accountant.AskForBonus(Position.Designer, DesignerHours));//false
        }
    }
    enum Position
    {
        Manager,
        Developer,
        Designer
    }
    class Accountant
    {
        public bool AskForBonus(Position worker, int hours)
        {
          
            switch (worker)
            {
                case Position.Manager:
                    return hours > 160; 
                case Position.Developer:
                    return hours > 180; 
                case Position.Designer:
                    return hours > 150; 
                default:
                    return false;
            }
        }
    }
}