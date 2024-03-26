using System;
using System.Collections.Generic;
using System.Ling;
using System.Threading.Tasks;

namespace _210325_01.ModeLs
{
    public class Atendimento
    {
       public int Id {get; set; }
       public DateTime DataAtendimento {get; set; }
       public Animal Animal {get; set; }
       public Veterinario Veterinario {get; set; }
       public string Observacao {get; set; }


    
    }
}
