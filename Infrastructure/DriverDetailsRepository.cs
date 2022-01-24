using CAPG-CAR-RENTAL-PROJECT.Models;

namespace CAPG-CAR-RENTAL-PROJECT.Infrastructure
{
    public class DriverDetailsRepository : ICRUDRepository<Driver, int>
    {
        CapRental _db;
        public DriverDetailsRepository(CapRentalContext db)
        {
            _db = db;
        }
        public IEnumerable<Driver> GetAll()
        {
            return _db.DriverDetails.ToList();
        }
        public Driver GetDetails(int id)
        {
            return _db.DriverDetails.FirstOrDefault(c=>c.DriverId==id);
        }
        public void Create(Driver item)
        {
            _db.DriverDetails.Add(item);
            _db.SaveChanges();
        }
        public void Delete(int id)
        {
             var obj = _db.DriverDetails.FirstOrDefault(c=>c.DriverId==id);
            if(obj==null)
                return;  
            _db.DriverDetails.Remove(obj);
            _db.SaveChanges();
        }
        public void Update(Driver item)
        {
             var obj = _db.DriverDetails.FirstOrDefault(c=>c.DriverId==item.DriverId);

            if(obj==null)

                return;

            obj.FName = item.FName;

            obj.MName = item.MName; 

            obj.LName = item.LName;

            obj.PHONE_NUMBER = item.PHONE_NUMBER;

            obj.STREET = Item.STREET;

            obj.City = item.City;

            obj.STATE_NAME = item.STATE_NAME;

            obj.ZIPCODE = item.ZIPCODE;

            

            _db.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            _db.SaveChanges();

        }

    }
}