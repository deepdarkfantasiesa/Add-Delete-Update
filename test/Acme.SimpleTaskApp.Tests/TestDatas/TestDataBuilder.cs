using Acme.SimpleTaskApp.EntityFrameworkCore;
using Acme.SimpleTaskApp.Tasks;

namespace Acme.SimpleTaskApp.Tests.TestDatas
{
    public class TestDataBuilder
    {
        private readonly SimpleTaskAppDbContext _context;

        public TestDataBuilder(SimpleTaskAppDbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            var neo = new Person("Neo");
            _context.People.Add(neo);
            _context.SaveChanges();

            //create test data here...
            _context.Certificates.AddRange(new Workers.Certificate()
            {
                Certification = "fff",
                WorkerID = 1

            }) ;

            _context.Workers.AddRange(
                new Workers.HouseWorker("HouseWorker1", 30, 1, "13800000000", "MyFirstHouseWorker", "tianhe"),
                new Workers.HouseWorker("HouseWorker2", 60, 2, "13800000001", "MySecondHouseWorker", "haizhu")
 
                ); ;


        }
    }
}