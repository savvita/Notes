using System;

namespace Notes
{
    internal class Note
    {
        public string Label { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }

        public DateTime AddingDate { get; private set; }

        public Note(string title, string text, string label = "Undefined") : this(title,text, label, DateTime.Now)
        {
        }

        public Note(string title, string text, string label, DateTime addingTime)
        {
            Title = title;
            Text = text;
            Label = label;
            AddingDate = addingTime;
        }

        public override string ToString() => String.Format("Title: {0}\nAdded: {1}\nLabel: {2}\n{3}", Title, AddingDate, Label, Text);

        public bool IsEqual(Note note) => Title == note.Title && Text == note.Text && Label == note.Label;

    }
}
