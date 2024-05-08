using System.Reflection.Metadata;
using System.Security.Cryptography.Xml;
using System.Windows.Forms;
using System.Xml.Linq;
using SaveOceanII.DTOs.Animals;
using SaveOceanII.DTOs.Employee;
using SaveOceanII.GeneralUtils;
using SaveOceanII.Persistence.DAO;
using SaveOceanII.Persistence.Mapping;
using SaveOceanII.Persistence.Utils;
using SaveTheOceanII.DTOs.Animals;
using SaveTheOceanII.DTOs.AnimalsFiles;
using SaveTheOceanII.GeneralUtils;
using SaveTheOceanII.Persistence.Mapping;

namespace SaveOceanII
{
    public partial class Form1 : Form
    {
        const string LocBcn = "Barcelona",
            LocTrg = "Tarragona";
        const string FamCetacea = "Cetaci",
            FamBird = "Au marina",
            FamTurtle = "Tortuga marina";
        const string JobTec = "Tecnic",
            JobVet = "Veterinari";
        const string NameEspecie = "Specie",
            NameFamily = "Family",
            NameId = "Id",
            NameResId = "ResId",
            NameDate = "Date",
            NameGA = "GA",
            NameAFamily = "Family",
            NameLoc = "Location";
        const string HdrEspecie = "Especie",
            HdrFamily = "Familia",
            HdrId = "Id",
            HdrResId = "ResId",
            HdrDate = "Data",
            HdrGA = "G.Afecció",
            HdrAFamily = "Familia",
            HdrLoc = "Location";

        const int Zero = 0,
            One = 1;

        private EmployeeDto nowUser;
        private RescueFileDto nowFile;

        EmployeeDao employeeDao = new EmployeeDao(NpgsqlUtils.OpenConnection());
        CetaceaDao cetaceaDao = new CetaceaDao(NpgsqlUtils.OpenConnection());
        SeaBirdDao seaBirdDao = new SeaBirdDao(NpgsqlUtils.OpenConnection());
        SeaTurtleDao seaTurtleDao = new SeaTurtleDao(NpgsqlUtils.OpenConnection());
        RescueFileDao fileDao = new RescueFileDao(NpgsqlUtils.OpenConnection());
        AnimalDao animalDao = new AnimalDao(NpgsqlUtils.OpenConnection());

        List<string> Locs = [LocBcn, LocTrg];
        List<string> Families = [FamCetacea, FamBird, FamTurtle];
        List<string> jobs = [JobTec, JobVet];
        List<AnimalDto> dbAnimals;

        public Form1()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(250, 250);
            dbAnimals = animalDao.GetAnimals().ToList();

            pnlLogin.Hide();
            panel1.Hide();
            pnlRescue.Hide();
            pnlAnimlFiles.Hide();
            pnlRescueFiles.Hide();

            foreach (var job in jobs)
                cbbJob.Items.Add(job);
            foreach (var family in Families)
                cbbFamily.Items.Add(family);

            dgAnimals.Columns.Add(NameEspecie, HdrEspecie);
            dgAnimals.Columns.Add(NameFamily, HdrFamily);
            InsertDgAnimals(dbAnimals);

            dgFiles.Columns.Add(NameId, HdrId);
            dgFiles.Columns.Add(NameResId, HdrResId);
            dgFiles.Columns.Add(NameDate, HdrDate);

            dgFiles.Columns.Add(NameGA, HdrGA);
            dgFiles.Columns.Add(NameFamily, HdrFamily);
            dgFiles.Columns.Add(NameLoc, HdrLoc);
            InsertDgRescues(fileDao.GetRescueFile().ToList());
        }

        private void AdminPanel()
        {
            panel1.Show();
            lblNowEmpName.Text = nowUser.Name;
            lblNowEmpRol.Text = nowUser.Job;
            lblNowEmpId.Text = nowUser.Id.ToString();
        }

        #region rescue
        private void RescuePanel()
        {
            pnlAnimlFiles.Hide();
            pnlRescue.Show();
            pnlRescueFiles.Hide();
        }

        private void BttRescue_Click(object sender, EventArgs e)
        {
            RescuePanel();
        }

        private void LoadDataRescue()
        {
            lblResIdView.Text = nowFile.RescueId.ToString();
            lbllvlView.Text = nowFile.GA.ToString();
            lblLocView.Text = nowFile.Location;
            lblDateView.Text = nowFile.RescueDate.ToString();
            lblEspecieView.Text = nowFile.Family;
        }

        private void bttHeal_Click(object sender, EventArgs e)
        {
            Final(false);
        }

        private void bttMove_Click(object sender, EventArgs e)
        {
            Final(true);
        }

        private void Final(bool action)
        {
            string family = nowFile.Family;
            int GA = nowFile.GA;
            int result;
            int exp;
            switch (family)
            {
                case FamCetacea:
                    result = new CetaceaDto().Heal(GA, action);
                    break;
                case FamTurtle:
                    result = new SeaTurtleDto().Heal(GA, action);

                    break;
                default:
                    result = new SeaBirdDto().Heal(GA, action);

                    break;
            }
            if (result <= 30)
            {
                MessageBox.Show(
                    "El rescat ha estat un èxit, l’exemplar es podrà reintroduir al medi natural i el jugador guanyarà 50 punts d’experiència."
                );
                exp = 50;
            }
            else
            {
                MessageBox.Show(
                    "El rescat ha estat un fracàs, l’exemplar haurà de ser traslladat al CRAM per ser examinat i el jugador perdrà 20 punts d’experiència"
                );
                exp = -20;
            }
            fileDao.AddRescueFile(nowFile);
            nowUser.Exp += exp;
            MessageBox.Show(nowUser.ToString());
            Xml.Create(nowUser);
            this.Close();
        }
        #endregion
        #region animals
        private void AnimalPanel()
        {
            pnlAnimlFiles.Show();
            pnlRescue.Hide();
            pnlRescueFiles.Hide();
            InsertDgAnimals(animalDao.GetAnimals().ToList());
        }

        private void BttModifi_Click(object sender, EventArgs e)
        {
            AnimalPanel();
        }

        private void InsertDgAnimals(List<AnimalDto> list)
        {
            dgAnimals.Rows.Clear();

            foreach (var X in list)
            {
                int index = dgAnimals.Rows.Add();
                dgAnimals.Rows[index].Cells[NameEspecie].Value = X.Species;
                dgAnimals.Rows[index].Cells[NameFamily].Value = X.Family;
            }
        }

        private void dgAnimals_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string specie = dgAnimals.Rows[e.RowIndex].Cells[Zero].Value.ToString();
            string family = dgAnimals.Rows[e.RowIndex].Cells[One].Value.ToString();
            if (!Families.Contains(family))
                MessageBox.Show("valors no valid");
            else if (!dbAnimals.Any(x => x.Species == specie))
                MessageBox.Show("no pots cambiar la especie");
            else
                try
                {
                    animalDao.UpdateAnimal(new() { Species = specie, Family = family });
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            if (family != dbAnimals.Where(x => x.Species == specie).FirstOrDefault().Family)
                InsertDgAnimals(animalDao.GetAnimals().ToList());
        }

        private void bttAddanimal_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            if (txtSpecie.Text == string.Empty)
                errorProvider.SetError(txtSpecie, "Introduiex la especie");
            if (cbbFamily.Text == string.Empty)
                errorProvider.SetError(cbbFamily, "Selecciona familia");
            if (cbbFamily.Text != string.Empty && txtSpecie.Text != string.Empty)
            {
                try
                {
                    animalDao.AddAnimal(
                        new() { Species = txtSpecie.Text, Family = cbbFamily.Text }
                    );
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            InsertDgAnimals(animalDao.GetAnimals().ToList());
        }

        #endregion animals

        #region rescueFiles
        private void RescueFles()
        {
            pnlRescueFiles.Show();
            pnlRescue.Hide();
            pnlAnimlFiles.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            RescueFles();
        }

        private void InsertDgRescues(List<RescueFileDto> list)
        {
            dgFiles.Rows.Clear();

            foreach (var X in list)
            {
                if (X != null)
                {
                    int index = dgFiles.Rows.Add();
                    dgFiles.Rows[index].Cells[NameId].Value = X.Id;
                    dgFiles.Rows[index].Cells[NameResId].Value = X.RescueId;
                    dgFiles.Rows[index].Cells[NameDate].Value = X.RescueDate;

                    dgFiles.Rows[index].Cells[NameGA].Value = X.GA;
                    dgFiles.Rows[index].Cells[NameFamily].Value = X.Family;
                    dgFiles.Rows[index].Cells[NameLoc].Value = X.Location;
                }
            }
        }

        private void bttSearchById_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            if (
                txtSearchById.Text != string.Empty
                && Int32.TryParse(txtSearchById.Text, out int id)
            )
            {
                InsertDgRescues([fileDao.GetRescueFileById(id)]);
            }
            else
            {
                errorProvider.SetError(txtSearchById, "Id no valida");
            }
        }

        private void txtSearchById_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchById.Text == string.Empty)
            {
                InsertDgRescues(fileDao.GetRescueFile().ToList());
            }
        }

        #endregion rescueFiles

        private void LogInMenu()
        {
            this.Size = new System.Drawing.Size(800, 495);
            pnlLogin.Show();
        }

        private void GenerateRescue()
        {
            Random rnd = new Random();

            switch (Families[rnd.Next(Zero, Families.Count)])
            {
                case FamCetacea:
                    List<CetaceaDto> Cetaceas = cetaceaDao.GetCetaceas().ToList();
                    nowFile = new RescueFileDto(
                        Cetaceas[rnd.Next(Zero, Cetaceas.Count)].Family,
                        Locs[rnd.Next(Zero, Locs.Count)]
                    );
                    break;
                case FamBird:
                    List<SeaBirdDto> seaBirds = seaBirdDao.GetSeaBirds().ToList();
                    nowFile = new RescueFileDto(
                        seaBirds[rnd.Next(Zero, seaBirds.Count)].Family,
                        Locs[rnd.Next(Zero, Locs.Count)]
                    );
                    break;
                case FamTurtle:
                    List<SeaTurtleDto> seaTurtles = seaTurtleDao.GetSeaTurtles().ToList();
                    nowFile = new RescueFileDto(
                        seaTurtles[rnd.Next(Zero, seaTurtles.Count)].Family,
                        Locs[rnd.Next(Zero, Locs.Count)]
                    );
                    break;
            }
        }

        private void BttEnter_Click_1(object sender, EventArgs e)
        {
            errorProvider.Clear();
            string name = txtName.Text;
            string job = cbbJob.Text;

            if (name == string.Empty)
                errorProvider.SetError(lblName, "Introduiex nom");
            if (job == string.Empty)
                errorProvider.SetError(lblJob, "Selecciona ofici");
            if (name != string.Empty && job != string.Empty)
            {
                name = Txt.Name(txtName.Text);
                employeeDao.AddEmployee(new(name, cbbJob.Text));
                nowUser = employeeDao.GetEmployeeByName(name);
                pnlLogin.Hide();
                AdminPanel();
                GenerateRescue();
                LoadDataRescue();
            }
        }

        private void BttPlay_Click(object sender, EventArgs e)
        {
            bttExit.Hide();
            bttPlay.Hide();
            LogInMenu();
        }

        private void BttExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgAnimals_SelectionChanged(object sender, EventArgs e)
        {
            // Verificar si no hay celdas seleccionadas
            if (dgAnimals.SelectedCells.Count == 0)
            {
                // Realizar acciones necesarias cuando se deselecciona una celda
            }
        }
    }
}
