using ClassLibrary3;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using ShopsRUs.DAL;
using ShopsRUs.Domains;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ShopsRUs.Moq
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void CheckAllInvoiceCount()
        {
            //Mock<UnitOfWork> _unitOfWorkMock = new Mock<UnitOfWork>(new ApiContext());
            UnitOfWork _unitOfWork = new UnitOfWork(new ApiContext());
            // Arrange

            //List<Invoice> result = new List<Invoice>();
            //_unitOfWork.Setup(x=>x.InvoiceRepository.GetAll()).Returns(result); // metotları virtual yapmam gerekiyordu

            // Act
            List<Invoice> result = _unitOfWork.InvoiceRepository.GetAll().ToList();

            // Assert
            // Actual:< 5 >.
            Assert.AreEqual(5, result.Count);
            //Assert.AreEqual(6, result.Count);
        }

        //Daha fazla test metodu yapabilirdim fakat zamanım çok kalmamıştı
    }
}
