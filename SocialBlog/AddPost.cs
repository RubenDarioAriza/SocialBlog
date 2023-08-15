using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocialBlog
{
    public partial class AddPost : Form
    {
        public AddPost()
        {
            InitializeComponent();
        }
        private byte[] GetImageBytes()
        {
            if (pictureBox.Image != null)
            {
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    pictureBox.Image.Save(memoryStream, pictureBox.Image.RawFormat);
                    return memoryStream.ToArray();
                }
            }

            return null;
        }


        private void btnSave_Click(string title, string description, string content, byte[] image)
        {
            title = txtTitle.Text;
            description = txtDescription.Text;
            content = txtContent.Text;
            image = GetImageBytes(); // Método que obtiene los bytes de la imagen

            try
            {
                postService.CreatePost(title, description, content, image);
                MessageBox.Show("Post creado exitosamente.");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }

}
