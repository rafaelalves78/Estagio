using System;
using System.Collections.Generic;
using System.Text;

namespace UtilizandoStringBuillder.Entities
{
    class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }

        public List<Comment> Comments { get; set; } = new List<Comment>();

        public Post()
        {

        }

        public Post(DateTime moment, string title, string content, int likes)
        {
            this.Moment = moment;
            this.Title = title;
            this.Content = content;
            this.Likes = likes;
        }

        public void AddComment (Comment comment)
        {
            Comments.Add(comment);
        }

        public void RemoveComment (Comment comment)
        {
            Comments.Remove(comment);
        }

        //Gerando o ToString() utilizando a classe StringBuilder
        /*O StringBuilder é responsável por fazer a montagem de um string
        conforme for mandado de forma eficiente.
        Depois que tiver pronto você pega o resultado na forma de String*/
        public override string ToString()
        {
            //Deve se instanciar um objeto StringBuilder (Pertence ao System.Text):
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.Title);
            sb.Append(this.Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(this.Moment.ToString("dd/MM/yyyy HH:MM:SS"));
            sb.AppendLine(this.Content);
            sb.AppendLine("\nComments:");
            
            foreach (Comment c in Comments)
            {
                sb.AppendLine(c.Text);
            }

            return sb.ToString();
        }
    }
}
