using System;

class Mobile
{
    string brand;
    string model;
    int battery_level;
    
    public Mobile(string brand,string model)
    {
        this.brand=brand;
        this.model=model;
        this.battery_level=0;
    }
    public void makeCall(string Phone_no)
    {
        Console.Write(Phone_no);
        Console.Write("  Calling...");
    }
    public void chargeBattery(int amt)
    {
        if(battery_level<100)
        {
            battery_level=battery_level+amt;
        }
        else
        {
            battery_level=100;
            Console.Write("Battery is fully charged.");
        }
        
    }
    public void useBattery(int amt)
    {
        if(battery_level>20)
        {
            battery_level=battery_level-amt;
        }
        else
        {
            Console.Write(battery_level);
            Console.Write("Battery running low!");
        }
    }
    public void printDetails()
    {
        Console.Write("\nMobile Detalis:\n");
        Console.WriteLine($"Brand: {brand}");
        Console.WriteLine($"Model: {model}");
        Console.Write($"Battery Level: {battery_level}");
    }
    
}
class Mobile_Class
{
    static void Main(string[] args)
    {
        Mobile m= new Mobile("Samsung","Grand Pro");
        m.makeCall("9544746120");
        m.chargeBattery(75);
        m.useBattery(30);
        m.printDetails();
    }
}
