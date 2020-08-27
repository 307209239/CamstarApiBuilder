// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ActivityTemplateDisposition
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
  public class ActivityTemplateDisposition : ActivityTemplate
  {
    [DataMember(EmitDefaultValue = false, Name = "ActivityTemplateDisposition_Disposition")]
    protected NamedObjectRef _Disposition;
    [DataMember(EmitDefaultValue = false, Name = "ActivityTemplateDisposition_DisplayConformingQuantity")]
    protected Primitive<bool> _DisplayConformingQuantity;
    [DataMember(EmitDefaultValue = false, Name = "ActivityTemplateDisposition_ReconcileQuantity")]
    protected Primitive<bool> _ReconcileQuantity;
    [DataMember(EmitDefaultValue = false, Name = "ActivityTemplateDisposition_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is ActivityTemplateDisposition && object.Equals((object) this._Disposition, (object) ((ActivityTemplateDisposition) obj)._Disposition) && (object.Equals((object) this._DisplayConformingQuantity, (object) ((ActivityTemplateDisposition) obj)._DisplayConformingQuantity) && object.Equals((object) this._ReconcileQuantity, (object) ((ActivityTemplateDisposition) obj)._ReconcileQuantity)) && object.Equals((object) this._Name, (object) ((ActivityTemplateDisposition) obj)._Name) && base.Equals(obj);
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
