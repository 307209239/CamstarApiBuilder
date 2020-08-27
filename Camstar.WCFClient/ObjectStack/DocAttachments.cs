// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DocAttachments
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
  public class DocAttachments : Subentity
  {
    [DataMember(EmitDefaultValue = false, Name = "DocAttachments_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "DocAttachments_Documents")]
    protected AttachedDoc[] _Documents;
    [DataMember(EmitDefaultValue = false, Name = "DocAttachments_IsFrozen")]
    protected Primitive<bool> _IsFrozen;

    public override bool Equals(object obj)
    {
      return obj is DocAttachments && object.Equals((object) this._ExportImportKey, (object) ((DocAttachments) obj)._ExportImportKey) && (this.CompareArrays((Array) this._Documents, (Array) ((DocAttachments) obj)._Documents) && object.Equals((object) this._IsFrozen, (object) ((DocAttachments) obj)._IsFrozen)) && base.Equals(obj);
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

    public AttachedDoc[] Documents
    {
      [param: In] set
      {
        this.PropertySet(nameof (Documents), (object) value);
      }
      get
      {
        return (AttachedDoc[]) this.PropertyGet(nameof (Documents));
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
