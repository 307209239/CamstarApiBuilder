// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.HistViewDtl
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (HistViewHistMainlineDtl))]
  [Serializable]
  public class HistViewDtl : NamedSubentity
  {
    [DataMember(EmitDefaultValue = false, Name = "HistViewDtl_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "HistViewDtl_UIFields")]
    protected Primitive<string>[] _UIFields;
    [DataMember(EmitDefaultValue = false, Name = "HistViewDtl_Parent")]
    protected BaseObjectRef _Parent;
    [DataMember(EmitDefaultValue = false, Name = "HistViewDtl_IsFrozen")]
    protected new Primitive<bool> _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "HistViewDtl_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is HistViewDtl && object.Equals((object) this._ExportImportKey, (object) ((HistViewDtl) obj)._ExportImportKey) && (this.CompareArrays((Array) this._UIFields, (Array) ((HistViewDtl) obj)._UIFields) && object.Equals((object) this._Parent, (object) ((HistViewDtl) obj)._Parent)) && (object.Equals((object) this._IsFrozen, (object) ((HistViewDtl) obj)._IsFrozen) && object.Equals((object) this._Name, (object) ((HistViewDtl) obj)._Name)) && base.Equals(obj);
    }

    public new Primitive<string> ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public Primitive<string>[] UIFields
    {
      [param: In] set
      {
        this.PropertySet(nameof (UIFields), (object) value);
      }
      get
      {
        return (Primitive<string>[]) this.PropertyGet(nameof (UIFields));
      }
    }

    public BaseObjectRef Parent
    {
      [param: In] set
      {
        this.PropertySet(nameof (Parent), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (Parent));
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
  }
}
