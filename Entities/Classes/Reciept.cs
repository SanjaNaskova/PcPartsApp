using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entities.Classes
{
   public class Reciept
    {
        public delegate void SendRecieptEventHendler();
        public event SendRecieptEventHendler SendReceipt;

        protected virtual void OnSendReceipt()
        {
            if (SendReceipt != null)
            {
                SendReceipt();
            }
            //else
            //{
            //    throw new NumberExeption2();
            //}
                
        }

        public void SendReceiptFinaly()
        {
            Console.WriteLine("Receipt sending...");
            Thread.Sleep(3000);
            OnSendReceipt();
        }
    }
}
