﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_FactoryMethod
{
    class Program
    {
        static void Main()
        {
            Documento[] D = new Documento[2];
            D[0] = new Curriculo();
            D[1] = new Relatorio();

            foreach(Documento doc in D)
            {
                Console.WriteLine("\n --" + doc.GetType().Name + "--");
                foreach (Pagina pg in doc.Paginas)
                {
                    pg.exibirPagina();
                }
            }


            // Note: constructors call Factory Method
            //Document[] documents = new Document[2];
            //documents[0] = new Resume();
            //documents[1] = new Report();



            //Display document pages
            //foreach (Document document in documents)
            //{
            //    Console.WriteLine("\n" + document.GetType().Name + "--");
            //    foreach (Page page in document.Pages)
            //    {
            //        Console.WriteLine(" " + page.GetType().Name);
            //    }
            //}

            // Wait for user
            Console.ReadKey();
        }
}



    /// <summary>
    /// The 'Product' abstract class
    /// </summary>
    abstract class Page
    {

    }

    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    class SkillsPage : Page
    {

    }

    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    class EducationPage : Page
    {

    }


    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    class ExperiencePage : Page
    {

    }


    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    class IntroductionPage : Page
    {

    }


    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    class ResultsPage : Page
    {

    }


    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    class ConclusionPage : Page
    {

    }


    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    class SummaryPage : Page
    {

    }


    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    class BibliographyPage : Page
    {

    }


    /// <summary>
    /// The 'Creator' abstract class
    /// </summary>
    abstract class Document
    {
        private List<Page> _pages = new List<Page>();

        // Constructor calls abstract Factory method
        public Document()
        {
            this.CreatePages();
        }

        public List<Page> Pages
        {
            get { return _pages; }
        }


        // Factory Method
        public abstract void CreatePages();
    }

    /// <summary>
    /// A 'ConcreteCreator' class
    /// </summary>
    class Resume : Document
    {
        // Factory Method implementation
        public override void CreatePages()
        {
            Pages.Add(new SkillsPage());
            Pages.Add(new EducationPage());
            Pages.Add(new ExperiencePage());
        }
    }

    /// <summary>
    /// A 'ConcreteCreator' class
    /// </summary>
    class Report : Document
    {
       // Factory Method implementation
        public override void CreatePages()
        {
            Pages.Add(new IntroductionPage());
            Pages.Add(new ResultsPage());
            Pages.Add(new ConclusionPage());
            Pages.Add(new SummaryPage());
            Pages.Add(new BibliographyPage());
        }
    }

}