using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATA;

namespace Logica
{
    public class Class1
    {
        private readonly PostData _postData;

        public PostService(PostData postData) => _postData = postData;

        public void CreatePost(string title, string description, string content, byte[] image)
        {
            if (string.IsNullOrWhiteSpace(content))
            {
                throw new ArgumentException("El contenido del post no puede estar vacío.");
            }

            var post = new Post
            {
                Title = title,
                Description = description,
                Content = content,
                Image = image
            };

            
        }
    }
}
