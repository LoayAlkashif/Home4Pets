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
    public partial class PetOwnerForm : Form
    {
        private User userFound;
        private AppDbContext context;

        public PetOwnerForm(User user)
        {
            InitializeComponent();
            userFound = user;
            context = new AppDbContext();

            LoadComboBoxes();
            LoadPets();

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ControlBox = false;

            this.BackgroundImage = Image.FromFile("G:\\ITI .Net\\6 Linq & entity\\project\\Home4Pets\\Home4Pets\\Photos\\2.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;

            btn_updatePet.Visible = false;
            btn_deletePet.Visible = false;

            dgv_Pets.SelectionChanged += Dgv_Pets_SelectionChanged;
        }

        private void Dgv_Pets_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_Pets.SelectedRows.Count > 0)
            {
                btn_updatePet.Visible = true;
                btn_deletePet.Visible = true;

                btn_addPet.Visible = false;

                var selectedRow = dgv_Pets.SelectedRows[0];
                var petId = (int)selectedRow.Cells["PetId"].Value;

                var selectedPet = context.Pets
                    .Include(p => p.PetType)
                    .FirstOrDefault(p => p.PetId == petId);

                if (selectedPet != null)
                {
                    txt_petName.Text = selectedPet.PetName;
                    cb_petType.SelectedValue = selectedPet.PetTypeId;
                    txt_description.Text = selectedPet.Description;
                    nud_age.Value = selectedPet.Age;
                    cb_gender.SelectedItem = selectedPet.Gender;
                    cb_healthStatus.SelectedItem = selectedPet.HealthStatus;
                    cb_vaccinationStatus.SelectedItem = selectedPet.VaccinationStatus;
                }
            }
            else
            {
                btn_updatePet.Visible = false;
                btn_deletePet.Visible = false;
            }
        }

        private void LoadComboBoxes()
        {
            var petTypes = context.PetTypes.ToList();
            cb_petType.DataSource = petTypes;
            cb_petType.DisplayMember = "PetTypeName";
            cb_petType.ValueMember = "PetTypeId";

            cb_gender.Items.AddRange(new[] { "Male", "Female" });
            cb_healthStatus.Items.AddRange(new[] { "Healthy", "Needs Treatment" });
            cb_vaccinationStatus.Items.AddRange(new[] { "Vaccinated", "Not Vaccinated" });
        }

        private void LoadPets()
        {
            var userPets = context.Pets.Where(p => p.UserId == userFound.UserId)
                                       .Include(p => p.PetType)
                                       .ToList();

            var petsToDisplay = userPets.Select(p => new
            {
                p.PetId,
                p.PetName,
                PetType = p.PetType?.PetTypeName,
                p.Description,
                p.Age,
                p.Gender,
                p.HealthStatus,
                p.VaccinationStatus,
                p.AdoptionStatus
            }).ToList();

            dgv_Pets.DataSource = petsToDisplay;
            dgv_Pets.Columns["PetId"].Visible = false;

            btn_addPet.Visible = true;
        }

        private void btn_addPet_Click(object sender, EventArgs e)
        {
            var pet = new Pet
            {
                UserId = userFound.UserId,
                PetName = txt_petName.Text,
                PetTypeId = (int)cb_petType.SelectedValue,
                Description = txt_description.Text,
                Age = int.Parse(nud_age.Text),
                Gender = cb_gender.SelectedItem.ToString(),
                HealthStatus = cb_healthStatus.SelectedItem.ToString(),
                VaccinationStatus = cb_vaccinationStatus.SelectedItem.ToString(),
                AdoptionStatus = "Available",
                DateRegistered = DateTime.Now
            };

            context.Pets.Add(pet);
            context.SaveChanges();

            MessageBox.Show("Pet added successfully!");
            LoadPets();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            loginForm loginForm = new loginForm();
            loginForm.StartPosition = FormStartPosition.Manual;
            loginForm.Location = this.Location;
            loginForm.Show();
            this.Close();
        }

        private void btn_viewPetRequests_Click(object sender, EventArgs e)
        {
            ViewPetAdoptionRequests vPAR = new ViewPetAdoptionRequests(userFound);

            vPAR.StartPosition = FormStartPosition.Manual;
            vPAR.Location = this.Location;
            vPAR.Show();
            this.Close();
        }

        private void btn_updatePet_Click(object sender, EventArgs e)
        {
            if (dgv_Pets.SelectedRows.Count > 0)
            {
                var selectedPetId = (int)dgv_Pets.SelectedRows[0].Cells["PetId"].Value;
                var petToUpdate = context.Pets.FirstOrDefault(p => p.PetId == selectedPetId);

                if (petToUpdate != null)
                {
                    petToUpdate.PetName = txt_petName.Text;
                    petToUpdate.PetTypeId = (int)cb_petType.SelectedValue;
                    petToUpdate.Description = txt_description.Text;
                    petToUpdate.Age = (int)nud_age.Value;
                    petToUpdate.Gender = cb_gender.SelectedItem.ToString();
                    petToUpdate.HealthStatus = cb_healthStatus.SelectedItem.ToString();
                    petToUpdate.VaccinationStatus = cb_vaccinationStatus.SelectedItem.ToString();

                    context.SaveChanges();
                    MessageBox.Show("Pet updated successfully!");
                    LoadPets();
                }
            }
        }

        private void btn_deletePet_Click(object sender, EventArgs e)
        {
            if (dgv_Pets.SelectedRows.Count > 0)
            {
                var selectedPetId = (int)dgv_Pets.SelectedRows[0].Cells["PetId"].Value;
                var petToDelete = context.Pets.FirstOrDefault(p => p.PetId == selectedPetId);

                if (petToDelete != null)
                {
                    context.Pets.Remove(petToDelete);
                    context.SaveChanges();
                    MessageBox.Show("Pet deleted successfully!");
                    LoadPets();
                }
            }
        }
    }
}