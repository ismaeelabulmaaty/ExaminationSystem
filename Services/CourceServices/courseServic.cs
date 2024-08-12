using AutoMapper;
using Core.Models;
using Core.Repository.Conttract;
using Core.Specifications.CourceSpec;
using ExaminationSystem.ViewModel.CourcViewModel;
using Microsoft.AspNetCore.Http.HttpResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.CourceServices
{
    public class courseServic : ICourceService
    {
        private readonly IGenericRepository<Course> _genericRepository;
        private readonly IMapper _mapper;
        private readonly ICourceService _courceService;

        public courseServic(IGenericRepository<Course> genericRepository , IMapper mapper , ICourceService courceService)
        {
            _genericRepository = genericRepository;
            _mapper = mapper;
            _courceService = courceService;
        }

        public int Add(CourceviewModel viewModel)
        {
            throw new NotImplementedException();
        }

     

        public CourceviewModel GetByID(int id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<CourceviewModel> ICourceService.GetAll()
        {
            var Spec = new CourcesSpec();
            var Cource =  _courceService.GetAll();
            return Cource;



        }
    }
}
