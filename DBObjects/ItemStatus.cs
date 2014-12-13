using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JentrousMarketing.TransferObjects;

namespace JentrousMarketing.DBObjects
{
    public class ItemStatus
    {
        private Int32 itemStatusId;
        private string itemStatusDesc;
        private int version;

        public ItemStatus()
        {

        }

        public ItemStatus(string itemStatusId)
        {
            ItemStatusDTO itemStatusDTO = new ItemStatusDTO();
            ItemStatus itemStatus = itemStatusDTO.getItemStatus(itemStatusId);

            this.itemStatusId = itemStatus.itemStatusId;
            this.itemStatusDesc = itemStatus.itemStatusDesc;
            this.version = itemStatus.Version;
        }

        public Int32 ItemStatusId
        {
            get { return itemStatusId; }
            set { itemStatusId = value; }
        }

        public string ItemStatusDesc
        {
            get { return itemStatusDesc; }
            set { itemStatusDesc = value; }
        }

        public int Version
        {
            get { return version; }
            set { version = value; }
        }
    }
}
