// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SystemInfoInquiry_Environment
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
  public class SystemInfoInquiry_Environment : Inquiry_Environment
  {
    [Metadata("Contains a system info detail", "SystemInfoDetail", false, false, false, "SystemInfoDetail", 16779302, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "SystemInfoInquiry_Environment_SystemInfoDetails")]
    protected SystemInfoDetail_Environment _SystemInfoDetails;
    [Metadata("Details for a workspace", "WorkspaceDetail", false, false, false, "WorkspaceDetail", 16779299, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "SystemInfoInquiry_Environment_ActiveWorkspaces")]
    protected WorkspaceDetail_Environment _ActiveWorkspaces;

    public SystemInfoDetail_Environment SystemInfoDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (SystemInfoDetails), (object) value);
      }
      get
      {
        return (SystemInfoDetail_Environment) this.PropertyGet(nameof (SystemInfoDetails));
      }
    }

    public WorkspaceDetail_Environment ActiveWorkspaces
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActiveWorkspaces), (object) value);
      }
      get
      {
        return (WorkspaceDetail_Environment) this.PropertyGet(nameof (ActiveWorkspaces));
      }
    }
  }
}
