<?xml version="1.0" encoding="utf-8"?>
<Entity xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <Uid>e3cce157-5df1-4021-9ed9-1d60ef25a92f</Uid>
  <Name>MailRequestI</Name>
  <DisplayName>E-mail запрос</DisplayName>
  <Namespace>Iprosoft.ELMA.MailReaderConf.Models</Namespace>
  <Properties>
    <PropertyMetadata xsi:type="EntityPropertyMetadata">
      <Uid>d47c3d20-33d8-4900-b73b-ec5449c3b566</Uid>
      <Name>Uid</Name>
      <DisplayName>Уникальный идентификатор</DisplayName>
      <TypeUid>eb6e8ddc-fafe-4e0e-9018-1a7667012579</TypeUid>
      <Settings xsi:type="GuidSettings">
        <FieldName>Uid</FieldName>
      </Settings>
      <Nullable>false</Nullable>
      <IsSystem>true</IsSystem>
      <ViewSettings>
        <Attributes>
          <ViewAttribute>
            <Visibility>Hidden</Visibility>
            <ReadOnly>true</ReadOnly>
          </ViewAttribute>
        </Attributes>
      </ViewSettings>
      <Order>0</Order>
    </PropertyMetadata>
    <PropertyMetadata xsi:type="EntityPropertyMetadata">
      <Uid>d8b25adc-a344-41e1-8764-52c2dfd468de</Uid>
      <Name>Name</Name>
      <DisplayName>Наименование</DisplayName>
      <TypeUid>9b9aac17-22bb-425c-aa93-9c02c5146965</TypeUid>
      <Settings xsi:type="StringSettings">
        <FieldName>Name</FieldName>
        <DefaultValue>name</DefaultValue>
      </Settings>
      <Nullable>false</Nullable>
      <Required>true</Required>
      <ViewSettings>
        <Attributes>
          <ViewAttribute>
            <ViewType>Create</ViewType>
          </ViewAttribute>
          <ViewAttribute>
            <ViewType>Edit</ViewType>
          </ViewAttribute>
          <ViewAttribute>
            <ViewType>Display</ViewType>
            <ReadOnly>true</ReadOnly>
          </ViewAttribute>
          <ViewAttribute>
            <ViewType>List</ViewType>
          </ViewAttribute>
          <ViewAttribute>
            <ViewType>Filter</ViewType>
          </ViewAttribute>
        </Attributes>
      </ViewSettings>
      <Order>1</Order>
      <InFastSearch>true</InFastSearch>
      <Filterable>true</Filterable>
    </PropertyMetadata>
    <PropertyMetadata xsi:type="EntityPropertyMetadata">
      <Uid>9cfebdbc-7433-436d-955c-28039439cd59</Uid>
      <Name>CreationDate</Name>
      <DisplayName>Дата создания</DisplayName>
      <TypeUid>dac9211e-e02b-47cd-8868-89a3bfc0f749</TypeUid>
      <Settings xsi:type="DateTimeSettings">
        <FieldName>CreationDate</FieldName>
        <SetCurrentDate>true</SetCurrentDate>
      </Settings>
      <Nullable>false</Nullable>
      <ViewSettings>
        <Attributes>
          <ViewAttribute>
            <ViewType>Create</ViewType>
            <Visibility>Hidden</Visibility>
          </ViewAttribute>
          <ViewAttribute>
            <ViewType>Edit</ViewType>
            <ReadOnly>true</ReadOnly>
          </ViewAttribute>
          <ViewAttribute>
            <ViewType>Display</ViewType>
            <ReadOnly>true</ReadOnly>
          </ViewAttribute>
          <ViewAttribute>
            <ViewType>List</ViewType>
            <Visibility>Hidden</Visibility>
          </ViewAttribute>
        </Attributes>
      </ViewSettings>
      <Order>2</Order>
      <Handlers>
        <PropertyHandlerInfo>
          <HandlerUid>d0c00d8a-e003-427d-9942-f52cfb77b0f0</HandlerUid>
        </PropertyHandlerInfo>
      </Handlers>
      <Filterable>true</Filterable>
    </PropertyMetadata>
    <PropertyMetadata xsi:type="EntityPropertyMetadata">
      <Uid>452b64cc-16b6-4c03-aefa-e8a3fe28b173</Uid>
      <Name>CreationAuthor</Name>
      <DisplayName>Автор создания</DisplayName>
      <TypeUid>72ed98ca-f260-4671-9bcd-ff1d80235f47</TypeUid>
      <SubTypeUid>cfdeb03c-35e9-45e7-aad8-037d83888f73</SubTypeUid>
      <Settings xsi:type="EntityUserSettings">
        <FieldName>CreationAuthor</FieldName>
      </Settings>
      <Nullable>true</Nullable>
      <ViewSettings>
        <Attributes>
          <ViewAttribute>
            <ViewType>Create</ViewType>
            <Visibility>Hidden</Visibility>
          </ViewAttribute>
          <ViewAttribute>
            <ViewType>Edit</ViewType>
            <ReadOnly>true</ReadOnly>
          </ViewAttribute>
          <ViewAttribute>
            <ViewType>Display</ViewType>
            <ReadOnly>true</ReadOnly>
          </ViewAttribute>
          <ViewAttribute>
            <ViewType>List</ViewType>
            <Visibility>Hidden</Visibility>
          </ViewAttribute>
        </Attributes>
      </ViewSettings>
      <Order>3</Order>
      <Handlers>
        <PropertyHandlerInfo>
          <HandlerUid>b05ac6bd-eb8b-474a-a796-b53831a9967e</HandlerUid>
        </PropertyHandlerInfo>
      </Handlers>
      <Filterable>true</Filterable>
    </PropertyMetadata>
    <PropertyMetadata xsi:type="EntityPropertyMetadata">
      <Uid>46225b35-9e82-4914-97ff-0d12964f597d</Uid>
      <Name>ChangeDate</Name>
      <DisplayName>Дата изменения</DisplayName>
      <TypeUid>dac9211e-e02b-47cd-8868-89a3bfc0f749</TypeUid>
      <Settings xsi:type="DateTimeSettings">
        <FieldName>ChangeDate</FieldName>
      </Settings>
      <Nullable>true</Nullable>
      <ViewSettings>
        <Attributes>
          <ViewAttribute>
            <ViewType>Create</ViewType>
            <Visibility>Hidden</Visibility>
          </ViewAttribute>
          <ViewAttribute>
            <ViewType>Edit</ViewType>
            <ReadOnly>true</ReadOnly>
          </ViewAttribute>
          <ViewAttribute>
            <ViewType>Display</ViewType>
            <ReadOnly>true</ReadOnly>
          </ViewAttribute>
          <ViewAttribute>
            <ViewType>List</ViewType>
            <Visibility>Hidden</Visibility>
          </ViewAttribute>
        </Attributes>
      </ViewSettings>
      <Order>4</Order>
      <Handlers>
        <PropertyHandlerInfo>
          <HandlerUid>12a6c5c4-12f8-4b2e-b7ea-5438974a2d25</HandlerUid>
        </PropertyHandlerInfo>
      </Handlers>
      <Filterable>true</Filterable>
    </PropertyMetadata>
    <PropertyMetadata xsi:type="EntityPropertyMetadata">
      <Uid>2132b9e8-3f9a-4ef0-a961-03c98c24dfa4</Uid>
      <Name>ChangeAuthor</Name>
      <DisplayName>Автор изменения</DisplayName>
      <TypeUid>72ed98ca-f260-4671-9bcd-ff1d80235f47</TypeUid>
      <SubTypeUid>cfdeb03c-35e9-45e7-aad8-037d83888f73</SubTypeUid>
      <Settings xsi:type="EntityUserSettings">
        <FieldName>ChangeAuthor</FieldName>
      </Settings>
      <Nullable>true</Nullable>
      <ViewSettings>
        <Attributes>
          <ViewAttribute>
            <ViewType>Create</ViewType>
            <Visibility>Hidden</Visibility>
          </ViewAttribute>
          <ViewAttribute>
            <ViewType>Edit</ViewType>
            <ReadOnly>true</ReadOnly>
          </ViewAttribute>
          <ViewAttribute>
            <ViewType>Display</ViewType>
            <ReadOnly>true</ReadOnly>
          </ViewAttribute>
          <ViewAttribute>
            <ViewType>List</ViewType>
            <Visibility>Hidden</Visibility>
          </ViewAttribute>
        </Attributes>
      </ViewSettings>
      <Order>5</Order>
      <Handlers>
        <PropertyHandlerInfo>
          <HandlerUid>d152e660-1ee9-4b5f-a614-df280e5b3f98</HandlerUid>
        </PropertyHandlerInfo>
      </Handlers>
      <Filterable>true</Filterable>
    </PropertyMetadata>
    <PropertyMetadata xsi:type="EntityPropertyMetadata">
      <Uid>f19d4133-ce78-47e5-81b4-cd45553a8184</Uid>
      <Name>Pisjma</Name>
      <DisplayName>Письма</DisplayName>
      <TypeUid>72ed98ca-f260-4671-9bcd-ff1d80235f47</TypeUid>
      <SubTypeUid>6648633a-d6f5-495c-a675-38fcb6b9258f</SubTypeUid>
      <Settings xsi:type="EntitySettings">
        <RelationType>ManyToMany</RelationType>
        <RelationTableName>M_MailRequestI_Pisjma</RelationTableName>
        <ParentColumnName>Parent</ParentColumnName>
        <ChildColumnName>Child</ChildColumnName>
        <CascadeMode>SaveUpdate</CascadeMode>
      </Settings>
      <Nullable>true</Nullable>
      <ViewSettings>
        <Attributes>
          <ViewAttribute>
            <ViewType>Create</ViewType>
          </ViewAttribute>
          <ViewAttribute>
            <ViewType>Edit</ViewType>
          </ViewAttribute>
          <ViewAttribute>
            <ViewType>Display</ViewType>
            <ReadOnly>true</ReadOnly>
          </ViewAttribute>
          <ViewAttribute>
            <ViewType>List</ViewType>
            <Visibility>Hidden</Visibility>
          </ViewAttribute>
          <ViewAttribute>
            <ViewType>Filter</ViewType>
          </ViewAttribute>
        </Attributes>
      </ViewSettings>
      <Order>6</Order>
    </PropertyMetadata>
  </Properties>
  <FormsScheme>FormConstructor</FormsScheme>
  <DefaultForms>
    <CreateUid>31692e31-47ff-47e3-af60-336de03d092a</CreateUid>
    <EditUid>31692e31-47ff-47e3-af60-336de03d092a</EditUid>
    <DisplayUid>f03f355f-26fe-49b8-b1e8-cf5746f5512a</DisplayUid>
  </DefaultForms>
  <Forms>
    <FormViewItem>
      <Name>Form</Name>
      <Uid>31692e31-47ff-47e3-af60-336de03d092a</Uid>
      <Items>
        <RootViewItem xsi:type="ColumnsLayoutViewItem">
          <Name>ColumnsLayout1</Name>
          <Uid>61e01ea4-c21a-4990-a5c1-1178eef77c03</Uid>
          <Items>
            <RootViewItem xsi:type="ColumnViewItem">
              <Name>Column1</Name>
              <Uid>ccde8ca1-edf2-47a2-918c-d2b56ea643f2</Uid>
              <Items>
                <RootViewItem xsi:type="PropertyViewItem">
                  <Name>Property1</Name>
                  <Uid>a1602530-5a85-449a-9e46-46bc952d23db</Uid>
                  <Property>d8b25adc-a344-41e1-8764-52c2dfd468de</Property>
                  <Attributes />
                </RootViewItem>
                <RootViewItem xsi:type="PropertyViewItem">
                  <Name>Property2</Name>
                  <Uid>4412de7f-c7a8-4be5-83cd-ebc0b56fbcdc</Uid>
                  <Property>9cfebdbc-7433-436d-955c-28039439cd59</Property>
                  <Attributes />
                </RootViewItem>
                <RootViewItem xsi:type="PropertyViewItem">
                  <Name>Property3</Name>
                  <Uid>5c6e26c3-947a-4fe1-ab81-e2b987d334e3</Uid>
                  <Property>452b64cc-16b6-4c03-aefa-e8a3fe28b173</Property>
                  <Attributes />
                  <TypeSettings>
                    <item key="HideCreator">
                      <anyType xsi:type="xsd:boolean">true</anyType>
                    </item>
                  </TypeSettings>
                </RootViewItem>
                <RootViewItem xsi:type="PropertyViewItem">
                  <Name>Property6</Name>
                  <Uid>82818460-2408-445d-8f58-6bf891c9577d</Uid>
                  <Property>f19d4133-ce78-47e5-81b4-cd45553a8184</Property>
                  <Attributes />
                  <TypeSettings>
                    <item key="HideCreator">
                      <anyType xsi:type="xsd:boolean">true</anyType>
                    </item>
                  </TypeSettings>
                </RootViewItem>
              </Items>
            </RootViewItem>
          </Items>
        </RootViewItem>
      </Items>
      <DisplayName>Создание</DisplayName>
    </FormViewItem>
    <FormViewItem>
      <Name>Form</Name>
      <Uid>f03f355f-26fe-49b8-b1e8-cf5746f5512a</Uid>
      <Items>
        <RootViewItem xsi:type="ColumnsLayoutViewItem">
          <Name>ColumnsLayout1</Name>
          <Uid>26d0ab1a-3354-4890-9be0-196ed09e9654</Uid>
          <Items>
            <RootViewItem xsi:type="ColumnViewItem">
              <Name>Column1</Name>
              <Uid>c0fd53c9-f9d1-442d-92a8-bdee49904b2d</Uid>
              <Items>
                <RootViewItem xsi:type="PropertyViewItem">
                  <Name>Property1</Name>
                  <Uid>03a201dc-6f64-4913-8cf4-46ddbecd8016</Uid>
                  <Property>d8b25adc-a344-41e1-8764-52c2dfd468de</Property>
                  <Attributes>
                    <ReadOnly>true</ReadOnly>
                  </Attributes>
                </RootViewItem>
                <RootViewItem xsi:type="PropertyViewItem">
                  <Name>Property2</Name>
                  <Uid>68394966-1a62-4789-a1a7-f818c433c635</Uid>
                  <Property>9cfebdbc-7433-436d-955c-28039439cd59</Property>
                  <Attributes>
                    <ReadOnly>true</ReadOnly>
                  </Attributes>
                </RootViewItem>
                <RootViewItem xsi:type="PropertyViewItem">
                  <Name>Property3</Name>
                  <Uid>5851eac4-5a71-4bb4-9be0-81765fba6ea8</Uid>
                  <Property>452b64cc-16b6-4c03-aefa-e8a3fe28b173</Property>
                  <Attributes>
                    <ReadOnly>true</ReadOnly>
                  </Attributes>
                </RootViewItem>
                <RootViewItem xsi:type="PropertyViewItem">
                  <Name>Property4</Name>
                  <Uid>8bb42a46-6084-471f-af4e-b8c125add310</Uid>
                  <Property>46225b35-9e82-4914-97ff-0d12964f597d</Property>
                  <Attributes>
                    <ReadOnly>true</ReadOnly>
                  </Attributes>
                </RootViewItem>
                <RootViewItem xsi:type="PropertyViewItem">
                  <Name>Property5</Name>
                  <Uid>496a763f-941b-4abf-b2ec-d7701037e24d</Uid>
                  <Property>2132b9e8-3f9a-4ef0-a961-03c98c24dfa4</Property>
                  <Attributes>
                    <ReadOnly>true</ReadOnly>
                  </Attributes>
                </RootViewItem>
                <RootViewItem xsi:type="PropertyViewItem">
                  <Name>Property6</Name>
                  <Uid>f1f86ec5-69d3-4459-9d3f-c7609d6f75c6</Uid>
                  <Property>f19d4133-ce78-47e5-81b4-cd45553a8184</Property>
                  <Attributes>
                    <ReadOnly>true</ReadOnly>
                  </Attributes>
                </RootViewItem>
              </Items>
            </RootViewItem>
          </Items>
        </RootViewItem>
      </Items>
      <DisplayName>Просмотр</DisplayName>
    </FormViewItem>
  </Forms>
  <FormViews>
    <FormView>
      <ViewType>Display</ViewType>
      <CanUseCommonView>true</CanUseCommonView>
      <CanUseCommonRazorView>true</CanUseCommonRazorView>
      <CanUseTabView>true</CanUseTabView>
      <CanUseTabRazorView>true</CanUseTabRazorView>
      <ViewInCommon>true</ViewInCommon>
    </FormView>
    <FormView>
      <ViewType>Create</ViewType>
      <CanUseCommonView>true</CanUseCommonView>
      <CanUseCommonRazorView>true</CanUseCommonRazorView>
      <CanUseTabView>true</CanUseTabView>
      <CanUseTabRazorView>true</CanUseTabRazorView>
      <ViewInCommon>true</ViewInCommon>
    </FormView>
    <FormView>
      <ViewType>Edit</ViewType>
      <CanUseCommonView>true</CanUseCommonView>
      <CanUseCommonRazorView>true</CanUseCommonRazorView>
      <CanUseTabView>true</CanUseTabView>
      <CanUseTabRazorView>true</CanUseTabRazorView>
      <ViewInCommon>true</ViewInCommon>
    </FormView>
  </FormViews>
  <TableViews>
    <TableView>
      <Uid>89787f32-7c42-4f27-8426-76b082e6add4</Uid>
      <ViewType>List</ViewType>
    </TableView>
  </TableViews>
  <TitlePropertyUid>d8b25adc-a344-41e1-8764-52c2dfd468de</TitlePropertyUid>
  <Type>Interface</Type>
  <ImplementationUid>f1286452-cfe8-49a1-a4a2-f48232234142</ImplementationUid>
  <IdTypeUid>d90a59af-7e47-48c5-8c4c-dad04834e6e3</IdTypeUid>
  <TableName>MailRequestI</TableName>
  <IsSoftDeletable>true</IsSoftDeletable>
  <SaveHistory>true</SaveHistory>
  <ShowInCatalogList>true</ShowInCatalogList>
  <Filterable>true</Filterable>
  <Filter />
  <Actions />
</Entity>