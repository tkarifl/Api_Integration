using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace WebApplication1.Models
{
    [XmlRoot(ElementName = "spec")]
    public class Spec
    {

        [XmlAttribute(AttributeName = "required")]
        public bool Required { get; set; }

        [XmlAttribute(AttributeName = "value")]
        public string Value { get; set; }

        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
    }

    [XmlRoot(ElementName = "specs")]
    public class Specs
    {

        [XmlElement(ElementName = "spec")]
        public List<Spec> Spec { get; set; }
    }

    [XmlRoot(ElementName = "photo")]
    public class Photo
    {

        [XmlElement(ElementName = "url")]
        public string Url { get; set; }

        [XmlAttribute(AttributeName = "photoId")]
        public int PhotoId { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "photos")]
    public class Photos
    {

        [XmlElement(ElementName = "photo")]
        public Photo Photo { get; set; }
    }

    [XmlRoot(ElementName = "cargoCompanies")]
    public class CargoCompanies
    {

        [XmlElement(ElementName = "cargoCompany")]
        public string CargoCompany { get; set; }
    }

    [XmlRoot(ElementName = "cargoCompanyDetail")]
    public class CargoCompanyDetail
    {

        [XmlElement(ElementName = "name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "value")]
        public string Value { get; set; }

        [XmlElement(ElementName = "cityPrice")]
        public double CityPrice { get; set; }

        [XmlElement(ElementName = "countryPrice")]
        public double CountryPrice { get; set; }
    }

    [XmlRoot(ElementName = "cargoCompanyDetails")]
    public class CargoCompanyDetails
    {

        [XmlElement(ElementName = "cargoCompanyDetail")]
        public CargoCompanyDetail CargoCompanyDetail { get; set; }
    }

    [XmlRoot(ElementName = "shippingTime")]
    public class ShippingTime
    {

        [XmlElement(ElementName = "days")]
        public string Days { get; set; }
    }

    [XmlRoot(ElementName = "productPackageSize")]
    public class ProductPackageSize
    {

        [XmlElement(ElementName = "width")]
        public int Width { get; set; }

        [XmlElement(ElementName = "height")]
        public int Height { get; set; }

        [XmlElement(ElementName = "depth")]
        public int Depth { get; set; }

        [XmlElement(ElementName = "weight")]
        public double Weight { get; set; }

        [XmlElement(ElementName = "desi")]
        public double Desi { get; set; }
    }

    [XmlRoot(ElementName = "cargoDetail")]
    public class CargoDetail
    {

        [XmlElement(ElementName = "city")]
        public int City { get; set; }

        [XmlElement(ElementName = "cargoCompanies")]
        public CargoCompanies CargoCompanies { get; set; }

        [XmlElement(ElementName = "shippingPayment")]
        public string ShippingPayment { get; set; }

        [XmlElement(ElementName = "shippingWhere")]
        public string ShippingWhere { get; set; }

        [XmlElement(ElementName = "cargoCompanyDetails")]
        public CargoCompanyDetails CargoCompanyDetails { get; set; }

        [XmlElement(ElementName = "shippingTime")]
        public ShippingTime ShippingTime { get; set; }

        [XmlElement(ElementName = "productPackageSize")]
        public ProductPackageSize ProductPackageSize { get; set; }
    }

    [XmlRoot(ElementName = "product")]
    public class Product
    {

        [XmlElement(ElementName = "categoryCode")]
        public string CategoryCode { get; set; }

        [XmlElement(ElementName = "storeCategoryId")]
        public int StoreCategoryId { get; set; }

        [XmlElement(ElementName = "title")]
        public string Title { get; set; }

        [XmlElement(ElementName = "specs")]
        public Specs Specs { get; set; }

        [XmlElement(ElementName = "photos")]
        public Photos Photos { get; set; }

        [XmlElement(ElementName = "pageTemplate")]
        public int PageTemplate { get; set; }

        [XmlElement(ElementName = "description")]
        public string Description { get; set; }

        [XmlElement(ElementName = "format")]
        public string Format { get; set; }

        [XmlElement(ElementName = "buyNowPrice")]
        public double BuyNowPrice { get; set; }

        [XmlElement(ElementName = "listingDays")]
        public int ListingDays { get; set; }

        [XmlElement(ElementName = "productCount")]
        public int ProductCount { get; set; }

        [XmlElement(ElementName = "cargoDetail")]
        public CargoDetail CargoDetail { get; set; }

        [XmlElement(ElementName = "marketPrice")]
        public double MarketPrice { get; set; }

        [XmlElement(ElementName = "productId")]
        public int ProductId { get; set; }

        [XmlElement(ElementName = "product")]
        public Product Product1 { get; set; }

        [XmlElement(ElementName = "summary")]
        public Summary Summary { get; set; }
    }

    [XmlRoot(ElementName = "summary")]
    public class Summary
    {

        [XmlElement(ElementName = "soldCount")]
        public int SoldCount { get; set; }

        [XmlElement(ElementName = "endDate")]
        public string EndDate { get; set; }

        [XmlElement(ElementName = "listingStatus")]
        public string ListingStatus { get; set; }

        [XmlElement(ElementName = "hasRelistOption")]
        public bool HasRelistOption { get; set; }
    }

    [XmlRoot(ElementName = "products")]
    public class Products
    {

        [XmlElement(ElementName = "product")]
        public Product[] Product { get; set; }
    }

    [XmlRoot(ElementName = "return")]
    public class Return
    {

        [XmlElement(ElementName = "ackCode")]
        public string AckCode { get; set; }

        [XmlElement(ElementName = "responseTime")]
        public string ResponseTime { get; set; }

        [XmlElement(ElementName = "timeElapsed")]
        public string TimeElapsed { get; set; }

        [XmlElement(ElementName = "productCount")]
        public int ProductCount { get; set; }

        [XmlElement(ElementName = "products")]
        public Products Products { get; set; }
    }

    [XmlRoot(ElementName = "getProductsResponse", Namespace = "https://product.individual.ws.listingapi.gg.com")]
    public class GetProductsResponse
    {

        [XmlElement(ElementName = "return")]
        public Return Return { get; set; }

        [XmlAttribute(AttributeName = "prod", Namespace = "https://product.individual.ws.listingapi.gg.com")]
        public string Prod { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "Body")]
    public class Body
    {

        [XmlElement(ElementName = "getProductsResponse")]
        public GetProductsResponse GetProductsResponse { get; set; }
    }

    [XmlRoot(ElementName = "Envelope")]
    public class GetProductsGeneralResponse
    {

        [XmlElement(ElementName = "Body")]
        public Body Body { get; set; }

    }
}
