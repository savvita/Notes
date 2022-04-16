using System;

namespace Notes
{
    internal class FindByLabelItem : Item
    {
        Notes notes;
        public FindByLabelItem(Notes notes) : base("Find by label")
        {
            this.notes = notes;
            this.ItemAction = FindByLabel;
        }

        private void FindByLabel()
        {
            Console.Write("Enter a label: ");

            string label = Console.ReadLine();

            var _notes = notes.FindByTitle(label);

            if (_notes.Count != 0)
            {
                int i = 0;
                foreach(Note note in _notes)
                    Console.WriteLine($"{++i}.\n{note}");
            }
            else
                Console.WriteLine("Not found...");

        }

    }
}
