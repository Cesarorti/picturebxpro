namespace picturebxpro
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            feliz = new Button();
            triste = new Button();
            envidia = new Button();
            enui = new Button();
            desagrado = new Button();
            ansiedad = new Button();
            temor = new Button();
            furia = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.i8;
            pictureBox1.Location = new Point(101, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(392, 285);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // feliz
            // 
            feliz.Location = new Point(69, 343);
            feliz.Name = "feliz";
            feliz.Size = new Size(118, 33);
            feliz.TabIndex = 1;
            feliz.Text = "feliz";
            feliz.UseVisualStyleBackColor = true;
            feliz.Click += feliz_Click;
            // 
            // triste
            // 
            triste.Location = new Point(193, 343);
            triste.Name = "triste";
            triste.Size = new Size(129, 33);
            triste.TabIndex = 2;
            triste.Text = "triste";
            triste.UseVisualStyleBackColor = true;
            triste.Click += triste_Click;
            // 
            // envidia
            // 
            envidia.Location = new Point(489, 395);
            envidia.Name = "envidia";
            envidia.Size = new Size(129, 33);
            envidia.TabIndex = 3;
            envidia.Text = "envidia";
            envidia.UseVisualStyleBackColor = true;
            envidia.Click += envidia_Click;
            // 
            // enui
            // 
            enui.Location = new Point(336, 395);
            enui.Name = "enui";
            enui.Size = new Size(129, 33);
            enui.TabIndex = 4;
            enui.Text = "enui";
            enui.UseVisualStyleBackColor = true;
            enui.Click += enui_Click;
            // 
            // desagrado
            // 
            desagrado.Location = new Point(336, 343);
            desagrado.Name = "desagrado";
            desagrado.Size = new Size(129, 33);
            desagrado.TabIndex = 5;
            desagrado.Text = "desagrado";
            desagrado.UseVisualStyleBackColor = true;
            desagrado.Click += desagrado_Click;
            // 
            // ansiedad
            // 
            ansiedad.Location = new Point(193, 395);
            ansiedad.Name = "ansiedad";
            ansiedad.Size = new Size(129, 33);
            ansiedad.TabIndex = 6;
            ansiedad.Text = "ansiedad";
            ansiedad.UseVisualStyleBackColor = true;
            ansiedad.Click += ansiedad_Click;
            // 
            // temor
            // 
            temor.Location = new Point(69, 395);
            temor.Name = "temor";
            temor.Size = new Size(118, 33);
            temor.TabIndex = 7;
            temor.Text = "temor";
            temor.UseVisualStyleBackColor = true;
            temor.Click += temor_Click;
            // 
            // furia
            // 
            furia.Location = new Point(489, 343);
            furia.Name = "furia";
            furia.Size = new Size(129, 33);
            furia.TabIndex = 8;
            furia.Text = "furia";
            furia.UseVisualStyleBackColor = true;
            furia.Click += furia_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(581, 126);
            label1.Name = "label1";
            label1.Size = new Size(98, 25);
            label1.TabIndex = 9;
            label1.Text = "Cesar Ortiz";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(furia);
            Controls.Add(temor);
            Controls.Add(ansiedad);
            Controls.Add(desagrado);
            Controls.Add(enui);
            Controls.Add(envidia);
            Controls.Add(triste);
            Controls.Add(feliz);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button feliz;
        private Button triste;
        private Button envidia;
        private Button enui;
        private Button desagrado;
        private Button ansiedad;
        private Button temor;
        private Button furia;
        private Label label1;
    }
}
