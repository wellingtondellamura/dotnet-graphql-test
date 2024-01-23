namespace GraphQLCourses.Services
{
    using Microsoft.VisualBasic.FileIO;
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using GraphQLCourses.Models;

    public class CourseService
    {

        
        private static List<Course>? _courses;

        public CourseService()
        {
            if (_courses ==null)
             _courses = LoadDataFromCSV("data/courses.csv");
        }

        public List<Course> GetCourses()
        {
            if (_courses == null)
                throw new Exception("Courses not loaded");
            return _courses;
        }

        private List<Course> LoadDataFromCSV(string filePath)
        {
            List<Course> courses = new List<Course>();

            using (TextFieldParser parser = new TextFieldParser(filePath))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(";");

                // Ignorar a linha de cabeçalho
                parser.ReadLine();

                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();
                    courses.Add(MapToCourse(fields));
                }
            }

            return courses;
        }

        private Course MapToCourse(string[] fields)
        {
            Course course = new Course
            {
                ID = int.Parse(fields[0]),
                Descricao = fields[1],
                DescricaoHistorico = fields[2],
                CodigoCensup = fields[3],
                CodigoEmec = fields[4],
                CodigoSistec = fields[5],
                CodigoEducacenso = fields[6],
                AnoLetivo = int.Parse(fields[7]),
                PeriodoLetivo = int.Parse(fields[8]),
                DataInicio = fields[9],
                DataFim = fields[10],
                Ativo = fields[11].Equals("Sim", StringComparison.OrdinalIgnoreCase),
                PossuiAlunoCursando = fields[12].Equals("Sim", StringComparison.OrdinalIgnoreCase),
                Codigo = int.Parse(fields[13]),
                NaturezaParticipacao = fields[14],
                Modalidade = fields[15],
                Area = fields[16],
                Eixo = fields[17],
                AreaCapes = fields[18],
                Periodicidade = fields[19],
                ExigeEnade = fields[20].Equals("Sim", StringComparison.OrdinalIgnoreCase),
                ExigeColacaoGrau = fields[21].Equals("Sim", StringComparison.OrdinalIgnoreCase),
                EmiteDiploma = fields[22].Equals("Sim", StringComparison.OrdinalIgnoreCase),
                AreaConcentracao = fields[23],
                Programa = fields[24],
                Diretoria = fields[25],
                Extensao = fields[26],
                Coordenador = fields[27],
                NumeroPortariaCoordenador = fields[28],
                TituloCertificadoMasculino = fields[29],
                TituloCertificadoFeminino = fields[30],
                Matrizes = fields[31]
            };

            return course;
        }
    }

}

