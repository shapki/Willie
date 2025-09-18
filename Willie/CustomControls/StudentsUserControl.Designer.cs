
namespace Willie.CustomControls
{
    partial class StudentsUserControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.dateBirthLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.numcardLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.dominantHandLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fullNameLabel.Location = new System.Drawing.Point(18, 15);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(161, 25);
            this.fullNameLabel.TabIndex = 0;
            this.fullNameLabel.Text = "Имя Фамилия";
            // 
            // dateBirthLabel
            // 
            this.dateBirthLabel.Location = new System.Drawing.Point(393, 15);
            this.dateBirthLabel.Name = "dateBirthLabel";
            this.dateBirthLabel.Size = new System.Drawing.Size(125, 13);
            this.dateBirthLabel.TabIndex = 1;
            this.dateBirthLabel.Text = "Род.:";
            this.dateBirthLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(18, 40);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(59, 13);
            this.phoneLabel.TabIndex = 2;
            this.phoneLabel.Text = "Телефон";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(20, 53);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(42, 13);
            this.emailLabel.TabIndex = 3;
            this.emailLabel.Text = "Почта";
            // 
            // numcardLabel
            // 
            this.numcardLabel.AutoSize = true;
            this.numcardLabel.Location = new System.Drawing.Point(20, 66);
            this.numcardLabel.Name = "numcardLabel";
            this.numcardLabel.Size = new System.Drawing.Size(46, 13);
            this.numcardLabel.TabIndex = 4;
            this.numcardLabel.Text = "Карта:";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(18, 101);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(39, 13);
            this.heightLabel.TabIndex = 5;
            this.heightLabel.Text = "Рост:";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(18, 114);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(34, 13);
            this.genderLabel.TabIndex = 6;
            this.genderLabel.Text = "Пол:";
            // 
            // dominantHandLabel
            // 
            this.dominantHandLabel.AutoSize = true;
            this.dominantHandLabel.Location = new System.Drawing.Point(18, 127);
            this.dominantHandLabel.Name = "dominantHandLabel";
            this.dominantHandLabel.Size = new System.Drawing.Size(136, 13);
            this.dominantHandLabel.TabIndex = 7;
            this.dominantHandLabel.Text = "Преобладающая рука";
            // 
            // StudentsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.Controls.Add(this.dominantHandLabel);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.numcardLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.dateBirthLabel);
            this.Controls.Add(this.fullNameLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "StudentsUserControl";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.Size = new System.Drawing.Size(536, 148);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.Label dateBirthLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label numcardLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label dominantHandLabel;
    }
}
