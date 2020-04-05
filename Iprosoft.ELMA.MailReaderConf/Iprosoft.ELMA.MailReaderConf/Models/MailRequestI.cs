#pragma warning disable 108,114,162
namespace Iprosoft.ELMA.MailReaderConf.Models
{
    using System;
    using System.Linq;
    using EleWise.ELMA.Extensions;
    
    
    /// <summary>
    /// E-mail запрос
    /// </summary>
    [global::EleWise.ELMA.Model.Attributes.MetadataType(typeof(global::EleWise.ELMA.Model.Metadata.EntityMetadata))]
    [global::EleWise.ELMA.Model.Attributes.Uid("e3cce157-5df1-4021-9ed9-1d60ef25a92f")]
    [global::EleWise.ELMA.Model.Attributes.DisplayName(typeof(@__Resources_IMailRequestI), "DisplayName")]
    [global::EleWise.ELMA.Model.Attributes.DisplayFormat(null)]
    [global::EleWise.ELMA.Model.Attributes.TitleProperty("d8b25adc-a344-41e1-8764-52c2dfd468de")]
    [global::EleWise.ELMA.Model.Attributes.ClassFormsScheme(global::EleWise.ELMA.Model.Metadata.ClassFormsScheme.FormConstructor)]
    [global::EleWise.ELMA.Model.Attributes.DefaultForm(global::EleWise.ELMA.Model.Views.ViewType.Create, "00000000-0000-0000-0000-000000000000", "31692e31-47ff-47e3-af60-336de03d092a", "00000000-0000-0000-0000-000000000000", "00000000-0000-0000-0000-000000000000", false)]
    [global::EleWise.ELMA.Model.Attributes.DefaultForm(global::EleWise.ELMA.Model.Views.ViewType.Edit, "00000000-0000-0000-0000-000000000000", "31692e31-47ff-47e3-af60-336de03d092a", "00000000-0000-0000-0000-000000000000", "00000000-0000-0000-0000-000000000000", false)]
    [global::EleWise.ELMA.Model.Attributes.DefaultForm(global::EleWise.ELMA.Model.Views.ViewType.Display, "00000000-0000-0000-0000-000000000000", "f03f355f-26fe-49b8-b1e8-cf5746f5512a", "00000000-0000-0000-0000-000000000000", "00000000-0000-0000-0000-000000000000", false)]
    [global::EleWise.ELMA.Model.Attributes.Form(typeof(IMailRequestI), "Iprosoft.ELMA.MailReaderConf.Models.MailRequestI.Form.Form.xml")]
    [global::EleWise.ELMA.Model.Attributes.Form(typeof(IMailRequestI), "Iprosoft.ELMA.MailReaderConf.Models.MailRequestI.Form.Form1.xml")]
    [global::EleWise.ELMA.Model.Attributes.FormView(@"<?xml version=""1.0"" encoding=""utf-8""?>
<FormView xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <ViewType>Display</ViewType>
  <CanUseCommonView>true</CanUseCommonView>
  <CanUseCommonRazorView>true</CanUseCommonRazorView>
  <CanUseTabView>true</CanUseTabView>
  <CanUseTabRazorView>true</CanUseTabRazorView>
  <ViewInCommon>true</ViewInCommon>
</FormView>")]
    [global::EleWise.ELMA.Model.Attributes.FormView(@"<?xml version=""1.0"" encoding=""utf-8""?>
<FormView xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <ViewType>Create</ViewType>
  <CanUseCommonView>true</CanUseCommonView>
  <CanUseCommonRazorView>true</CanUseCommonRazorView>
  <CanUseTabView>true</CanUseTabView>
  <CanUseTabRazorView>true</CanUseTabRazorView>
  <ViewInCommon>true</ViewInCommon>
</FormView>")]
    [global::EleWise.ELMA.Model.Attributes.FormView(@"<?xml version=""1.0"" encoding=""utf-8""?>
<FormView xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <ViewType>Edit</ViewType>
  <CanUseCommonView>true</CanUseCommonView>
  <CanUseCommonRazorView>true</CanUseCommonRazorView>
  <CanUseTabView>true</CanUseTabView>
  <CanUseTabRazorView>true</CanUseTabRazorView>
  <ViewInCommon>true</ViewInCommon>
</FormView>")]
    [global::EleWise.ELMA.Model.Attributes.TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2" +
        "001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>89" +
        "787f32-7c42-4f27-8426-76b082e6add4</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableVi" +
        "ew>")]
    [global::EleWise.ELMA.Model.Attributes.Entity("MailRequestI")]
    [global::EleWise.ELMA.Model.Attributes.IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
    [global::EleWise.ELMA.Model.Attributes.ShowInCatalogList(true)]
    [global::EleWise.ELMA.Model.Attributes.EntityMetadataType(global::EleWise.ELMA.Model.Metadata.EntityMetadataType.Interface)]
    [global::EleWise.ELMA.Model.Attributes.SaveHistory()]
    [global::EleWise.ELMA.Model.Attributes.Filterable()]
    [global::EleWise.ELMA.Model.Attributes.ImplementationUid("f1286452-cfe8-49a1-a4a2-f48232234142")]
    [global::EleWise.ELMA.Model.Attributes.FilterType(typeof(IMailRequestIFilter))]
    public partial interface IMailRequestI : global::EleWise.ELMA.Model.Entities.IEntity<long>
    {
        
        /// <summary>
        /// Уникальный идентификатор
        /// </summary>
        [global::EleWise.ELMA.Model.Attributes.Uid("d47c3d20-33d8-4900-b73b-ec5449c3b566")]
        [global::EleWise.ELMA.ComponentModel.NotNull()]
        [global::EleWise.ELMA.Model.Attributes.SystemProperty()]
        [global::EleWise.ELMA.Model.Attributes.Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
        [global::EleWise.ELMA.Model.Types.Settings.GuidSettings(FieldName="Uid")]
        [global::EleWise.ELMA.Model.Attributes.DisplayName(typeof(@__Resources_IMailRequestI), "P_Uid_DisplayName")]
        [global::EleWise.ELMA.Model.Attributes.View(ViewType=global::EleWise.ELMA.Model.Views.ViewType.All, ItemType=global::EleWise.ELMA.Model.Views.ItemType.Default, Visibility=global::EleWise.ELMA.Model.Views.Visibility.Hidden, ReadOnly=true)]
        [global::EleWise.ELMA.Model.Attributes.EntityProperty()]
        System.Guid Uid
        {
            get;
            set;
        }
        
        /// <summary>
        /// Наименование
        /// </summary>
        [global::EleWise.ELMA.Model.Attributes.Uid("d8b25adc-a344-41e1-8764-52c2dfd468de")]
        [global::EleWise.ELMA.Model.Attributes.Order(1)]
        [global::EleWise.ELMA.Model.Attributes.Required(true)]
        [global::EleWise.ELMA.Model.Attributes.Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
        [global::EleWise.ELMA.Model.Types.Settings.StringSettings(DefaultValue="name", FieldName="Name")]
        [global::EleWise.ELMA.Model.Types.Validation.RequiredField()]
        [global::EleWise.ELMA.Model.Attributes.DisplayName(typeof(@__Resources_IMailRequestI), "P_Name_DisplayName")]
        [global::EleWise.ELMA.Model.Attributes.View(ViewType=global::EleWise.ELMA.Model.Views.ViewType.Create, ItemType=global::EleWise.ELMA.Model.Views.ItemType.Default, Visibility=global::EleWise.ELMA.Model.Views.Visibility.Visible, ReadOnly=false)]
        [global::EleWise.ELMA.Model.Attributes.View(ViewType=global::EleWise.ELMA.Model.Views.ViewType.Edit, ItemType=global::EleWise.ELMA.Model.Views.ItemType.Default, Visibility=global::EleWise.ELMA.Model.Views.Visibility.Visible, ReadOnly=false)]
        [global::EleWise.ELMA.Model.Attributes.View(ViewType=global::EleWise.ELMA.Model.Views.ViewType.Display, ItemType=global::EleWise.ELMA.Model.Views.ItemType.Default, Visibility=global::EleWise.ELMA.Model.Views.Visibility.Visible, ReadOnly=true)]
        [global::EleWise.ELMA.Model.Attributes.View(ViewType=global::EleWise.ELMA.Model.Views.ViewType.List, ItemType=global::EleWise.ELMA.Model.Views.ItemType.Default, Visibility=global::EleWise.ELMA.Model.Views.Visibility.Visible, ReadOnly=false)]
        [global::EleWise.ELMA.Model.Attributes.View(ViewType=global::EleWise.ELMA.Model.Views.ViewType.Filter, ItemType=global::EleWise.ELMA.Model.Views.ItemType.Default, Visibility=global::EleWise.ELMA.Model.Views.Visibility.Visible, ReadOnly=false)]
        [global::EleWise.ELMA.Model.Attributes.FastSearch(true)]
        [global::EleWise.ELMA.Model.Attributes.Filterable()]
        [global::EleWise.ELMA.Model.Attributes.EntityProperty()]
        string Name
        {
            get;
            set;
        }
        
        /// <summary>
        /// Дата создания
        /// </summary>
        [global::EleWise.ELMA.Model.Attributes.Uid("9cfebdbc-7433-436d-955c-28039439cd59")]
        [global::EleWise.ELMA.Model.Attributes.Order(2)]
        [global::EleWise.ELMA.ComponentModel.NotNull()]
        [global::EleWise.ELMA.Model.Attributes.Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
        [global::EleWise.ELMA.Model.Types.Settings.DateTimeSettings(SetCurrentDate=true, FieldName="CreationDate")]
        [global::EleWise.ELMA.Model.Attributes.DisplayName(typeof(@__Resources_IMailRequestI), "P_CreationDate_DisplayName")]
        [global::EleWise.ELMA.Model.Attributes.PropertyHandler("d0c00d8a-e003-427d-9942-f52cfb77b0f0")]
        [global::EleWise.ELMA.Model.Attributes.View(ViewType=global::EleWise.ELMA.Model.Views.ViewType.Create, ItemType=global::EleWise.ELMA.Model.Views.ItemType.Default, Visibility=global::EleWise.ELMA.Model.Views.Visibility.Hidden, ReadOnly=false)]
        [global::EleWise.ELMA.Model.Attributes.View(ViewType=global::EleWise.ELMA.Model.Views.ViewType.Edit, ItemType=global::EleWise.ELMA.Model.Views.ItemType.Default, Visibility=global::EleWise.ELMA.Model.Views.Visibility.Visible, ReadOnly=true)]
        [global::EleWise.ELMA.Model.Attributes.View(ViewType=global::EleWise.ELMA.Model.Views.ViewType.Display, ItemType=global::EleWise.ELMA.Model.Views.ItemType.Default, Visibility=global::EleWise.ELMA.Model.Views.Visibility.Visible, ReadOnly=true)]
        [global::EleWise.ELMA.Model.Attributes.View(ViewType=global::EleWise.ELMA.Model.Views.ViewType.List, ItemType=global::EleWise.ELMA.Model.Views.ItemType.Default, Visibility=global::EleWise.ELMA.Model.Views.Visibility.Hidden, ReadOnly=false)]
        [global::EleWise.ELMA.Model.Attributes.Filterable()]
        [global::EleWise.ELMA.Model.Attributes.EntityProperty()]
        System.DateTime CreationDate
        {
            get;
            set;
        }
        
        /// <summary>
        /// Автор создания
        /// </summary>
        [global::EleWise.ELMA.Model.Attributes.Uid("452b64cc-16b6-4c03-aefa-e8a3fe28b173")]
        [global::EleWise.ELMA.Model.Attributes.Order(3)]
        [global::EleWise.ELMA.Model.Attributes.Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfdeb03c-35e9-45e7-aad8-037d83888f73")]
        [global::EleWise.ELMA.Security.Types.Settings.EntityUserSettings(FieldName="CreationAuthor")]
        [global::EleWise.ELMA.Model.Attributes.DisplayName(typeof(@__Resources_IMailRequestI), "P_CreationAuthor_DisplayName")]
        [global::EleWise.ELMA.Model.Attributes.PropertyHandler("b05ac6bd-eb8b-474a-a796-b53831a9967e")]
        [global::EleWise.ELMA.Model.Attributes.View(ViewType=global::EleWise.ELMA.Model.Views.ViewType.Create, ItemType=global::EleWise.ELMA.Model.Views.ItemType.Default, Visibility=global::EleWise.ELMA.Model.Views.Visibility.Hidden, ReadOnly=false)]
        [global::EleWise.ELMA.Model.Attributes.View(ViewType=global::EleWise.ELMA.Model.Views.ViewType.Edit, ItemType=global::EleWise.ELMA.Model.Views.ItemType.Default, Visibility=global::EleWise.ELMA.Model.Views.Visibility.Visible, ReadOnly=true)]
        [global::EleWise.ELMA.Model.Attributes.View(ViewType=global::EleWise.ELMA.Model.Views.ViewType.Display, ItemType=global::EleWise.ELMA.Model.Views.ItemType.Default, Visibility=global::EleWise.ELMA.Model.Views.Visibility.Visible, ReadOnly=true)]
        [global::EleWise.ELMA.Model.Attributes.View(ViewType=global::EleWise.ELMA.Model.Views.ViewType.List, ItemType=global::EleWise.ELMA.Model.Views.ItemType.Default, Visibility=global::EleWise.ELMA.Model.Views.Visibility.Hidden, ReadOnly=false)]
        [global::EleWise.ELMA.Model.Attributes.Filterable()]
        [global::EleWise.ELMA.Model.Attributes.EntityProperty()]
        EleWise.ELMA.Security.Models.IUser CreationAuthor
        {
            get;
            set;
        }
        
        /// <summary>
        /// Дата изменения
        /// </summary>
        [global::EleWise.ELMA.Model.Attributes.Uid("46225b35-9e82-4914-97ff-0d12964f597d")]
        [global::EleWise.ELMA.Model.Attributes.Order(4)]
        [global::EleWise.ELMA.ComponentModel.CanBeNull()]
        [global::EleWise.ELMA.Model.Attributes.Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
        [global::EleWise.ELMA.Model.Types.Settings.DateTimeSettings(FieldName="ChangeDate")]
        [global::EleWise.ELMA.Model.Attributes.DisplayName(typeof(@__Resources_IMailRequestI), "P_ChangeDate_DisplayName")]
        [global::EleWise.ELMA.Model.Attributes.PropertyHandler("12a6c5c4-12f8-4b2e-b7ea-5438974a2d25")]
        [global::EleWise.ELMA.Model.Attributes.View(ViewType=global::EleWise.ELMA.Model.Views.ViewType.Create, ItemType=global::EleWise.ELMA.Model.Views.ItemType.Default, Visibility=global::EleWise.ELMA.Model.Views.Visibility.Hidden, ReadOnly=false)]
        [global::EleWise.ELMA.Model.Attributes.View(ViewType=global::EleWise.ELMA.Model.Views.ViewType.Edit, ItemType=global::EleWise.ELMA.Model.Views.ItemType.Default, Visibility=global::EleWise.ELMA.Model.Views.Visibility.Visible, ReadOnly=true)]
        [global::EleWise.ELMA.Model.Attributes.View(ViewType=global::EleWise.ELMA.Model.Views.ViewType.Display, ItemType=global::EleWise.ELMA.Model.Views.ItemType.Default, Visibility=global::EleWise.ELMA.Model.Views.Visibility.Visible, ReadOnly=true)]
        [global::EleWise.ELMA.Model.Attributes.View(ViewType=global::EleWise.ELMA.Model.Views.ViewType.List, ItemType=global::EleWise.ELMA.Model.Views.ItemType.Default, Visibility=global::EleWise.ELMA.Model.Views.Visibility.Hidden, ReadOnly=false)]
        [global::EleWise.ELMA.Model.Attributes.Filterable()]
        [global::EleWise.ELMA.Model.Attributes.EntityProperty()]
        System.Nullable<System.DateTime> ChangeDate
        {
            get;
            set;
        }
        
        /// <summary>
        /// Автор изменения
        /// </summary>
        [global::EleWise.ELMA.Model.Attributes.Uid("2132b9e8-3f9a-4ef0-a961-03c98c24dfa4")]
        [global::EleWise.ELMA.Model.Attributes.Order(5)]
        [global::EleWise.ELMA.Model.Attributes.Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfdeb03c-35e9-45e7-aad8-037d83888f73")]
        [global::EleWise.ELMA.Security.Types.Settings.EntityUserSettings(FieldName="ChangeAuthor")]
        [global::EleWise.ELMA.Model.Attributes.DisplayName(typeof(@__Resources_IMailRequestI), "P_ChangeAuthor_DisplayName")]
        [global::EleWise.ELMA.Model.Attributes.PropertyHandler("d152e660-1ee9-4b5f-a614-df280e5b3f98")]
        [global::EleWise.ELMA.Model.Attributes.View(ViewType=global::EleWise.ELMA.Model.Views.ViewType.Create, ItemType=global::EleWise.ELMA.Model.Views.ItemType.Default, Visibility=global::EleWise.ELMA.Model.Views.Visibility.Hidden, ReadOnly=false)]
        [global::EleWise.ELMA.Model.Attributes.View(ViewType=global::EleWise.ELMA.Model.Views.ViewType.Edit, ItemType=global::EleWise.ELMA.Model.Views.ItemType.Default, Visibility=global::EleWise.ELMA.Model.Views.Visibility.Visible, ReadOnly=true)]
        [global::EleWise.ELMA.Model.Attributes.View(ViewType=global::EleWise.ELMA.Model.Views.ViewType.Display, ItemType=global::EleWise.ELMA.Model.Views.ItemType.Default, Visibility=global::EleWise.ELMA.Model.Views.Visibility.Visible, ReadOnly=true)]
        [global::EleWise.ELMA.Model.Attributes.View(ViewType=global::EleWise.ELMA.Model.Views.ViewType.List, ItemType=global::EleWise.ELMA.Model.Views.ItemType.Default, Visibility=global::EleWise.ELMA.Model.Views.Visibility.Hidden, ReadOnly=false)]
        [global::EleWise.ELMA.Model.Attributes.Filterable()]
        [global::EleWise.ELMA.Model.Attributes.EntityProperty()]
        EleWise.ELMA.Security.Models.IUser ChangeAuthor
        {
            get;
            set;
        }
        
        /// <summary>
        /// Письма
        /// </summary>
        [global::EleWise.ELMA.Model.Attributes.Uid("f19d4133-ce78-47e5-81b4-cd45553a8184")]
        [global::EleWise.ELMA.Model.Attributes.Order(6)]
        [global::EleWise.ELMA.Model.Attributes.Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "6648633a-d6f5-495c-a675-38fcb6b9258f")]
        [global::EleWise.ELMA.Model.Types.Settings.EntitySettings(RelationType=global::EleWise.ELMA.Model.Types.Settings.RelationType.ManyToMany, RelationTableName="M_MailRequestI_Pisjma", ParentColumnName="Parent", ChildColumnName="Child", CascadeMode=global::EleWise.ELMA.Model.Types.Settings.CascadeMode.SaveUpdate)]
        [global::EleWise.ELMA.Model.Attributes.DisplayName(typeof(@__Resources_IMailRequestI), "P_Pisjma_DisplayName")]
        [global::EleWise.ELMA.Model.Attributes.View(ViewType=global::EleWise.ELMA.Model.Views.ViewType.Create, ItemType=global::EleWise.ELMA.Model.Views.ItemType.Default, Visibility=global::EleWise.ELMA.Model.Views.Visibility.Visible, ReadOnly=false)]
        [global::EleWise.ELMA.Model.Attributes.View(ViewType=global::EleWise.ELMA.Model.Views.ViewType.Edit, ItemType=global::EleWise.ELMA.Model.Views.ItemType.Default, Visibility=global::EleWise.ELMA.Model.Views.Visibility.Visible, ReadOnly=false)]
        [global::EleWise.ELMA.Model.Attributes.View(ViewType=global::EleWise.ELMA.Model.Views.ViewType.Display, ItemType=global::EleWise.ELMA.Model.Views.ItemType.Default, Visibility=global::EleWise.ELMA.Model.Views.Visibility.Visible, ReadOnly=true)]
        [global::EleWise.ELMA.Model.Attributes.View(ViewType=global::EleWise.ELMA.Model.Views.ViewType.List, ItemType=global::EleWise.ELMA.Model.Views.ItemType.Default, Visibility=global::EleWise.ELMA.Model.Views.Visibility.Hidden, ReadOnly=false)]
        [global::EleWise.ELMA.Model.Attributes.View(ViewType=global::EleWise.ELMA.Model.Views.ViewType.Filter, ItemType=global::EleWise.ELMA.Model.Views.ItemType.Default, Visibility=global::EleWise.ELMA.Model.Views.Visibility.Visible, ReadOnly=false)]
        [global::EleWise.ELMA.Model.Attributes.EntityProperty()]
        Iesi.Collections.Generic.ISet<Iprosoft.ELMA.MailReaderConf.Models.IEMailMessageI> Pisjma
        {
            get;
            set;
        }
    }
    
    internal class @__Resources_IMailRequestI
    {
        
        public static string DisplayName
        {
            get
            {
                return global::EleWise.ELMA.SR.T("E-mail запрос");
            }
        }
        
        public static string P_Uid_DisplayName
        {
            get
            {
                return global::EleWise.ELMA.SR.T("Уникальный идентификатор");
            }
        }
        
        public static string P_Name_DisplayName
        {
            get
            {
                return global::EleWise.ELMA.SR.T("Наименование");
            }
        }
        
        public static string P_CreationDate_DisplayName
        {
            get
            {
                return global::EleWise.ELMA.SR.T("Дата создания");
            }
        }
        
        public static string P_CreationAuthor_DisplayName
        {
            get
            {
                return global::EleWise.ELMA.SR.T("Автор создания");
            }
        }
        
        public static string P_ChangeDate_DisplayName
        {
            get
            {
                return global::EleWise.ELMA.SR.T("Дата изменения");
            }
        }
        
        public static string P_ChangeAuthor_DisplayName
        {
            get
            {
                return global::EleWise.ELMA.SR.T("Автор изменения");
            }
        }
        
        public static string P_Pisjma_DisplayName
        {
            get
            {
                return global::EleWise.ELMA.SR.T("Письма");
            }
        }
        
        private static string @__AllFormsResources
        {
            get
            {
                return global::EleWise.ELMA.SR.T("Создание");
                return global::EleWise.ELMA.SR.T("Просмотр");
            }
        }
    }
    
    /// <summary>
    /// Фильтр для объекта "E-mail запрос"
    /// </summary>
    [global::EleWise.ELMA.Model.Attributes.FilterFor(typeof(IMailRequestI))]
    public interface IMailRequestIFilter : global::EleWise.ELMA.Model.Common.IEntityFilter
    {
        
        /// <summary>
        /// Фильтр для свойства "Наименование"
        /// </summary>
        string Name
        {
            get;
            set;
        }
        
        /// <summary>
        /// Фильтр для свойства "Дата создания"
        /// </summary>
        EleWise.ELMA.Model.Ranges.DateTimeRange CreationDate
        {
            get;
            set;
        }
        
        /// <summary>
        /// Фильтр для свойства "Автор создания"
        /// </summary>
        EleWise.ELMA.Security.Models.IUser CreationAuthor
        {
            get;
            set;
        }
        
        /// <summary>
        /// Фильтр для свойства "Дата изменения"
        /// </summary>
        EleWise.ELMA.Model.Ranges.DateTimeRange ChangeDate
        {
            get;
            set;
        }
        
        /// <summary>
        /// Фильтр для свойства "Автор изменения"
        /// </summary>
        EleWise.ELMA.Security.Models.IUser ChangeAuthor
        {
            get;
            set;
        }
    }
}
#pragma warning restore 108,114,162
