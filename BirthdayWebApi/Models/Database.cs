using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace BirthdayWebApi.Models
{
    public class Database
    {
        private static Dictionary<string, InvitationModel> _list;
        static Database()
        {
            _list = new Dictionary<string, InvitationModel>();
            _list.Add("Abdulvahap", new InvitationModel
            {
                Name = "Abdulvahap",
                Eposta = "abdulvahapselcuk@gmail.com",
                JoiningCase = true
            });
            _list.Add("Adem", new InvitationModel
            {
                Name = "Adem",
                Eposta = "ademk@gmail.com",
                JoiningCase = false
            });
            _list.Add("Berrin", new InvitationModel
            {
                Name = "Berrin",
                Eposta = "berrin@gmail.com",
                JoiningCase = true
            });
        }
        public static void Add(InvitationModel model)
        {
            string key = model.Name.ToLower();
            if (_list.ContainsKey(key))
            {
                _list[key] = model;
            }
            else
            {
                _list.Add(key, model);
            }
        }
        public static IEnumerable<InvitationModel> List
        {
            get { return _list.Values; }
        }
    }
}