using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class TopSkill
    {
        public string name { get; set; }
        public int count { get; set; }
    }

    public class TopLanguage
    {
        public string name { get; set; }
        public int count { get; set; }
    }

    public class TopEnvironment
    {
        public string name { get; set; }
        public int count { get; set; }
    }

    public class TopFramework
    {
        public string name { get; set; }
        public int count { get; set; }
    }

    public class TopTool
    {
        public string name { get; set; }
        public int count { get; set; }
    }

    public class TopInterest
    {
        public string name { get; set; }
        public int count { get; set; }
    }

    public class TopTrait
    {
        public string name { get; set; }
        public int count { get; set; }
    }

    public class TopArea
    {
        public string name { get; set; }
        public int count { get; set; }
    }

    public class Account
    {
        public string name { get; set; }
        public string link { get; set; }
        public string site_link { get; set; }
        public string image_link { get; set; }
        public string image_link_16 { get; set; }
        public string image_link_22 { get; set; }
        public string image_link_32 { get; set; }
        public string image_link_48 { get; set; }
    }

    public class Badge
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string link { get; set; }
        public string image_link { get; set; }
        public bool earned { get; set; }
        public string earned_date { get; set; }
        public int current_value { get; set; }
        public int needed_value { get; set; }
        public int level { get; set; }
        public string trait { get; set; }
        public string trait_description { get; set; }
        public Account account { get; set; }
    }

    public class Account2
    {
        public string name { get; set; }
        public string link { get; set; }
        public string site_link { get; set; }
        public string image_link { get; set; }
        public string image_link_16 { get; set; }
        public string image_link_22 { get; set; }
        public string image_link_32 { get; set; }
        public string image_link_48 { get; set; }
    }

    public class Coderbits
    {
        public string name { get; set; }
        public string title { get; set; }
        public string location { get; set; }
        public string website_link { get; set; }
        public string bio { get; set; }
        public string created { get; set; }
        public string updated { get; set; }
        public int views { get; set; }
        public int rank { get; set; }
        public string username { get; set; }
        public string link { get; set; }
        public string gravatar_hash { get; set; }
        public int one_bit_badges { get; set; }
        public int eight_bit_badges { get; set; }
        public int sixteen_bit_badges { get; set; }
        public int thirty_two_bit_badges { get; set; }
        public int sixty_four_bit_badges { get; set; }
        public int follower_count { get; set; }
        public int following_count { get; set; }
        public List<TopSkill> top_skills { get; set; }
        public List<TopLanguage> top_languages { get; set; }
        public List<TopEnvironment> top_environments { get; set; }
        public List<TopFramework> top_frameworks { get; set; }
        public List<TopTool> top_tools { get; set; }
        public List<TopInterest> top_interests { get; set; }
        public List<TopTrait> top_traits { get; set; }
        public List<TopArea> top_areas { get; set; }
        public List<Badge> badges { get; set; }
        public List<Account2> accounts { get; set; }
    }
}
