using CF.Data;
using CF.Repo;
using CF.Repo.Common;
using CrudRepository.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudRepository
{
    public partial class EditorForm : Form
    {
        public Student student { get; set; }
        public bool Adding { get; set; }

        private UnitOfWork unitOfWork;
        private StudentRepository studentRepository;

        public EditorForm()
        {
            InitializeComponent();
            unitOfWork = new UnitOfWork();
            //studentRepository = unitOfWork.Repository<Student>();
        }

        public EditorForm(Student student)
        {
            InitializeComponent();
            unitOfWork = new UnitOfWork();
            //studentRepository = unitOfWork.Repository<Student>();
            this.student = student;

            if (string.IsNullOrWhiteSpace(student.FirstName))
            {
                Adding = true;
                this.Text = "Ajout";
            }
            else
            {
                Adding = false;
                this.Text = "Modification";

                txtNom.Text = student.FirstName;
                txtPrenom.Text = student.LastName;
                txtNumInsc.Text = student.EnrollmentNumber;
                txtMail.Text = student.Email;

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //StudentController Students = new StudentController();

                //student.FirstName = txtNom.Text;
                //student.LastName = txtPrenom.Text;
                //student.EnrollmentNumber = txtNumInsc.Text;
                //student.Email = txtMail.Text;
                //student.IPAddress = "exp";
                //student.ModifiedDate = DateTime.UtcNow;
                //if (Adding)
                //{
                //    student.AddedDate = DateTime.UtcNow;
                //    Students.AddStudent(student);
                //}
                //else
                //{
                //    //Students.UpdateStudent(student);
                //    studentRepository.Update(student);
                //}

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
