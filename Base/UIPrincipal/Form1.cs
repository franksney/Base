﻿using System;
using System.Windows.Forms;
using BLL;

namespace UIPrincipal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            usuarioBLL.Inserir();


        }
    }
}
