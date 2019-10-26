using Microsoft.BizTalk.Component.Interop;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GMB.Biztalk.PipelineComponents
{
    public abstract class PipelineComponentBase : IPersistPropertyBag
    {
        private static readonly ConcurrentDictionary<Type, XmlSerializer> serialisers = new ConcurrentDictionary<Type, XmlSerializer>();
        public abstract void GetClassID(out Guid classID);


        public abstract void InitNew();
       

        public void Load(IPropertyBag propertyBag, int errorLog)
        {
          
        }

        public void Save(IPropertyBag propertyBag, bool clearDirty, bool saveAllProperties)
        {
            throw new NotImplementedException();
        }


    }
}
