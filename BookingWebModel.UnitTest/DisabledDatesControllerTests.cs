﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit.Extensions;
using Xunit;
using System.Web.Mvc;
using Ploeh.Samples.Booking.WebUI.Controllers;

namespace Ploeh.Samples.Booking.WebModel.UnitTest
{
    public class DisabledDatesControllerTests
    {
        [Theory, AutoWebData]
        public void SutIsController(DisabledDatesController sut)
        {
            Assert.IsAssignableFrom<IController>(sut);
        }

        [Theory, AutoWebData]
        public void GetReturnsCorrectDataType(DisabledDatesController sut,
            int year,
            int month)
        {
            JsonResult actual = sut.Get(year, month);
            Assert.IsAssignableFrom<string[]>(actual.Data);
        }
    }
}