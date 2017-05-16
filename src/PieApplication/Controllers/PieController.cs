using Microsoft.AspNetCore.Mvc;
using PieApplication.Models;
using PieApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PieApplication.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly ICatagoryRepository _catagoryRepository;

        public PieController(IPieRepository pieRepository, ICatagoryRepository catagoryRepository)
        {
            _pieRepository = pieRepository;
            _catagoryRepository = catagoryRepository;
        }

        public ViewResult List()
        {
            PiesListViewModel piesListViewModel = new PiesListViewModel();
            piesListViewModel.CurrentCategory = "Cheese cakes";
            piesListViewModel.Pies = _pieRepository.Pies;
            return View(piesListViewModel);
        }
    }
}
