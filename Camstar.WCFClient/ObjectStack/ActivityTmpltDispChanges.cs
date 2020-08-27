// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ActivityTmpltDispChanges
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
  public class ActivityTmpltDispChanges : ActivityTemplateChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "ActivityTmpltDispChanges_Disposition")]
    protected NamedObjectRef _Disposition;
    [DataMember(EmitDefaultValue = false, Name = "ActivityTmpltDispChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ActivityTmpltDispChanges_DispositionData")]
    protected DispositionDataChanges[] _DispositionData;
    [DataMember(EmitDefaultValue = false, Name = "ActivityTmpltDispChanges_DisplayConformingQuantity")]
    protected Primitive<bool> _DisplayConformingQuantity;
    [DataMember(EmitDefaultValue = false, Name = "ActivityTmpltDispChanges_ReconcileQuantity")]
    protected Primitive<bool> _ReconcileQuantity;
    [DataMember(EmitDefaultValue = false, Name = "ActivityTmpltDispChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is ActivityTmpltDispChanges && object.Equals((object) this._Disposition, (object) ((ActivityTmpltDispChanges) obj)._Disposition) && (object.Equals((object) this._ObjectToChange, (object) ((ActivityTmpltDispChanges) obj)._ObjectToChange) && this.CompareArrays((Array) this._DispositionData, (Array) ((ActivityTmpltDispChanges) obj)._DispositionData)) && (object.Equals((object) this._DisplayConformingQuantity, (object) ((ActivityTmpltDispChanges) obj)._DisplayConformingQuantity) && object.Equals((object) this._ReconcileQuantity, (object) ((ActivityTmpltDispChanges) obj)._ReconcileQuantity) && object.Equals((object) this._Name, (object) ((ActivityTmpltDispChanges) obj)._Name)) && base.Equals(obj);
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
