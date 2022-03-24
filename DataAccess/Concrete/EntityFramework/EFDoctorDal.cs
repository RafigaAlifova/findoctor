using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;


namespace DataAccess.EntityFramework.Concrete
{
    public class EFDoctorDal : EfEntityRepositoryBase<Doctor, findoctorContext>, IDoctorDal
    {

    }
}
