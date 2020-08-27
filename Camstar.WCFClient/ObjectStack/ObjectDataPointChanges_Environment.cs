// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ObjectDataPointChanges_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class ObjectDataPointChanges_Environment : DataPointChanges_Environment
  {
    [Metadata("Data Point that calls for identifying an InSite object.", "ObjectDataPointChanges", false, false, false, "NamedSubentityRef", 1049321, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ObjectDataPointChanges_Environment_ListItemToChange")]
    protected new Environment _ListItemToChange;
    [Metadata("QueryType", "QueryTypeEnum", false, false, false, "Integer", 1050374, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ObjectDataPointChanges_Environment_QueryType")]
    protected Environment _QueryType;
    [Metadata("The Insite data type.\r\n1\tInteger\r\n2\tFloat\r\n3              Fixed\r\n4\tString\r\n5\tObject\r\n6\tTimeStamp\r\n7\tBoolean\r\n9\tDecimal\r\n", "DataTypeEnum", false, true, false, "Integer", 1049990, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ObjectDataPointChanges_Environment_DataType")]
    protected new Environment _DataType;
    [DataMember(EmitDefaultValue = false, Name = "ObjectDataPointChanges_Environment_DisplayMode")]
    [Metadata("Identifies the type of the Control Display Mode\r\n1 = DropDown\r\n2 = PickList\r\n4 = None", "ControlDisplayModeEnum", false, false, false, "Integer", 1050521, false, false, true, null)]
    protected Environment _DisplayMode;
    [DataMember(EmitDefaultValue = false, Name = "ObjectDataPointChanges_Environment_ListFieldExpression")]
    [Metadata("Field Expression.", "", false, false, false, "String", 1050878, false, false, false, null)]
    protected Environment _ListFieldExpression;
    [Metadata("The DataPointQueryParam contains a reference to the parameter name and an expression that is evaluated (at collection time) to provide the value for the parameter.", "DataPointQueryParamChanges", false, false, false, "DataPointQueryParamChanges", 1050883, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ObjectDataPointChanges_Environment_DataPointQueryParams")]
    protected DataPointQueryParamChanges_Environment _DataPointQueryParams;
    [DataMember(EmitDefaultValue = false, Name = "ObjectDataPointChanges_Environment_ObjectSelValType")]
    [Metadata("Selection values for the method by which selection values are returned for an ObjectDataType in the DataPointCollectionDef.\r\n0 = None - no selection values are returned.\r\n1 = Static - retrieve all instances of the particular object.\r\n2 = Query - runs the query identified and returns the results.\r\n3 = ListField - returns the entries in the list field identified.\r\n4 = ObjectGroup - this selection values method is only available if the object type selected is of type ObjectGroup (or one of its subclasses).", "ObjectSelValTypeEnum", false, true, false, "Integer", 1050571, false, false, true, null)]
    protected Environment _ObjectSelValType;
    [Metadata("SQL/CDO Query Name", "", false, false, false, "String", 1050378, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ObjectDataPointChanges_Environment_QueryName")]
    protected Environment _QueryName;
    [DataMember(EmitDefaultValue = false, Name = "ObjectDataPointChanges_Environment_ObjectToChange")]
    [Metadata("Data Point that calls for identifying an InSite object.", "ObjectDataPoint", false, false, false, "NamedSubentityRef", 1048682, false, false, false, null)]
    protected new Environment _ObjectToChange;
    [Metadata("CDO Definition Id", "", false, true, false, "Integer", 1050572, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ObjectDataPointChanges_Environment_ObjectType")]
    protected Environment _ObjectType;
    [Metadata("An ObjectGroup is used to provide a list of objects, such as a list of Resources, Products or User Codes of a particular type. These lists are typically used for validation and selection. For example, an Operation includes a reference to a LossCodeGroup. The entries in this list define the valid Loss (reason) Codes for work performed while a Container is at that Operation.\r\n\r\nAn instance of an ObjectGroup includes a list of specific objects and a list of ObjectGroups. This list of objects for any given ObjectGroup is restricted to a specific type (or any of its derived types). Likewise, the list of ObjectGroup s within the ObjectGroup is restricted to the same type (or any of its derived types).\r\n", "ObjectGroup", false, false, false, "NamedObjectRef", 1050873, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ObjectDataPointChanges_Environment_ObjectGroup")]
    protected Environment _ObjectGroup;

    public new Environment ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public Environment QueryType
    {
      [param: In] set
      {
        this.PropertySet(nameof (QueryType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (QueryType));
      }
    }

    public new Environment DataType
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DataType));
      }
    }

    public Environment DisplayMode
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayMode), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DisplayMode));
      }
    }

    public Environment ListFieldExpression
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListFieldExpression), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ListFieldExpression));
      }
    }

    public DataPointQueryParamChanges_Environment DataPointQueryParams
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataPointQueryParams), (object) value);
      }
      get
      {
        return (DataPointQueryParamChanges_Environment) this.PropertyGet(nameof (DataPointQueryParams));
      }
    }

    public Environment ObjectSelValType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectSelValType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectSelValType));
      }
    }

    public Environment QueryName
    {
      [param: In] set
      {
        this.PropertySet(nameof (QueryName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (QueryName));
      }
    }

    public new Environment ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Environment ObjectType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectType));
      }
    }

    public Environment ObjectGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectGroup), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectGroup));
      }
    }
  }
}
