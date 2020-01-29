using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;


namespace basic
{
    public partial class merge_page : Form
    {

        LinkedList path_link = new LinkedList();

        public merge_page()
        {
            InitializeComponent();
        }

        private void choose_btn_Click(object sender, EventArgs e)
        {
            //Opens a fileDialog of you system
            OpenFileDialog FileDialogBox = new OpenFileDialog();

            //Sets the default path of FileDialogBox
            //Allows user to access only pdf files
            FileDialogBox.InitialDirectory = "C:\\Users\\umair\\Downloads";
            FileDialogBox.Filter = "Portable Document Format (*.pdf)|*.pdf;";

            string file_path;
            //After choosing file.... 
            if (FileDialogBox.ShowDialog() == DialogResult.OK)
            {
                //adding the file path to link list.... also showing file path inside a textbox

                file_path = FileDialogBox.FileName;
                path_link.insert(file_path);

                path_box.Text = file_path;
            }
            
        }

        //Opens the Home Page...
        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            landing_page h = new landing_page();
            h.Show();
        }

        private void path_box_TextChanged(object sender, EventArgs e)
        {
        }

        private void merge_btn_Click(object sender, EventArgs e)
        {
            //gets the size of linked list...
            int list_len = 0;
            list_len = path_link.len();

            //If user tries to merge without choosing two files atleast...
            while(list_len == 0 )
            {
                MessageBox.Show("Please Choose Files First !");
                choose_btn_Click(sender, e);
                return;
            }

            //path of our merged file...
            string outputPdfPath = @"C:\Users\umair\source\repos\basic\basic\mergedDoc\getMerged.pdf";

            //Creates a new Document...
            Document doc = new Document();

            //Creates an outputStream file for the doc...
            FileStream out_file = new FileStream(outputPdfPath, FileMode.Create);

            //Creates a copy of document...
            PdfSmartCopy copy_doc = new PdfSmartCopy(doc, out_file);

            //open document
            doc.Open();
            
            Node curr = path_link.head;

            //Merge all files in a link list
            for (int f = 0 ; f < list_len ; f++)
            {
                //Reads pdf...
                PdfReader read_pdf = new PdfReader(curr.path);

                //gets total number of pages in read_pdf;
                int TotalPages = read_pdf.NumberOfPages;

                //Adding each page in doc...
                for (int i = 1; i <= TotalPages; i++)
                {
                    //get each page of file and adding it to doc...
                    PdfImportedPage get_page = copy_doc.GetImportedPage(read_pdf, i);
                    copy_doc.AddPage(get_page);
                }
                curr = curr.next;
                read_pdf.Close();
            }

            //save the output file  
            doc.Close();

            DialogResult show_dialog = MessageBox.Show("Download your Merged File !", "Success!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (show_dialog == DialogResult.OK)
            {
                System.Diagnostics.Process.Start(outputPdfPath);
            }
            if (show_dialog == DialogResult.Cancel)
            {
                this.Hide();
                merge_page h = new merge_page();
                h.Show();
            }

        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
