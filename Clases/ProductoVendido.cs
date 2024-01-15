﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    internal class ProductoVendido
    {
        private int _id;
        private int _idProducto;
        private int _stock;
        private int _idVenta;

        public ProductoVendido(int id, int idProducto, int stock, int idVenta)
        {
            this._id = id;
            this._idProducto = idProducto;
            this._stock = stock;
            this._idVenta = idVenta;
        }

        public int Id { get { return this._id; } set { this._id = value; } }
        public int IdProducto { get { return this._idProducto; } set { this._idProducto = value; } }
        public int Stock { get { return this._stock; } set { this._stock = value; } }
        public int IdVenta { get { return this._idVenta; } set { this._idVenta = value; } }
    }
}
