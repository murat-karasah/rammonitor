using System.Diagnostics;

Process[] processes = Process.GetProcesses();

foreach (Process process in processes)
{
    Console.WriteLine("------------------------");
    Console.WriteLine("Process Name: {0} \t ID: {1} \t Memory Usage: {2} KB",
        process.ProcessName, process.Id, process.WorkingSet64 / 1024);

    try
    {
        ProcessModule mainModule = process.MainModule;
        IntPtr baseAddress = mainModule.BaseAddress;
        int moduleSize = mainModule.ModuleMemorySize;

        Console.WriteLine("Base Address: 0x{0:X}", baseAddress.ToInt64());
        Console.WriteLine("Module Size: {0} bytes", moduleSize);

        foreach (ProcessModule module in process.Modules)
        {
            Console.WriteLine("Module Name: {0}", module.ModuleName);
            Console.WriteLine("Base Address: 0x{0:X}", module.BaseAddress.ToInt64());
            Console.WriteLine("Module Size: {0} bytes", module.ModuleMemorySize);
            Console.WriteLine();
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine("Error: {0}", ex.Message);
    }

    Console.WriteLine("------------------------");
}

Console.ReadLine();