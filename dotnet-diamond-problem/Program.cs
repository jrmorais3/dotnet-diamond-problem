using dotnet_diamond_problem.Classes;
using dotnet_diamond_problem.Interfaces;

EnergyControl energyControl = new();
((ISmartphone)energyControl).Charge(); // Outputs: Smartphone is charging...
((ITablet)energyControl).Charge(); // Outputs: Tablet is charging...
Console.ReadLine();