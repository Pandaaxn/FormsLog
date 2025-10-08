using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;

namespace Forms
{
    internal class Acciones
    {
        private List<string> listanombres = new List<string>();

        public List<string> ObtenerNombres()
        {
            return listanombres;
        }
        public bool AgregarNombre(string nombre)
        {
            try
            {
                listanombres.Add(nombre);
                return true;
            }
            catch (Exception)
            {
                return false;

            }
        }
        public bool EliminarNombre(string nombre)
        {
            try
            {
                if (listanombres.Contains(nombre))
                {
                    listanombres.Remove(nombre);
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool ExportarNombresAExcel(string rutaArchivo)
        {
            try
            {
                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Nombres");
                    worksheet.Cell(1, 1).Value = "Nombre";
                    for (int i = 0; i < listanombres.Count; i++)
                    {
                        worksheet.Cell(i + 2, 1).Value = listanombres[i];
                    }
                    workbook.SaveAs(rutaArchivo);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
