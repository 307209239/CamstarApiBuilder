// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SystemInfoInquiry
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
  public class SystemInfoInquiry : Inquiry
  {
    [DataMember(EmitDefaultValue = false, Name = "SystemInfoInquiry_SystemInfoDetails")]
    protected SystemInfoDetail[] _SystemInfoDetails;
    [DataMember(EmitDefaultValue = false, Name = "SystemInfoInquiry_ActiveWorkspaces")]
    protected WorkspaceDetail[] _ActiveWorkspaces;

    public override bool Equals(object obj)
    {
      return obj is SystemInfoInquiry && this.CompareArrays((Array) this._SystemInfoDetails, (Array) ((SystemInfoInquiry) obj)._SystemInfoDetails) && this.CompareArrays((Array) this._ActiveWorkspaces, (Array) ((SystemInfoInquiry) obj)._ActiveWorkspaces) && base.Equals(obj);
    }

    public SystemInfoDetail[] SystemInfoDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (SystemInfoDetails), (object) value);
      }
      get
      {
        return (SystemInfoDetail[]) this.PropertyGet(nameof (SystemInfoDetails));
      }
    }

    public WorkspaceDetail[] ActiveWorkspaces
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActiveWorkspaces), (object) value);
      }
      get
      {
        return (WorkspaceDetail[]) this.PropertyGet(nameof (ActiveWorkspaces));
      }
    }
  }
}
