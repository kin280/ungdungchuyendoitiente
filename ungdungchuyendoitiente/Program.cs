using System;

class doitien
{
    
    static double Doitien(double USD, double Rate)
    {
        return USD * Rate;
    }

    static void Main()
    {
        
        double Rate = 23000; 
        Console.Write("Nhập giá trị tiền USD: ");
        double USD = Convert.ToDouble(Console.ReadLine());

        double VND = Doitien(USD, Rate);
        Console.WriteLine($"{USD} USD = {VND} VNĐ");

        Console.ReadLine();
    }
}

