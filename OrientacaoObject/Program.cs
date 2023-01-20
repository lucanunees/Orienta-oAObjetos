using Orientacao.ContentContext;
using Orientacao.ContentContext.Enums;
using System;

namespace OrientacaoObject
{
     class Program
    {
        static void Main(string[] args)
        {
            var articles = new List<Article>();
            // Criando um objeto e passando já os valores:

            articles.Add(new Article("Artigo sobre OOP", "Orientacao-objeto"));
            articles.Add(new Article("Artigo sobre CSharp", "Linguagem CSharp"));
            articles.Add(new Article("Artigo sobre .NET", "Framework"));

            //Percorrendo a lista de articles através do foreach.
            foreach(var article in articles)
            {
                //Console.WriteLine(article.Id);
                //Console.WriteLine(article.Title);
                //Console.WriteLine(article.Url);
            }

            //Criando o curso.
            var courseOOP = new Course("Fundamentos OOP", "Fundamentos OOP", EContentLevel.Fundamental) ;
            var courseCSharp = new Course("Fundamentos CSharp", "Linguagem CSharp", EContentLevel.Fundamental);
            var courseAspNet = new Course("Fundamentos .NET", "Framework", EContentLevel.Fundamental);

            // Criando a lista de cursos.
            var courses = new List<Course>();
            courses.Add(courseOOP);
            courses.Add(courseCSharp);
            courses.Add(courseAspNet);

            if(courseOOP.IsInvalid) 
            Console.WriteLine($"{courseOOP.Title} está invalido");

            // Criando uma lista de Carreiras:
            var careers = new List<Career>();

            // Criando uma Career com esses cursos.
            var careerDotnet = new Career("Especialista .Net", "Especialista-dotnet");
            var careerItem2 = new CareerItem(1,"Aprenda OOP", "Descrição", courseOOP);
            var careerItem = new CareerItem(3,"Comece por aqui", "Descrição", courseCSharp);
            var careerItem3 = new CareerItem(2,"Aprenda .NET", "Descrição", courseAspNet);

            careerDotnet.Items.Add(careerItem2);
            careerDotnet.Items.Add(careerItem3);
            careerDotnet.Items.Add(careerItem);
            careers.Add(careerDotnet);

            foreach (var career in careers)
            {
                Console.WriteLine(career.Title);

                foreach (var item in career.Items.OrderBy(x => x.Order))
                {
                    Console.WriteLine($"ID do curso: {item.Order} Titulo do curso: {item.Title}");
                    Console.WriteLine($"Titulo do curso: {item.Course.Title}");
                    Console.WriteLine($"Nivel do curso: {item.Course.Level}");

                    foreach(var notification in item.Notifications)
                    {
                     Console.WriteLine($"{notification.Property} - {notification.Message}");
                    }



                }
                Console.ReadLine();
            }

        }
    }
}