using System;

class Program
{
    static void Main(string[] args)
    {
        Computer gamingPC = new Computer.Builder()
            .SetCPU("Intel i9")
            .SetRAM(32)
            .SetStorage(1000)
            .Build();

        Computer officePC = new Computer.Builder()
            .SetCPU("Intel i5")
            .SetRAM(16)
            .SetStorage(512)
            .Build();

        gamingPC.DisplayConfiguration();
        officePC.DisplayConfiguration();
    }
}