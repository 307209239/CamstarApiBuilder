// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ActivityDispositionChanges
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
  public class ActivityDispositionChanges : ActivityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "ActivityDispositionChanges_EventFailures")]
    protected SubentityRef[] _EventFailures;
    [DataMember(EmitDefaultValue = false, Name = "ActivityDispositionChanges_AvailableFailures")]
    protected EventFailure[] _AvailableFailures;
    [DataMember(EmitDefaultValue = false, Name = "ActivityDispositionChanges_DispositionData")]
    protected DispositionDataChanges[] _DispositionData;
    [DataMember(EmitDefaultValue = false, Name = "ActivityDispositionChanges_Disposition")]
    protected NamedObjectRef _Disposition;
    [DataMember(EmitDefaultValue = false, Name = "ActivityDispositionChanges_ObjectToChange")]
    protected new NamedSubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ActivityDispositionChanges_ReconcileQuantity")]
    protected Primitive<bool> _ReconcileQuantity;
    [DataMember(EmitDefaultValue = false, Name = "ActivityDispositionChanges_DisplayConformingQuantity")]
    protected Primitive<bool> _DisplayConformingQuantity;
    [DataMember(EmitDefaultValue = false, Name = "ActivityDispositionChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is ActivityDispositionChanges && this.CompareArrays((Array) this._EventFailures, (Array) ((ActivityDispositionChanges) obj)._EventFailures) && (this.CompareArrays((Array) this._AvailableFailures, (Array) ((ActivityDispositionChanges) obj)._AvailableFailures) && this.CompareArrays((Array) this._DispositionData, (Array) ((ActivityDispositionChanges) obj)._DispositionData)) && (object.Equals((object) this._Disposition, (object) ((ActivityDispositionChanges) obj)._Disposition) && object.Equals((object) this._ObjectToChange, (object) ((ActivityDispositionChanges) obj)._ObjectToChange) && (object.Equals((object) this._ReconcileQuantity, (object) ((ActivityDispositionChanges) obj)._ReconcileQuantity) && object.Equals((object) this._DisplayConformingQuantity, (object) ((ActivityDispositionChanges) obj)._DisplayConformingQuantity))) && object.Equals((object) this._Name, (object) ((ActivityDispositionChanges) obj)._Name) && base.Equals(obj);
    }

    public SubentityRef[] EventFailures
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventFailures), (object) value);
      }
      get
      {
        return (SubentityRef[]) this.PropertyGet(nameof (EventFailures));
      }
    }

    public EventFailure[] AvailableFailures
    {
      [param: In] set
      {
        this.PropertySet(nameof (AvailableFailures), (object) value);
      }
      get
      {
        return (EventFailure[]) this.PropertyGet(nameof (AvailableFailures));
      }
    }

    public DispositionDataChanges[] DispositionData
    {
      [param: In] set
      {
        this.PropertySet(nameof (DispositionData), (object) value);
      }
      get
      {
        return (DispositionDataChanges[]) this.PropertyGet(nameof (DispositionData));
      }
    }

    public NamedObjectRef Disposition
    {
      [param: In] set
      {
        this.PropertySet(nameof (Disposition), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Disposition));
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

    public Primitive<bool> ReconcileQuantity
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReconcileQuantity), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ReconcileQuantity));
      }
    }

    public Primitive<bool> DisplayConformingQuantity
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayConformingQuantity), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (DisplayConformingQuantity));
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
