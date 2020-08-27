// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.WorkspaceDetail_Environment
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
  public class WorkspaceDetail_Environment : ServiceData_Environment
  {
    [Metadata("LongString", "", false, false, false, "String", 1048678, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "WorkspaceDetail_Environment_Description")]
    protected Environment _Description;
    [DataMember(EmitDefaultValue = false, Name = "WorkspaceDetail_Environment_IsActive")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049952, false, false, false, "0")]
    protected Environment _IsActive;
    [Metadata("Generic String", "", false, false, false, "String", 1051457, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "WorkspaceDetail_Environment_Prefix")]
    protected Environment _Prefix;
    [Metadata("Generic String", "", false, false, false, "String", 16779298, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "WorkspaceDetail_Environment_Color")]
    protected Environment _Color;
    [Metadata("Generic String", "", false, false, false, "String", 16779297, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "WorkspaceDetail_Environment_SupportedBy")]
    protected Environment _SupportedBy;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 16779295, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "WorkspaceDetail_Environment_WorkspaceId")]
    protected Environment _WorkspaceId;
    [Metadata("Generic String", "", false, false, false, "String", 16779296, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "WorkspaceDetail_Environment_Code")]
    protected Environment _Code;

    public Environment Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Description));
      }
    }

    public Environment IsActive
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsActive), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsActive));
      }
    }

    public Environment Prefix
    {
      [param: In] set
      {
        this.PropertySet(nameof (Prefix), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Prefix));
      }
    }

    public Environment Color
    {
      [param: In] set
      {
        this.PropertySet(nameof (Color), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Color));
      }
    }

    public Environment SupportedBy
    {
      [param: In] set
      {
        this.PropertySet(nameof (SupportedBy), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SupportedBy));
      }
    }

    public Environment WorkspaceId
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkspaceId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (WorkspaceId));
      }
    }

    public Environment Code
    {
      [param: In] set
      {
        this.PropertySet(nameof (Code), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Code));
      }
    }
  }
}
