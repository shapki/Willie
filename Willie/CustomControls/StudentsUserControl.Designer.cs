
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
            this.dateWillie = new System.Windows.Forms.Label();
            this.numcardLabel = new System.Windows.Forms.Label();
            this.trainingHistoryButton = new System.Windows.Forms.Button();
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
            this.fullNameLabel.Click += new System.EventHandler(this.fullNameLabel_Click);
            // 
            // dateWillie
            // 
            this.dateWillie.Location = new System.Drawing.Point(373, 15);
            this.dateWillie.Name = "dateWillie";
            this.dateWillie.Size = new System.Drawing.Size(145, 13);
            this.dateWillie.TabIndex = 1;
            this.dateWillie.Text = "Вилли:";
            this.dateWillie.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.dateWillie.Click += new System.EventHandler(this.dateWillie_Click);
            // 
            // numcardLabel
            // 
            this.numcardLabel.AutoSize = true;
            this.numcardLabel.Location = new System.Drawing.Point(18, 51);
            this.numcardLabel.Name = "numcardLabel";
            this.numcardLabel.Size = new System.Drawing.Size(89, 13);
            this.numcardLabel.TabIndex = 4;
            this.numcardLabel.Text = "Карта ученика:";
            this.numcardLabel.Click += new System.EventHandler(this.numcardLabel_Click);
            // 
            // trainingHistoryButton
            // 
            this.trainingHistoryButton.BackColor = System.Drawing.Color.Red;
            this.trainingHistoryButton.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.trainingHistoryButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.trainingHistoryButton.Location = new System.Drawing.Point(445, 31);
            this.trainingHistoryButton.Name = "trainingHistoryButton";
            this.trainingHistoryButton.Size = new System.Drawing.Size(73, 33);
            this.trainingHistoryButton.TabIndex = 5;
            this.trainingHistoryButton.Text = "История тренировок";
            this.trainingHistoryButton.UseVisualStyleBackColor = false;
            this.trainingHistoryButton.Click += new System.EventHandler(this.trainingHistoryButton_Click);
            // 
            // StudentsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(211)))));
            this.Controls.Add(this.trainingHistoryButton);
            this.Controls.Add(this.numcardLabel);
            this.Controls.Add(this.dateWillie);
            this.Controls.Add(this.fullNameLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "StudentsUserControl";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.Size = new System.Drawing.Size(536, 79);
            this.Click += new System.EventHandler(this.StudentsUserControl_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.Label dateWillie;
        private System.Windows.Forms.Label numcardLabel;
        private System.Windows.Forms.Button trainingHistoryButton;
    }
}
