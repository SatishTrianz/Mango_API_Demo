using Microsoft.EntityFrameworkCore;
using Schmersal_Models.ApiModels;
using Schmersal_Models.Sch_Entities;
using SSchmersal_Models.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Mango_Services;
namespace Mango_Services.Services
{
    public class OfferStatusService : RepositoryBase<TblOffer>, IOfferStatusService
    {
        private readonly Sch_Context _context;

        public OfferStatusService(Sch_Context context) : base(context)
        {
            _context = context;
        }

        public async Task<string> CreateOfferStatus(TblOffer obj)
        {
            string Result = string.Empty;
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            try
            {
                var resultSet = 0;// await _context.Database.ExecuteSqlRawAsync("EXEC USP_SaveOfferStatusDetails  @OfferId={0},@ProjectId={1},@ServiceId ={2},@ServiceType={3},@Description ={4},@Region={5},@ContactPerson={6},@CustomerName ={7},@HoursProgress={8},@StartDate={9},@EndDate={10},@AssignedTo ={11},@RoadMapProgress={12},@Status={13}", obj.ProjectId, obj.OfferId, obj.ServiceId, obj.ServiceType, obj.Description, obj.Region, obj.ContactPerson, obj.CustomerName, obj.HoursProgress, obj.StartDate, obj.EndDate, obj.AssignedTo, obj.RoadMapProgress, obj.Status);
                if (resultSet > 0)
                {
                    Result = "Saved successfully";
                }
                else
                {
                    Result = "Failed to save data";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Result;
        }

        public async Task<string> DeleteOfferStatus(int offerStatusId)
        {
            string Result = string.Empty;
            var res = await _context.Database.ExecuteSqlRawAsync(@"USP_DeleteOfferStatusById {0}", offerStatusId);
            if (res > 0)
            {
                Result = "Deleted Successfully";
            }
            else
            {
                Result = "Failed to delete ";
            }
            return Result;
        }

        public async Task<List<OfferStatusAPIModel>> GetAllOfferStatus()
        {
            // return await _context.TblOffers.FromSqlRaw<OfferStatusAPIModel>($"USP_GetOfferStatusDetails").ToListAsync();
            var result = await (from p in _context.TblProjects
                                join customer in _context.TblCustomers on p.customer_id equals customer.erp_customer_id
                                join offer in _context.TblOffers on p.erp_project_id equals offer.project_id
                          select new OfferStatusAPIModel
                          {
                              offer_id=offer.id,
                              project_id=p.id,
                              Status=offer.status,
                              customer_name=customer.customer_name,
                          }).ToListAsync();
            return result;
        }
        public async Task<OfferStatusAPIModel> GetOfferStatusDetailsById(string offerId)
        {
            
            var result = await (from p in _context.TblProjects
                                join customer in _context.TblCustomers on p.customer_id equals customer.erp_customer_id
                                join offer in _context.TblOffers on p.erp_project_id equals offer.project_id
                                join contact in _context.TblContacts on offer.contact_id equals contact.contact_id
                                where offer.id== offerId
                                select new OfferStatusAPIModel
                                {
                                    offer_id = offer.id,
                                    project_id = p.id,
                                    Status = offer.status,
                                    customer_name = customer.customer_name,
                                    customer_id=customer.id,
                                    customer_address=customer.street,
                                    contact_id=contact.contact_id,
                                    contact_email=contact.email_address,
                                    contact_number=contact.phone_number

                                }).FirstOrDefaultAsync();
            return result;
        }

        public async Task<string> UpdateOfferStatus(TblOffer obj)
        {
            string Result = string.Empty;

            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            try
            {

                int resultSet = 0;//await _context.Database.ExecuteSqlRawAsync("EXEC USP_UpdateOfferStatusDetails @OfferStatusId={0}, @OfferId={1},@ProjectId={2},@ServiceId ={3},@ServiceType={4},@Description ={5},@Region={6},@ContactPerson={7},@CustomerName ={8},@HoursProgress={9},@StartDate={10},@EndDate={11},@AssignedTo ={12},@RoadMapProgress={13},@Status={14}", obj.OfferStatusId, obj.ProjectId, obj.OfferId, obj.ServiceId, obj.ServiceType, obj.Description, obj.Region, obj.ContactPerson, obj.CustomerName, obj.HoursProgress, obj.StartDate, obj.EndDate, obj.AssignedTo, obj.RoadMapProgress, obj.Status);
                if (resultSet > 0)
                {
                    Result = "Update successfully";
                }
                else
                {
                    Result = "Failed to update data";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Result;
        }
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
