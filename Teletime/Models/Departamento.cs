﻿using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Teletime.Models
{
    public class Departamento
    {
        public Departamento()
        {
            Funcionarios = new List<Funcionario>();
        }

        public int IdDepartamento
        {
            get;
            set;
        }

        [DisplayName("Departamento")]
        public string NomeDepartamento
        {
            get;
            set;
        }

        public virtual ICollection<Funcionario> Funcionarios
        {
            get;
            set;
        }
    }
}
