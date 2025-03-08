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
    public partial class AdopterForm : Form
    {

        private User currentUser;

        private AppDbContext context;
        public AdopterForm(User userFound)
        {
            InitializeComponent();


            currentUser = userFound;

            context = new AppDbContext();

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ControlBox = false;

            this.BackgroundImage = Image.FromFile("G:\\ITI .Net\\6 Linq & entity\\project\\Home4Pets\\Home4Pets\\Photos\\2.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;

            formLoadPets();
        }

        private void formLoadPets()
        {
            var availablePets = context.Pets.Where(p => p.AdoptionStatus == "Available")
                                            .Include(p => p.PetType)
                                            .Select(p => new
                                            {
                                                p.PetId,
                                                p.PetName,
                                                PetType = p.PetType.PetTypeName,
                                                p.Description,
                                                p.Age,
                                                p.HealthStatus,
                                                p.VaccinationStatus,
                                                p.AdoptionStatus
                                            }).ToList();

            dgv_AvailablePets.DataSource = availablePets;
            dgv_AvailablePets.Columns["PetId"].Visible = false;

            lab_userName.Text = currentUser.Username;

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            loginForm loginForm = new loginForm();

            loginForm.Show();

            this.Close();
        }

        private void btn_requestAdoption_Click(object sender, EventArgs e)
        {
            if (dgv_AvailablePets.SelectedRows.Count > 0)
            {
                try
                {
                    var selectedRow = dgv_AvailablePets.SelectedRows[0];
                    int petId = (int)selectedRow.Cells["PetId"].Value;

                    var selectedPet = context.Pets.FirstOrDefault(p => p.PetId == petId);
                    var currentUserInDb = context.Users.FirstOrDefault(u => u.UserId == currentUser.UserId);

                    if (selectedPet != null && currentUserInDb != null)
                    {
                        if (selectedPet.AdoptionStatus != "Available")
                        {
                            MessageBox.Show("This pet is not available for adoption.");
                            return;
                        }

                        var existingRequest = context.AdoptionRequests
                                                                    .FirstOrDefault(ar => ar.PetId == petId && ar.UserId == currentUser.UserId);

                        if (existingRequest != null)
                        {
                            MessageBox.Show("You have already sent an adoption request for this pet.");
                            return;
                        }

                        var adoptionRequest = new AdoptionRequest
                        {
                            PetId = selectedPet.PetId,
                            UserId = currentUser.UserId,
                            RequestDate = DateTime.Now,
                            Status = "Pending",
                            Remarks = txt_remarks.Text,
                        };

                        context.AdoptionRequests.Add(adoptionRequest);
                        context.SaveChanges();

                        MessageBox.Show("Adoption request sent successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Invalid Pet or User.");
                    }
                }
                catch (Exception ex)
                {
                    string errorMessage = "An error occurred: " + ex.Message;
                    if (ex.InnerException != null)
                    {
                        errorMessage += "\nInner Exception: " + ex.InnerException.Message;
                    }
                    MessageBox.Show(errorMessage);
                }
            }
            else
            {
                MessageBox.Show("Please select a pet to adopt.");
            }
        }

        private void viewRequests_Click(object sender, EventArgs e)
        {
            ViewAdopterRequests vAR = new ViewAdopterRequests(currentUser);

            vAR.Show();

            this.Close();
        }
    }
}
