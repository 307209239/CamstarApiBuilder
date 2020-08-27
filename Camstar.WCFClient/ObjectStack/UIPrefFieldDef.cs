// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UIPrefFieldDef
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
  public class UIPrefFieldDef : NamedSubentity
  {
    [DataMember(EmitDefaultValue = false, Name = "UIPrefFieldDef_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "UIPrefFieldDef_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "UIPrefFieldDef_FieldSeq")]
    protected Primitive<int> _FieldSeq;
    [DataMember(EmitDefaultValue = false, Name = "UIPrefFieldDef_IsFrozen")]
    protected new Primitive<bool> _IsFrozen;

    public override bool Equals(object obj)
    {
      return obj is UIPrefFieldDef && object.Equals((object) this._Name, (object) ((UIPrefFieldDef) obj)._Name) && (object.Equals((object) this._ExportImportKey, (object) ((UIPrefFieldDef) obj)._ExportImportKey) && object.Equals((object) this._FieldSeq, (object) ((UIPrefFieldDef) obj)._FieldSeq)) && object.Equals((object) this._IsFrozen, (object) ((UIPrefFieldDef) obj)._IsFrozen) && base.Equals(obj);
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

    public Primitive<int> FieldSeq
    {
      [param: In] set
      {
        this.PropertySet(nameof (FieldSeq), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (FieldSeq));
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
  }
}
