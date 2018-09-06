﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projLivrosLista
{
    class Exemplar : Livro
    {
        // Atributos
        private int tompo;
        private List<Emprestimo> emprestimos;

        Exemplar(int tompo):base () { this.tompo = tompo; }

        /* Propriedades
        public int Tompo { get => tompo; set => tompo = value; }
        public List<Emprestimo> Emprestimos { get => emprestimos; set => emprestimos = value; }
        */

        // Métodos

        public bool emprestar() {
            return true;
        }
        public bool devolver()
        {
            return true;
        }
        public bool disponivel()
        {
            return true;
        }
        public int qtdeEmprestimos() {
            return 0;
        }


    }
}
