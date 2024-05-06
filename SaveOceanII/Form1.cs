using SaveOceanII.DTOs.Employee;
using SaveOceanII.GeneralUtils;
using SaveOceanII.Persistence.Mapping;
using SaveOceanII.Persistence.Utils;
using System.Windows.Forms;

namespace SaveOceanII
{
    public partial class Form1 : Form
    {
        private EmployeeDto ActualUSer;
        public Form1()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(250, 250);

            pnlLogin.Hide();

            JobDao jobCrud = new JobDao(NpgsqlUtils.OpenConnection());

            foreach (var job in jobCrud.GetJobs())
                cbbJob.Items.Add(job.Name);
        }

        private void bttPlay_Click(object sender, EventArgs e)
        {
            bttExit.Hide();
            bttPlay.Hide();
            LogInMenu();
        }

        private void bttExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LogInMenu()
        {
            this.Size = new System.Drawing.Size(800, 495);
            pnlLogin.Show();
        }
        private void EmpMenu()
        {

        }

        private void bttEnter_Click_1(object sender, EventArgs e)
        {
            errorProvider.Clear();
            string name = txtName.Text;
            string job = cbbJob.Text;
            string id = txtId.Text;

            if (name == string.Empty)
                errorProvider.SetError(lblName, "Introduiex nom");
            if (job == string.Empty)
                errorProvider.SetError(lblJob, "Selecciona ofici");
            if (name != string.Empty && name != string.Empty)
            {
                if (id != string.Empty && int.TryParse(id, out int empId))
                {


                }
                else
                {
                    EmployeeDao empCrud = new EmployeeDao(NpgsqlUtils.OpenConnection());

                    name = Txt.Name(txtName.Text);
                    empCrud.AddEmployee(new(name, cbbJob.Text));
                    ActualUSer = empCrud.GetEmployeeByName(name);
                    pnlLogin.Hide();
                }
            }
        }

    }
}
