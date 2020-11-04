﻿using BLL;
using BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace GroupProject
{
    /// <summary>
    /// Interaction logic for AddBookWindow.xaml
    /// </summary>
    public partial class AddBookWindow : Window
    {
        private IBLLClass _bll = null;
        public AddBookWindow(IBLLClass bll)
        {
            InitializeComponent();
            _bll = bll;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Enter name of the book!");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPublisher.Text))
            {
                MessageBox.Show("Enter publisher of the book!");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Enter price of the book!");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPages.Text))
            {
                MessageBox.Show("Enter pages of the book!");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtAmount.Text))
            {
                MessageBox.Show("Enter amount of the books");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtAuthor.Text))
            {
                MessageBox.Show("Enter pages of the book!");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtGenre.Text))
            {
                MessageBox.Show("Enter amount of the book!");
                return;
            }
            if (!decimal.TryParse(txtPrice.Text, out _))
            {
                MessageBox.Show("Price is a number!");
                return;
            }
            if (!decimal.TryParse(txtPages.Text, out _))
            {
                MessageBox.Show("Pages is a number!");
                return;
            }
            if (!decimal.TryParse(txtAmount.Text, out _))
            {
                MessageBox.Show("Amount is a number!");
                return;
            }

            _bll.AddBooks(new BookDTO()
            {
                Price = decimal.Parse(txtPrice.Text),
                Pages = int.Parse(txtPages.Text),
                Amount = int.Parse(txtAmount.Text),
                Year = Date.SelectedDate.Value,
                Author = txtAuthor.Text,
                Genre = txtGenre.Text,
                Name = txtName.Text,
                Publisher = txtPublisher.Text
            });

            MessageBox.Show("Succesfully added!");
        }
    }
}