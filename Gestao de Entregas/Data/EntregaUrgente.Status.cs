﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Gestao_de_Entregas.Data
{
    public class EntregaUrgenteStatus
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public EntregaUrgente EntregaUrgente { get; set; }

        [Required]
        public string Observacao { get; set; }

        [Required]
        public ApplicationUser Usuario { get; set; }

        [Required]
        public DateTime DataStatus { get; set; }
    }
}