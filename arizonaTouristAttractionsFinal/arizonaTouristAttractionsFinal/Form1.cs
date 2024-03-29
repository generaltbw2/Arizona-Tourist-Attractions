﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace arizonaTouristAttractionsFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //Splashscreen
            Thread t = new Thread(new ThreadStart(StartForm));
            t.Start();
            Thread.Sleep(300);
            InitializeComponent();
            t.Abort();
        }
        public void StartForm()
        {
            //Splashscreen
            Application.Run(new Form2());
        }

        private void arizonaLocationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.arizonaLocationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.arizona1DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'arizona1DataSet.arizonaLocation' table. You can move, or remove it, as needed.
            this.arizonaLocationTableAdapter.Fill(this.arizona1DataSet.arizonaLocation);
            pictureChange();

        }
        //Sets the picture of the picturebox
        private void pictureChange()
        {
            if (System.IO.File.Exists(locationPictureTextBox.Text))
            {
                pictureBox1.Load(locationPictureTextBox.Text);
                //this.BackgroundImage = Image.FromFile(locationPictureTextBox.Text);
            }
            else
                pictureBox1.Image = null;
        }
        private void arizonaLocationBindingNavigator_Click(object sender, EventArgs e)
        {
            pictureChange();
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk_1(object sender, CancelEventArgs e)
        {
            locationPictureTextBox.Text = @"..\..\Images\" + openFileDialog1.SafeFileName;
            pictureChange();
        }

        //Searches for different keywords through the database
        private void searchButton_Click(object sender, EventArgs e)
        {
            // connection string  
            try
            {
                resultsComboBox.Items.Clear();
                // Query database
                var contactDetails =
                   from c in arizona1DataSet.arizonaLocation
                   where c.locationName.ToLower().Contains(searchTextBox.Text.ToLower()) || c.County.ToLower().Contains(searchTextBox.Text.ToLower()) || c.County.ToLower().Contains(searchTextBox.Text.ToLower()) || c.City.ToLower().Contains(searchTextBox.Text.ToLower()) || c.Location.ToLower().Contains(searchTextBox.Text.ToLower()) || c.Rating.ToLower().Contains(searchTextBox.Text.ToLower())
                   select c;
                foreach (arizona1DataSet.arizonaLocationRow item in contactDetails)
                {
                    resultsComboBox.Items.Add(item.locationName);
                }
                arizonaLocationBindingSource.DataSource = contactDetails.AsDataView();
                try
                {
                    pictureChange();
                }
                catch {}
                //arizonaLocationDataGridView.DataSource = contactDetails.AsDataView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Shows the results for the search through the database
        private void showButton_Click(object sender, EventArgs e)
        {
            try
            {
                var contactDetails =
                    from c in arizona1DataSet.arizonaLocation
                    where c.locationName == resultsComboBox.SelectedItem.ToString()
                    select c;
                arizonaLocationBindingSource.DataSource = contactDetails.AsDataView();
                resultsComboBox.Items.Clear();
                pictureChange();
            }
            catch {return;}
            //foreach (arizona1DataSet.arizonaLocationRow item in contactDetails)
            //{
            //    arizonaLocationBindingSource.Position = arizonaLocationBindingSource.Find("locationName", item.locationName);
            //}
            //resultsComboBox.Items.Clear();
        }

        //Will reset the view of the database and show all records
        private void resetViewButton_Click(object sender, EventArgs e)
        {
            try
            {
                var contactDetails =
                        from c in arizona1DataSet.arizonaLocation
                        where c.locationName.Equals(c.locationName)
                        select c;
                arizonaLocationBindingSource.DataSource = contactDetails.AsDataView();
                resultsComboBox.Items.Clear();
                pictureChange();
            }
            catch { return; }
        }
    }
}
