﻿using Microsoft.AspNetCore.Identity;
using SistemaAc.Data;
using SistemaAc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaAc.ModelCategorias
{
    public class CursoModels
    {
        private ApplicationDbContext context;
        private List<IdentityError> errorList = new List<IdentityError>();
        private string code = "", des = "";
        private Boolean estados;
        public CursoModels(ApplicationDbContext context)
        {
            this.context = context;
        }

        internal List<Categoria> getCategorias()
        {
            return context.Categoria.Where(c => c.Estado == true).ToList();
        }

        internal List<IdentityError> agregarCurso(int id, string nombre, string descripcion, byte creditos, byte horas, decimal costo, bool estado, int categoria, string funcion)
        {
            var curso = new Curso
            {
                Nombre = nombre,
                Descripcion = descripcion,
                Creditos = creditos,
                Horas = horas,
                Costo = costo,
                Estado = estado,
                CategoriaID = categoria,
            };
            try
            {
                context.Add(curso);
                context.SaveChanges();
                code = "Save";
                des = "Save";
            }
            catch (Exception e)
            {

                code = "error";
                des = e.Message;
            }
            errorList.Add(new IdentityError
            {
                Code = code,
                Description = des
            });
            return errorList;
        }

        public List<Curso> getCursos(int id)
        {
            return context.Curso.Where(c => c.CursoID == id).ToList();
        }


        public List<IdentityError> editarCurso(int id, string nombre, string descripcion, byte creditos, byte horas, decimal costo, Boolean estado, int categoriaID, int funcion)
        {
            switch (funcion)
            {
                case 0:
                    if (estado)
                    {
                        estados = false;
                    }
                    else
                    {
                        estados = true;
                    }

                    break;
                case 1:
                    estados = estado;
                    break;
            }
            var curso = new Curso
            {
                CursoID = id,
                Nombre = nombre,
                Descripcion = descripcion,
                Creditos = creditos,
                Horas = horas,
                Costo = costo,
                Estado = estados,
                CategoriaID = categoriaID,
            };
            try
            {
                context.Update(curso);
                context.SaveChanges();
                code = "Save";
                des = "Save";
            }
            catch (Exception ex)
            {
                code = "error";
                des = ex.Message;
            }
            errorList.Add(new IdentityError
            {
                Code = code,
                Description = des
            });

            return errorList;
        }

        public List<Categoria> getCategoria(int id)
        {
            return context.Categoria.Where(c => c.CategoriaID == id).ToList();
        }

        internal List<object[]> filtrarCurso(int numPagina, string valor, string order)
        {
            int cant, numRegistros = 0, inicio = 0, reg_por_pagina = 2;
            int can_paginas, pagina;
            string dataFilter = "", paginador = "", Estado = null;
            List<object[]> data = new List<object[]>();
            IEnumerable<Curso> query;
            List<Curso> cursos = null;
            switch (order)
            {
                case "nombre":
                    cursos = context.Curso.OrderBy(c => c.Nombre).ToList();
                    break;
                case "des":
                    cursos = context.Curso.OrderBy(c => c.Descripcion).ToList();
                    break;
                case "creditos":
                    cursos = context.Curso.OrderBy(c => c.Creditos).ToList();
                    break;
                case "horas":
                    cursos = context.Curso.OrderBy(c => c.Horas).ToList();
                    break;
                case "costo":
                    cursos = context.Curso.OrderBy(c => c.Costo).ToList();
                    break;
                case "estado":
                    cursos = context.Curso.OrderBy(c => c.Estado).ToList();
                    break;
                case "categoria":
                    cursos = context.Curso.OrderBy(c => c.Categoria).ToList();
                    break;

            }
            numRegistros = cursos.Count;
            inicio = (numPagina - 1) * reg_por_pagina;
            can_paginas = (numRegistros / reg_por_pagina);
            if (valor == "null")
            {
                query = cursos.Skip(inicio).Take(reg_por_pagina);
            }
            else
            {
                query = cursos.Where(c => c.Nombre.StartsWith(valor) || c.Descripcion.StartsWith(valor)).Skip(inicio).Take(reg_por_pagina);
            }
            cant = query.Count();
            foreach (var item in query)
            {
                var categoria = getCategoria(item.CategoriaID);
                if (item.Estado == true)
                {
                    Estado = "<a data-toggle='modal' data-target='#ModalEstadoCurso' onclick='editarEstadoCurso(" + item.CursoID + ',' + 0 + ")' class='btn btn-success'>Activo</a>";
                }
                else
                {
                    Estado = "<a data-toggle='modal' data-target='#ModalEstadoCurso' onclick='editarEstadoCurso(" + item.CursoID + ',' + 0 + ")' class='btn btn-danger'>No activo</a>";
                }
                dataFilter += "<tr>" +
                    "<td>" + item.Nombre + "</td>" +
                    "<td>" + item.Descripcion + "</td>" +
                    "<td>" + item.Creditos + "</td>" +
                    "<td>" + item.Horas + "</td>" +
                    "<td>" + item.Costo + "</td>" +
                    "<td>" + Estado + " </td>" +
                    "<td>" + categoria[0].Nombre + "</td>" +
                    "<td>" +
                    "<a data-toggle='modal' data-target='#modalCS' onclick='editarEstadoCurso(" + item.CursoID + ',' + 1 + ")'  class='btn btn-success'>Edit</a>" +
                    "</td>" +
                "</tr>";

            }
            if (valor == "null")
            {
                if (numPagina > 1)
                {
                    pagina = numPagina - 1;
                    paginador += "<a class='btn btn-default' onclick='filtrarCurso(" + 1 + ',' + '"' + order + '"' + ")'> << </a>" +
                    "<a class='btn btn-default' onclick='filtrarCurso(" + pagina + ',' + '"' + order + '"' + ")'> < </a>";
                }
                if (1 < can_paginas)
                {
                    paginador += "<strong class='btn btn-success'>" + numPagina + ".de." + can_paginas + "</strong>";
                }
                if (numPagina < can_paginas)
                {
                    pagina = numPagina + 1;
                    paginador += "<a class='btn btn-default' onclick='filtrarCurso(" + pagina + ',' + '"' + order + '"' + ")'>  > </a>" +
                                 "<a class='btn btn-default' onclick='filtrarCurso(" + can_paginas + ',' + '"' + order + '"' + ")'> >> </a>";
                }
            }
            object[] dataObj = { dataFilter, paginador };
            data.Add(dataObj);
            return data;
        }
    }
}
