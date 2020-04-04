[assembly: System.Runtime.InteropServices.Guid("ae337f3f-7dd0-4c49-9046-2c492922e205")]
[assembly: System.Runtime.InteropServices.ComVisible(false)]
[assembly: System.Reflection.AssemblyTitle("Iprosoft.ELMA.MailReaders")]
[assembly: EleWise.ELMA.ComponentModel.ComponentAssembly()]
[assembly: EleWise.ELMA.Model.Attributes.ModelAssembly()]

namespace Iprosoft.ELMA.MailReaders
{
    using System;
    
    
    [global::EleWise.ELMA.Model.Attributes.MetadataType(typeof(global::EleWise.ELMA.Model.Metadata.AssemblyInfoMetadata))]
    [global::EleWise.ELMA.Model.Attributes.Uid("ae337f3f-7dd0-4c49-9046-2c492922e205")]
    internal class @__AssemblyInfo
    {
        
        /// <summary>
        /// Уникальный идентификатор данного класса
        /// </summary>
        public const string UID_S = "ae337f3f-7dd0-4c49-9046-2c492922e205";
        
        private static global::System.Guid _UID = new global::System.Guid(UID_S);
        
        /// <summary>
        /// Уникальный идентификатор данного класса
        /// </summary>
        public static global::System.Guid UID
        {
            get
            {
                return _UID;
            }
        }
    }
    
    internal class @__Resources__AssemblyInfo
    {
        
        public static string DisplayName
        {
            get
            {
                return global::EleWise.ELMA.SR.T("Iprosoft.ELMA.MailReaders");
            }
        }
    }
}
