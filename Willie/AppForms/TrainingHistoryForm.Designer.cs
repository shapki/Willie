
namespace Willie.AppForms
{
    partial class TrainingHistoryForm
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
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.shapkin_06_WillieDataSet = new Willie.Shapkin_06_WillieDataSet();
            this.programsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.programsTableAdapter = new Willie.Shapkin_06_WillieDataSetTableAdapters.programsTableAdapter();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsTableAdapter = new Willie.Shapkin_06_WillieDataSetTableAdapters.studentsTableAdapter();
            this.boxerTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.boxerTypesTableAdapter = new Willie.Shapkin_06_WillieDataSetTableAdapters.boxerTypesTableAdapter();
            this.trainingHistorySave = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentOneId = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.studentTwoBoxerId = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.programId = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.flowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shapkin_06_WillieDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxerTypesBindingSource)).BeginInit();
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
            this.splitContainer.Panel1.Controls.Add(this.trainingHistorySave);
            this.splitContainer.Panel1.Controls.Add(this.logoPictureBox);
            this.splitContainer.Panel1.Controls.Add(this.titleLabel);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.flowLayoutPanel);
            this.splitContainer.Size = new System.Drawing.Size(800, 450);
            this.splitContainer.SplitterDistance = 48;
            this.splitContainer.TabIndex = 1;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.logoPictureBox.Image = global::Willie.Properties.Resources.icon1;
            this.logoPictureBox.Location = new System.Drawing.Point(0, 0);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(51, 48);
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
            this.titleLabel.Size = new System.Drawing.Size(258, 25);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "ИСТОРИЯ ТРЕНИРОВОК";
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.Controls.Add(this.dataGridView1);
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(800, 398);
            this.flowLayoutPanel.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date,
            this.studentOneId,
            this.studentTwoBoxerId,
            this.programId,
            this.comment});
            this.dataGridView1.DataSource = this.programsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(794, 392);
            this.dataGridView1.TabIndex = 0;
            // 
            // shapkin_06_WillieDataSet
            // 
            this.shapkin_06_WillieDataSet.DataSetName = "Shapkin_06_WillieDataSet";
            this.shapkin_06_WillieDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // programsBindingSource
            // 
            this.programsBindingSource.DataMember = "programs";
            this.programsBindingSource.DataSource = this.shapkin_06_WillieDataSet;
            // 
            // programsTableAdapter
            // 
            this.programsTableAdapter.ClearBeforeFill = true;
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
            // boxerTypesBindingSource
            // 
            this.boxerTypesBindingSource.DataMember = "boxerTypes";
            this.boxerTypesBindingSource.DataSource = this.shapkin_06_WillieDataSet;
            // 
            // boxerTypesTableAdapter
            // 
            this.boxerTypesTableAdapter.ClearBeforeFill = true;
            // 
            // trainingHistorySave
            // 
            this.trainingHistorySave.BackColor = System.Drawing.Color.Red;
            this.trainingHistorySave.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.trainingHistorySave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.trainingHistorySave.Location = new System.Drawing.Point(724, 3);
            this.trainingHistorySave.Name = "trainingHistorySave";
            this.trainingHistorySave.Size = new System.Drawing.Size(73, 42);
            this.trainingHistorySave.TabIndex = 6;
            this.trainingHistorySave.Text = "Сохранить";
            this.trainingHistorySave.UseVisualStyleBackColor = false;
            // 
            // date
            // 
            this.date.HeaderText = "Дата";
            this.date.Name = "date";
            // 
            // studentOneId
            // 
            this.studentOneId.DataSource = this.studentsBindingSource;
            this.studentOneId.DisplayMember = "fullName";
            this.studentOneId.HeaderText = "Студент";
            this.studentOneId.Name = "studentOneId";
            this.studentOneId.ValueMember = "idStudent";
            // 
            // studentTwoBoxerId
            // 
            this.studentTwoBoxerId.DataPropertyName = "studentTwoBoxerId";
            this.studentTwoBoxerId.DataSource = this.boxerTypesBindingSource;
            this.studentTwoBoxerId.DisplayMember = "boxerType";
            this.studentTwoBoxerId.HeaderText = "Тип 2го студента";
            this.studentTwoBoxerId.Name = "studentTwoBoxerId";
            this.studentTwoBoxerId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.studentTwoBoxerId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.studentTwoBoxerId.ValueMember = "idBoxer";
            // 
            // programId
            // 
            this.programId.DataSource = this.programsBindingSource;
            this.programId.HeaderText = "Тип программы";
            this.programId.Name = "programId";
            this.programId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.programId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.programId.ValueMember = "idProgram";
            // 
            // comment
            // 
            this.comment.HeaderText = "Комментарий";
            this.comment.Name = "comment";
            // 
            // TrainingHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer);
            this.Name = "TrainingHistoryForm";
            this.Text = "ВИЛЛИ | ИСТОРИЯ ТРЕНИРОВОК";
            this.Load += new System.EventHandler(this.TrainingHistoryForm_Load);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.flowLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shapkin_06_WillieDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxerTypesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Shapkin_06_WillieDataSet shapkin_06_WillieDataSet;
        private System.Windows.Forms.BindingSource programsBindingSource;
        private Shapkin_06_WillieDataSetTableAdapters.programsTableAdapter programsTableAdapter;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private Shapkin_06_WillieDataSetTableAdapters.studentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.BindingSource boxerTypesBindingSource;
        private Shapkin_06_WillieDataSetTableAdapters.boxerTypesTableAdapter boxerTypesTableAdapter;
        private System.Windows.Forms.Button trainingHistorySave;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewComboBoxColumn studentOneId;
        private System.Windows.Forms.DataGridViewComboBoxColumn studentTwoBoxerId;
        private System.Windows.Forms.DataGridViewComboBoxColumn programId;
        private System.Windows.Forms.DataGridViewTextBoxColumn comment;
    }
}