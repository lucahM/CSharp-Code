namespace VersionControl1
{
    partial class frmFinsurvVersionControl
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
            this.dgvVersions = new System.Windows.Forms.DataGridView();
            this.devDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uATSTAGINGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procFinsurvOutOfSynchFilesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finsurv_Version_ControlDataSet = new VersionControl1.Finsurv_Version_ControlDataSet();
            this.procFinsurvOutOfSynchFilesTableAdapter = new VersionControl1.Finsurv_Version_ControlDataSetTableAdapters.procFinsurvOutOfSynchFilesTableAdapter();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvFinsurv = new System.Windows.Forms.DataGridView();
            this.devDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uATSTAGINGDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procFinsurvFilesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finsurv_Version_ControlDataSet1 = new VersionControl1.Finsurv_Version_ControlDataSet1();
            this.procFinsurvFilesTableAdapter = new VersionControl1.Finsurv_Version_ControlDataSet1TableAdapters.procFinsurvFilesTableAdapter();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtVersion = new System.Windows.Forms.TextBox();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbFileName = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbEnvironment = new System.Windows.Forms.ComboBox();
            this.btnReload = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrintUnmached = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVersions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.procFinsurvOutOfSynchFilesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finsurv_Version_ControlDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinsurv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.procFinsurvFilesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finsurv_Version_ControlDataSet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVersions
            // 
            this.dgvVersions.AllowUserToAddRows = false;
            this.dgvVersions.AllowUserToDeleteRows = false;
            this.dgvVersions.AutoGenerateColumns = false;
            this.dgvVersions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVersions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.devDataGridViewTextBoxColumn,
            this.uATSTAGINGDataGridViewTextBoxColumn,
            this.prodDataGridViewTextBoxColumn});
            this.dgvVersions.DataSource = this.procFinsurvOutOfSynchFilesBindingSource;
            this.dgvVersions.Location = new System.Drawing.Point(16, 69);
            this.dgvVersions.Name = "dgvVersions";
            this.dgvVersions.ReadOnly = true;
            this.dgvVersions.Size = new System.Drawing.Size(557, 208);
            this.dgvVersions.TabIndex = 0;
            // 
            // devDataGridViewTextBoxColumn
            // 
            this.devDataGridViewTextBoxColumn.DataPropertyName = "Dev";
            this.devDataGridViewTextBoxColumn.HeaderText = "Dev";
            this.devDataGridViewTextBoxColumn.Name = "devDataGridViewTextBoxColumn";
            this.devDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uATSTAGINGDataGridViewTextBoxColumn
            // 
            this.uATSTAGINGDataGridViewTextBoxColumn.DataPropertyName = "UAT_STAGING";
            this.uATSTAGINGDataGridViewTextBoxColumn.HeaderText = "UAT_STAGING";
            this.uATSTAGINGDataGridViewTextBoxColumn.Name = "uATSTAGINGDataGridViewTextBoxColumn";
            this.uATSTAGINGDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prodDataGridViewTextBoxColumn
            // 
            this.prodDataGridViewTextBoxColumn.DataPropertyName = "Prod";
            this.prodDataGridViewTextBoxColumn.HeaderText = "Prod";
            this.prodDataGridViewTextBoxColumn.Name = "prodDataGridViewTextBoxColumn";
            this.prodDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // procFinsurvOutOfSynchFilesBindingSource
            // 
            this.procFinsurvOutOfSynchFilesBindingSource.DataMember = "procFinsurvOutOfSynchFiles";
            this.procFinsurvOutOfSynchFilesBindingSource.DataSource = this.finsurv_Version_ControlDataSet;
            // 
            // finsurv_Version_ControlDataSet
            // 
            this.finsurv_Version_ControlDataSet.DataSetName = "Finsurv_Version_ControlDataSet";
            this.finsurv_Version_ControlDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // procFinsurvOutOfSynchFilesTableAdapter
            // 
            this.procFinsurvOutOfSynchFilesTableAdapter.ClearBeforeFill = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(828, 25);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Exit";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvFinsurv
            // 
            this.dgvFinsurv.AutoGenerateColumns = false;
            this.dgvFinsurv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFinsurv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.devDataGridViewTextBoxColumn1,
            this.uATSTAGINGDataGridViewTextBoxColumn1,
            this.prodDataGridViewTextBoxColumn1});
            this.dgvFinsurv.DataSource = this.procFinsurvFilesBindingSource;
            this.dgvFinsurv.Location = new System.Drawing.Point(12, 323);
            this.dgvFinsurv.Name = "dgvFinsurv";
            this.dgvFinsurv.Size = new System.Drawing.Size(891, 313);
            this.dgvFinsurv.TabIndex = 4;
            // 
            // devDataGridViewTextBoxColumn1
            // 
            this.devDataGridViewTextBoxColumn1.DataPropertyName = "Dev";
            this.devDataGridViewTextBoxColumn1.HeaderText = "Dev";
            this.devDataGridViewTextBoxColumn1.Name = "devDataGridViewTextBoxColumn1";
            this.devDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // uATSTAGINGDataGridViewTextBoxColumn1
            // 
            this.uATSTAGINGDataGridViewTextBoxColumn1.DataPropertyName = "UAT_STAGING";
            this.uATSTAGINGDataGridViewTextBoxColumn1.HeaderText = "UAT_STAGING";
            this.uATSTAGINGDataGridViewTextBoxColumn1.Name = "uATSTAGINGDataGridViewTextBoxColumn1";
            this.uATSTAGINGDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // prodDataGridViewTextBoxColumn1
            // 
            this.prodDataGridViewTextBoxColumn1.DataPropertyName = "Prod";
            this.prodDataGridViewTextBoxColumn1.HeaderText = "Prod";
            this.prodDataGridViewTextBoxColumn1.Name = "prodDataGridViewTextBoxColumn1";
            this.prodDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // procFinsurvFilesBindingSource
            // 
            this.procFinsurvFilesBindingSource.DataMember = "procFinsurvFiles";
            this.procFinsurvFilesBindingSource.DataSource = this.finsurv_Version_ControlDataSet1;
            // 
            // finsurv_Version_ControlDataSet1
            // 
            this.finsurv_Version_ControlDataSet1.DataSetName = "Finsurv_Version_ControlDataSet1";
            this.finsurv_Version_ControlDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // procFinsurvFilesTableAdapter
            // 
            this.procFinsurvFilesTableAdapter.ClearBeforeFill = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(185, 209);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(117, 23);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update Record";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtVersion
            // 
            this.txtVersion.Location = new System.Drawing.Point(141, 173);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.Size = new System.Drawing.Size(161, 20);
            this.txtVersion.TabIndex = 3;
            // 
            // dtDate
            // 
            this.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDate.Location = new System.Drawing.Point(141, 130);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(161, 20);
            this.dtDate.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbFileName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtVersion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbEnvironment);
            this.groupBox1.Controls.Add(this.dtDate);
            this.groupBox1.Location = new System.Drawing.Point(595, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 248);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update Files";
            // 
            // cmbFileName
            // 
            this.cmbFileName.FormattingEnabled = true;
            this.cmbFileName.Location = new System.Drawing.Point(141, 77);
            this.cmbFileName.Name = "cmbFileName";
            this.cmbFileName.Size = new System.Drawing.Size(161, 21);
            this.cmbFileName.TabIndex = 7;
            this.cmbFileName.SelectedIndexChanged += new System.EventHandler(this.cmbFileName_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "File Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Version";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Environment";
            // 
            // cmbEnvironment
            // 
            this.cmbEnvironment.FormattingEnabled = true;
            this.cmbEnvironment.Items.AddRange(new object[] {
            "Finsurv_Development",
            "Finsurv_UAT_Staging",
            "Finsurv_Production"});
            this.cmbEnvironment.Location = new System.Drawing.Point(141, 22);
            this.cmbEnvironment.Name = "cmbEnvironment";
            this.cmbEnvironment.Size = new System.Drawing.Size(161, 21);
            this.cmbEnvironment.TabIndex = 2;
            this.cmbEnvironment.SelectedIndexChanged += new System.EventHandler(this.cmbEnvironment_SelectedIndexChanged);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(595, 25);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(75, 23);
            this.btnReload.TabIndex = 8;
            this.btnReload.Text = "Refresh";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(217, 29);
            this.label7.TabIndex = 9;
            this.label7.Text = "Out of sync Files";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Finsurv App Files";
            // 
            // btnPrintUnmached
            // 
            this.btnPrintUnmached.Location = new System.Drawing.Point(422, 25);
            this.btnPrintUnmached.Name = "btnPrintUnmached";
            this.btnPrintUnmached.Size = new System.Drawing.Size(151, 23);
            this.btnPrintUnmached.TabIndex = 11;
            this.btnPrintUnmached.Text = "Print unmatched files";
            this.btnPrintUnmached.UseVisualStyleBackColor = true;
            this.btnPrintUnmached.Click += new System.EventHandler(this.BtnPrintUnmached_Click);
            // 
            // frmFinsurvVersionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 646);
            this.Controls.Add(this.btnPrintUnmached);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvFinsurv);
            this.Controls.Add(this.dgvVersions);
            this.Controls.Add(this.btnClose);
            this.Name = "frmFinsurvVersionControl";
            this.Text = "Finsurv Application Version Control";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVersions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.procFinsurvOutOfSynchFilesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finsurv_Version_ControlDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinsurv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.procFinsurvFilesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finsurv_Version_ControlDataSet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVersions;
        private Finsurv_Version_ControlDataSet finsurv_Version_ControlDataSet;
        private System.Windows.Forms.BindingSource procFinsurvOutOfSynchFilesBindingSource;
        private Finsurv_Version_ControlDataSetTableAdapters.procFinsurvOutOfSynchFilesTableAdapter procFinsurvOutOfSynchFilesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn devDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uATSTAGINGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvFinsurv;
        private Finsurv_Version_ControlDataSet1 finsurv_Version_ControlDataSet1;
        private System.Windows.Forms.BindingSource procFinsurvFilesBindingSource;
        private Finsurv_Version_ControlDataSet1TableAdapters.procFinsurvFilesTableAdapter procFinsurvFilesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn devDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn uATSTAGINGDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtVersion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbEnvironment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbFileName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrintUnmached;
    }
}
