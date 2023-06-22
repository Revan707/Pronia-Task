using Pronia.Core.Entities;

namespace Pronia.UI.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<Slider>? Sliders { get; set; }
        public IEnumerable<Shipping>? Shippings { get; set; }
        public IEnumerable<Product>? Products { get; set; }
        public IEnumerable<Banner>? Banners { get; set; }
        public IEnumerable<NewProduct>? NewProducts { get; set; }
    }
}
