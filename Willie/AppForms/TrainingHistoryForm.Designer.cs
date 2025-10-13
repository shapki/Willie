
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
            this.trainingHistorySave = new System.Windows.Forms.Button();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentOneIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shapkin_06_WillieDataSet = new Willie.Shapkin_06_WillieDataSet();
            this.studentTwoBoxerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.boxerTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.programIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.programsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainingHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.programsTableAdapter = new Willie.Shapkin_06_WillieDataSetTableAdapters.programsTableAdapter();
            this.studentsTableAdapter = new Willie.Shapkin_06_WillieDataSetTableAdapters.studentsTableAdapter();
            this.boxerTypesTableAdapter = new Willie.Shapkin_06_WillieDataSetTableAdapters.boxerTypesTableAdapter();
            this.trainingHistoryTableAdapter = new Willie.Shapkin_06_WillieDataSetTableAdapters.trainingHistoryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.flowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shapkin_06_WillieDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxerTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingHistoryBindingSource)).BeginInit();
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
            this.splitContainer.Size = new System.Drawing.Size(803, 450);
            this.splitContainer.SplitterDistance = 48;
            this.splitContainer.TabIndex = 1;
            // 
            // trainingHistorySave
            // 
            this.trainingHistorySave.BackColor = System.Drawing.Color.Red;
            this.trainingHistorySave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.trainingHistorySave.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.trainingHistorySave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.trainingHistorySave.Location = new System.Drawing.Point(724, 3);
            this.trainingHistorySave.Name = "trainingHistorySave";
            this.trainingHistorySave.Size = new System.Drawing.Size(73, 42);
            this.trainingHistorySave.TabIndex = 6;
            this.trainingHistorySave.Text = "Сохранить";
            this.trainingHistorySave.UseVisualStyleBackColor = false;
            this.trainingHistorySave.Click += new System.EventHandler(this.trainingHistorySave_Click);
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
            this.flowLayoutPanel.Size = new System.Drawing.Size(803, 398);
            this.flowLayoutPanel.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.studentOneIdDataGridViewTextBoxColumn,
            this.studentTwoBoxerIdDataGridViewTextBoxColumn,
            this.programIdDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.trainingHistoryBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(794, 392);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.CellParsing += new System.Windows.Forms.DataGridViewCellParsingEventHandler(this.dataGridView1_CellParsing);
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // studentOneIdDataGridViewTextBoxColumn
            // 
            this.studentOneIdDataGridViewTextBoxColumn.DataPropertyName = "studentOneId";
            this.studentOneIdDataGridViewTextBoxColumn.DataSource = this.studentsBindingSource;
            this.studentOneIdDataGridViewTextBoxColumn.DisplayMember = "fullName";
            this.studentOneIdDataGridViewTextBoxColumn.HeaderText = "Студент";
            this.studentOneIdDataGridViewTextBoxColumn.Name = "studentOneIdDataGridViewTextBoxColumn";
            this.studentOneIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.studentOneIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.studentOneIdDataGridViewTextBoxColumn.ValueMember = "idStudent";
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
            // studentTwoBoxerIdDataGridViewTextBoxColumn
            // 
            this.studentTwoBoxerIdDataGridViewTextBoxColumn.DataPropertyName = "studentTwoBoxerId";
            this.studentTwoBoxerIdDataGridViewTextBoxColumn.DataSource = this.boxerTypesBindingSource;
            this.studentTwoBoxerIdDataGridViewTextBoxColumn.DisplayMember = "boxerType";
            this.studentTwoBoxerIdDataGridViewTextBoxColumn.HeaderText = "Тип 2го студента";
            this.studentTwoBoxerIdDataGridViewTextBoxColumn.Name = "studentTwoBoxerIdDataGridViewTextBoxColumn";
            this.studentTwoBoxerIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.studentTwoBoxerIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.studentTwoBoxerIdDataGridViewTextBoxColumn.ValueMember = "idBoxer";
            // 
            // boxerTypesBindingSource
            // 
            this.boxerTypesBindingSource.DataMember = "boxerTypes";
            this.boxerTypesBindingSource.DataSource = this.shapkin_06_WillieDataSet;
            // 
            // programIdDataGridViewTextBoxColumn
            // 
            this.programIdDataGridViewTextBoxColumn.DataPropertyName = "programId";
            this.programIdDataGridViewTextBoxColumn.DataSource = this.programsBindingSource;
            this.programIdDataGridViewTextBoxColumn.DisplayMember = "hits";
            this.programIdDataGridViewTextBoxColumn.HeaderText = "Тип программы";
            this.programIdDataGridViewTextBoxColumn.Name = "programIdDataGridViewTextBoxColumn";
            this.programIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.programIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.programIdDataGridViewTextBoxColumn.ValueMember = "idProgram";
            // 
            // programsBindingSource
            // 
            this.programsBindingSource.DataMember = "programs";
            this.programsBindingSource.DataSource = this.shapkin_06_WillieDataSet;
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Комментарий";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            // 
            // trainingHistoryBindingSource
            // 
            this.trainingHistoryBindingSource.DataMember = "trainingHistory";
            this.trainingHistoryBindingSource.DataSource = this.shapkin_06_WillieDataSet;
            // 
            // programsTableAdapter
            // 
            this.programsTableAdapter.ClearBeforeFill = true;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // boxerTypesTableAdapter
            // 
            this.boxerTypesTableAdapter.ClearBeforeFill = true;
            // 
            // trainingHistoryTableAdapter
            // 
            this.trainingHistoryTableAdapter.ClearBeforeFill = true;
            // 
            // TrainingHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
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
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shapkin_06_WillieDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxerTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingHistoryBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource trainingHistoryBindingSource;
        private Shapkin_06_WillieDataSetTableAdapters.trainingHistoryTableAdapter trainingHistoryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn studentOneIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn studentTwoBoxerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn programIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
    }
}