using DeltaSoftTask.Core;
using DeltaSoftTask.Core.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeltaSoftTask.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public MemberController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet("GetAll")]
        public IEnumerable<Member> GetAllMembers()
        {
            return _unitOfWork.Members.GetAll();
        }
    }
}
