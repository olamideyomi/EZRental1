using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ARMSDALayer;

namespace ARMSBOLayer
{
    public class CreditCardMerchant
    {
        // Public instance properties
        public byte MerchantCode { get; set; }
        public string MerchantName { get; set; }

        // Public Constructors & Destructor Methods
        public CreditCardMerchant()
        {
            this.MerchantCode = 0;
            this.MerchantName = " ";
        }

        public CreditCardMerchant(byte mCode, string mName)
        {
            this.MerchantCode = mCode;
            this.MerchantName = mName;
        }

        ~CreditCardMerchant() { }

        // Public Instance Methods
        public void Print()
        {
            try
            {
                StreamWriter objPrinterFile = new StreamWriter("Network_Printer.txt", true);
                objPrinterFile.WriteLine("Credit Card Merchant Information: ");
                objPrinterFile.WriteLine("Merchant Code = {0}", this.MerchantCode);
                objPrinterFile.WriteLine("Merchant Name = {0}", this.MerchantName);
                objPrinterFile.WriteLine();
                objPrinterFile.Close();
            }
            catch (Exception objE)
            {
                throw new Exception("Unexpected Error in Print() Method: {0} " + objE.Message);
            }
        }

        // Public Instance & Static Data Access Methods
        public static List<CreditCardMerchant> GetAllCreditCardMerchants()
        {
            return DALayer_GetAllCreditCardMerchants();
        }

        // Protected Instance & Static Data Access Methods
        protected static List<CreditCardMerchant> DALayer_GetAllCreditCardMerchants()
        {
           //Step A-Start Error Trapping
            try
            {
                //Step 1-Use DAL object Factory Base Class POINTER to get the SQL Server FACTORY
                //Data Access Object using POLYMORPHISM.
                DALObjectFactoryBase objDAOFactory =
                DALObjectFactoryBase.GetDataSourceDAOFactory(DALObjectFactoryBase.SQLSERVER);
                //Step 2-now that you have the SQL FACTORY object GET DAO object to do the work
                CreditCardMerchantDAO objCreditCardMerchantDAO = objDAOFactory.GetCreditCardMerchantDAO();
                //Step 3-call CreditCardDAO DAO to do the work & return COLLECTION of Data Transfer Objects
                List<CreditCardMerchantDTO> objCreditCardMerchantDTOList =
               objCreditCardMerchantDAO.GetAllRecords();
                //Step 4- test if List<CreditCardMerchantDTO> DTO collection exists (returned from DBMS)
                if (objCreditCardMerchantDTOList != null)
                {
                    //Step 5-Create a LIST Collection of CreditCardMerchant objects to populate with
                    //the data from each DTO Object in of DTO collection
                    List<CreditCardMerchant> objCreditCardMerchantList = new List<CreditCardMerchant>();
                    //Step 6-Loop through List<CreditCardMerchantDTO> objCreditCardDTOList collection
                    foreach (CreditCardMerchantDTO objDTO in objCreditCardMerchantDTOList)
                    {
                        //Step 6a-Create new CreditCardMerchant object
                        CreditCardMerchant objCreditCardMerchant = new CreditCardMerchant();
                        //Step 6b-get the data from DTO object and SET CreditCardMerchant object
                        objCreditCardMerchant.MerchantCode = objDTO.MerchantCode;
                        objCreditCardMerchant.MerchantName = objDTO.MerchantName;

                        //Step 6c-Add CreditCardMerchant Object to the objCreditCardMerchantList COLLECTION
                        objCreditCardMerchantList.Add(objCreditCardMerchant);
                    }//End of foreach
                     //Step 6d-once copy process ends, Return objCreditCardMerchantList COLLECTION
                    return objCreditCardMerchantList;
                }//End of if
                else
                {
                  //Step 6e- No DTO collection object returned from DALayer, return a null
                    return null;
                } 
            }//End of try
             //Step B-Traps for general exception.
            catch (Exception objE)
            {
                //Step C-Re-Throw a general exceptions
                throw new Exception("Unexpected Error in DALayer_GetAllCreditCards(key) Method: {0} " +
                objE.Message);
            }
        }  //End of methodEnd of method
    }
}
