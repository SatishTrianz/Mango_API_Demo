using Schmersal_Models.ApiModels;
using SSchmersal_Models.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mango_Services.Services
{
        public interface IOfferStatusService : IRepositoryBase<TblOffer>
        {
            Task<OfferStatusAPIModel> GetOfferStatusDetailsById(string offerId);
            Task<List<OfferStatusAPIModel>> GetAllOfferStatus();
            Task<string> CreateOfferStatus(TblOffer offerStatus);
            Task<string> UpdateOfferStatus(TblOffer offerStatus);
            Task<string> DeleteOfferStatus(int offerStatusId);
        }
    
}
