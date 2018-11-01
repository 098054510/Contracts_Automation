namespace Contracs_Automation.Services
{
    interface ITaxServices<Amount>
    {
        double Tax(double Amount);
    }
}