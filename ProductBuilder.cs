using System;
using Domain_Layer.Shared.Value_Objects;

internal class ProductBuilder
{
    public ProductBuilder(){ }


    public string Tittle;

    public Money Price;

    public int Count;

    public int TottalImage;

    ////  public ICollection<ProductImage> images;
    public Product Build() { 
        return new Product
    }
}
