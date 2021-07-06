using System;
using System.Net;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;
using System.Xml;
using System.Xml.Serialization;
using WebApplication1.Models;

namespace WebApplication1
{
    public class Soap_gg_services
    {
        public HttpWebRequest CreateSOAPWebRequest(string role_username, string role_password)
        {
            //Making Web Request    
            HttpWebRequest Req = (HttpWebRequest)WebRequest.Create(@"https://dev.gittigidiyor.com:8443/listingapi/ws/IndividualProductService?wsdl");
            string encoded = System.Convert.ToBase64String(Encoding.GetEncoding("ISO-8859-1")
                                           .GetBytes(role_username + ":" + role_password));
            Req.Headers.Add("Authorization", "Basic " + encoded);
            //SOAPAction    
            Req.Headers.Add(@"SOAP:Action");
            //Content_type    
            Req.ContentType = "text/xml;charset=\"utf-8\"";
            Req.Accept = "text/xml";
            //HTTP method    
            Req.Method = "POST";
            //return HttpWebRequest    
            return Req;

        }
        public string CreateMD5Hash(string input)
        {
            // Step 1, calculate MD5 hash from input
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hashBytes = md5.ComputeHash(inputBytes);

            // Step 2, convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                sb.Append(hashBytes[i].ToString("X2"));
            }
            return sb.ToString();
        }
        public Return Get_Products(string role_username, string role_password,string api_key,string secret_key,string status)
        {
            //Calling CreateSOAPWebRequest method  
            HttpWebRequest request = CreateSOAPWebRequest(role_username, role_password);

            XmlDocument SOAPReqBody = new XmlDocument();
            var time = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            var signature = CreateMD5Hash(api_key + secret_key + time);

            string req = $@"
            <s:Envelope xmlns:s=""http://schemas.xmlsoap.org/soap/envelope/"">
                <s:Body xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
              <prod:getProducts xmlns:prod=""https://product.individual.ws.listingapi.gg.com"">
               <apiKey>{api_key}</apiKey>
               <sign>{signature}</sign>
               <time>{time}</time>
               <startOffSet>0</startOffSet>
               <rowCount>100</rowCount>
               <status>{status}</status>
               <withData>true</withData>
               <lang>tr</lang>
            </prod:getProducts></s:Body>
            </s:Envelope>";

            SOAPReqBody.LoadXml(req);
            string hata = string.Empty;
            var getProductsResult = new Return();
            try
            {
                string messageResult = String.Empty;
                using (Stream stream = request.GetRequestStream())
                {
                    SOAPReqBody.Save(stream);
                }

                using (WebResponse Serviceres = request.GetResponse())
                {
                    using (XmlTextReader rd = new XmlTextReader(Serviceres.GetResponseStream()))
                    {
                        rd.ReadToDescendant("return");
                        XmlSerializer serializer1 = new XmlSerializer(typeof(Return));
                        getProductsResult = (Return)serializer1.Deserialize(rd.ReadSubtree());
                    }
                }

            }

            catch (WebException ex)
            {
                using (var stream = ex.Response.GetResponseStream())
                using (var reader = new StreamReader(stream))
                {

                    hata = reader.ReadToEnd();
                    //Console.ReadKey();
                }
            }
            catch (Exception ex)
            {
                // Something more serious happened
                // like for example you don't have network access
                // we cannot talk about a server exception here as
                // the server probably was never reached
            }
            return getProductsResult;
        }
        public Insert_Return Insert_Product(string role_username, string role_password, string api_key, string secret_key,string title,string description, string image_url, string price)
        {
            HttpWebRequest request = CreateSOAPWebRequest(role_username, role_password);

            XmlDocument SOAPReqBody = new XmlDocument();
            var time = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            var signature = CreateMD5Hash(api_key + secret_key + time);

            string req = $@"
            <s:Envelope xmlns:s=""http://schemas.xmlsoap.org/soap/envelope/"">
                <s:Body xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
             <prod:insertAndActivateProduct  xmlns:prod=""https://product.individual.ws.listingapi.gg.com"">
   <apiKey>{api_key}</apiKey>
   <sign>{signature}</sign>
   <time>{time}</time>
   <itemId></itemId>
   <product>
      <categoryCode>gdk</categoryCode>
      <storeCategoryId></storeCategoryId>
      <title>{title} __ggtest</title>
      <subtitle></subtitle>
      <specs>
        <spec name=""Durum"" value=""Sıfır"" type=""Combo"" required=""true""/>
        <spec name=""Marka"" value=""Bulamadım"" type=""Combo"" required=""true""/>
        <spec name=""Model"" value=""Bulamadım"" type=""Combo"" required=""true""/>
        <spec name=""Renk"" value=""Siyah"" type=""Combo"" required=""true""/>
        <spec name=""Garanti"" value=""Yok"" type=""Combo"" required=""true""/>
        <spec name=""Garanti Süresi"" value=""Yok"" type=""Combo"" required=""true""/>
        <spec name=""Garanti Geçerlilik Yeri"" value=""Türkiye"" type=""Combo"" required=""true""/>
      </specs>
      <photos>
         <photo photoId=""0"">
            <url>{image_url}</url>
            <base64></base64>
         </photo>
      </photos>
      <pageTemplate>1</pageTemplate>
      <description>{description}</description>
      <startDate></startDate>
      <catalogId></catalogId>
      <catalogDetail></catalogDetail>
      <catalogFilter></catalogFilter>
      <format>S</format>
      <startPrice></startPrice>
      <buyNowPrice>{price}</buyNowPrice>
      <netEarning></netEarning>
      <listingDays>30</listingDays>
      <productCount>1</productCount>
      <cargoDetail>
         <city>34</city>
         <shippingPayment>B</shippingPayment>
         <shippingWhere>country</shippingWhere>
         <cargoCompanyDetails>
            <cargoCompanyDetail>
               <name>aras</name>
               <cityPrice>3.00</cityPrice>
               <countryPrice>5.00</countryPrice>
            </cargoCompanyDetail>
             </cargoCompanyDetails>
             <shippingTime>
            <days>today</days>
            <beforeTime>10:00</beforeTime>
             </shippingTime>
      </cargoDetail>
      <affiliateOption>false</affiliateOption>
      <boldOption>false</boldOption>
      <catalogOption>false</catalogOption>
      <vitrineOption>false</vitrineOption>
   </product>
   <forceToSpecEntry>false</forceToSpecEntry>
   <nextDateOption>false</nextDateOption>
   <lang>tr</lang>
</prod:insertAndActivateProduct>
</s:Body>
            </s:Envelope>";

            SOAPReqBody.LoadXml(req);
            string hata = string.Empty;
            var getProductsResult = new Insert_Return();
            try
            {
                string messageResult = String.Empty;
                using (Stream stream = request.GetRequestStream())
                {
                    SOAPReqBody.Save(stream);
                }

                using (WebResponse Serviceres = request.GetResponse())
                {
                    using (XmlTextReader rd = new XmlTextReader(Serviceres.GetResponseStream()))
                    {
                        rd.ReadToDescendant("return");
                        XmlSerializer serializer1 = new XmlSerializer(typeof(Insert_Return));
                        getProductsResult = (Insert_Return)serializer1.Deserialize(rd.ReadSubtree());
                    }
                }

            }

            catch (WebException ex)
            {
                using (var stream = ex.Response.GetResponseStream())
                using (var reader = new StreamReader(stream))
                {

                    hata = reader.ReadToEnd();
                    //Console.ReadKey();
                }
            }
            catch (Exception ex)
            {
                // Something more serious happened
                // like for example you don't have network access
                // we cannot talk about a server exception here as
                // the server probably was never reached
            }
            return getProductsResult;
        }
    }
}
