using QuickBuy.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;

namespace QuickBuy.Dominio.Entidades
{
    public class Pedido
    {
        public int Id { get; set; }

        public DateTime DataPedido { get; set; }

        public int UsuarioId { get; set; }

        public DateTime DataPrevisaoEntrega { get; set; }

        public string CEP { get; set; }

        public string Estado { get; set; }

        public string Cidade { get; set; }
        
        public string EnderecoCompleto { get; set; }

        public int NumeroEndereco { get; set; }

        public int FormPagamentoID { get; set; }

        public FormaPagamento FormaPagemento { get; set; }


        /// <summary>
        /// um pedido deve ter pelo menos um pedido ou muitos pedidos
        /// </summary>
        public ICollection <ItemPedido> ItemPedido { get; set; }
    }
}
