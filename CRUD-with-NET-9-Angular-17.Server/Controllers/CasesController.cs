using CRUD_with_NET_9_Angular_17.Server.Data;
using CRUD_with_NET_9_Angular_17.Server.Models;
using CRUD_with_NET_9_Angular_17.Server.Models.Domain;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_with_NET_9_Angular_17.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CasesController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;
        public CasesController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetAllCases()
        {
            var contacts = dbContext.Cases.ToList();
            return Ok(contacts);
        }

        [HttpPost]
        public IActionResult AddCase(AddCaseRequestDto request)
        {
            var domainModelCase = new Case
            {
                Id = Guid.NewGuid(),
                CaseNumber = request.CaseNumber,
                Defendant = request.Defendant,
                Plaintiff = request.Plaintiff,
                Officer = request.Officer,
                BadgeNumber = request.BadgeNumber,
                DescriptionOfIncident = request.DescriptionOfIncident
            };

            dbContext.Cases.Add(domainModelCase);
            dbContext.SaveChanges();
            return Ok(domainModelCase);
        }

        //[HttpPut("{id:guid}")]
        //public IActionResult UpdateContact(Guid id, UpdateContactRequestDto request)
        //{
        //    var existingContact = dbContext.Cases.FirstOrDefault(c => c.Id == id);
        //    if (existingContact == null)
        //    {
        //        return NotFound($"Contact with ID {id} not found.");
        //    }

        //    // Update the existing contact's properties
        //    existingContact.Name = request?.Name;
        //    existingContact.OrganizationName = request?.OrganizationName;
        //    existingContact.Email = request?.Email;
        //    existingContact.Phone = request?.Phone;
        //    existingContact.IsInterviewSchedule = request?.IsInterviewSchedule;

        //    dbContext.SaveChanges();
        //    return Ok(existingContact);
        //}

        //[HttpDelete("{id:guid}")]
        //public IActionResult DeleteContact(Guid id)
        //{
        //    var contact = dbContext.Cases.FirstOrDefault(c => c.Id == id);
        //    if (contact == null)
        //    {
        //        return NotFound($"Contact with ID {id} not found.");
        //    }

        //    dbContext.Cases.Remove(contact);
        //    dbContext.SaveChanges();
        //    GetAllContacts();

        //    return Ok($"Contact with ID {id} deleted successfully.");
        //}
    }
}