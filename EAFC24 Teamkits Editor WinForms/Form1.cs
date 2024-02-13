using EAFC24_Teamkits_Editor_WinForms.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EAFC24_Teamkits_Editor_WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] file;
        int count = 0; 
        List<Jersey> list = new List<Jersey>();

        private void button1_Click(object sender, EventArgs e)
        {
           file  = File.ReadAllLines("teamkits.txt");
            foreach (string line in file)
            {
                if (count!=0)
                    list.Add(new Jersey
                    {
                        chestbadge = Convert.ToInt32(line.Split('\t')[0]),
                        shortsnumberplacementcode = Convert.ToInt32(line.Split('\t')[1]),
                        shortsnumbercolorprimg = Convert.ToInt32(line.Split('\t')[2]),
                        teamcolorsecb = Convert.ToInt32(line.Split('\t')[3]),
                        shortsrenderingdetailmaptype = Convert.ToInt32(line.Split('\t')[4]),
                        jerseyfrontnumberplacementcode = Convert.ToInt32(line.Split('\t')[5]),
                        jerseynumbercolorsecr = Convert.ToInt32(line.Split('\t')[6]),
                        jerseynumbercolorprimr = Convert.ToInt32(line.Split('\t')[7]),
                        jerseynumbercolorprimg = Convert.ToInt32(line.Split('\t')[8]),
                        shortsnumbercolorsecb = Convert.ToInt32(line.Split('\t')[9]),
                        teamcolorprimg = Convert.ToInt32(line.Split('\t')[10]),
                        shortsnumbercolorterb = Convert.ToInt32(line.Split('\t')[11]),
                        shortsnumbercolorprimr = Convert.ToInt32(line.Split('\t')[12]),
                        teamcolortertb = Convert.ToInt32(line.Split('\t')[13]),
                        jerseynumbercolorterg = Convert.ToInt32(line.Split('\t')[14]),
                        shortsnumbercolorprimb = Convert.ToInt32(line.Split('\t')[15]),
                        jerseynamelayouttype = Convert.ToInt32(line.Split('\t')[16]),
                        jerseynumbercolorterr = Convert.ToInt32(line.Split('\t')[17]),
                        jerseyrightsleevebadge = Convert.ToInt32(line.Split('\t')[18]),
                        jerseynumbercolorprimb = Convert.ToInt32(line.Split('\t')[19]),
                        jerseyshapestyle = Convert.ToInt32(line.Split('\t')[20]),
                        jerseybacknameplacementcode = Convert.ToInt32(line.Split('\t')[21]),
                        teamcolorprimr = Convert.ToInt32(line.Split('\t')[22]),
                        jerseynamecolorg = Convert.ToInt32(line.Split('\t')[23]),
                        jerseyleftsleevebadge = Convert.ToInt32(line.Split('\t')[24]),
                        teamcolorsecg = Convert.ToInt32(line.Split('\t')[25]),
                        shortsnumbercolorsecg = Convert.ToInt32(line.Split('\t')[26]),
                        teamcolortertr = Convert.ToInt32(line.Split('\t')[27]),
                        jerseynumbercolorsecg = Convert.ToInt32(line.Split('\t')[28]),
                        renderingmaterialtype = Convert.ToInt32(line.Split('\t')[29]),
                        shortsnumbercolorterr = Convert.ToInt32(line.Split('\t')[30]),
                        teamcolorsecr = Convert.ToInt32(line.Split('\t')[31]),
                        jerseycollargeometrytype = Convert.ToInt32(line.Split('\t')[32]),
                        shortsnumbercolorterg = Convert.ToInt32(line.Split('\t')[33]),
                        jerseynamecolorr = Convert.ToInt32(line.Split('\t')[34]),
                        teamcolorprimb = Convert.ToInt32(line.Split('\t')[35]),
                        jerseyrenderingdetailmaptype = Convert.ToInt32(line.Split('\t')[36]),
                        jerseynumbercolorsecb = Convert.ToInt32(line.Split('\t')[37]),
                        jerseynamecolorb = Convert.ToInt32(line.Split('\t')[38]),
                        jerseynumbercolorterb = Convert.ToInt32(line.Split('\t')[39]),
                        teamcolortertg = Convert.ToInt32(line.Split('\t')[40]),
                        shortsnumbercolorsecr = Convert.ToInt32(line.Split('\t')[41]),
                        jerseybacknamefontcase = Convert.ToInt32(line.Split('\t')[42]),
                        teamkittypetechid = Convert.ToInt32(line.Split('\t')[43]),
                        powid = Convert.ToInt32(line.Split('\t')[44]),
                        isinheritbasedetailmap = Convert.ToInt32(line.Split('\t')[45]),
                        islocked = Convert.ToInt32(line.Split('\t')[46]),
                        numberfonttype = Convert.ToInt32(line.Split('\t')[47]),
                        jerseynamefonttype = Convert.ToInt32(line.Split('\t')[48]),
                        teamkitid = Convert.ToInt32(line.Split('\t')[49]),
                        teamcolorprimpercent = Convert.ToInt32(line.Split('\t')[50]),
                        teamcolorsecpercent = Convert.ToInt32(line.Split('\t')[51]),
                        year = Convert.ToInt32(line.Split('\t')[52]),
                        captainarmband = Convert.ToInt32(line.Split('\t')[53]),
                        teamtechid = Convert.ToInt32(line.Split('\t')[54]),
                        isembargoed = Convert.ToInt32(line.Split('\t')[55]),
                        hasadvertisingkit = Convert.ToInt32(line.Split('\t')[56]),
                        dlc = Convert.ToInt32(line.Split('\t')[57]),
                        teamcolortertpercent = Convert.ToInt32(line.Split('\t')[58]),
                        armbandtype = Convert.ToInt32(line.Split('\t')[59]),
                        shortsnumberfonttype = Convert.ToInt32(line.Split('\t')[60]),
                        shortstyle = Convert.ToInt32(line.Split('\t')[61]),
                        jerseyfit = Convert.ToInt32(line.Split('\t')[62]),
                        jerseyrestriction = Convert.ToInt32(line.Split('\t')[63]),

                    });
                count++;
            }
            listBox1.DataSource = list.GroupBy(x=>x.teamtechid).Select(x=>x.Key).ToArray();
            listBox1.DisplayMember="teamtechid";

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.DataSource = list.Where(x=>x.teamtechid==Convert.ToInt32(listBox1.SelectedItem.ToString())).ToArray();
            listBox2.DisplayMember = "teamkittypetechid";

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Jersey jersey= (Jersey)listBox2.SelectedItem;
            // var jersey = list.Where(x => x.teamtechid == Convert.ToInt32(listBox1.SelectedItem.ToString()) && x.teamkittypetechid == Convert.ToInt32(listBox2.SelectedValue.ToString())).First();
            #region jerseydetails
            textBox2.Text=jersey.jerseycollargeometrytype.ToString();
            textBox3.Text = jersey.captainarmband.ToString();
            Color teamcolor1 = Color.FromArgb(jersey.teamcolorprimr, jersey.teamcolorprimg, jersey.teamcolorprimb);
            textBox4.Text = ColorTranslator.ToHtml(teamcolor1);
            button2.BackColor = teamcolor1;
            textBox5.Text=jersey.teamcolorprimpercent.ToString();
           Color teamcolor2= Color.FromArgb(jersey.teamcolorsecr, jersey.teamcolorsecg, jersey.teamcolorsecb);
            textBox7.Text= ColorTranslator.ToHtml(teamcolor2);
            button3.BackColor = teamcolor2;
            textBox6.Text = jersey.teamcolorsecpercent.ToString();
            Color teamcolor3 = Color.FromArgb(jersey.teamcolortertr, jersey.teamcolortertg, jersey.teamcolortertb);
            textBox9.Text = ColorTranslator.ToHtml(teamcolor3);
            button4.BackColor = teamcolor3;
            textBox8.Text = jersey.teamcolortertpercent.ToString();
            textBox10.Text=jersey.jerseyleftsleevebadge.ToString();
            textBox11.Text=jersey.jerseyrightsleevebadge.ToString();
            textBox12.Text=jersey.jerseyshapestyle.ToString();
            textBox13.Text=jersey.shortstyle.ToString();

            #endregion

            #region backnamedetails
            textBox14.Text=jersey.jerseynamefonttype.ToString();
            Color backname = Color.FromArgb(jersey.jerseynamecolorr, jersey.jerseynamecolorg, jersey.jerseynamecolorb);
            textBox15.Text = ColorTranslator.ToHtml(backname);
            button5.BackColor= backname;
            textBox16.Text=jersey.jerseybacknamefontcase.ToString();
            textBox17.Text=jersey.jerseynamelayouttype.ToString();
            textBox18.Text=jersey.jerseybacknameplacementcode.ToString();
            #endregion

            #region backnumberdetails


            textBox23.Text=jersey.numberfonttype.ToString();
            Color jerseyback1= Color.FromArgb(jersey.jerseynumbercolorprimr, jersey.jerseynumbercolorprimg, jersey.jerseynumbercolorprimb);
            Color jerseyback2= Color.FromArgb(jersey.jerseynumbercolorsecr, jersey.jerseynumbercolorsecg, jersey.jerseynumbercolorsecb);
            Color jerseyback3= Color.FromArgb(jersey.jerseynumbercolorterr, jersey.jerseynumbercolorterg, jersey.jerseynumbercolorterb);
            textBox22.Text = ColorTranslator.ToHtml(jerseyback1);
            textBox20.Text = ColorTranslator.ToHtml(jerseyback2);
            textBox21.Text = ColorTranslator.ToHtml(jerseyback3);
            button6.BackColor= jerseyback1;
            button7.BackColor= jerseyback2;
            button8.BackColor= jerseyback3;
           
            textBox19.Text=jersey.jerseyfrontnumberplacementcode.ToString();
            #endregion


            #region shortnumberdetails
            
            textBox28.Text=jersey.shortsnumberfonttype.ToString();
            Color numberback1 = Color.FromArgb(jersey.shortsnumbercolorprimr, jersey.shortsnumbercolorprimg, jersey.shortsnumbercolorprimb);
            Color numberback2 = Color.FromArgb(jersey.shortsnumbercolorsecr, jersey.shortsnumbercolorsecg, jersey.shortsnumbercolorsecb);
            Color numberback3 = Color.FromArgb(jersey.shortsnumbercolorterr, jersey.shortsnumbercolorterg, jersey.shortsnumbercolorterb);
            textBox27.Text = ColorTranslator.ToHtml(numberback1);
            textBox25.Text = ColorTranslator.ToHtml(numberback3);
            textBox24.Text = ColorTranslator.ToHtml(jerseyback3);
            button11.BackColor = numberback1;
            button10.BackColor = numberback2;
            button9.BackColor = numberback3;

            textBox26.Text = jersey.shortsnumberplacementcode.ToString();

            #endregion

            #region others

            textBox40.Text=jersey.armbandtype.ToString();
            textBox39.Text=jersey.chestbadge.ToString();
            textBox38.Text=jersey.dlc.ToString();
            textBox37.Text=jersey.hasadvertisingkit.ToString();
            textBox36.Text=jersey.isembargoed.ToString();
            textBox35.Text=jersey.isinheritbasedetailmap.ToString();
            textBox34.Text=jersey.islocked.ToString();
            textBox33.Text=jersey.jerseyfit.ToString();
            textBox32.Text=jersey.jerseyrenderingdetailmaptype.ToString();
            textBox31.Text=jersey.jerseyrestriction.ToString();
            textBox30.Text=jersey.powid.ToString();
            textBox29.Text=jersey.renderingmaterialtype.ToString();
            textBox41.Text=jersey.shortsrenderingdetailmaptype.ToString();
            textBox42.Text=jersey.teamkitid.ToString();
            textBox43.Text=jersey.teamkittypetechid.ToString();
            textBox44.Text=jersey.teamtechid.ToString();
            textBox45.Text=jersey.year.ToString();



            #endregion

        }
    }
}
