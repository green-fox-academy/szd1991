using System;
using System.Collections.Generic;
using System.Text;

namespace BlogPost
{
    public class BlogPost
    {
        private string AuthorName;
        private string Title;
        private string Text;
        private string PublicationDate;

        public BlogPost(string AuthorName = "Anonymus", string Title = "Unknown", string Text = "Content", string PublicationDate = "1999.12.31.")
        {
            this.AuthorName = AuthorName;
            this.Title = Title;
            this.Text = Text;
            this.PublicationDate = PublicationDate;
        }

        public string CompleteBlogPost()
        {
            return $"Author: {AuthorName}\nTitle: {Title}\nPublished: {PublicationDate}\n\n{Text}\n";
        }
    }
}
