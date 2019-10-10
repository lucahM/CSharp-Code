using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace VersionControl1
{
    public partial class frmFinsurvVersionControl : Form
    {
        public frmFinsurvVersionControl()
        {
            InitializeComponent();
        }

        public void Printing()
        {
            PrintDialog pd = new PrintDialog();
            PrintDocument pdoc = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            Font font = new Font("Arial", 10);
            PaperSize psz = new PaperSize("Custom", 100, 200);

            pd.Document = pdoc;
            pd.Document.DefaultPageSettings.PaperSize = psz;
            pdoc.DefaultPageSettings.PaperSize.Height = 820;
            pdoc.DefaultPageSettings.PaperSize.Width = 700;
            pdoc.PrintPage += new PrintPageEventHandler(pdoc_PrintPage);

            DialogResult res = pd.ShowDialog();

            if (res == DialogResult.OK)
            {
                PrintPreviewDialog prv = new PrintPreviewDialog();
                prv.Document = pdoc;
                res = prv.ShowDialog();

                if (res == DialogResult.OK)
                {
                    pdoc.Print();
                }
            }
        }

        private void pdoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font font = new Font("Courier New", 10);
            float fontHeight = font.GetHeight();
            int startX = 50;
            int startY = 65;
            int Offset = 40;

            graphics.DrawString("Unmatched Files", new Font("Courier New", 10), new SolidBrush(Color.Black), startX, startY + Offset);
            Offset += 20;
            string underline = "------------------------------------------";
            graphics.DrawString(underline, new Font("Courier New", 10), new SolidBrush(Color.Black), startX, startY + Offset);
            Offset += 20;

            int a = dgvVersions.Rows.Count;

            for (int i = 0; i < a; i++)
            {
                Offset += 20;
                graphics.DrawString("DEV: " +Convert.ToString(dgvVersions.Rows[i].Cells[0].Value), new Font("Courier New", 10), new SolidBrush(Color.Black), startX, startY + Offset);
                Offset += 20;
                graphics.DrawString("UAT: " +Convert.ToString(dgvVersions.Rows[i].Cells[1].Value), new Font("Courier New", 10), new SolidBrush(Color.Black), startX, startY + Offset);
                Offset += 20;
                graphics.DrawString("PROD: " +Convert.ToString(dgvVersions.Rows[i].Cells[2].Value), new Font("Courier New", 10), new SolidBrush(Color.Black), startX, startY + Offset);
                Offset += 20;
            }
        }

        public void FillCombobox()
        {
            using (SqlConnection conn = new SqlConnection("Data Source=.; Initial Catalog=Finsurv_Version_Control; User id=sa; Password=Password1;"))
            {
                conn.Open();
                if (cmbEnvironment.Text == "Finsurv_Development")
                {
                    using (var cmd = new SqlCommand("Select FILENAME From Finsurv_Development", conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cmbFileName.Items.Add(reader["FILENAME"].ToString());
                        }
                    }
                }

                if (cmbEnvironment.Text == "Finsurv_Production")
                {
                    using (var cmd = new SqlCommand("Select FILENAME From Finsurv_Production", conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cmbFileName.Items.Add(reader["FILENAME"].ToString());
                        }
                    }
                }

                if (cmbEnvironment.Text == "Finsurv_UAT_Staging")
                {
                    using (var cmd = new SqlCommand("Select FILENAME From Finsurv_UAT_Staging", conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cmbFileName.Items.Add(reader["FILENAME"].ToString());
                        }
                    }
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.procFinsurvFilesTableAdapter.Fill(this.finsurv_Version_ControlDataSet1.procFinsurvFiles);
            this.procFinsurvOutOfSynchFilesTableAdapter.Fill(this.finsurv_Version_ControlDataSet.procFinsurvOutOfSynchFiles);

            this.dgvVersions.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvVersions.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvVersions.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            this.dgvFinsurv.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvFinsurv.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvFinsurv.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            this.cmbEnvironment.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbFileName.DropDownStyle = ComboBoxStyle.DropDownList;

            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmbEnvironment_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtDate.Text = DateTime.Now.ToString();
            cmbFileName.Items.Clear();
            FillCombobox();
        }

        private void cmbFileName_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime date;
            string version;
            string tableName = cmbEnvironment.Text;
            using (SqlConnection conn = new SqlConnection("Data Source=.; Initial Catalog=Finsurv_Version_Control; User id=sa; Password=Password1;"))
            {
                string commands = string.Format("SELECT MODIFIED_DATE From {0} Where FILENAME = @FileName", tableName);
                SqlCommand cmd = new SqlCommand(commands, conn);
                cmd.Parameters.AddWithValue("@FileName", cmbFileName.Text);

                conn.Open();
                date = (DateTime)cmd.ExecuteScalar();
                dtDate.Text = date.ToString();
                conn.Close();

                string comm = string.Format("SELECT VERSION From {0} Where FILENAME = @FileName", tableName);
                SqlCommand cmds = new SqlCommand(comm, conn);
                cmds.Parameters.AddWithValue("@TableName", cmbEnvironment.Text);
                cmds.Parameters.AddWithValue("@FileName", cmbFileName.Text);

                conn.Open();
                if (cmds.ExecuteScalar() is System.DBNull)
                {
                    txtVersion.Text = "";
                    return;
                }
                version = (string)cmds.ExecuteScalar();
                txtVersion.Text = version;
                conn.Close();
                
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            procFinsurvFilesTableAdapter.Fill(finsurv_Version_ControlDataSet1.procFinsurvFiles);
            procFinsurvOutOfSynchFilesTableAdapter.Fill(finsurv_Version_ControlDataSet.procFinsurvOutOfSynchFiles);
            dtDate.Text = DateTime.Now.ToString();
            txtVersion.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string tableName = cmbEnvironment.Text;
            string sql = string.Format("Update {0} SET MODIFIED_DATE = @Date, VERSION = @Version WHERE FILENAME = @Filename ", tableName);
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=.; Initial Catalog=Finsurv_Version_Control; User id=sa; Password=Password1;"))
                using (var command = new SqlCommand(sql, conn))
                {
                    command.Parameters.Add("@Date", SqlDbType.Date).Value = dtDate.Text;
                    command.Parameters.Add("@Version", SqlDbType.VarChar).Value = txtVersion.Text;
                    command.Parameters.Add("@Filename", SqlDbType.VarChar).Value = cmbFileName.Text;

                    conn.Open();
                    command.ExecuteNonQuery();
                    command.Dispose();
                    conn.Close();

                    MessageBox.Show("File Information Succesfully Updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.procFinsurvOutOfSynchFilesTableAdapter.Fill(this.finsurv_Version_ControlDataSet.procFinsurvOutOfSynchFiles);
                    this.procFinsurvFilesTableAdapter.Fill(this.finsurv_Version_ControlDataSet1.procFinsurvFiles);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show($"Failed to update. Error Message: {err.Message}");
            }
        }

        private void BtnPrintUnmached_Click(object sender, EventArgs e)
        {
            Printing();
        }
    }
}
