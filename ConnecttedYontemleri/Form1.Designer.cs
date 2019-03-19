namespace ConnecttedYontemleri
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
            this.btnLocal = new System.Windows.Forms.Button();
            this.btnGlobal = new System.Windows.Forms.Button();
            this.btnClass = new System.Windows.Forms.Button();
            this.btnApp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLocal
            // 
            this.btnLocal.Location = new System.Drawing.Point(12, 12);
            this.btnLocal.Name = "btnLocal";
            this.btnLocal.Size = new System.Drawing.Size(176, 43);
            this.btnLocal.TabIndex = 0;
            this.btnLocal.Text = "Local Değişken İle Bağlan";
            this.btnLocal.UseVisualStyleBackColor = true;
            this.btnLocal.Click += new System.EventHandler(this.btnLocal_Click);
            // 
            // btnGlobal
            // 
            this.btnGlobal.Location = new System.Drawing.Point(12, 61);
            this.btnGlobal.Name = "btnGlobal";
            this.btnGlobal.Size = new System.Drawing.Size(176, 43);
            this.btnGlobal.TabIndex = 1;
            this.btnGlobal.Text = "Global Değişken İle Bağlan";
            this.btnGlobal.UseVisualStyleBackColor = true;
            this.btnGlobal.Click += new System.EventHandler(this.btnGlobal_Click);
            // 
            // btnClass
            // 
            this.btnClass.Location = new System.Drawing.Point(12, 110);
            this.btnClass.Name = "btnClass";
            this.btnClass.Size = new System.Drawing.Size(176, 43);
            this.btnClass.TabIndex = 2;
            this.btnClass.Text = "Class İle Bağlan";
            this.btnClass.UseVisualStyleBackColor = true;
            this.btnClass.Click += new System.EventHandler(this.btnClass_Click);
            // 
            // btnApp
            // 
            this.btnApp.Location = new System.Drawing.Point(12, 159);
            this.btnApp.Name = "btnApp";
            this.btnApp.Size = new System.Drawing.Size(176, 43);
            this.btnApp.TabIndex = 3;
            this.btnApp.Text = "App.config İle Bağlan";
            this.btnApp.UseVisualStyleBackColor = true;
            this.btnApp.Click += new System.EventHandler(this.btnApp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 224);
            this.Controls.Add(this.btnApp);
            this.Controls.Add(this.btnClass);
            this.Controls.Add(this.btnGlobal);
            this.Controls.Add(this.btnLocal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLocal;
        private System.Windows.Forms.Button btnGlobal;
        private System.Windows.Forms.Button btnClass;
        private System.Windows.Forms.Button btnApp;
    }
}

