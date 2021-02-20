using System;

namespace DIO.Series
{
    public class Serie : entityBase
    {

		private Genre Genre { get; set; }
		private string Title { get; set; }
		private string Description { get; set; }
		private int Year { get; set; }
        private bool Delete {get; set;}

		public Serie(int id, Genre genre, string title, string description, int year)
		{
			this.Id = id;
			this.Genre = genre;
			this.Title = title;
			this.Description = description;
			this.Year = year;
            this.Delete = false;
		}

        public override string ToString()
		{
		
            string back = "";
            back += "Genre: " + this.Genre + Environment.NewLine;
            back += "Title: " + this.Title + Environment.NewLine;
            back += "Description: " + this.Description + Environment.NewLine;
            back += "Year: " + this.Year + Environment.NewLine;
            back += "Delete: " + this.Delete;
			return back;
		}

        public string returnTitle()
		{
			return this.Title;
		}

		public int returnId()
		{
			return this.Id;
		}
        public bool returnDelete()
		{
			return this.Delete;
		}
        public void delete() {
            this.Delete = true;
        }
    }
}