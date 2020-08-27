// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangePackageHeader
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
  public class ChangePackageHeader : ServiceData
  {
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageHeader_StepIcon")]
    protected Primitive<string> _StepIcon;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageHeader_Step")]
    protected Primitive<string> _Step;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageHeader_ChangePackageImportStatus")]
    protected Enumeration<ChangePackageImportStatusEnum, int> _ChangePackageImportStatus;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageHeader_Workflow")]
    protected RevisionedObjectRef _Workflow;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageHeader_ChangePackage")]
    protected NamedObjectRef _ChangePackage;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageHeader_Status")]
    protected Enumeration<PackageStatusEnum, int> _Status;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageHeader_LastUpdatedDate")]
    protected Primitive<DateTime> _LastUpdatedDate;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageHeader_Description")]
    protected Primitive<string> _Description;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageHeader_TargetSystemName")]
    protected Primitive<string> _TargetSystemName;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageHeader_OwnerName")]
    protected Primitive<string> _OwnerName;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageHeader_DocumentSets")]
    protected DocumentSet[] _DocumentSets;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageHeader_Name")]
    protected Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageHeader_Documents")]
    protected NamedSubentityRef[] _Documents;

    public override bool Equals(object obj)
    {
      return obj is ChangePackageHeader && object.Equals((object) this._StepIcon, (object) ((ChangePackageHeader) obj)._StepIcon) && (object.Equals((object) this._Step, (object) ((ChangePackageHeader) obj)._Step) && object.Equals((object) this._ChangePackageImportStatus, (object) ((ChangePackageHeader) obj)._ChangePackageImportStatus)) && (object.Equals((object) this._Workflow, (object) ((ChangePackageHeader) obj)._Workflow) && object.Equals((object) this._ChangePackage, (object) ((ChangePackageHeader) obj)._ChangePackage) && (object.Equals((object) this._Status, (object) ((ChangePackageHeader) obj)._Status) && object.Equals((object) this._LastUpdatedDate, (object) ((ChangePackageHeader) obj)._LastUpdatedDate))) && (object.Equals((object) this._Description, (object) ((ChangePackageHeader) obj)._Description) && object.Equals((object) this._TargetSystemName, (object) ((ChangePackageHeader) obj)._TargetSystemName) && (object.Equals((object) this._OwnerName, (object) ((ChangePackageHeader) obj)._OwnerName) && this.CompareArrays((Array) this._DocumentSets, (Array) ((ChangePackageHeader) obj)._DocumentSets)) && (object.Equals((object) this._Name, (object) ((ChangePackageHeader) obj)._Name) && this.CompareArrays((Array) this._Documents, (Array) ((ChangePackageHeader) obj)._Documents))) && base.Equals(obj);
    }

    public Primitive<string> StepIcon
    {
      [param: In] set
      {
        this.PropertySet(nameof (StepIcon), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (StepIcon));
      }
    }

    public Primitive<string> Step
    {
      [param: In] set
      {
        this.PropertySet(nameof (Step), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Step));
      }
    }

    public Enumeration<ChangePackageImportStatusEnum, int> ChangePackageImportStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangePackageImportStatus), (object) value);
      }
      get
      {
        return (Enumeration<ChangePackageImportStatusEnum, int>) this.PropertyGet(nameof (ChangePackageImportStatus));
      }
    }

    public RevisionedObjectRef Workflow
    {
      [param: In] set
      {
        this.PropertySet(nameof (Workflow), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (Workflow));
      }
    }

    public NamedObjectRef ChangePackage
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangePackage), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ChangePackage));
      }
    }

    public Enumeration<PackageStatusEnum, int> Status
    {
      [param: In] set
      {
        this.PropertySet(nameof (Status), (object) value);
      }
      get
      {
        return (Enumeration<PackageStatusEnum, int>) this.PropertyGet(nameof (Status));
      }
    }

    public Primitive<DateTime> LastUpdatedDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastUpdatedDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (LastUpdatedDate));
      }
    }

    public Primitive<string> Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Description));
      }
    }

    public Primitive<string> TargetSystemName
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetSystemName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (TargetSystemName));
      }
    }

    public Primitive<string> OwnerName
    {
      [param: In] set
      {
        this.PropertySet(nameof (OwnerName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (OwnerName));
      }
    }

    public DocumentSet[] DocumentSets
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentSets), (object) value);
      }
      get
      {
        return (DocumentSet[]) this.PropertyGet(nameof (DocumentSets));
      }
    }

    public Primitive<string> Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Name));
      }
    }

    public NamedSubentityRef[] Documents
    {
      [param: In] set
      {
        this.PropertySet(nameof (Documents), (object) value);
      }
      get
      {
        return (NamedSubentityRef[]) this.PropertyGet(nameof (Documents));
      }
    }
  }
}
