// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DataCollectionDefChanges
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
  public class DataCollectionDefChanges : RevisionedObjectChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "DataCollectionDefChanges_ParametricDataControl")]
    protected Primitive<string> _ParametricDataControl;
    [DataMember(EmitDefaultValue = false, Name = "DataCollectionDefChanges_SPCChartDefGroup")]
    protected NamedObjectRef _SPCChartDefGroup;
    [DataMember(EmitDefaultValue = false, Name = "DataCollectionDefChanges_SPCChartDefEntries")]
    protected NamedObjectRef[] _SPCChartDefEntries;
    [DataMember(EmitDefaultValue = false, Name = "DataCollectionDefChanges_SPCChartDefGroupProxy")]
    protected Camstar.WCF.ObjectStack.SPCChartDefGroup _SPCChartDefGroupProxy;
    [DataMember(EmitDefaultValue = false, Name = "DataCollectionDefChanges_WebPart")]
    protected NamedObjectRef _WebPart;
    [DataMember(EmitDefaultValue = false, Name = "DataCollectionDefChanges_Base")]
    protected new RevisionedObjectRef _Base;
    [DataMember(EmitDefaultValue = false, Name = "DataCollectionDefChanges_ParametricDataDefType")]
    protected Primitive<int> _ParametricDataDefType;
    [DataMember(EmitDefaultValue = false, Name = "DataCollectionDefChanges_IsRevOfRcd")]
    protected new Primitive<bool> _IsRevOfRcd;
    [DataMember(EmitDefaultValue = false, Name = "DataCollectionDefChanges_IsFrozen")]
    protected new Primitive<bool> _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "DataCollectionDefChanges_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "DataCollectionDefChanges_ObjectToChange")]
    protected new RevisionedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "DataCollectionDefChanges_ParametricDataDef")]
    protected Primitive<string> _ParametricDataDef;

    public override bool Equals(object obj)
    {
      return obj is DataCollectionDefChanges && object.Equals((object) this._ParametricDataControl, (object) ((DataCollectionDefChanges) obj)._ParametricDataControl) && (object.Equals((object) this._SPCChartDefGroup, (object) ((DataCollectionDefChanges) obj)._SPCChartDefGroup) && this.CompareArrays((Array) this._SPCChartDefEntries, (Array) ((DataCollectionDefChanges) obj)._SPCChartDefEntries)) && (object.Equals((object) this._SPCChartDefGroupProxy, (object) ((DataCollectionDefChanges) obj)._SPCChartDefGroupProxy) && object.Equals((object) this._WebPart, (object) ((DataCollectionDefChanges) obj)._WebPart) && (object.Equals((object) this._Base, (object) ((DataCollectionDefChanges) obj)._Base) && object.Equals((object) this._ParametricDataDefType, (object) ((DataCollectionDefChanges) obj)._ParametricDataDefType))) && (object.Equals((object) this._IsRevOfRcd, (object) ((DataCollectionDefChanges) obj)._IsRevOfRcd) && object.Equals((object) this._IsFrozen, (object) ((DataCollectionDefChanges) obj)._IsFrozen) && (object.Equals((object) this._Name, (object) ((DataCollectionDefChanges) obj)._Name) && object.Equals((object) this._ObjectToChange, (object) ((DataCollectionDefChanges) obj)._ObjectToChange)) && object.Equals((object) this._ParametricDataDef, (object) ((DataCollectionDefChanges) obj)._ParametricDataDef)) && base.Equals(obj);
    }

    public Primitive<string> ParametricDataControl
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParametricDataControl), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ParametricDataControl));
      }
    }

    public NamedObjectRef SPCChartDefGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (SPCChartDefGroup), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (SPCChartDefGroup));
      }
    }

    public NamedObjectRef[] SPCChartDefEntries
    {
      [param: In] set
      {
        this.PropertySet(nameof (SPCChartDefEntries), (object) value);
      }
      get
      {
        return (NamedObjectRef[]) this.PropertyGet(nameof (SPCChartDefEntries));
      }
    }

    public Camstar.WCF.ObjectStack.SPCChartDefGroup SPCChartDefGroupProxy
    {
      [param: In] set
      {
        this.PropertySet(nameof (SPCChartDefGroupProxy), (object) value);
      }
      get
      {
        return (Camstar.WCF.ObjectStack.SPCChartDefGroup) this.PropertyGet(nameof (SPCChartDefGroupProxy));
      }
    }

    public NamedObjectRef WebPart
    {
      [param: In] set
      {
        this.PropertySet(nameof (WebPart), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (WebPart));
      }
    }

    public new RevisionedObjectRef Base
    {
      [param: In] set
      {
        this.PropertySet(nameof (Base), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (Base));
      }
    }

    public Primitive<int> ParametricDataDefType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParametricDataDefType), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (ParametricDataDefType));
      }
    }

    public new Primitive<bool> IsRevOfRcd
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsRevOfRcd), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsRevOfRcd));
      }
    }

    public new Primitive<bool> IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsFrozen));
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

    public new RevisionedObjectRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Primitive<string> ParametricDataDef
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParametricDataDef), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ParametricDataDef));
      }
    }
  }
}
