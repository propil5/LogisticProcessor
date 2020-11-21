using LogisticProcessor.DataAccess.Dao;
using LogisticProcessor.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticProcessor.Test.DataAcess.Dao
{
    [TestFixture]
    public class AddressDtoTest
    {
        private AddressDao _addressDao;

        [SetUp]
        public void SetUp()
        {
            var context = new DbContext();
            _addressDao = new AddressDao();
        }

        [Test]
        public void CanAddAddress()
        {
            var newAddress = new AddressDto
            {
                
            }
            var add = _addressDao.Add()
            var sut = _addressDao.Get();
            Assert.IsNotNull(sut);
            Assert.IsTrue(sut.Any());
        }

        [Test]
        public void CanGetAddress()
        {

        }

        [Test]
        public void CanUpdateAddress()
        {

        }

        [Test]
        public void CanDeleteAddress()
        {

        }
    }

    //Base CRUD Test
    //[SetUp]
    //public void SetUp()
    //{

    //}

    //[Test]
    //public void CanAddAddress()
    //{

    //}

    //[Test]
    //public void CanGetAddress()
    //{

    //}

    //[Test]
    //public void CanUpdateAddress()
    //{

    //}

    //[Test]
    //public void CanDeleteAddress()
    //{

    //}

}
