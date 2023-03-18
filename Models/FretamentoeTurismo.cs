using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoI4.Models
{
    public class FretamentoeTurismo
    {
        public int Id {get;set;}
        public string Nome{get;set;}
        public string Email{get;set;}
        public double Celular{get;set;}
        public double Telefone{get;set;}
        public string CidadeOrigem{get;set;}
        public string CidadeDestino{get;set;}
        public string DataIda{get;set;}
        public string DataVolta{get;set;}
        public string Descricao{get;set;}  
    }
}