using System.Globalization;
namespace proposto2.dominio {
    class Acessorio {

        //public int codigo { get; set; }
        public string descricao { get; set; }
        public double preco { get; set; }
        public Carro carro { get; set; }

        public Acessorio (string descricao, double preco, Carro carro) {
            //this.codigo = codigo;
            this.descricao = descricao;
            this.preco = preco;
            this.carro = carro;
        }

        public override string ToString() {
            return descricao
                + ", Preço: "
                + preco.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}