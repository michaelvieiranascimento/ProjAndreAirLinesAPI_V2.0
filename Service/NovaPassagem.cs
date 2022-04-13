using System.Threading.Tasks;
using ProjAndreAirLinesAPI_V2._0.Model;

namespace ProjAndreAirLinesAPI_V2._0.Service
{
    public class NovaPassagem
    {
        {
        //private static readonly AndreAirlinesAPI2_0Context _context = _context;

        public static async Task<Passagem> ReturnPriceTicket(Passagem passagem, AndreAirlinesAPI2_0Context _context, PrecoBase precoBase)
        {
            decimal preco;
            double porcentagem = 0;

            var Precobase = await _context.PrecoBase.Where(Precobase =>
                                                                       Precobase.Origem == passagem.voo.Origem &&
                                                                       Precobase.Destino == passagem.voo.Destino &&
                                                                       Precobase.Class.Id == passagem.Class.Id)
                                                    .OrderByDescending(Precobase => Precobase.DataInclusao)
                                                    .FirstOrDefaultAsync();
            porcentagem = Precobase.PorcentagemPromocao;

            if (precoBase.Class.Id == 4)
            {
                preco = PrecoBase.preco;
                passagem.Preco = preco;
                return passagem;
            }
            else
            {
                preco = PrecoBase.Preco - (PrecoBase.preco * ((decimal)porcentagem / 100));
                passagem.Preco = preco;
                return passagem;

            }
        }
    }
}
