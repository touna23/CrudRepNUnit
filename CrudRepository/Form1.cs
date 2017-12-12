using CF.Data;
using CrudRepository.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrudRepository.LanguageExtensions;
using CF.Repo;
using CF.Repo.Common;
using CF.Service;

namespace CrudRepository
{
    public partial class Form1 : Form
    {
        private SortableBindingList<Student> blStudents = new SortableBindingList<Student>();
        private BindingSource bsStudents = new BindingSource();

        private IStudentService _studentService;
        private IDepartementService _deptService;

        public Form1(IStudentService studentService)
        {
            this._studentService = studentService;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StudentController students = new StudentController(_studentService);

            blStudents = new SortableBindingList<Student>(students.GetAll());

            bsStudents.DataSource = blStudents;
            dataGridView1.DataSource = bsStudents;

            SetupDataBindingsForLabels();
            PrepareDataGridViewColumns();

            comboStudent.DataSource = students.GetAll();
            comboStudent.DisplayMember = "FirstName";
            comboStudent.ValueMember = "Id";
        }

        private void SetupDataBindingsForLabels()
        {
            lblProductIdentifier.DataBindings.Add("text", bsStudents, "Id");
            lblProductName.DataBindings.Add("text", bsStudents, "FirstName");
        }

        private void PrepareDataGridViewColumns()
        {
            List<string> hideColumns = new List<string>() { "Id", "AddedDate", "ModifiedDate", "IPAddress" };

            foreach (string colName in hideColumns)
            {
                if (dataGridView1.Columns.Contains(colName))
                {
                    dataGridView1.Columns[colName].Visible = false;
                }
            }

            dataGridView1.ExpandColumns();
        }

        private void AddNewStudent()
        {
            Student student = new Student();
            EditorForm f = new EditorForm(student);
            try
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    blStudents.Add(student);
                    blStudents.ResetBindings();
                    dataGridView1.Sort(dataGridView1.Columns["FirstName"], ListSortDirection.Ascending);
                }
            }
            finally
            {
                f.Dispose();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddNewStudent();
        }

        private void cmdEditCurrent_Click(object sender, EventArgs e)
        {
            EditCurrentRow();
        }

        private void EditCurrentRow()
        {

            Student student = blStudents.Where(c => c.Id == bsStudents.StudentIdentifier()).AsQueryable().FirstOrDefault();

            //Student student = blStudents.FirstOrDefault(stud => stud.Id == bsStudents.StudentIdentifier());
            EditorForm f = new EditorForm(student);

            try
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    bsStudents.ResetCurrentItem();
                }
            }
            finally
            {
                f.Dispose();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ////Student student = blStudents.FirstOrDefault(stud => stud.Id == bsStudents.StudentIdentifier());
            ////StudentController Students = new StudentController();
            ////Students.deleteStudent(student);
            ////bsStudents.RemoveCurrent();
            ////ActiveControl = dataGridView1;



            //Customers customers = new Customers();
            //customers.Remove(bsCustomers.Customer());

            //ActiveControl = dataGridView1;


        }
    }
}
