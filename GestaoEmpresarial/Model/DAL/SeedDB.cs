using System.Collections.Generic;
using System.Data.Entity;

namespace Model.DAL
{
    //public class SeedDB : DropCreateDatabaseIfModelChanges<Contexto>
    public class SeedDB : DropCreateDatabaseAlways<Contexto>
    {
        protected override void Seed(Contexto context)
        {
            List<Estado> estados = new List<Estado>()
            {
                new Estado(){ Nome = "Acre", Sigla = "AC" },
                new Estado(){ Nome = "Alagoas", Sigla = "AL" },
                new Estado(){ Nome = "Amapá", Sigla = "AP" },
                new Estado(){ Nome = "Amazonas", Sigla = "AM" },
                new Estado(){ Nome = "Bahia", Sigla = "BA" },
                new Estado(){ Nome = "Ceará", Sigla = "CE" },
                new Estado(){ Nome = "Distrito Federal", Sigla = "DF" },
                new Estado(){ Nome = "Espirito Santo", Sigla = "ES" },
                new Estado(){ Nome = "Goiás", Sigla = "GO" },
                new Estado(){ Nome = "Maranhão", Sigla = "MA" },
                new Estado(){ Nome = "Mato Grosso", Sigla = "MT" },
                new Estado(){ Nome = "Mato Grosso do Sul", Sigla = "MS" },
                new Estado(){ Nome = "Minas Gerais", Sigla = "MG" },
                new Estado(){ Nome = "Pará", Sigla = "PA" },
                new Estado(){ Nome = "Paraíba", Sigla = "PB" },
                new Estado(){ Nome = "Paraná", Sigla = "PR" },
                new Estado(){ Nome = "Pernambuco", Sigla = "PE" },
                new Estado(){ Nome = "Piauí", Sigla = "PI" },
                new Estado(){ Nome = "Rio de Janeiro", Sigla = "RJ" },
                new Estado(){ Nome = "Rio Grande do Norte", Sigla = "RN" },
                new Estado(){ Nome = "Rio Grande do Sul", Sigla = "RS" },
                new Estado(){ Nome = "Rondônia", Sigla = "RO" },
                new Estado(){ Nome = "Roraima", Sigla = "RR" },
                new Estado(){ Nome = "Santa Catarina", Sigla = "SC" },
                new Estado(){ Nome = "São Paulo", Sigla = "SP" },
                new Estado(){ Nome = "Sergipe", Sigla = "SE" },
                new Estado(){ Nome = "Tocantins", Sigla = "TO" },
            };
            context.Estados.AddRange(estados);
            base.Seed(context);
            context.SaveChanges();

            List<Cidade> cidades = new List<Cidade>()
            {
                new Cidade(){ Nome = "Curitiba", EstadoID = 16 },
                new Cidade(){ Nome = "São José dos Pinhais", EstadoID = 16 },
            };
            context.Cidades.AddRange(cidades);
            base.Seed(context);
            context.SaveChanges();
        }
    }
}
