// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.WIPMsgKey
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (WIPMsgLabelKey))]
  [KnownType(typeof (WIPMsgOperationKey))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class WIPMsgKey : Subentity
  {
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgKey_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgKey_WIPMsgDetails")]
    protected Camstar.WCF.ObjectStack.WIPMsgDetails[] _WIPMsgDetails;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgKey_IsFrozen")]
    protected Primitive<bool> _IsFrozen;

    public override bool Equals(object obj)
    {
      return obj is WIPMsgKey && object.Equals((object) this._ExportImportKey, (object) ((WIPMsgKey) obj)._ExportImportKey) && (this.CompareArrays((Array) this._WIPMsgDetails, (Array) ((WIPMsgKey) obj)._WIPMsgDetails) && object.Equals((object) this._IsFrozen, (object) ((WIPMsgKey) obj)._IsFrozen)) && base.Equals(obj);
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

    public Camstar.WCF.ObjectStack.WIPMsgDetails[] WIPMsgDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgDetails), (object) value);
      }
      get
      {
        return (Camstar.WCF.ObjectStack.WIPMsgDetails[]) this.PropertyGet(nameof (WIPMsgDetails));
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
