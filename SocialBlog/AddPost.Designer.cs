namespace SocialBlog
{
    partial class AddPost
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblContent = new System.Windows.Forms.Label();
            this.lblImg = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.txtContent = new System.Windows.Forms.RichTextBox();
            this.btnSelectImg = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(77, 44);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(65, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Titulo";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Times New Roman", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(15, 120);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(118, 25);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Descripción";
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Font = new System.Drawing.Font("Times New Roman", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContent.Location = new System.Drawing.Point(29, 273);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(102, 25);
            this.lblContent.TabIndex = 2;
            this.lblContent.Text = "Contenido";
            // 
            // lblImg
            // 
            this.lblImg.AutoSize = true;
            this.lblImg.Font = new System.Drawing.Font("Times New Roman", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImg.Location = new System.Drawing.Point(60, 408);
            this.lblImg.Name = "lblImg";
            this.lblImg.Size = new System.Drawing.Size(74, 25);
            this.lblImg.TabIndex = 3;
            this.lblImg.Text = "Imagén";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(190, 48);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(258, 20);
            this.txtTitle.TabIndex = 4;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(190, 97);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(400, 75);
            this.txtDescription.TabIndex = 5;
            this.txtDescription.Text = "";
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(190, 198);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(400, 178);
            this.txtContent.TabIndex = 6;
            this.txtContent.Text = "";
            // 
            // btnSelectImg
            // 
            this.btnSelectImg.Font = new System.Drawing.Font("Times New Roman", 18.33962F);
            this.btnSelectImg.Location = new System.Drawing.Point(190, 403);
            this.btnSelectImg.Name = "btnSelectImg";
            this.btnSelectImg.Size = new System.Drawing.Size(315, 38);
            this.btnSelectImg.TabIndex = 7;
            this.btnSelectImg.Text = "Seleccionar Imagen";
            this.btnSelectImg.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 18.33962F);
            this.btnSave.Location = new System.Drawing.Point(190, 505);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(232, 106);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Crear Post";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // AddPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(647, 670);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSelectImg);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblImg);
            this.Controls.Add(this.lblContent);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblTitle);
            this.Name = "AddPost";
            this.Text = "AddPost";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.Label lblImg;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.RichTextBox txtContent;
        private System.Windows.Forms.Button btnSelectImg;
        private System.Windows.Forms.Button btnSave;
    }
}