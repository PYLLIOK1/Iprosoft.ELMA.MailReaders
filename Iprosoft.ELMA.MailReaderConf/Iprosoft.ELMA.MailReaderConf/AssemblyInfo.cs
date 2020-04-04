[assembly: System.Runtime.InteropServices.Guid("8928e471-8e8e-4348-88c6-f01c8c1479bc")]
[assembly: System.Runtime.InteropServices.ComVisible(false)]
[assembly: System.Reflection.AssemblyTitle("Iprosoft.ELMA.MailReaderConf")]
[assembly: System.Reflection.AssemblyDescription("Iprosoft.ELMA.MailReaderConf")]
[assembly: EleWise.ELMA.ComponentModel.ComponentAssembly()]
[assembly: EleWise.ELMA.Model.Attributes.ModelAssembly()]

namespace Iprosoft.ELMA.MailReaderConf
{
    using System;
    
    
    [global::EleWise.ELMA.Model.Attributes.MetadataType(typeof(global::EleWise.ELMA.Model.Metadata.AssemblyInfoMetadata))]
    [global::EleWise.ELMA.Model.Attributes.Uid("8928e471-8e8e-4348-88c6-f01c8c1479bc")]
    [global::EleWise.ELMA.Model.Attributes.AssemblySummary(typeof(@__Resources__AssemblyInfo), "Summary")]
    internal class @__AssemblyInfo
    {
        
        /// <summary>
        /// Уникальный идентификатор данного класса
        /// </summary>
        public const string UID_S = "8928e471-8e8e-4348-88c6-f01c8c1479bc";
        
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
                return global::EleWise.ELMA.SR.T("Iprosoft.ELMA.MailReaderConf");
            }
        }
        
        public static string Description
        {
            get
            {
                return global::EleWise.ELMA.SR.T("Iprosoft.ELMA.MailReaderConf");
            }
        }
        
        public static string Summary
        {
            get
            {
                return global::EleWise.ELMA.SR.T("Iprosoft.ELMA.MailReaderConf");
            }
        }
    }
}
