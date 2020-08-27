// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SystemInfoInquiry_Info
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
  public class SystemInfoInquiry_Info : Inquiry_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "SystemInfoInquiry_Info_SystemInfoDetails")]
    protected SystemInfoDetail_Info _SystemInfoDetails;
    [DataMember(EmitDefaultValue = false, Name = "SystemInfoInquiry_Info_ActiveWorkspaces")]
    protected WorkspaceDetail_Info _ActiveWorkspaces;

    public SystemInfoDetail_Info SystemInfoDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (SystemInfoDetails), (object) value);
      }
      get
      {
        return (SystemInfoDetail_Info) this.PropertyGet(nameof (SystemInfoDetails));
      }
    }

    public WorkspaceDetail_Info ActiveWorkspaces
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActiveWorkspaces), (object) value);
      }
      get
      {
        return (WorkspaceDetail_Info) this.PropertyGet(nameof (ActiveWorkspaces));
      }
    }
  }
}
