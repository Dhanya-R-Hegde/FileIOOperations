using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FileIOOperations
{
    internal class XMLSerialization
    {
        public void serializeXml()
        {
            XmlSerializer ser = new XmlSerializer(typeof(OrderForm));
            FileStream fileStream = new FileStream(@"", FileMode.Create);
            OrderForm orderForm = new OrderForm();
            DateTime dt = new DateTime(2013, 12, 31);
            orderForm.orderDate = dt;
            ser.Serialize(fileStream, orderForm);
        }
    }

    public class OrderForm
    {
        public DateTime orderDate;
    }
}
