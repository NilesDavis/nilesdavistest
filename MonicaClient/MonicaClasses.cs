using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonicaClient
{
  public class Contact
  {
    public int id { get; set; }
    public string @object { get; set; }
    public string hash_id { get; set; }
    public string first_name { get; set; }
    public string last_name { get; set; }
    public string nickname { get; set; }
    public string complete_name { get; set; }
    public string initials { get; set; }
    public string gender { get; set; }
    public string gender_type { get; set; }
    public bool is_starred { get; set; }
    public bool is_partial { get; set; }
    public bool is_active { get; set; }
    public bool is_dead { get; set; }
    public bool is_me { get; set; }
    public Information information { get; set; }
    public string url { get; set; }
    //public Account account { get; set; }
  }


  public class Information
  {

  }

  public class Relationship
  {
    public int id { get; set; }
    public string name { get; set; }
  }

  public class Birthdate
  {
    public bool? is_age_based { get; set; }
    public bool? is_year_unknown { get; set; }
    public DateTime? date { get; set; }
  }

  public class DeceasedDate
  {
    public object is_age_based { get; set; }
    public object is_year_unknown { get; set; }
    public object date { get; set; }
  }

  public class Avatar
  {
    public string url { get; set; }
    public string source { get; set; }
    public string default_avatar_color { get; set; }
  }

  public class Information2
  {
    public Birthdate birthdate { get; set; }
    public DeceasedDate deceased_date { get; set; }
    public Avatar avatar { get; set; }
    public Relationships relationships { get; set; }
    public Dates dates { get; set; }
    public Career career { get; set; }
    public string food_preferences { get; set; }
    public HowYouMet how_you_met { get; set; }
  }

  public class Account
  {
    public int id { get; set; }
  }

  //public class Contact
  //{
  //  public Relationship relationship { get; set; }
  //  public Contact contact { get; set; }
  //}

  public class Love
  {
    public int total { get; set; }
    public List<Contact> contacts { get; set; }
  }

  public class Family
  {
    public int total { get; set; }
    public List<Contact> contacts { get; set; }
  }

  public class Friend
  {
    public int total { get; set; }
    public List<Contact> contacts { get; set; }
  }

  public class Work
  {
    public int total { get; set; }
    public List<Contact> contacts { get; set; }
  }

  public class Relationships
  {
    public Love love { get; set; }
    public Family family { get; set; }
    public Friend friend { get; set; }
    public Work work { get; set; }
  }

  public class Dates
  {
    public Birthdate birthdate { get; set; }
    public DeceasedDate deceased_date { get; set; }
  }

  public class Career
  {
    public string job { get; set; }
    public string company { get; set; }
  }

  public class FirstMetDate
  {
    public object is_age_based { get; set; }
    public object is_year_unknown { get; set; }
    public object date { get; set; }
  }

  public class HowYouMet
  {
    public string general_information { get; set; }
    public FirstMetDate first_met_date { get; set; }
    public object first_met_through_contact { get; set; }
  }

  public class Country
  {
    public string id { get; set; }
    public string @object { get; set; }
    public string name { get; set; }
    public string iso { get; set; }
  }

  public class Address
  {
    public int id { get; set; }
    public string @object { get; set; }
    public string name { get; set; }
    public string street { get; set; }
    public string city { get; set; }
    public string province { get; set; }
    public string postal_code { get; set; }
    public object latitude { get; set; }
    public object longitude { get; set; }
    public Country country { get; set; }
    public string url { get; set; }
    public Account account { get; set; }
    public Contact contact { get; set; }
    public DateTime created_at { get; set; }
    public DateTime updated_at { get; set; }
  }

  public class Tag
  {
    public int id { get; set; }
    public string @object { get; set; }
    public string name { get; set; }
    public string name_slug { get; set; }
    public Account account { get; set; }
    public DateTime created_at { get; set; }
    public DateTime updated_at { get; set; }
  }

  public class Statistics
  {
    public int number_of_calls { get; set; }
    public int number_of_notes { get; set; }
    public int number_of_activities { get; set; }
    public int number_of_reminders { get; set; }
    public int number_of_tasks { get; set; }
    public int number_of_gifts { get; set; }
    public int number_of_debts { get; set; }
  }

  public class Datum
  {
    public int id { get; set; }
    public string @object { get; set; }
    public string hash_id { get; set; }
    public string first_name { get; set; }
    public string last_name { get; set; }
    public string nickname { get; set; }
    public string complete_name { get; set; }
    public string initials { get; set; }
    public object description { get; set; }
    public string gender { get; set; }
    public string gender_type { get; set; }
    public bool is_starred { get; set; }
    public bool is_partial { get; set; }
    public bool is_active { get; set; }
    public bool is_dead { get; set; }
    public bool is_me { get; set; }
    public DateTime? last_called { get; set; }
    public DateTime? last_activity_together { get; set; }
    public int? stay_in_touch_frequency { get; set; }
    public DateTime? stay_in_touch_trigger_date { get; set; }
    public string information { get; set; }
    public List<Address> addresses { get; set; }
    public List<Tag> tags { get; set; }
    public Statistics statistics { get; set; }
    public string url { get; set; }
    public Account account { get; set; }
    public DateTime created_at { get; set; }
    public DateTime updated_at { get; set; }
  }

  public class Links
  {
    public string first { get; set; }
    public string last { get; set; }
    public object prev { get; set; }
    public string next { get; set; }
  }

  public class Meta
  {
    public int current_page { get; set; }
    public int from { get; set; }
    public int last_page { get; set; }
    public string path { get; set; }
    public int per_page { get; set; }
    public int to { get; set; }
    public int total { get; set; }
  }

  public class Root
  {
    public List<Datum> data { get; set; }
    public Links links { get; set; }
    public Meta meta { get; set; }
  }

}
