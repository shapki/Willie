
namespace Willie.AppForms
{
    partial class CreateUpdateStudentForm
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
            this.dateBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shapkin_06_WillieDataSet = new Willie.Shapkin_06_WillieDataSet();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.phoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.numcardMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.dominantHandIdComboBox = new System.Windows.Forms.ComboBox();
            this.dominantHandBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.genderIdComboBox = new System.Windows.Forms.ComboBox();
            this.genderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saveButton = new System.Windows.Forms.Button();
            this.studentsTableAdapter = new Willie.Shapkin_06_WillieDataSetTableAdapters.studentsTableAdapter();
            this.tableAdapterManager = new Willie.Shapkin_06_WillieDataSetTableAdapters.TableAdapterManager();
            this.dominantHandTableAdapter = new Willie.Shapkin_06_WillieDataSetTableAdapters.dominantHandTableAdapter();
            this.genderTableAdapter = new Willie.Shapkin_06_WillieDataSetTableAdapters.genderTableAdapter();
            this.heightNumericUpDown = new System.Windows.Forms.NumericUpDown();
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
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shapkin_06_WillieDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dominantHandBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // dateBirthLabel
            // 
            dateBirthLabel.AutoSize = true;
            dateBirthLabel.Location = new System.Drawing.Point(33, 16);
            dateBirthLabel.Name = "dateBirthLabel";
            dateBirthLabel.Size = new System.Drawing.Size(87, 13);
            dateBirthLabel.TabIndex = 16;
            dateBirthLabel.Text = "Дата Рождения";
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Location = new System.Drawing.Point(33, 41);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new System.Drawing.Size(34, 13);
            fullNameLabel.TabIndex = 18;
            fullNameLabel.Text = "ФИО";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(33, 67);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(52, 13);
            phoneLabel.TabIndex = 20;
            phoneLabel.Text = "Телефон";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(33, 93);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(37, 13);
            emailLabel.TabIndex = 22;
            emailLabel.Text = "Почта";
            // 
            // numcardLabel
            // 
            numcardLabel.AutoSize = true;
            numcardLabel.Location = new System.Drawing.Point(33, 119);
            numcardLabel.Name = "numcardLabel";
            numcardLabel.Size = new System.Drawing.Size(75, 13);
            numcardLabel.TabIndex = 24;
            numcardLabel.Text = "Номер карты";
            // 
            // heightLabel
            // 
            heightLabel.AutoSize = true;
            heightLabel.Location = new System.Drawing.Point(33, 145);
            heightLabel.Name = "heightLabel";
            heightLabel.Size = new System.Drawing.Size(31, 13);
            heightLabel.TabIndex = 26;
            heightLabel.Text = "Рост";
            // 
            // dominantHandIdLabel
            // 
            dominantHandIdLabel.AutoSize = true;
            dominantHandIdLabel.Location = new System.Drawing.Point(33, 171);
            dominantHandIdLabel.Name = "dominantHandIdLabel";
            dominantHandIdLabel.Size = new System.Drawing.Size(78, 13);
            dominantHandIdLabel.TabIndex = 28;
            dominantHandIdLabel.Text = "Ведущая рука";
            // 
            // genderIdLabel
            // 
            genderIdLabel.AutoSize = true;
            genderIdLabel.Location = new System.Drawing.Point(33, 198);
            genderIdLabel.Name = "genderIdLabel";
            genderIdLabel.Size = new System.Drawing.Size(27, 13);
            genderIdLabel.TabIndex = 30;
            genderIdLabel.Text = "Пол";
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
            this.splitContainer.Panel2.Controls.Add(this.heightNumericUpDown);
            this.splitContainer.Panel2.Controls.Add(dateBirthLabel);
            this.splitContainer.Panel2.Controls.Add(this.dateBirthDateTimePicker);
            this.splitContainer.Panel2.Controls.Add(fullNameLabel);
            this.splitContainer.Panel2.Controls.Add(this.fullNameTextBox);
            this.splitContainer.Panel2.Controls.Add(phoneLabel);
            this.splitContainer.Panel2.Controls.Add(this.phoneMaskedTextBox);
            this.splitContainer.Panel2.Controls.Add(emailLabel);
            this.splitContainer.Panel2.Controls.Add(this.emailTextBox);
            this.splitContainer.Panel2.Controls.Add(numcardLabel);
            this.splitContainer.Panel2.Controls.Add(this.numcardMaskedTextBox);
            this.splitContainer.Panel2.Controls.Add(heightLabel);
            this.splitContainer.Panel2.Controls.Add(dominantHandIdLabel);
            this.splitContainer.Panel2.Controls.Add(this.dominantHandIdComboBox);
            this.splitContainer.Panel2.Controls.Add(genderIdLabel);
            this.splitContainer.Panel2.Controls.Add(this.genderIdComboBox);
            this.splitContainer.Panel2.Controls.Add(this.saveButton);
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
            // dateBirthDateTimePicker
            // 
            this.dateBirthDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.studentsBindingSource, "dateBirth", true));
            this.dateBirthDateTimePicker.Location = new System.Drawing.Point(135, 12);
            this.dateBirthDateTimePicker.Name = "dateBirthDateTimePicker";
            this.dateBirthDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateBirthDateTimePicker.TabIndex = 17;
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "students";
            this.studentsBindingSource.DataSource = this.shapkin_06_WillieDataSet;
            // 
            // shapkin_06_WillieDataSet
            // 
            this.shapkin_06_WillieDataSet.DataSetName = "Shapkin_06_WillieDataSet";
            this.shapkin_06_WillieDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "fullName", true));
            this.fullNameTextBox.Location = new System.Drawing.Point(135, 38);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.fullNameTextBox.TabIndex = 19;
            // 
            // phoneMaskedTextBox
            // 
            this.phoneMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "phone", true));
            this.phoneMaskedTextBox.Location = new System.Drawing.Point(135, 64);
            this.phoneMaskedTextBox.Mask = "+0 000 000 00 00";
            this.phoneMaskedTextBox.Name = "phoneMaskedTextBox";
            this.phoneMaskedTextBox.Size = new System.Drawing.Size(200, 20);
            this.phoneMaskedTextBox.TabIndex = 21;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "email", true));
            this.emailTextBox.Location = new System.Drawing.Point(135, 90);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(200, 20);
            this.emailTextBox.TabIndex = 23;
            // 
            // numcardMaskedTextBox
            // 
            this.numcardMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "numcard", true));
            this.numcardMaskedTextBox.Location = new System.Drawing.Point(135, 116);
            this.numcardMaskedTextBox.Name = "numcardMaskedTextBox";
            this.numcardMaskedTextBox.Size = new System.Drawing.Size(200, 20);
            this.numcardMaskedTextBox.TabIndex = 25;
            // 
            // dominantHandIdComboBox
            // 
            this.dominantHandIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "DominantHandId", true));
            this.dominantHandIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.studentsBindingSource, "DominantHandId", true));
            this.dominantHandIdComboBox.DataSource = this.dominantHandBindingSource;
            this.dominantHandIdComboBox.DisplayMember = "typeDominantHand";
            this.dominantHandIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dominantHandIdComboBox.FormattingEnabled = true;
            this.dominantHandIdComboBox.Location = new System.Drawing.Point(135, 168);
            this.dominantHandIdComboBox.Name = "dominantHandIdComboBox";
            this.dominantHandIdComboBox.Size = new System.Drawing.Size(200, 21);
            this.dominantHandIdComboBox.TabIndex = 29;
            this.dominantHandIdComboBox.ValueMember = "idDominantHand";
            // 
            // dominantHandBindingSource
            // 
            this.dominantHandBindingSource.DataMember = "dominantHand";
            this.dominantHandBindingSource.DataSource = this.shapkin_06_WillieDataSet;
            // 
            // genderIdComboBox
            // 
            this.genderIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "genderId", true));
            this.genderIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.studentsBindingSource, "genderId", true));
            this.genderIdComboBox.DataSource = this.genderBindingSource;
            this.genderIdComboBox.DisplayMember = "typeGender";
            this.genderIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderIdComboBox.FormattingEnabled = true;
            this.genderIdComboBox.Location = new System.Drawing.Point(135, 195);
            this.genderIdComboBox.Name = "genderIdComboBox";
            this.genderIdComboBox.Size = new System.Drawing.Size(200, 21);
            this.genderIdComboBox.TabIndex = 31;
            this.genderIdComboBox.ValueMember = "idGender";
            // 
            // genderBindingSource
            // 
            this.genderBindingSource.DataMember = "gender";
            this.genderBindingSource.DataSource = this.shapkin_06_WillieDataSet;
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
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
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
            // dominantHandTableAdapter
            // 
            this.dominantHandTableAdapter.ClearBeforeFill = true;
            // 
            // genderTableAdapter
            // 
            this.genderTableAdapter.ClearBeforeFill = true;
            // 
            // heightNumericUpDown
            // 
            this.heightNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.studentsBindingSource, "height", true));
            this.heightNumericUpDown.Location = new System.Drawing.Point(135, 142);
            this.heightNumericUpDown.Maximum = new decimal(new int[] {
            210,
            0,
            0,
            0});
            this.heightNumericUpDown.Minimum = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.heightNumericUpDown.Name = "heightNumericUpDown";
            this.heightNumericUpDown.Size = new System.Drawing.Size(200, 20);
            this.heightNumericUpDown.TabIndex = 32;
            this.heightNumericUpDown.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // CreateUpdateStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 317);
            this.Controls.Add(this.splitContainer);
            this.MinimumSize = new System.Drawing.Size(389, 356);
            this.Name = "CreateUpdateStudentForm";
            this.Text = "ВИЛЛИ | ДОБАВЛЕНИЕ СТУДЕНТА";
            this.Load += new System.EventHandler(this.CreateUpdateStudent_Load);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shapkin_06_WillieDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dominantHandBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightNumericUpDown)).EndInit();
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
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.MaskedTextBox numcardMaskedTextBox;
        private System.Windows.Forms.ComboBox dominantHandIdComboBox;
        private System.Windows.Forms.ComboBox genderIdComboBox;
        private System.Windows.Forms.BindingSource dominantHandBindingSource;
        private Shapkin_06_WillieDataSetTableAdapters.dominantHandTableAdapter dominantHandTableAdapter;
        private System.Windows.Forms.BindingSource genderBindingSource;
        private Shapkin_06_WillieDataSetTableAdapters.genderTableAdapter genderTableAdapter;
        private System.Windows.Forms.NumericUpDown heightNumericUpDown;
    }
}