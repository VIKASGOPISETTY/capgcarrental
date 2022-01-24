using CAPG-CAR-RENTAL-PROJECT.Models;

namespace CAPG-CAR-RENTAL-PROJECT.Infrastructure
{
    public class LocationDetailsRepository : ICRUDRepository<Location, int>
    {
        CapRental _db;
        public LocationDetailsRepository(CapRentalContext db)
        {
            _db = db;
        }
        public IEnumerable<Location> GetAll()
        {
            return _db.LocationDetails.ToList();
        }
        public Location GetDetails(int id)
        {
            return _db.LocationDetails.FirstOrDefault(c=>c.LocationId==id);
        }
        public void Create(Location item)
        {
            _db.LocationDetails.Add(item);
            _db.SaveChanges();
        }
        public void Delete(int id)
        {
             var obj = _db.LocationDetails.FirstOrDefault(c=>c.LocationId==id);
            if(obj==null)
                return;  
            _db.LocationDetails.Remove(obj);
            _db.SaveChanges();
        }
        public void Update(Location item)
        {
             var obj = _db.LocationDetails.FirstOrDefault(c=>c.LocationId==item.LocationId);

            if(obj==null)

                return;

            obj.LOCATION_ID = item.LOCATION_ID;

            obj.LOCATION_DETAILS = item.LOCATION_DETAILS; 

            obj.STREET = Item.STREET;

            obj.City = item.City;

            obj.STATE_NAME = item.STATE_NAME;

            obj.ZIPCODE = item.ZIPCODE;

            

            _db.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            _db.SaveChanges();

        }

    }
}