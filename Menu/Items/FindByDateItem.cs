using System;

namespace Notes
{
    internal class FindByDateItem : Item
    {
        Notes notes;
        public FindByDateItem(Notes notes) : base("Find by date")
        {
            this.notes = notes;
            this.ItemAction = FindByDate;
        }

        private void FindByDate()
        {
            Console.Write("Enter a date (dd/mm/yyyy): ");

            string date = Console.ReadLine();

            try
            {
                var _notes = notes.FindByDate(Convert.ToDateTime(date));

                if (_notes.Count != 0)
                {
                    int i = 0;
                    foreach (Note note in _notes)
                        Console.WriteLine($"{++i}.\n{note}");
                }
                else
                    Console.WriteLine("Not found...");
            }
            catch (FormatException)
            {
                Console.WriteLine("Data was in incorrect format...");
            }
            
        }

    }
}
