using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using TokenManagement.Models;
using TokenManagement.Models.DomainObjects;

namespace TokenManagement.Controllers
{

   
    public class TokenController : Controller
        {
       
        private readonly ApplicationDbContext _db;
        public TokenController(ApplicationDbContext dbContext)
        {
            _db = dbContext;
        }

        [HttpPost]
            public ActionResult IssueToken(Customer customer)
            {
            var newToken = new Token
            {
                //ServiceCounter = customer.CategoryID.ToString(),
                CreatedAt = DateTime.Now,
                ResolutionStatus = "Pending" 
            };

            _db.Tokens.Add(newToken);
            _db.SaveChanges();

            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public IActionResult GenerateToken([FromBody] Customer customerData)
        {
            try
            {
                var token = customerData.CustomerID + customerData.FirstName + customerData.LastName + customerData.CategoryID;

                var tokenEntity = new Token { TokenID = token, CustomerID = customerData.CustomerID, ResolutionStatus = "Pending", CategoryID = customerData.CategoryID, CreatedAt = DateTime.Now };


                _db.Tokens.Add(tokenEntity);
                _db.SaveChanges();

                var tokensCount = _db.Tokens.Count(t => t.CategoryID == customerData.CategoryID.ToString());

                return Json(new { Count = tokensCount.ToString() });
            }
            catch (Exception ex) {
                return Json(new { Error = ex.Message });    
            }
        }
        [HttpGet]
        [Route("GetNowServingTickets")]
        public IActionResult GetNowServingTickets()
        {
           
            var nowServingTickets = new List<string>
            {
                "A001",
                "A002",
                "A003",
            
            };

            return Json(nowServingTickets);
        }   

    }
 
}
