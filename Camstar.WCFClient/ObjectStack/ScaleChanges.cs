// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ScaleChanges
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
  public class ScaleChanges : ResourceChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "ScaleChanges_UOM")]
    protected NamedObjectRef _UOM;
    [DataMember(EmitDefaultValue = false, Name = "ScaleChanges_ChildResources")]
    protected new NamedObjectRef[] _ChildResources;
    [DataMember(EmitDefaultValue = false, Name = "ScaleChanges_ParentResource")]
    protected new NamedObjectRef _ParentResource;
    [DataMember(EmitDefaultValue = false, Name = "ScaleChanges_ResourceFamily")]
    protected new NamedObjectRef _ResourceFamily;
    [DataMember(EmitDefaultValue = false, Name = "ScaleChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ScaleChanges_WorkingRangeMax")]
    protected Primitive<double> _WorkingRangeMax;
    [DataMember(EmitDefaultValue = false, Name = "ScaleChanges_DecimalPrecision")]
    protected Primitive<int> _DecimalPrecision;
    [DataMember(EmitDefaultValue = false, Name = "ScaleChanges_DecimalScale")]
    protected Primitive<int> _DecimalScale;
    [DataMember(EmitDefaultValue = false, Name = "ScaleChanges_WorkingRangeMin")]
    protected Primitive<double> _WorkingRangeMin;
    [DataMember(EmitDefaultValue = false, Name = "ScaleChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is ScaleChanges && object.Equals((object) this._UOM, (object) ((ScaleChanges) obj)._UOM) && (this.CompareArrays((Array) this._ChildResources, (Array) ((ScaleChanges) obj)._ChildResources) && object.Equals((object) this._ParentResource, (object) ((ScaleChanges) obj)._ParentResource)) && (object.Equals((object) this._ResourceFamily, (object) ((ScaleChanges) obj)._ResourceFamily) && object.Equals((object) this._ObjectToChange, (object) ((ScaleChanges) obj)._ObjectToChange) && (object.Equals((object) this._WorkingRangeMax, (object) ((ScaleChanges) obj)._WorkingRangeMax) && object.Equals((object) this._DecimalPrecision, (object) ((ScaleChanges) obj)._DecimalPrecision))) && (object.Equals((object) this._DecimalScale, (object) ((ScaleChanges) obj)._DecimalScale) && object.Equals((object) this._WorkingRangeMin, (object) ((ScaleChanges) obj)._WorkingRangeMin) && object.Equals((object) this._Name, (object) ((ScaleChanges) obj)._Name)) && base.Equals(obj);
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

    public new NamedObjectRef[] ChildResources
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildResources), (object) value);
      }
      get
      {
        return (NamedObjectRef[]) this.PropertyGet(nameof (ChildResources));
      }
    }

    public new NamedObjectRef ParentResource
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParentResource), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ParentResource));
      }
    }

    public new NamedObjectRef ResourceFamily
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceFamily), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ResourceFamily));
      }
    }

    public new NamedObjectRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Primitive<double> WorkingRangeMax
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkingRangeMax), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (WorkingRangeMax));
      }
    }

    public Primitive<int> DecimalPrecision
    {
      [param: In] set
      {
        this.PropertySet(nameof (DecimalPrecision), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (DecimalPrecision));
      }
    }

    public Primitive<int> DecimalScale
    {
      [param: In] set
      {
        this.PropertySet(nameof (DecimalScale), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (DecimalScale));
      }
    }

    public Primitive<double> WorkingRangeMin
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkingRangeMin), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (WorkingRangeMin));
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
