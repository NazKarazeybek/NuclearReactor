namespace NuclearReactor
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.title = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Reactor1 = new System.Windows.Forms.Label();
            this.Reactor2 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.reactorsstable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.LightCyan;
            this.title.Font = new System.Drawing.Font("Georgia", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Black;
            this.title.Location = new System.Drawing.Point(0, 18);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(801, 44);
            this.title.TabIndex = 0;
            this.title.Text = "Nuclear Reactor";
            this.title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.title.Click += new System.EventHandler(this.label1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Reactor1
            // 
            this.Reactor1.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reactor1.ForeColor = System.Drawing.Color.Black;
            this.Reactor1.Location = new System.Drawing.Point(132, 99);
            this.Reactor1.Name = "Reactor1";
            this.Reactor1.Size = new System.Drawing.Size(152, 47);
            this.Reactor1.TabIndex = 2;
            this.Reactor1.Text = "Reactor 1";
            this.Reactor1.Click += new System.EventHandler(this.label2_Click);
            // 
            // Reactor2
            // 
            this.Reactor2.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reactor2.ForeColor = System.Drawing.Color.Black;
            this.Reactor2.Location = new System.Drawing.Point(495, 99);
            this.Reactor2.Name = "Reactor2";
            this.Reactor2.Size = new System.Drawing.Size(154, 47);
            this.Reactor2.TabIndex = 3;
            this.Reactor2.Text = "Reactor 2";
            this.Reactor2.Click += new System.EventHandler(this.Reactor2_Click);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.SlateBlue;
            this.startButton.Location = new System.Drawing.Point(307, 277);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(168, 45);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LawnGreen;
            this.label2.ForeColor = System.Drawing.Color.LawnGreen;
            this.label2.Location = new System.Drawing.Point(147, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 112);
            this.label2.TabIndex = 5;
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LawnGreen;
            this.label3.ForeColor = System.Drawing.Color.LawnGreen;
            this.label3.Location = new System.Drawing.Point(510, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 112);
            this.label3.TabIndex = 6;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(383, 405);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // reactorsstable
            // 
            this.reactorsstable.BackColor = System.Drawing.Color.White;
            this.reactorsstable.Font = new System.Drawing.Font("Georgia", 16F);
            this.reactorsstable.ForeColor = System.Drawing.Color.Black;
            this.reactorsstable.Location = new System.Drawing.Point(12, 376);
            this.reactorsstable.Name = "reactorsstable";
            this.reactorsstable.Size = new System.Drawing.Size(779, 49);
            this.reactorsstable.TabIndex = 8;
            this.reactorsstable.Text = "Reactors Steal";
            this.reactorsstable.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reactorsstable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.Reactor2);
            this.Controls.Add(this.Reactor1);
            this.Controls.Add(this.title);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label Reactor1;
        private System.Windows.Forms.Label Reactor2;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label reactorsstable;
    }
}

