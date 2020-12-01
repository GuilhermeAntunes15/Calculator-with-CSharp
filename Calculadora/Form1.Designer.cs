namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_v1 = new System.Windows.Forms.TextBox();
            this.btn_Somar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_v2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Resp = new System.Windows.Forms.Label();
            this.btn_Subtrair = new System.Windows.Forms.Button();
            this.btn_Dividir = new System.Windows.Forms.Button();
            this.btn_Mult = new System.Windows.Forms.Button();
            this.btn_Ans = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Pot = new System.Windows.Forms.Button();
            this.btn_Raiz = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(72, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor 1:";
            // 
            // txt_v1
            // 
            this.txt_v1.Location = new System.Drawing.Point(159, 101);
            this.txt_v1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_v1.Name = "txt_v1";
            this.txt_v1.Size = new System.Drawing.Size(148, 28);
            this.txt_v1.TabIndex = 1;
            // 
            // btn_Somar
            // 
            this.btn_Somar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Somar.Location = new System.Drawing.Point(372, 89);
            this.btn_Somar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Somar.Name = "btn_Somar";
            this.btn_Somar.Size = new System.Drawing.Size(45, 36);
            this.btn_Somar.TabIndex = 2;
            this.btn_Somar.Text = "+";
            this.btn_Somar.UseVisualStyleBackColor = true;
            this.btn_Somar.Click += new System.EventHandler(this.btn_Somar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(133, 271);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Resultado:";
            // 
            // txt_v2
            // 
            this.txt_v2.Location = new System.Drawing.Point(159, 174);
            this.txt_v2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_v2.Name = "txt_v2";
            this.txt_v2.Size = new System.Drawing.Size(148, 28);
            this.txt_v2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(72, 176);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valor 2:";
            // 
            // lbl_Resp
            // 
            this.lbl_Resp.AutoSize = true;
            this.lbl_Resp.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Resp.ForeColor = System.Drawing.Color.White;
            this.lbl_Resp.Location = new System.Drawing.Point(229, 271);
            this.lbl_Resp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Resp.Name = "lbl_Resp";
            this.lbl_Resp.Size = new System.Drawing.Size(65, 26);
            this.lbl_Resp.TabIndex = 6;
            this.lbl_Resp.Text = "label4";
            this.lbl_Resp.Visible = false;
            // 
            // btn_Subtrair
            // 
            this.btn_Subtrair.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Subtrair.Location = new System.Drawing.Point(449, 89);
            this.btn_Subtrair.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Subtrair.Name = "btn_Subtrair";
            this.btn_Subtrair.Size = new System.Drawing.Size(45, 36);
            this.btn_Subtrair.TabIndex = 7;
            this.btn_Subtrair.Text = "-";
            this.btn_Subtrair.UseVisualStyleBackColor = true;
            this.btn_Subtrair.Click += new System.EventHandler(this.btn_Subtrair_Click);
            // 
            // btn_Dividir
            // 
            this.btn_Dividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dividir.Location = new System.Drawing.Point(520, 90);
            this.btn_Dividir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Dividir.Name = "btn_Dividir";
            this.btn_Dividir.Size = new System.Drawing.Size(45, 36);
            this.btn_Dividir.TabIndex = 8;
            this.btn_Dividir.Text = "÷";
            this.btn_Dividir.UseVisualStyleBackColor = true;
            this.btn_Dividir.Click += new System.EventHandler(this.btn_Dividir_Click);
            // 
            // btn_Mult
            // 
            this.btn_Mult.Location = new System.Drawing.Point(372, 151);
            this.btn_Mult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Mult.Name = "btn_Mult";
            this.btn_Mult.Size = new System.Drawing.Size(45, 36);
            this.btn_Mult.TabIndex = 9;
            this.btn_Mult.Text = "X";
            this.btn_Mult.UseVisualStyleBackColor = true;
            this.btn_Mult.Click += new System.EventHandler(this.btn_Mult_Click);
            // 
            // btn_Ans
            // 
            this.btn_Ans.Location = new System.Drawing.Point(405, 216);
            this.btn_Ans.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Ans.Name = "btn_Ans";
            this.btn_Ans.Size = new System.Drawing.Size(55, 36);
            this.btn_Ans.TabIndex = 10;
            this.btn_Ans.Text = "ANS";
            this.btn_Ans.UseVisualStyleBackColor = true;
            this.btn_Ans.Click += new System.EventHandler(this.btn_Ans_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.SkyBlue;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(195, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 40);
            this.label4.TabIndex = 11;
            this.label4.Text = "Calculadora";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(449, 151);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 36);
            this.button1.TabIndex = 12;
            this.button1.Text = "%";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Pot
            // 
            this.btn_Pot.Font = new System.Drawing.Font("Comic Sans MS", 11.25F);
            this.btn_Pot.Location = new System.Drawing.Point(483, 216);
            this.btn_Pot.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Pot.Name = "btn_Pot";
            this.btn_Pot.Size = new System.Drawing.Size(45, 36);
            this.btn_Pot.TabIndex = 13;
            this.btn_Pot.Text = "Pot";
            this.btn_Pot.UseVisualStyleBackColor = true;
            this.btn_Pot.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_Raiz
            // 
            this.btn_Raiz.Font = new System.Drawing.Font("Comic Sans MS", 11.25F);
            this.btn_Raiz.Location = new System.Drawing.Point(520, 151);
            this.btn_Raiz.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Raiz.Name = "btn_Raiz";
            this.btn_Raiz.Size = new System.Drawing.Size(45, 36);
            this.btn_Raiz.TabIndex = 14;
            this.btn_Raiz.Text = "√";
            this.btn_Raiz.UseVisualStyleBackColor = true;
            this.btn_Raiz.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(630, 339);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Raiz);
            this.Controls.Add(this.btn_Pot);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Ans);
            this.Controls.Add(this.btn_Mult);
            this.Controls.Add(this.btn_Dividir);
            this.Controls.Add(this.btn_Subtrair);
            this.Controls.Add(this.lbl_Resp);
            this.Controls.Add(this.txt_v2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Somar);
            this.Controls.Add(this.txt_v1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Calcualdora";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_v1;
        private System.Windows.Forms.Button btn_Somar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_v2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Resp;
        private System.Windows.Forms.Button btn_Subtrair;
        private System.Windows.Forms.Button btn_Dividir;
        private System.Windows.Forms.Button btn_Mult;
        private System.Windows.Forms.Button btn_Ans;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Pot;
        private System.Windows.Forms.Button btn_Raiz;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

