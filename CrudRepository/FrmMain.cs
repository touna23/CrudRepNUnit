using CF.Data;
using CF.Repo;
using CF.Service;
using CrudRepository.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrudRepository.LanguageExtensions;
using NLog;
using CrudRepository.Utils.Nlog;

namespace CrudRepository
{

    public partial class FrmMain : Form
    {
        private Logger logger = LogManager.GetCurrentClassLogger();
        private SortableBindingList<Student> blStudents = new SortableBindingList<Student>();
        private BindingSource bsStudents = new BindingSource();
        

        IStudentService _studentService;
        IDepartementService _deptService;

        //public FrmMain(IStudentService studentService,IDepartementService deptService)
        //{
        //    this._deptService = deptService;
        //    this._studentService = studentService;
        //    InitializeComponent();
        //}
        public FrmMain()
        {
            _studentService = ContainerExtension.container.Resolve<IStudentService>();
            _deptService = ContainerExtension.container.Resolve<IDepartementService>();
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            LoadStudents();
            PrepareDataGridViewColumns();
            InitializeDepartmentList();
        }

        private void LoadStudents()
        {
            StudentController students = new StudentController(_studentService);
            var j = students.GetAll().ToList().Count();
            blStudents = new SortableBindingList<Student>(students.GetAll());
            bsStudents.DataSource = blStudents;
            dataGridView1.DataSource = bsStudents;
        }

        private void InitializeDepartmentList()
        {
            DepartementController departements = new DepartementController(_deptService);
            var i = departements.GetAll().ToList().Count();
            comboDept.DataSource = departements.GetAll();
            comboDept.DisplayMember = "Title";
            comboDept.ValueMember = "Id";
        }

        private void PrepareDataGridViewColumns()
        {
            List<string> hideColumns = new List<string>() { "Id", "AddedDate", "ModifiedDate", "IPAddress", "DeptId", "Departement" };

            foreach (string colName in hideColumns)
            {
                if (dataGridView1.Columns.Contains(colName))
                {
                    dataGridView1.Columns[colName].Visible = false;
                }
            }
            dataGridView1.ExpandColumns();
        }

        private void AddNewStudent_Click(object sender, EventArgs e)
        {
            int studentId = Convert.ToInt32(labelStudentId.Text);
            StudentController Students = new StudentController(_studentService);
            if (studentId == 0)
            {
                try
                {
                    Student student = new Student
                    {
                        FirstName = Txt_StudentName.Text,
                        LastName = txtPrenom.Text,
                        EnrollmentNumber = txtNumInsc.Text,
                        Email = txtMail.Text,
                        IPAddress = "exp",
                        ModifiedDate = DateTime.UtcNow,
                        DeptId = Convert.ToInt32(comboDept.SelectedValue)
                    };
                    student.AddedDate = DateTime.UtcNow;
                    Students.AddStudent(student);
                }
                catch (Exception ex)
                {
                    logger.Error(ex, "It seems the exception happened. :(");
                    throw ex;
                }
            }
            else
            {
                var studToUpdate = Students.GetByIdStudent(studentId);
                if (studToUpdate != null)
                {
                    studToUpdate.FirstName = Txt_StudentName.Text;
                    studToUpdate.LastName = txtPrenom.Text;
                    studToUpdate.EnrollmentNumber = txtNumInsc.Text;
                    studToUpdate.Email = txtMail.Text;
                    studToUpdate.ModifiedDate = DateTime.UtcNow;
                    studToUpdate.DeptId = Convert.ToInt32(comboDept.SelectedValue);
                }
                Students.UpdateStudent(studToUpdate);
            }
            MessageBox.Show(this, "Employee Saved Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadStudents();
        }

        private void AddDept_Click(object sender, EventArgs e)
        {
            frmManageDepartment frmManageDepartment = new frmManageDepartment()
            {
                RefreshDepartmentList = InitializeDepartmentList
            };
            frmManageDepartment.Show(this);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = null;

            if (dataGridView1.SelectedRows.Count > 0)
            {
                selectedRow = dataGridView1.SelectedRows[0];
            }
            if (selectedRow == null)
                return;
            labelStudentId.Text = selectedRow.Cells["Id"].Value.ToString();
            Txt_StudentName.Text = selectedRow.Cells["FirstName"].Value.ToString();
            txtPrenom.Text = selectedRow.Cells["LastName"].Value.ToString();
            txtNumInsc.Text = selectedRow.Cells["EnrollmentNumber"].Value.ToString();
            txtMail.Text = selectedRow.Cells["Email"].Value.ToString();
            comboDept.SelectedValue = Convert.ToInt32(selectedRow.Cells["DeptId"].Value.ToString());
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            labelStudentId.Text = "0";
            Txt_StudentName.Text = string.Empty;
            txtPrenom.Text = string.Empty;
            txtNumInsc.Text = string.Empty;
            txtMail.Text = string.Empty;
            comboDept.SelectedIndex = 0;
        }
    }
}
