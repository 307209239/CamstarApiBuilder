// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.WIPMsgKey_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (WIPMsgOperationKey_Info))]
  [KnownType(typeof (WIPMsgLabelKey_Info))]
  [Serializable]
  public class WIPMsgKey_Info : Subentity_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgKey_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgKey_Info_WIPMsgDetails")]
    protected WIPMsgDetails_Info _WIPMsgDetails;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgKey_Info_IsFrozen")]
    protected Info _IsFrozen;

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

    public WIPMsgDetails_Info WIPMsgDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgDetails), (object) value);
      }
      get
      {
        return (WIPMsgDetails_Info) this.PropertyGet(nameof (WIPMsgDetails));
      }
    }

    public Info IsFrozen
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
