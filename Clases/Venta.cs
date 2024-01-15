using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    internal class Venta
    {
        private int _id;
        private string _comentario;
        private int _idUsuario;

        public Venta(int id, string comentario, int idUsuario)
        {
            this._id = id;
            this._comentario = comentario;
            this._idUsuario = idUsuario;
        }

        public int Id { get { return this._id; } set { this._id = value; } }
        public string Comentario { get { return this._comentario; } set { this._comentario = value; } }
        public int IdUsuario { get { return this._idUsuario; } set { this._idUsuario = value; } }
    }
}
