// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UITargetLink
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
  public class UITargetLink : Subentity
  {
    [DataMember(EmitDefaultValue = false, Name = "UITargetLink_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "UITargetLink_TargetMember")]
    protected Primitive<string> _TargetMember;
    [DataMember(EmitDefaultValue = false, Name = "UITargetLink_SourceMember")]
    protected Primitive<string> _SourceMember;
    [DataMember(EmitDefaultValue = false, Name = "UITargetLink_IsFrozen")]
    protected Primitive<bool> _IsFrozen;

    public override bool Equals(object obj)
    {
      return obj is UITargetLink && object.Equals((object) this._ExportImportKey, (object) ((UITargetLink) obj)._ExportImportKey) && (object.Equals((object) this._TargetMember, (object) ((UITargetLink) obj)._TargetMember) && object.Equals((object) this._SourceMember, (object) ((UITargetLink) obj)._SourceMember)) && object.Equals((object) this._IsFrozen, (object) ((UITargetLink) obj)._IsFrozen) && base.Equals(obj);
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

    public Primitive<string> TargetMember
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetMember), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (TargetMember));
      }
    }

    public Primitive<string> SourceMember
    {
      [param: In] set
      {
        this.PropertySet(nameof (SourceMember), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (SourceMember));
      }
    }

    public Primitive<bool> IsFrozen
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
