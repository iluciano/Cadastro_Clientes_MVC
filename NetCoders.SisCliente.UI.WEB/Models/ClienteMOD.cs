﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NetCoders.SisCliente.UI.WEB.Models
{
    [Table("TB_CLIENTE")]
    public class ClienteMOD
    {
        [Key]
        public int Codigo { get; set; }

        //O Data Anottations Required, Serve pra dizer que a minha propriedade
        //è obrigatória.
        [Required(ErrorMessage = "Campo nome não pode ser vazio.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo e-mail não pode ser vazio."), EmailAddress]
        //O Data Annotations EmailAddress serve para dizer que a minha
        //Propriedade é um Email, ou seja, ele vai fazer uma verficação
        //simples, se o campo é um email
        public string Email { get; set; }
    }
}