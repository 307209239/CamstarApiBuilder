// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Generator.ObjectModel.ModelDataSet
// Assembly: Camstar.WCFGenerator, Version=7.8.7004.31022, Culture=neutral, PublicKeyToken=null
// MVID: 91343708-C770-4337-A57D-62D505E9E44B
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFGenerator.dll

using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Camstar.WCF.Generator.ObjectModel
{
  [DesignerCategory("code")]
  [ToolboxItem(true)]
  [XmlSchemaProvider("GetTypedDataSetSchema")]
  [XmlRoot("ModelDataSet")]
  [HelpKeyword("vs.data.DataSet")]
  [Serializable]
  public class ModelDataSet : DataSet
  {
    private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    private ModelDataSet.CDOChildrenDataTable tableCDOChildren;
    private ModelDataSet.CDOMethodsDataTable tableCDOMethods;
    private ModelDataSet.CDOFieldsDataTable tableCDOFields;
    private ModelDataSet.WCFWorkspacesDataTable tableWCFWorkspaces;
    private ModelDataSet.UserDataTable tableUser;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public ModelDataSet()
    {
      this.BeginInit();
      this.InitClass();
      CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
      base.Tables.CollectionChanged += changeEventHandler;
      base.Relations.CollectionChanged += changeEventHandler;
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected ModelDataSet(SerializationInfo info, StreamingContext context)
      : base(info, context, false)
    {
      if (this.IsBinarySerialized(info, context))
      {
        this.InitVars(false);
        CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
        this.Tables.CollectionChanged += changeEventHandler;
        this.Relations.CollectionChanged += changeEventHandler;
      }
      else
      {
        string s = (string) info.GetValue("XmlSchema", typeof (string));
        if (this.DetermineSchemaSerializationMode(info, context) == SchemaSerializationMode.IncludeSchema)
        {
          DataSet dataSet = new DataSet();
          dataSet.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
          if (dataSet.Tables[nameof (CDOChildren)] != null)
            base.Tables.Add((DataTable) new ModelDataSet.CDOChildrenDataTable(dataSet.Tables[nameof (CDOChildren)]));
          if (dataSet.Tables[nameof (CDOMethods)] != null)
            base.Tables.Add((DataTable) new ModelDataSet.CDOMethodsDataTable(dataSet.Tables[nameof (CDOMethods)]));
          if (dataSet.Tables[nameof (CDOFields)] != null)
            base.Tables.Add((DataTable) new ModelDataSet.CDOFieldsDataTable(dataSet.Tables[nameof (CDOFields)]));
          if (dataSet.Tables[nameof (WCFWorkspaces)] != null)
            base.Tables.Add((DataTable) new ModelDataSet.WCFWorkspacesDataTable(dataSet.Tables[nameof (WCFWorkspaces)]));
          if (dataSet.Tables[nameof (User)] != null)
            base.Tables.Add((DataTable) new ModelDataSet.UserDataTable(dataSet.Tables[nameof (User)]));
          this.DataSetName = dataSet.DataSetName;
          this.Prefix = dataSet.Prefix;
          this.Namespace = dataSet.Namespace;
          this.Locale = dataSet.Locale;
          this.CaseSensitive = dataSet.CaseSensitive;
          this.EnforceConstraints = dataSet.EnforceConstraints;
          this.Merge(dataSet, false, MissingSchemaAction.Add);
          this.InitVars();
        }
        else
          this.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
        this.GetSerializationData(info, context);
        CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
        base.Tables.CollectionChanged += changeEventHandler;
        this.Relations.CollectionChanged += changeEventHandler;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public ModelDataSet.CDOChildrenDataTable CDOChildren
    {
      get
      {
        return this.tableCDOChildren;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public ModelDataSet.CDOMethodsDataTable CDOMethods
    {
      get
      {
        return this.tableCDOMethods;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public ModelDataSet.CDOFieldsDataTable CDOFields
    {
      get
      {
        return this.tableCDOFields;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public ModelDataSet.WCFWorkspacesDataTable WCFWorkspaces
    {
      get
      {
        return this.tableWCFWorkspaces;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public ModelDataSet.UserDataTable User
    {
      get
      {
        return this.tableUser;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(true)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public override SchemaSerializationMode SchemaSerializationMode
    {
      get
      {
        return this._schemaSerializationMode;
      }
      set
      {
        this._schemaSerializationMode = value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public new DataTableCollection Tables
    {
      get
      {
        return base.Tables;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public new DataRelationCollection Relations
    {
      get
      {
        return base.Relations;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void InitializeDerivedDataSet()
    {
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataSet Clone()
    {
      ModelDataSet modelDataSet = (ModelDataSet) base.Clone();
      modelDataSet.InitVars();
      modelDataSet.SchemaSerializationMode = this.SchemaSerializationMode;
      return (DataSet) modelDataSet;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override bool ShouldSerializeTables()
    {
      return false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override bool ShouldSerializeRelations()
    {
      return false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void ReadXmlSerializable(XmlReader reader)
    {
      if (this.DetermineSchemaSerializationMode(reader) == SchemaSerializationMode.IncludeSchema)
      {
        this.Reset();
        DataSet dataSet = new DataSet();
        int num = (int) dataSet.ReadXml(reader);
        if (dataSet.Tables["CDOChildren"] != null)
          base.Tables.Add((DataTable) new ModelDataSet.CDOChildrenDataTable(dataSet.Tables["CDOChildren"]));
        if (dataSet.Tables["CDOMethods"] != null)
          base.Tables.Add((DataTable) new ModelDataSet.CDOMethodsDataTable(dataSet.Tables["CDOMethods"]));
        if (dataSet.Tables["CDOFields"] != null)
          base.Tables.Add((DataTable) new ModelDataSet.CDOFieldsDataTable(dataSet.Tables["CDOFields"]));
        if (dataSet.Tables["WCFWorkspaces"] != null)
          base.Tables.Add((DataTable) new ModelDataSet.WCFWorkspacesDataTable(dataSet.Tables["WCFWorkspaces"]));
        if (dataSet.Tables["User"] != null)
          base.Tables.Add((DataTable) new ModelDataSet.UserDataTable(dataSet.Tables["User"]));
        this.DataSetName = dataSet.DataSetName;
        this.Prefix = dataSet.Prefix;
        this.Namespace = dataSet.Namespace;
        this.Locale = dataSet.Locale;
        this.CaseSensitive = dataSet.CaseSensitive;
        this.EnforceConstraints = dataSet.EnforceConstraints;
        this.Merge(dataSet, false, MissingSchemaAction.Add);
        this.InitVars();
      }
      else
      {
        int num = (int) this.ReadXml(reader);
        this.InitVars();
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override XmlSchema GetSchemaSerializable()
    {
      MemoryStream memoryStream = new MemoryStream();
      this.WriteXmlSchema((XmlWriter) new XmlTextWriter((Stream) memoryStream, (Encoding) null));
      memoryStream.Position = 0L;
      return XmlSchema.Read((XmlReader) new XmlTextReader((Stream) memoryStream), (ValidationEventHandler) null);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.InitVars(true);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars(bool initTable)
    {
      this.tableCDOChildren = (ModelDataSet.CDOChildrenDataTable) base.Tables["CDOChildren"];
      if (initTable && this.tableCDOChildren != null)
        this.tableCDOChildren.InitVars();
      this.tableCDOMethods = (ModelDataSet.CDOMethodsDataTable) base.Tables["CDOMethods"];
      if (initTable && this.tableCDOMethods != null)
        this.tableCDOMethods.InitVars();
      this.tableCDOFields = (ModelDataSet.CDOFieldsDataTable) base.Tables["CDOFields"];
      if (initTable && this.tableCDOFields != null)
        this.tableCDOFields.InitVars();
      this.tableWCFWorkspaces = (ModelDataSet.WCFWorkspacesDataTable) base.Tables["WCFWorkspaces"];
      if (initTable && this.tableWCFWorkspaces != null)
        this.tableWCFWorkspaces.InitVars();
      this.tableUser = (ModelDataSet.UserDataTable) base.Tables["User"];
      if (!initTable || this.tableUser == null)
        return;
      this.tableUser.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.DataSetName = nameof (ModelDataSet);
      this.Prefix = "Camstar.WCF.ObjectModel";
      this.Namespace = "http://www.camstar.com/WCF/ModelDataSet.xsd";
      this.EnforceConstraints = true;
      this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.tableCDOChildren = new ModelDataSet.CDOChildrenDataTable();
      base.Tables.Add((DataTable) this.tableCDOChildren);
      this.tableCDOMethods = new ModelDataSet.CDOMethodsDataTable();
      base.Tables.Add((DataTable) this.tableCDOMethods);
      this.tableCDOFields = new ModelDataSet.CDOFieldsDataTable();
      base.Tables.Add((DataTable) this.tableCDOFields);
      this.tableWCFWorkspaces = new ModelDataSet.WCFWorkspacesDataTable();
      base.Tables.Add((DataTable) this.tableWCFWorkspaces);
      this.tableUser = new ModelDataSet.UserDataTable();
      base.Tables.Add((DataTable) this.tableUser);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private bool ShouldSerializeCDOChildren()
    {
      return false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private bool ShouldSerializeCDOMethods()
    {
      return false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private bool ShouldSerializeCDOFields()
    {
      return false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private bool ShouldSerializeWCFWorkspaces()
    {
      return false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private bool ShouldSerializeUser()
    {
      return false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void SchemaChanged(object sender, CollectionChangeEventArgs e)
    {
      if (e.Action != CollectionChangeAction.Remove)
        return;
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
    {
      ModelDataSet modelDataSet = new ModelDataSet();
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      xmlSchemaSequence.Items.Add((XmlSchemaObject) new XmlSchemaAny()
      {
        Namespace = modelDataSet.Namespace
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = modelDataSet.GetSchemaSerializable();
      if (xs.Contains(schemaSerializable.TargetNamespace))
      {
        MemoryStream memoryStream1 = new MemoryStream();
        MemoryStream memoryStream2 = new MemoryStream();
        try
        {
          schemaSerializable.Write((Stream) memoryStream1);
          IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
          while (enumerator.MoveNext())
          {
            XmlSchema current = (XmlSchema) enumerator.Current;
            memoryStream2.SetLength(0L);
            MemoryStream memoryStream3 = memoryStream2;
            current.Write((Stream) memoryStream3);
            if (memoryStream1.Length == memoryStream2.Length)
            {
              memoryStream1.Position = 0L;
              memoryStream2.Position = 0L;
              do
                ;
              while (memoryStream1.Position != memoryStream1.Length && memoryStream1.ReadByte() == memoryStream2.ReadByte());
              if (memoryStream1.Position == memoryStream1.Length)
                return schemaComplexType;
            }
          }
        }
        finally
        {
          memoryStream1?.Close();
          memoryStream2?.Close();
        }
      }
      xs.Add(schemaSerializable);
      return schemaComplexType;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public delegate void CDOChildrenRowChangeEventHandler(
      object sender,
      ModelDataSet.CDOChildrenRowChangeEvent e);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public delegate void CDOMethodsRowChangeEventHandler(
      object sender,
      ModelDataSet.CDOMethodsRowChangeEvent e);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public delegate void CDOFieldsRowChangeEventHandler(
      object sender,
      ModelDataSet.CDOFieldsRowChangeEvent e);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public delegate void WCFWorkspacesRowChangeEventHandler(
      object sender,
      ModelDataSet.WCFWorkspacesRowChangeEvent e);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public delegate void UserRowChangeEventHandler(object sender, ModelDataSet.UserRowChangeEvent e);

    [XmlSchemaProvider("GetTypedTableSchema")]
    [Serializable]
    public class CDOChildrenDataTable : TypedTableBase<ModelDataSet.CDOChildrenRow>
    {
      private DataColumn columnDescription;
      private DataColumn columnName;
      private DataColumn columnParentID;
      private DataColumn _columnWCFCDO_ID;
      private DataColumn columnMask;
      private DataColumn columnMethodName;
      private DataColumn columnParameterName;
      private DataColumn columnParmeterDescription;
      private DataColumn columnMethodDescription;
      private DataColumn _columnWCFCDOMethods_ID;
      private DataColumn columnCount;
      private DataColumn _columnWCFCDOChildrenCount_ID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public CDOChildrenDataTable()
      {
        this.TableName = "CDOChildren";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      internal CDOChildrenDataTable(DataTable table)
      {
        this.TableName = table.TableName;
        if (table.CaseSensitive != table.DataSet.CaseSensitive)
          this.CaseSensitive = table.CaseSensitive;
        if (table.Locale.ToString() != table.DataSet.Locale.ToString())
          this.Locale = table.Locale;
        if (table.Namespace != table.DataSet.Namespace)
          this.Namespace = table.Namespace;
        this.Prefix = table.Prefix;
        this.MinimumCapacity = table.MinimumCapacity;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected CDOChildrenDataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn DescriptionColumn
      {
        get
        {
          return this.columnDescription;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn NameColumn
      {
        get
        {
          return this.columnName;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn ParentIDColumn
      {
        get
        {
          return this.columnParentID;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn _WCFCDO_IDColumn
      {
        get
        {
          return this._columnWCFCDO_ID;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn MaskColumn
      {
        get
        {
          return this.columnMask;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn MethodNameColumn
      {
        get
        {
          return this.columnMethodName;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn ParameterNameColumn
      {
        get
        {
          return this.columnParameterName;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn ParmeterDescriptionColumn
      {
        get
        {
          return this.columnParmeterDescription;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn MethodDescriptionColumn
      {
        get
        {
          return this.columnMethodDescription;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn _WCFCDOMethods_IDColumn
      {
        get
        {
          return this._columnWCFCDOMethods_ID;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn CountColumn
      {
        get
        {
          return this.columnCount;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn _WCFCDOChildrenCount_IDColumn
      {
        get
        {
          return this._columnWCFCDOChildrenCount_ID;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [Browsable(false)]
      public int Count
      {
        get
        {
          return this.Rows.Count;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public ModelDataSet.CDOChildrenRow this[int index]
      {
        get
        {
          return (ModelDataSet.CDOChildrenRow) this.Rows[index];
        }
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public event ModelDataSet.CDOChildrenRowChangeEventHandler CDOChildrenRowChanging;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public event ModelDataSet.CDOChildrenRowChangeEventHandler CDOChildrenRowChanged;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public event ModelDataSet.CDOChildrenRowChangeEventHandler CDOChildrenRowDeleting;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public event ModelDataSet.CDOChildrenRowChangeEventHandler CDOChildrenRowDeleted;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void AddCDOChildrenRow(ModelDataSet.CDOChildrenRow row)
      {
        this.Rows.Add((DataRow) row);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public ModelDataSet.CDOChildrenRow AddCDOChildrenRow(
        string Description,
        string Name,
        int ParentID,
        int _WCFCDO_ID,
        int Mask,
        string MethodName,
        string ParameterName,
        string ParmeterDescription,
        string MethodDescription,
        int _WCFCDOMethods_ID,
        int Count,
        int _WCFCDOChildrenCount_ID)
      {
        ModelDataSet.CDOChildrenRow cdoChildrenRow = (ModelDataSet.CDOChildrenRow) this.NewRow();
        object[] objArray = new object[12]
        {
          (object) Description,
          (object) Name,
          (object) ParentID,
          (object) _WCFCDO_ID,
          (object) Mask,
          (object) MethodName,
          (object) ParameterName,
          (object) ParmeterDescription,
          (object) MethodDescription,
          (object) _WCFCDOMethods_ID,
          (object) Count,
          (object) _WCFCDOChildrenCount_ID
        };
        cdoChildrenRow.ItemArray = objArray;
        this.Rows.Add((DataRow) cdoChildrenRow);
        return cdoChildrenRow;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public override DataTable Clone()
      {
        ModelDataSet.CDOChildrenDataTable childrenDataTable = (ModelDataSet.CDOChildrenDataTable) base.Clone();
        childrenDataTable.InitVars();
        return (DataTable) childrenDataTable;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override DataTable CreateInstance()
      {
        return (DataTable) new ModelDataSet.CDOChildrenDataTable();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      internal void InitVars()
      {
        this.columnDescription = this.Columns["Description"];
        this.columnName = this.Columns["Name"];
        this.columnParentID = this.Columns["ParentID"];
        this._columnWCFCDO_ID = this.Columns["WCFCDO.ID"];
        this.columnMask = this.Columns["Mask"];
        this.columnMethodName = this.Columns["MethodName"];
        this.columnParameterName = this.Columns["ParameterName"];
        this.columnParmeterDescription = this.Columns["ParmeterDescription"];
        this.columnMethodDescription = this.Columns["MethodDescription"];
        this._columnWCFCDOMethods_ID = this.Columns["WCFCDOMethods.ID"];
        this.columnCount = this.Columns["Count"];
        this._columnWCFCDOChildrenCount_ID = this.Columns["WCFCDOChildrenCount.ID"];
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      private void InitClass()
      {
        this.columnDescription = new DataColumn("Description", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnDescription);
        this.columnName = new DataColumn("Name", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnName);
        this.columnParentID = new DataColumn("ParentID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnParentID);
        this._columnWCFCDO_ID = new DataColumn("WCFCDO.ID", typeof (int), (string) null, MappingType.Element);
        this._columnWCFCDO_ID.ExtendedProperties.Add((object) "Generator_ColumnVarNameInTable", (object) "_columnWCFCDO_ID");
        this._columnWCFCDO_ID.ExtendedProperties.Add((object) "Generator_UserColumnName", (object) "WCFCDO.ID");
        this.Columns.Add(this._columnWCFCDO_ID);
        this.columnMask = new DataColumn("Mask", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnMask);
        this.columnMethodName = new DataColumn("MethodName", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnMethodName);
        this.columnParameterName = new DataColumn("ParameterName", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnParameterName);
        this.columnParmeterDescription = new DataColumn("ParmeterDescription", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnParmeterDescription);
        this.columnMethodDescription = new DataColumn("MethodDescription", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnMethodDescription);
        this._columnWCFCDOMethods_ID = new DataColumn("WCFCDOMethods.ID", typeof (int), (string) null, MappingType.Element);
        this._columnWCFCDOMethods_ID.ExtendedProperties.Add((object) "Generator_ColumnVarNameInTable", (object) "_columnWCFCDOMethods_ID");
        this._columnWCFCDOMethods_ID.ExtendedProperties.Add((object) "Generator_UserColumnName", (object) "WCFCDOMethods.ID");
        this.Columns.Add(this._columnWCFCDOMethods_ID);
        this.columnCount = new DataColumn("Count", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCount);
        this._columnWCFCDOChildrenCount_ID = new DataColumn("WCFCDOChildrenCount.ID", typeof (int), (string) null, MappingType.Element);
        this._columnWCFCDOChildrenCount_ID.ExtendedProperties.Add((object) "Generator_ColumnVarNameInTable", (object) "_columnWCFCDOChildrenCount_ID");
        this._columnWCFCDOChildrenCount_ID.ExtendedProperties.Add((object) "Generator_UserColumnName", (object) "WCFCDOChildrenCount.ID");
        this.Columns.Add(this._columnWCFCDOChildrenCount_ID);
        this.columnDescription.MaxLength = 536870910;
        this.columnName.MaxLength = 37;
        this.columnMethodName.MaxLength = 50;
        this.columnParameterName.MaxLength = (int) byte.MaxValue;
        this.columnParmeterDescription.MaxLength = 250;
        this.columnMethodDescription.MaxLength = 536870910;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public ModelDataSet.CDOChildrenRow NewCDOChildrenRow()
      {
        return (ModelDataSet.CDOChildrenRow) this.NewRow();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
      {
        return (DataRow) new ModelDataSet.CDOChildrenRow(builder);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override Type GetRowType()
      {
        return typeof (ModelDataSet.CDOChildrenRow);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.CDOChildrenRowChanged == null)
          return;
        this.CDOChildrenRowChanged((object) this, new ModelDataSet.CDOChildrenRowChangeEvent((ModelDataSet.CDOChildrenRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.CDOChildrenRowChanging == null)
          return;
        this.CDOChildrenRowChanging((object) this, new ModelDataSet.CDOChildrenRowChangeEvent((ModelDataSet.CDOChildrenRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.CDOChildrenRowDeleted == null)
          return;
        this.CDOChildrenRowDeleted((object) this, new ModelDataSet.CDOChildrenRowChangeEvent((ModelDataSet.CDOChildrenRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.CDOChildrenRowDeleting == null)
          return;
        this.CDOChildrenRowDeleting((object) this, new ModelDataSet.CDOChildrenRowChangeEvent((ModelDataSet.CDOChildrenRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void RemoveCDOChildrenRow(ModelDataSet.CDOChildrenRow row)
      {
        this.Rows.Remove((DataRow) row);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        ModelDataSet modelDataSet = new ModelDataSet();
        XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny();
        xmlSchemaAny1.Namespace = "http://www.w3.org/2001/XMLSchema";
        xmlSchemaAny1.MinOccurs = new Decimal(0);
        xmlSchemaAny1.MaxOccurs = new Decimal(-1, -1, -1, false, (byte) 0);
        xmlSchemaAny1.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny1);
        XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
        xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
        xmlSchemaAny2.MinOccurs = new Decimal(1);
        xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny2);
        schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "namespace",
          FixedValue = modelDataSet.Namespace
        });
        schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (CDOChildrenDataTable)
        });
        schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = modelDataSet.GetSchemaSerializable();
        if (xs.Contains(schemaSerializable.TargetNamespace))
        {
          MemoryStream memoryStream1 = new MemoryStream();
          MemoryStream memoryStream2 = new MemoryStream();
          try
          {
            schemaSerializable.Write((Stream) memoryStream1);
            IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
            while (enumerator.MoveNext())
            {
              XmlSchema current = (XmlSchema) enumerator.Current;
              memoryStream2.SetLength(0L);
              MemoryStream memoryStream3 = memoryStream2;
              current.Write((Stream) memoryStream3);
              if (memoryStream1.Length == memoryStream2.Length)
              {
                memoryStream1.Position = 0L;
                memoryStream2.Position = 0L;
                do
                  ;
                while (memoryStream1.Position != memoryStream1.Length && memoryStream1.ReadByte() == memoryStream2.ReadByte());
                if (memoryStream1.Position == memoryStream1.Length)
                  return schemaComplexType;
              }
            }
          }
          finally
          {
            memoryStream1?.Close();
            memoryStream2?.Close();
          }
        }
        xs.Add(schemaSerializable);
        return schemaComplexType;
      }
    }

    [XmlSchemaProvider("GetTypedTableSchema")]
    [Serializable]
    public class CDOMethodsDataTable : TypedTableBase<ModelDataSet.CDOMethodsRow>
    {
      private DataColumn columnDescription;
      private DataColumn columnName;
      private DataColumn columnParentID;
      private DataColumn _columnWCFCDO_ID;
      private DataColumn columnMask;
      private DataColumn columnMethodName;
      private DataColumn columnParameterName;
      private DataColumn columnParameterDescription;
      private DataColumn columnMethodDescription;
      private DataColumn _columnWCFCDOMethods_ID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public CDOMethodsDataTable()
      {
        this.TableName = "CDOMethods";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      internal CDOMethodsDataTable(DataTable table)
      {
        this.TableName = table.TableName;
        if (table.CaseSensitive != table.DataSet.CaseSensitive)
          this.CaseSensitive = table.CaseSensitive;
        if (table.Locale.ToString() != table.DataSet.Locale.ToString())
          this.Locale = table.Locale;
        if (table.Namespace != table.DataSet.Namespace)
          this.Namespace = table.Namespace;
        this.Prefix = table.Prefix;
        this.MinimumCapacity = table.MinimumCapacity;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected CDOMethodsDataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn DescriptionColumn
      {
        get
        {
          return this.columnDescription;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn NameColumn
      {
        get
        {
          return this.columnName;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn ParentIDColumn
      {
        get
        {
          return this.columnParentID;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn _WCFCDO_IDColumn
      {
        get
        {
          return this._columnWCFCDO_ID;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn MaskColumn
      {
        get
        {
          return this.columnMask;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn MethodNameColumn
      {
        get
        {
          return this.columnMethodName;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn ParameterNameColumn
      {
        get
        {
          return this.columnParameterName;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn ParameterDescriptionColumn
      {
        get
        {
          return this.columnParameterDescription;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn MethodDescriptionColumn
      {
        get
        {
          return this.columnMethodDescription;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn _WCFCDOMethods_IDColumn
      {
        get
        {
          return this._columnWCFCDOMethods_ID;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [Browsable(false)]
      public int Count
      {
        get
        {
          return this.Rows.Count;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public ModelDataSet.CDOMethodsRow this[int index]
      {
        get
        {
          return (ModelDataSet.CDOMethodsRow) this.Rows[index];
        }
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public event ModelDataSet.CDOMethodsRowChangeEventHandler CDOMethodsRowChanging;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public event ModelDataSet.CDOMethodsRowChangeEventHandler CDOMethodsRowChanged;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public event ModelDataSet.CDOMethodsRowChangeEventHandler CDOMethodsRowDeleting;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public event ModelDataSet.CDOMethodsRowChangeEventHandler CDOMethodsRowDeleted;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void AddCDOMethodsRow(ModelDataSet.CDOMethodsRow row)
      {
        this.Rows.Add((DataRow) row);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public ModelDataSet.CDOMethodsRow AddCDOMethodsRow(
        string Description,
        string Name,
        int ParentID,
        int _WCFCDO_ID,
        int Mask,
        string MethodName,
        string ParameterName,
        string ParameterDescription,
        string MethodDescription,
        int _WCFCDOMethods_ID)
      {
        ModelDataSet.CDOMethodsRow cdoMethodsRow = (ModelDataSet.CDOMethodsRow) this.NewRow();
        object[] objArray = new object[10]
        {
          (object) Description,
          (object) Name,
          (object) ParentID,
          (object) _WCFCDO_ID,
          (object) Mask,
          (object) MethodName,
          (object) ParameterName,
          (object) ParameterDescription,
          (object) MethodDescription,
          (object) _WCFCDOMethods_ID
        };
        cdoMethodsRow.ItemArray = objArray;
        this.Rows.Add((DataRow) cdoMethodsRow);
        return cdoMethodsRow;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public override DataTable Clone()
      {
        ModelDataSet.CDOMethodsDataTable methodsDataTable = (ModelDataSet.CDOMethodsDataTable) base.Clone();
        methodsDataTable.InitVars();
        return (DataTable) methodsDataTable;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override DataTable CreateInstance()
      {
        return (DataTable) new ModelDataSet.CDOMethodsDataTable();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      internal void InitVars()
      {
        this.columnDescription = this.Columns["Description"];
        this.columnName = this.Columns["Name"];
        this.columnParentID = this.Columns["ParentID"];
        this._columnWCFCDO_ID = this.Columns["WCFCDO.ID"];
        this.columnMask = this.Columns["Mask"];
        this.columnMethodName = this.Columns["MethodName"];
        this.columnParameterName = this.Columns["ParameterName"];
        this.columnParameterDescription = this.Columns["ParameterDescription"];
        this.columnMethodDescription = this.Columns["MethodDescription"];
        this._columnWCFCDOMethods_ID = this.Columns["WCFCDOMethods.ID"];
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      private void InitClass()
      {
        this.columnDescription = new DataColumn("Description", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnDescription);
        this.columnName = new DataColumn("Name", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnName);
        this.columnParentID = new DataColumn("ParentID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnParentID);
        this._columnWCFCDO_ID = new DataColumn("WCFCDO.ID", typeof (int), (string) null, MappingType.Element);
        this._columnWCFCDO_ID.ExtendedProperties.Add((object) "Generator_ColumnVarNameInTable", (object) "_columnWCFCDO_ID");
        this._columnWCFCDO_ID.ExtendedProperties.Add((object) "Generator_UserColumnName", (object) "WCFCDO.ID");
        this.Columns.Add(this._columnWCFCDO_ID);
        this.columnMask = new DataColumn("Mask", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnMask);
        this.columnMethodName = new DataColumn("MethodName", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnMethodName);
        this.columnParameterName = new DataColumn("ParameterName", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnParameterName);
        this.columnParameterDescription = new DataColumn("ParameterDescription", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnParameterDescription);
        this.columnMethodDescription = new DataColumn("MethodDescription", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnMethodDescription);
        this._columnWCFCDOMethods_ID = new DataColumn("WCFCDOMethods.ID", typeof (int), (string) null, MappingType.Element);
        this._columnWCFCDOMethods_ID.ExtendedProperties.Add((object) "Generator_ColumnVarNameInTable", (object) "_columnWCFCDOMethods_ID");
        this._columnWCFCDOMethods_ID.ExtendedProperties.Add((object) "Generator_UserColumnName", (object) "WCFCDOMethods.ID");
        this.Columns.Add(this._columnWCFCDOMethods_ID);
        this.columnDescription.MaxLength = 536870910;
        this.columnName.MaxLength = 37;
        this.columnMethodName.MaxLength = 50;
        this.columnParameterName.MaxLength = (int) byte.MaxValue;
        this.columnParameterDescription.MaxLength = 250;
        this.columnMethodDescription.MaxLength = 536870910;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public ModelDataSet.CDOMethodsRow NewCDOMethodsRow()
      {
        return (ModelDataSet.CDOMethodsRow) this.NewRow();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
      {
        return (DataRow) new ModelDataSet.CDOMethodsRow(builder);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override Type GetRowType()
      {
        return typeof (ModelDataSet.CDOMethodsRow);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.CDOMethodsRowChanged == null)
          return;
        this.CDOMethodsRowChanged((object) this, new ModelDataSet.CDOMethodsRowChangeEvent((ModelDataSet.CDOMethodsRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.CDOMethodsRowChanging == null)
          return;
        this.CDOMethodsRowChanging((object) this, new ModelDataSet.CDOMethodsRowChangeEvent((ModelDataSet.CDOMethodsRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.CDOMethodsRowDeleted == null)
          return;
        this.CDOMethodsRowDeleted((object) this, new ModelDataSet.CDOMethodsRowChangeEvent((ModelDataSet.CDOMethodsRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.CDOMethodsRowDeleting == null)
          return;
        this.CDOMethodsRowDeleting((object) this, new ModelDataSet.CDOMethodsRowChangeEvent((ModelDataSet.CDOMethodsRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void RemoveCDOMethodsRow(ModelDataSet.CDOMethodsRow row)
      {
        this.Rows.Remove((DataRow) row);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        ModelDataSet modelDataSet = new ModelDataSet();
        XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny();
        xmlSchemaAny1.Namespace = "http://www.w3.org/2001/XMLSchema";
        xmlSchemaAny1.MinOccurs = new Decimal(0);
        xmlSchemaAny1.MaxOccurs = new Decimal(-1, -1, -1, false, (byte) 0);
        xmlSchemaAny1.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny1);
        XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
        xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
        xmlSchemaAny2.MinOccurs = new Decimal(1);
        xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny2);
        schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "namespace",
          FixedValue = modelDataSet.Namespace
        });
        schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (CDOMethodsDataTable)
        });
        schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = modelDataSet.GetSchemaSerializable();
        if (xs.Contains(schemaSerializable.TargetNamespace))
        {
          MemoryStream memoryStream1 = new MemoryStream();
          MemoryStream memoryStream2 = new MemoryStream();
          try
          {
            schemaSerializable.Write((Stream) memoryStream1);
            IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
            while (enumerator.MoveNext())
            {
              XmlSchema current = (XmlSchema) enumerator.Current;
              memoryStream2.SetLength(0L);
              MemoryStream memoryStream3 = memoryStream2;
              current.Write((Stream) memoryStream3);
              if (memoryStream1.Length == memoryStream2.Length)
              {
                memoryStream1.Position = 0L;
                memoryStream2.Position = 0L;
                do
                  ;
                while (memoryStream1.Position != memoryStream1.Length && memoryStream1.ReadByte() == memoryStream2.ReadByte());
                if (memoryStream1.Position == memoryStream1.Length)
                  return schemaComplexType;
              }
            }
          }
          finally
          {
            memoryStream1?.Close();
            memoryStream2?.Close();
          }
        }
        xs.Add(schemaSerializable);
        return schemaComplexType;
      }
    }

    [XmlSchemaProvider("GetTypedTableSchema")]
    [Serializable]
    public class CDOFieldsDataTable : TypedTableBase<ModelDataSet.CDOFieldsRow>
    {
      private DataColumn _columnSelfWCFCDO_Description;
      private DataColumn _columnSelfWCFCDO_Name;
      private DataColumn columnParentID;
      private DataColumn _columnSelfWCFCDO_ID;
      private DataColumn _columnSelfWCFCDO_Mask;
      private DataColumn _columnWCFCDOFields_Name;
      private DataColumn _columnWCFCDOFields_Description;
      private DataColumn columnFieldDefName;
      private DataColumn columnIsList;
      private DataColumn columnType;
      private DataColumn columnOwnership;
      private DataColumn columnSerialization;
      private DataColumn _columnWCFCDOFields_ID;
      private DataColumn columnTypeID;
      private DataColumn _columnWCFCDOFields_Mask;
      private DataColumn columnTypeName;
      private DataColumn columnCDOFieldUsage;
      private DataColumn columnAllowClientToRead;
      private DataColumn columnAllowClientToUpdate;
      private DataColumn columnIsUserDefinedField;
      private DataColumn columnRequired;
      private DataColumn columnDefaultValue;
      private DataColumn columnLabelID;
      private DataColumn columnCreateOnInitialize;
      private DataColumn columnInheritMask;
      private DataColumn columnInheritedID;
      private DataColumn columnSelValMode;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public CDOFieldsDataTable()
      {
        this.TableName = "CDOFields";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      internal CDOFieldsDataTable(DataTable table)
      {
        this.TableName = table.TableName;
        if (table.CaseSensitive != table.DataSet.CaseSensitive)
          this.CaseSensitive = table.CaseSensitive;
        if (table.Locale.ToString() != table.DataSet.Locale.ToString())
          this.Locale = table.Locale;
        if (table.Namespace != table.DataSet.Namespace)
          this.Namespace = table.Namespace;
        this.Prefix = table.Prefix;
        this.MinimumCapacity = table.MinimumCapacity;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected CDOFieldsDataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn _SelfWCFCDO_DescriptionColumn
      {
        get
        {
          return this._columnSelfWCFCDO_Description;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn _SelfWCFCDO_NameColumn
      {
        get
        {
          return this._columnSelfWCFCDO_Name;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn ParentIDColumn
      {
        get
        {
          return this.columnParentID;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn _SelfWCFCDO_IDColumn
      {
        get
        {
          return this._columnSelfWCFCDO_ID;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn _SelfWCFCDO_MaskColumn
      {
        get
        {
          return this._columnSelfWCFCDO_Mask;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn _WCFCDOFields_NameColumn
      {
        get
        {
          return this._columnWCFCDOFields_Name;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn _WCFCDOFields_DescriptionColumn
      {
        get
        {
          return this._columnWCFCDOFields_Description;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn FieldDefNameColumn
      {
        get
        {
          return this.columnFieldDefName;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn IsListColumn
      {
        get
        {
          return this.columnIsList;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn TypeColumn
      {
        get
        {
          return this.columnType;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn OwnershipColumn
      {
        get
        {
          return this.columnOwnership;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn SerializationColumn
      {
        get
        {
          return this.columnSerialization;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn _WCFCDOFields_IDColumn
      {
        get
        {
          return this._columnWCFCDOFields_ID;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn TypeIDColumn
      {
        get
        {
          return this.columnTypeID;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn _WCFCDOFields_MaskColumn
      {
        get
        {
          return this._columnWCFCDOFields_Mask;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn TypeNameColumn
      {
        get
        {
          return this.columnTypeName;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn CDOFieldUsageColumn
      {
        get
        {
          return this.columnCDOFieldUsage;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn AllowClientToReadColumn
      {
        get
        {
          return this.columnAllowClientToRead;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn AllowClientToUpdateColumn
      {
        get
        {
          return this.columnAllowClientToUpdate;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn IsUserDefinedFieldColumn
      {
        get
        {
          return this.columnIsUserDefinedField;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn RequiredColumn
      {
        get
        {
          return this.columnRequired;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn DefaultValueColumn
      {
        get
        {
          return this.columnDefaultValue;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn LabelIDColumn
      {
        get
        {
          return this.columnLabelID;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn CreateOnInitializeColumn
      {
        get
        {
          return this.columnCreateOnInitialize;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn InheritMaskColumn
      {
        get
        {
          return this.columnInheritMask;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn InheritedIDColumn
      {
        get
        {
          return this.columnInheritedID;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn SelValModeColumn
      {
        get
        {
          return this.columnSelValMode;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [Browsable(false)]
      public int Count
      {
        get
        {
          return this.Rows.Count;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public ModelDataSet.CDOFieldsRow this[int index]
      {
        get
        {
          return (ModelDataSet.CDOFieldsRow) this.Rows[index];
        }
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public event ModelDataSet.CDOFieldsRowChangeEventHandler CDOFieldsRowChanging;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public event ModelDataSet.CDOFieldsRowChangeEventHandler CDOFieldsRowChanged;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public event ModelDataSet.CDOFieldsRowChangeEventHandler CDOFieldsRowDeleting;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public event ModelDataSet.CDOFieldsRowChangeEventHandler CDOFieldsRowDeleted;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void AddCDOFieldsRow(ModelDataSet.CDOFieldsRow row)
      {
        this.Rows.Add((DataRow) row);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public ModelDataSet.CDOFieldsRow AddCDOFieldsRow(
        string _SelfWCFCDO_Description,
        string _SelfWCFCDO_Name,
        int ParentID,
        int _SelfWCFCDO_ID,
        int _SelfWCFCDO_Mask,
        string _WCFCDOFields_Name,
        string _WCFCDOFields_Description,
        string FieldDefName,
        bool IsList,
        int Type,
        int Ownership,
        int Serialization,
        int _WCFCDOFields_ID,
        int TypeID,
        int _WCFCDOFields_Mask,
        string TypeName,
        string CDOFieldUsage,
        bool AllowClientToRead,
        bool AllowClientToUpdate,
        bool IsUserDefinedField,
        int Required,
        string DefaultValue,
        int LabelID,
        bool CreateOnInitialize,
        int InheritMask,
        int InheritedID,
        int SelValMode)
      {
        ModelDataSet.CDOFieldsRow cdoFieldsRow = (ModelDataSet.CDOFieldsRow) this.NewRow();
        object[] objArray = new object[27]
        {
          (object) _SelfWCFCDO_Description,
          (object) _SelfWCFCDO_Name,
          (object) ParentID,
          (object) _SelfWCFCDO_ID,
          (object) _SelfWCFCDO_Mask,
          (object) _WCFCDOFields_Name,
          (object) _WCFCDOFields_Description,
          (object) FieldDefName,
          (object) IsList,
          (object) Type,
          (object) Ownership,
          (object) Serialization,
          (object) _WCFCDOFields_ID,
          (object) TypeID,
          (object) _WCFCDOFields_Mask,
          (object) TypeName,
          (object) CDOFieldUsage,
          (object) AllowClientToRead,
          (object) AllowClientToUpdate,
          (object) IsUserDefinedField,
          (object) Required,
          (object) DefaultValue,
          (object) LabelID,
          (object) CreateOnInitialize,
          (object) InheritMask,
          (object) InheritedID,
          (object) SelValMode
        };
        cdoFieldsRow.ItemArray = objArray;
        this.Rows.Add((DataRow) cdoFieldsRow);
        return cdoFieldsRow;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public override DataTable Clone()
      {
        ModelDataSet.CDOFieldsDataTable cdoFieldsDataTable = (ModelDataSet.CDOFieldsDataTable) base.Clone();
        cdoFieldsDataTable.InitVars();
        return (DataTable) cdoFieldsDataTable;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override DataTable CreateInstance()
      {
        return (DataTable) new ModelDataSet.CDOFieldsDataTable();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      internal void InitVars()
      {
        this._columnSelfWCFCDO_Description = this.Columns["SelfWCFCDO.Description"];
        this._columnSelfWCFCDO_Name = this.Columns["SelfWCFCDO.Name"];
        this.columnParentID = this.Columns["ParentID"];
        this._columnSelfWCFCDO_ID = this.Columns["SelfWCFCDO.ID"];
        this._columnSelfWCFCDO_Mask = this.Columns["SelfWCFCDO.Mask"];
        this._columnWCFCDOFields_Name = this.Columns["WCFCDOFields.Name"];
        this._columnWCFCDOFields_Description = this.Columns["WCFCDOFields.Description"];
        this.columnFieldDefName = this.Columns["FieldDefName"];
        this.columnIsList = this.Columns["IsList"];
        this.columnType = this.Columns["Type"];
        this.columnOwnership = this.Columns["Ownership"];
        this.columnSerialization = this.Columns["Serialization"];
        this._columnWCFCDOFields_ID = this.Columns["WCFCDOFields.ID"];
        this.columnTypeID = this.Columns["TypeID"];
        this._columnWCFCDOFields_Mask = this.Columns["WCFCDOFields.Mask"];
        this.columnTypeName = this.Columns["TypeName"];
        this.columnCDOFieldUsage = this.Columns["CDOFieldUsage"];
        this.columnAllowClientToRead = this.Columns["AllowClientToRead"];
        this.columnAllowClientToUpdate = this.Columns["AllowClientToUpdate"];
        this.columnIsUserDefinedField = this.Columns["IsUserDefinedField"];
        this.columnRequired = this.Columns["Required"];
        this.columnDefaultValue = this.Columns["DefaultValue"];
        this.columnLabelID = this.Columns["LabelID"];
        this.columnCreateOnInitialize = this.Columns["CreateOnInitialize"];
        this.columnInheritMask = this.Columns["InheritMask"];
        this.columnInheritedID = this.Columns["InheritedID"];
        this.columnSelValMode = this.Columns["SelValMode"];
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      private void InitClass()
      {
        this._columnSelfWCFCDO_Description = new DataColumn("SelfWCFCDO.Description", typeof (string), (string) null, MappingType.Element);
        this._columnSelfWCFCDO_Description.ExtendedProperties.Add((object) "Generator_ColumnVarNameInTable", (object) "_columnSelfWCFCDO_Description");
        this._columnSelfWCFCDO_Description.ExtendedProperties.Add((object) "Generator_UserColumnName", (object) "SelfWCFCDO.Description");
        this.Columns.Add(this._columnSelfWCFCDO_Description);
        this._columnSelfWCFCDO_Name = new DataColumn("SelfWCFCDO.Name", typeof (string), (string) null, MappingType.Element);
        this._columnSelfWCFCDO_Name.ExtendedProperties.Add((object) "Generator_ColumnVarNameInTable", (object) "_columnSelfWCFCDO_Name");
        this._columnSelfWCFCDO_Name.ExtendedProperties.Add((object) "Generator_UserColumnName", (object) "SelfWCFCDO.Name");
        this.Columns.Add(this._columnSelfWCFCDO_Name);
        this.columnParentID = new DataColumn("ParentID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnParentID);
        this._columnSelfWCFCDO_ID = new DataColumn("SelfWCFCDO.ID", typeof (int), (string) null, MappingType.Element);
        this._columnSelfWCFCDO_ID.ExtendedProperties.Add((object) "Generator_ColumnVarNameInTable", (object) "_columnSelfWCFCDO_ID");
        this._columnSelfWCFCDO_ID.ExtendedProperties.Add((object) "Generator_UserColumnName", (object) "SelfWCFCDO.ID");
        this.Columns.Add(this._columnSelfWCFCDO_ID);
        this._columnSelfWCFCDO_Mask = new DataColumn("SelfWCFCDO.Mask", typeof (int), (string) null, MappingType.Element);
        this._columnSelfWCFCDO_Mask.ExtendedProperties.Add((object) "Generator_ColumnVarNameInTable", (object) "_columnSelfWCFCDO_Mask");
        this._columnSelfWCFCDO_Mask.ExtendedProperties.Add((object) "Generator_UserColumnName", (object) "SelfWCFCDO.Mask");
        this.Columns.Add(this._columnSelfWCFCDO_Mask);
        this._columnWCFCDOFields_Name = new DataColumn("WCFCDOFields.Name", typeof (string), (string) null, MappingType.Element);
        this._columnWCFCDOFields_Name.ExtendedProperties.Add((object) "Generator_ColumnVarNameInTable", (object) "_columnWCFCDOFields_Name");
        this._columnWCFCDOFields_Name.ExtendedProperties.Add((object) "Generator_UserColumnName", (object) "WCFCDOFields.Name");
        this.Columns.Add(this._columnWCFCDOFields_Name);
        this._columnWCFCDOFields_Description = new DataColumn("WCFCDOFields.Description", typeof (string), (string) null, MappingType.Element);
        this._columnWCFCDOFields_Description.ExtendedProperties.Add((object) "Generator_ColumnVarNameInTable", (object) "_columnWCFCDOFields_Description");
        this._columnWCFCDOFields_Description.ExtendedProperties.Add((object) "Generator_UserColumnName", (object) "WCFCDOFields.Description");
        this.Columns.Add(this._columnWCFCDOFields_Description);
        this.columnFieldDefName = new DataColumn("FieldDefName", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnFieldDefName);
        this.columnIsList = new DataColumn("IsList", typeof (bool), (string) null, MappingType.Element);
        this.Columns.Add(this.columnIsList);
        this.columnType = new DataColumn("Type", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnType);
        this.columnOwnership = new DataColumn("Ownership", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnOwnership);
        this.columnSerialization = new DataColumn("Serialization", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnSerialization);
        this._columnWCFCDOFields_ID = new DataColumn("WCFCDOFields.ID", typeof (int), (string) null, MappingType.Element);
        this._columnWCFCDOFields_ID.ExtendedProperties.Add((object) "Generator_ColumnVarNameInTable", (object) "_columnWCFCDOFields_ID");
        this._columnWCFCDOFields_ID.ExtendedProperties.Add((object) "Generator_UserColumnName", (object) "WCFCDOFields.ID");
        this.Columns.Add(this._columnWCFCDOFields_ID);
        this.columnTypeID = new DataColumn("TypeID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnTypeID);
        this._columnWCFCDOFields_Mask = new DataColumn("WCFCDOFields.Mask", typeof (int), (string) null, MappingType.Element);
        this._columnWCFCDOFields_Mask.ExtendedProperties.Add((object) "Generator_ColumnVarNameInTable", (object) "_columnWCFCDOFields_Mask");
        this._columnWCFCDOFields_Mask.ExtendedProperties.Add((object) "Generator_UserColumnName", (object) "WCFCDOFields.Mask");
        this.Columns.Add(this._columnWCFCDOFields_Mask);
        this.columnTypeName = new DataColumn("TypeName", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnTypeName);
        this.columnCDOFieldUsage = new DataColumn("CDOFieldUsage", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCDOFieldUsage);
        this.columnAllowClientToRead = new DataColumn("AllowClientToRead", typeof (bool), (string) null, MappingType.Element);
        this.Columns.Add(this.columnAllowClientToRead);
        this.columnAllowClientToUpdate = new DataColumn("AllowClientToUpdate", typeof (bool), (string) null, MappingType.Element);
        this.Columns.Add(this.columnAllowClientToUpdate);
        this.columnIsUserDefinedField = new DataColumn("IsUserDefinedField", typeof (bool), (string) null, MappingType.Element);
        this.Columns.Add(this.columnIsUserDefinedField);
        this.columnRequired = new DataColumn("Required", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnRequired);
        this.columnDefaultValue = new DataColumn("DefaultValue", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnDefaultValue);
        this.columnLabelID = new DataColumn("LabelID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnLabelID);
        this.columnCreateOnInitialize = new DataColumn("CreateOnInitialize", typeof (bool), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCreateOnInitialize);
        this.columnInheritMask = new DataColumn("InheritMask", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnInheritMask);
        this.columnInheritedID = new DataColumn("InheritedID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnInheritedID);
        this.columnSelValMode = new DataColumn("SelValMode", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnSelValMode);
        this._columnSelfWCFCDO_Description.MaxLength = 536870910;
        this._columnSelfWCFCDO_Name.MaxLength = 37;
        this._columnWCFCDOFields_Name.MaxLength = 32;
        this._columnWCFCDOFields_Description.MaxLength = 536870910;
        this.columnFieldDefName.MaxLength = 37;
        this.columnTypeID.ReadOnly = true;
        this.columnTypeName.MaxLength = 37;
        this.columnCDOFieldUsage.MaxLength = 50;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public ModelDataSet.CDOFieldsRow NewCDOFieldsRow()
      {
        return (ModelDataSet.CDOFieldsRow) this.NewRow();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
      {
        return (DataRow) new ModelDataSet.CDOFieldsRow(builder);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override Type GetRowType()
      {
        return typeof (ModelDataSet.CDOFieldsRow);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.CDOFieldsRowChanged == null)
          return;
        this.CDOFieldsRowChanged((object) this, new ModelDataSet.CDOFieldsRowChangeEvent((ModelDataSet.CDOFieldsRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.CDOFieldsRowChanging == null)
          return;
        this.CDOFieldsRowChanging((object) this, new ModelDataSet.CDOFieldsRowChangeEvent((ModelDataSet.CDOFieldsRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.CDOFieldsRowDeleted == null)
          return;
        this.CDOFieldsRowDeleted((object) this, new ModelDataSet.CDOFieldsRowChangeEvent((ModelDataSet.CDOFieldsRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.CDOFieldsRowDeleting == null)
          return;
        this.CDOFieldsRowDeleting((object) this, new ModelDataSet.CDOFieldsRowChangeEvent((ModelDataSet.CDOFieldsRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void RemoveCDOFieldsRow(ModelDataSet.CDOFieldsRow row)
      {
        this.Rows.Remove((DataRow) row);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        ModelDataSet modelDataSet = new ModelDataSet();
        XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny();
        xmlSchemaAny1.Namespace = "http://www.w3.org/2001/XMLSchema";
        xmlSchemaAny1.MinOccurs = new Decimal(0);
        xmlSchemaAny1.MaxOccurs = new Decimal(-1, -1, -1, false, (byte) 0);
        xmlSchemaAny1.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny1);
        XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
        xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
        xmlSchemaAny2.MinOccurs = new Decimal(1);
        xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny2);
        schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "namespace",
          FixedValue = modelDataSet.Namespace
        });
        schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (CDOFieldsDataTable)
        });
        schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = modelDataSet.GetSchemaSerializable();
        if (xs.Contains(schemaSerializable.TargetNamespace))
        {
          MemoryStream memoryStream1 = new MemoryStream();
          MemoryStream memoryStream2 = new MemoryStream();
          try
          {
            schemaSerializable.Write((Stream) memoryStream1);
            IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
            while (enumerator.MoveNext())
            {
              XmlSchema current = (XmlSchema) enumerator.Current;
              memoryStream2.SetLength(0L);
              MemoryStream memoryStream3 = memoryStream2;
              current.Write((Stream) memoryStream3);
              if (memoryStream1.Length == memoryStream2.Length)
              {
                memoryStream1.Position = 0L;
                memoryStream2.Position = 0L;
                do
                  ;
                while (memoryStream1.Position != memoryStream1.Length && memoryStream1.ReadByte() == memoryStream2.ReadByte());
                if (memoryStream1.Position == memoryStream1.Length)
                  return schemaComplexType;
              }
            }
          }
          finally
          {
            memoryStream1?.Close();
            memoryStream2?.Close();
          }
        }
        xs.Add(schemaSerializable);
        return schemaComplexType;
      }
    }

    [XmlSchemaProvider("GetTypedTableSchema")]
    [Serializable]
    public class WCFWorkspacesDataTable : TypedTableBase<ModelDataSet.WCFWorkspacesRow>
    {
      private DataColumn columnId;
      private DataColumn columnCode;
      private DataColumn columnSequence;
      private DataColumn columnDescription;
      private DataColumn columnSupportedBy;
      private DataColumn columnColor;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public WCFWorkspacesDataTable()
      {
        this.TableName = "WCFWorkspaces";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      internal WCFWorkspacesDataTable(DataTable table)
      {
        this.TableName = table.TableName;
        if (table.CaseSensitive != table.DataSet.CaseSensitive)
          this.CaseSensitive = table.CaseSensitive;
        if (table.Locale.ToString() != table.DataSet.Locale.ToString())
          this.Locale = table.Locale;
        if (table.Namespace != table.DataSet.Namespace)
          this.Namespace = table.Namespace;
        this.Prefix = table.Prefix;
        this.MinimumCapacity = table.MinimumCapacity;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected WCFWorkspacesDataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn IdColumn
      {
        get
        {
          return this.columnId;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn CodeColumn
      {
        get
        {
          return this.columnCode;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn SequenceColumn
      {
        get
        {
          return this.columnSequence;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn DescriptionColumn
      {
        get
        {
          return this.columnDescription;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn SupportedByColumn
      {
        get
        {
          return this.columnSupportedBy;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn ColorColumn
      {
        get
        {
          return this.columnColor;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [Browsable(false)]
      public int Count
      {
        get
        {
          return this.Rows.Count;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public ModelDataSet.WCFWorkspacesRow this[int index]
      {
        get
        {
          return (ModelDataSet.WCFWorkspacesRow) this.Rows[index];
        }
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public event ModelDataSet.WCFWorkspacesRowChangeEventHandler WCFWorkspacesRowChanging;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public event ModelDataSet.WCFWorkspacesRowChangeEventHandler WCFWorkspacesRowChanged;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public event ModelDataSet.WCFWorkspacesRowChangeEventHandler WCFWorkspacesRowDeleting;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public event ModelDataSet.WCFWorkspacesRowChangeEventHandler WCFWorkspacesRowDeleted;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void AddWCFWorkspacesRow(ModelDataSet.WCFWorkspacesRow row)
      {
        this.Rows.Add((DataRow) row);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public ModelDataSet.WCFWorkspacesRow AddWCFWorkspacesRow(
        int Id,
        string Code,
        int Sequence,
        string Description,
        string SupportedBy,
        string Color)
      {
        ModelDataSet.WCFWorkspacesRow wcfWorkspacesRow = (ModelDataSet.WCFWorkspacesRow) this.NewRow();
        object[] objArray = new object[6]
        {
          (object) Id,
          (object) Code,
          (object) Sequence,
          (object) Description,
          (object) SupportedBy,
          (object) Color
        };
        wcfWorkspacesRow.ItemArray = objArray;
        this.Rows.Add((DataRow) wcfWorkspacesRow);
        return wcfWorkspacesRow;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public ModelDataSet.WCFWorkspacesRow FindById(int Id)
      {
        return (ModelDataSet.WCFWorkspacesRow) this.Rows.Find(new object[1]
        {
          (object) Id
        });
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public override DataTable Clone()
      {
        ModelDataSet.WCFWorkspacesDataTable workspacesDataTable = (ModelDataSet.WCFWorkspacesDataTable) base.Clone();
        workspacesDataTable.InitVars();
        return (DataTable) workspacesDataTable;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override DataTable CreateInstance()
      {
        return (DataTable) new ModelDataSet.WCFWorkspacesDataTable();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      internal void InitVars()
      {
        this.columnId = this.Columns["Id"];
        this.columnCode = this.Columns["Code"];
        this.columnSequence = this.Columns["Sequence"];
        this.columnDescription = this.Columns["Description"];
        this.columnSupportedBy = this.Columns["SupportedBy"];
        this.columnColor = this.Columns["Color"];
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      private void InitClass()
      {
        this.columnId = new DataColumn("Id", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnId);
        this.columnCode = new DataColumn("Code", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCode);
        this.columnSequence = new DataColumn("Sequence", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnSequence);
        this.columnDescription = new DataColumn("Description", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnDescription);
        this.columnSupportedBy = new DataColumn("SupportedBy", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnSupportedBy);
        this.columnColor = new DataColumn("Color", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnColor);
        this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
        {
          this.columnId
        }, true));
        this.columnId.AllowDBNull = false;
        this.columnId.Unique = true;
        this.columnCode.MaxLength = 5;
        this.columnDescription.MaxLength = (int) byte.MaxValue;
        this.columnSupportedBy.MaxLength = 50;
        this.columnColor.MaxLength = 50;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public ModelDataSet.WCFWorkspacesRow NewWCFWorkspacesRow()
      {
        return (ModelDataSet.WCFWorkspacesRow) this.NewRow();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
      {
        return (DataRow) new ModelDataSet.WCFWorkspacesRow(builder);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override Type GetRowType()
      {
        return typeof (ModelDataSet.WCFWorkspacesRow);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.WCFWorkspacesRowChanged == null)
          return;
        this.WCFWorkspacesRowChanged((object) this, new ModelDataSet.WCFWorkspacesRowChangeEvent((ModelDataSet.WCFWorkspacesRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.WCFWorkspacesRowChanging == null)
          return;
        this.WCFWorkspacesRowChanging((object) this, new ModelDataSet.WCFWorkspacesRowChangeEvent((ModelDataSet.WCFWorkspacesRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.WCFWorkspacesRowDeleted == null)
          return;
        this.WCFWorkspacesRowDeleted((object) this, new ModelDataSet.WCFWorkspacesRowChangeEvent((ModelDataSet.WCFWorkspacesRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.WCFWorkspacesRowDeleting == null)
          return;
        this.WCFWorkspacesRowDeleting((object) this, new ModelDataSet.WCFWorkspacesRowChangeEvent((ModelDataSet.WCFWorkspacesRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void RemoveWCFWorkspacesRow(ModelDataSet.WCFWorkspacesRow row)
      {
        this.Rows.Remove((DataRow) row);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        ModelDataSet modelDataSet = new ModelDataSet();
        XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny();
        xmlSchemaAny1.Namespace = "http://www.w3.org/2001/XMLSchema";
        xmlSchemaAny1.MinOccurs = new Decimal(0);
        xmlSchemaAny1.MaxOccurs = new Decimal(-1, -1, -1, false, (byte) 0);
        xmlSchemaAny1.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny1);
        XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
        xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
        xmlSchemaAny2.MinOccurs = new Decimal(1);
        xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny2);
        schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "namespace",
          FixedValue = modelDataSet.Namespace
        });
        schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (WCFWorkspacesDataTable)
        });
        schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = modelDataSet.GetSchemaSerializable();
        if (xs.Contains(schemaSerializable.TargetNamespace))
        {
          MemoryStream memoryStream1 = new MemoryStream();
          MemoryStream memoryStream2 = new MemoryStream();
          try
          {
            schemaSerializable.Write((Stream) memoryStream1);
            IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
            while (enumerator.MoveNext())
            {
              XmlSchema current = (XmlSchema) enumerator.Current;
              memoryStream2.SetLength(0L);
              MemoryStream memoryStream3 = memoryStream2;
              current.Write((Stream) memoryStream3);
              if (memoryStream1.Length == memoryStream2.Length)
              {
                memoryStream1.Position = 0L;
                memoryStream2.Position = 0L;
                do
                  ;
                while (memoryStream1.Position != memoryStream1.Length && memoryStream1.ReadByte() == memoryStream2.ReadByte());
                if (memoryStream1.Position == memoryStream1.Length)
                  return schemaComplexType;
              }
            }
          }
          finally
          {
            memoryStream1?.Close();
            memoryStream2?.Close();
          }
        }
        xs.Add(schemaSerializable);
        return schemaComplexType;
      }
    }

    [XmlSchemaProvider("GetTypedTableSchema")]
    [Serializable]
    public class UserDataTable : TypedTableBase<ModelDataSet.UserRow>
    {
      private DataColumn columnUserName;
      private DataColumn columnAllowUserMode;
      private DataColumn columnAllowSystemMode;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public UserDataTable()
      {
        this.TableName = "User";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      internal UserDataTable(DataTable table)
      {
        this.TableName = table.TableName;
        if (table.CaseSensitive != table.DataSet.CaseSensitive)
          this.CaseSensitive = table.CaseSensitive;
        if (table.Locale.ToString() != table.DataSet.Locale.ToString())
          this.Locale = table.Locale;
        if (table.Namespace != table.DataSet.Namespace)
          this.Namespace = table.Namespace;
        this.Prefix = table.Prefix;
        this.MinimumCapacity = table.MinimumCapacity;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected UserDataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn UserNameColumn
      {
        get
        {
          return this.columnUserName;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn AllowUserModeColumn
      {
        get
        {
          return this.columnAllowUserMode;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn AllowSystemModeColumn
      {
        get
        {
          return this.columnAllowSystemMode;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [Browsable(false)]
      public int Count
      {
        get
        {
          return this.Rows.Count;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public ModelDataSet.UserRow this[int index]
      {
        get
        {
          return (ModelDataSet.UserRow) this.Rows[index];
        }
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public event ModelDataSet.UserRowChangeEventHandler UserRowChanging;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public event ModelDataSet.UserRowChangeEventHandler UserRowChanged;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public event ModelDataSet.UserRowChangeEventHandler UserRowDeleting;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public event ModelDataSet.UserRowChangeEventHandler UserRowDeleted;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void AddUserRow(ModelDataSet.UserRow row)
      {
        this.Rows.Add((DataRow) row);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public ModelDataSet.UserRow AddUserRow(
        string UserName,
        bool AllowUserMode,
        bool AllowSystemMode)
      {
        ModelDataSet.UserRow userRow = (ModelDataSet.UserRow) this.NewRow();
        object[] objArray = new object[3]
        {
          (object) UserName,
          (object) AllowUserMode,
          (object) AllowSystemMode
        };
        userRow.ItemArray = objArray;
        this.Rows.Add((DataRow) userRow);
        return userRow;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public ModelDataSet.UserRow FindByUserName(string UserName)
      {
        return (ModelDataSet.UserRow) this.Rows.Find(new object[1]
        {
          (object) UserName
        });
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public override DataTable Clone()
      {
        ModelDataSet.UserDataTable userDataTable = (ModelDataSet.UserDataTable) base.Clone();
        userDataTable.InitVars();
        return (DataTable) userDataTable;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override DataTable CreateInstance()
      {
        return (DataTable) new ModelDataSet.UserDataTable();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      internal void InitVars()
      {
        this.columnUserName = this.Columns["UserName"];
        this.columnAllowUserMode = this.Columns["AllowUserMode"];
        this.columnAllowSystemMode = this.Columns["AllowSystemMode"];
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      private void InitClass()
      {
        this.columnUserName = new DataColumn("UserName", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnUserName);
        this.columnAllowUserMode = new DataColumn("AllowUserMode", typeof (bool), (string) null, MappingType.Element);
        this.Columns.Add(this.columnAllowUserMode);
        this.columnAllowSystemMode = new DataColumn("AllowSystemMode", typeof (bool), (string) null, MappingType.Element);
        this.Columns.Add(this.columnAllowSystemMode);
        this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
        {
          this.columnUserName
        }, true));
        this.columnUserName.AllowDBNull = false;
        this.columnUserName.Unique = true;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public ModelDataSet.UserRow NewUserRow()
      {
        return (ModelDataSet.UserRow) this.NewRow();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
      {
        return (DataRow) new ModelDataSet.UserRow(builder);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override Type GetRowType()
      {
        return typeof (ModelDataSet.UserRow);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.UserRowChanged == null)
          return;
        this.UserRowChanged((object) this, new ModelDataSet.UserRowChangeEvent((ModelDataSet.UserRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.UserRowChanging == null)
          return;
        this.UserRowChanging((object) this, new ModelDataSet.UserRowChangeEvent((ModelDataSet.UserRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.UserRowDeleted == null)
          return;
        this.UserRowDeleted((object) this, new ModelDataSet.UserRowChangeEvent((ModelDataSet.UserRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.UserRowDeleting == null)
          return;
        this.UserRowDeleting((object) this, new ModelDataSet.UserRowChangeEvent((ModelDataSet.UserRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void RemoveUserRow(ModelDataSet.UserRow row)
      {
        this.Rows.Remove((DataRow) row);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        ModelDataSet modelDataSet = new ModelDataSet();
        XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny();
        xmlSchemaAny1.Namespace = "http://www.w3.org/2001/XMLSchema";
        xmlSchemaAny1.MinOccurs = new Decimal(0);
        xmlSchemaAny1.MaxOccurs = new Decimal(-1, -1, -1, false, (byte) 0);
        xmlSchemaAny1.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny1);
        XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
        xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
        xmlSchemaAny2.MinOccurs = new Decimal(1);
        xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny2);
        schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "namespace",
          FixedValue = modelDataSet.Namespace
        });
        schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (UserDataTable)
        });
        schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = modelDataSet.GetSchemaSerializable();
        if (xs.Contains(schemaSerializable.TargetNamespace))
        {
          MemoryStream memoryStream1 = new MemoryStream();
          MemoryStream memoryStream2 = new MemoryStream();
          try
          {
            schemaSerializable.Write((Stream) memoryStream1);
            IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
            while (enumerator.MoveNext())
            {
              XmlSchema current = (XmlSchema) enumerator.Current;
              memoryStream2.SetLength(0L);
              MemoryStream memoryStream3 = memoryStream2;
              current.Write((Stream) memoryStream3);
              if (memoryStream1.Length == memoryStream2.Length)
              {
                memoryStream1.Position = 0L;
                memoryStream2.Position = 0L;
                do
                  ;
                while (memoryStream1.Position != memoryStream1.Length && memoryStream1.ReadByte() == memoryStream2.ReadByte());
                if (memoryStream1.Position == memoryStream1.Length)
                  return schemaComplexType;
              }
            }
          }
          finally
          {
            memoryStream1?.Close();
            memoryStream2?.Close();
          }
        }
        xs.Add(schemaSerializable);
        return schemaComplexType;
      }
    }

    public class CDOChildrenRow : DataRow
    {
      private ModelDataSet.CDOChildrenDataTable tableCDOChildren;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      internal CDOChildrenRow(DataRowBuilder rb)
        : base(rb)
      {
        this.tableCDOChildren = (ModelDataSet.CDOChildrenDataTable) this.Table;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string Description
      {
        get
        {
          try
          {
            return (string) this[this.tableCDOChildren.DescriptionColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Description' in table 'CDOChildren' is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tableCDOChildren.DescriptionColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string Name
      {
        get
        {
          try
          {
            return (string) this[this.tableCDOChildren.NameColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Name' in table 'CDOChildren' is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tableCDOChildren.NameColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public int ParentID
      {
        get
        {
          try
          {
            return (int) this[this.tableCDOChildren.ParentIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'ParentID' in table 'CDOChildren' is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tableCDOChildren.ParentIDColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public int _WCFCDO_ID
      {
        get
        {
          try
          {
            return (int) this[this.tableCDOChildren._WCFCDO_IDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'WCFCDO.ID' in table 'CDOChildren' is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tableCDOChildren._WCFCDO_IDColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public int Mask
      {
        get
        {
          try
          {
            return (int) this[this.tableCDOChildren.MaskColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Mask' in table 'CDOChildren' is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tableCDOChildren.MaskColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string MethodName
      {
        get
        {
          try
          {
            return (string) this[this.tableCDOChildren.MethodNameColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'MethodName' in table 'CDOChildren' is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tableCDOChildren.MethodNameColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string ParameterName
      {
        get
        {
          try
          {
            return (string) this[this.tableCDOChildren.ParameterNameColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'ParameterName' in table 'CDOChildren' is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tableCDOChildren.ParameterNameColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string ParmeterDescription
      {
        get
        {
          try
          {
            return (string) this[this.tableCDOChildren.ParmeterDescriptionColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'ParmeterDescription' in table 'CDOChildren' is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tableCDOChildren.ParmeterDescriptionColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string MethodDescription
      {
        get
        {
          try
          {
            return (string) this[this.tableCDOChildren.MethodDescriptionColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'MethodDescription' in table 'CDOChildren' is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tableCDOChildren.MethodDescriptionColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public int _WCFCDOMethods_ID
      {
        get
        {
          try
          {
            return (int) this[this.tableCDOChildren._WCFCDOMethods_IDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'WCFCDOMethods.ID' in table 'CDOChildren' is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tableCDOChildren._WCFCDOMethods_IDColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public int Count
      {
        get
        {
          try
          {
            return (int) this[this.tableCDOChildren.CountColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Count' in table 'CDOChildren' is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tableCDOChildren.CountColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public int _WCFCDOChildrenCount_ID
      {
        get
        {
          try
          {
            return (int) this[this.tableCDOChildren._WCFCDOChildrenCount_IDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'WCFCDOChildrenCount.ID' in table 'CDOChildren' is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tableCDOChildren._WCFCDOChildrenCount_IDColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IsDescriptionNull()
      {
        return this.IsNull(this.tableCDOChildren.DescriptionColumn);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void SetDescriptionNull()
      {
        this[this.tableCDOChildren.DescriptionColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IsNameNull()
      {
        return this.IsNull(this.tableCDOChildren.NameColumn);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void SetNameNull()
      {
        this[this.tableCDOChildren.NameColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IsParentIDNull()
      {
        return this.IsNull(this.tableCDOChildren.ParentIDColumn);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void SetParentIDNull()
      {
        this[this.tableCDOChildren.ParentIDColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool Is_WCFCDO_IDNull()
      {
        return this.IsNull(this.tableCDOChildren._WCFCDO_IDColumn);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void Set_WCFCDO_IDNull()
      {
        this[this.tableCDOChildren._WCFCDO_IDColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IsMaskNull()
      {
        return this.IsNull(this.tableCDOChildren.MaskColumn);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void SetMaskNull()
      {
        this[this.tableCDOChildren.MaskColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IsMethodNameNull()
      {
        return this.IsNull(this.tableCDOChildren.MethodNameColumn);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void SetMethodNameNull()
      {
        this[this.tableCDOChildren.MethodNameColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IsParameterNameNull()
      {
        return this.IsNull(this.tableCDOChildren.ParameterNameColumn);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void SetParameterNameNull()
      {
        this[this.tableCDOChildren.ParameterNameColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IsParmeterDescriptionNull()
      {
        return this.IsNull(this.tableCDOChildren.ParmeterDescriptionColumn);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void SetParmeterDescriptionNull()
      {
        this[this.tableCDOChildren.ParmeterDescriptionColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IsMethodDescriptionNull()
      {
        return this.IsNull(this.tableCDOChildren.MethodDescriptionColumn);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void SetMethodDescriptionNull()
      {
        this[this.tableCDOChildren.MethodDescriptionColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool Is_WCFCDOMethods_IDNull()
      {
        return this.IsNull(this.tableCDOChildren._WCFCDOMethods_IDColumn);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void Set_WCFCDOMethods_IDNull()
      {
        this[this.tableCDOChildren._WCFCDOMethods_IDColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IsCountNull()
      {
        return this.IsNull(this.tableCDOChildren.CountColumn);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void SetCountNull()
      {
        this[this.tableCDOChildren.CountColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool Is_WCFCDOChildrenCount_IDNull()
      {
        return this.IsNull(this.tableCDOChildren._WCFCDOChildrenCount_IDColumn);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void Set_WCFCDOChildrenCount_IDNull()
      {
        this[this.tableCDOChildren._WCFCDOChildrenCount_IDColumn] = Convert.DBNull;
      }
    }

    public class CDOMethodsRow : DataRow
    {
      private ModelDataSet.CDOMethodsDataTable tableCDOMethods;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      internal CDOMethodsRow(DataRowBuilder rb)
        : base(rb)
      {
        this.tableCDOMethods = (ModelDataSet.CDOMethodsDataTable) this.Table;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string Description
      {
        get
        {
          try
          {
            return (string) this[this.tableCDOMethods.DescriptionColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Description' in table 'CDOMethods' is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tableCDOMethods.DescriptionColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string Name
      {
        get
        {
          try
          {
            return (string) this[this.tableCDOMethods.NameColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Name' in table 'CDOMethods' is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tableCDOMethods.NameColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public int ParentID
      {
        get
        {
          try
          {
            return (int) this[this.tableCDOMethods.ParentIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'ParentID' in table 'CDOMethods' is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tableCDOMethods.ParentIDColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public int _WCFCDO_ID
      {
        get
        {
          try
          {
            return (int) this[this.tableCDOMethods._WCFCDO_IDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'WCFCDO.ID' in table 'CDOMethods' is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tableCDOMethods._WCFCDO_IDColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public int Mask
      {
        get
        {
          try
          {
            return (int) this[this.tableCDOMethods.MaskColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Mask' in table 'CDOMethods' is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tableCDOMethods.MaskColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string MethodName
      {
        get
        {
          try
          {
            return (string) this[this.tableCDOMethods.MethodNameColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'MethodName' in table 'CDOMethods' is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tableCDOMethods.MethodNameColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string ParameterName
      {
        get
        {
          try
          {
            return (string) this[this.tableCDOMethods.ParameterNameColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'ParameterName' in table 'CDOMethods' is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tableCDOMethods.ParameterNameColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string ParameterDescription
      {
        get
        {
          try
          {
            return (string) this[this.tableCDOMethods.ParameterDescriptionColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'ParameterDescription' in table 'CDOMethods' is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tableCDOMethods.ParameterDescriptionColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string MethodDescription
      {
        get
        {
          try
          {
            return (string) this[this.tableCDOMethods.MethodDescriptionColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'MethodDescription' in table 'CDOMethods' is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tableCDOMethods.MethodDescriptionColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public int _WCFCDOMethods_ID
      {
        get
        {
          try
          {
            return (int) this[this.tableCDOMethods._WCFCDOMethods_IDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'WCFCDOMethods.ID' in table 'CDOMethods' is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tableCDOMethods._WCFCDOMethods_IDColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IsDescriptionNull()
      {
        return this.IsNull(this.tableCDOMethods.DescriptionColumn);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void SetDescriptionNull()
      {
        this[this.tableCDOMethods.DescriptionColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IsNameNull()
      {
        return this.IsNull(this.tableCDOMethods.NameColumn);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void SetNameNull()
      {
        this[this.tableCDOMethods.NameColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IsParentIDNull()
      {
        return this.IsNull(this.tableCDOMethods.ParentIDColumn);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void SetParentIDNull()
      {
        this[this.tableCDOMethods.ParentIDColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool Is_WCFCDO_IDNull()
      {
        return this.IsNull(this.tableCDOMethods._WCFCDO_IDColumn);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void Set_WCFCDO_IDNull()
      {
        this[this.tableCDOMethods._WCFCDO_IDColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IsMaskNull()
      {
        return this.IsNull(this.tableCDOMethods.MaskColumn);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void SetMaskNull()
      {
        this[this.tableCDOMethods.MaskColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IsMethodNameNull()
      {
        return this.IsNull(this.tableCDOMethods.MethodNameColumn);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void SetMethodNameNull()
      {
        this[this.tableCDOMethods.MethodNameColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IsParameterNameNull()
      {
        return this.IsNull(this.tableCDOMethods.ParameterNameColumn);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void SetParameterNameNull()
      {
        this[this.tableCDOMethods.ParameterNameColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IsParameterDescriptionNull()
      {
        return this.IsNull(this.tableCDOMethods.ParameterDescriptionColumn);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void SetParameterDescriptionNull()
      {
        this[this.tableCDOMethods.ParameterDescriptionColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IsMethodDescriptionNull()
      {
        return this.IsNull(this.tableCDOMethods.MethodDescriptionColumn);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void SetMethodDescriptionNull()
      {
        this[this.tableCDOMethods.MethodDescriptionColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool Is_WCFCDOMethods_IDNull()
      {
        return this.IsNull(this.tableCDOMethods._WCFCDOMethods_IDColumn);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void Set_WCFCDOMethods_IDNull()
      {
        this[this.tableCDOMethods._WCFCDOMethods_IDColumn] = Convert.DBNull;
      }
    }

    public class CDOFieldsRow : DataRow
    {
      private ModelDataSet.CDOFieldsDataTable tableCDOFields;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      internal CDOFieldsRow(DataRowBuilder rb)
        : base(rb)
      {
        this.tableCDOFields = (ModelDataSet.CDOFieldsDataTable) this.Table;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string _SelfWCFCDO_Description
      {
        get
        {
          try
          {
            return (string) this[this.tableCDOFields._SelfWCFCDO_DescriptionColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'SelfWCFCDO.Description' in table 'CDOFields' is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tableCDOFields._SelfWCFCDO_DescriptionColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string _SelfWCFCDO_Name
      {
        get
        {
          try
          {
            return (string) this[this.tableCDOFields._SelfWCFCDO_NameColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'SelfWCFCDO.Name' in table 'CDOFields' is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tableCDOFields._SelfWCFCDO_NameColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public int ParentID
      {
        get
        {
          try
          {
            return (int) this[this.tableCDOFields.ParentIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'ParentID' in table 'CDOFields' is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tableCDOFields.ParentIDColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public int _SelfWCFCDO_ID
      {
        get
        {
          try
          {
            return (int) this[this.tableCDOFields._SelfWCFCDO_IDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'SelfWCFCDO.ID' in table 'CDOFields' is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tableCDOFields._SelfWCFCDO_IDColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public int _SelfWCFCDO_Mask
      {
        get
        {
          try
          {
            return (int) this[this.tableCDOFields._SelfWCFCDO_MaskColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'SelfWCFCDO.Mask' in table 'CDOFields' is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tableCDOFields._SelfWCFCDO_MaskColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string _WCFCDOFields_Name
      {
        get
        {
          try
          {
            return (string) this[this.tableCDOFields._WCFCDOFields_NameColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'WCFCDOFields.Name' in table 'CDOFields' is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tableCDOFields._WCFCDOFields_NameColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string _WCFCDOFields_Description
      {
        get
        {
          try
          {
            return (string) this[this.tableCDOFields._WCFCDOFields_DescriptionColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'WCFCDOFields.Description' in table 'CDOFields' is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tableCDOFields._WCFCDOFields_DescriptionColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string FieldDefName
      {
        get
        {
          try
          {
            return (string) this[this.tableCDOFields.FieldDefNameColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'FieldDefName' in table 'CDOFields' is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tableCDOFields.FieldDefNameColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IsList
      {
        get
        {
          try
          {
            return (bool) this[this.tableCDOFields.IsListColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'IsList' in table 'CDOFields' is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tableCDOFields.IsListColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public int Type
      {
        get
        {
          try
          {
            return (int) this[this.tableCDOFields.TypeColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Type' in table 'CDOFields' is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tableCDOFields.TypeColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public int Ownership
      {
        get
        {
          try
          {
            return (int) this[this.tableCDOFields.OwnershipColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Ownership' in table 'CDOFields' is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tableCDOFields.OwnershipColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public int Serialization
      {
        get
        {
          try
          {
            return (int) this[this.tableCDOFields.SerializationColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Serialization' in table 'CDOFields' is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tableCDOFields.SerializationColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public int _WCFCDOFields_ID
      {
        get
        {
          try
          {
            return (int) this[this.tableCDOFields._WCFCDOFields_IDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'WCFCDOFields.ID' in table 'CDOFields' is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tableCDOFields._WCFCDOFields_IDColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public int TypeID
      {
        get
        {
          try
          {
            return (int) this[this.tableCDOFields.TypeIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'TypeID' in table 'CDOFields' is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tableCDOFields.TypeIDColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public int _WCFCDOFields_Mask
      {
        get
        {
          try
          {
            return (int) this[this.tableCDOFields._WCFCDOFields_MaskColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'WCFCDOFields.Mask' in table 'CDOFields' is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tableCDOFields._WCFCDOFields_MaskColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string TypeName
      {
        get
        {
          try
          {
            return (string) this[this.tableCDOFields.TypeNameColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'TypeName' in table 'CDOFields' is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tableCDOFields.TypeNameColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string CDOFieldUsage
      {
        get
        {
          try
          {
            return (string) this[this.tableCDOFields.CDOFieldUsageColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'CDOFieldUsage' in table 'CDOFields' is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tableCDOFields.CDOFieldUsageColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool AllowClientToRead
      {
        get
        {
          try
          {
            return (bool) this[this.tableCDOFields.AllowClientToReadColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'AllowClientToRead' in table 'CDOFields' is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tableCDOFields.AllowClientToReadColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool AllowClientToUpdate
      {
        get
        {
          try
          {
            return (bool) this[this.tableCDOFields.AllowClientToUpdateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'AllowClientToUpdate' in table 'CDOFields' is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tableCDOFields.AllowClientToUpdateColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IsUserDefinedField
      {
        get
        {
          try
          {
            return (bool) this[this.tableCDOFields.IsUserDefinedFieldColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'IsUserDefinedField' in table 'CDOFields' is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tableCDOFields.IsUserDefinedFieldColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public int Required
      {
        get
        {
          try
          {
            return (int) this[this.tableCDOFields.RequiredColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Required' in table 'CDOFields' is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tableCDOFields.RequiredColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string DefaultValue
      {
        get
        {
          try
          {
            return (string) this[this.tableCDOFields.DefaultValueColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'DefaultValue' in table 'CDOFields' is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tableCDOFields.DefaultValueColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public int LabelID
      {
        get
        {
          try
          {
            return (int) this[this.tableCDOFields.LabelIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'LabelID' in table 'CDOFields' is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tableCDOFields.LabelIDColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool CreateOnInitialize
      {
        get
        {
          try
          {
            return (bool) this[this.tableCDOFields.CreateOnInitializeColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'CreateOnInitialize' in table 'CDOFields' is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tableCDOFields.CreateOnInitializeColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public int InheritMask
      {
        get
        {
          try
          {
            return (int) this[this.tableCDOFields.InheritMaskColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'InheritMask' in table 'CDOFields' is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tableCDOFields.InheritMaskColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public int InheritedID
      {
        get
        {
          try
          {
            return (int) this[this.tableCDOFields.InheritedIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'InheritedID' in table 'CDOFields' is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tableCDOFields.InheritedIDColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public int SelValMode
      {
        get
        {
          try
          {
            return (int) this[this.tableCDOFields.SelValModeColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'SelValMode' in table 'CDOFields' is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tableCDOFields.SelValModeColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool Is_SelfWCFCDO_DescriptionNull()
      {
        return this.IsNull(this.tableCDOFields._SelfWCFCDO_DescriptionColumn);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void Set_SelfWCFCDO_DescriptionNull()
      {
        this[this.tableCDOFields._SelfWCFCDO_DescriptionColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool Is_SelfWCFCDO_NameNull()
      {
        return this.IsNull(this.tableCDOFields._SelfWCFCDO_NameColumn);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void Set_SelfWCFCDO_NameNull()
      {
        this[this.tableCDOFields._SelfWCFCDO_NameColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IsParentIDNull()
      {
        return this.IsNull(this.tableCDOFields.ParentIDColumn);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void SetParentIDNull()
      {
        this[this.tableCDOFields.ParentIDColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool Is_SelfWCFCDO_IDNull()
      {
        return this.IsNull(this.tableCDOFields._SelfWCFCDO_IDColumn);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void Set_SelfWCFCDO_IDNull()
      {
        this[this.tableCDOFields._SelfWCFCDO_IDColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool Is_SelfWCFCDO_MaskNull()
      {
        return this.IsNull(this.tableCDOFields._SelfWCFCDO_MaskColumn);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void Set_SelfWCFCDO_MaskNull()
      {
        this[this.tableCDOFields._SelfWCFCDO_MaskColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool Is_WCFCDOFields_NameNull()
      {
        return this.IsNull(this.tableCDOFields._WCFCDOFields_NameColumn);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void Set_WCFCDOFields_NameNull()
      {
        this[this.tableCDOFields._WCFCDOFields_NameColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool Is_WCFCDOFields_DescriptionNull()
      {
        return this.IsNull(this.tableCDOFields._WCFCDOFields_DescriptionColumn);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void Set_WCFCDOFields_DescriptionNull()
      {
        this[this.tableCDOFields._WCFCDOFields_DescriptionColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IsFieldDefNameNull()
      {
        return this.IsNull(this.tableCDOFields.FieldDefNameColumn);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void SetFieldDefNameNull()
      {
        this[this.tableCDOFields.FieldDefNameColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IsIsListNull()
      {
        return this.IsNull(this.tableCDOFields.IsListColumn);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void SetIsListNull()
      {
        this[this.tableCDOFields.IsListColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IsTypeNull()
      {
        return this.IsNull(this.tableCDOFields.TypeColumn);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void SetTypeNull()
      {
        this[this.tableCDOFields.TypeColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IsOwnershipNull()
      {
        return this.IsNull(this.tableCDOFields.OwnershipColumn);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void SetOwnershipNull()
      {
        this[this.tableCDOFields.OwnershipColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IsSerializationNull()
      {
        return this.IsNull(this.tableCDOFields.SerializationColumn);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void SetSerializationNull()
      {
        this[this.tableCDOFields.SerializationColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool Is_WCFCDOFields_IDNull()
      {
        return this.IsNull(this.tableCDOFields._WCFCDOFields_IDColumn);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void Set_WCFCDOFields_IDNull()
      {
        this[this.tableCDOFields._WCFCDOFields_IDColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IsTypeIDNull()
      {
        return this.IsNull(this.tableCDOFields.TypeIDColumn);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void SetTypeIDNull()
      {
        this[this.tableCDOFields.TypeIDColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool Is_WCFCDOFields_MaskNull()
      {
        return this.IsNull(this.tableCDOFields._WCFCDOFields_MaskColumn);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void Set_WCFCDOFields_MaskNull()
      {
        this[this.tableCDOFields._WCFCDOFields_MaskColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IsTypeNameNull()
      {
        return this.IsNull(this.tableCDOFields.TypeNameColumn);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void SetTypeNameNull()
      {
        this[this.tableCDOFields.TypeNameColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IsCDOFieldUsageNull()
      {
        return this.IsNull(this.tableCDOFields.CDOFieldUsageColumn);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void SetCDOFieldUsageNull()
      {
        this[this.tableCDOFields.CDOFieldUsageColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IsAllowClientToReadNull()
      {
        return this.IsNull(this.tableCDOFields.AllowClientToReadColumn);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void SetAllowClientToReadNull()
      {
        this[this.tableCDOFields.AllowClientToReadColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IsAllowClientToUpdateNull()
      {
        return this.IsNull(this.tableCDOFields.AllowClientToUpdateColumn);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void SetAllowClientToUpdateNull()
      {
        this[this.tableCDOFields.AllowClientToUpdateColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IsIsUserDefinedFieldNull()
      {
        return this.IsNull(this.tableCDOFields.IsUserDefinedFieldColumn);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void SetIsUserDefinedFieldNull()
      {
        this[this.tableCDOFields.IsUserDefinedFieldColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IsRequiredNull()
      {
        return this.IsNull(this.tableCDOFields.RequiredColumn);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void SetRequiredNull()
      {
        this[this.tableCDOFields.RequiredColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IsDefaultValueNull()
      {
        return this.IsNull(this.tableCDOFields.DefaultValueColumn);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void SetDefaultValueNull()
      {
        this[this.tableCDOFields.DefaultValueColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IsLabelIDNull()
      {
        return this.IsNull(this.tableCDOFields.LabelIDColumn);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void SetLabelIDNull()
      {
        this[this.tableCDOFields.LabelIDColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IsCreateOnInitializeNull()
      {
        return this.IsNull(this.tableCDOFields.CreateOnInitializeColumn);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void SetCreateOnInitializeNull()
      {
        this[this.tableCDOFields.CreateOnInitializeColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IsInheritMaskNull()
      {
        return this.IsNull(this.tableCDOFields.InheritMaskColumn);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void SetInheritMaskNull()
      {
        this[this.tableCDOFields.InheritMaskColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IsInheritedIDNull()
      {
        return this.IsNull(this.tableCDOFields.InheritedIDColumn);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void SetInheritedIDNull()
      {
        this[this.tableCDOFields.InheritedIDColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IsSelValModeNull()
      {
        return this.IsNull(this.tableCDOFields.SelValModeColumn);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void SetSelValModeNull()
      {
        this[this.tableCDOFields.SelValModeColumn] = Convert.DBNull;
      }
    }

    public class WCFWorkspacesRow : DataRow
    {
      private ModelDataSet.WCFWorkspacesDataTable tableWCFWorkspaces;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      internal WCFWorkspacesRow(DataRowBuilder rb)
        : base(rb)
      {
        this.tableWCFWorkspaces = (ModelDataSet.WCFWorkspacesDataTable) this.Table;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public int Id
      {
        get
        {
          return (int) this[this.tableWCFWorkspaces.IdColumn];
        }
        set
        {
          this[this.tableWCFWorkspaces.IdColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string Code
      {
        get
        {
          try
          {
            return (string) this[this.tableWCFWorkspaces.CodeColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Code' in table 'WCFWorkspaces' is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tableWCFWorkspaces.CodeColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public int Sequence
      {
        get
        {
          try
          {
            return (int) this[this.tableWCFWorkspaces.SequenceColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Sequence' in table 'WCFWorkspaces' is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tableWCFWorkspaces.SequenceColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string Description
      {
        get
        {
          try
          {
            return (string) this[this.tableWCFWorkspaces.DescriptionColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Description' in table 'WCFWorkspaces' is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tableWCFWorkspaces.DescriptionColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string SupportedBy
      {
        get
        {
          return this.IsSupportedByNull() ? string.Empty : (string) this[this.tableWCFWorkspaces.SupportedByColumn];
        }
        set
        {
          this[this.tableWCFWorkspaces.SupportedByColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string Color
      {
        get
        {
          return this.IsColorNull() ? string.Empty : (string) this[this.tableWCFWorkspaces.ColorColumn];
        }
        set
        {
          this[this.tableWCFWorkspaces.ColorColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IsCodeNull()
      {
        return this.IsNull(this.tableWCFWorkspaces.CodeColumn);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void SetCodeNull()
      {
        this[this.tableWCFWorkspaces.CodeColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IsSequenceNull()
      {
        return this.IsNull(this.tableWCFWorkspaces.SequenceColumn);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void SetSequenceNull()
      {
        this[this.tableWCFWorkspaces.SequenceColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IsDescriptionNull()
      {
        return this.IsNull(this.tableWCFWorkspaces.DescriptionColumn);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void SetDescriptionNull()
      {
        this[this.tableWCFWorkspaces.DescriptionColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IsSupportedByNull()
      {
        return this.IsNull(this.tableWCFWorkspaces.SupportedByColumn);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void SetSupportedByNull()
      {
        this[this.tableWCFWorkspaces.SupportedByColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IsColorNull()
      {
        return this.IsNull(this.tableWCFWorkspaces.ColorColumn);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void SetColorNull()
      {
        this[this.tableWCFWorkspaces.ColorColumn] = Convert.DBNull;
      }
    }

    public class UserRow : DataRow
    {
      private ModelDataSet.UserDataTable tableUser;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      internal UserRow(DataRowBuilder rb)
        : base(rb)
      {
        this.tableUser = (ModelDataSet.UserDataTable) this.Table;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string UserName
      {
        get
        {
          return (string) this[this.tableUser.UserNameColumn];
        }
        set
        {
          this[this.tableUser.UserNameColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool AllowUserMode
      {
        get
        {
          try
          {
            return (bool) this[this.tableUser.AllowUserModeColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'AllowUserMode' in table 'User' is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tableUser.AllowUserModeColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool AllowSystemMode
      {
        get
        {
          try
          {
            return (bool) this[this.tableUser.AllowSystemModeColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'AllowSystemMode' in table 'User' is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tableUser.AllowSystemModeColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IsAllowUserModeNull()
      {
        return this.IsNull(this.tableUser.AllowUserModeColumn);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void SetAllowUserModeNull()
      {
        this[this.tableUser.AllowUserModeColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IsAllowSystemModeNull()
      {
        return this.IsNull(this.tableUser.AllowSystemModeColumn);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void SetAllowSystemModeNull()
      {
        this[this.tableUser.AllowSystemModeColumn] = Convert.DBNull;
      }
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public class CDOChildrenRowChangeEvent : EventArgs
    {
      private ModelDataSet.CDOChildrenRow eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public CDOChildrenRowChangeEvent(ModelDataSet.CDOChildrenRow row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public ModelDataSet.CDOChildrenRow Row
      {
        get
        {
          return this.eventRow;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataRowAction Action
      {
        get
        {
          return this.eventAction;
        }
      }
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public class CDOMethodsRowChangeEvent : EventArgs
    {
      private ModelDataSet.CDOMethodsRow eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public CDOMethodsRowChangeEvent(ModelDataSet.CDOMethodsRow row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public ModelDataSet.CDOMethodsRow Row
      {
        get
        {
          return this.eventRow;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataRowAction Action
      {
        get
        {
          return this.eventAction;
        }
      }
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public class CDOFieldsRowChangeEvent : EventArgs
    {
      private ModelDataSet.CDOFieldsRow eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public CDOFieldsRowChangeEvent(ModelDataSet.CDOFieldsRow row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public ModelDataSet.CDOFieldsRow Row
      {
        get
        {
          return this.eventRow;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataRowAction Action
      {
        get
        {
          return this.eventAction;
        }
      }
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public class WCFWorkspacesRowChangeEvent : EventArgs
    {
      private ModelDataSet.WCFWorkspacesRow eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public WCFWorkspacesRowChangeEvent(ModelDataSet.WCFWorkspacesRow row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public ModelDataSet.WCFWorkspacesRow Row
      {
        get
        {
          return this.eventRow;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataRowAction Action
      {
        get
        {
          return this.eventAction;
        }
      }
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public class UserRowChangeEvent : EventArgs
    {
      private ModelDataSet.UserRow eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public UserRowChangeEvent(ModelDataSet.UserRow row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public ModelDataSet.UserRow Row
      {
        get
        {
          return this.eventRow;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataRowAction Action
      {
        get
        {
          return this.eventAction;
        }
      }
    }
  }
}
