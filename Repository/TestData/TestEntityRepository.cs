using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFTestTask.Repository.TestData
{
    public class TestEntityRepository
    {
        public void Create(TestEntity TestEntity)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.TestEntities.Add(TestEntity);
                db.SaveChanges();
            }
        }

        public List<TestEntity> GetAll()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                return db.TestEntities.ToList();
            }
        }
        public TestEntity GetById(int id)
        {
            TestEntity TestEntity;
            using (ApplicationContext db = new ApplicationContext())
            {
                TestEntity = db.TestEntities.Where(d => d.Id == id).First();
            }
            return TestEntity;
        }
        public void Update(TestEntity TestEntity)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.TestEntities.Update(TestEntity);
                db.SaveChanges();
            }
        }
        public void DeleteById(int id)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.TestEntities.Remove(GetById(id));
                db.SaveChanges();
            }
        }
    }
}
