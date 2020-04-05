<?xml version="1.0" encoding="utf-8"?>
<Entity xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <Uid>6648633a-d6f5-495c-a675-38fcb6b9258f</Uid>
  <Name>EMailMessageI</Name>
  <DisplayName>EMailMessageI</DisplayName>
  <Namespace>Iprosoft.ELMA.MailReaderConf.Models</Namespace>
  <Properties>
    <PropertyMetadata xsi:type="EntityPropertyMetadata">
      <Uid>9ab435f1-883c-4c43-9789-7488c827118e</Uid>
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
      <Uid>1a2c3b3f-22f7-46db-93e2-218dfdac60c4</Uid>
      <Name>Name</Name>
      <DisplayName>Наименование</DisplayName>
      <TypeUid>9b9aac17-22bb-425c-aa93-9c02c5146965</TypeUid>
      <Settings xsi:type="StringSettings">
        <FieldName>Name</FieldName>
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
        </Attributes>
      </ViewSettings>
      <Order>1</Order>
      <InFastSearch>true</InFastSearch>
      <Filterable>true</Filterable>
    </PropertyMetadata>
    <PropertyMetadata xsi:type="EntityPropertyMetadata">
      <Uid>9f11e44a-182c-494a-b92a-10e92b2c47bd</Uid>
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
      <Uid>8f7d2515-666e-45d5-bb3f-4ec0d2717550</Uid>
      <Name>Tema</Name>
      <DisplayName>Тема</DisplayName>
      <TypeUid>9b9aac17-22bb-425c-aa93-9c02c5146965</TypeUid>
      <Settings xsi:type="StringSettings">
        <FieldName>Tema</FieldName>
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
      <Order>3</Order>
    </PropertyMetadata>
    <PropertyMetadata xsi:type="EntityPropertyMetadata">
      <Uid>5e2c97a5-0750-4962-84e3-b708cc3816df</Uid>
      <Name>Soobschenie</Name>
      <DisplayName>Сообщение</DisplayName>
      <TypeUid>317e3d72-9c47-4b68-926d-ba77a2579bc2</TypeUid>
      <Settings xsi:type="TextSettings">
        <FieldName>Soobschenie</FieldName>
        <MultiLine>true</MultiLine>
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
      <Order>4</Order>
    </PropertyMetadata>
    <PropertyMetadata xsi:type="EntityPropertyMetadata">
      <Uid>ace29bdd-0b0d-4f68-8844-31e89d0bf968</Uid>
      <Name>OtKogo</Name>
      <DisplayName>От кого</DisplayName>
      <TypeUid>9b9aac17-22bb-425c-aa93-9c02c5146965</TypeUid>
      <Settings xsi:type="StringSettings">
        <FieldName>OtKogo</FieldName>
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
      <Order>5</Order>
    </PropertyMetadata>
    <PropertyMetadata xsi:type="EntityPropertyMetadata">
      <Uid>d27d3e5c-2173-4c2d-847f-259a498db8d0</Uid>
      <Name>DataPolucheniePisjma</Name>
      <DisplayName>Дата получение письма</DisplayName>
      <TypeUid>dac9211e-e02b-47cd-8868-89a3bfc0f749</TypeUid>
      <Settings xsi:type="DateTimeSettings">
        <FieldName>DataPolucheniePisjma</FieldName>
      </Settings>
      <Nullable>false</Nullable>
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
    <CreateUid>e2ea92ca-102e-4f56-80dd-7da212efc216</CreateUid>
    <EditUid>e2ea92ca-102e-4f56-80dd-7da212efc216</EditUid>
    <DisplayUid>82fea08d-ec27-4e17-9f0d-70ac59e21e01</DisplayUid>
  </DefaultForms>
  <Forms>
    <FormViewItem>
      <Name>Form</Name>
      <Uid>e2ea92ca-102e-4f56-80dd-7da212efc216</Uid>
      <Items>
        <RootViewItem xsi:type="ColumnsLayoutViewItem">
          <Name>ColumnsLayout1</Name>
          <Uid>ce5a42a3-2371-4e45-802a-37db8b5a493e</Uid>
          <Items>
            <RootViewItem xsi:type="ColumnViewItem">
              <Name>Column1</Name>
              <Uid>2651539b-6d2b-4705-923e-eddc01954df9</Uid>
              <Items>
                <RootViewItem xsi:type="PropertyViewItem">
                  <Name>Property1</Name>
                  <Uid>e8413370-6511-45a0-89d4-abe94378b212</Uid>
                  <Property>1a2c3b3f-22f7-46db-93e2-218dfdac60c4</Property>
                  <Attributes />
                </RootViewItem>
                <RootViewItem xsi:type="PropertyViewItem">
                  <Name>Property2</Name>
                  <Uid>cb917ad1-c842-4cda-a504-88a42657ffc1</Uid>
                  <Property>9f11e44a-182c-494a-b92a-10e92b2c47bd</Property>
                  <Attributes />
                </RootViewItem>
                <RootViewItem xsi:type="PropertyViewItem">
                  <Name>Property3</Name>
                  <Uid>3d42a611-4472-4d19-9991-a5cd7d1fc883</Uid>
                  <Property>8f7d2515-666e-45d5-bb3f-4ec0d2717550</Property>
                  <Attributes />
                </RootViewItem>
                <RootViewItem xsi:type="PropertyViewItem">
                  <Name>Property4</Name>
                  <Uid>4bb51df9-7cf8-43f9-8244-b1709e311846</Uid>
                  <Property>5e2c97a5-0750-4962-84e3-b708cc3816df</Property>
                  <Attributes />
                </RootViewItem>
                <RootViewItem xsi:type="PropertyViewItem">
                  <Name>Property5</Name>
                  <Uid>7989735c-3f17-4d1d-8f07-ff11949c63d8</Uid>
                  <Property>ace29bdd-0b0d-4f68-8844-31e89d0bf968</Property>
                  <Attributes />
                </RootViewItem>
                <RootViewItem xsi:type="PropertyViewItem">
                  <Name>Property6</Name>
                  <Uid>74cb8e1c-4c5d-4a62-a197-c7d2c09574db</Uid>
                  <Property>d27d3e5c-2173-4c2d-847f-259a498db8d0</Property>
                  <Attributes />
                </RootViewItem>
              </Items>
            </RootViewItem>
          </Items>
        </RootViewItem>
      </Items>
      <DisplayName>Создание\Редактирование</DisplayName>
    </FormViewItem>
    <FormViewItem>
      <Name>Form</Name>
      <Uid>82fea08d-ec27-4e17-9f0d-70ac59e21e01</Uid>
      <Items>
        <RootViewItem xsi:type="ColumnsLayoutViewItem">
          <Name>ColumnsLayout1</Name>
          <Uid>a78a2c99-a674-495b-a901-bb720db536b3</Uid>
          <Items>
            <RootViewItem xsi:type="ColumnViewItem">
              <Name>Column1</Name>
              <Uid>b502f679-36be-47af-9d95-b42755bb553a</Uid>
              <Items>
                <RootViewItem xsi:type="PropertyViewItem">
                  <Name>Property1</Name>
                  <Uid>ff46b5b6-bf0e-4de6-ba16-ad4a1409afb7</Uid>
                  <Property>1a2c3b3f-22f7-46db-93e2-218dfdac60c4</Property>
                  <Attributes>
                    <ReadOnly>true</ReadOnly>
                  </Attributes>
                </RootViewItem>
                <RootViewItem xsi:type="PropertyViewItem">
                  <Name>Property2</Name>
                  <Uid>683a47e3-297e-49c5-85ac-4295b5a0a451</Uid>
                  <Property>9f11e44a-182c-494a-b92a-10e92b2c47bd</Property>
                  <Attributes>
                    <ReadOnly>true</ReadOnly>
                  </Attributes>
                </RootViewItem>
                <RootViewItem xsi:type="PropertyViewItem">
                  <Name>Property3</Name>
                  <Uid>ddd9cb07-9e9f-4ef4-9c97-bb840b2bd4c2</Uid>
                  <Property>8f7d2515-666e-45d5-bb3f-4ec0d2717550</Property>
                  <Attributes>
                    <ReadOnly>true</ReadOnly>
                  </Attributes>
                </RootViewItem>
                <RootViewItem xsi:type="PropertyViewItem">
                  <Name>Property4</Name>
                  <Uid>ea3acbc1-eb89-43c2-a775-915bb240a07e</Uid>
                  <Property>5e2c97a5-0750-4962-84e3-b708cc3816df</Property>
                  <Attributes>
                    <ReadOnly>true</ReadOnly>
                  </Attributes>
                </RootViewItem>
                <RootViewItem xsi:type="PropertyViewItem">
                  <Name>Property5</Name>
                  <Uid>d2a87dda-1134-4b2d-9e33-2baa52a8bb43</Uid>
                  <Property>ace29bdd-0b0d-4f68-8844-31e89d0bf968</Property>
                  <Attributes>
                    <ReadOnly>true</ReadOnly>
                  </Attributes>
                </RootViewItem>
                <RootViewItem xsi:type="PropertyViewItem">
                  <Name>Property6</Name>
                  <Uid>c3b0c007-28c2-45ee-b058-48a7b76de1f6</Uid>
                  <Property>d27d3e5c-2173-4c2d-847f-259a498db8d0</Property>
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
      <Uid>87c0a569-da23-424d-8107-24331f7b496a</Uid>
      <ViewType>List</ViewType>
    </TableView>
  </TableViews>
  <TitlePropertyUid>1a2c3b3f-22f7-46db-93e2-218dfdac60c4</TitlePropertyUid>
  <Type>Interface</Type>
  <ImplementationUid>fd5eb2d5-531c-4042-92aa-c40565928707</ImplementationUid>
  <IdTypeUid>d90a59af-7e47-48c5-8c4c-dad04834e6e3</IdTypeUid>
  <TableName>EMailMessageI</TableName>
  <IsSoftDeletable>true</IsSoftDeletable>
  <SaveHistory>true</SaveHistory>
  <ShowInCatalogList>true</ShowInCatalogList>
  <Filterable>true</Filterable>
  <Filter />
  <Actions />
</Entity>