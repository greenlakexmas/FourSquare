using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace GreenlakeChristmas.FourSquare.Objects
{
    public class ApiResponse
    {
        public static ApiResponse GetVenue(string oauth_token, string venueId)
        {
            string apiurl =
                string.Format("https://api.foursquare.com/v2/venues/{0}?oauth_token={1}", venueId,
                              oauth_token);
            HttpWebResponse oResponse = null;
            object json = null;
            try
            {
                HttpWebRequest oRequest = (HttpWebRequest)WebRequest.Create(apiurl);
                oResponse = (HttpWebResponse)oRequest.GetResponse();
                StreamReader reader = new StreamReader(oResponse.GetResponseStream());
                string sr = reader.ReadToEnd();

                json = JSON.JsonDecode(sr);
            }
            catch (WebException we)
            {
                throw new Exception(we.Message, we);
            }
            finally
            {
                if (oResponse != null)
                    oResponse.Close();
            }

            Dictionary<string, object> dictionary = (Dictionary<string, object>) json;

            ApiResponse fourSquareResponse = new ApiResponse(dictionary);
            return fourSquareResponse;
        }

        public ApiResponse(Dictionary<string, object> dictionary)
        {
            object response = dictionary["response"];
            if (!(response is Dictionary<string, object>)) return;
            Dictionary<string, object> dict = response as Dictionary<string, object>;
            object venue = dict["venue"];
            if (venue is Dictionary<string, object>)
            {
                this.Venue = new Venue(venue as Dictionary<string, object>);
            }
        }

        public Venue Venue { get; protected set; }
 
    }
}