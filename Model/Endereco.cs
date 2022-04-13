using Newtonsoft.Json;

namespace ProjAndreAirLinesAPI_V2._0.Model
{
    public class Endereco
    {
        public int Id { get; set; }

        [JsonProperty("bairro")]
        public string Bairro { get; set; }

        [JsonProperty("localidade")]
        public string Cidade { get; set; }
        public string Pais { get; set; }

        [JsonProperty("cep")]
        public string Cep { get; set; }

        [JsonProperty("logradouro")]
        public string Rua { get; set; }

        [JsonProperty("uf")]
        public string Estado { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }

        public Endereco(string bairro, string cidade, string pais, string cep, string rua, string estado, int numero, string complemento)
        {
            Bairro = bairro;
            Cidade = cidade;
            Pais = pais;
            Cep = cep;
            Rua = rua;
            Estado = estado;
            Numero = numero;
            Complemento = complemento;
        }

    }
}
