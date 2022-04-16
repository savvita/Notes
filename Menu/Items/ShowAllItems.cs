namespace Notes
{
    internal class ShowAllItems : Item
    {
        Notes notes;
        public ShowAllItems(Notes notes) : base("Show all notes")
        {
            this.notes = notes;
            this.ItemAction = ShowAll;
        }

        private void ShowAll() => notes.ShowAll();
    }
}
