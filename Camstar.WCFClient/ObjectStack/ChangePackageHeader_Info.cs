// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangePackageHeader_Info
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
  public class ChangePackageHeader_Info : ServiceData_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageHeader_Info_StepIcon")]
    protected Info _StepIcon;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageHeader_Info_Step")]
    protected Info _Step;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageHeader_Info_ChangePackageImportStatus")]
    protected Info _ChangePackageImportStatus;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageHeader_Info_Workflow")]
    protected Info _Workflow;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageHeader_Info_ChangePackage")]
    protected Info _ChangePackage;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageHeader_Info_Status")]
    protected Info _Status;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageHeader_Info_LastUpdatedDate")]
    protected Info _LastUpdatedDate;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageHeader_Info_Description")]
    protected Info _Description;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageHeader_Info_TargetSystemName")]
    protected Info _TargetSystemName;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageHeader_Info_OwnerName")]
    protected Info _OwnerName;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageHeader_Info_DocumentSets")]
    protected DocumentSet_Info _DocumentSets;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageHeader_Info_Name")]
    protected Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageHeader_Info_Documents")]
    protected Info _Documents;

    public Info StepIcon
    {
      [param: In] set
      {
        this.PropertySet(nameof (StepIcon), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (StepIcon));
      }
    }

    public Info Step
    {
      [param: In] set
      {
        this.PropertySet(nameof (Step), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Step));
      }
    }

    public Info ChangePackageImportStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangePackageImportStatus), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ChangePackageImportStatus));
      }
    }

    public Info Workflow
    {
      [param: In] set
      {
        this.PropertySet(nameof (Workflow), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Workflow));
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

    public Info Status
    {
      [param: In] set
      {
        this.PropertySet(nameof (Status), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Status));
      }
    }

    public Info LastUpdatedDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastUpdatedDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastUpdatedDate));
      }
    }

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

    public Info TargetSystemName
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetSystemName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TargetSystemName));
      }
    }

    public Info OwnerName
    {
      [param: In] set
      {
        this.PropertySet(nameof (OwnerName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OwnerName));
      }
    }

    public DocumentSet_Info DocumentSets
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentSets), (object) value);
      }
      get
      {
        return (DocumentSet_Info) this.PropertyGet(nameof (DocumentSets));
      }
    }

    public Info Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Name));
      }
    }

    public Info Documents
    {
      [param: In] set
      {
        this.PropertySet(nameof (Documents), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Documents));
      }
    }
  }
}
