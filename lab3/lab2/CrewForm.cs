using lab3.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class CrewForm : Form
    {
        public CrewForm()
        {
            InitializeComponent();
            this.ageTextBox.TextChanged += new System.EventHandler(this.ageTextBox_TextChanged);
            this.nameLabel.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            this.positionTextBox.TextChanged += new System.EventHandler(this.positionTextBox_TextChanged);
            this.experiencTextBox.TextChanged += new System.EventHandler(this.experiencTextBox_TextChanged);
        }

        private void Crew_Load(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                int value = 0;
                if(nameTextBox.Text.Length < 4)
                {
                    throw new Exception("Имя слишком короткое");
                }
                crewListBox.Items.Clear();
                CrewMemeber crewMemeber = new CrewMemeber();
                crewMemeber.Name = nameTextBox.Text;
                crewMemeber.Experience = int.Parse(experiencTextBox.Text);
                crewMemeber.Age = int.Parse(ageTextBox.Text);
                crewMemeber.Position = positionTextBox.Text;
                if (int.TryParse(experiencTextBox.Text, out value) && value < 0 || value >= crewMemeber.Age)
                {
                    throw new Exception("Неверно введено значние опыта работы");
                }
                value = 18;
                if (crewMemeber.Name.Length < 4)
                {
                    throw new Exception("Неверно введено имя");
                }
                if (!int.TryParse(ageTextBox.Text, out value) || crewMemeber.Age <= crewMemeber.Experience)
                {
                    if (value < 19)
                    {
                        throw new Exception("Неверно введён возраст");
                    }
                }
                Program.airport.CrewMemebers.Add(crewMemeber);
                foreach (Control c in this.Controls)
                {
                    if (c is TextBox)
                    {
                        c.Text = string.Empty;
                    }
                }
                foreach (var item in Program.airport.CrewMemebers)
                {
                    crewListBox.Items.Add(item.Name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            int value = 0;
            if (!int.TryParse(nameTextBox.Text,out value) && nameTextBox.Text.Length >= 4)
            {
               nameTextBox.BackColor = Color.White;
            }
            else
            {
                nameTextBox.BackColor = Color.Red;
            }
        }

        private void positionTextBox_TextChanged(object sender, EventArgs e)
        {
            int value = 0;
            if (!int.TryParse(positionTextBox.Text, out value))
            {
                positionTextBox.BackColor = Color.White;
            }
            else
            {
                positionTextBox.BackColor = Color.Red;
            }
        }

        private void ageTextBox_TextChanged(object sender, EventArgs e)
        {
            int value = 18;
            if (int.TryParse(ageTextBox.Text, out value) && value > 18)
            {
                ageTextBox.BackColor = Color.White;
            }
            else
            {
                ageTextBox.BackColor = Color.Red;
            }
        }

        private void experiencTextBox_TextChanged(object sender, EventArgs e)
        {
            int value = 0;
            if (int.TryParse(experiencTextBox.Text, out value) || value < 0)
            {
                experiencTextBox.BackColor = Color.White;
            }
            else
            {
                experiencTextBox.BackColor = Color.Red;
            }
        }
    }
}
