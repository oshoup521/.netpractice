using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FlowersMart.Models;
using BLL;
using BOL;

namespace FlowersMart.Controllers;

public class ProductController : Controller
{
    private readonly ILogger<ProductController> _logger;

    public ProductController(ILogger<ProductController> logger)
    {
        _logger = logger;
    }

    public IActionResult Details()
    {
        CatalogManager cm = new CatalogManager();
        List<Product> allProducts = cm.allProducts();
        this.ViewData["products"] = allProducts;
        return View();
    }




}
