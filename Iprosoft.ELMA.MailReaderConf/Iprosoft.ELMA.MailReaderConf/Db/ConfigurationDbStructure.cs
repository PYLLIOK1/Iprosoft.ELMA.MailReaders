using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Runtime.Db;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Services;
using Iprosoft.ELMA.MailReaderConf.Models;
using System;
using System.Collections.Generic;


namespace Iprosoft.ELMA.MailReaderConf.Db
{
    [Component]
    internal class ConfigurationDbStructure : DbStructureExtension
    {
        public override Guid ProviderUid => Guid.Empty;

        public void CreateEmailMessageITemaIndexes()
        {
            var transform = Locator.GetServiceNotNull<ITransformationProvider>();
            transform.AddIndex(new Index()
            {
                Name = "IX_EmailMessageI_Tema",
                TableName = "EmailMessageI",
                Columns = new List<string> { nameof(IEMailMessageI.Tema) }
            });
        }
    }
}
