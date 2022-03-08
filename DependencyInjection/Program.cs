using DependencyInjection.Interfaces;
using System;

namespace DependencyInjection
{
    // 1 Client Class => The client class is a class wich dependq on the service class.
    // 2 Service Class => The service class is a class that provides service to the client.
    // 3 Injector Class => Thrninjector class injects the service class ibject into the client class.


    public class StudentService : IService
    {
        public void GetName()
        {
            Console.WriteLine("Service name");
        }
        public void GetDescription()
        {
            Console.WriteLine("Student");
        }
    }
    public class TeacherService : IService
    {
        public void GetName()
        {
            Console.WriteLine("This is service name");
        }
        public void GetDescription()
        {
            Console.WriteLine("This is Teahcer");
        }
    }

    public class BusinessLogicService
    {
        IService iService;

        public BusinessLogicService(IService iService)
        {
            this.iService = iService;
            this.iService.GetName();
            this.iService.GetDescription();
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            BusinessLogicService businessLogicService = new BusinessLogicService(new StudentService());
            Console.ReadKey();
        }
    }

    ////Tight coupling
    //public class Student
    //{
    //    DataService obj = new DataService();
    //    public void Get()
    //    {
    //        obj.GetName();
    //    }
    //}
    //public class DataService
    //{
    //    public void GetName()
    //    {

    //    }
    //}
    ////End tight coupling
}
