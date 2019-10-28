﻿
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EditoraAPI.Models
{
    public class Compra
    {
        [Key] public int ID_Compra { get; set; }
        [Required] public float Total_Pag { get; set;}
        [Required] public DateTime DataPag { get; set; }
        public List<Cliente> clientes { get; set; }
        public List<Tipo> tipos { get; set; }
    }
}