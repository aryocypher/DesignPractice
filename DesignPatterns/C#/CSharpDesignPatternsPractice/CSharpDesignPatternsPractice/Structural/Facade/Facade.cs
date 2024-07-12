using CSharpDesignPatternsPractice.Structural.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ComputerFacade cf= new ComputerFacade();
//cf.start();
namespace CSharpDesignPatternsPractice.Structural.Facade
{

    class CPU
    {
        public void Freeze()
        {
            Console.WriteLine("Freeze");
        }
        public void Execute()
        {
            Console.WriteLine("Execute");
        }
    }

    class Memory
    {
        public void Load()
        {
            Console.WriteLine("Load Memory");
        }
    }

    class HardDrive()
    {
        public void Read()
        {
            Console.WriteLine("Read");
        }
    }
    class ComputerFacade
    {
        private CPU cPU;
        private Memory memory;
        private HardDrive hardwareDrive;

        public ComputerFacade()
        {
            this.cPU= new CPU();
            this.memory= new Memory();
            this.hardwareDrive= new HardDrive();
        }

        public void start()
        {
            cPU.Execute();
            memory.Load();
            hardwareDrive.Read();
        }
    }
}
