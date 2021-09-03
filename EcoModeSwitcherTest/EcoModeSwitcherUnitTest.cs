using System;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using EcoModeSwitcher;
using EcoModeSwitcher.Services;
using EcoModeSwitcher.Interfaces;
using System.Collections.Generic;

namespace EcoModeSwitcherTest
{
    [TestClass]
    public class EcoModeSwitcherUnitTest
    {
        Publisher publisher;
        EmailService emailService;
        BuildingManagementService buildingManagementService;
        DatabaseService databaseService;


        [TestInitialize]
        public void Initialize()
        {
            var loggerMock = new Mock<ILogger<Publisher>>();
            ILogger<Publisher> logger = loggerMock.Object;

            LockerSystemManager lockerSystem = new LockerSystemManager();

            publisher = new Publisher(logger,lockerSystem);
            emailService = new EmailService();
            databaseService = new DatabaseService();
            buildingManagementService = new BuildingManagementService();

        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Publisher_Register_Method_Gets_Null_Throws_Exception()
        {
            publisher.Register(null);

        }

    }
}
