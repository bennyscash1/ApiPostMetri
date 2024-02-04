using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComprehensiveAutomation.Test.ExternalApiTests.GenerateApiUserTokenTest
{
    public class RegisterInputDTO
    {
        public string email { get; set; }
        public string password { get; set; }
    }



    public class PokemonTypesDTO
    {
        public int Count { get; set; }
        public string Next { get; set; }
        public string Previous { get; set; }
        public List<PokemonTypeListDTO> Results { get; set; }

    }
    public class PokemonTypeListDTO
    {
        public string Name { get; set; }
        public string Url { get; set; }
    }

}
