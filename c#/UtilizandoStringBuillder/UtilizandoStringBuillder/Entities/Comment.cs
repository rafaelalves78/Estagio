using UtilizandoStringBuillder.Entities;

namespace UtilizandoStringBuillder.Entities
{
    class Comment
    {
        public string Text { get; set; }

        public Comment()
        {

        }

        public Comment(string text)
        {
            this.Text = text;
        }
    }
}
