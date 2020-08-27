using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JSONParser1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e) {

        }

        private void button2_Click(object sender, EventArgs e) {
            txtDebugOutput.Text = string.Empty;
        }

        private void cmdDeserialize_Click(object sender, EventArgs e) {
            //txtDebugOutput.Text = txtInput.Text;
            //debugoutput(txtInput.Text);
            deserializeJSON(txtInput.Text);
        }


        private void debugoutput(string strDebugText) {
            try {
                System.Diagnostics.Debug.WriteLine(strDebugText);
                txtDebugOutput.Text = txtDebugOutput.Text + strDebugText + Environment.NewLine;
                txtDebugOutput.SelectionStart = txtDebugOutput.TextLength;
                txtDebugOutput.ScrollToCaret();
            }
            catch (Exception ex) {

                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }


        private void deserializeJSON(string strJSON) {
            try {
                //var jPerson = JsonConvert.DeserializeObject<dynamic>(strJSON);

                var jPerson = JsonConvert.DeserializeObject<jsonPersonSimple>(strJSON);



                debugoutput("Here's our JOSN object: " + jPerson.ToString());
                debugoutput("Here's the First Name: " + jPerson.firstname);
                debugoutput("Here's the street address: " + jPerson.address.streetAddress);
            }
            catch (Exception ex) {
                debugoutput("We had a problem: " + ex.Message.ToString());
            }
        }
    }
} 

    //"firstname": "Roger",
    //"lastname": "Moore",
    //"age": 89,
    //"isAlive": false