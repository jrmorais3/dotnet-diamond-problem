using dotnet_diamond_problem.Interfaces;

namespace dotnet_diamond_problem.Classes
{
    public class EnergyControl : ISmartphone, ITablet
    {
        void ISmartphone.Charge()
        {
            Console.WriteLine("Smartphone is charging...");
        }

        void ITablet.Charge()
        {
            Console.WriteLine("Tablet is charging...");
        }
    }
}
