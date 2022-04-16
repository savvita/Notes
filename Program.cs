using System;
namespace Notes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NotesMenu menu = new NotesMenu(new Notes());
            menu.Show();

            //System.Console.WriteLine(DateTime.Now.Date);

            //string date = "12/3/2022";
            //Console.WriteLine(Convert.ToDateTime(date));
        }

    }
}
