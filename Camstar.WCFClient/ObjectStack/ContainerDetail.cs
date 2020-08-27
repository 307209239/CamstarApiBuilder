// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ContainerDetail
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
  public class ContainerDetail : Subentity
  {
    [DataMember(EmitDefaultValue = false, Name = "ContainerDetail_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;

    public override bool Equals(object obj)
    {
      return obj is ContainerDetail && object.Equals((object) this._ExportImportKey, (object) ((ContainerDetail) obj)._ExportImportKey) && base.Equals(obj);
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
  }
}
