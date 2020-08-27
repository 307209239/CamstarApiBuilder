// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangePackageTarget
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
  public class ChangePackageTarget : Subentity
  {
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageTarget_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageTarget_TargetSystemName")]
    protected Primitive<string> _TargetSystemName;

    public override bool Equals(object obj)
    {
      return obj is ChangePackageTarget && object.Equals((object) this._ExportImportKey, (object) ((ChangePackageTarget) obj)._ExportImportKey) && object.Equals((object) this._TargetSystemName, (object) ((ChangePackageTarget) obj)._TargetSystemName) && base.Equals(obj);
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

    public Primitive<string> TargetSystemName
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetSystemName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (TargetSystemName));
      }
    }
  }
}
