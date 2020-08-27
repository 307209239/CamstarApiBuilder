// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.WIPMsgLabelKey
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
  public class WIPMsgLabelKey : WIPMsgKey
  {
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgLabelKey_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgLabelKey_Label")]
    protected Primitive<string> _Label;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgLabelKey_IsFrozen")]
    protected new Primitive<bool> _IsFrozen;

    public override bool Equals(object obj)
    {
      return obj is WIPMsgLabelKey && object.Equals((object) this._ExportImportKey, (object) ((WIPMsgLabelKey) obj)._ExportImportKey) && (object.Equals((object) this._Label, (object) ((WIPMsgLabelKey) obj)._Label) && object.Equals((object) this._IsFrozen, (object) ((WIPMsgLabelKey) obj)._IsFrozen)) && base.Equals(obj);
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

    public Primitive<string> Label
    {
      [param: In] set
      {
        this.PropertySet(nameof (Label), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Label));
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
