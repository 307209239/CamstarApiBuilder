// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DataPointCollectionPointChgs
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
  public class DataPointCollectionPointChgs : DataPointChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionPointChgs_UOM")]
    protected NamedObjectRef _UOM;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionPointChgs_Sequence")]
    protected Primitive<int> _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionPointChgs_DataType")]
    protected Enumeration<DataPointCollectionTypeEnum, int> _DataType;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionPointChgs_ListItemToChange")]
    protected new NamedSubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionPointChgs_ObjectToChange")]
    protected new NamedSubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionPointChgs_OuterLowerLimit")]
    protected Primitive<string> _OuterLowerLimit;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionPointChgs_InnerLowerLimit")]
    protected Primitive<string> _InnerLowerLimit;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionPointChgs_OuterUpperLimit")]
    protected Primitive<string> _OuterUpperLimit;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionPointChgs_InnerUpperLimit")]
    protected Primitive<string> _InnerUpperLimit;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionPointChgs_MinimumSamples")]
    protected Primitive<int> _MinimumSamples;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionPointChgs_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is DataPointCollectionPointChgs && object.Equals((object) this._UOM, (object) ((DataPointCollectionPointChgs) obj)._UOM) && (object.Equals((object) this._Sequence, (object) ((DataPointCollectionPointChgs) obj)._Sequence) && object.Equals((object) this._DataType, (object) ((DataPointCollectionPointChgs) obj)._DataType)) && (object.Equals((object) this._ListItemToChange, (object) ((DataPointCollectionPointChgs) obj)._ListItemToChange) && object.Equals((object) this._ObjectToChange, (object) ((DataPointCollectionPointChgs) obj)._ObjectToChange) && (object.Equals((object) this._OuterLowerLimit, (object) ((DataPointCollectionPointChgs) obj)._OuterLowerLimit) && object.Equals((object) this._InnerLowerLimit, (object) ((DataPointCollectionPointChgs) obj)._InnerLowerLimit))) && (object.Equals((object) this._OuterUpperLimit, (object) ((DataPointCollectionPointChgs) obj)._OuterUpperLimit) && object.Equals((object) this._InnerUpperLimit, (object) ((DataPointCollectionPointChgs) obj)._InnerUpperLimit) && (object.Equals((object) this._MinimumSamples, (object) ((DataPointCollectionPointChgs) obj)._MinimumSamples) && object.Equals((object) this._Name, (object) ((DataPointCollectionPointChgs) obj)._Name))) && base.Equals(obj);
    }

    public NamedObjectRef UOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOM), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (UOM));
      }
    }

    public Primitive<int> Sequence
    {
      [param: In] set
      {
        this.PropertySet(nameof (Sequence), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (Sequence));
      }
    }

    public Enumeration<DataPointCollectionTypeEnum, int> DataType
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataType), (object) value);
      }
      get
      {
        return (Enumeration<DataPointCollectionTypeEnum, int>) this.PropertyGet(nameof (DataType));
      }
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

    public Primitive<string> OuterLowerLimit
    {
      [param: In] set
      {
        this.PropertySet(nameof (OuterLowerLimit), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (OuterLowerLimit));
      }
    }

    public Primitive<string> InnerLowerLimit
    {
      [param: In] set
      {
        this.PropertySet(nameof (InnerLowerLimit), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (InnerLowerLimit));
      }
    }

    public Primitive<string> OuterUpperLimit
    {
      [param: In] set
      {
        this.PropertySet(nameof (OuterUpperLimit), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (OuterUpperLimit));
      }
    }

    public Primitive<string> InnerUpperLimit
    {
      [param: In] set
      {
        this.PropertySet(nameof (InnerUpperLimit), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (InnerUpperLimit));
      }
    }

    public Primitive<int> MinimumSamples
    {
      [param: In] set
      {
        this.PropertySet(nameof (MinimumSamples), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (MinimumSamples));
      }
    }

    public new Primitive<string> Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Name));
      }
    }
  }
}
