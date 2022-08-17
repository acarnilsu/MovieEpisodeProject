using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer.Entities;
using FacadeLayer.Dal;
using BusinessLogicLayer.BL;

namespace MovieEpisodeProject.Formlar
{
    public partial class FrmActor : Form
    {
        public FrmActor()
        {
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            List<EntityActor> entityActors = BLActor.BLActorList();
            dataGridView1.DataSource=entityActors;
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            EntityActor entityActor = new EntityActor();
            entityActor.actorName=txtName.Text;
            entityActor.actorSurname=txtSurname.Text;
            entityActor.actorAge = txtAge.Text;
            BLActor.BLAddActor(entityActor);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            BLActor.BLDeleteActor(id);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            EntityActor ent=new EntityActor();
            ent.actorID=int.Parse(txtID.Text);
            ent.actorName=txtName.Text;
            ent.actorSurname = txtSurname.Text;
            ent.actorAge=txtAge.Text;
            BLActor.BLUpdateActor(ent);
        }
    }
}
