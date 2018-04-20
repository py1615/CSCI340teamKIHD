﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIC_KIHD_GUI
{
    public partial class QuoteForm : Form
    {
        public QuoteForm(string FN, string LN, string birth, string address, string city, string state, string zip, string father, string mother, string cigarette, string smoke, 
                        string blood, string grams, string heartDisease, string cancer, string hospital, string dangerous, string payoff, string bFirstname, string bLastName)
        {
            InitializeComponent();
            firstName.Text = FN;
            LastName.Text = LN;
            dateOfBirth.Text = birth;
            StreetAdress.Text = address;
            CityLabel.Text = city;
            StateLabel.Text = state;
            zipCode.Text = zip;
            FatherAgeAtDeath.Text = father;
            MotherAgeAtDeath.Text = mother;
            CigarettesPerDay.Text = cigarette;
            SmokingHistory.Text = smoke;
            BloodPressure.Text = blood;
            AverageGrams.Text = grams;
            HeartDisease.Text = heartDisease;
            CancerLabel.Text = cancer;
            Hospitalized.Text = hospital;
            DangerousActivities.Text = dangerous;
            PayoffAmount.Text = payoff;
            BeneficiaryFirstName.Text = bFirstname;
            BeneficiaryLastName.Text = bLastName;


        }

        private void QuoteForm_Load(object sender, EventArgs e)
        {
            
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label30_Click(object sender, EventArgs e)
        {

        }
    }
}
