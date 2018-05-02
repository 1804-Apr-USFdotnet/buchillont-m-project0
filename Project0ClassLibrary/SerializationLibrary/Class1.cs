using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using Project0ClassLibrary;
using Newtonsoft.Json.Converters;

namespace SerializationLibrary
{
    public class Class1
    {

        public static void Serialize()
        {
            /*string direc = AppDomain.CurrentDomain.BaseDirectory;
            string theFileName = "the_Restaurants";
            List<Restaurant> Restaurant_List = new List<Restaurant>();*/

            //initializing Restaurant class object
            Restaurant r = new Restaurant();

            //initializing values
            r.name = "Romano's Macaroni Grill";
            r.address = "14904 N Dale Mabry Hwy, Tampa, FL 33618";
            r.email = "";
            r.phone = "1-888-472-2195";
            r.avgRating = 3.7;

            try
            {
                //Serializing data
                string testJson = JsonConvert.SerializeObject(r);

                //save stream in file after serializing
                File.WriteAllText(@"C:\Users\Administrator\source\repos\Project0ClassLibrary", testJson);

                Console.WriteLine("Object has been converted into the stream.");
            }

            catch (Exception ex)
            {
                Console.WriteLine("Here's what's wrong: ");
                Console.WriteLine(ex.Message);
            }

            //now I'd like a unit test for testing out the serialization aspect of this project...

        }

        public static void Deserialize()
        {
            //string theJson = File.ReadAllText()
        }

            //string json = File.ReadAllText(/*file from which we get restaurants */);

            //deserialize the object
            //Restaurant r = JsonConvert.DeserializeObject<Restaurant>(json);


            //Console.WriteLine("Restaurant Name: {0} \nAddress: {1} \nEmail: {2} \nPhone: {3} \n Average rating: {4} \n", name, address, email, phone, avgRatingString);*/

            /*var converter = new ExpandoObjectConverter();

            dynamic r = JsonConvert.DeserializeObject<System.Dynamic.ExpandoObject>(json, converter);*/



            /*Stream theStream = File.OpenWrite(Environment.CurrentDirectory + "myText.txt");

            JsonSerializer serializer = new JsonSerializer();
            serializer.serialize()*/

            /* JsonSerializer serializer = new JsonSerializer();
            serializer.Converters.Add(new JavaScriptDateTimeConverter());
            serializer.NullValueHandling = NullValueHandling.Ignore;

            using (StreamWriter sw = new StreamWriter(@"c:\json.txt"))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                 serializer.Serialize(writer, product);
                // {"ExpiryDate":new Date(1230375600000),"Price":0}
            }
             */
        
    }
}
