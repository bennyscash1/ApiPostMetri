/*using ComprehensiveAutomation.Test.Infra.BaseTest;
using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks;
using Refit;
using static ComprehensiveAutomation.Test.Infra.BaseTest.EnumList;
using Xunit;
using ComprehensiveAutomation.Test.ExternalApiTests.GenerateApiUserTokenTest;
using System.Net;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using ComprehensiveAutomation.Infra.HttpService;

namespace ComprehensiveAutomation.ApiTest.ApiInit
{
    public class ApiHttpClientPostTest : BaseTest
    {

        [Fact]
        [Trait(Category, TestLevel.Level_1)]
        [Trait(Category, Categories.Api)]

        public async Task _ApiHttpClientPostTest()
        {
            string i_token = "example token";
            string email = GetTestData(configDataEnum.ApiEmail);
            string passworr = GetTestData(configDataEnum.ApiPassword);

            var m_serviceOtpValidate = new HttpService(
                new HttpServiceOptions { BaseUrl = GetTestData(configDataEnum.BaseApiUrl) });
            var loginRequest = new RegisterInputDTO
            {
                email = email,
                password = passworr
            };
            var responsevalidateOtp = await m_serviceOtpValidate
                .CallWithBody<RegisterInputDTO, RegisterOutputDTO>
              (loginRequest, new HttpCallOptionsBody("/api/register", i_token));
            Assert.Equal(HttpStatusCode.OK, responsevalidateOtp.HttpStatus);
            int userId = responsevalidateOtp.Result.id;
            string token= responsevalidateOtp.Result.token;

        }
    }

}
*/