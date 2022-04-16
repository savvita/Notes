using System;

namespace Notes
{
    internal class AddItem : Item
    {
        Notes notes;
        public AddItem(Notes notes) : base("Add a note")
        {
            this.notes = notes;
            this.ItemAction = AddNote;
        }

        private void AddNote()
        {
            Console.Write("Enter a title: ");
            string title = Console.ReadLine();

            Console.Write("Enter a label: ");
            string label = Console.ReadLine();

            Console.Write("Enter a text: ");
            string text = Console.ReadLine();

            if (notes.AddNote(new Note(title, text, label)))
                Console.WriteLine("Added...");
            else
                Console.WriteLine("This note is already at the notes");
        }

    }
}
