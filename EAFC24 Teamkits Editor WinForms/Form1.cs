using EAFC24_Teamkits_Editor_WinForms.Classes;
using EAFC24_Teamkits_Editor_WinForms.Helpers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
            file = File.ReadAllLines("teamkits.txt");
            foreach (string line in file)
            {
                if (count != 0)
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
            listBox1.DataSource = list.GroupBy(x => x.teamtechid).Select(x => x.Key).ToArray();
            listBox1.DisplayMember = "teamtechid";

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowKitOfTeams();

        }

        private void ShowKitOfTeams()
        {
            listBox2.DataSource = list.Where(x => x.teamtechid == Convert.ToInt32(listBox1.SelectedItem.ToString())).ToArray();
            listBox2.DisplayMember = "teamkittypetechid";
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Jersey jersey = (Jersey)listBox2.SelectedItem;
            // var jersey = list.Where(x => x.teamtechid == Convert.ToInt32(listBox1.SelectedItem.ToString()) && x.teamkittypetechid == Convert.ToInt32(listBox2.SelectedValue.ToString())).First();
            #region jerseydetails
            textBox2.Text = jersey.jerseycollargeometrytype.ToString();
            textBox3.Text = jersey.captainarmband.ToString();
            Color teamcolor1 = Color.FromArgb(jersey.teamcolorprimr, jersey.teamcolorprimg, jersey.teamcolorprimb);
            textBox4.Text = ColorTranslator.ToHtml(teamcolor1);
            button2.BackColor = teamcolor1;
            textBox5.Text = jersey.teamcolorprimpercent.ToString();
            Color teamcolor2 = Color.FromArgb(jersey.teamcolorsecr, jersey.teamcolorsecg, jersey.teamcolorsecb);
            textBox7.Text = ColorTranslator.ToHtml(teamcolor2);
            button3.BackColor = teamcolor2;
            textBox6.Text = jersey.teamcolorsecpercent.ToString();
            Color teamcolor3 = Color.FromArgb(jersey.teamcolortertr, jersey.teamcolortertg, jersey.teamcolortertb);
            textBox9.Text = ColorTranslator.ToHtml(teamcolor3);
            button4.BackColor = teamcolor3;
            textBox8.Text = jersey.teamcolortertpercent.ToString();
            textBox10.Text = jersey.jerseyleftsleevebadge.ToString();
            textBox11.Text = jersey.jerseyrightsleevebadge.ToString();
            textBox12.Text = jersey.jerseyshapestyle.ToString();
            textBox13.Text = jersey.shortstyle.ToString();

            #endregion

            #region backnamedetails
            textBox14.Text = jersey.jerseynamefonttype.ToString();
            Color backname = Color.FromArgb(jersey.jerseynamecolorr, jersey.jerseynamecolorg, jersey.jerseynamecolorb);
            textBox15.Text = ColorTranslator.ToHtml(backname);
            button5.BackColor = backname;
            textBox16.Text = jersey.jerseybacknamefontcase.ToString();
            textBox17.Text = jersey.jerseynamelayouttype.ToString();
            textBox18.Text = jersey.jerseybacknameplacementcode.ToString();
            #endregion

            #region backnumberdetails


            textBox23.Text = jersey.numberfonttype.ToString();
            Color jerseyback1 = Color.FromArgb(jersey.jerseynumbercolorprimr, jersey.jerseynumbercolorprimg, jersey.jerseynumbercolorprimb);
            Color jerseyback2 = Color.FromArgb(jersey.jerseynumbercolorsecr, jersey.jerseynumbercolorsecg, jersey.jerseynumbercolorsecb);
            Color jerseyback3 = Color.FromArgb(jersey.jerseynumbercolorterr, jersey.jerseynumbercolorterg, jersey.jerseynumbercolorterb);
            textBox22.Text = ColorTranslator.ToHtml(jerseyback1);
            textBox20.Text = ColorTranslator.ToHtml(jerseyback2);
            textBox21.Text = ColorTranslator.ToHtml(jerseyback3);
            button6.BackColor = jerseyback1;
            button7.BackColor = jerseyback2;
            button8.BackColor = jerseyback3;

            textBox19.Text = jersey.jerseyfrontnumberplacementcode.ToString();
            #endregion


            #region shortnumberdetails

            textBox28.Text = jersey.shortsnumberfonttype.ToString();
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

            textBox40.Text = jersey.armbandtype.ToString();
            textBox39.Text = jersey.chestbadge.ToString();
            textBox38.Text = jersey.dlc.ToString();
            textBox37.Text = jersey.hasadvertisingkit.ToString();
            textBox36.Text = jersey.isembargoed.ToString();
            textBox35.Text = jersey.isinheritbasedetailmap.ToString();
            textBox34.Text = jersey.islocked.ToString();
            textBox33.Text = jersey.jerseyfit.ToString();
            textBox32.Text = jersey.jerseyrenderingdetailmaptype.ToString();
            textBox31.Text = jersey.jerseyrestriction.ToString();
            textBox30.Text = jersey.powid.ToString();
            textBox29.Text = jersey.renderingmaterialtype.ToString();
            textBox41.Text = jersey.shortsrenderingdetailmaptype.ToString();
            textBox42.Text = jersey.teamkitid.ToString();
            textBox43.Text = jersey.teamkittypetechid.ToString();
            textBox44.Text = jersey.teamtechid.ToString();
            textBox45.Text = jersey.year.ToString();



            #endregion

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Jersey jersey = (Jersey)listBox2.SelectedItem;

            list.Add(new Jersey
            {
                armbandtype = jersey.armbandtype,
                captainarmband = jersey.captainarmband,
                chestbadge = jersey.chestbadge,
                dlc = jersey.dlc,
                hasadvertisingkit = jersey.hasadvertisingkit,
                isembargoed = jersey.isembargoed,
                isinheritbasedetailmap = jersey.isinheritbasedetailmap,
                islocked = jersey.islocked,
                jerseybacknamefontcase = jersey.jerseybacknamefontcase,
                jerseybacknameplacementcode = jersey.jerseybacknameplacementcode,
                jerseycollargeometrytype = jersey.jerseycollargeometrytype,
                jerseyfit = jersey.jerseyfit,
                jerseyfrontnumberplacementcode = jersey.jerseyfrontnumberplacementcode,
                jerseyleftsleevebadge = jersey.jerseyleftsleevebadge,
                jerseynamecolorb = jersey.jerseynamecolorb,
                jerseynamecolorg = jersey.jerseynamecolorg,
                jerseynamecolorr = jersey.jerseynamecolorr,
                jerseynamefonttype = jersey.jerseynamefonttype,
                jerseynamelayouttype = jersey.jerseynamelayouttype,
                jerseynumbercolorprimb = jersey.jerseynumbercolorprimb,
                jerseynumbercolorprimg = jersey.jerseynumbercolorprimg,
                jerseynumbercolorprimr = jersey.jerseynumbercolorprimr,
                jerseynumbercolorsecb = jersey.jerseynumbercolorsecb,
                jerseynumbercolorsecg = jersey.jerseynumbercolorsecg,
                jerseynumbercolorsecr = jersey.jerseynumbercolorsecr,
                jerseynumbercolorterb = jersey.jerseynumbercolorterb,
                jerseynumbercolorterg = jersey.jerseynumbercolorterg,
                jerseynumbercolorterr = jersey.jerseynumbercolorterr,
                jerseyrenderingdetailmaptype = jersey.jerseyrenderingdetailmaptype,
                jerseyrestriction = jersey.jerseyrestriction,
                jerseyrightsleevebadge = jersey.jerseyrightsleevebadge,
                jerseyshapestyle = jersey.jerseyshapestyle,
                numberfonttype = jersey.numberfonttype,
                powid = jersey.powid,
                renderingmaterialtype = jersey.renderingmaterialtype,
                shortsnumbercolorprimb = jersey.shortsnumbercolorprimb,
                shortsnumbercolorprimg = jersey.shortsnumbercolorprimg,
                shortsnumbercolorprimr = jersey.shortsnumbercolorprimr,
                shortsnumbercolorsecb = jersey.shortsnumbercolorsecb,
                shortsnumbercolorsecg = jersey.shortsnumbercolorsecg,
                shortsnumbercolorsecr = jersey.shortsnumbercolorsecr,
                shortsnumbercolorterb = jersey.shortsnumbercolorterb,
                shortsnumbercolorterg = jersey.shortsnumbercolorterg,
                shortsnumbercolorterr = jersey.shortsnumbercolorterr,
                shortsnumberfonttype = jersey.shortsnumberfonttype,
                shortsnumberplacementcode = jersey.shortsnumberplacementcode,
                shortsrenderingdetailmaptype = jersey.shortsrenderingdetailmaptype,
                shortstyle = jersey.shortstyle,
                teamcolorprimb = jersey.teamcolorprimb,
                teamcolorprimg = jersey.teamcolorprimg,
                teamcolorprimpercent = jersey.teamcolorprimpercent,
                teamcolorprimr = jersey.teamcolorprimr,
                teamcolorsecb = jersey.teamcolorsecb,
                teamcolorsecg = jersey.teamcolorsecg,
                teamcolorsecpercent = jersey.teamcolorsecpercent,
                teamcolorsecr = jersey.teamcolorsecr,
                teamcolortertb = jersey.teamcolortertb,
                teamcolortertg = jersey.teamcolortertg,
                teamcolortertpercent = jersey.teamcolortertpercent,
                teamcolortertr = jersey.teamcolortertr,
                teamkitid = jersey.teamkitid,
                teamkittypetechid = JerseyHelpers.FindLastJerseyByTeam(list, jersey.teamtechid) + 1,
                teamtechid = jersey.teamtechid,
                year = jersey.year
            });
            ShowKitOfTeams();




        }
        private void textBoxesChanges(object sender, EventArgs e)
        {
           

            

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

      


        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            Jersey jersey = JerseyHelpers.FinJerseyBy(list, (Jersey)listBox2.SelectedItem);
            jersey.jerseycollargeometrytype = Convert.ToInt32(textBox2.Text);
            jersey.captainarmband = Convert.ToInt32(textBox3.Text);
            Color teamcolor1 = ColorTranslator.FromHtml(textBox4.Text);
            jersey.teamcolorprimr = teamcolor1.R;
            jersey.teamcolorprimg = teamcolor1.G;
            jersey.teamcolorprimb = teamcolor1.B;


            jersey.teamcolorprimpercent = Convert.ToInt32(textBox5.Text);
            Color teamcolor2 = ColorTranslator.FromHtml(textBox7.Text);

            jersey.teamcolorsecr = teamcolor2.R;
            jersey.teamcolorsecg = teamcolor2.G;
            jersey.teamcolorsecb = teamcolor2.B;
            jersey.teamcolorsecpercent = Convert.ToInt32(textBox6.Text);

            Color teamcolor3 = ColorTranslator.FromHtml(textBox9.Text);


            jersey.teamcolortertr = teamcolor3.R;
            jersey.teamcolortertg = teamcolor3.G;
            jersey.teamcolortertb = teamcolor3.B;


            jersey.teamcolortertpercent = Convert.ToInt32(textBox8.Text);
            jersey.jerseyleftsleevebadge = Convert.ToInt32(textBox10.Text);
            jersey.jerseyrightsleevebadge = Convert.ToInt32(textBox11.Text);
            jersey.jerseyshapestyle = Convert.ToInt32(textBox12.Text);
            jersey.shortstyle = Convert.ToInt32(textBox13.Text);

            jersey.jerseynamefonttype = Convert.ToInt32(textBox14.Text);
            Color backname = ColorTranslator.FromHtml(textBox15.Text);
            jersey.jerseynamecolorr = backname.R;
            jersey.jerseynamecolorg = backname.G;
            jersey.jerseynamecolorb = backname.B;


            jersey.jerseybacknamefontcase = Convert.ToInt32(textBox16.Text);
            jersey.jerseynamelayouttype = Convert.ToInt32(textBox17.Text);
            jersey.jerseybacknameplacementcode = Convert.ToInt32(textBox18.Text);

            jersey.numberfonttype = Convert.ToInt32(textBox23.Text);
            Color jerseyback1 = ColorTranslator.FromHtml(textBox22.Text);
            jersey.jerseynumbercolorprimr = jerseyback1.R;
            jersey.jerseynumbercolorprimg = jerseyback1.G;
            jersey.jerseynumbercolorprimb = jerseyback1.B;
            Color jerseyback2 = ColorTranslator.FromHtml(textBox20.Text);
            jersey.jerseynumbercolorsecr = jerseyback2.R;
            jersey.jerseynumbercolorsecg = jerseyback2.G;
            jersey.jerseynumbercolorsecb = jerseyback2.B;
            Color jerseyback3 = ColorTranslator.FromHtml(textBox21.Text);
            jersey.jerseynumbercolorterr = jerseyback3.R;
            jersey.jerseynumbercolorterg = jerseyback3.G;
            jersey.jerseynumbercolorterb = jerseyback3.B;



            jersey.jerseyfrontnumberplacementcode = Convert.ToInt32(textBox19.Text);

            jersey.shortsnumberfonttype = Convert.ToInt32(textBox28.Text);


            Color numberback1 = ColorTranslator.FromHtml(textBox27.Text);
            jersey.shortsnumbercolorprimr = numberback1.R;
            jersey.shortsnumbercolorprimg = numberback1.G;
            jersey.shortsnumbercolorprimb = numberback1.B;
            Color numberback2 = ColorTranslator.FromHtml(textBox25.Text);
            jersey.shortsnumbercolorsecr = numberback2.R;
            jersey.shortsnumbercolorsecg = numberback2.G;
            jersey.shortsnumbercolorsecb = numberback2.B;
            Color numberback3 = ColorTranslator.FromHtml(textBox24.Text);
            jersey.shortsnumbercolorterr = numberback3.R;
            jersey.shortsnumbercolorterg = numberback3.G;
            jersey.shortsnumbercolorterb = numberback3.B;



            jersey.shortsnumberplacementcode = Convert.ToInt32(textBox26.Text);

            jersey.armbandtype = Convert.ToInt32(textBox40.Text);
            jersey.chestbadge = Convert.ToInt32(textBox39.Text);
            jersey.dlc = Convert.ToInt32(textBox38.Text);
            jersey.hasadvertisingkit = Convert.ToInt32(textBox37.Text);
            jersey.isembargoed = Convert.ToInt32(textBox36.Text);
            jersey.isinheritbasedetailmap = Convert.ToInt32(textBox35.Text);
            jersey.islocked = Convert.ToInt32(textBox34.Text);
            jersey.jerseyfit = Convert.ToInt32(textBox33.Text);
            jersey.jerseyrenderingdetailmaptype = Convert.ToInt32(textBox32.Text);
            jersey.jerseyrestriction = Convert.ToInt32(textBox31.Text);
            jersey.powid = Convert.ToInt32(textBox30.Text);
            jersey.renderingmaterialtype = Convert.ToInt32(textBox29.Text);
            jersey.shortsrenderingdetailmaptype = Convert.ToInt32(textBox41.Text);
            jersey.teamkitid = Convert.ToInt32(textBox42.Text);
            jersey.teamkittypetechid = Convert.ToInt32(textBox43.Text);
            jersey.teamtechid = Convert.ToInt32(textBox44.Text);
            jersey.year = Convert.ToInt32(textBox45.Text);
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            List<Jersey> newlist = list.Where(x=>x.teamkitid!=0).ToList();
            
            string tsvString = newlist.ToDelimitedText<Jersey>('\t', true, false);
            File.WriteAllText("newteamkits.txt", tsvString,Encoding.Unicode);
        }
    }
}
