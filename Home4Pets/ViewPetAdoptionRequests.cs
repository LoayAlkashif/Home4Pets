using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Home4Pets.Context;
using Home4Pets.Models;
using Microsoft.EntityFrameworkCore;

namespace Home4Pets
{
    public partial class ViewPetAdoptionRequests : Form
    {
        AppDbContext context;
        User userFound;
        public ViewPetAdoptionRequests(User user)
        {
            InitializeComponent();
            context = new AppDbContext();
            userFound = user;

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ControlBox = false;

            this.BackgroundImage = Image.FromFile("G:\\ITI .Net\\6 Linq & entity\\project\\Home4Pets\\Home4Pets\\Photos\\2.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;

            LoadRequests();
        }

        private void LoadRequests()
        {
            var petRequests = context.AdoptionRequests.Where(ar => ar.Pet.UserId == userFound.UserId)
                                                      .Include(ar => ar.Pet)
                                                      .Include(ar => ar.User)
                                                      .Select(ar => new
                                                      {
                                                          ar.PetId,
                                                          pet_name = ar.Pet.PetName,
                                                          Adopter_Name = ar.User.Username,
                                                          Adopter_Number = ar.User.Phone,
                                                          ar.RequestDate,
                                                          ar.Status,
                                                          ar.ApprovalDate,
                                                          ar.Remarks
                                                      }).ToList();

            dgv_petRequests.DataSource = petRequests;
            dgv_petRequests.Columns["PetId"].Visible = false;
        }

        private void btn_returnBack_Click(object sender, EventArgs e)
        {
            PetOwnerForm petOwnerForm = new PetOwnerForm(userFound);

            petOwnerForm.Show();

            this.Close();
        }

        private void btn_approveRequest_Click(object sender, EventArgs e)
        {
            if (dgv_petRequests.SelectedRows.Count > 0)
            {
                var selectedPetId = (int)dgv_petRequests.SelectedRows[0].Cells["PetId"].Value;

                var selectedRequest = context.AdoptionRequests
                                             .FirstOrDefault(ar => ar.PetId == selectedPetId);

                if (selectedRequest != null)
                {
                    selectedRequest.Status = "Approved";
                    selectedRequest.ApprovalDate = DateTime.Now;

                    var pet = context.Pets.FirstOrDefault(p => p.PetId == selectedPetId);
                    if (pet != null)
                    {
                        pet.AdoptionStatus = "Adopted";
                    }
                    context.SaveChanges();

                    MessageBox.Show("Request approved successfully");

                    LoadRequests();
                }
            }
        }
    }
}



