// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ContentChangeHistoryInquiry_Info
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
  public class ContentChangeHistoryInquiry_Info : ChangePackageInquiry_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ContentChangeHistoryInquiry_Info_InstanceName")]
    protected Info _InstanceName;
    [DataMember(EmitDefaultValue = false, Name = "ContentChangeHistoryInquiry_Info_Headers")]
    protected ModelingAuditTrailHeader_Info _Headers;
    [DataMember(EmitDefaultValue = false, Name = "ContentChangeHistoryInquiry_Info_ChangePackageHeader")]
    protected ChangePackageHeader_Info _ChangePackageHeader;
    [DataMember(EmitDefaultValue = false, Name = "ContentChangeHistoryInquiry_Info_ChangePackage")]
    protected Info _ChangePackage;
    [DataMember(EmitDefaultValue = false, Name = "ContentChangeHistoryInquiry_Info_Instances")]
    protected CPModelingInstanceDtl_Info _Instances;
    [DataMember(EmitDefaultValue = false, Name = "ContentChangeHistoryInquiry_Info_ShowAllPackageHistory")]
    protected Info _ShowAllPackageHistory;
    [DataMember(EmitDefaultValue = false, Name = "ContentChangeHistoryInquiry_Info_StartTimestamp")]
    protected Info _StartTimestamp;
    [DataMember(EmitDefaultValue = false, Name = "ContentChangeHistoryInquiry_Info_ObjectType")]
    protected Info _ObjectType;
    [DataMember(EmitDefaultValue = false, Name = "ContentChangeHistoryInquiry_Info_EndTimestamp")]
    protected Info _EndTimestamp;
    [DataMember(EmitDefaultValue = false, Name = "ContentChangeHistoryInquiry_Info_LastChangeUser")]
    protected Info _LastChangeUser;

    public Info InstanceName
    {
      [param: In] set
      {
        this.PropertySet(nameof (InstanceName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (InstanceName));
      }
    }

    public ModelingAuditTrailHeader_Info Headers
    {
      [param: In] set
      {
        this.PropertySet(nameof (Headers), (object) value);
      }
      get
      {
        return (ModelingAuditTrailHeader_Info) this.PropertyGet(nameof (Headers));
      }
    }

    public ChangePackageHeader_Info ChangePackageHeader
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangePackageHeader), (object) value);
      }
      get
      {
        return (ChangePackageHeader_Info) this.PropertyGet(nameof (ChangePackageHeader));
      }
    }

    public Info ChangePackage
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangePackage), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ChangePackage));
      }
    }

    public CPModelingInstanceDtl_Info Instances
    {
      [param: In] set
      {
        this.PropertySet(nameof (Instances), (object) value);
      }
      get
      {
        return (CPModelingInstanceDtl_Info) this.PropertyGet(nameof (Instances));
      }
    }

    public Info ShowAllPackageHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (ShowAllPackageHistory), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ShowAllPackageHistory));
      }
    }

    public Info StartTimestamp
    {
      [param: In] set
      {
        this.PropertySet(nameof (StartTimestamp), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (StartTimestamp));
      }
    }

    public Info ObjectType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectType));
      }
    }

    public Info EndTimestamp
    {
      [param: In] set
      {
        this.PropertySet(nameof (EndTimestamp), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EndTimestamp));
      }
    }

    public Info LastChangeUser
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastChangeUser), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastChangeUser));
      }
    }
  }
}
