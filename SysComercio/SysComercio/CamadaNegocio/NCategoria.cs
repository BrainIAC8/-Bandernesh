using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaDados;
using System.Data;

namespace CamadaNegocio
{
    public class NCategoria
    {

        // Método Inserir
        public static string Inserir(string nome, string descricao)
        {
            DCategoria obj = new CamadaDados.DCategoria();
            obj.Nome = nome;
            obj.Descricao = descricao;
            return obj.Inserir(obj);
        }

        // Método Editar
        public static string Editar(int idcategoria, string nome, string descricao)
        {
            DCategoria obj = new CamadaDados.DCategoria();
            obj.Idcategoria = idcategoria;
            obj.Nome = nome;
            obj.Descricao = descricao;
            return obj.Editar(obj);
        }

        // Método Deletar
        public static string Excluir(int idcategoria)
        {
            DCategoria obj = new CamadaDados.DCategoria();
            obj.Idcategoria = idcategoria;
            return obj.Excluir(obj);
        }

        // Método Mostrar
        public static DataTable Mostrar(string textobuscar)
        {
            DCategoria obj = new DCategoria();
            obj.TextoBuscar = textobuscar;
            return new DCategoria().Mostrar();
        }

        // Método Buscar
        public static DataTable BuscarNome(string textobuscar)
        {
            DCategoria obj = new DCategoria();
            obj.TextoBuscar = textobuscar;
            return obj.BuscarNome(obj);
        }
    }
}
