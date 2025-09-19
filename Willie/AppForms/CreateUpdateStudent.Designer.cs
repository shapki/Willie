
namespace Willie.AppForms
{
    partial class CreateUpdateStudent
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label dateBirthLabel;
            System.Windows.Forms.Label fullNameLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label numcardLabel;
            System.Windows.Forms.Label heightLabel;
            System.Windows.Forms.Label dominantHandIdLabel;
            System.Windows.Forms.Label genderIdLabel;
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.shapkin_06_WillieDataSet = new Willie.Shapkin_06_WillieDataSet();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsTableAdapter = new Willie.Shapkin_06_WillieDataSetTableAdapters.studentsTableAdapter();
            this.tableAdapterManager = new Willie.Shapkin_06_WillieDataSetTableAdapters.TableAdapterManager();
            this.dateBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.phoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.emailMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.numcardMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.dominantHandIdComboBox = new System.Windows.Forms.ComboBox();
            this.genderIdComboBox = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            dateBirthLabel = new System.Windows.Forms.Label();
            fullNameLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            numcardLabel = new System.Windows.Forms.Label();
            heightLabel = new System.Windows.Forms.Label();
            dominantHandIdLabel = new System.Windows.Forms.Label();
            genderIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shapkin_06_WillieDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer.Panel1.Controls.Add(this.logoPictureBox);
            this.splitContainer.Panel1.Controls.Add(this.titleLabel);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.AutoScroll = true;
            this.splitContainer.Panel2.Controls.Add(this.saveButton);
            this.splitContainer.Panel2.Controls.Add(dateBirthLabel);
            this.splitContainer.Panel2.Controls.Add(this.dateBirthDateTimePicker);
            this.splitContainer.Panel2.Controls.Add(fullNameLabel);
            this.splitContainer.Panel2.Controls.Add(this.fullNameTextBox);
            this.splitContainer.Panel2.Controls.Add(phoneLabel);
            this.splitContainer.Panel2.Controls.Add(this.phoneMaskedTextBox);
            this.splitContainer.Panel2.Controls.Add(emailLabel);
            this.splitContainer.Panel2.Controls.Add(this.emailMaskedTextBox);
            this.splitContainer.Panel2.Controls.Add(numcardLabel);
            this.splitContainer.Panel2.Controls.Add(this.numcardMaskedTextBox);
            this.splitContainer.Panel2.Controls.Add(heightLabel);
            this.splitContainer.Panel2.Controls.Add(this.heightTextBox);
            this.splitContainer.Panel2.Controls.Add(dominantHandIdLabel);
            this.splitContainer.Panel2.Controls.Add(this.dominantHandIdComboBox);
            this.splitContainer.Panel2.Controls.Add(genderIdLabel);
            this.splitContainer.Panel2.Controls.Add(this.genderIdComboBox);
            this.splitContainer.Size = new System.Drawing.Size(373, 317);
            this.splitContainer.SplitterDistance = 33;
            this.splitContainer.TabIndex = 1;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.logoPictureBox.Image = global::Willie.Properties.Resources.icon1;
            this.logoPictureBox.Location = new System.Drawing.Point(0, 0);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(51, 33);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 2;
            this.logoPictureBox.TabStop = false;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLabel.Location = new System.Drawing.Point(57, 11);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(278, 25);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "ДОБАВЛЕНИЕ СТУДЕНТА";
            // 
            // shapkin_06_WillieDataSet
            // 
            this.shapkin_06_WillieDataSet.DataSetName = "Shapkin_06_WillieDataSet";
            this.shapkin_06_WillieDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "students";
            this.studentsBindingSource.DataSource = this.shapkin_06_WillieDataSet;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.dominantHandTableAdapter = null;
            this.tableAdapterManager.genderTableAdapter = null;
            this.tableAdapterManager.hitsTableAdapter = null;
            this.tableAdapterManager.programsTableAdapter = null;
            this.tableAdapterManager.studentsTableAdapter = this.studentsTableAdapter;
            this.tableAdapterManager.UpdateOrder = Willie.Shapkin_06_WillieDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dateBirthLabel
            // 
            dateBirthLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            dateBirthLabel.AutoSize = true;
            dateBirthLabel.Location = new System.Drawing.Point(33, 18);
            dateBirthLabel.Name = "dateBirthLabel";
            dateBirthLabel.Size = new System.Drawing.Size(86, 13);
            dateBirthLabel.TabIndex = 0;
            dateBirthLabel.Text = "Дата рождения";
            // 
            // dateBirthDateTimePicker
            // 
            this.dateBirthDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateBirthDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.studentsBindingSource, "dateBirth", true));
            this.dateBirthDateTimePicker.Location = new System.Drawing.Point(135, 14);
            this.dateBirthDateTimePicker.Name = "dateBirthDateTimePicker";
            this.dateBirthDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateBirthDateTimePicker.TabIndex = 1;
            // 
            // fullNameLabel
            // 
            fullNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            fullNameLabel.AutoSize = true;
            fullNameLabel.Location = new System.Drawing.Point(33, 43);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new System.Drawing.Size(34, 13);
            fullNameLabel.TabIndex = 2;
            fullNameLabel.Text = "ФИО";
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fullNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "fullName", true));
            this.fullNameTextBox.Location = new System.Drawing.Point(135, 40);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.fullNameTextBox.TabIndex = 3;
            // 
            // phoneLabel
            // 
            phoneLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(33, 69);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(52, 13);
            phoneLabel.TabIndex = 4;
            phoneLabel.Text = "Телефон";
            // 
            // phoneMaskedTextBox
            // 
            this.phoneMaskedTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.phoneMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "phone", true));
            this.phoneMaskedTextBox.Location = new System.Drawing.Point(135, 66);
            this.phoneMaskedTextBox.Name = "phoneMaskedTextBox";
            this.phoneMaskedTextBox.Size = new System.Drawing.Size(200, 20);
            this.phoneMaskedTextBox.TabIndex = 5;
            // 
            // emailLabel
            // 
            emailLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(33, 95);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(37, 13);
            emailLabel.TabIndex = 6;
            emailLabel.Text = "Почта";
            // 
            // emailMaskedTextBox
            // 
            this.emailMaskedTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "email", true));
            this.emailMaskedTextBox.Location = new System.Drawing.Point(135, 92);
            this.emailMaskedTextBox.Name = "emailMaskedTextBox";
            this.emailMaskedTextBox.Size = new System.Drawing.Size(200, 20);
            this.emailMaskedTextBox.TabIndex = 7;
            // 
            // numcardLabel
            // 
            numcardLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            numcardLabel.AutoSize = true;
            numcardLabel.Location = new System.Drawing.Point(33, 121);
            numcardLabel.Name = "numcardLabel";
            numcardLabel.Size = new System.Drawing.Size(75, 13);
            numcardLabel.TabIndex = 8;
            numcardLabel.Text = "Номер карты";
            // 
            // numcardMaskedTextBox
            // 
            this.numcardMaskedTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numcardMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "numcard", true));
            this.numcardMaskedTextBox.Location = new System.Drawing.Point(135, 118);
            this.numcardMaskedTextBox.Name = "numcardMaskedTextBox";
            this.numcardMaskedTextBox.Size = new System.Drawing.Size(200, 20);
            this.numcardMaskedTextBox.TabIndex = 9;
            // 
            // heightLabel
            // 
            heightLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            heightLabel.AutoSize = true;
            heightLabel.Location = new System.Drawing.Point(33, 147);
            heightLabel.Name = "heightLabel";
            heightLabel.Size = new System.Drawing.Size(31, 13);
            heightLabel.TabIndex = 10;
            heightLabel.Text = "Рост";
            // 
            // heightTextBox
            // 
            this.heightTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.heightTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "height", true));
            this.heightTextBox.Location = new System.Drawing.Point(135, 144);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(200, 20);
            this.heightTextBox.TabIndex = 11;
            // 
            // dominantHandIdLabel
            // 
            dominantHandIdLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            dominantHandIdLabel.AutoSize = true;
            dominantHandIdLabel.Location = new System.Drawing.Point(33, 173);
            dominantHandIdLabel.Name = "dominantHandIdLabel";
            dominantHandIdLabel.Size = new System.Drawing.Size(78, 13);
            dominantHandIdLabel.TabIndex = 12;
            dominantHandIdLabel.Text = "Ведущая рука";
            // 
            // dominantHandIdComboBox
            // 
            this.dominantHandIdComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dominantHandIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "DominantHandId", true));
            this.dominantHandIdComboBox.FormattingEnabled = true;
            this.dominantHandIdComboBox.Location = new System.Drawing.Point(135, 170);
            this.dominantHandIdComboBox.Name = "dominantHandIdComboBox";
            this.dominantHandIdComboBox.Size = new System.Drawing.Size(200, 21);
            this.dominantHandIdComboBox.TabIndex = 13;
            // 
            // genderIdLabel
            // 
            genderIdLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            genderIdLabel.AutoSize = true;
            genderIdLabel.Location = new System.Drawing.Point(33, 200);
            genderIdLabel.Name = "genderIdLabel";
            genderIdLabel.Size = new System.Drawing.Size(27, 13);
            genderIdLabel.TabIndex = 14;
            genderIdLabel.Text = "Пол";
            // 
            // genderIdComboBox
            // 
            this.genderIdComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.genderIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "genderId", true));
            this.genderIdComboBox.FormattingEnabled = true;
            this.genderIdComboBox.Location = new System.Drawing.Point(135, 197);
            this.genderIdComboBox.Name = "genderIdComboBox";
            this.genderIdComboBox.Size = new System.Drawing.Size(200, 21);
            this.genderIdComboBox.TabIndex = 15;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saveButton.Location = new System.Drawing.Point(36, 230);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(299, 23);
            this.saveButton.TabIndex = 16;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // CreateUpdateStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 317);
            this.Controls.Add(this.splitContainer);
            this.MinimumSize = new System.Drawing.Size(389, 356);
            this.Name = "CreateUpdateStudent";
            this.Text = "ВИЛЛИ | ДОБАВЛЕНИЕ СТУДЕНТА";
            this.Load += new System.EventHandler(this.CreateUpdateStudent_Load);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shapkin_06_WillieDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label titleLabel;
        private Shapkin_06_WillieDataSet shapkin_06_WillieDataSet;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private Shapkin_06_WillieDataSetTableAdapters.studentsTableAdapter studentsTableAdapter;
        private Shapkin_06_WillieDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DateTimePicker dateBirthDateTimePicker;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.MaskedTextBox phoneMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox emailMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox numcardMaskedTextBox;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.ComboBox dominantHandIdComboBox;
        private System.Windows.Forms.ComboBox genderIdComboBox;
    }
}