namespace arbol_Operaciones
{
    partial class Form1
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
            this.resolver = new System.Windows.Forms.Button();
            this.evaluarPost = new System.Windows.Forms.Button();
            this.evaluarPre = new System.Windows.Forms.Button();
            this.txtEc = new System.Windows.Forms.TextBox();
            this.txtPost = new System.Windows.Forms.TextBox();
            this.txtPre = new System.Windows.Forms.TextBox();
            this.txtResPre = new System.Windows.Forms.TextBox();
            this.txtResPost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // resolver
            // 
            this.resolver.Location = new System.Drawing.Point(36, 21);
            this.resolver.Name = "resolver";
            this.resolver.Size = new System.Drawing.Size(75, 39);
            this.resolver.TabIndex = 0;
            this.resolver.Text = "Resolver";
            this.resolver.UseVisualStyleBackColor = true;
            this.resolver.Click += new System.EventHandler(this.resolver_Click);
            // 
            // evaluarPost
            // 
            this.evaluarPost.Location = new System.Drawing.Point(36, 66);
            this.evaluarPost.Name = "evaluarPost";
            this.evaluarPost.Size = new System.Drawing.Size(75, 41);
            this.evaluarPost.TabIndex = 1;
            this.evaluarPost.Text = "Evaluar Post";
            this.evaluarPost.UseVisualStyleBackColor = true;
            this.evaluarPost.Click += new System.EventHandler(this.evaluarPost_Click);
            // 
            // evaluarPre
            // 
            this.evaluarPre.Location = new System.Drawing.Point(36, 113);
            this.evaluarPre.Name = "evaluarPre";
            this.evaluarPre.Size = new System.Drawing.Size(75, 41);
            this.evaluarPre.TabIndex = 2;
            this.evaluarPre.Text = "Evaluar Pre";
            this.evaluarPre.UseVisualStyleBackColor = true;
            this.evaluarPre.Click += new System.EventHandler(this.evaluarPre_Click);
            // 
            // txtEc
            // 
            this.txtEc.Location = new System.Drawing.Point(117, 40);
            this.txtEc.Name = "txtEc";
            this.txtEc.Size = new System.Drawing.Size(157, 20);
            this.txtEc.TabIndex = 3;
            // 
            // txtPost
            // 
            this.txtPost.Location = new System.Drawing.Point(379, 94);
            this.txtPost.Name = "txtPost";
            this.txtPost.Size = new System.Drawing.Size(157, 20);
            this.txtPost.TabIndex = 4;
            // 
            // txtPre
            // 
            this.txtPre.Location = new System.Drawing.Point(379, 140);
            this.txtPre.Name = "txtPre";
            this.txtPre.Size = new System.Drawing.Size(157, 20);
            this.txtPre.TabIndex = 5;
            // 
            // txtResPre
            // 
            this.txtResPre.Location = new System.Drawing.Point(117, 133);
            this.txtResPre.Name = "txtResPre";
            this.txtResPre.Size = new System.Drawing.Size(157, 20);
            this.txtResPre.TabIndex = 7;
            // 
            // txtResPost
            // 
            this.txtResPost.Location = new System.Drawing.Point(117, 87);
            this.txtResPost.Name = "txtResPost";
            this.txtResPost.Size = new System.Drawing.Size(157, 20);
            this.txtResPost.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Post-Order";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Pre-Order";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 302);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtResPre);
            this.Controls.Add(this.txtResPost);
            this.Controls.Add(this.txtPre);
            this.Controls.Add(this.txtPost);
            this.Controls.Add(this.txtEc);
            this.Controls.Add(this.evaluarPre);
            this.Controls.Add(this.evaluarPost);
            this.Controls.Add(this.resolver);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button resolver;
        private System.Windows.Forms.Button evaluarPost;
        private System.Windows.Forms.Button evaluarPre;
        private System.Windows.Forms.TextBox txtEc;
        private System.Windows.Forms.TextBox txtPost;
        private System.Windows.Forms.TextBox txtPre;
        private System.Windows.Forms.TextBox txtResPre;
        private System.Windows.Forms.TextBox txtResPost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

