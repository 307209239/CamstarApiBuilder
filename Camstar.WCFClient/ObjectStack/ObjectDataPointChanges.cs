// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ObjectDataPointChanges
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
  public class ObjectDataPointChanges : DataPointChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "ObjectDataPointChanges_ListItemToChange")]
    protected new NamedSubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "ObjectDataPointChanges_QueryType")]
    protected Enumeration<QueryTypeEnum, int> _QueryType;
    [DataMember(EmitDefaultValue = false, Name = "ObjectDataPointChanges_DataType")]
    protected new Enumeration<DataTypeEnum, int> _DataType;
    [DataMember(EmitDefaultValue = false, Name = "ObjectDataPointChanges_DisplayMode")]
    protected Enumeration<ControlDisplayModeEnum, int> _DisplayMode;
    [DataMember(EmitDefaultValue = false, Name = "ObjectDataPointChanges_ListFieldExpression")]
    protected Primitive<string> _ListFieldExpression;
    [DataMember(EmitDefaultValue = false, Name = "ObjectDataPointChanges_DataPointQueryParams")]
    protected DataPointQueryParamChanges[] _DataPointQueryParams;
    [DataMember(EmitDefaultValue = false, Name = "ObjectDataPointChanges_ObjectSelValType")]
    protected Enumeration<ObjectSelValTypeEnum, int> _ObjectSelValType;
    [DataMember(EmitDefaultValue = false, Name = "ObjectDataPointChanges_QueryName")]
    protected Primitive<string> _QueryName;
    [DataMember(EmitDefaultValue = false, Name = "ObjectDataPointChanges_ObjectToChange")]
    protected new NamedSubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ObjectDataPointChanges_ObjectType")]
    protected Primitive<int> _ObjectType;
    [DataMember(EmitDefaultValue = false, Name = "ObjectDataPointChanges_ObjectGroup")]
    protected NamedObjectRef _ObjectGroup;

    public override bool Equals(object obj)
    {
      return obj is ObjectDataPointChanges && object.Equals((object) this._ListItemToChange, (object) ((ObjectDataPointChanges) obj)._ListItemToChange) && (object.Equals((object) this._QueryType, (object) ((ObjectDataPointChanges) obj)._QueryType) && object.Equals((object) this._DataType, (object) ((ObjectDataPointChanges) obj)._DataType)) && (object.Equals((object) this._DisplayMode, (object) ((ObjectDataPointChanges) obj)._DisplayMode) && object.Equals((object) this._ListFieldExpression, (object) ((ObjectDataPointChanges) obj)._ListFieldExpression) && (this.CompareArrays((Array) this._DataPointQueryParams, (Array) ((ObjectDataPointChanges) obj)._DataPointQueryParams) && object.Equals((object) this._ObjectSelValType, (object) ((ObjectDataPointChanges) obj)._ObjectSelValType))) && (object.Equals((object) this._QueryName, (object) ((ObjectDataPointChanges) obj)._QueryName) && object.Equals((object) this._ObjectToChange, (object) ((ObjectDataPointChanges) obj)._ObjectToChange) && (object.Equals((object) this._ObjectType, (object) ((ObjectDataPointChanges) obj)._ObjectType) && object.Equals((object) this._ObjectGroup, (object) ((ObjectDataPointChanges) obj)._ObjectGroup))) && base.Equals(obj);
    }

    public new NamedSubentityRef ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public Enumeration<QueryTypeEnum, int> QueryType
    {
      [param: In] set
      {
        this.PropertySet(nameof (QueryType), (object) value);
      }
      get
      {
        return (Enumeration<QueryTypeEnum, int>) this.PropertyGet(nameof (QueryType));
      }
    }

    public new Enumeration<DataTypeEnum, int> DataType
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataType), (object) value);
      }
      get
      {
        return (Enumeration<DataTypeEnum, int>) this.PropertyGet(nameof (DataType));
      }
    }

    public Enumeration<ControlDisplayModeEnum, int> DisplayMode
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayMode), (object) value);
      }
      get
      {
        return (Enumeration<ControlDisplayModeEnum, int>) this.PropertyGet(nameof (DisplayMode));
      }
    }

    public Primitive<string> ListFieldExpression
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListFieldExpression), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ListFieldExpression));
      }
    }

    public DataPointQueryParamChanges[] DataPointQueryParams
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataPointQueryParams), (object) value);
      }
      get
      {
        return (DataPointQueryParamChanges[]) this.PropertyGet(nameof (DataPointQueryParams));
      }
    }

    public Enumeration<ObjectSelValTypeEnum, int> ObjectSelValType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectSelValType), (object) value);
      }
      get
      {
        return (Enumeration<ObjectSelValTypeEnum, int>) this.PropertyGet(nameof (ObjectSelValType));
      }
    }

    public Primitive<string> QueryName
    {
      [param: In] set
      {
        this.PropertySet(nameof (QueryName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (QueryName));
      }
    }

    public new NamedSubentityRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Primitive<int> ObjectType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectType), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (ObjectType));
      }
    }

    public NamedObjectRef ObjectGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectGroup), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ObjectGroup));
      }
    }
  }
}
