// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.WIPMsgLabelKey_Info
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
  public class WIPMsgLabelKey_Info : WIPMsgKey_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgLabelKey_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgLabelKey_Info_Label")]
    protected Info _Label;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgLabelKey_Info_IsFrozen")]
    protected new Info _IsFrozen;

    public new Info ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public Info Label
    {
      [param: In] set
      {
        this.PropertySet(nameof (Label), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Label));
      }
    }

    public new Info IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsFrozen));
      }
    }
  }
}
