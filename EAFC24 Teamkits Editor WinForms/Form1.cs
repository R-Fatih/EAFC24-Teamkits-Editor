using EAFC24_Teamkits_Editor_WinForms.Classes;
using EAFC24_Teamkits_Editor_WinForms.Helpers;
using EAFC24_Teamkits_Editor_WinForms.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using MessageBox = System.Windows.Forms.MessageBox;

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
        bool isfileopened = false;
        ResourceManager res_man;    // declare Resource manager to access to specific cultureinfo

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                //MessageBox.Show(openFileDialog1.FileName);
                file = File.ReadAllLines(openFileDialog1.FileName);
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
                isfileopened = true;
            }
            else
                MessageBox.Show(Localization.Lütfen_dosya_seçin, Localization.Hata, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            textBox16.Text = jersey.jerseynamelayouttype.ToString();
            textBox17.Text = jersey.jerseybacknamefontcase.ToString();
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
            if (isfileopened)
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
            else
                MessageBox.Show(Localization.Lütfen_teamkits_dosyası_açın, Localization.Hata, MessageBoxButtons.OK, MessageBoxIcon.Error);



        }
        private void textBoxesChanges(object sender, EventArgs e)
        {




        }

        private void button13_Click(object sender, EventArgs e)
        {

        }


        private void button14_Click_1(object sender, EventArgs e)
        {
            if (isfileopened)
            {

                List<Jersey> newlist = list.Where(x => x.teamkitid != 0).ToList();

                string tsvString = newlist.ToDelimitedText<Jersey>('\t', true, false);
                saveFileDialog1.Filter = "Text Dosyaları (*.txt)|*.txt";
                DialogResult result = saveFileDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog1.FileName, tsvString, Encoding.Unicode);
                    MessageBox.Show(Localization.Başarıyla_kaydedildi_);
                }
                else
                    MessageBox.Show(Localization.Lütfen_isim_girin, Localization.Hata, MessageBoxButtons.OK, MessageBoxIcon.Error);


            }else
                MessageBox.Show(Localization.Lütfen_teamkits_dosyası_açın, Localization.Hata, MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Jersey jersey = JerseyHelpers.FinJerseyBy(list, (Jersey)listBox2.SelectedItem);
            jersey.jerseycollargeometrytype = Convert.ToInt32(textBox2.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Jersey jersey = JerseyHelpers.FinJerseyBy(list, (Jersey)listBox2.SelectedItem);
            jersey.captainarmband = Convert.ToInt32(textBox3.Text);

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            Jersey jersey = JerseyHelpers.FinJerseyBy(list, (Jersey)listBox2.SelectedItem);
            Color teamcolor1 = ColorTranslator.FromHtml(textBox4.Text);
            jersey.teamcolorprimr = teamcolor1.R;
            jersey.teamcolorprimg = teamcolor1.G;
            jersey.teamcolorprimb = teamcolor1.B;
            button2.BackColor = teamcolor1;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            Jersey jersey = JerseyHelpers.FinJerseyBy(list, (Jersey)listBox2.SelectedItem);
            jersey.teamcolorprimpercent = Convert.ToInt32(textBox5.Text);
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            Jersey jersey = JerseyHelpers.FinJerseyBy(list, (Jersey)listBox2.SelectedItem);
            Color teamcolor2 = ColorTranslator.FromHtml(textBox7.Text);

            jersey.teamcolorsecr = teamcolor2.R;
            jersey.teamcolorsecg = teamcolor2.G;
            jersey.teamcolorsecb = teamcolor2.B;
            button3.BackColor = teamcolor2;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            Jersey jersey = JerseyHelpers.FinJerseyBy(list, (Jersey)listBox2.SelectedItem);
            jersey.teamcolorsecpercent = Convert.ToInt32(textBox6.Text);

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            Jersey jersey = JerseyHelpers.FinJerseyBy(list, (Jersey)listBox2.SelectedItem);
            Color teamcolor3 = ColorTranslator.FromHtml(textBox9.Text);

            jersey.teamcolortertr = teamcolor3.R;
            jersey.teamcolortertg = teamcolor3.G;
            jersey.teamcolortertb = teamcolor3.B;
            button4.BackColor = teamcolor3;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            Jersey jersey = JerseyHelpers.FinJerseyBy(list, (Jersey)listBox2.SelectedItem);
            jersey.teamcolortertpercent = Convert.ToInt32(textBox8.Text);

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            Jersey jersey = JerseyHelpers.FinJerseyBy(list, (Jersey)listBox2.SelectedItem);
            jersey.jerseyleftsleevebadge = Convert.ToInt32(textBox10.Text);

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            Jersey jersey = JerseyHelpers.FinJerseyBy(list, (Jersey)listBox2.SelectedItem);
            jersey.jerseyrightsleevebadge = Convert.ToInt32(textBox11.Text);

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            Jersey jersey = JerseyHelpers.FinJerseyBy(list, (Jersey)listBox2.SelectedItem);
            jersey.jerseyshapestyle = Convert.ToInt32(textBox12.Text);

        }

        private void textBox13_TextChanged_1(object sender, EventArgs e)
        {
            Jersey jersey = JerseyHelpers.FinJerseyBy(list, (Jersey)listBox2.SelectedItem);
            jersey.shortstyle = Convert.ToInt32(textBox13.Text);

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            Jersey jersey = JerseyHelpers.FinJerseyBy(list, (Jersey)listBox2.SelectedItem);
            jersey.jerseynamefonttype = Convert.ToInt32(textBox14.Text);

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            Jersey jersey = JerseyHelpers.FinJerseyBy(list, (Jersey)listBox2.SelectedItem);
            Color backname = ColorTranslator.FromHtml(textBox15.Text);
            jersey.jerseynamecolorr = backname.R;
            jersey.jerseynamecolorg = backname.G;
            jersey.jerseynamecolorb = backname.B;
            button5.BackColor = backname;
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            Jersey jersey = JerseyHelpers.FinJerseyBy(list, (Jersey)listBox2.SelectedItem);
            jersey.jerseynamelayouttype = Convert.ToInt32(textBox16.Text);

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            Jersey jersey = JerseyHelpers.FinJerseyBy(list, (Jersey)listBox2.SelectedItem);
            jersey.jerseybacknamefontcase = Convert.ToInt32(textBox17.Text);

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            Jersey jersey = JerseyHelpers.FinJerseyBy(list, (Jersey)listBox2.SelectedItem);
            jersey.jerseybacknameplacementcode = Convert.ToInt32(textBox18.Text);

        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {
            Jersey jersey = JerseyHelpers.FinJerseyBy(list, (Jersey)listBox2.SelectedItem);
            jersey.numberfonttype = Convert.ToInt32(textBox23.Text);

        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {
            Jersey jersey = JerseyHelpers.FinJerseyBy(list, (Jersey)listBox2.SelectedItem);
            Color jerseyback1 = ColorTranslator.FromHtml(textBox22.Text);
            jersey.jerseynumbercolorprimr = jerseyback1.R;
            jersey.jerseynumbercolorprimg = jerseyback1.G;
            jersey.jerseynumbercolorprimb = jerseyback1.B;
            button6.BackColor = jerseyback1;

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            Jersey jersey = JerseyHelpers.FinJerseyBy(list, (Jersey)listBox2.SelectedItem);
            Color jerseyback2 = ColorTranslator.FromHtml(textBox20.Text);
            jersey.jerseynumbercolorsecr = jerseyback2.R;
            jersey.jerseynumbercolorsecg = jerseyback2.G;
            jersey.jerseynumbercolorsecb = jerseyback2.B;
            button7.BackColor = jerseyback2;

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {
            Jersey jersey = JerseyHelpers.FinJerseyBy(list, (Jersey)listBox2.SelectedItem);
            Color jerseyback3 = ColorTranslator.FromHtml(textBox21.Text);
            jersey.jerseynumbercolorterr = jerseyback3.R;
            jersey.jerseynumbercolorterg = jerseyback3.G;
            jersey.jerseynumbercolorterb = jerseyback3.B;
            button8.BackColor = jerseyback3;

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {
            Jersey jersey = JerseyHelpers.FinJerseyBy(list, (Jersey)listBox2.SelectedItem);
            jersey.jerseyfrontnumberplacementcode = Convert.ToInt32(textBox19.Text);

        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {
            Jersey jersey = JerseyHelpers.FinJerseyBy(list, (Jersey)listBox2.SelectedItem);
            jersey.shortsnumberfonttype = Convert.ToInt32(textBox28.Text);

        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {
            Jersey jersey = JerseyHelpers.FinJerseyBy(list, (Jersey)listBox2.SelectedItem);
            Color numberback1 = ColorTranslator.FromHtml(textBox27.Text);
            jersey.shortsnumbercolorprimr = numberback1.R;
            jersey.shortsnumbercolorprimg = numberback1.G;
            jersey.shortsnumbercolorprimb = numberback1.B;
            button11.BackColor = numberback1;

        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {
            Jersey jersey = JerseyHelpers.FinJerseyBy(list, (Jersey)listBox2.SelectedItem);
            Color numberback2 = ColorTranslator.FromHtml(textBox25.Text);
            jersey.shortsnumbercolorsecr = numberback2.R;
            jersey.shortsnumbercolorsecg = numberback2.G;
            jersey.shortsnumbercolorsecb = numberback2.B;
            button10.BackColor = numberback2;

        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {
            Jersey jersey = JerseyHelpers.FinJerseyBy(list, (Jersey)listBox2.SelectedItem);
            Color numberback3 = ColorTranslator.FromHtml(textBox24.Text);
            jersey.shortsnumbercolorterr = numberback3.R;
            jersey.shortsnumbercolorterg = numberback3.G;
            jersey.shortsnumbercolorterb = numberback3.B;
            button9.BackColor = numberback3;

        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {
            Jersey jersey = JerseyHelpers.FinJerseyBy(list, (Jersey)listBox2.SelectedItem);
            jersey.shortsnumberplacementcode = Convert.ToInt32(textBox26.Text);

        }

        private void textBox40_TextChanged(object sender, EventArgs e)
        {
            Jersey jersey = JerseyHelpers.FinJerseyBy(list, (Jersey)listBox2.SelectedItem);
            jersey.armbandtype = Convert.ToInt32(textBox40.Text);

        }

        private void textBox39_TextChanged(object sender, EventArgs e)
        {
            Jersey jersey = JerseyHelpers.FinJerseyBy(list, (Jersey)listBox2.SelectedItem);
            jersey.chestbadge = Convert.ToInt32(textBox39.Text);

        }

        private void textBox38_TextChanged(object sender, EventArgs e)
        {
            Jersey jersey = JerseyHelpers.FinJerseyBy(list, (Jersey)listBox2.SelectedItem);
            jersey.dlc = Convert.ToInt32(textBox38.Text);

        }

        private void textBox37_TextChanged(object sender, EventArgs e)
        {
            Jersey jersey = JerseyHelpers.FinJerseyBy(list, (Jersey)listBox2.SelectedItem);
            jersey.hasadvertisingkit = Convert.ToInt32(textBox37.Text);

        }

        private void textBox36_TextChanged(object sender, EventArgs e)
        {
            Jersey jersey = JerseyHelpers.FinJerseyBy(list, (Jersey)listBox2.SelectedItem);
            jersey.isembargoed = Convert.ToInt32(textBox36.Text);

        }

        private void textBox35_TextChanged(object sender, EventArgs e)
        {
            Jersey jersey = JerseyHelpers.FinJerseyBy(list, (Jersey)listBox2.SelectedItem);
            jersey.isinheritbasedetailmap = Convert.ToInt32(textBox35.Text);

        }

        private void textBox34_TextChanged(object sender, EventArgs e)
        {
            Jersey jersey = JerseyHelpers.FinJerseyBy(list, (Jersey)listBox2.SelectedItem);
            jersey.islocked = Convert.ToInt32(textBox34.Text);

        }

        private void textBox33_TextChanged(object sender, EventArgs e)
        {
            Jersey jersey = JerseyHelpers.FinJerseyBy(list, (Jersey)listBox2.SelectedItem);
            jersey.jerseyfit = Convert.ToInt32(textBox33.Text);

        }

        private void textBox32_TextChanged(object sender, EventArgs e)
        {
            Jersey jersey = JerseyHelpers.FinJerseyBy(list, (Jersey)listBox2.SelectedItem);
            jersey.jerseyrenderingdetailmaptype = Convert.ToInt32(textBox32.Text);

        }

        private void textBox31_TextChanged(object sender, EventArgs e)
        {
            Jersey jersey = JerseyHelpers.FinJerseyBy(list, (Jersey)listBox2.SelectedItem);
            jersey.jerseyrestriction = Convert.ToInt32(textBox31.Text);

        }

        private void textBox30_TextChanged(object sender, EventArgs e)
        {
            Jersey jersey = JerseyHelpers.FinJerseyBy(list, (Jersey)listBox2.SelectedItem);
            jersey.powid = Convert.ToInt32(textBox30.Text);

        }

        private void textBox29_TextChanged(object sender, EventArgs e)
        {
            Jersey jersey = JerseyHelpers.FinJerseyBy(list, (Jersey)listBox2.SelectedItem);
            jersey.renderingmaterialtype = Convert.ToInt32(textBox29.Text);

        }

        private void textBox41_TextChanged(object sender, EventArgs e)
        {
            Jersey jersey = JerseyHelpers.FinJerseyBy(list, (Jersey)listBox2.SelectedItem);
            jersey.shortsrenderingdetailmaptype = Convert.ToInt32(textBox41.Text);

        }

        private void textBox42_TextChanged(object sender, EventArgs e)
        {
            Jersey jersey = JerseyHelpers.FinJerseyBy(list, (Jersey)listBox2.SelectedItem);
            jersey.teamkitid = Convert.ToInt32(textBox42.Text);

        }

        private void textBox43_TextChanged(object sender, EventArgs e)
        {
            Jersey jersey = JerseyHelpers.FinJerseyBy(list, (Jersey)listBox2.SelectedItem);
            jersey.teamkittypetechid = Convert.ToInt32(textBox43.Text);


        }

        private void textBox44_TextChanged(object sender, EventArgs e)
        {
            Jersey jersey = JerseyHelpers.FinJerseyBy(list, (Jersey)listBox2.SelectedItem);
            jersey.teamtechid = Convert.ToInt32(textBox44.Text);

        }

        private void textBox45_TextChanged(object sender, EventArgs e)
        {
            Jersey jersey = JerseyHelpers.FinJerseyBy(list, (Jersey)listBox2.SelectedItem);
            jersey.year = Convert.ToInt32(textBox45.Text);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listBox1.DataSource = list.Where(z => z.teamtechid.ToString().Contains(textBox1.Text)).GroupBy(x => x.teamtechid).Select(x => x.Key).ToArray();
            listBox1.DisplayMember = "teamtechid";
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Localization.Culture = CultureInfo.GetCultureInfo("tr");
            Properties.Settings.Default["lang"] = "tr";
            Properties.Settings.Default.Save();

        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Localization.Culture = CultureInfo.GetCultureInfo("en-US");

            Properties.Settings.Default["lang"] = "en-US";
            Properties.Settings.Default.Save();

        }

        private void russianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Localization.Culture = CultureInfo.GetCultureInfo("ru-RU");
            Properties.Settings.Default["lang"] = "ru-RU";
            Properties.Settings.Default.Save();

        }
        public void Apply()
        {
            label1.Text = Localization.jerseycollargeometrytype;
            label2.Text = Localization.captainarmband;
            label3.Text = Localization.Color_1_;
            label4.Text = Localization.Color_1_+"%";
            label6.Text = Localization.Color_2_;
            label5.Text = Localization.Color_2_ + "%";
            label8.Text = Localization.Color_3_;
            label7.Text = Localization.Color_3_ + "%";
            label9.Text = Localization.jerseyleftsleevebadge;
            label10.Text = Localization.jerseyrightsleevebadge;
            label11.Text = Localization.jerseyshapestyle;
            label12.Text = Localization.shortstyle;
            label24.Text = Localization.jerseynamefonttype;
            label22.Text = Localization.Color_1_;
            label21.Text = Localization.jerseynamelayouttype;
            label19.Text = Localization.jerseybacknamefontcase;
            label15.Text = Localization.jerseybacknameplacementcode;
            label18.Text = Localization.numberfonttype;
            label17.Text = Localization.Color_1_;
            label14.Text = Localization.Color_2_;
            label16.Text = Localization.Color_3_;
            label13.Text = Localization.jerseyfrontnumberplacementcode;
            label27.Text = Localization.shortsnumberfonttype;
            label26.Text = Localization.Color_1_;
            label23.Text = Localization.Color_2_;
            label20.Text = Localization.Color_3_;
            label25.Text = Localization.jerseybacknameplacementcode;
            label39.Text = Localization.armbandtype;
            label38.Text = Localization.chestbadge;
            label37.Text = Localization.dlc;
           
            label35.Text = Localization.isembargoed;
            label36.Text = Localization.hasadvertisingkit;
            label34.Text = Localization.isinheritbasedetailmap;
            label33.Text = Localization.islocked;
            label32.Text = Localization.jerseyfit;
            label31.Text = Localization.jerseyrenderingdetailmaptype;
            label30.Text = Localization.jerseyrestriction;
            label29.Text = Localization.powid;
            label28.Text = Localization.renderingmaterialtype;
            label40.Text = Localization.shortsrenderingdetailmaptype;
            label41.Text = Localization.teamkitid;
            label42.Text = Localization.teamkittypetechid;
            label43.Text = Localization.teamtechid;
            label44.Text = Localization.year;

            groupBox1.Text = Localization.Kit_details;
            groupBox2.Text = Localization.Kit_name;
            groupBox3.Text = Localization.Kit_number;
            groupBox4.Text = Localization.Shorts_number;
            groupBox5.Text = Localization.Other;

            button1.Text = Localization.Open;
            button14.Text = Localization.Save;
            button12.Text = Localization.Duplicate;
            this.Text = Localization.Title;

        }
        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button13_Click_1(object sender, EventArgs e)
        {
           

            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    Localization.Culture = CultureInfo.GetCultureInfo("tr");
                    Properties.Settings.Default["lang"] = "tr";
                    Properties.Settings.Default.Save();
                    break;
                    case 1:
                    Localization.Culture = CultureInfo.GetCultureInfo("en-US");
                    Properties.Settings.Default["lang"] = "en-US";
                    Properties.Settings.Default.Save();
                    break;
                    case 2:
                    Localization.Culture = CultureInfo.GetCultureInfo("ru-RU");
                    Properties.Settings.Default["lang"] = "ru-RU";
                    Properties.Settings.Default.Save();
                    break;
            }
            Apply();
          


        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            Localization.Culture = CultureInfo.GetCultureInfo(Properties.Settings.Default["lang"].ToString());
            Apply();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Process.Start("https://mellivoranetwork.com");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Process.Start("https://formamerkez.blogspot.com");

        }

        private void button16_Click(object sender, EventArgs e)
        {
            Process.Start("https://twitter.com/kitmaker_Fatih");

        }

        private void button17_Click(object sender, EventArgs e)
        {
            Process.Start("https://buymeacoffee.com/kitmakerfatih");

        }

        private void button19_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/R-Fatih/EAFC24-Teamkits-Editor");

        }
    }
}
