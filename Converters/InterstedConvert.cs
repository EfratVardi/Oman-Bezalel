using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using Dto;

namespace Converters
{
    public class InterestedConvert
    {
        //ממירה מחלקה שלנו לשל מיקרוסופט
        public static Intersted ToDalInterested(InterstedDto i)
        {
            Intersted inter = new Intersted();
            inter.CellInterested = i.CellIntersted;
            inter.IdCollege = i.IdCollege;
            inter.IdDiploma = i.IdDiploma;
            inter.IdFaculty = i.IdFaculty;
            inter.IdIntersted = i.IdIntersted;
            inter.IdPersonStatus = i.IdPersonStatus;
            inter.IdResource = i.IdResource;
            inter.LastNameIntersted = i.LastNameIntersted;
            inter.TzInterested = i.TzIntersted;
            inter.FirstNameIntersted = i.FirstNameIntersted;
            inter.GmailIntersted = i.GmailIntersted;

            return inter;

        }
        //ממירה מחלקה של מיקרוסופט לשלנו
        public static InterstedDto ToDtoIntersted(Intersted i)
        {
            InterstedDto inter = new InterstedDto();
            inter.CellIntersted = i.CellInterested;
            inter.IdCollege = i.IdCollege;
            inter.IdDiploma = i.IdDiploma;
            inter.IdFaculty = i.IdFaculty;
            inter.IdIntersted = i.IdIntersted;
            inter.IdPersonStatus = i.IdPersonStatus;
            inter.IdResource = i.IdResource;
            inter.LastNameIntersted = i.LastNameIntersted;
            inter.TzIntersted = i.TzInterested;
            inter.FirstNameIntersted = i.FirstNameIntersted;
            inter.GmailIntersted = i.GmailIntersted;
            inter.IdUser = i.IdUser;
            return inter;
        }

        //ממירה אוסף שלנו לאוסף של מיקרוסופט
        public static List<Intersted> ToDalInterestedList(List<InterstedDto> le)
        {
            List<Intersted> lin = new List<Intersted>();
            foreach (var item in le)
            {
                lin.Add(ToDalInterested(item));
            }
            return lin;
        }

        //ממירה אוסף של מיקרוסופט לאוסף שלנו
        public static List<InterstedDto> ToDtoInterestedList(List<Intersted> le)
        {
            List<InterstedDto> lin = new List<InterstedDto>();
            foreach (var item in le)
            {
                lin.Add(ToDtoIntersted(item));
            }
            return lin;
        }
    }
}




