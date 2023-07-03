using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystemPro.classlar.Parametreler
{
    public class Prm
    {

        #region Static Parameters

        public static sbyte Error;
        public static string InformationScreenContent;

        #endregion

        #region Add Parameters
        private string barcode;
        private string bookName;
        private string auther;
        private string publisher;
        private string printingPlace;
        private string printingDate;
        private string printingCount;
        private string typeOfBook;
        private string page;
        private string language;
        private string subject;
        private string typeOfSupply;
        private string dateOfSupply;
        private string image;

        private int ekleyenID;
        private int publisherID;
        private int autherID;

        private bool escrowStatus;

        public string Barcode { get => barcode; set => barcode = value; }
        public string BookName { get => bookName; set => bookName = value; }
        public string Auther { get => auther; set => auther = value; }
        public string Puplisher { get => publisher; set => publisher = value; }
        public string PrintingPlace { get => printingPlace; set => printingPlace = value; }
        public string PrintingDate { get => printingDate; set => printingDate = value; }
        public string PrintingCount { get => printingCount; set => printingCount = value; }
        public string TypeOfBook { get => typeOfBook; set => typeOfBook = value; }
        public string Page { get => page; set => page = value; }
        public string Language { get => language; set => language = value; }
        public string Subject { get => subject; set => subject = value; }
        public string TypeOfSupply { get => typeOfSupply; set => typeOfSupply = value; }
        public string DateOfSupply { get => dateOfSupply; set => dateOfSupply = value; }
        public string Image { get => image; set => image = value; }
        public int EkleyenID { get => ekleyenID; set => ekleyenID = value; }
        public int PublisherID { get => publisherID; set => publisherID = value; }
        public int AutherID { get => autherID; set => autherID = value; }
        public bool EscrowStatus { get => escrowStatus; set => escrowStatus = value; }

        #endregion
    }
}
