using System;


namespace MidTermLibraryGUI
{
    public class BookClass
    {
        #region Variables
        private string title;
        private string author;
        private string genre;
        private string status;
        private string duedate;
        private int indexkey;
        #endregion   //defined variables for book class


        #region Properties
        public string TitleProp { get { return title; } set { title = value; } }
        public string AuthorProp { get { return author; } set { author = value; } }
        public string GenreProp { get { return genre; } set { genre = value; } }
        public string StatusProp { get { return status; } set { status = value; } }
        public string DueDateProp { get { return duedate; } set { duedate= value; } }
        public int IndexProp { get { return indexkey; } set { indexkey = value; } }
        public static string SelectProp { get;  set; }
        #endregion   // added get set properties for all variables

        #region Constructors         

        public BookClass()
        {//defaullt constructor
            TitleProp = "";
            AuthorProp = "";
            GenreProp = "";
            StatusProp = "Available";
            DueDateProp = "On Shelf";
            indexkey = 0;
            
        }

        public BookClass(string GetTitle, string GetAuthor, string GetGenre) //constructor for inputs
        {
            TitleProp = GetTitle;
            AuthorProp = GetAuthor;    
            GenreProp = GetGenre;
           
        }

        public override string ToString()   // for spacing
        {
            string output = String.Empty;    

            output += String.Format("{0, -40} {1, -20} {2, -20} {3, -20} {4, -20} {5}", TitleProp, AuthorProp, GenreProp, StatusProp, DueDateProp, IndexProp);
        
            return output;
        }

        #endregion
    }
}
