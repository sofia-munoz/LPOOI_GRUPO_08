﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClaseBase
{
    public class Producto
    {
        private string prod_Codigo;

        public string Prod_Codigo
        {
            get { return prod_Codigo; }
            set { prod_Codigo = value; }
        }
        private string prod_Categoria;

        public string Prod_Categoria
        {
            get { return prod_Categoria; }
            set { prod_Categoria = value; }
        }

        private string prod_Descripcion;

        public string Prod_Descripcion
        {
            get { return prod_Descripcion; }
            set { prod_Descripcion = value; }
        }

        private decimal prod_Precio;

        public decimal Prod_Precio
        {
            get { return prod_Precio; }
            set { prod_Precio = value; }
        }
    }
}
