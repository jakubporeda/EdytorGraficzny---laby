
namespace EdytorGraficzny
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
            panel1 = new Panel();
            color_picker = new PictureBox();
            pic_color = new Button();
            panel3 = new Panel();
            btn_save = new Button();
            btn_clear = new Button();
            btn_line = new Button();
            btn_rectangle = new Button();
            btn_color = new Button();
            btn_ellipse = new Button();
            btn_fill = new Button();
            btn_eraser = new Button();
            btn_pencil = new Button();
            panel2 = new Panel();
            pic = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)color_picker).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(color_picker);
            panel1.Controls.Add(pic_color);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1262, 139);
            panel1.TabIndex = 0;
            // 
            // color_picker
            // 
            color_picker.Image = Properties.Resources.color_palette;
            color_picker.Location = new Point(3, 4);
            color_picker.Name = "color_picker";
            color_picker.Size = new Size(406, 130);
            color_picker.SizeMode = PictureBoxSizeMode.StretchImage;
            color_picker.TabIndex = 4;
            color_picker.TabStop = false;
            color_picker.MouseClick += color_picker_MouseClick;
            // 
            // pic_color
            // 
            pic_color.BackColor = Color.White;
            pic_color.Location = new Point(415, 47);
            pic_color.Name = "pic_color";
            pic_color.Size = new Size(49, 45);
            pic_color.TabIndex = 0;
            pic_color.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Controls.Add(btn_save);
            panel3.Controls.Add(btn_clear);
            panel3.Controls.Add(btn_line);
            panel3.Controls.Add(btn_rectangle);
            panel3.Controls.Add(btn_color);
            panel3.Controls.Add(btn_ellipse);
            panel3.Controls.Add(btn_fill);
            panel3.Controls.Add(btn_eraser);
            panel3.Controls.Add(btn_pencil);
            panel3.Location = new Point(489, 8);
            panel3.Name = "panel3";
            panel3.Size = new Size(766, 122);
            panel3.TabIndex = 3;
            // 
            // btn_save
            // 
            btn_save.BackColor = Color.FromArgb(64, 64, 64);
            btn_save.Cursor = Cursors.Hand;
            btn_save.FlatAppearance.BorderColor = Color.DimGray;
            btn_save.FlatAppearance.MouseDownBackColor = Color.Black;
            btn_save.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btn_save.FlatStyle = FlatStyle.Flat;
            btn_save.ForeColor = Color.White;
            btn_save.Location = new Point(695, 62);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(66, 55);
            btn_save.TabIndex = 8;
            btn_save.Text = "SAVE";
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += btn_save_Click;
            // 
            // btn_clear
            // 
            btn_clear.BackColor = Color.FromArgb(64, 64, 64);
            btn_clear.Cursor = Cursors.Hand;
            btn_clear.FlatAppearance.BorderColor = Color.DimGray;
            btn_clear.FlatAppearance.MouseDownBackColor = Color.Black;
            btn_clear.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btn_clear.FlatStyle = FlatStyle.Flat;
            btn_clear.ForeColor = Color.White;
            btn_clear.Location = new Point(695, 4);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(66, 55);
            btn_clear.TabIndex = 7;
            btn_clear.Text = "CLEAR";
            btn_clear.UseVisualStyleBackColor = false;
            btn_clear.Click += btn_clear_Click;
            // 
            // btn_line
            // 
            btn_line.BackColor = Color.FromArgb(64, 64, 64);
            btn_line.Cursor = Cursors.Hand;
            btn_line.FlatAppearance.BorderColor = Color.DimGray;
            btn_line.FlatAppearance.MouseDownBackColor = Color.Black;
            btn_line.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btn_line.FlatStyle = FlatStyle.Flat;
            btn_line.Image = Properties.Resources.line66x60;
            btn_line.Location = new Point(596, 4);
            btn_line.Name = "btn_line";
            btn_line.Size = new Size(92, 113);
            btn_line.TabIndex = 6;
            btn_line.TextAlign = ContentAlignment.BottomCenter;
            btn_line.UseVisualStyleBackColor = false;
            btn_line.Click += btn_line_Click;
            // 
            // btn_rectangle
            // 
            btn_rectangle.BackColor = Color.FromArgb(64, 64, 64);
            btn_rectangle.Cursor = Cursors.Hand;
            btn_rectangle.FlatAppearance.BorderColor = Color.DimGray;
            btn_rectangle.FlatAppearance.MouseDownBackColor = Color.Black;
            btn_rectangle.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btn_rectangle.FlatStyle = FlatStyle.Flat;
            btn_rectangle.Font = new Font("Segoe UI", 8F);
            btn_rectangle.ForeColor = Color.White;
            btn_rectangle.Image = Properties.Resources.rectangle_66x60;
            btn_rectangle.Location = new Point(498, 4);
            btn_rectangle.Name = "btn_rectangle";
            btn_rectangle.Size = new Size(92, 113);
            btn_rectangle.TabIndex = 5;
            btn_rectangle.Text = "RECTANGLE";
            btn_rectangle.TextAlign = ContentAlignment.BottomCenter;
            btn_rectangle.UseVisualStyleBackColor = false;
            btn_rectangle.Click += btn_rectangle_Click;
            // 
            // btn_color
            // 
            btn_color.BackColor = Color.FromArgb(64, 64, 64);
            btn_color.Cursor = Cursors.Hand;
            btn_color.FlatAppearance.BorderColor = Color.DimGray;
            btn_color.FlatAppearance.MouseDownBackColor = Color.Black;
            btn_color.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btn_color.FlatStyle = FlatStyle.Flat;
            btn_color.Font = new Font("Segoe UI", 8F);
            btn_color.ForeColor = Color.White;
            btn_color.Image = Properties.Resources.paleta66x60;
            btn_color.Location = new Point(6, 4);
            btn_color.Name = "btn_color";
            btn_color.Size = new Size(92, 113);
            btn_color.TabIndex = 1;
            btn_color.Text = "COLOR";
            btn_color.TextAlign = ContentAlignment.BottomCenter;
            btn_color.UseVisualStyleBackColor = false;
            btn_color.Click += btn_color_Click;
            // 
            // btn_ellipse
            // 
            btn_ellipse.BackColor = Color.FromArgb(64, 64, 64);
            btn_ellipse.Cursor = Cursors.Hand;
            btn_ellipse.FlatAppearance.BorderColor = Color.DimGray;
            btn_ellipse.FlatAppearance.MouseDownBackColor = Color.Black;
            btn_ellipse.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btn_ellipse.FlatStyle = FlatStyle.Flat;
            btn_ellipse.Font = new Font("Segoe UI", 8F);
            btn_ellipse.ForeColor = Color.White;
            btn_ellipse.Image = Properties.Resources.circle66x60;
            btn_ellipse.Location = new Point(400, 4);
            btn_ellipse.Name = "btn_ellipse";
            btn_ellipse.Size = new Size(92, 113);
            btn_ellipse.TabIndex = 4;
            btn_ellipse.Text = "ELLIPSE";
            btn_ellipse.TextAlign = ContentAlignment.BottomCenter;
            btn_ellipse.UseVisualStyleBackColor = false;
            btn_ellipse.Click += btn_ellipse_Click;
            // 
            // btn_fill
            // 
            btn_fill.BackColor = Color.FromArgb(64, 64, 64);
            btn_fill.Cursor = Cursors.Hand;
            btn_fill.FlatAppearance.BorderColor = Color.DimGray;
            btn_fill.FlatAppearance.MouseDownBackColor = Color.Black;
            btn_fill.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btn_fill.FlatStyle = FlatStyle.Flat;
            btn_fill.Font = new Font("Segoe UI", 8F);
            btn_fill.ForeColor = Color.White;
            btn_fill.Image = Properties.Resources.wiaderko66x60;
            btn_fill.Location = new Point(105, 4);
            btn_fill.Name = "btn_fill";
            btn_fill.Size = new Size(92, 113);
            btn_fill.TabIndex = 2;
            btn_fill.Text = "FILL";
            btn_fill.TextAlign = ContentAlignment.BottomCenter;
            btn_fill.UseVisualStyleBackColor = false;
            btn_fill.Click += btn_fill_Click;
            // 
            // btn_eraser
            // 
            btn_eraser.BackColor = Color.FromArgb(64, 64, 64);
            btn_eraser.Cursor = Cursors.Hand;
            btn_eraser.FlatAppearance.BorderColor = Color.DimGray;
            btn_eraser.FlatAppearance.MouseDownBackColor = Color.Black;
            btn_eraser.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btn_eraser.FlatStyle = FlatStyle.Flat;
            btn_eraser.Font = new Font("Segoe UI", 8F);
            btn_eraser.ForeColor = Color.White;
            btn_eraser.Image = Properties.Resources.gumka66x60;
            btn_eraser.Location = new Point(302, 4);
            btn_eraser.Name = "btn_eraser";
            btn_eraser.Size = new Size(92, 113);
            btn_eraser.TabIndex = 3;
            btn_eraser.Text = "ERASER";
            btn_eraser.TextAlign = ContentAlignment.BottomCenter;
            btn_eraser.UseVisualStyleBackColor = false;
            btn_eraser.Click += btn_eraser_Click;
            // 
            // btn_pencil
            // 
            btn_pencil.BackColor = Color.FromArgb(64, 64, 64);
            btn_pencil.Cursor = Cursors.Hand;
            btn_pencil.FlatAppearance.BorderColor = Color.DimGray;
            btn_pencil.FlatAppearance.MouseDownBackColor = Color.Black;
            btn_pencil.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btn_pencil.FlatStyle = FlatStyle.Flat;
            btn_pencil.Font = new Font("Segoe UI", 8F);
            btn_pencil.ForeColor = Color.White;
            btn_pencil.Image = Properties.Resources.olowek66x60;
            btn_pencil.Location = new Point(204, 4);
            btn_pencil.Name = "btn_pencil";
            btn_pencil.Size = new Size(92, 113);
            btn_pencil.TabIndex = 3;
            btn_pencil.Text = "PENCIL";
            btn_pencil.TextAlign = ContentAlignment.BottomCenter;
            btn_pencil.UseVisualStyleBackColor = false;
            btn_pencil.Click += btn_pencil_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gray;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 575);
            panel2.Name = "panel2";
            panel2.Size = new Size(1262, 38);
            panel2.TabIndex = 1;
            // 
            // pic
            // 
            pic.BackColor = Color.White;
            pic.Dock = DockStyle.Fill;
            pic.Location = new Point(0, 0);
            pic.Name = "pic";
            pic.Size = new Size(1262, 613);
            pic.TabIndex = 2;
            pic.TabStop = false;
            pic.Paint += pic_Paint;
            pic.MouseClick += pic_MouseClick;
            pic.MouseDown += pic_MouseDown;
            pic.MouseMove += pic_MouseMove;
            pic.MouseUp += pic_MouseUp;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 613);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pic);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)color_picker).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic).EndInit();
            ResumeLayout(false);
        }


        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btn_color;
        private Button pic_color;
        private PictureBox pic;
        private Button btn_eraser;
        private Button btn_pencil;
        private Button btn_fill;
        private Button btn_ellipse;
        private Button btn_line;
        private Button btn_rectangle;
        private Panel panel3;
        private Button btn_save;
        private Button btn_clear;
        private PictureBox color_picker;
    }
}
