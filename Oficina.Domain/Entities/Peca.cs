﻿namespace OficinaOS.Domain.Entities
{
    public class Peca : Entity
    {
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public string Marca { get; set; }
        public decimal ValorUnitario { get; set; }
    }
}
