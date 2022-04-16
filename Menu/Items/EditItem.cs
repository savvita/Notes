using System;

namespace Notes
{
    internal class EditItem : Item
    {
        Notes notes;
        public EditItem(Notes notes) : base("Edit a note")
        {
            this.notes = notes;
            this.ItemAction = EditNote;
        }

        private void EditNote()
        {
            notes.ShowAll();

            Console.Write("Enter an index of the note: ");

            if (Int32.TryParse(Console.ReadLine(), out int i))
            {
                if (i >= 1 && i <= notes.Count)
                {
                    Console.Write("Enter a title: ");
                    string title = Console.ReadLine();

                    Console.Write("Enter a label: ");
                    string label = Console.ReadLine();

                    Console.Write("Enter a text: ");
                    string text = Console.ReadLine();

                    notes.Edit(notes[i - 1], title, text, label);

                    Console.WriteLine("Edited...");
                }
            }
        }

    }
}
