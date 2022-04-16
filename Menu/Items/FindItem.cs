namespace Notes
{
    internal class FindItem : Item
    {
        public FindItem(Notes notes) : base("Find")
        {
            Items.Add(new FindByTitleItem(notes));
            Items.Add(new FindByLabelItem(notes));
            Items.Add(new FindByDateItem(notes));

            this.ItemAction = null;
        }
    }
}
