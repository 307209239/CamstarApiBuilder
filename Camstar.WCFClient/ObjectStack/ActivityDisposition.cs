// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ActivityDisposition
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
  public class ActivityDisposition : Activity
  {
    [DataMember(EmitDefaultValue = false, Name = "ActivityDisposition_EventFailures")]
    protected SubentityRef[] _EventFailures;
    [DataMember(EmitDefaultValue = false, Name = "ActivityDisposition_DispositionData")]
    protected Camstar.WCF.ObjectStack.DispositionData[] _DispositionData;
    [DataMember(EmitDefaultValue = false, Name = "ActivityDisposition_Disposition")]
    protected NamedObjectRef _Disposition;
    [DataMember(EmitDefaultValue = false, Name = "ActivityDisposition_ReconcileQuantity")]
    protected Primitive<bool> _ReconcileQuantity;
    [DataMember(EmitDefaultValue = false, Name = "ActivityDisposition_DisplayConformingQuantity")]
    protected Primitive<bool> _DisplayConformingQuantity;
    [DataMember(EmitDefaultValue = false, Name = "ActivityDisposition_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is ActivityDisposition && this.CompareArrays((Array) this._EventFailures, (Array) ((ActivityDisposition) obj)._EventFailures) && (this.CompareArrays((Array) this._DispositionData, (Array) ((ActivityDisposition) obj)._DispositionData) && object.Equals((object) this._Disposition, (object) ((ActivityDisposition) obj)._Disposition)) && (object.Equals((object) this._ReconcileQuantity, (object) ((ActivityDisposition) obj)._ReconcileQuantity) && object.Equals((object) this._DisplayConformingQuantity, (object) ((ActivityDisposition) obj)._DisplayConformingQuantity) && object.Equals((object) this._Name, (object) ((ActivityDisposition) obj)._Name)) && base.Equals(obj);
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

    public Camstar.WCF.ObjectStack.DispositionData[] DispositionData
    {
      [param: In] set
      {
        this.PropertySet(nameof (DispositionData), (object) value);
      }
      get
      {
        return (Camstar.WCF.ObjectStack.DispositionData[]) this.PropertyGet(nameof (DispositionData));
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
