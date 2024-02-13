using EAFC24_Teamkits_Editor_WinForms.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAFC24_Teamkits_Editor_WinForms.Helpers
{
    public static class JerseyHelpers
    {
        public static int FindLastJerseyByTeam(List<Jersey> list, int id)
        {
            return list.Where(x => x.teamtechid == id).OrderByDescending(y => y.teamkittypetechid).First().teamkittypetechid;
        }
        public static Jersey FinJerseyBy(List<Jersey> list, Jersey jersey)
        {
            return list.Where(x => x.teamtechid == jersey.teamtechid&&x.teamkittypetechid==jersey.teamkittypetechid).First();
        }
    }
}
