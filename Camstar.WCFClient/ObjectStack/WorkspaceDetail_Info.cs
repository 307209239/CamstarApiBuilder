// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.WorkspaceDetail_Info
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
  public class WorkspaceDetail_Info : ServiceData_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "WorkspaceDetail_Info_Description")]
    protected Info _Description;
    [DataMember(EmitDefaultValue = false, Name = "WorkspaceDetail_Info_IsActive")]
    protected Info _IsActive;
    [DataMember(EmitDefaultValue = false, Name = "WorkspaceDetail_Info_Prefix")]
    protected Info _Prefix;
    [DataMember(EmitDefaultValue = false, Name = "WorkspaceDetail_Info_Color")]
    protected Info _Color;
    [DataMember(EmitDefaultValue = false, Name = "WorkspaceDetail_Info_SupportedBy")]
    protected Info _SupportedBy;
    [DataMember(EmitDefaultValue = false, Name = "WorkspaceDetail_Info_WorkspaceId")]
    protected Info _WorkspaceId;
    [DataMember(EmitDefaultValue = false, Name = "WorkspaceDetail_Info_Code")]
    protected Info _Code;

    public Info Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Description));
      }
    }

    public Info IsActive
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsActive), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsActive));
      }
    }

    public Info Prefix
    {
      [param: In] set
      {
        this.PropertySet(nameof (Prefix), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Prefix));
      }
    }

    public Info Color
    {
      [param: In] set
      {
        this.PropertySet(nameof (Color), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Color));
      }
    }

    public Info SupportedBy
    {
      [param: In] set
      {
        this.PropertySet(nameof (SupportedBy), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SupportedBy));
      }
    }

    public Info WorkspaceId
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkspaceId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (WorkspaceId));
      }
    }

    public Info Code
    {
      [param: In] set
      {
        this.PropertySet(nameof (Code), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Code));
      }
    }
  }
}
