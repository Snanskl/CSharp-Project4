using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_4
{
    public partial class MainForm : Form
    {
        #region Fields area
        private PartyManager partyManager;

        #endregion

        #region Program Main function
        public MainForm()
        {
            InitializeComponent();

            InitializeGUI();
        }
        private void InitializeGUI()
        { 
            // Initialize form default setting
        }
        private void MainForm_Load(object sender, EventArgs e) // donr
        {CenterToScreen();}
        #endregion

        #region Button functions

        #endregion

        #region Read data area

        #endregion

        #region Party manager manual methods 
        public void DisplayResult()
        {   
            //when all functions are valid, call this method to display result
        
        }
        private bool ReadInput()
        {
            //Read all the input before calling DisplayResult function
            bool validInput = false;

            return validInput;
        }
        private void UpdateGUI()
        { 
        
        
        }


        #endregion

        







    }
}
