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
    public class ContactManager : IContactManager
    {
        private readonly IContactRepository _contactRepository;

        public ContactManager(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }
        public List<Contact> TGetListAll()
        {
            return _contactRepository.GetListAll();
        }
        public Contact TGetByID(int id)
        {
            return _contactRepository.GetByID(id);
        }


        public void TAdd(Contact entity)
        {
            _contactRepository.Add(entity);
        }

        public void TDelete(Contact entity)
        {
            _contactRepository.Delete(entity);
        }

        public void TUpdate(Contact entity)
        {
            _contactRepository.Update(entity);
        }
    }
}
