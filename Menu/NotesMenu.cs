namespace Notes
{
    internal class NotesMenu : Item
    {
        public NotesMenu(Notes notes) : base("Notes manager")
        {
            Items.Add(new ShowAllItems(notes));
            Items.Add(new AddItem(notes));
            Items.Add(new RemoveItem(notes));
            Items.Add(new EditItem(notes));
            Items.Add(new FindItem(notes));
            Items.Add(new SaveItem(notes));
        }
        public new void Show() => new Menu(this).Show();
    }
}
