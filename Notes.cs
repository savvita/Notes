using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Notes
{
    internal class Notes
    {
        List<Note> notes;

        public int Count
        {
            get { return notes.Count; }
        }


        public Notes()
        {
            notes = new List<Note>();
            Load();
        }

        public bool AddNote(Note note)
        {
            if (!IsContains(note))
            {
                notes.Add(note);
                return true;
            }
            else
                return false;
        }

        public bool RemoveNote(Note note) => notes.Remove(notes.Find((item) => item.IsEqual(note)));

        public bool Edit(Note note, string newTitle, string newText, string newLabel)
        {
            Note _note = notes.Find((item) => item.IsEqual(note));

            if (_note == null)
                return false;

            _note.Title = newTitle;
            _note.Text = newText;
            _note.Label = newLabel;

            return true;
        }

        public List<Note> FindByTitle(string title) => notes.FindAll(note => note.Title == title);
        public List<Note> FindByLabel(string label) => notes.FindAll(note => note.Label == label);
        public List<Note> FindByDate(DateTime date) => notes.FindAll(note => note.AddingDate.Date == date);

        public bool IsContains(Note note) => notes.Find((item) => item.IsEqual(note)) != null;

        public void ShowAll()
        {
            int i = 0;

            foreach(Note note in notes)
            {
                Console.WriteLine($"{++i}.\n{note}");
                Console.WriteLine(new String('=', 20));
            }
        }

        public Note this[int index]
        {
            get
            {
                return notes[index];
            }
        }

        public void Save(string path = "notes.txt")
        {
            StringBuilder sb = new StringBuilder();

            foreach (var note in notes)
                sb.Append(note + "\n");

            File.WriteAllText(path, sb.ToString());
        }

        public void Load(string path = "notes.txt")
        {
            if (!File.Exists(path))
                return;

            notes.Clear();

            string[] lines = File.ReadAllLines(path);

            int i = 0;

            while(i < lines.Length)
            {
                int idx = lines[i].IndexOf(':');

                string title = GetProperty(lines[i], ref i);

                DateTime dt = Convert.ToDateTime(lines[i].Substring(idx + 2));

                i++;

                notes.Add(new Note(title, "", "", dt));

                notes[notes.Count - 1].Label = GetProperty(lines[i], ref i);
                
                notes[notes.Count - 1].Text = lines[i++];
            }
        }

        private static string GetProperty(string str, ref int idx)
        {
            int i = str.IndexOf(':');
            idx++;

            return str.Substring(i + 2);
        }

    }
}
