// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ObjectDataPointChanges_Info
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
  public class ObjectDataPointChanges_Info : DataPointChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ObjectDataPointChanges_Info_ListItemToChange")]
    protected new Info _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "ObjectDataPointChanges_Info_QueryType")]
    protected Info _QueryType;
    [DataMember(EmitDefaultValue = false, Name = "ObjectDataPointChanges_Info_DataType")]
    protected new Info _DataType;
    [DataMember(EmitDefaultValue = false, Name = "ObjectDataPointChanges_Info_DisplayMode")]
    protected Info _DisplayMode;
    [DataMember(EmitDefaultValue = false, Name = "ObjectDataPointChanges_Info_ListFieldExpression")]
    protected Info _ListFieldExpression;
    [DataMember(EmitDefaultValue = false, Name = "ObjectDataPointChanges_Info_DataPointQueryParams")]
    protected DataPointQueryParamChanges_Info _DataPointQueryParams;
    [DataMember(EmitDefaultValue = false, Name = "ObjectDataPointChanges_Info_ObjectSelValType")]
    protected Info _ObjectSelValType;
    [DataMember(EmitDefaultValue = false, Name = "ObjectDataPointChanges_Info_QueryName")]
    protected Info _QueryName;
    [DataMember(EmitDefaultValue = false, Name = "ObjectDataPointChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ObjectDataPointChanges_Info_ObjectType")]
    protected Info _ObjectType;
    [DataMember(EmitDefaultValue = false, Name = "ObjectDataPointChanges_Info_ObjectGroup")]
    protected Info _ObjectGroup;

    public new Info ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public Info QueryType
    {
      [param: In] set
      {
        this.PropertySet(nameof (QueryType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (QueryType));
      }
    }

    public new Info DataType
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DataType));
      }
    }

    public Info DisplayMode
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayMode), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DisplayMode));
      }
    }

    public Info ListFieldExpression
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListFieldExpression), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ListFieldExpression));
      }
    }

    public DataPointQueryParamChanges_Info DataPointQueryParams
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataPointQueryParams), (object) value);
      }
      get
      {
        return (DataPointQueryParamChanges_Info) this.PropertyGet(nameof (DataPointQueryParams));
      }
    }

    public Info ObjectSelValType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectSelValType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectSelValType));
      }
    }

    public Info QueryName
    {
      [param: In] set
      {
        this.PropertySet(nameof (QueryName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (QueryName));
      }
    }

    public new Info ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Info ObjectType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectType));
      }
    }

    public Info ObjectGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectGroup), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectGroup));
      }
    }
  }
}
