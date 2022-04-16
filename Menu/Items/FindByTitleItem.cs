using System;

namespace Notes
{
    internal class FindByTitleItem : Item
    {
        Notes notes;
        public FindByTitleItem(Notes notes) : base("Find by title")
        {
            this.notes = notes;
            this.ItemAction = FindByTitle;
        }

        private void FindByTitle()
        {
            Console.Write("Enter a title: ");

            string title = Console.ReadLine();

            var _notes = notes.FindByTitle(title);

            if (_notes.Count != 0)
            {
                int i = 0;
                foreach (Note note in _notes)
                    Console.WriteLine($"{++i}.\n{note}");
            }
            else
                Console.WriteLine("Not found...");
        }

    }
}
