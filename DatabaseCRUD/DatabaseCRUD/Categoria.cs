using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseCRUD
{
    internal class Categoria
    {
        public int Id { get; set; }
        public string Denominazione { get; set; }
        public string? Descrizione { get; set; } = string.Empty;

        public override string ToString()
        {
            return $"{{{nameof(Id)}={Id.ToString()}, {nameof(Denominazione)}={Denominazione}, {nameof(Descrizione)}={Descrizione}}}";
        }
    }
}