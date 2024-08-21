using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBB_Gen_11_Housemates_Info
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (HMCB.Text == "Binsoy Namoca")
            {
                HMNameLBL.Text = "Binsoy Namoca";
                HMMonikerLBL.Text = "The Maabilidancing Dong of South Cotabato";
                HMStatusLBL.Text = "Safe";
                HMPB.Image = new Bitmap("E:\\DRPSPHCALab\\PBBGen11HMInfo-CSharp\\PBB Gen 11 Housemates Info\\Resources\\HMPics\\PHCAPBBGen11HM_BinsoyNamoca.png");
            }
            else if (HMCB.Text == "Brx Ruiz")
            {
                HMNameLBL.Text = "Brx Ruiz";
                HMMonikerLBL.Text = "The Seamanluluto of Bacolod";
                HMStatusLBL.Text = "Evicted (3EN)";
                HMPB.Image = new Bitmap("E:\\DRPSPHCALab\\PBBGen11HMInfo-CSharp\\PBB Gen 11 Housemates Info\\Resources\\HMPics\\PHCAPBBGen11HM_BrxRuiz.png");
            }
            else if (HMCB.Text == "Dingdong and Patrick")
            {
                HMNameLBL.Text = "Dingdong Bahan and Patrick Ramirez";
                HMMonikerLBL.Text = "The Charismatic and Go-Getter Partners of Taguig and Maynila";
                HMStatusLBL.Text = "Nominated (4NN)";
                HMPB.Image = new Bitmap("E:\\DRPSPHCALab\\PBBGen11HMInfo-CSharp\\PBB Gen 11 Housemates Info\\Resources\\HMPics\\PHCAPBBGen11HM_Dongpat.png");
            }
            else if (HMCB.Text == "Dylan Yturralde")
            {
                HMNameLBL.Text = "Dylan Yturralde";
                HMMonikerLBL.Text = "The Astig Volleybae of Pampanga";
                HMStatusLBL.Text = "Nominated (4NN)";
                HMPB.Image = new Bitmap("E:\\DRPSPHCALab\\PBBGen11HMInfo-CSharp\\PBB Gen 11 Housemates Info\\Resources\\HMPics\\PHCAPBBGen11HM_DylanYturralde.png");
            }
            else if (HMCB.Text == "Fyang Smith")
            {
                HMNameLBL.Text = "Fyang Smith";
                HMMonikerLBL.Text = "The Anakabogerang Influencer of Mandaluyong";
                HMStatusLBL.Text = "Nominated (4NN)";
                HMPB.Image = new Bitmap("E:\\DRPSPHCALab\\PBBGen11HMInfo-CSharp\\PBB Gen 11 Housemates Info\\Resources\\HMPics\\PHCAPBBGen11HM_FyangSmith.png");
            }
            else if (HMCB.Text == "Gwen Montano")
            {
                HMNameLBL.Text = "Gwen Montano";
                HMMonikerLBL.Text = "The Brave Bromantiko of Cavite";
                HMStatusLBL.Text = "Newly Entered";
                HMPB.Image = new Bitmap("E:\\DRPSPHCALab\\PBBGen11HMInfo-CSharp\\PBB Gen 11 Housemates Info\\Resources\\HMPics\\PHCAPBBGen11HM_GwenMontano.png");
            }
            else if (HMCB.Text == "Jan Silva")
            {
                HMNameLBL.Text = "Jan Silva";
                HMMonikerLBL.Text = "The Prodigal Bai of Cebu";
                HMStatusLBL.Text = "Safe";
                HMPB.Image = new Bitmap("E:\\DRPSPHCALab\\PBBGen11HMInfo-CSharp\\PBB Gen 11 Housemates Info\\Resources\\HMPics\\PHCAPBBGen11HM_JanSilva.png");
            }
            else if (HMCB.Text == "Jarren Garcia")
            {
                HMNameLBL.Text = "Jarren Garcia";
                HMMonikerLBL.Text = "The Charming Crooner of London, United Kingdom";
                HMStatusLBL.Text = "Safe";
                HMPB.Image = new Bitmap("E:\\DRPSPHCALab\\PBBGen11HMInfo-CSharp\\PBB Gen 11 Housemates Info\\Resources\\HMPics\\PHCAPBBGen11HM_JarrenGarcia.png");
            }
            else if (HMCB.Text == "Jas Dudley-Scales")
            {
                HMNameLBL.Text = "Jas Dudley-Scales";
                HMMonikerLBL.Text = "The Optimistic Ate of Dumaguete";
                HMStatusLBL.Text = "Safe";
                HMPB.Image = new Bitmap("E:\\DRPSPHCALab\\PBBGen11HMInfo-CSharp\\PBB Gen 11 Housemates Info\\Resources\\HMPics\\PHCAPBBGen11HM_JasDudleyScales.png");
            }
            else if (HMCB.Text == "JM Ibarra")
            {
                HMNameLBL.Text = "JM Ibarra";
                HMMonikerLBL.Text = "The Pogisyanong Pilo-To Be of Quezon";
                HMStatusLBL.Text = "Safe";
                HMPB.Image = new Bitmap("E:\\DRPSPHCALab\\PBBGen11HMInfo-CSharp\\PBB Gen 11 Housemates Info\\Resources\\HMPics\\PHCAPBBGen11HM_JMIbarra.png");
            }
            else if (HMCB.Text == "Joli Alferez")
            {
                HMNameLBL.Text = "Joli Alferez";
                HMMonikerLBL.Text = "The Smiling Darling of Camarines Sur";
                HMStatusLBL.Text = "Safe";
                HMPB.Image = new Bitmap("E:\\DRPSPHCALab\\PBBGen11HMInfo-CSharp\\PBB Gen 11 Housemates Info\\Resources\\HMPics\\PHCAPBBGen11HM_JoliAlferez.png");
            }
            else if (HMCB.Text == "JP Cabrera")
            {
                HMNameLBL.Text = "JP Cabrera";
                HMMonikerLBL.Text = "The Perserving Bunso of Quezon City";
                HMStatusLBL.Text = "Safe";
                HMPB.Image = new Bitmap("E:\\DRPSPHCALab\\PBBGen11HMInfo-CSharp\\PBB Gen 11 Housemates Info\\Resources\\HMPics\\PHCAPBBGen11HM_JPCabrera.png");
            }
            else if (HMCB.Text == "Kai Montinola")
            {
                HMNameLBL.Text = "Kai Montinola";
                HMMonikerLBL.Text = "The Singing Gwapa of Cebu";
                HMStatusLBL.Text = "Nominated (4NN)";
                HMPB.Image = new Bitmap("E:\\DRPSPHCALab\\PBBGen11HMInfo-CSharp\\PBB Gen 11 Housemates Info\\Resources\\HMPics\\PHCAPBBGen11HM_KaiMontinola.png");
            }
            else if (HMCB.Text == "Kanata Tapia")
            {
                HMNameLBL.Text = "Kanata Tapia";
                HMMonikerLBL.Text = "The Lola-Ving Apo of Occidental Mindoro";
                HMStatusLBL.Text = "Evicted (2EN)";
                HMPB.Image = new Bitmap("E:\\DRPSPHCALab\\PBBGen11HMInfo-CSharp\\PBB Gen 11 Housemates Info\\Resources\\HMPics\\PHCAPBBGen11HM_KanataTapia.png");
            }
            else if (HMCB.Text == "Kolette Madelo")
            {
                HMNameLBL.Text = "Kolette Madelo";
                HMMonikerLBL.Text = "The Ma-Cute-Lit na Raketera of General Santos";
                HMStatusLBL.Text = "Nominated (4NN)";
                HMPB.Image = new Bitmap("E:\\DRPSPHCALab\\PBBGen11HMInfo-CSharp\\PBB Gen 11 Housemates Info\\Resources\\HMPics\\PHCAPBBGen11HM_KoletteMadelo.png");
            }
            else if (HMCB.Text == "Marc Nanninga")
            {
                HMNameLBL.Text = "Marc Nanninga";
                HMMonikerLBL.Text = "The Sporty Go Lucky Kuya of Camarines Norte";
                HMStatusLBL.Text = "Evicted (2EN)";
                HMPB.Image = new Bitmap("E:\\DRPSPHCALab\\PBBGen11HMInfo-CSharp\\PBB Gen 11 Housemates Info\\Resources\\HMPics\\PHCAPBBGen11HM_MarcNanninga.png");
            }
            else if (HMCB.Text == "Noimie Steikunas")
            {
                HMNameLBL.Text = "Noimie Steikunas";
                HMMonikerLBL.Text = "The Mombitious Chikadora of Lithuania";
                HMStatusLBL.Text = "Evicted (3EN)";
                HMPB.Image = new Bitmap("E:\\DRPSPHCALab\\PBBGen11HMInfo-CSharp\\PBB Gen 11 Housemates Info\\Resources\\HMPics\\PHCAPBBGen11HM_NoimieSteikunas.png");
            }
            else if (HMCB.Text == "Rain Celmar")
            {
                HMNameLBL.Text = "Rain Celmar";
                HMMonikerLBL.Text = "The Cheerfu-Langga of Cebu";
                HMStatusLBL.Text = "Nominated (4NN)";
                HMPB.Image = new Bitmap("E:\\DRPSPHCALab\\PBBGen11HMInfo-CSharp\\PBB Gen 11 Housemates Info\\Resources\\HMPics\\PHCAPBBGen11HM_RainCelmar.png");
            }
            else if (HMCB.Text == "Therese Villamor")
            {
                HMNameLBL.Text = "Therese Villamor";
                HMMonikerLBL.Text = "The Determined Daughter of Camarines Sur";
                HMStatusLBL.Text = "Evicted (1EN)";
                HMPB.Image = new Bitmap("E:\\DRPSPHCALab\\PBBGen11HMInfo-CSharp\\PBB Gen 11 Housemates Info\\Resources\\HMPics\\PHCAPBBGen11HM_ThereseVillamor.png");
            }
        }
    }
}
