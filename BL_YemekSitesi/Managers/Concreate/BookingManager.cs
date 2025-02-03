using Base_Model.Model.Entities;
using BL_YemekSitesi.Managers.Abstract;
using DAL_YemekSitesi.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_YemekSitesi.Managers.Concreate
{
    public class BookingManager : IBookingManager
    {
        private readonly IBookingRepository _bookingRepository; // booking yap

        public BookingManager(IBookingRepository bookingRepository)
        {
            _bookingRepository = bookingRepository;
        }

        public List<Booking> TGetListAll()
        {
            return _bookingRepository.GetListAll();
        }

        public Booking TGetByID(int id)
        {
            return _bookingRepository.GetByID(id);
        }

        public void TAdd(Booking entity)
        {
            _bookingRepository.Add(entity);
        }

        public void TDelete(Booking entity)
        {
            _bookingRepository.Delete(entity);
        }

       
       

        public void TUpdate(Booking entity)
        {
            _bookingRepository.Update(entity);
        }
    }
}
