using System;

namespace Notes
{
    internal class RemoveItem : Item
    {
        Notes notes;
        public RemoveItem(Notes notes) : base("Remove a note")
        {
            this.notes = notes;
            this.ItemAction = RemoveNote;
        }

        private void RemoveNote()
        {
            notes.ShowAll();

            Console.Write("Enter an index of the note: ");

            if (Int32.TryParse(Console.ReadLine(), out int i))
            {
                if (i >= 1 && i <= notes.Count)
                {
                    if(notes.RemoveNote(notes[i - 1]))
                        Console.WriteLine("Deleted...");
                    else
                        Console.WriteLine("This note is not found");
                }
            }
        }

    }
}
