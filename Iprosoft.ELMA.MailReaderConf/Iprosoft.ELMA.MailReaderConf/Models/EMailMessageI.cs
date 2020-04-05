#pragma warning disable 108,114,162
namespace Iprosoft.ELMA.MailReaderConf.Models
{
    using System;
    using System.Linq;
    using EleWise.ELMA.Extensions;
    
    
    /// <summary>
    /// EMailMessageI
    /// </summary>
    [global::EleWise.ELMA.Model.Attributes.MetadataType(typeof(global::EleWise.ELMA.Model.Metadata.EntityMetadata))]
    [global::EleWise.ELMA.Model.Attributes.Uid("6648633a-d6f5-495c-a675-38fcb6b9258f")]
    [global::EleWise.ELMA.Model.Attributes.DisplayName(typeof(@__Resources_IEMailMessageI), "DisplayName")]
    [global::EleWise.ELMA.Model.Attributes.DisplayFormat(null)]
    [global::EleWise.ELMA.Model.Attributes.TitleProperty("1a2c3b3f-22f7-46db-93e2-218dfdac60c4")]
    [global::EleWise.ELMA.Model.Attributes.ClassFormsScheme(global::EleWise.ELMA.Model.Metadata.ClassFormsScheme.FormConstructor)]
    [global::EleWise.ELMA.Model.Attributes.DefaultForm(global::EleWise.ELMA.Model.Views.ViewType.Create, "00000000-0000-0000-0000-000000000000", "e2ea92ca-102e-4f56-80dd-7da212efc216", "00000000-0000-0000-0000-000000000000", "00000000-0000-0000-0000-000000000000", false)]
    [global::EleWise.ELMA.Model.Attributes.DefaultForm(global::EleWise.ELMA.Model.Views.ViewType.Edit, "00000000-0000-0000-0000-000000000000", "e2ea92ca-102e-4f56-80dd-7da212efc216", "00000000-0000-0000-0000-000000000000", "00000000-0000-0000-0000-000000000000", false)]
    [global::EleWise.ELMA.Model.Attributes.DefaultForm(global::EleWise.ELMA.Model.Views.ViewType.Display, "00000000-0000-0000-0000-000000000000", "82fea08d-ec27-4e17-9f0d-70ac59e21e01", "00000000-0000-0000-0000-000000000000", "00000000-0000-0000-0000-000000000000", false)]
    [global::EleWise.ELMA.Model.Attributes.Form(typeof(IEMailMessageI), "Iprosoft.ELMA.MailReaderConf.Models.EMailMessageI.Form.Form.xml")]
    [global::EleWise.ELMA.Model.Attributes.Form(typeof(IEMailMessageI), "Iprosoft.ELMA.MailReaderConf.Models.EMailMessageI.Form.Form1.xml")]
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
        "001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>87" +
        "c0a569-da23-424d-8107-24331f7b496a</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableVi" +
        "ew>")]
    [global::EleWise.ELMA.Model.Attributes.Entity("EMailMessageI")]
    [global::EleWise.ELMA.Model.Attributes.IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
    [global::EleWise.ELMA.Model.Attributes.ShowInCatalogList(true)]
    [global::EleWise.ELMA.Model.Attributes.EntityMetadataType(global::EleWise.ELMA.Model.Metadata.EntityMetadataType.Interface)]
    [global::EleWise.ELMA.Model.Attributes.SaveHistory()]
    [global::EleWise.ELMA.Model.Attributes.Filterable()]
    [global::EleWise.ELMA.Model.Attributes.ImplementationUid("fd5eb2d5-531c-4042-92aa-c40565928707")]
    [global::EleWise.ELMA.Model.Attributes.FilterType(typeof(IEMailMessageIFilter))]
    public partial interface IEMailMessageI : global::EleWise.ELMA.Model.Entities.IEntity<long>
    {
        
        /// <summary>
        /// Уникальный идентификатор
        /// </summary>
        [global::EleWise.ELMA.Model.Attributes.Uid("9ab435f1-883c-4c43-9789-7488c827118e")]
        [global::EleWise.ELMA.ComponentModel.NotNull()]
        [global::EleWise.ELMA.Model.Attributes.SystemProperty()]
        [global::EleWise.ELMA.Model.Attributes.Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
        [global::EleWise.ELMA.Model.Types.Settings.GuidSettings(FieldName="Uid")]
        [global::EleWise.ELMA.Model.Attributes.DisplayName(typeof(@__Resources_IEMailMessageI), "P_Uid_DisplayName")]
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
        [global::EleWise.ELMA.Model.Attributes.Uid("1a2c3b3f-22f7-46db-93e2-218dfdac60c4")]
        [global::EleWise.ELMA.Model.Attributes.Order(1)]
        [global::EleWise.ELMA.Model.Attributes.Required(true)]
        [global::EleWise.ELMA.Model.Attributes.Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
        [global::EleWise.ELMA.Model.Types.Settings.StringSettings(FieldName="Name")]
        [global::EleWise.ELMA.Model.Types.Validation.RequiredField()]
        [global::EleWise.ELMA.Model.Attributes.DisplayName(typeof(@__Resources_IEMailMessageI), "P_Name_DisplayName")]
        [global::EleWise.ELMA.Model.Attributes.View(ViewType=global::EleWise.ELMA.Model.Views.ViewType.Create, ItemType=global::EleWise.ELMA.Model.Views.ItemType.Default, Visibility=global::EleWise.ELMA.Model.Views.Visibility.Visible, ReadOnly=false)]
        [global::EleWise.ELMA.Model.Attributes.View(ViewType=global::EleWise.ELMA.Model.Views.ViewType.Edit, ItemType=global::EleWise.ELMA.Model.Views.ItemType.Default, Visibility=global::EleWise.ELMA.Model.Views.Visibility.Visible, ReadOnly=false)]
        [global::EleWise.ELMA.Model.Attributes.View(ViewType=global::EleWise.ELMA.Model.Views.ViewType.Display, ItemType=global::EleWise.ELMA.Model.Views.ItemType.Default, Visibility=global::EleWise.ELMA.Model.Views.Visibility.Visible, ReadOnly=true)]
        [global::EleWise.ELMA.Model.Attributes.View(ViewType=global::EleWise.ELMA.Model.Views.ViewType.List, ItemType=global::EleWise.ELMA.Model.Views.ItemType.Default, Visibility=global::EleWise.ELMA.Model.Views.Visibility.Visible, ReadOnly=false)]
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
        [global::EleWise.ELMA.Model.Attributes.Uid("9f11e44a-182c-494a-b92a-10e92b2c47bd")]
        [global::EleWise.ELMA.Model.Attributes.Order(2)]
        [global::EleWise.ELMA.ComponentModel.NotNull()]
        [global::EleWise.ELMA.Model.Attributes.Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
        [global::EleWise.ELMA.Model.Types.Settings.DateTimeSettings(SetCurrentDate=true, FieldName="CreationDate")]
        [global::EleWise.ELMA.Model.Attributes.DisplayName(typeof(@__Resources_IEMailMessageI), "P_CreationDate_DisplayName")]
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
        /// Тема
        /// </summary>
        [global::EleWise.ELMA.Model.Attributes.Uid("8f7d2515-666e-45d5-bb3f-4ec0d2717550")]
        [global::EleWise.ELMA.Model.Attributes.Order(3)]
        [global::EleWise.ELMA.Model.Attributes.Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
        [global::EleWise.ELMA.Model.Types.Settings.StringSettings(FieldName="Tema")]
        [global::EleWise.ELMA.Model.Attributes.DisplayName(typeof(@__Resources_IEMailMessageI), "P_Tema_DisplayName")]
        [global::EleWise.ELMA.Model.Attributes.View(ViewType=global::EleWise.ELMA.Model.Views.ViewType.Create, ItemType=global::EleWise.ELMA.Model.Views.ItemType.Default, Visibility=global::EleWise.ELMA.Model.Views.Visibility.Visible, ReadOnly=false)]
        [global::EleWise.ELMA.Model.Attributes.View(ViewType=global::EleWise.ELMA.Model.Views.ViewType.Edit, ItemType=global::EleWise.ELMA.Model.Views.ItemType.Default, Visibility=global::EleWise.ELMA.Model.Views.Visibility.Visible, ReadOnly=false)]
        [global::EleWise.ELMA.Model.Attributes.View(ViewType=global::EleWise.ELMA.Model.Views.ViewType.Display, ItemType=global::EleWise.ELMA.Model.Views.ItemType.Default, Visibility=global::EleWise.ELMA.Model.Views.Visibility.Visible, ReadOnly=true)]
        [global::EleWise.ELMA.Model.Attributes.View(ViewType=global::EleWise.ELMA.Model.Views.ViewType.List, ItemType=global::EleWise.ELMA.Model.Views.ItemType.Default, Visibility=global::EleWise.ELMA.Model.Views.Visibility.Hidden, ReadOnly=false)]
        [global::EleWise.ELMA.Model.Attributes.View(ViewType=global::EleWise.ELMA.Model.Views.ViewType.Filter, ItemType=global::EleWise.ELMA.Model.Views.ItemType.Default, Visibility=global::EleWise.ELMA.Model.Views.Visibility.Visible, ReadOnly=false)]
        [global::EleWise.ELMA.Model.Attributes.EntityProperty()]
        string Tema
        {
            get;
            set;
        }
        
        /// <summary>
        /// Сообщение
        /// </summary>
        [global::EleWise.ELMA.Model.Attributes.Uid("5e2c97a5-0750-4962-84e3-b708cc3816df")]
        [global::EleWise.ELMA.Model.Attributes.Order(4)]
        [global::EleWise.ELMA.Model.Attributes.Property("317e3d72-9c47-4b68-926d-ba77a2579bc2")]
        [global::EleWise.ELMA.Model.Types.Settings.TextSettings(FieldName="Soobschenie")]
        [global::EleWise.ELMA.Model.Attributes.DisplayName(typeof(@__Resources_IEMailMessageI), "P_Soobschenie_DisplayName")]
        [global::EleWise.ELMA.Model.Attributes.View(ViewType=global::EleWise.ELMA.Model.Views.ViewType.Create, ItemType=global::EleWise.ELMA.Model.Views.ItemType.Default, Visibility=global::EleWise.ELMA.Model.Views.Visibility.Visible, ReadOnly=false)]
        [global::EleWise.ELMA.Model.Attributes.View(ViewType=global::EleWise.ELMA.Model.Views.ViewType.Edit, ItemType=global::EleWise.ELMA.Model.Views.ItemType.Default, Visibility=global::EleWise.ELMA.Model.Views.Visibility.Visible, ReadOnly=false)]
        [global::EleWise.ELMA.Model.Attributes.View(ViewType=global::EleWise.ELMA.Model.Views.ViewType.Display, ItemType=global::EleWise.ELMA.Model.Views.ItemType.Default, Visibility=global::EleWise.ELMA.Model.Views.Visibility.Visible, ReadOnly=true)]
        [global::EleWise.ELMA.Model.Attributes.View(ViewType=global::EleWise.ELMA.Model.Views.ViewType.List, ItemType=global::EleWise.ELMA.Model.Views.ItemType.Default, Visibility=global::EleWise.ELMA.Model.Views.Visibility.Hidden, ReadOnly=false)]
        [global::EleWise.ELMA.Model.Attributes.View(ViewType=global::EleWise.ELMA.Model.Views.ViewType.Filter, ItemType=global::EleWise.ELMA.Model.Views.ItemType.Default, Visibility=global::EleWise.ELMA.Model.Views.Visibility.Visible, ReadOnly=false)]
        [global::EleWise.ELMA.Model.Attributes.EntityProperty()]
        string Soobschenie
        {
            get;
            set;
        }
        
        /// <summary>
        /// От кого
        /// </summary>
        [global::EleWise.ELMA.Model.Attributes.Uid("ace29bdd-0b0d-4f68-8844-31e89d0bf968")]
        [global::EleWise.ELMA.Model.Attributes.Order(5)]
        [global::EleWise.ELMA.Model.Attributes.Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
        [global::EleWise.ELMA.Model.Types.Settings.StringSettings(FieldName="OtKogo")]
        [global::EleWise.ELMA.Model.Attributes.DisplayName(typeof(@__Resources_IEMailMessageI), "P_OtKogo_DisplayName")]
        [global::EleWise.ELMA.Model.Attributes.View(ViewType=global::EleWise.ELMA.Model.Views.ViewType.Create, ItemType=global::EleWise.ELMA.Model.Views.ItemType.Default, Visibility=global::EleWise.ELMA.Model.Views.Visibility.Visible, ReadOnly=false)]
        [global::EleWise.ELMA.Model.Attributes.View(ViewType=global::EleWise.ELMA.Model.Views.ViewType.Edit, ItemType=global::EleWise.ELMA.Model.Views.ItemType.Default, Visibility=global::EleWise.ELMA.Model.Views.Visibility.Visible, ReadOnly=false)]
        [global::EleWise.ELMA.Model.Attributes.View(ViewType=global::EleWise.ELMA.Model.Views.ViewType.Display, ItemType=global::EleWise.ELMA.Model.Views.ItemType.Default, Visibility=global::EleWise.ELMA.Model.Views.Visibility.Visible, ReadOnly=true)]
        [global::EleWise.ELMA.Model.Attributes.View(ViewType=global::EleWise.ELMA.Model.Views.ViewType.List, ItemType=global::EleWise.ELMA.Model.Views.ItemType.Default, Visibility=global::EleWise.ELMA.Model.Views.Visibility.Hidden, ReadOnly=false)]
        [global::EleWise.ELMA.Model.Attributes.View(ViewType=global::EleWise.ELMA.Model.Views.ViewType.Filter, ItemType=global::EleWise.ELMA.Model.Views.ItemType.Default, Visibility=global::EleWise.ELMA.Model.Views.Visibility.Visible, ReadOnly=false)]
        [global::EleWise.ELMA.Model.Attributes.EntityProperty()]
        string OtKogo
        {
            get;
            set;
        }
        
        /// <summary>
        /// Дата получение письма
        /// </summary>
        [global::EleWise.ELMA.Model.Attributes.Uid("d27d3e5c-2173-4c2d-847f-259a498db8d0")]
        [global::EleWise.ELMA.Model.Attributes.Order(6)]
        [global::EleWise.ELMA.ComponentModel.NotNull()]
        [global::EleWise.ELMA.Model.Attributes.Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
        [global::EleWise.ELMA.Model.Types.Settings.DateTimeSettings(FieldName="DataPolucheniePisjma")]
        [global::EleWise.ELMA.Model.Attributes.DisplayName(typeof(@__Resources_IEMailMessageI), "P_DataPolucheniePisjma_DisplayName")]
        [global::EleWise.ELMA.Model.Attributes.View(ViewType=global::EleWise.ELMA.Model.Views.ViewType.Create, ItemType=global::EleWise.ELMA.Model.Views.ItemType.Default, Visibility=global::EleWise.ELMA.Model.Views.Visibility.Visible, ReadOnly=false)]
        [global::EleWise.ELMA.Model.Attributes.View(ViewType=global::EleWise.ELMA.Model.Views.ViewType.Edit, ItemType=global::EleWise.ELMA.Model.Views.ItemType.Default, Visibility=global::EleWise.ELMA.Model.Views.Visibility.Visible, ReadOnly=false)]
        [global::EleWise.ELMA.Model.Attributes.View(ViewType=global::EleWise.ELMA.Model.Views.ViewType.Display, ItemType=global::EleWise.ELMA.Model.Views.ItemType.Default, Visibility=global::EleWise.ELMA.Model.Views.Visibility.Visible, ReadOnly=true)]
        [global::EleWise.ELMA.Model.Attributes.View(ViewType=global::EleWise.ELMA.Model.Views.ViewType.List, ItemType=global::EleWise.ELMA.Model.Views.ItemType.Default, Visibility=global::EleWise.ELMA.Model.Views.Visibility.Hidden, ReadOnly=false)]
        [global::EleWise.ELMA.Model.Attributes.View(ViewType=global::EleWise.ELMA.Model.Views.ViewType.Filter, ItemType=global::EleWise.ELMA.Model.Views.ItemType.Default, Visibility=global::EleWise.ELMA.Model.Views.Visibility.Visible, ReadOnly=false)]
        [global::EleWise.ELMA.Model.Attributes.EntityProperty()]
        System.DateTime DataPolucheniePisjma
        {
            get;
            set;
        }
    }
    
    internal class @__Resources_IEMailMessageI
    {
        
        public static string DisplayName
        {
            get
            {
                return global::EleWise.ELMA.SR.T("EMailMessageI");
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
        
        public static string P_Tema_DisplayName
        {
            get
            {
                return global::EleWise.ELMA.SR.T("Тема");
            }
        }
        
        public static string P_Soobschenie_DisplayName
        {
            get
            {
                return global::EleWise.ELMA.SR.T("Сообщение");
            }
        }
        
        public static string P_OtKogo_DisplayName
        {
            get
            {
                return global::EleWise.ELMA.SR.T("От кого");
            }
        }
        
        public static string P_DataPolucheniePisjma_DisplayName
        {
            get
            {
                return global::EleWise.ELMA.SR.T("Дата получение письма");
            }
        }
        
        private static string @__AllFormsResources
        {
            get
            {
                return global::EleWise.ELMA.SR.T("Создание\\Редактирование");
                return global::EleWise.ELMA.SR.T("Просмотр");
            }
        }
    }
    
    /// <summary>
    /// Фильтр для объекта "EMailMessageI"
    /// </summary>
    [global::EleWise.ELMA.Model.Attributes.FilterFor(typeof(IEMailMessageI))]
    public interface IEMailMessageIFilter : global::EleWise.ELMA.Model.Common.IEntityFilter
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
    }
}
#pragma warning restore 108,114,162
