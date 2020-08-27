// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Subentity
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
  public class Subentity : BaseObject
  {
    [DataMember(EmitDefaultValue = false, Name = "Subentity_ExportImportKey")]
    protected Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "Subentity_DisplayName")]
    protected Primitive<string> _DisplayName;

    public override bool Equals(object obj)
    {
      return obj is Subentity && object.Equals((object) this._ExportImportKey, (object) ((Subentity) obj)._ExportImportKey) && object.Equals((object) this._DisplayName, (object) ((Subentity) obj)._DisplayName) && base.Equals(obj);
    }

    public Primitive<string> ExportImportKey
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

    public Primitive<string> DisplayName
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (DisplayName));
      }
    }
  }
}
