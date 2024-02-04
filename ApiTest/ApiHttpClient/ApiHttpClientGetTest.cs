using ComprehensiveAutomation.Test.Infra.BaseTest;
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
    public class ApiHttpClientGetTest : BaseTest
    {
        string inJson = "flying";
        string notInJson = "someText";
        [Fact]
        [Trait(Category, TestLevel.Level_1)]
        [Trait(Category, Categories.Api)]

        public async Task _ApiHttpClientGetTest()
        {   
            HttpService m_httpService = new HttpService(
            new HttpServiceOptions { BaseUrl = GetTestData(configDataEnum.BaseApiUrl) });

            var m_responceUserProfile = await m_httpService
                .CallWithoutBody<PokemonTypesDTO>
                    (new HttpCallOptionsSimple("type") 
                    { Method = HttpCallMethod.Get });

            Assert.Equal(HttpStatusCode.OK, m_responceUserProfile.HttpStatus);

            List<PokemonTypeListDTO> resultName = new List<PokemonTypeListDTO>();

            foreach (var item in m_responceUserProfile.Result.Results)
            {
                resultName.Add(new PokemonTypeListDTO
                {
                    Name = item.Name,
                    Url = item.Url
                });
            }


            bool isFlyingPresent = resultName.Any(item => item.Name == inJson);
            bool isNotPresent = resultName.Any(item => item.Name == notInJson);
            //
            Assert.True(isFlyingPresent);
            Assert.False(isNotPresent);
        }
    }

}
