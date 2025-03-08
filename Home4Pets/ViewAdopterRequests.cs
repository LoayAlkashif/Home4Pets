using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Azure.Core;
using Home4Pets.Context;
using Home4Pets.Models;
using Microsoft.EntityFrameworkCore;

namespace Home4Pets
{
    public partial class ViewAdopterRequests : Form
    {
        AppDbContext context;
        User currentUser;
        public ViewAdopterRequests(User user)
        {
            InitializeComponent();
            context = new AppDbContext();

            currentUser = user;

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ControlBox = false;

            this.BackgroundImage = Image.FromFile("G:\\ITI .Net\\6 Linq & entity\\project\\Home4Pets\\Home4Pets\\Photos\\2.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;

            FormLoad();
        }

        private void btn_returnBack_Click(object sender, EventArgs e)
        {
            AdopterForm adopterForm = new AdopterForm(currentUser);

            adopterForm.Show();

            this.Close();
        }

        private void FormLoad()
        {
            var userRequests = context.AdoptionRequests.Where(ar => ar.UserId == currentUser.UserId)
                                                        .Include(ar => ar.Pet)
                                                        .Select(ar => new
                                                        {
                                                            ar.AdoptionRequestId,
                                                            PetName = ar.Pet.PetName,
                                                            ar.RequestDate,
                                                            ar.Status,
                                                            ar.ApprovalDate,
                                                            ar.Remarks
                                                        }).ToList();

            dgv_adopterRequests.DataSource = userRequests;
            dgv_adopterRequests.Columns["AdoptionRequestId"].Visible = false;

        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (dgv_adopterRequests.SelectedRows.Count > 0)
            {
                var selectedRow = dgv_adopterRequests.SelectedRows[0];
                int adoptionRequestId = (int)selectedRow.Cells["AdoptionRequestId"].Value;

                var userRequest = context.AdoptionRequests.Include(ar => ar.Pet)  
                                                           .FirstOrDefault(ar => ar.AdoptionRequestId == adoptionRequestId);

                if (userRequest != null)
                {
                    userRequest.Pet.AdoptionStatus = "Available";

                    context.AdoptionRequests.Remove(userRequest);

                    context.SaveChanges();

                    FormLoad();

                    MessageBox.Show("Request removed and pet status updated to Available.");
                }
            }
            else
            {
                MessageBox.Show("Please select a request to remove.");
            }
        }
    }
}
