using ExaminationSystem.ViewModel.CourcViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.CourceServices
{
    public interface ICourceService
    {

        int Add(CourceviewModel viewModel);
        IEnumerable<CourceviewModel> GetAll();
        CourceviewModel GetByID(int id);
    }
}
