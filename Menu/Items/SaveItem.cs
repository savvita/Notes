using System;

namespace Notes
{
    internal class SaveItem : Item
    {
        Notes notes;
        public SaveItem(Notes notes) : base("Save")
        {
            this.notes = notes;
            this.ItemAction = Save;
        }

        private void Save()
        {
            notes.Save();
            Console.WriteLine("Saved...");
        }

    }
}
