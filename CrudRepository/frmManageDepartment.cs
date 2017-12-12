using CF.Data;
using CF.Service;
using CrudRepository.Controller;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudRepository
{
    public delegate void RefreshDepartmentListDelegate();
    public partial class frmManageDepartment : Form
    {
        public RefreshDepartmentListDelegate RefreshDepartmentList;
        IDepartementService _deptService;

        private SortableBindingList<Departement> blDepartements = new SortableBindingList<Departement>();
        private BindingSource bsDepartements = new BindingSource();

        public frmManageDepartment()
        {
            _deptService = ContainerExtension.container.Resolve<IDepartementService>();
            InitializeComponent();
        }

        private void InitializeDepartmentList()
        {

            DepartementController departements = new DepartementController(_deptService);
            blDepartements = new SortableBindingList<Departement>(departements.GetAll());
            bsDepartements.DataSource = blDepartements;
            GridDepartement.DataSource = bsDepartements;
            GridDepartement.Columns[2].Visible = false;
        }

        private void SaveDept_Click(object sender, EventArgs e)
        {

            int deptId = Convert.ToInt32(Label_DeptId.Text);
            DepartementController Departements = new DepartementController(_deptService);
            if (deptId == 0)
            {
                try
                {
                    Departement departement = new Departement
                    {
                        Title = deptLabel.Text
                    };
                    Departements.AddDepartement(departement);
                    MessageBox.Show(this, "Departement Saved Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                var studToUpdate = Departements.GetByIdDepartement(deptId);
                if (studToUpdate != null)
                {
                    studToUpdate.Title = deptLabel.Text;
                }
                Departements.UpdateDepartement(studToUpdate);
            }

            InitializeDepartmentList();
        }

        private void frmManageDepartment_Load(object sender, EventArgs e)
        {
            InitializeDepartmentList();
        }

        private void ClearDep_Click(object sender, EventArgs e)
        {
            Label_DeptId.Text = "0";
            deptLabel.Text = string.Empty;
        }

        private void frmManageDepartment_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            if (RefreshDepartmentList != null)
                RefreshDepartmentList();
        }
    }
}
